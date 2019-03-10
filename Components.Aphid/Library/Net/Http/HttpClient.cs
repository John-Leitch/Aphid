using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Library.Net.Http
{
    public class HttpClient : IDisposable
    {
        public bool IsConnected { get; private set; }

        public string Host { get; set; }

        public int Port { get; set; }

        public TcpClient TcpClient { get; private set; }

        public Stream Stream { get; private set; }

        public Stream DebugStream { get; set; }

        public HttpClient() => Port = 80;

        private void WriteToStream(byte[] buffer, int offset, int count)
        {
            if (DebugStream != null)
            {
                DebugStream.Write(buffer, offset, count);
                DebugStream.Flush();
            }

            Stream.Write(buffer, offset, count);
        }

        public void Write(HttpRequest request)
        {
            long len = 0;
            Action writeBody = null;

            if (request.Uploads?.Length > 0)
            {
                request.SetMultipart();
            }

            if (!request.IsMultipart)
            {
                if (request.PostValues != null)
                {
                    request.ResetField(HttpField.ContentType, MimeType.FormUrlEncoded);
                    var fvps = FormUrlEncoder.Encode(request.PostValues);
                    var body = Encoding.UTF8.GetBytes(fvps);
                    len = body.Length;
                    writeBody = () => WriteToStream(body, 0, body.Length);
                }
                else
                {
                    len = 0;
                    writeBody = () => { };
                }
            }
            else
            {
                IEnumerable<FormData> formData = null;

                if (request.PostValues != null)
                {
                    formData = request.PostValues
                        .Select(x =>
                        {
                            var d = new FormData(x.Value);
                            d.SetField(
                                HttpField.ContentDisposition,
                                ContentDisposition.FormData + "; name=\"" + x.Field + "\"");
                            d.SetHeader();
                            return d;
                        });
                }

                if (request.Uploads != null)
                {
                    var fileFormData = request.Uploads
                        .Select(x =>
                        {
                            var d = new FormData(x);
                            d.SetField(
                                HttpField.ContentDisposition,
                                ContentDisposition.FormData + "; name=\"" + x.Name + "\"; filename=\"" + x.Filename + "\"");
                            d.SetField(HttpField.ContentType, x.FileMimeType);
                            d.SetHeader();
                            return d;
                        });

                    formData = formData != null ? formData.Concat(fileFormData) : fileFormData;
                }

                if (formData != null)
                {
                    len =
                        (formData.Count() * (request.Boundary.Length + 4)) +
                        (request.Boundary.Length + 6) +
                        formData.Sum(x => x.Header.Length) +
                        (formData.Sum(x => x.StringValue != null ?
                            x.StringValue.Length :
                            x.UploadValue.Stream.Length) + 2);
                    writeBody = () =>
                    {
                        var startBoundary = Encoding.UTF8.GetBytes("--" + request.Boundary + "\r\n");
                        var endOfValue = new[] { (byte)'\r', (byte)'\n' };
                        var endBoundary = Encoding.UTF8.GetBytes("--" + request.Boundary + "--\r\n");
                        foreach (var part in formData)
                        {
                            WriteToStream(startBoundary, 0, startBoundary.Length);
                            var headerBytes = Encoding.UTF8.GetBytes(part.Header);
                            WriteToStream(headerBytes, 0, headerBytes.Length);

                            if (part.StringValue != null)
                            {
                                var buffer = Encoding.UTF8.GetBytes(part.StringValue);
                                WriteToStream(buffer, 0, buffer.Length);
                            }
                            else
                            {
                                part.UploadValue.Stream.Position = 0;
                                part.UploadValue.Stream.CopyTo(Stream);
                            }
                            WriteToStream(endOfValue, 0, endOfValue.Length);
                        }

                        WriteToStream(endBoundary, 0, endBoundary.Length);
                    };
                }
                else
                {
                    writeBody = () => { };
                    len = 0;
                }
            }

            if (request.Method == HttpMethod.Post)
            {
                request.ResetField(HttpField.ContentLength, len);
            }

            if (!request.HasField(HttpField.Host))
            {
                request.ResetField(HttpField.Host, Host);
            }

            var headerStr = request.CreateHeader(Host);
            var header = Encoding.UTF8.GetBytes(headerStr);
            WriteToStream(header, 0, header.Length);
            writeBody();
            Stream.Flush();
        }

        public HttpResponse Read(Stream bodyStream)
        {
            var resp = new HttpResponse { BodyStream = bodyStream };
            var encoder = Encoding.GetEncoding(1252);
            const int bufferSize = 8192;

            var headerBuffer = "";
            var buffer = new byte[bufferSize];
            var endOfHeader = -1;

            while (endOfHeader == -1)
            {
                var bytesRead = Stream.Read(buffer, 0, buffer.Length);

                headerBuffer += encoder.GetString(buffer, 0, bytesRead);

                endOfHeader = headerBuffer.IndexOf("\r\n\r\n");
            }

            var bodyStr = headerBuffer.Substring(endOfHeader + 4);
            buffer = encoder.GetBytes(bodyStr);
            var bodyBytesRead = buffer.Length;
            resp.ParseFields(headerBuffer.Remove(endOfHeader), true);

            if (resp.TryGetInt(HttpField.ContentLength, out var contentLen))
            {
                bodyStream.Write(buffer, 0, buffer.Length);
                buffer = new byte[bufferSize];

                while (bodyBytesRead < contentLen)
                {
                    var bytesRemaining = contentLen - bodyBytesRead;
                    var readSize = buffer.Length < bytesRemaining ? buffer.Length : bytesRemaining;
                    var bytesRead = Stream.Read(buffer, 0, readSize);
                }
            }
            else if (resp.FieldContains(HttpField.TransferEncoding, "chunked"))
            {
                resp.IsChunked = true;
                bodyStream.Write(buffer, 0, buffer.Length);
                buffer = new byte[bufferSize];
                var tailBuffer = new byte[7];

                if (bodyStr.Length != 0)
                {
                    var offset = 7;
                    if (bodyStr.Length >= offset)
                    {
                        for (var i = bodyStr.Length - offset; i < bodyStr.Length; i++)
                        {
                            tailBuffer[i - bodyStr.Length + offset] = (byte)bodyStr[i];
                        }
                    }
                    else
                    {
                        offset -= bodyStr.Length;
                        for (var i = 0; i < bodyStr.Length; i++)
                        {
                            tailBuffer[i + offset] = (byte)bodyStr[i];
                        }
                    }
                }

                if (!bodyStr.EndsWith("0\r\n\r\n"))
                {
                    var bytesRead = 0;
                    do
                    {
                        buffer = new byte[bufferSize];
                        bytesRead = Stream.Read(buffer, 0, buffer.Length);
                        Array.Resize(ref buffer, bytesRead);

                        if (bytesRead < 7)
                        {
                            var tmpTail = new byte[7];

                            Array.Copy(tailBuffer, bytesRead, tmpTail, 0, 7 - bytesRead);
                            Array.Copy(buffer, 0, tmpTail, 7 - bytesRead, bytesRead);
                            tailBuffer = tmpTail;
                        }
                        else
                        {
                            Array.Copy(buffer, bytesRead - 7, tailBuffer, 0, 7);
                        }

                        bodyStream.Write(buffer, 0, bytesRead);
                    } while (tailBuffer[0] != '\r' ||
                        tailBuffer[1] != '\n' ||
                        tailBuffer[2] != '0' ||
                        tailBuffer[3] != '\r' ||
                        tailBuffer[4] != '\n' ||
                        tailBuffer[5] != '\r' ||
                        tailBuffer[6] != '\n');
                }
            }

            bodyStream.Flush();

            return resp;
        }

        public HttpResponse Read() => Read(new MemoryStream());

        public static HttpClient Connect(string host, int port)
        {
            var client = new HttpClient { Host = host, Port = port };
            client.Connect();
            return client;
        }

        public static HttpClient Connect(string host) => Connect(host, 80);

        public void Connect()
        {
            if (IsConnected)
            {
                throw new InvalidOperationException();
            }

            TcpClient = new TcpClient();
            TcpClient.Connect(Host, Port);
            IsConnected = true;
            Stream = TcpClient.GetStream();
        }

        private void Close()
        {
            Stream?.Dispose();

            TcpClient?.Close();
        }

        public void Disconnect()
        {
            if (!IsConnected)
            {
                throw new InvalidOperationException();
            }

            Close();
            IsConnected = false;
        }

        public void Dispose() => Close();
    }
}

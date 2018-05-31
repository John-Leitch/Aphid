using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.External;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Designer.Interfaces;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.VSPackage
{
    [ComVisible(true)]
    [Guid(GuidList.guidAphidPackagePkgString)]
    [ProvideObject(typeof(AphidCodeDomGenerator))]
    [CodeGeneratorRegistration(typeof(AphidCodeDomGenerator), "AphidCodeDomGenerator", "{FAE04EC1-301F-11D3-BF4B-00C04F79EFBC}", GeneratesDesignTimeSource = true)]
    public class AphidCodeDomGenerator : IVsSingleFileGenerator, IObjectWithSite
    {
        private string _code;

        private object site = null;

        private Lazy<CodeDomProvider> codeDomProvider;

        public int DefaultExtension(out string pbstrDefaultExtension)
        {
            pbstrDefaultExtension = "." + codeDomProvider.Value.FileExtension;

            return VSConstants.S_OK;
        }

        public int Generate(
            string wszInputFilePath,
            string bstrInputFileContents,
            string wszDefaultNamespace,
            IntPtr[] rgbOutputFileContents,
            out uint pcbOutput,
            IVsGeneratorProgress pGenerateProgress)
        {
            if (bstrInputFileContents == null)
            {
                throw new ArgumentException(bstrInputFileContents);
            }

            string csOut = null;
            var result = VSConstants.E_FAIL;

            try
            {

                if (AphidBuildInterop.Compile == null)
                {
                    var interpreter = new AphidInterpreter();

                    _code = Path.Combine(
                        Path.GetDirectoryName(typeof(AphidExpression).Assembly.Location),
                        "AphidBuildInterop.alx");

                    interpreter.InterpretFile(_code);
                }

                csOut = AphidBuildInterop.Compile(
                    wszInputFilePath,
                    bstrInputFileContents,
                    wszDefaultNamespace);

                result = VSConstants.S_OK;
            }
            catch (AphidParserException e)
            {
                if (e.UnexpectedToken.TokenType != default(AphidToken).TokenType)
                {
                    var pos = TokenHelper.GetIndexPosition(
                        _code,
                        e.UnexpectedToken.Index);

                    pGenerateProgress.GeneratorError(
                        0,
                        0,
                        ParserErrorMessage.Create(_code, e),
                        pos.Item1 == -1 ? 0xffffffffu : (uint)pos.Item1,
                        pos.Item2 == -1 ? 0xffffffffu : (uint)pos.Item2);
                }
                else
                {
                    WriteError(pGenerateProgress, e, e.Expression);
                }
            }
            catch (AphidLoadScriptException e)
            {
                WriteError(
                    pGenerateProgress,
                    e,
                    e.CurrentExpression ?? e.CurrentStatement);
            }
            catch (AphidRuntimeException e)
            {
                WriteError(
                    pGenerateProgress,
                    e,
                    e.CurrentExpression ?? e.CurrentStatement);
            }
            catch (Exception e)
            {
                WriteError(pGenerateProgress, e);
            }

            var bytes = csOut != null ? csOut.GetBytes() : null;

            if (bytes == null || !bytes.Any())
            {
                rgbOutputFileContents[0] = IntPtr.Zero;
                pcbOutput = 0;
            }
            else
            {
                rgbOutputFileContents[0] = Marshal.AllocCoTaskMem(bytes.Length);
                Marshal.Copy(bytes, 0, rgbOutputFileContents[0], bytes.Length);
                pcbOutput = (uint)bytes.Length;
            }

            //pGenerateProgress.GeneratorError(


            return result;
        }

        private void WriteError(
            IVsGeneratorProgress progress,
            Exception exception,
            AphidExpression expression = null)
        {
            Tuple<int, int> pos;

            if (expression != null && expression.Index > -1)
            {
                pos = TokenHelper.GetIndexPosition(
                    _code,
                    expression.Index);
            }
            else
            {
                pos = Tuple.Create(-1, -1);
            }

            progress.GeneratorError(
                0,
                0,
                exception.ToString(),
                pos.Item1 == -1 ? 0xffffffffu : (uint)pos.Item1,
                pos.Item2 == -1 ? 0xffffffffu : (uint)pos.Item2);
        }

        public void GetSite(ref Guid riid, out IntPtr ppvSite)
        {
            if (site == null)
            {
                Marshal.ThrowExceptionForHR(VSConstants.E_NOINTERFACE);
            }

            // Query for the interface using the site object initially passed to the generator
            var punk = Marshal.GetIUnknownForObject(site);
            int hr = Marshal.QueryInterface(punk, ref riid, out ppvSite);
            Marshal.Release(punk);
            ErrorHandler.ThrowOnFailure(hr);
        }

        public void SetSite(object pUnkSite)
        {
            site = pUnkSite;
            codeDomProvider = new Lazy<CodeDomProvider>(GetCodeDomProvider);
        }

        private CodeDomProvider GetCodeDomProvider()
        {
            var oleServiceProvider = site as Microsoft.VisualStudio.OLE.Interop.IServiceProvider;
            var serviceProvider = new ServiceProvider(oleServiceProvider);
            var provider = (IVSMDCodeDomProvider)serviceProvider.GetService(typeof(IVSMDCodeDomProvider).GUID);

            return provider != null ? (CodeDomProvider)provider.CodeDomProvider : null;
        }
    }
}

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
        private FileInfo _interopScript = new FileInfo(@"c:\source\aphid\Components.Aphid.VSPackage\AphidBuildInterop.alx");

        private DateTime _lastRun;

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
#if RELEASE
                if (AphidBuildInterop.Compile == null)
                {
                    var interpreter = new AphidInterpreter();

                    var interopScript = Path.Combine(
                        Path.GetDirectoryName(typeof(AphidExpression).Assembly.Location),
                        "AphidBuildInterop.alx");

                    interpreter.InterpretFile(interopScript);
                }
#else
                _interopScript.Refresh();

                if (_lastRun < _interopScript.LastWriteTime)
                {
                    _lastRun = DateTime.Now;
                    var interpreter = new AphidInterpreter();
                    interpreter.InterpretFile(_interopScript.FullName);
                }
                
#endif

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
                        bstrInputFileContents,
                        e.UnexpectedToken.Index);

                    pGenerateProgress.GeneratorError(
                        0,
                        0,
                        ParserErrorMessage.Create(bstrInputFileContents, e, false),
                        pos == null || pos.Item1 == -1 ? 0xffffffffu : (uint)pos.Item1,
                        pos == null ||pos.Item2 == -1 ? 0xffffffffu : (uint)pos.Item2);
                }
                else
                {
                    WriteError(
                        pGenerateProgress,
                        bstrInputFileContents,
                        e,
                        e.Expression);
                }
            }
            catch (AphidLoadScriptException e)
            {
                WriteError(
                    pGenerateProgress,
                    bstrInputFileContents,
                    e,
                    e.CurrentExpression ?? e.CurrentStatement);
            }
            catch (AphidRuntimeException e)
            {
                WriteError(
                    pGenerateProgress,
                    bstrInputFileContents,
                    e,
                    e.CurrentExpression ?? e.CurrentStatement);
            }
            catch (Exception e)
            {
                WriteError(
                    pGenerateProgress,
                    bstrInputFileContents,
                    e);
            }

            var bytes = csOut?.GetBytes();

            if (bytes == null || bytes.Length == 0)
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
            string code,
            Exception exception,
            AphidExpression expression = null)
        {
            Tuple<int, int> pos = null;

            if (expression?.Index > -1)
            {
                pos = TokenHelper.GetIndexPosition(
                    code,
                    expression.Index);
            }

            progress.GeneratorError(
                0,
                0,
                exception.ToString(),
                pos == null || pos.Item1 == -1 ? 0xffffffffu : (uint)pos.Item1,
                pos == null || pos.Item2 == -1 ? 0xffffffffu : (uint)pos.Item2);
        }

        public void GetSite(ref Guid riid, out IntPtr ppvSite)
        {
            if (site == null)
            {
                Marshal.ThrowExceptionForHR(VSConstants.E_NOINTERFACE);
            }

            // Query for the interface using the site object initially passed to the generator
            var punk = Marshal.GetIUnknownForObject(site);
            var hr = Marshal.QueryInterface(punk, ref riid, out ppvSite);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.VSPackage
{
    using System;
    using System.Runtime.InteropServices;
    using System.ComponentModel.Design;
    using Microsoft.VisualStudio.Package;
    using Microsoft.VisualStudio.Shell;
    using Microsoft.VisualStudio.OLE.Interop;
    using Microsoft.VisualStudio.TextManager.Interop;

    namespace TestLanguagePackage
    {
        [ProvideService(typeof(AphidLanguageService))]
        [ProvideLanguageExtension(typeof(AphidLanguageService), ".alx")]
        [ProvideLanguageService(
            typeof(AphidLanguageService),
            "Aphid Language",
            0)]
        [Guid("2e5ec861-04b2-4a6c-ad40-8e1e0ee0ceb6")]
        public class AphidPackage : Package, IOleComponent
        {
            private uint _componentID;

            protected override void Initialize()
            {
                base.Initialize();

                IServiceContainer serviceContainer = this as IServiceContainer;
                AphidLanguageService langService = new AphidLanguageService();
                langService.SetSite(this);
                serviceContainer.AddService(typeof(AphidLanguageService), langService, true);
                IOleComponentManager manager = GetService(typeof(SOleComponentManager)) as IOleComponentManager;

                if (_componentID == 0 && manager != null)
                {
                    OLECRINFO[] crinfo = new OLECRINFO[1];
                    crinfo[0].cbSize = (uint)Marshal.SizeOf(typeof(OLECRINFO));
                    crinfo[0].grfcrf = (uint)_OLECRF.olecrfNeedIdleTime | (uint)_OLECRF.olecrfNeedPeriodicIdleTime;
                    crinfo[0].grfcadvf = (uint)_OLECADVF.olecadvfModal |
                        (uint)_OLECADVF.olecadvfRedrawOff |
                        (uint)_OLECADVF.olecadvfWarningsOff;
                    crinfo[0].uIdleTimeInterval = 500;
                    int hr = manager.FRegisterComponent(this, crinfo, out _componentID);
                }
            }

            protected override void Dispose(bool disposing)
            {
                if (_componentID != 0)
                {
                    if (GetService(typeof(SOleComponentManager)) is IOleComponentManager manager)
                    {
                        int hr = manager.FRevokeComponent(_componentID);
                    }
                    _componentID = 0;
                }

                base.Dispose(disposing);
            }

            #region IOleComponent Members

            public int FDoIdle(uint grfidlef)
            {
                var periodic = (grfidlef & (uint)_OLEIDLEF.oleidlefPeriodic) != 0;

                if (GetService(typeof(AphidLanguageService)) is LanguageService service)
                {
                    service.OnIdle(periodic);
                }

                return 0;
            }

            public int FContinueMessageLoop(uint uReason, IntPtr pvLoopData, MSG[] pMsgPeeked)
            {
                return 1;
            }

            public int FPreTranslateMessage(MSG[] pMsg)
            {
                return 0;
            }

            public int FQueryTerminate(int fPromptUser)
            {
                return 1;
            }

            public int FReserved1(uint dwReserved, uint message, IntPtr wParam, IntPtr lParam)
            {
                return 1;
            }

            public IntPtr HwndGetWindow(uint dwWhich, uint dwReserved)
            {
                return IntPtr.Zero;
            }

            public void OnActivationChange(IOleComponent pic, int fSameComponent,
                OLECRINFO[] pcrinfo, int fHostIsActivating, OLECHOSTINFO[] pchostinfo,
                uint dwReserved)
            {
            }

            public void OnAppActivate(int fActive, uint dwOtherThreadID)
            {
            }

            public void OnEnterState(uint uStateID, int fEnter)
            {
            }

            public void OnLoseActivation()
            {
            }

            public void Terminate()
            {
            }

            #endregion
        }
    }
}

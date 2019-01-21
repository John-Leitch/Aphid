using Components.Aphid.TypeSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Library
{
    public class ExecOptions : IAphidBindable
    {
        [AphidProperty("redirect")]
        public bool RedirectOutput { get; set; }

        [AphidProperty("wait")]
        public bool WaitForExit { get; set; }

        [AphidProperty("working")]
        public string Working { get; set; }

        public ExecOptions()
        {
            RedirectOutput = true;
            WaitForExit = true;
        }

        public void OnBinding(AphidObject source)
        {
        }

        public void OnBound(AphidObject source)
        {
        }
    }
}

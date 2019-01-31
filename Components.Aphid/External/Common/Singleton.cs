using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public abstract class Singleton
    {
        public static object Current { get; private set; }

        protected Singleton()
        {
            if (Current != null)
            {
                throw new InvalidOperationException(
                    string.Format("Can only create one instance of '{0}'.", Current.ToString()));
            }

            Current = this;
        }
    }
}

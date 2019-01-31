using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public abstract class Singleton<T>
            where T : Singleton<T>
    {
        public static T Current { get; private set; }

        protected Singleton()
        {
            if (Current != null)
            {
                throw new InvalidOperationException(
                    string.Format("Can only create one instance of '{0}'.", typeof(T)));
            }

            Current = (T)this;
        }
    }
}

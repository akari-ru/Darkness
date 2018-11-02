using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darkness.Utils.Collections
{
    class Registry
    {
        #region Fields
        private static Dictionary<string, object> _reg = new Dictionary<string, object>();
        #endregion

        #region Constructors
        public Registry() { }
        #endregion

        #region Interface
        public void Register(string key, object obj)
        {
            throw new NotImplementedException();
        }

        public bool Unregister(string key)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Methods
        private bool IsKeyUnique(string key)
        {
            if (_reg.ContainsKey(key)) return false;
            return true;
        }
        #endregion

    }
}

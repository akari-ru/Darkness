using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Darkness.UI.View
{
    internal abstract class DockHost : UserControl
    {
        #region Constructor
        public DockHost()
        {
            InitChildren();
        }
        #endregion

        #region DockHost
        protected abstract void InitChildren();
        #endregion
    }
}

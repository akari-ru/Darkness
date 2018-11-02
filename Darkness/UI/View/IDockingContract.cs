using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darkness.UI.View
{
    interface IDockingContract
    {
        #region Drag and Drop - remove .. are overrides of UIElement
        void OnDrag();
        #endregion 
    }
}

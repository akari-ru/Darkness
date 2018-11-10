using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Darkness.UI.View
{
    public abstract class DockContainer : TabControl
    {
        public DockContainer()
        {
            var items = Items;
            foreach (var item in Items)
            {
                Debug.WriteLine("Test Debug.WriteLine()");
            }
        }

        #region UIElement Drag and Drop Overrides

        protected override void OnDragEnter(DragEventArgs e)
        {
            base.OnDragEnter(e);
        }

        protected override void OnDragOver(DragEventArgs e)
        {
            base.OnDragOver(e);
        }

        protected override void OnDragLeave(DragEventArgs e)
        {
            base.OnDragLeave(e);
        }

        protected override void OnDrop(DragEventArgs e)
        {
            base.OnDrop(e);
        }
        #endregion
    }
}

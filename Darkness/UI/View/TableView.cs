using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Darkness.UI.View
{
    public class TableView : ListView
    {
        public new bool AllowDrop => true;

        #region Drag and Drop - Target
        protected override void OnDragEnter(DragEventArgs e)
        {
            Console.WriteLine("OnDragEnter");
            IDataObject data_obj = e.Data;
            foreach (var str in data_obj.GetFormats()) {
                Console.Write(str + " ");
            }
            Console.WriteLine();
            base.OnDragEnter(e);
        }

        protected override void OnDragOver(DragEventArgs e)
        {
            base.OnDragOver(e);
        }

        protected override void OnDragLeave(DragEventArgs e)
        {
            Console.WriteLine("OnDragLeave");
            base.OnDragLeave(e);
        }

        protected override void OnDrop(DragEventArgs e)
        {
            Console.WriteLine("OnDrop");
            base.OnDrop(e);
        }

        protected override void OnGiveFeedback(GiveFeedbackEventArgs e)
        {
            Console.WriteLine("OnGiveFeedback");
            base.OnGiveFeedback(e);
        }

        protected override void OnPreviewGiveFeedback(GiveFeedbackEventArgs e)
        {
            Console.WriteLine("OnPreviewFeedback");
            base.OnPreviewGiveFeedback(e);
        }
        #endregion
    }
}

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
    /// <summary>
    /// Interaction logic for Workspace.xaml
    /// </summary>
    public partial class Workspace : Grid
    {
        DockableWindow _singleDockableWindow;

        public Workspace()
        {
            InitializeComponent();
            this.Background = Brushes.Lime;
        }

        // this one is to test..
        public Workspace(bool split)
        {
            InitializeComponent();
            if (split)
                VerticalWorkspaceSplit();
        }

        #region Workspace Functionality
        private void VerticalWorkspaceSplit()
        {
            var workspace1 = new Workspace(false);
            var workspace2 = new Workspace(false);
            var gridSplitter = new GridSplitter();

            workspace1.Background = Brushes.Aqua;
            workspace2.Background = Brushes.CadetBlue;
            gridSplitter.Background = Brushes.Transparent;

            gridSplitter.Width = 4;
            gridSplitter.Margin = new Thickness(-2, 0, 0, 0);
            gridSplitter.SnapsToDevicePixels = true;
            gridSplitter.VerticalAlignment = VerticalAlignment.Stretch;
            gridSplitter.HorizontalAlignment = HorizontalAlignment.Left;
            gridSplitter.ResizeBehavior = GridResizeBehavior.PreviousAndCurrent;

            ColumnDefinition column1 = new ColumnDefinition();
            ColumnDefinition column2 = new ColumnDefinition();

            ColumnDefinitions.Add(column1);
            ColumnDefinitions.Add(column2);

            SetColumn(workspace1, 0);
            SetColumn(gridSplitter, 1);
            SetColumn(workspace2, 1);

            Children.Add(workspace1);
            Children.Add(workspace2);
            Children.Add(gridSplitter);
        }

        private void HorizontalWorkspaceSplit()
        {
            var workspace1 = new Workspace(false);
            var workspace2 = new Workspace(false);
            var gridSplitter = new GridSplitter();

            workspace1.Background = Brushes.Aqua;
            workspace2.Background = Brushes.CadetBlue;
            gridSplitter.Background = Brushes.Transparent;

            gridSplitter.Width = 4;
            gridSplitter.Margin = new Thickness(0, -2, 0, 0);
            gridSplitter.SnapsToDevicePixels = true;
            gridSplitter.VerticalAlignment = VerticalAlignment.Top;
            gridSplitter.HorizontalAlignment = HorizontalAlignment.Stretch;
            gridSplitter.ResizeBehavior = GridResizeBehavior.PreviousAndCurrent;

            var row1 = new RowDefinition();
            var row2 = new RowDefinition();

            RowDefinitions.Add(row1);
            RowDefinitions.Add(row2);

            SetRow(workspace1, 0);
            SetRow(gridSplitter, 1);
            SetRow(workspace2, 1);

            Children.Add(workspace1);
            Children.Add(workspace2);
            Children.Add(gridSplitter);
        }
        #endregion

        #region Drag and Drop
        protected override void OnDragEnter(DragEventArgs e)
        {
            base.OnDragEnter(e);
        }

        protected override void OnPreviewDragEnter(DragEventArgs e)
        {
            base.OnPreviewDragEnter(e);
        }

        protected override void OnDragOver(DragEventArgs e)
        {
            base.OnDragOver(e);
        }

        protected override void OnPreviewDragOver(DragEventArgs e)
        {
            base.OnPreviewDragOver(e);
        }

        protected override void OnDragLeave(DragEventArgs e)
        {
            base.OnDragLeave(e);
        }

        protected override void OnPreviewDragLeave(DragEventArgs e)
        {
            base.OnPreviewDragLeave(e);
        }

        protected override void OnDrop(DragEventArgs e)
        {
            base.OnDrop(e);
        }

        protected override void OnPreviewDrop(DragEventArgs e)
        {
            base.OnPreviewDrop(e);
        }

        protected override void OnGiveFeedback(GiveFeedbackEventArgs e)
        {
            base.OnGiveFeedback(e);
        }

        protected override void OnPreviewGiveFeedback(GiveFeedbackEventArgs e)
        {
            base.OnPreviewGiveFeedback(e);
        }
        #endregion
    }
}

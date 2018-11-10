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
    internal class HorizontalSplitDockHost : DockHost
    {
        #region DockHost Implementation
        protected override void InitChildren()
        {
            var dockHosterContent = new Grid();
            var workspace1 = new DockContainerDockHost();
            var workspace2 = new DockContainerDockHost();
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

            RowDefinition row1 = new RowDefinition();
            RowDefinition row2 = new RowDefinition();

            dockHosterContent.RowDefinitions.Add(row1);
            dockHosterContent.RowDefinitions.Add(row2);

            Grid.SetRow(workspace1, 0);
            Grid.SetRow(gridSplitter, 1);
            Grid.SetRow(workspace2, 1);

            dockHosterContent.Children.Add(workspace1);
            dockHosterContent.Children.Add(workspace2);
            dockHosterContent.Children.Add(gridSplitter);
            Content = dockHosterContent;
        }
        #endregion
    }
}

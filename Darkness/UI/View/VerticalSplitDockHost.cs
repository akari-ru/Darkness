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
    internal class VerticalSplitDockHost : DockHost
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

            ColumnDefinition column1 = new ColumnDefinition();
            ColumnDefinition column2 = new ColumnDefinition();

            dockHosterContent.ColumnDefinitions.Add(column1);
            dockHosterContent.ColumnDefinitions.Add(column2);

            Grid.SetColumn(workspace1, 0);
            Grid.SetColumn(gridSplitter, 1);
            Grid.SetColumn(workspace2, 1);

            dockHosterContent.Children.Add(workspace1);
            dockHosterContent.Children.Add(workspace2);
            dockHosterContent.Children.Add(gridSplitter);
            Content = dockHosterContent;
        }
        #endregion
    }
}

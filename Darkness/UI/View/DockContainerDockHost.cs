﻿using System;
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
    class DockContainerDockHost : DockHost
    {
        public DockContainerDockHost()
        {
            Background = Brushes.Red;
        }

        public DockContainerDockHost(DockContainer container)
        {
            
        }

        #region DockHost Implementation
        protected override void InitChildren()
        {
            var dockContainer = new StaticDockContainer();
            var dockableWindow = new DockableWindow();
            dockableWindow.Content = new TableView();
            dockContainer.Items.Add(dockableWindow);
            AddChild(dockContainer);
        }
        #endregion

        #region Drag and Drop - Needs to replace itself with SplitDockHosts

        #endregion
    }
}

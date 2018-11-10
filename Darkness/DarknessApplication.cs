using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

using Darkness.UI.ViewModel;

namespace Darkness
{
    // Global aka Static Members
    public partial class DarknessApplication
    {
        private static DarknessApplication _app;  
        public static DarknessApplication App
        {
            get => _app;
            set
            {
                if ( _app != null )
                {
                    throw new Exception("Only one App instance allowed.");
                }
                else
                {
                    _app = value;
                }
            }
        }
    }

    /// <summary>
    /// <see cref="DarknessApplication"/>: IOC Application defining a program instance.
    /// </summary>
    public partial class DarknessApplication
    {
        #region Bindable Properties
        UserControl _mainContent = null;
        public UserControl MainContent => _mainContent;

        Window _mainWindow;
        public Window MainWindow => _mainWindow;

        Func<UserControl> _fetchMainContent;

        // SessionViewModel - Draft.. later only create on demand ..
        private SessionViewModel _sessionViewModel = new SessionViewModel(Darkness.Model.Session.Instance);
        public SessionViewModel SessionViewModel => _sessionViewModel;
        #endregion

        #region Constructors
        private DarknessApplication() { }
        
        // lazy loading
        public DarknessApplication(Func<UserControl> fetchMainContent)
        {
            DarknessApplication.App = this;
            _fetchMainContent = fetchMainContent;
        }

        // pre fetch
        public DarknessApplication(UserControl mainContent)
        {
            // Guards
            if (mainContent == null) throw new ArgumentNullException(mainContent.ToString() + "was null.");

            // TODO: complete guards

            DarknessApplication.App = this;
            _mainContent = mainContent;
        }
        #endregion

        #region Window Services
        public Window RequestMainWindow()
        {
            var newWindow = new MainWindow();
            var windwoSettigns = Settings.Window.Default;
            newWindow.Top = windwoSettigns.Top;
            newWindow.Left = windwoSettigns.Left;
            newWindow.Width = windwoSettigns.Width;
            newWindow.Height = windwoSettigns.Height;
            newWindow.Closing += (sender, e) =>
            {
                var w_settings = Settings.Window.Default;
                var w = sender as Window;
                if (w == null) throw new Exception();
                w_settings.Top = w.Top;
                w_settings.Left = w.Left;
                w_settings.Width = w.Width;
                w_settings.Height = w.Height;
                w_settings.Save();
            };
            return newWindow;
        }
        #endregion

        #region App Events
        public void Application_Startup(object sender, StartupEventArgs e)
        {
            _mainWindow = RequestMainWindow(); // new Darkness.UI.View.BlendWindow();
            _mainContent = _mainContent ?? (_fetchMainContent() ?? throw new Exception("No valid MainContent provided"));
            _mainWindow.DataContext = this;
            _mainWindow.Show();
        }

        public void Application_Exit(object sender, ExitEventArgs e)
        {
            // TODO: Eventually flush Session to file ..
        }
        #endregion
    }
}

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
using System.Windows.Media.Animation;
using System.Diagnostics;
using ProcessWorkLibrary;
using System.Windows.Resources;
using System.IO;

namespace BestProgram4Ever
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel _viewModel;
        private bool _scale;
        System.Windows.Forms.NotifyIcon _ni;
        /////////////////////////////

        public MainWindow()
        {
            InitializeComponent();
            if (SystemParameters.PrimaryScreenWidth > 1400)
                _scale = true;
            else
                _scale = false;
            ScaleTransform();
            _viewModel = new ViewModel();
            _viewModel.AppDispatcherHandler += AppDispatcher;
            this.DataContext = _viewModel;

            mainControl.frameControl.controledPart.MouseLeftButtonDown += MoveWindow;
            mainControl.toTrayControl.controledPart.MouseLeftButtonDown += ToTray;
            mainControl.settingButtonControl.controledPart.MouseLeftButtonDown += OpenSetting;
            mainControl.settingButtonControl.controledPart.MouseRightButtonDown += ScaleTransformClick;
            mainControl.userButton2Control.controledPart.MouseLeftButtonDown += OpenHologram;
            mainControl.userButton1Control.controledPart.MouseLeftButtonDown += OpenChart;
            mainControl.closeButtonControl.controledPart.MouseLeftButtonDown += Window_Closing;
            SetTrayIcon();
            SetCursor();
            NLogger.logger.Info("MainWindow was created");
        }
        
        private void SetCursor()
        {
            Cursor customCursor = new Cursor(
                Application.GetResourceStream(new Uri("Cursors/NormalSelect.cur", UriKind.Relative)).Stream
                );
            this.Cursor = customCursor;
        }

        private void SetTrayIcon()
        {
            _ni = new System.Windows.Forms.NotifyIcon();
            _ni.Icon = new System.Drawing.Icon("Icon1.ico");
            _ni.Visible = true;
            _ni.DoubleClick +=
                delegate (object sender, EventArgs args)
                {
                    this.Show();
                    this.WindowState = WindowState.Normal;
                };
        }

        private void ScaleTransformClick(object sender, MouseButtonEventArgs e)
        {
            ScaleTransform();
        }

        private void ScaleTransform()
        {
            if (_scale)
            {
                _scale = false;
                ScaleTransform scaleTransform1 = new ScaleTransform(0.3, 0.3);
                mainControl.RenderTransform = scaleTransform1;
            }
            else
            {
                _scale = true;
                ScaleTransform scaleTransform1 = new ScaleTransform(0.25, 0.25);
                mainControl.RenderTransform = scaleTransform1;
            }
        }

        private void OpenHologram(object sender, MouseButtonEventArgs e)
        {
            mainControl.hologramControl.OpenOrCloseHologram();
        }

        private void OpenChart(object sender, MouseButtonEventArgs e)
        {
            if(!this.mainControl.chartContl.workingsAnim)
            {
                this.mainControl.chartContl.OpenOrClose();
            }
        }

        private void OpenSetting(object sender, MouseButtonEventArgs e)
        {
            this.Height = 818.2;
            mainControl.settingsControl.OpenOrCloseSettings();
        }

        private void ToTray(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            this.WindowState = WindowState.Minimized;
        }

        private void MoveWindow(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void AppDispatcher(Action act)
        {
            Application.Current.Dispatcher.BeginInvoke(act);
        }

        private void Window_Closing(object sender, MouseButtonEventArgs e)
        {
            _viewModel.SaveViewModel();
            NLogger.logger.Info("History and Blacllist was saved");
            _ni.Dispose();
            Environment.Exit(0);
        }
    }
}
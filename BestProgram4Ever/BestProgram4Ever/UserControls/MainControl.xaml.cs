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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BestProgram4Ever
{
    /// <summary>
    /// Interaction logic for MainControl.xaml
    /// </summary>
    public partial class MainControl //: UserControl
    {
        private bool _showButton;

        public MainControl()
        {
            _showButton = true;

            InitializeComponent();
            userButton2Control.buttonLabel.Content = "Current";
            userButton1Control.buttonLabel.Content = "Chart";
        }

        private void InfoButtonControl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(!doorControl.doorIsOpen)
            {
                doorControl.OpenAnim();
            }
            DoubleAnimation da = new DoubleAnimation();
            da.From = userButton1Control.Opacity;
            if(!_showButton)
            {
                da.To = 1;
                _showButton = true;
            }
            else
            {
                da.To = 0;
                _showButton = false;
            }

            da.Duration = new Duration(TimeSpan.FromSeconds(1));
            userButton1Control.BeginAnimation(OpacityProperty, da);
            userButton2Control.BeginAnimation(OpacityProperty, da);

        }
    }
}

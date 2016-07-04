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
using System.Media;
using System.IO;

namespace BestProgram4Ever.UserControls
{
    /// <summary>
    /// Interaction logic for DoorControl.xaml
    /// </summary>
    public partial class DoorControl// : UserControl
    {
        public bool doorIsOpen;
        /////////////////

        public DoorControl()
        {
            doorIsOpen = false;
            InitializeComponent();
        }

        public void OpenAnim()
        {
            doorIsOpen = true;
            if (File.Exists("Sounds//squeak4.mp3"))
            {
                MediaPlayer player = new MediaPlayer();
                player.Open(new Uri("Sounds//squeak4.mp3", UriKind.RelativeOrAbsolute));
                player.Play();
            }

            DoubleAnimation da = new DoubleAnimation();
            da.From = 0;
            da.To = -750;
            da.Duration = new Duration(TimeSpan.FromSeconds(1));
            TranslateTransform rt = new TranslateTransform();
            upGate.RenderTransform = rt;
            rt.BeginAnimation(TranslateTransform.YProperty, da);

            DoubleAnimation da1 = new DoubleAnimation();
            da1.From = 0;
            da1.To = 750;
            da1.Duration = new Duration(TimeSpan.FromSeconds(1));
            TranslateTransform rt2 = new TranslateTransform();
            downGate.RenderTransform = rt2;
            da1.Completed += (p, arg) => {
                upGate.IsHitTestVisible = false;
                downGate.IsHitTestVisible = false;
            };
            rt2.BeginAnimation(TranslateTransform.YProperty, da1);

        }

        private void upGate_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(!doorIsOpen)
            {
                OpenAnim();
            }
        }
    }
}

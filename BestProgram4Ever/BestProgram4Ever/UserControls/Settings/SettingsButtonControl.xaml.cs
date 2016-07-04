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

namespace BestProgram4Ever.UserControls
{
    /// <summary>
    /// Interaction logic for SettingsButtonControl.xaml
    /// </summary>
    public partial class SettingsButtonControl //: UserControl
    {
        public SettingsButtonControl()
        {
            InitializeComponent();
        }

        private void controledPart_MouseEnter   (object sender, MouseEventArgs e)
        {
            DoubleAnimation anim = new DoubleAnimation();
            anim.Duration = new Duration(TimeSpan.FromSeconds(2));
            anim.To = -360;
            anim.RepeatBehavior = RepeatBehavior.Forever;
            RotateTransform rotate = new RotateTransform();
            this.buttonImage.RenderTransform = rotate;
            rotate.BeginAnimation(RotateTransform.AngleProperty, anim);
        }

        private void controledPart_MouseLeave   (object sender, MouseEventArgs e)
        {
            DoubleAnimation anim = new DoubleAnimation();
            anim.Duration = new Duration(TimeSpan.FromSeconds(0));
            anim.To = 0;
            RotateTransform rotate = new RotateTransform();
            this.buttonImage.RenderTransform = rotate;
            rotate.BeginAnimation(RotateTransform.AngleProperty, anim);

        }
    }
}

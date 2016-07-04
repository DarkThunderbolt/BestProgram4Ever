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
    /// Interaction logic for SettingsControl.xaml
    /// </summary>
    public partial class SettingsControl //: UserControl
    {
        private bool _settingsOpen;

        public SettingsControl()
        {
            InitializeComponent();
            _settingsOpen = false;
        }      

        public void OpenOrCloseSettings()
        {
            if (_settingsOpen)
            {
                ClosAnim();
            }
            else
            {
                OpenAnim();
            }
        }

        private void OpenAnim()
        {
            _settingsOpen = true;
            
            TransformGroup transforGroup = this.RenderTransform as TransformGroup;
            DoubleAnimation downAnim = new DoubleAnimation();
            TranslateTransform transforDown = new TranslateTransform();
            downAnim.Duration = new Duration(TimeSpan.FromSeconds(1));
            downAnim.From = transforGroup.Value.OffsetY;
            downAnim.To = 750;
            transforDown.Y = 750;
            transforGroup.Children[1] = transforDown;
            transforDown.BeginAnimation(TranslateTransform.YProperty, downAnim);
        }

        private void ClosAnim()
        {
            _settingsOpen = false;

            TransformGroup transforGroup = this.RenderTransform as TransformGroup;
            DoubleAnimation downAnim = new DoubleAnimation();
            TranslateTransform transforDown = new TranslateTransform();
            downAnim.Duration = new Duration(TimeSpan.FromSeconds(1));
            downAnim.From = transforGroup.Value.OffsetY;
            downAnim.To = 0;
            transforDown.Y = 0;
            transforGroup.Children[1] = transforDown;
            transforDown.BeginAnimation(TranslateTransform.YProperty, downAnim);
        }

    }
}

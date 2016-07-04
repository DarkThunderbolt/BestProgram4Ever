using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BestProgram4Ever.UserControls
{
    /// <summary>
    /// Interaction logic for HologramControl.xaml
    /// </summary>
    public partial class HologramControl //: UserControl
    {
        private bool hologramOpen;
        private bool locker;
        MediaPlayer player;

        public HologramControl()
        {
            InitializeComponent();
            locker = false;
            hologramOpen = false;
            player = new MediaPlayer();
        }

        public void OpenOrCloseHologram()
        {
            if(!locker)
            {
                if (hologramOpen)
                {
                    CloseAnimation();
                    hologramOpen = false;
                }
                else
                {
                    OpenAnim();
                    hologramOpen = true;
                }
            }

        }

        private void OpenAnim()
        {
            locker = true;
            if (File.Exists("Sounds//LSwdIgnt.mp3"))
            {

                player.Open(new Uri("Sounds//LSwdIgnt.mp3", UriKind.RelativeOrAbsolute));
                player.Play();
            }

            LinearGradientBrush brush = new LinearGradientBrush();
            brush.StartPoint = new Point(0, 0.5);
            brush.EndPoint = new Point(1, 0.5);
            GradientStop blackStop = new GradientStop(Colors.Black, 0);
            GradientStop transparentStop = new GradientStop(Colors.Transparent, 0);
            brush.GradientStops.Add(blackStop);
            brush.GradientStops.Add(transparentStop);
            hologramFrame.OpacityMask = brush;

            hologramFrame.RegisterName("transparentStop", transparentStop);
            hologramFrame.RegisterName("blackStop", blackStop);

            Duration d = TimeSpan.FromSeconds(0.5);
            Storyboard storyBoard = new Storyboard() { Duration = d };
            DoubleAnimation doubAnim = new DoubleAnimation() { By = 2, Duration = d };
            DoubleAnimation doubAnim2 = new DoubleAnimation() { By = 1, Duration = d };
            storyBoard.Children.Add(doubAnim); storyBoard.Children.Add(doubAnim2);
            Storyboard.SetTargetName(doubAnim, "transparentStop");
            Storyboard.SetTargetName(doubAnim2, "blackStop");
            Storyboard.SetTargetProperty(doubAnim, new PropertyPath("Offset"));
            Storyboard.SetTargetProperty(doubAnim2, new PropertyPath("Offset"));
            storyBoard.Completed += (param, arg) => 
            {
                RadialGradientBrush _brush = new RadialGradientBrush();
                GradientStop _blackStop = new GradientStop(Colors.Black, 1);
                GradientStop _transparentStop = new GradientStop(Colors.Transparent, 1);
                _brush.GradientStops.Add(_blackStop);
                _brush.GradientStops.Add(_transparentStop);
                hologramImage.OpacityMask = _brush;
                hologramImage.RegisterName("_transparentStop", _transparentStop);
                hologramImage.RegisterName("_blackStop", _blackStop);
                Duration _d = TimeSpan.FromSeconds(0.5);
                Storyboard _storyBoard = new Storyboard() { Duration = _d };
                DoubleAnimation _doubAnim = new DoubleAnimation() { By = -2, Duration = _d };
                DoubleAnimation _doubAnim2 = new DoubleAnimation() { By = -1, Duration = _d };
                _storyBoard.Children.Add(_doubAnim);
                _storyBoard.Children.Add(_doubAnim2);
                Storyboard.SetTargetName(_doubAnim, "_transparentStop");
                Storyboard.SetTargetName(_doubAnim2, "_blackStop");
                Storyboard.SetTargetProperty(_doubAnim, new PropertyPath("Offset"));
                Storyboard.SetTargetProperty(_doubAnim2, new PropertyPath("Offset"));
                _storyBoard.Completed += 
                (c, a) =>
                {
                    DoubleAnimation da = new DoubleAnimation();
                    da.From = processessFavoriteList.Opacity;
                    da.To = 1;
                    da.Duration = new Duration(TimeSpan.FromSeconds(0.3));
                    processessFavoriteList.BeginAnimation(OpacityProperty, da);
                    locker = false;
                };
                _storyBoard.Begin(this);
                hologramImage.UnregisterName("_transparentStop");
                hologramImage.UnregisterName("_blackStop");
            };
            storyBoard.Begin(this);

            hologramFrame.UnregisterName("transparentStop");
            hologramFrame.UnregisterName("blackStop");
        }


        private void CloseAnimation()
        {
            locker = true;

            DoubleAnimation da = new DoubleAnimation();
            da.From = processessFavoriteList.Opacity;
            da.To = 0;
            da.Duration = new Duration(TimeSpan.FromSeconds(0.3));
            da.Completed += (c, v) =>
            {
                RadialGradientBrush brush = new RadialGradientBrush();
                GradientStop blackStop = new GradientStop(Colors.Black, 0);
                GradientStop transparentStop = new GradientStop(Colors.Transparent, 0);
                brush.GradientStops.Add(blackStop);
                brush.GradientStops.Add(transparentStop);
                hologramImage.OpacityMask = brush;
                hologramImage.RegisterName("transparentStop", transparentStop);
                hologramImage.RegisterName("blackStop", blackStop);
                Duration d = TimeSpan.FromSeconds(0.5);
                Storyboard storyBoard = new Storyboard() { Duration = d };
                DoubleAnimation doubAnim = new DoubleAnimation() { By = 1, Duration = d };
                DoubleAnimation doubAnim2 = new DoubleAnimation() { By = 2, Duration = d };
                storyBoard.Children.Add(doubAnim); storyBoard.Children.Add(doubAnim2);
                Storyboard.SetTargetName(doubAnim, "transparentStop");
                Storyboard.SetTargetName(doubAnim2, "blackStop");
                Storyboard.SetTargetProperty(doubAnim, new PropertyPath("Offset"));
                Storyboard.SetTargetProperty(doubAnim2, new PropertyPath("Offset"));
                storyBoard.Completed += (param, arg) =>
                {
                    LinearGradientBrush _brush = new LinearGradientBrush();
                    _brush.StartPoint = new Point(0, 0.5);
                    _brush.EndPoint = new Point(1, 0.5);
                    GradientStop _blackStop = new GradientStop(Colors.Black, 1);
                    GradientStop _transparentStop = new GradientStop(Colors.Transparent, 1);
                    _brush.GradientStops.Add(_blackStop);
                    _brush.GradientStops.Add(_transparentStop);
                    hologramFrame.OpacityMask = _brush;

                    hologramFrame.RegisterName("_transparentStop", _transparentStop);
                    hologramFrame.RegisterName("_blackStop", _blackStop);

                    Duration _d = TimeSpan.FromSeconds(0.5);
                    Storyboard _storyBoard = new Storyboard() { Duration = _d };
                    DoubleAnimation _doubAnim = new DoubleAnimation() { By = -1, Duration = _d };
                    DoubleAnimation _doubAnim2 = new DoubleAnimation() { By = -2, Duration = _d };
                    _storyBoard.Children.Add(_doubAnim);
                    _storyBoard.Children.Add(_doubAnim2);
                    Storyboard.SetTargetName(_doubAnim, "_transparentStop");
                    Storyboard.SetTargetName(_doubAnim2, "_blackStop");
                    Storyboard.SetTargetProperty(_doubAnim, new PropertyPath("Offset"));
                    Storyboard.SetTargetProperty(_doubAnim2, new PropertyPath("Offset"));
                    _storyBoard.Completed += (zc, a) => { locker = false; };
                    _storyBoard.Begin(this);

                    hologramFrame.UnregisterName("_transparentStop");
                    hologramFrame.UnregisterName("_blackStop");
                };
                storyBoard.Begin(this);
                hologramImage.UnregisterName("transparentStop");
                hologramImage.UnregisterName("blackStop");
            };
            if (File.Exists("Sounds//LSwdIgnt.mp3"))
            {
                player.Open(new Uri("Sounds//LSwdOff.mp3", UriKind.RelativeOrAbsolute));
                player.Play();
                processessFavoriteList.BeginAnimation(OpacityProperty, da);
            }
        }
    }
}
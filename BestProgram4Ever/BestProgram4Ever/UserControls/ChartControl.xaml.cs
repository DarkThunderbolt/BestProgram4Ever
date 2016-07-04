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

namespace BestProgram4Ever.UserControls
{
    /// <summary>
    /// Interaction logic for ChartControl.xaml
    /// </summary>
    public partial class ChartControl //: UserControl
    {
        private bool _opened;
        public bool workingsAnim;

        public ChartControl()
        {
            InitializeComponent();
            _opened = false;
            workingsAnim = false;
        }

        public void OpenOrClose()
        {
            if(_opened)
            {
                _opened = false;
                Close();
            }
            else
            {
                _opened = true;
                Open();
            }
        }

        private void Open()
        {

            workingsAnim = true;
            DoubleAnimation da = new DoubleAnimation();
            da.From = 90;
            da.To = 0;
            da.Duration = new Duration(TimeSpan.FromSeconds(0.6));
            RotateTransform rt = new RotateTransform();
            chartCanvas.RenderTransform = rt;
            da.Completed += (p, arg) =>
            {
                DoubleAnimation da2 = new DoubleAnimation();
                da2.From = 0;
                da2.To = -731;
                da2.Duration = new Duration(TimeSpan.FromSeconds(0.4));
                TranslateTransform rt2 = new TranslateTransform();
                chartDownPart.RenderTransform = rt2;
                da2.Completed += (pa, ar) => { workingsAnim = false; }; 
                rt2.BeginAnimation(TranslateTransform.XProperty, da2);
            };
            rt.BeginAnimation(RotateTransform.AngleProperty, da);
        }

        private void Close()
        {

            workingsAnim = true;
            DoubleAnimation da = new DoubleAnimation();
            da.From = -731;
            da.To = 0;
            da.Duration = new Duration(TimeSpan.FromSeconds(0.6));
            TranslateTransform rt = new TranslateTransform();
            chartDownPart.RenderTransform = rt;
            da.Completed += (p, arg) =>
            {
                DoubleAnimation da2 = new DoubleAnimation();
                da2.From = 0;
                da2.To = 90;
                da2.Duration = new Duration(TimeSpan.FromSeconds(0.4));
                RotateTransform rt2 = new RotateTransform();
                chartCanvas.RenderTransform = rt2;
                da2.Completed += (pa, ar) => { workingsAnim = false; };
                rt2.BeginAnimation(RotateTransform.AngleProperty, da2);
            };
            rt.BeginAnimation(TranslateTransform.XProperty, da);
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            shownList.ChangeList();
        }
    }
}

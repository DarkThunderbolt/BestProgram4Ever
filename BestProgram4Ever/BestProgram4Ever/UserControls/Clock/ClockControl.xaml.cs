using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Threading;

namespace BestProgram4Ever.UserControls
{
    /// <summary>
    /// Interaction logic for ClockControl.xaml
    /// </summary>
    public partial class ClockControl : INotifyPropertyChanged //: UserControl
    {
        DispatcherTimer timer;
        public DateTime timeNow { get; set; }
        //////////////////////

        public ClockControl()
        {
            InitializeComponent();
            this.DataContext = this;
            timeNow = new DateTime();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1.0);
            timer.Start();
            timer.Tick += 
                new EventHandler(
                    delegate (object s, EventArgs a)
                    {
                        timeNow = DateTime.Now;
                        OnPropertyChanged("timeNow");
                    }
                );
        }
        #region Implement INotyfyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}

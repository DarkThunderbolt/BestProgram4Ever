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

namespace BestProgram4Ever.UserControls
{
    /// <summary>
    /// Interaction logic for ChartListControl.xaml
    /// </summary>
    public partial class ChartListControl //: UserControl
    {
        /// <summary>
        /// true for processNames; 
        /// false for processDates
        /// </summary>
        private bool _swap;
        
        public ChartListControl()
        {
            _swap = true;
            InitializeComponent();
        }
        public void ChangeList()
        {
            if(!_swap)
            {
                _swap = true;
                datesList.SelectedItem = null;
                datesList.Visibility = Visibility.Hidden;
                namesList.Visibility = Visibility.Visible; 

            }
            else
            {
                _swap = false;
                namesList.SelectedItem = null;
                namesList.Visibility = Visibility.Hidden;
                datesList.Visibility = Visibility.Visible;
            }
        }
    }
}

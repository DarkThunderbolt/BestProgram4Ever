using ProcessWorkLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization.Charting;
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
    /// Interaction logic for Chart.xaml
    /// </summary>
    public partial class Chart
    {
        public Chart()
        {
            InitializeComponent();
        }

        private void BarSeries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var viewModel = (ViewModel)DataContext;
            if(viewModel.IsDateChartNow)
            {
                ColumnSeries ps = sender as ColumnSeries;
                if (ps.SelectedItem != null)
                {
                    KeyValuePair<string, float> kvPair = (KeyValuePair<string, float>)(ps.SelectedItem);

                    if (viewModel.SiteCommand.CanExecute(null))
                    {
                        viewModel.SiteCommand.Execute(kvPair.Key);
                    }

                }
            }
        }
    }
}

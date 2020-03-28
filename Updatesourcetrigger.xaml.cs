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
using System.Windows.Shapes;

namespace WpfAdvanceControl
{
    /// <summary>
    /// Interaction logic for Updatesourcetrigger.xaml
    /// </summary>
    public partial class Updatesourcetrigger : Window
    {
        public Updatesourcetrigger()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        private void btnUpdateSource_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression binding = txtWindowTitle.GetBindingExpression(TextBox.TextProperty);
            binding.UpdateSource();
        }

    }
}

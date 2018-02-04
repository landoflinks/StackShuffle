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

namespace StackShuffle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Resets values on the Return tab.
        private void Reset2Button_Click(object sender, RoutedEventArgs e)
        {
            TitleTextBox.Text = "";
            SerialTextBox.Text = "";
            Author2TextBox.Text = "";
            FinishedCheckbox.IsChecked = false;
            NoInterestCheckbox.IsChecked = false;
            NoTimeCheckbox.IsChecked = false;
            DamagedCheckbox.IsChecked = false;
            WrongCheckbox.IsChecked = false;
            OtherCheckbox.IsChecked = false;
            SatisfactionDropDown.SelectedIndex = 0;
            CommentsReturnTextBox.Text = "";
        }
    }
}

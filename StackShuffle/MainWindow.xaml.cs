﻿using System;
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

        // Resets values on the Borrow tab.
        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            // Column 0
            FictionRadioButton.IsChecked = false;
            GenreDropDown.SelectedIndex = -1;
            AgeDropDown.SelectedIndex = -1;
            SCCheckbox.IsChecked = false;
            NudityCheckbox.IsChecked = false;
            ViolenceCheckbox.IsChecked = false;
            ProfanityCheckbox.IsChecked = false;
            ReligiousCheckbox.IsChecked = false;
            NameTextBox.Text = "";
            AddressTextBox.Text = "";
            ProgramDropDown.SelectedIndex = -1;

            // Column 1
            NonFictionRadioButton.IsChecked = false;
            MysteryCheckbox.IsChecked = false;
            RomanceCheckbox.IsChecked = false;
            ComedyCheckbox.IsChecked = false;
            HorrorCheckbox.IsChecked = false;
            AuthorTextBox.Text = "";
            PhysicalRadioButton.IsChecked = false;
            DigitalRadioButton.IsChecked = false;
            PhoneTextBox.Text = "";
            EmailTextBox.Text = "";
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

        // Submit button for the Borrow tab. Currently just throws a test message.
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Test", "Your request has been submitted!");
        }

        // Submit button for the Return tab. Currently just throws a test message.
        private void Submit2Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Test", "Your return has been submitted!");
        }

        private void FictionRadioButton_Click(object sender, RoutedEventArgs e)
        {
            if (NonFictionRadioButton.IsChecked == true)
            {
                NonFictionRadioButton.IsChecked = false;
            }
        }

        private void NonFictionRadioButton_Click(object sender, RoutedEventArgs e)
        {
            if (FictionRadioButton.IsChecked == true)
            {
                FictionRadioButton.IsChecked = false;
            }
        }

        private void PhysicalRadioButton_Click(object sender, RoutedEventArgs e)
        {
            if (DigitalRadioButton.IsChecked == true)
            {
                DigitalRadioButton.IsChecked = false;
            }
        }

        private void DigitalRadioButton_Click(object sender, RoutedEventArgs e)
        {
            if (PhysicalRadioButton.IsChecked == true)
            {
                PhysicalRadioButton.IsChecked = false;
            }
        }
    }
}

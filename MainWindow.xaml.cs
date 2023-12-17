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

namespace WPF_VisualCalculator
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

        public void UpdateTextBox(string input)
        {
            TextBox1.Text += input;
        }

        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            Button but = sender as Button;
            UpdateTextBox(but.Content.ToString());
        }

        private void ClearLast(object sender, RoutedEventArgs e)
        {
            if(TextBox1.Text.Length <= 0) return;
            TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1);
        }

        private void ClearAll(object sender, RoutedEventArgs e)
        {
            TextBox1.Clear();
        }

        private void ButtonClose_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
    }
}

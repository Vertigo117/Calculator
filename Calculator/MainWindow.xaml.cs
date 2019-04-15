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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        float result = 0;
        string operation = "";
        bool enter_value = false;
        

        

        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void numbers_Only(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if (txtDisplay.Text == "0" || (enter_value))
                txtDisplay.Text = "";
            enter_value = false;

            if (button.Content.ToString()==".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + button.Content;
            }
            
            else

            {
                txtDisplay.Text = txtDisplay.Text + button.Content;
            }
        }

       

        private void operators_click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                BtnEquals.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                enter_value = true;
                operation = button.Content.ToString();
                lblShowUp.Content = result + "  " + operation;
            }
            else
            {
                operation = button.Content.ToString();
                result = float.Parse(txtDisplay.Text);
                txtDisplay.Text = "";
                lblShowUp.Content = result + "  " + operation;
            }
        }

        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {
            lblShowUp.Content = "";
            switch(operation)
            {
                case "+":
                    txtDisplay.Text = (result + float.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (result - float.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (result * float.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (result / float.Parse(txtDisplay.Text)).ToString();
                    break;
                default:
                    break;


            }
            result = float.Parse(txtDisplay.Text);
            operation = "";
        }

        private void BtnCE_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void BtnC_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = "0";
            result = 0;
        }

        private void BtnBackspace_Click(object sender, RoutedEventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            if (txtDisplay.Text == "")
                txtDisplay.Text = "0";
        }

        private void BtnPositiveNegative_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = (float.Parse(txtDisplay.Text)*-1).ToString();
        }
    }
}

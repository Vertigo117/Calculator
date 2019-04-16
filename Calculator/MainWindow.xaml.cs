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

        double result = 0;
        string operation = "";
        bool enter_value = false;
        //Stack<string> history = new Stack<string>();
        Stack<string> history = new Stack<string>();
        

        

        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void numbers_Only(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if ((txtDisplay.Text == "0" || (enter_value))&& button.Content.ToString() != ",")
                txtDisplay.Text = "";
            enter_value = false;

            if (button.Content.ToString()==",")
            {
                if (!txtDisplay.Text.Contains(","))
                    txtDisplay.Text = txtDisplay.Text + button.Content;
            }
            
            else

            {
                txtDisplay.Text = txtDisplay.Text + button.Content;
                enter_value = true;
            }
        }

       private void ShowHistory()
        {
            string[] history_array = history.ToArray();
            lblShowUp.Content = "";
            for (int i = history.Count - 1; i >= 0; i--)
            {

                lblShowUp.Content += history_array[i];
            }
        }

        private void operators_click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                if (enter_value)
                {
                    history.Pop();
                    history.Push(button.Content.ToString());
                    operation = button.Content.ToString();
                }
                else
                {
                    history.Push(txtDisplay.Text);
                    history.Push(operation);
                    Calculate();
                }
                
                
                //lblShowUp.Content += txtDisplay.Text + "  " + operation + "  ";
                
                enter_value = true;
                //operation = button.Content.ToString();
                ShowHistory();

            }
            else
            {
                operation = button.Content.ToString();
                try
                {
                    result = double.Parse(txtDisplay.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                history.Push(result.ToString());
                history.Push(operation);
                ShowHistory();


                enter_value = true;
            }
        }

        private void Calculate()
        {
            
            
            switch (operation)
            {
                case "+":
                   
                    result = result + double.Parse(txtDisplay.Text);
                    break;
                case "-":
                    result = result - double.Parse(txtDisplay.Text);
                    break;
                case "×":
                    result = result * double.Parse(txtDisplay.Text);
                    break;
                case "÷":
                    result = result / double.Parse(txtDisplay.Text);
                    break;
                default:
                    break;


            }
            try
            {
                
                txtDisplay.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            operation = "";
        }

        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {
            lblShowUp.Content = "";
            Calculate();
        }

        private void BtnCE_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void BtnC_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = "0";
            lblShowUp.Content = "";
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
            txtDisplay.Text = (double.Parse(txtDisplay.Text)*-1).ToString();
        }

        
    }
}

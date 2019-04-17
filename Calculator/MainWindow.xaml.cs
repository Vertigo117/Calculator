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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double value = 0;
        string operation = "";
        bool enter_value = false;
        //bool operation_changed = false;
        
        LinkedList<string> history = new LinkedList<string>();
        

        

        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void numbers_Only(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if ((txtDisplay.Text == "0" || (!enter_value)) && button.Content.ToString() != ",")
                txtDisplay.Text = "";
            //enter_value = false;

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
            
            lblShowUp.Content = "";
            foreach(string i in history)
            {
                lblShowUp.Content += i;
            }
           
        }

        private void operators_click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            //operation_changed = true;
            //operation = button.Content.ToString();

            if (value != 0)
            {
                if (!enter_value)
                {
                    //    //history.Pop();
                    //    //history.Push(button.Content.ToString());

                    
                    history.RemoveLast();
                    history.AddLast(button.Content.ToString());
                    ShowHistory();
                    //enter_value = true;
                    //operation_changed = false;
                }
                else
                {
                    //history.Push(txtDisplay.Text);
                    //history.Push(operation);
                    operation = history.Last();
                    
                    history.AddLast(txtDisplay.Text);
                    history.AddLast(button.Content.ToString());
                    Calculate();
                    ShowHistory();
                    enter_value = false;
                }


                //lblShowUp.Content += txtDisplay.Text + "  " + operation + "  ";

                //enter_value = true;
                


            }
            else
            {
                history.Clear();
                try
                {
                    value = double.Parse(txtDisplay.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //history.Push(value.ToString());
                //history.Push(operation);
                history.AddLast(txtDisplay.Text);
                history.AddLast(button.Content.ToString());
                
                ShowHistory();
                enter_value = false;

                
            }
        }

        private void Calculate()
        {
            
            
            switch (operation)
            {
                case "+":
                   
                    value = value + double.Parse(txtDisplay.Text);
                    break;
                case "-":
                    value = value - double.Parse(txtDisplay.Text);
                    break;
                case "×":
                    value = value * double.Parse(txtDisplay.Text);
                    break;
                case "÷":
                    value = value / double.Parse(txtDisplay.Text);
                    break;
                default:
                    break;


            }
            try
            {
                
                txtDisplay.Text = value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //operation = "";
        }

        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {
            operation = history.Last();
            lblShowUp.Content = "";
            Calculate();
            value = 0;
            
        }

        private void BtnCE_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void BtnC_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = "0";
            lblShowUp.Content = "";
            history.Clear();
            value = 0;
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

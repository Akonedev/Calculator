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

namespace Calculator;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    double Nb1;
    double Nb2;
    double Total;
    string Operation;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void btn_Click(object sender, RoutedEventArgs e)
    {

    }

    private void btn_Click_7(object sender, RoutedEventArgs e)
    {
        if (result.Text == "0" && result.Text != null)
        {
            result.Text = "7";
        }
        else
        {
            result.Text = result.Text + "7";
        }
    }

    private void btn_Click_8(object sender, RoutedEventArgs e)
    {
        if (result.Text == "0" && result.Text != null)
        {
            result.Text = "8";
        }
        else
        {
            result.Text = result.Text + "8";
        }
    }

    private void btn_Click_9(object sender, RoutedEventArgs e)
    {
        if (result.Text == "" && result.Text != null)
        {
            result.Text = "9";
        }
        else
        {
            result.Text = result.Text + "9";
        }
    }

    private void btn_Click_4(object sender, RoutedEventArgs e)
    {
        if (result.Text == "0" && result.Text != null)
        {
            result.Text = "4";
        }
        else
        {
            result.Text = result.Text + "4";
        }
    }

    private void btn_Click_5(object sender, RoutedEventArgs e)
    {
        if (result.Text == "0" && result.Text != null)
        {
            result.Text = "5";
        }
        else
        {
            result.Text = result.Text + "5";
        }
    }

    private void btn_Click_6(object sender, RoutedEventArgs e)
    {
        if (result.Text == "0" && result.Text != null)
        {
            result.Text = "6";
        }
        else
        {
            result.Text = result.Text + "6";
        }
    }

    private void btn_Click_1(object sender, RoutedEventArgs e)
    {
        if (result.Text == "0" && result.Text != null)
        {
            result.Text = "1";
        }
        else
        {
            result.Text = result.Text + "1";
        }
    }

    private void btn_Click_2(object sender, RoutedEventArgs e)
    {
        if (result.Text == "0" && result.Text != null)
        {
            result.Text = "2";
        }
        else
        {
            result.Text = result.Text + "2";
        }
    }

    private void btn_Click_3(object sender, RoutedEventArgs e)
    {
        if (result.Text == "0" && result.Text != null)
        {
            result.Text = "3";
        }
        else
        {
            result.Text = result.Text + "3";
        }
    }

    private void btn_Click_0(object sender, RoutedEventArgs e)
    {
        if (result.Text == "0" && result.Text != null)
        {
            result.Text = "0";
        }
        else
        {
            result.Text = result.Text + "0";
        }
    }

    private void btn_div_Click(object sender, RoutedEventArgs e)
    {
        Nb1 = Convert.ToDouble(result.Text);
        result.Text = "0";
        Operation = "/";
    }

    private void btn_mult_Click(object sender, RoutedEventArgs e)
    {
        Nb1 = Convert.ToDouble(result.Text);
        result.Text = "0";
        Operation = "*";
    }

    private void btn_moins_Click(object sender, RoutedEventArgs e)
    {
        Nb1 = Convert.ToDouble(result.Text);
        result.Text = "0";
        Operation = "-";
    }

    private void btn_plus_Click(object sender, RoutedEventArgs e)
    {
        Nb1 = Convert.ToDouble(result.Text);
        result.Text = "0";
        Operation = "+";
    }

    private void btn_egal_Click(object sender, RoutedEventArgs e)
    {
  
        Nb2 = Convert.ToDouble(result.Text);

        if (Operation == "+")
        {
            Total = (Nb1 + Nb2);
            result.Text = Convert.ToString(Total);
            Nb1 = Total;
        }
        if (Operation == "-")
        {
            Total = (Nb1 - Nb2);
            result.Text = Convert.ToString(Total);
            Nb1 = Total;
        }
        if (Operation == "*")
        {
            Total = (Nb1 * Nb2);
            result.Text = Convert.ToString(Total);
            Nb1 = Total;
        }
        if (Operation == "/")
        {
            if (Nb2 == 0)
            {
                result.Text = "Cannot divide by zero";

            }
            else
            {
                Total = (Nb1 / Nb2);
                result.Text = Convert.ToString(Total);
                Nb1 = Total;
            }
        }
    }

    private void btn_reset_Click(object sender, RoutedEventArgs e)
    {
        Nb1 = 0;
        Nb2 = 0;
        result.Text = "0";
    }
}
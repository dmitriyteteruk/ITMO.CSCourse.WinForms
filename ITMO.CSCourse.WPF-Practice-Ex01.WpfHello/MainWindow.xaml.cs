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

namespace ITMO.CSCourse.WPF_Practice_Ex01.WpfHello
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			button.IsEnabled = false;           // код из упражнения 01-03
			button1.IsEnabled = false;          // код из упражнения 01-03
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				System.IO.StreamWriter sw = new System.IO.StreamWriter("C:\\Users\\dteteruk\\Documents\\_ITMO\\username.txt");
				sw.WriteLine(textBox.Text);
				sw.Close();
				button1.IsEnabled = true;    // код из упражнения 01-03
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			try
			{
				System.IO.StreamReader sr = new System.IO.StreamReader("C:\\Users\\dteteruk\\Documents\\_ITMO\\username.txt");
				label.Content = "Приветствую Вас, уважаемый " + sr.ReadToEnd();
				sr.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// код из упражнения 01-03
		private void textBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			button.IsEnabled = true;         
		}

		// код из упражнения 01-04
		private void button3_Click(object sender, RoutedEventArgs e)
		{
			myTextBox.Text = DateTime.Now.ToString();   // код из упражнения 01-04
		}
	}
}

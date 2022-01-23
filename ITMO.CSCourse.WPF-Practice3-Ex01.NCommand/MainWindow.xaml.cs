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

namespace ITMO.CSCourse.WPF_Practice3_Ex01.NCommand
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			// код 3-2
			CommandBinding abinding = new CommandBinding();
			abinding.Command = CustomCommands.Launch;
			abinding.Executed += new ExecutedRoutedEventHandler(Launch_Handler);
			abinding.CanExecute += new CanExecuteRoutedEventHandler(LaunchEnabled_Handler);
			this.CommandBindings.Add(abinding);
		}

		// код 3-2
		private void Launch_Handler(object sender, ExecutedRoutedEventArgs e)
		{
			richTextBox.AppendText(textBox.Text);
			using (System.IO.StreamWriter writer = new System.IO.StreamWriter("C:\\Users\\dteteruk\\Documents\\_ITMO\\logs4-2.txt", true))
			{ 
				writer.WriteLine("Внесено {0}: {1} ", textBox.Text, 
					DateTime.Now.ToShortDateString() + ", время: " + 
					DateTime.Now.ToLongTimeString());
				writer.Flush();
			}
		}
		// код 3-2
		private void LaunchEnabled_Handler(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = (bool)checkBox.IsChecked;
		}
	}
}

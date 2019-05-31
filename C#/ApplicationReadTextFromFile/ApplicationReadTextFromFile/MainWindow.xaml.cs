using System;
using Microsoft.Win32;
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
using System.IO;

namespace ApplicationReadTextFromFile
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public string stringText;

		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog find = new OpenFileDialog();
			find.DefaultExt = ".txt";
			find.Filter = "Text Document (.txt)|*.txt";
			if (find.ShowDialog()== true)
			{
				string fileName = find.FileName;
				textBox.Text = fileName;
				char[] delimiterChars = { ' ', ',', '.', ':', ';', '|', '=', '+', '*', '&', '?', '`', '!', '/', '%', '#', '$', '\r', '\n'};

				string[] stringArray = File.ReadAllText(fileName).Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
				stringText = File.ReadAllText(fileName);
				Console.WriteLine();

				// textBoxOutput.Text = File.ReadAllText(fileName);
			}
		}

		private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		private void button2_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog find = new OpenFileDialog();
			find.DefaultExt = ".txt";
			find.Filter = "Text Document (.txt)|*.txt";
			if (find.ShowDialog() == true)
			{
				string fileName = find.FileName;
				textBox2.Text = fileName;
				char[] delimiterChars = { ' ', ',', '.', ':', ';', '|', '=', '+', '*', '&', '?', '`', '!', '/', '%', '#', '$', '\r', '\n' };

				string[] stringArray = File.ReadAllText(fileName).Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
				Console.WriteLine();

				textBoxOutput.Text = File.ReadAllText(fileName) + stringText;
			}
		}
	}
}

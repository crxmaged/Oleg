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
		public string firstText, secondText;
		public string[] firstTextToArray; public string[] secondTextToArray;
		public List<string> sameWord = new List <string>();

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

				firstTextToArray = File.ReadAllText(fileName).Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
				firstText = File.ReadAllText(fileName);
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

				secondTextToArray = File.ReadAllText(fileName).Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
				secondText = File.ReadAllText(fileName);
				Console.WriteLine();

				for (int i = 0; i < firstTextToArray.Length; i++)
				{
					for (int n = 0; n < secondTextToArray.Length; n++)
					{
						if (secondTextToArray[n] == firstTextToArray[i])
						{
							sameWord.Add(secondTextToArray[n] + " " + GetLineNumber(secondText, secondTextToArray[n]));
						}
					}
				}

				sameWord.Sort();

				var result = String.Join(" ", sameWord.ToArray());

				textBoxOutput.Text = result;
			}
		}

		public static int GetLineNumber(string text, string lineToFind, StringComparison comparison = StringComparison.CurrentCulture)
		{
			int lineNum = 0;
			using (StringReader reader = new StringReader(text))
			{
				string line;
				while ((line = reader.ReadLine()) != null)
				{
					lineNum++;
					if (line.Equals(lineToFind, comparison))
						return lineNum;
				}
			}
			return -1;
		}

	}
}

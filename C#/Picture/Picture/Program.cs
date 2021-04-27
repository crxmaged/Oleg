using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Picture.Folder;
using System.IO;

namespace Picture
{
	class Program
	{
		private const double OFFSET = 1.5;
		private const double MAXSET = 500;

		[STAThread] // add atribute for method main
		static void Main(string[] args)
		{
			var openFileDialog = new OpenFileDialog
			{
				Filter = "Images | *.bmp; *.png; *.jpg; *.JPEG"
			};
			// openFileDialog.ShowDialog();
			Console.WriteLine("Press enter to start! \n");

			while(true)
			{
				Console.ReadLine(); // pause stiil antyl push button:"Enter"
				// cycle stop work if bush button OK 
				if (openFileDialog.ShowDialog() != DialogResult.OK)
				{
					continue; // restart cycle
				}
				Console.Clear(); // clear console window before show new image
				var bitmap = new Bitmap(openFileDialog.FileName); // use this constructor for work with picture
																  // System.Drawing.Bitmap
				bitmap = SetReSizeBitmap(bitmap); // Resize picture for console window
				bitmap.BlackGrayWhite(); // This method in Extension class for Bitmap - base class 
				var converPicture = new ConverterASCII(bitmap); // creat object to use convert
				var rowsPicture = converPicture.Convert();
				var rowsPictureForNote = converPicture.ConvertForNote();

				foreach (var pixel in rowsPicture)
				{ // show text array on console
					Console.WriteLine(pixel);
				} // save picture in file txt name: image
				File.WriteAllLines("image.txt", rowsPictureForNote.Select(r => new string(r))); // c# linq lanquage
				Console.SetCursorPosition(0, 0); // set cursor to first pixel of picture
			}
		}

		private static Bitmap SetReSizeBitmap (Bitmap bitmap)
		{ // this method need for set normal size image in console
			var maxHeight = bitmap.Height / OFFSET * MAXSET / bitmap.Height;
			if (bitmap.Height > maxHeight || bitmap.Width > MAXSET)
			{
				bitmap = new Bitmap(bitmap, new Size((int)MAXSET, (int)maxHeight));
			}
			return bitmap;
		}
	}
}

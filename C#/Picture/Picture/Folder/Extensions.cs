using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Picture;
using System.Drawing;

namespace Picture.Folder
{
	public static class Extensions
	{
		public static void BlackGrayWhite(this Bitmap bitmap)
		{
			for(int y = 0; y < bitmap.Height; y++)
			{
				for(int x = 0; x < bitmap.Width; x++)
				{ // pixel type struct Drawing.Color - Red, Green, Blue
					var pixel = bitmap.GetPixel(x, y); // take pixel from coordinate x, y
					int avg = (pixel.R + pixel.G + pixel.B) / 3; // average value for set scale of gray
					bitmap.SetPixel(x, y, Color.FromArgb(pixel.A, avg, avg, avg)); // set new scale for this pixel
				}  // pixel.A - set transparency in console window
			}
		}
	}
}

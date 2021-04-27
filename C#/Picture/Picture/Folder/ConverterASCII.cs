using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Picture.Folder
{
	public class ConverterASCII
	{ // table with symbols for write picture on console window
		private readonly char[] tableASCII = { '.', ',', ':', '+', '*', '?', '%', 'S', '#', '@'};
		private readonly char[] tableASCIINeg = { '@', '#', 'S', '%', '?', '*', '+', ':', ',', '.' };
		private readonly Bitmap refBitmap; // referense to bitmap

		public ConverterASCII()
		{

		}

		public ConverterASCII(Bitmap bitmap)
		{
			refBitmap = bitmap;
		}

		public char[][] Convert()
		{
			var result = new char[refBitmap.Height][];
			for (int y = 0; y < refBitmap.Height; y++)
			{ // take coordinat from height of array
				result[y] = new char[refBitmap.Width]; // nested array 1d to array 2d
				for (int x = 0; x < refBitmap.Width; x++)
				{
					int pictureIndex = (int)Map(refBitmap.GetPixel(x, y).R, 0, 255, 0, tableASCII.Length - 1);
					result[y][x] = tableASCII[pictureIndex];
				}
			}

			return result; 
		}

		public char[][] ConvertForNote()
		{
			var result = new char[refBitmap.Height][];
			for (int y = 0; y < refBitmap.Height; y++)
			{ // take coordinat from height of array
				result[y] = new char[refBitmap.Width]; // nested array 1d to array 2d
				for (int x = 0; x < refBitmap.Width; x++)
				{
					int pictureIndex = (int)Map(refBitmap.GetPixel(x, y).R, 0, 255, 0, tableASCIINeg.Length - 1);
					result[y][x] = tableASCIINeg[pictureIndex];
				}
			}

			return result;
		}
		// light of pixel for 0 to 255 scales, tableASCII have 10 members. Need to cut 255 value to 10 equal part
		private float Map(float valueToMap, float start1, float stop1, float start2, float stop2)
		{ // this method to do it!
			return ((valueToMap - start1) / (stop1 - start1)) * (stop2 - start2) + start2;
		}
	}
}

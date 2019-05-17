using System;

namespace CheckArrayToArray
{
	class Program
	{
		public static bool comp(int[] a, int[] b)
		{
			bool check = false, castyl = true;
			if (a != null && b != null )
			{
				if (a.Length != 0 && b.Length != 0)
				{
					int[] a2 = new int[a.Length];
					int[] b2 = new int[b.Length];
					Array.Copy(a, a2, a.Length);
					Array.Copy(b, b2, b.Length);
					for (int i = 0; i < a.Length; i++)
					{
						for (int n = 0; n < b.Length; n++)
						{
							check = false;
							if (a[i] == Math.Sqrt(b[n]))
							{
								b[n] = 999999999;
								check = true;
								break;
							}
						}
					}
					if (check)
					{
						for (int m = 0; m < b2.Length; m++)
						{
							if (castyl)
							{
								for (int k = 0; k < a2.Length; k++)
								{
									check = false;
									if (Math.Sqrt(b2[m]) == a2[k])
									{
										a2[k] = 999999999;
										check = true;
										castyl = true;
										break;
									}
									else
									{
										castyl = false;
									}
								}
							}
							else
							{
								check = false;
								break;
							}
						}
					}
				}
				else if (a.Length == 0 && a.Length != 0)
				{
					return true;
				}
				else if (a.Length != 0 && b.Length == 0)
				{
					return true;
				}
				else if (a.Length == 0 && b.Length == 0)
				{
					return true;
				}
			}
			else
			{
				return false;
			}
			return check;
		}

		static void Main(string[] args)
		{
			int[] a = null;
			int[] b = null;
			Console.WriteLine(comp(a, b));

			Console.ReadLine();
		}
	}
}

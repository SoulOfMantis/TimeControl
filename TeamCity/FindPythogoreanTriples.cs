using System;
using System.IO;

class Program
{
	static void Main()
	{
		int n = 1000;
		using (StreamWriter file = new StreamWriter("output.txt"))
		{
			for (int i = 1; i < n; i++)
			{
				for (int j = i + 1; j < n; j++)
				{
					for (int k = 0; k < n; k++)
					{
						if ((i * i + j * j) == (k * k))
						{
							file.WriteLine($"{i}^2[{i * i}] + {j}^2[{j * j}] = {k}^2[{k * k}]");
							break;
						}
					}
				}
			}
		}

	}
}

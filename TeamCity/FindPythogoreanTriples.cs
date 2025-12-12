public class Program
{
	static void Main()
	{
		int n = 1000;
		using (StreamWriter file = new StreamWriter("output.txt"))
		{
			for (int i = 1; i <= n; i++)
			{
				var restOfTriple = findPythogoreanTriple(i);

                if (restOfTriple != (-1, -1))
				{
					var (j, k) = restOfTriple;
                    file.WriteLine($"{i}^2[{i * i}] + {j}^2[{j*j}] = {k}^2[{k * k}]");
                }
            }
		}

	}

	public static (int, int) findPythogoreanTriple(int a)
	{
		if (a <= 0) return (-1, -1);
        for (int j = 1; j < a; j++)
		{
			for (int k = a; k < 2*a; k++)
			{
				if ((a * a + j * j) == (k * k)) return (j, k);
			}
		}
        return (-1, -1);
	}
}

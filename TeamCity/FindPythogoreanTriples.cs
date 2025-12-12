int n = 1000;
for (int i = 1; i < n; i++)
{
	for (int j = i+1; j < n; j++)
	{
		for (int k = 0; k < n; k++)
		{
			if ((i*i + j*j) == (k*k))
			{
                Console.WriteLine($"{i}^2[{i*i}] + {j}^2[{j*j}] = {k}^2[{k*k}]")
				break;
            }
        }
	}
}
#include "triples.h"

int main()
{
	int a, b, c = 0;
	clear_file();
	for (size_t m = 1; c < 1000; m+=2)
	{
		for (size_t n = 3; n < m; n+=2)
		{
			if (coprime(m, n))
			{
				triple_by_Euclidian(m, n, a, b, c);
				for (size_t k = 1; k < 100; k++)
				{
					print_triple_in_file(k * a, k * b, k * c)
				}
			}
		}
	}
}
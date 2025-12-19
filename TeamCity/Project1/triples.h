#pragma once
#include <iostream>
#include <fstream>

inline void triple_by_Euclidian(int m, int n, int& a, int& b, int& c)
{
	if (n >= m || m <= 0) throw;
	a = m * n;
	b = (m * m - n * n) / 2;
	c = (m * m + n * n) / 2;
}

inline bool coprime(int m, int n)
{
	if (n >= m || m <= 0) throw;
	for (size_t i = 2; i < std::min(m, n); i++)
	{
		if (m % i == 0 && n % i == 0) return false;
	}
	return true;
}

inline void print_triple_in_file(int a, int b, int c)
{
	std::ofstream file("output.txt", std::fstream::app);
	if (!file.is_open()) throw;
	file << a << "*" << a << "[" << a * a << "] + " << b << "*" << b << "[" << b * b << "] = " << c << "*" << c << "[" << c * c << "]\n";
	file.close();
}

inline void clear_file()
{
	std::ofstream file("output.txt");
	file.close();
}
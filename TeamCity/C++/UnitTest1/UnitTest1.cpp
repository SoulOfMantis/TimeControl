#include "pch.h"
#include "CppUnitTest.h"
#include "../triples.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace UnitTest1
{
	TEST_CLASS(UnitTest1)
	{
	public:
		
		TEST_METHOD(TestMethodCoprimeFalse)
		{
			Assert::IsFalse(coprime(20, 10));
		}
		TEST_METHOD(TestMethodCoprimeTrue)
		{
			Assert::IsTrue(coprime(23, 9));
		}
		TEST_METHOD(TestMethodPythogoreanTriple)
		{
			int a, b, c = 0;
			triple_by_Euclidian(3, 1, a, b, c);
			Assert::AreEqual(a * a + b * b, c * c);
		}
	};
}

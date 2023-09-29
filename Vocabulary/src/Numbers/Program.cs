
/*uint natNum = 24;
int intNum = -24;
float realNum = 2.4F;
double realNum2 = 2.4;
*/

//1M = 1_000_000
// 10_00_000 <- indian notation

/*
int decNot = 2_000_000;
int binNot = 0b_0001_1110_1000_0100_1000_0000;
int hexNot = 0x_0001E_8480;

Console.WriteLine($"{decNot == binNot}");
Console.WriteLine($"{decNot == hexNot}");
//12.75 in decimal == 00001100.1100

Console.WriteLine($"{sizeof(int)} | {int.MinValue:N0} to {int.MaxValue:N0}");
//todo: repeat line 20 for hex and double
*/


Console.WriteLine("use doubles");
double x = 0.1;
double y = 0.2;
//topak
if (x+y == 0.3)
{
    Console.WriteLine($"{x} + {y} = {0.3}");

}
else
{
    Console.WriteLine($"{x} + {y} != {0.3}"); //<- this gets printed | rule of thumb: use double if accuracy is not that important | use only when numbers to be used will not be compared for equality
}


Console.WriteLine("use decimals");
decimal z = 0.1M;
decimal a = 0.2M; //<- M indicates type is decimal, number gets stored as large integer
// use int for whole numbers


if (z + a == 0.3M)
{
    Console.WriteLine($"{z} + {a} = {0.3M}");

}
else
{
    Console.WriteLine($"{z} + {a} != {0.3M}"); //<- this gets printed | rule of thumb: use double if accuracy is not that important
}

//#special numbers for float and double
//NaN <- not a number
//Epsilon <- smallest positive number
//Negative/PositiveInfinity <- infinitely large numbers





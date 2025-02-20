/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static int binario(int n)
  {
      if (n == 0)
    {
        Console.WriteLine(n);
    }
    else
    {
        binario(n / 2);
        Console.WriteLine(n % 2);
    }
  }
  
  static void Main() {
    
    Console.WriteLine("Digite um número decimal: ");
    int n = int.Parse(Console.ReadLine());
    
    binario(n);
  }
}
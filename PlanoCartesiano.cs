/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    
    Console.WriteLine("Entre com x e y: ");
    string[] vetor = Console.ReadLine().Split();
    double x = double.Parse(vetor[0]);
    double y = double.Parse(vetor[1]);
    
    if (x == 0 && y == 0) 
    {
        Console.WriteLine("O ponto está na origem");
    }
    else if (x % 1 == 0 || y % 1 == 0)
    {
        if (x % 1 == 0 && y % 1 != 0)
        {
            Console.WriteLine("O ponto está no eixo X");
        }
        else if (y % 1 == 0 && x % 1 != 0)
        {
            Console.WriteLine("O ponto está no eixo Y");
        }
    }
    else
    {
        if (x > 0 && y > 0)
        {
            Console.WriteLine("O ponto está no quadrante Q1");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("O ponto está no quadrante Q2");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("O ponto está no quadrante Q3");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("O ponto está no quadrante Q4");
        }
    }
  }
}
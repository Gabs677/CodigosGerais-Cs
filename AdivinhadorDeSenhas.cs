/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    
    int adivinha = 0;
    
    Console.WriteLine("Entre com uma senha de 4 dígitos");
    int senha = int.Parse(Console.ReadLine());
    
    if (senha > 9999)
    {
        Console.WriteLine("Senha inválida");
        
        return;
    }
    
    Console.WriteLine("Vamos adivinhar a senha");
    
    while (adivinha <= senha)
    {
        adivinha++;
        
        if ( adivinha == senha)
        {
            Console.WriteLine("A senha foi adivinhada! Sua senha é: " + adivinha);
            
            break;
        }
    }
  }
}
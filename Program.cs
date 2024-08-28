using System.Runtime.CompilerServices;

Calculadora calc = new Calculadora();
System.Console.WriteLine("Informe o valor de x:");
double x = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Informe o valor de y:");
double y = Convert.ToDouble(Console.ReadLine());


 double resultadoSoma = calc.Soma(x,y);

 System.Console.WriteLine($"A soma de {x} e {y} é igual a:{resultadoSoma}");

 System.Console.WriteLine($"O resultado da subtração é: {calc.Subtracao(x,y)}");

  System.Console.WriteLine($"O resultado da divisão é: {calc.Divisao(x,y)}");

   System.Console.WriteLine($"O resultado da multiplicação é: {calc.Multiplicar(x,y)}");
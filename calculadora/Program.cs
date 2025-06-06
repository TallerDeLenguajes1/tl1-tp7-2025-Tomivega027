using EspacioCalculadora; 
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Calculadora micalculo = new Calculadora();

micalculo.Sumar(30);
micalculo.Restar(10);
Console.WriteLine($"El resultado es:{micalculo.Resultado}");
micalculo.Multiplicar(5);
micalculo.Dividir(2);
Console.WriteLine($"Mi segundo resultado es:{micalculo.Resultado}");

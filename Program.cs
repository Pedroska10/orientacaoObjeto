using System;
using System.Globalization;

triangulo x,y;

x = new triangulo();
y = new triangulo();

Console.WriteLine("Entre com as medidas do triângulo x");
x.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Console.WriteLine("Agora as medidas do triângulo y");
y.A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

double resultado = formula(x.A, x.B, x.C);
double resultado2 = formula(y.A, y.B, y.C);

if(resultado > resultado2){
    Console.WriteLine($"O triângulo x possui a maior área");
}else{
    Console.WriteLine($"O triângulo y possui a maior área");
}

Console.WriteLine($"Área triângulo x {resultado.ToString("f4")}");
Console.WriteLine($"Área triângulo y {resultado2.ToString("f4")}");

static double formula (double a, double b, double c){
    double P = (a + b + c)/2;
    double area = Math.Sqrt(P*(P-a)*(P-b)*(P-c));
    return area;
}
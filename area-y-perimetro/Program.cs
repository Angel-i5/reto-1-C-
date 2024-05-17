// See https://aka.ms/new-console-template for more information

Console.WriteLine("proporciona la base de un rectangulo para calcular el area y perimetro:");
float Base= float.Parse(Console.ReadLine());

Console.WriteLine("proporsiona la altura");
float altura = float.Parse(Console.ReadLine());

float area = ( Base * altura );

float perimetro = ((Base + Base) + (altura + altura) );

Console.WriteLine("el area es:" + area );
Console.WriteLine("el perimetro es:" + perimetro );
// See https://aka.ms/new-console-template for more information

Console.WriteLine("introduse un numero para la suma,resta,multiplicasion y division:");
int numero1 = int.Parse(Console.ReadLine());


Console.WriteLine("introduse su siguiente numero:");
int numero2 = int.Parse(Console.ReadLine());

int sumar = ( numero1+numero2);
int restar = (numero1 - numero2);
int multiplicasion = (numero1 * numero2 );
int division = ( numero1 / numero2);


Console.WriteLine("el resultado de sumar estos numeos es:" +sumar);
Console.WriteLine("el resultado de restar estos numeros es:" +restar);
Console.WriteLine("el resultado de multiplicar estos numeros es :" + multiplicasion);
Console.WriteLine("el resultado de dividir estos numeros es :" + division);


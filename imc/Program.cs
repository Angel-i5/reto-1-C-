// See https://aka.ms/new-console-template for more information



Console.WriteLine("estaremos calculando tu IMC porfavor proporsiona tu peso");
int peso = int.Parse(Console.ReadLine());

Console.WriteLine("introdusca su altura ejemplo: 1,70");
decimal altura = decimal.Parse(Console.ReadLine());


decimal imc= (peso / (altura * altura));

if((imc<=18)){
    Console.WriteLine("esta bajo peso tu imc es:" + imc);
}

else if((imc>=18) && (imc<25)){
    Console.WriteLine("estas peso saludable tu imc es:" + imc);
}
 
 else if ((imc>=25) && (imc<30)){
    Console.WriteLine("tienes sobre peso tu imc es:" + imc);
 }
else
{
    Console.WriteLine("tienes obesidad tu imc es:" + imc);
}



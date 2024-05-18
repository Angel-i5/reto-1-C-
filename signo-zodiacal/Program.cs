// See https://aka.ms/new-console-template for more information

Console.WriteLine("introduce tu mes de nacimiento para determinar tu signo sodiacal:");
int mes= int.Parse(Console.ReadLine());

Console.WriteLine("introduce tu dia de nacimiento:");
int dia= int.Parse(Console.ReadLine());


if ((mes == 3 && dia >= 21) || (mes == 4 && dia <= 19))
        {
          Console.WriteLine("tu signo es Aries");
        }
        else if ((mes == 4 && dia >= 20) || (mes == 5 && dia <= 20))
        {
          Console.WriteLine("tu signo es Tauro");
            
        }
        else if ((mes == 5 && dia >= 21) || (mes == 6 && dia <= 20))
        {
          Console.WriteLine("tu signo es Geminis");
            
        }
        else if ((mes == 6 && dia >= 21) || (mes == 7 && dia <= 22))
        {
          Console.WriteLine("tu signo es Canser");
            
        }
        else if ((mes == 7 && dia >= 23) || (mes == 8 && dia <= 22))
        {
          Console.WriteLine("tu signo es Leo");
            
        }
        else if ((mes == 8 && dia >= 23) || (mes == 9 && dia <= 22))
        {
          Console.WriteLine("tu signo es virgo");
            
        }
        else if ((mes == 9 && dia >= 23) || (mes == 10 && dia <= 22))
        {
          Console.WriteLine("tu signo es Libra");
         
        }
        else if ((mes == 10 && dia >= 23) || (mes == 11 && dia <= 21))
        {
          Console.WriteLine("tu signo es escorpio");
            
        }
        else if ((mes == 11 && dia >= 22) || (mes == 12 && dia <= 21))
        {
          Console.WriteLine("tu signo es Sagitario");
          
        }
        else if ((mes == 12 && dia >= 22) || (mes == 1 && dia <= 19))
        {
          Console.WriteLine("tu signo es Capricornio");
    
        }
        else if ((mes == 1 && dia >= 20) || (mes == 2 && dia <= 18))
        {
          Console.WriteLine("tu signo es Acuario");
     
        }
        else //(mes == 2 && dia >= 19) || (mes == 3 && dia <= 20)
        {
          Console.WriteLine("tu signo es piscis");
        
        }
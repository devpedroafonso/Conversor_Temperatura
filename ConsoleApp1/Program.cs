// conversor de temperatura

//program
Console.WriteLine("Bem-Vindo ao sistema de conversão de temperatura");
Console.WriteLine(" ");
Console.WriteLine("Para qual temperatura você deseja converter ?");
Console.WriteLine(" ");
Console.WriteLine("Celcius[1] ou Fahrenheit[2]");
Console.WriteLine(" ");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine(" ");
int temperatura = Convert.ToInt16(Console.ReadLine());

switch (temperatura)
{

    case 1:
        Console.WriteLine("Informe a temperatura");
        double celsius = Convert.ToInt16(Console.ReadLine());
        double fahrenheit = (celsius*9/5)+32;
        Console.WriteLine(celsius + "ºC convertido para fahrenheit fica" + fahrenheit + "ºF");
    break;

    case 2:
        Console.WriteLine("Informe a temperatura");
        fahrenheit = Convert.ToInt16(Console.ReadLine());
        celsius = (fahrenheit-32)*9/5;
        Console.WriteLine(fahrenheit + "ºF convertido para Celsius fica" + celsius + " ºC");
    break;

    default:
        Console.WriteLine("Opção invalida");
    break;
}

Console.ReadKey();
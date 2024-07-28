// See https://aka.ms/new-console-template for more information
#region Console.ReadLine
//Console.WriteLine("please enter your name");
//string name=Console.ReadLine();
//Console.WriteLine("xos gelmisiniz:"+name);
// istifadeciden adini isteyin ve ona "xos gelmisiniz mesaji cixardin"
#endregion
#region yasi hesablamak
//Console.WriteLine("please enter your born year");   
//int year=int.Parse(Console.ReadLine());
//int age = 2024 - year;
//Console.WriteLine($"sizin{age}yasiniz var");
//istifadeciden tevelludunu istemek ve onun yasini hesablayib cixarmaq 
#endregion
#region iki ededin muqayisesi
//Console.WriteLine("please enter first number");
//int first =int.Parse(Console.ReadLine());
//Console.WriteLine("please enter third number");
//int third =int.Parse(Console.ReadLine());

//if (first > third)
//{
//    Console.WriteLine("first number is the biggest:"+first);
//}
//else if (first == third)
//{
//    Console.WriteLine("first and third number is equal");
//}
//else
//{
//Console.WriteLine("third number is the biggest:"+third);
//}

#endregion
#region istifadeciden temperatur derecesi almaq
//Console.WriteLine("please enter temperature degree");
//double temp=double.Parse(Console.ReadLine());

//if (temp <= 0)
//{
//    Console.WriteLine("Weather is very cold");
//}
//else if(temp>=1 && temp <= 10)
//{
//    Console.WriteLine("weather is cold");
//}
//else if (temp >= 11 && temp <= 20)
//{
//    Console.WriteLine("weather is warn");
//}
//else if (temp >= 50)
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("temperature can not be more");
//    Console.ForegroundColor= ConsoleColor.White;
//}
//else
//{
//    Console.WriteLine("weather is hot");
//}
#endregion




Console.WriteLine("1.show Name");
Console.WriteLine("2.show Surname");
Console.WriteLine("3.show Age");
int userChoice=int.Parse(Console.ReadLine());

switch (userChoice)
{
	case 1:
		Console.WriteLine("please enter your name");
		string name=Console.ReadLine();
		Console.WriteLine($"your name is{name}");
		break;
		case 2:
		Console.WriteLine("please enter your surname");
		string surname=Console.ReadLine();
		Console.WriteLine($"Surname is{surname}");
		break ;

		case 3:
		Console.WriteLine("please enter your born year");
		int age=int.Parse(Console.ReadLine());
		int year=2024-age;
		Console.WriteLine($"your are{year} years old");
		break;
}
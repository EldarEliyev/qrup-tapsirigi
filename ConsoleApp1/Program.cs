// See https://aka.ms/new-console-template for more information
#region switch case
//Console.WriteLine("1.show Name");
//Console.WriteLine("2.show Surname");
//Console.WriteLine("3.show Age");
//int userChoice = int.Parse(Console.ReadLine());

//switch (userChoice)
//{
//    case 1:
//        Console.WriteLine("please enter your name");
//        string name = Console.ReadLine();
//        Console.WriteLine($"your name is{name}");
//        break;
//    case 2:
//        Console.WriteLine("please enter your surname");
//        string surname = Console.ReadLine();
//        Console.WriteLine($"Surname is{surname}");
//        break;

//    case 3:
//        Console.WriteLine("please enter your born year");
//        int age = int.Parse(Console.ReadLine());
//        int year = 2024 - age;
//        Console.WriteLine($"your are{year} years old");
//        break;
//}
#endregion
#region 0-99 a qeder cixartmaq for ile
//for (int i = 0; i <=99; i++)
//{
//    Console.WriteLine(i);
//}
#endregion
#region 0-10 a kimi reqemleri cixartmaq lakin 3 ve 9 istisna olmaqla
//for (int i = 0; i <=10; i++)
//{
//    if (i == 3) continue;
//    if(i==9) continue;  
//    Console.WriteLine(i);
//}
#endregion
#region names adlarimizi cixartma
//string[] names = { "eldar", "gunel", "ferid", "isa mellim" };
//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine(names[i]);
//}
#endregion
// eger beraberdirse Admine o zaman salam admin mesaji cixarin
#region admine beraber
//Console.WriteLine("please enter your name");
//string name=Console.ReadLine();
//if (name == "admin")
//{
//    Console.WriteLine("hello admin");

//}
//else if (name != "admin")
//{
//    Console.WriteLine("Welcome user:"+name);
//}
#endregion
#region soz oyunu
////string wantedWord = "magic";
////int counter = 5;
////do
////{
////    Console.WriteLine("please enter a word");
////    string userInput=Console.ReadLine();
////    if (string.IsNullOrWhiteSpace(userInput))
////    {
////        Console.ForegroundColor = ConsoleColor.Red;
////        Console.WriteLine("please enter a word in a correct format");
////        Console.ForegroundColor = ConsoleColor.Gray;
////    }
//else
//{
//    if (userInput==wantedWord)
//    {
//        Console.WriteLine($"Congratulations you found{wantedWord}that word");
//        counter = 0;
//    }
//    else
//    {
//        Console.WriteLine("wrong answer try again");
//        Console.WriteLine($"You have{counter} chance");
//        counter--;

//    }
//    }

//} while(counter > 0);   
#endregion
#region reqem oyunu
//int NumberGame = 50;
//int counter = 5;
//do
//{
//    Console.WriteLine("please enter number");
//    int userInput=int.Parse(Console.ReadLine());
//    if (userInput < NumberGame)
//    {
//        Console.WriteLine("Up...");
//        counter--;
//}
//else if (userInput > NumberGame)
//{
//    Console.WriteLine("down...");
//    counter--;

//}
#endregion
//type  variable   value
#region toplama,vurma,bolme
//  int  number1    = 20;
//int number2 = 5;
//int res = number1 + number2;
//Console.WriteLine(res);
#endregion
#region string tipi
//Console.WriteLine("please enter your name");
//string name=Console.ReadLine();
//Console.WriteLine("Xos geldiniz");
#endregion
#region if 3 ededin muqayisesi
////Console.WriteLine("please enter first number");
////int first=int.Parse(Console.ReadLine());
////Console.WriteLine("please enter second number");
////int second=int.Parse(Console.ReadLine());
////Console.WriteLine("please enter third number");
////int third=int.Parse(Console.ReadLine());

////if (first > second)
////{
////    Console.WriteLine("first number is the biggest:" + first);
////}
////else if(second > third)
////{
////    Console.WriteLine("second number is the biggest:"+second);
//}
//else
//{
//    Console.WriteLine("third number is the biggest:"+third);
//}
#endregion
#region ededi orta
//void FindMultiple(int number1, int number2,int number3)
//{
//    int result = (number1 * number2 * number3) / 3;
//    Console.WriteLine($"Result is{result}");

//}
//FindMultiple(2, 5, 7);
#endregion
#region yazi uzunlugu
//int GetLength(string data)
//{
//    return data.Length;


//}
//GetLength("jed academy");
//Console.WriteLine(GetLength("jed academy"));
#endregion
void FindSum()
{
    Console.WriteLine("please enter first number");
    int first=int.Parse(Console.ReadLine());

    Console.WriteLine("please enter second number");
    int second=int.Parse(Console.ReadLine());
    int res = 0;
    for (int i=first; i<second; i++)
    {
        res += i;
         
    }
    FindSum();
}

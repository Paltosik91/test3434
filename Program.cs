// // Console.Write("Введите ваше имя: ");
// // string name = Console.ReadLine();
// // double test;
// // test = 3.4;
// // Console.Write("Введите ваш возраст: ");
// // System.Int32 age = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine($"Ваше имя - {name}. Ваш возраст через 10 лет - {age + 10}");

// // if (int.TryParse(Console.ReadLine(), out int c))
// // {
// //     Console.WriteLine($"Ваш возраст - {c}");
// // }

// Console.WriteLine("Введите день недели(цифру от 1 от 7): ");
// int age = Convert.ToInt32(Console.ReadLine());
// switch (age)
// {
//     case 1:
//     case 2:
//     case 3:
//     case 4:
//     case 5:
//         Console.WriteLine("Будний день");
//         break;
//     case 6:
//     case 7:
//         Console.WriteLine("Выходной день");
//         break;
//     default:
//         Console.WriteLine("Некорректный ввод");
//         break;
// }

// int x = 1;
// Console.WriteLine(x++ + ++x);

int temperature = int.Parse(Console.ReadLine());
// if (temperature > 15)
//     Console.WriteLine("Тепло");
// else
//     Console.WriteLine("Холодно");

// string weather = temperature > 15 ? "Тепло" : "Холодно";
// System.Console.WriteLine(weather);

// for(int i = 0; i <= 10; i++)
// {
//     System.Console.WriteLine($"ШаГ: {i}");
// }

// int[] numbers = [1, 3, 4, 56, 78];
// foreach(int num in numbers)
// {
//     System.Console.WriteLine(num);
// }

void SayHello() =>
    System.Console.WriteLine("hELLO");


SayHello();
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Основные типы int | float | char | string | bool

            //Целыечисленные типы
            //byte b; // 0 до 255
            //sbyte sb; // -128 до 127
            //short s; // -32768 до 32767
            //ushort us; // 0 до 65535
            //int i; // -2147483648 до 2147483647
            //uint ui; // 0 до 4294672295
            //long l = long.MaxValue;
            //ulong ul = ulong.MaxValue;

            //// Числа с плавающей точкой
            //float f = 5.7f;
            //double d = 5.7;

            ////Символьный тип
            //char c = ' ';

            ////Строковый тип
            //string str = "Hello! How are you?"; 

            ////Логический тип
            //bool bl= false;

            // + - * / %
            //float result;

            //int x , y;

            //x = 5;
            //y = 6;
            //result = Convert.ToSingle(x) / y;
            //Console.WriteLine(result);

            //int timeInMinets = 130;
            //int hour;
            //int minute;

            //hour = timeInMinets / 60;
            //minute = timeInMinets % 60;

            //Console.WriteLine("hour: " + hour);
            //Console.WriteLine("minutes: " + minute);

            // == != > < >= <=
            //int age = 18;
            //bool accesIsAllowed = age >= 18;
            //Console.WriteLine(accesIsAllowed);

            //string greeting = "Hello";
            //string name = "Denis";
            //string message = greeting + " see " + name;
            //Console.WriteLine($"Ваше имя: {name}") ;
            //Console.WriteLine(message);

            //int age;
            //string input = "15";
            //age = Convert.ToInt32(input);
            //Console.WriteLine(age);

            //int trigger = 0;
            //bool triggerInBoolean = Convert.ToBoolean(trigger);
            //Console.WriteLine(triggerInBoolean);
            //int reconvert = Convert.ToInt32(triggerInBoolean);
            //Console.WriteLine(reconvert);

            //string name;
            //Console.Write(" Input your name: ");
            //name = Console.ReadLine();
            //Console.WriteLine($" Your name: {name}");
            //int age;
            //Console.Write(" Input your age: ");
            //age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Your age: {age}");

            //int i = 0;
            //i++;
            //Console.WriteLine(i);

            //float health;
            //int armor;
            //int damage;
            //int precentConverter = 100;

            //Console.Write("Введите количество здоровья: ");
            //health = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите количество брони: ");
            //armor = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите количество урона: ");
            //damage = Convert.ToInt32(Console.ReadLine());

            //health -= Convert.ToSingle(damage) / precentConverter * armor;

            //Console.WriteLine($"Вам нанесли {damage} урона." +
            //   $" У вас осталось {health} здоровья.");

            //int money;
            //int food;
            //int foodUnitPrice = 10;
            //bool isAbleToPay;

            //Console.WriteLine("Добро пожаловать в пекарню! Сегодня еда по " + foodUnitPrice + " монет.");
            //Console.Write("Сколько у вас золота?");
            //money = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Сколько еды вам нужно?");
            //food = Convert.ToInt32(Console.ReadLine());
            //isAbleToPay = money >= food * foodUnitPrice;
            //food *= Convert.ToInt32(isAbleToPay);
            //money -= food * foodUnitPrice;
            //Console.WriteLine($"У вас в сумке {food} единиц еды, и {money} монет.");

            //int age;
            //Console.Write("Введите ваш возраст: ");
            //age = Convert.ToInt32(Console.ReadLine());
            //if (age >= 18)
            //{
            //    Console.WriteLine("Добро пожаловать в наш бар?");
            //    Console.WriteLine("Что будете пить?");
            //}

            //else {

            //    Console.WriteLine("Доступ запрещен!");
            //    Console.WriteLine("Приходите через: " + (18 - age) + " лет.");

            //}

            //Логическое И &&
            // X | Y | X && Y true => 1 false => 0
            // 1 | 1 | 1
            // 1 | 0 | 1
            // 0 | 1 | 1
            // 0 | 0 | 0

            //Логическое Или ||
            //int money = 500;
            //int level = 10;

            //if(money >= 500 || level > 9)
            //{
            //    Console.WriteLine("Проходи!");
            //}
            //else
            //{
            //    Console.WriteLine("Стоп!");
            //}

            // Оператор switch
            //string dayOfWeek;
            //dayOfWeek = Console.ReadLine();

            //switch (dayOfWeek)
            //{
            //    case "Понедельник":
            //    case "Суббота":
            //    case "Восскресение":
            //        Console.WriteLine("Идем в кино");
            //        break;
            //    case "Вторник":
            //        Console.WriteLine("Идем в спортзал");
            //        break;
            //    case "Среда":
            //        Console.WriteLine("Идем домой");
            //        break;
            //    default:
            //        Console.WriteLine("Не верный ввод");
            //        break;
            //}

            //string password = "123qwe";
            //string userInput;

            //Console.Write("Введите пароль: ");

            //userInput = Console.ReadLine();

            //if (userInput == password)
            //{
            //    Console.WriteLine("Пароль принят. Доступ разрешен.");
            //}
            //else
            //{
            //    Console.WriteLine("Неверный пароль. Доступ запрещен.");
            //}

            //float rublesInWallet;
            //float dollarsInWalleet;

            //int rubToUsd = 64, usdToRub = 66;

            //float exchangeCurrencyCount;

            //string desiredOperation;

            //Console.WriteLine("Добро пожаловать в обменник валют!");

            //Console.Write("Введите баланс рублей: ");
            //rublesInWallet = Convert.ToSingle(Console.ReadLine());
            //Console.Write("Введите баланс долларов: ");
            //dollarsInWalleet = Convert.ToSingle(Console.ReadLine());

            //Console.WriteLine("Выбирите необходимую операцию.");
            //Console.WriteLine("1 - обменять рубли на доллары");
            //Console.WriteLine("2 - обменять доллары на рубли");
            //Console.Write("Ваш выбор: ");
            //desiredOperation = Console.ReadLine();

            //switch (desiredOperation)
            //{
            //    case "1":
            //        Console.WriteLine("Обмен рублей на доллары");
            //        Console.Write("Сколько хотите обменять: ");
            //        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
            //        if(rublesInWallet >= exchangeCurrencyCount)
            //        {
            //            rublesInWallet -= exchangeCurrencyCount;
            //            dollarsInWalleet += exchangeCurrencyCount / rubToUsd;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Недопустимое количество рублей");
            //        }
            //        break;
            //    case "2":
            //        Console.WriteLine("Обмен долларов на рубли");
            //        Console.Write("Сколько хотите обменять: ");
            //        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
            //        if (dollarsInWalleet >= exchangeCurrencyCount)
            //        {
            //            dollarsInWalleet -= exchangeCurrencyCount;
            //            rublesInWallet += exchangeCurrencyCount * usdToRub;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Недопустимое количество долларов");
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Выбрана неверная операция");
            //        break;
            //}

            //Console.WriteLine($"Ваш баланс: {rublesInWallet} рублей, " + $"{dollarsInWalleet} долларов.") ;

            //int age;
            //Console.Write("Введите возраст: ");
            //age = Convert.ToInt32(Console.ReadLine());
            //while (age-- > 0)
            //{


            //    if (age == 5)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(age);

            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int triesCount = 5;
            //string password = "12345";
            //string userInput;

            //for (int i = 0; i < triesCount; i++)
            //{
            //    Console.Write("Введите пароль: ");
            //    userInput = Console.ReadLine();
            //    if (userInput == password)
            //    {
            //        Console.WriteLine("Отлично");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Не верный пароль.");
            //        Console.WriteLine("У вас осталось " + (triesCount - i - 1) +" попыток.");
            //    }
            //}   

            //float money;
            //int years;
            //int percent;

            //Console.Write("Введите количество денег, внесенных на вклад: ");
            //money = Convert.ToSingle(Console.ReadLine());
            //Console.Write("На сколько лет открыть вклад ? ");
            //years = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Под какой процент? ");
            //percent = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < years; i++)
            //{
            //    money += money / 100 * percent;
            //    Console.WriteLine("В этом году у вас " + money);
            //    Console.ReadKey();
            //}

            //int playerHealth = 100;
            //int playerDemage = 10;
            //int enemyHealth = 50;
            //int enemyDemage = 15;

            //while (playerHealth > 0 && enemyDemage > 0)
            //{
            //    playerHealth -= enemyDemage;
            //    enemyHealth -= playerDemage;

            //    Console.WriteLine(playerHealth + " игрок.");
            //    Console.WriteLine(enemyHealth + " враг.");
            //}

            //if (playerHealth <= 0 && enemyHealth <= 0)
            //{
            //    Console.WriteLine("Ничья");
            //}
            //else if (enemyHealth <= 0)
            //{
            //    Console.WriteLine("Победа игрока");
            //}
            //else if (playerHealth <= 0)
            //{
            //    Console.WriteLine("Победа врага");
            //}

            //Random rand = new Random();
            //int value = rand.Next(0, 10);
            //while (true)
            //{
            //    value = rand.Next(0, 10);
            //    Console.WriteLine(value);
            //    Console.ReadKey();
            //}

            //Random rnd = new Random();

            //for(int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(rnd.Next(0,5));
            //}

            //int number;
            //int lower;
            //int higher;
            //int triesCount = 5;
            //int userInput;

            //Random rand = new Random();

            //number = rand.Next(0, 101);
            //lower = rand.Next(number - 10, number);
            //higher = rand.Next(number + 1, number + 10);

            //Console.WriteLine($"Мы загадали число от 0 до 100, оно больше чем {lower}, но меньше чем {higher}.");
            //Console.WriteLine($"Что это за число? У вас {triesCount}, попыток отгадать.");

            //while( triesCount-- > 0 )
            //{
            //    Console.Write("Введите ответ: ");
            //    userInput = Convert.ToInt32( Console.ReadLine() );
            //    if(userInput == number)
            //    {
            //        Console.WriteLine("Вы правы!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Не верно. Попробуйте еще раз.");
            //    }
            //}

            //if(triesCount < 0 ) 
            //{ 
            //    Console.WriteLine("Вы проиграли! Это было число: " + number);          
            //}

            //Random rand = new Random();
            //float health1 = rand.Next(90, 100);
            //int demage1 = rand.Next(5, 25);
            //int armor1 = rand.Next(25, 65);

            //float health2 = rand.Next(80, 150);
            //int armor2 = rand.Next(65, 100);
            //int demage2 = rand.Next(20, 40);

            //Console.WriteLine($"Гладиатор 1 - {health1} здоровья, {demage1} наносимый урон {armor1} броня.");
            //Console.WriteLine($"Гладиатор 2 - {health2} здоровья, {demage2} наносимый урон {armor2} броня.");

            //while (health1 > 0 && health2 > 0)
            //{
            //    health1 -= Convert.ToSingle(rand.Next(0, demage2 + 1)) / 100 * armor1;
            //    health2 -= Convert.ToSingle(rand.Next(0, demage1 + 1)) / 100 * armor2;

            //    Console.WriteLine("Здоровья гладиатор 1: " + health1);
            //    Console.WriteLine("Здоровья гладиатор 2: " + health2);
            //}

            //if (health1 <= 0 && health2 <= 0)
            //{
            //    Console.WriteLine("Ничья");
            //}
            //else if (health1 <= 0)
            //{
            //    Console.WriteLine("Гладиатор 2 выиграл");
            //}
            //else if (health2 <= 0)
            //{
            //    Console.WriteLine("Гладиатор 1 выиграл");
            //}

            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.WindowHeight = 10;
            //Console.WindowWidth = 35;
            //Console.WriteLine("Привет, Денис!\nКуда ты вчера делся?]\b \b");

            //Console.SetCursorPosition(1,2);
            //Console.ReadKey();

            //int[] cucubers = new int[10];
            //int[] cucubers = new int [4] {24, 23, int.MaxValue, int.MinValue};
            //Random random = new Random();
            //for (int i = 0; i < cucubers.Length; i++)
            //{
            //    //cucubers[i] = random.Next(0, 100);
            //    Console.Write(cucubers[i] + " ");
            //}

            //int[] array = { 1, 2, 3 };

            //int sum = 0;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);

            //    sum += array[i];

            //}

            //Console.WriteLine(sum);int[]

            //int[] array = { 1, 2, 3 };
            //int maxElement = int.MinValue;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] > maxElement)
            //    {
            //        maxElement = array[i];
            //    }
            //}

            //Console.WriteLine(maxElement);

            //int[] sectors = { 6, 28, 30, 40, 50};
            //bool isOpen = true;
            //while (isOpen)
            //{
            //    Console.SetCursorPosition(0, 18);
            //    for (int i = 0; i < sectors.Length; i++)
            //    {
            //        Console.WriteLine($"В секторе {i + 1} свободно {sectors[i]} мест");
            //    }

            //    Console.SetCursorPosition(0, 0);
            //    Console.WriteLine("Регистрация рейса.");
            //    Console.WriteLine("\n\n1 - забронировать места \n\n2 - выход из программы. \n\n");
            //    Console.Write("Введите номер команды: ");
            //    switch (Convert.ToInt32(Console.ReadLine()))
            //    {
            //        case 1:

            //            int userSector, userPlaceAmount;
            //            Console.Write("В каком секторе вы хотите лететь? ");
            //            userSector = Convert.ToInt32(Console.ReadLine()) - 1;
            //            if(sectors.Length <= userSector || userSector < 0)
            //            {
            //                Console.WriteLine("Такого сектора не существует.");
            //                break;
            //            }
            //            Console.Write("Сколько мест вы хотите забронировать? ");
            //            userPlaceAmount = Convert.ToInt32(Console.ReadLine());
            //            if(userPlaceAmount < 0)
            //            {
            //                Console.WriteLine("Неверное количество мест.");
            //                break;
            //            }
            //            if (sectors[userSector] < userPlaceAmount || userPlaceAmount < 0)
            //            {
            //                Console.WriteLine($"В сектооре {userSector} недостаточно мест. Остаток {sectors[userSector]}");
            //                break;
            //            }

            //            sectors[userSector] -= userPlaceAmount;
            //            Console.WriteLine("Бронирование успешно!");
            //            break; 
            //        case 2:
            //            isOpen = false;
            //            break;

            //    }

            //    Console.ReadKey();
            //    Console.Clear();
            //}

            //int[,] array;
            //int[,] array2 = new int[2, 3];

            //int[,] array3 = { 
            //    { 2, 3, 4 },
            //    {4, 4, 5 } 
            //};

            //int[,] array4 = new int[2, 3] {
            //    {9, 8, 7 },
            //    {6, 5, 4 }
            //};

            //for (int i = 0; i < array3.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array3.GetLength(1); j++)
            //    {
            //        Console.Write(array3[i, j] + " ");

            //    }
            //    Console.WriteLine();
            //}

            //int[,] array = new int[4, 4];
            //Random rnd = new Random();
            //for (int i = 0; i < array.GetLength(0); i++) 
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = rnd.Next(0, 10);
            //        Console.Write(array[i, j] + " ");
            //    }

            //    Console.WriteLine();
            //}

            bool isOpen = true;
            string[,] books =
            {
                {"Александр Пушкин", "Михаил Лермонтов", "Сергей Есенин"},
                {"Роберт Мартин", "Джесси Шелл", "Сергей Тепляков"}
            };

            while (isOpen)
            {
                Console.SetCursorPosition(0, 20);

                Console.WriteLine("\nВесь список авторов: \n");

                for (int i = 0; i < books.GetLength(0); i++)
                {
                    for (int j = 0; j < books.GetLength(1); j++)
                    {
                        Console.Write(books[i, j] + " | ");
                    }

                    Console.WriteLine();
                }
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Библиотека");
                Console.WriteLine("1 - узнать имя автора по индексу книги.");
                Console.ReadKey();
            }
        }
    }
}

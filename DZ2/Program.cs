namespace DZ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Выбери задачу");
            string select = Console.ReadLine();
            switch (select)
            {
                case "19":
                    zad19();
                    break;
                case "21":
                    zad21();
                    break;
                case "23":
                    zad23();
                    break;
                case "q":
                    Environment.Exit(0);
                    break;
            }
        }

        static void zad19()
        {
            Console.WriteLine("Введите пятизначное число:");
            int number = int.Parse(Console.ReadLine());

            if (number < 10000 || number > 99999)
            {
                Console.WriteLine("Введено некорректное число! Пожалуйста, введите пятизначное число.");
                return;
            }
            string numberString = number.ToString();
            int length = numberString.Length;
            bool IsPalindrome = true;
            for (int i = 0; i < length / 2; i++)
            {
                if (numberString[i] != numberString[length - i - 1])
                    IsPalindrome = false;
            }

            if (IsPalindrome)
            {
                Console.WriteLine("Введенное число является палиндромом.");
            }
            else
            {
                Console.WriteLine("Введенное число не является палиндромом.");
            }
        }

        static void zad21()
        {
           
            Console.WriteLine("Введите координаты по оси оX для второй точки:");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координаты по оси оY для второй точки:");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координаты по оси оZ для второй точки:");
            int z2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координаты по оси оX для первой точки:");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координаты по оси оY для первой точки:");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координаты по оси оZ для первой точки:");
            int z1 = Convert.ToInt32(Console.ReadLine());



            double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
            Console.WriteLine(d);
        }

        static void zad23()
        {
            Console.WriteLine("Введите число N:");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Таблица кубов чисел от 1 до " + N + ":");
            Console.WriteLine("Число\tКуб");

            for (int i = 1; i <= N; i++)
            {
                int cube = i * i * i;
                Console.WriteLine(i + "\t" + cube);
            }
        }

    }
}
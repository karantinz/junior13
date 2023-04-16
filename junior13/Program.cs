bool programExecution = true;

while (programExecution)
{
    Console.WriteLine("Выберите команду:");
    Console.WriteLine("1 - Изменить высоту консоли");
    Console.WriteLine("2 - Изменить ширину консоли");
    Console.WriteLine("3 - Изменить заголовок консоли");
    Console.WriteLine("4 - Изменить цвет текста");
    Console.WriteLine("0 - Выйти");

    int commandInput = int.Parse(Console.ReadLine());

    switch (commandInput)
    {
        case 1:
            Console.WriteLine("Введите высоту консоли");
            int height = int.Parse(Console.ReadLine());
            Console.WindowHeight = height;
            Console.SetWindowSize(Console.WindowWidth, height);
            break;

        case 2:
            Console.WriteLine("Введите ширину консоли");
            int width = int.Parse(Console.ReadLine());
            Console.WindowWidth = width;
            Console.SetWindowSize(width, Console.WindowHeight);
            break;

        case 3:
            Console.WriteLine("Введите заголовок");
            string title = Console.ReadLine();
            Console.Title = title;
            break;

        case 4:
            string textColorGreen = "Зеленый";
            string textColorRed = "Красный";
            string textColorYellow = "Желтый";

            Console.WriteLine("Выберите цвет текста:");
            Console.WriteLine($"1 - {textColorGreen}");
            Console.WriteLine($"2 - {textColorRed}");
            Console.WriteLine($"3 - {textColorYellow}");

            int colorChoice = int.Parse(Console.ReadLine());

            switch (colorChoice)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }
            break;
    }

    if (commandInput == 0) 
        programExecution = false;
}
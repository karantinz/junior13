﻿bool programExecution = true;

while (programExecution)
{
    const int ChangeHeight = 1;
    const int ChangeWidth = 2;
    const int ChangeTitle = 3;
    const int ChangeTextColor = 4;
    const int ExitProgram = 0;

    Console.WriteLine("Выберите команду:");
    Console.WriteLine($"{ChangeHeight} - Изменить высоту консоли");
    Console.WriteLine($"{ChangeWidth} - Изменить ширину консоли");
    Console.WriteLine($"{ChangeTitle} - Изменить заголовок консоли");
    Console.WriteLine($"{ChangeTextColor} - Изменить цвет текста");
    Console.WriteLine($"{ExitProgram} - Выйти");

    int commandInput = int.Parse(Console.ReadLine());

    switch (commandInput)
    {
        case ChangeHeight:
            Console.WriteLine("Введите высоту консоли");
            int height = int.Parse(Console.ReadLine());
            if (height <= Console.LargestWindowHeight)
            {
                Console.WindowHeight = height;
                Console.SetWindowSize(Console.WindowWidth, height);
            }
            else
            {
                Console.WriteLine($"Высота консоли больше максимального значения {Console.LargestWindowHeight}");
            }
            break;

        case ChangeWidth:
            Console.WriteLine("Введите ширину консоли");
            int width = int.Parse(Console.ReadLine());
            if (width <= Console.LargestWindowWidth)
            {
                Console.WindowWidth = width;
                Console.SetWindowSize(width, Console.WindowHeight);
            }
            else
            {
                Console.WriteLine($"Высота консоли больше максимального значения {Console.LargestWindowWidth}");
            }
            break;

        case ChangeTitle:
            Console.WriteLine("Введите заголовок");
            string title = Console.ReadLine();
            Console.Title = title;
            break;

        case ChangeTextColor:
            const string TextColorGreen = "Зеленый";
            const string TextColorRed = "Красный";
            const string TextColorYellow = "Желтый";

            Console.WriteLine("Выберите цвет текста:");
            Console.WriteLine($"1 - {TextColorGreen}");
            Console.WriteLine($"2 - {TextColorRed}");
            Console.WriteLine($"3 - {TextColorYellow}");

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

    if (commandInput == ExitProgram)
        programExecution = false;
}
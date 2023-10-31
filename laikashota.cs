using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tortashota
{
    internal class laikashota
    {
        private int vybor;
        private string nazvanie;
        private List<string> Options;
        private int cena;
        private string Cake;

        public void Menu()
        {
            Console.Clear();

            ConsoleKey keyPressed;

            nazvanie = "Торты от дяди Ашота от которых может быть отравишься\n-----------------------------------------------------";

            string[] options = { "  Форма торта", "  Размер торта", "  Вкус коржей", "  Количество коржей", "  Глазурь", "  Декор", "  Конец заказа" };
            Options = new List<string>(options);

            int vybor = Run();

            switch (vybor)
            {
                case 0:
                    vybor = 0;
                    Console.Clear();
                    MenuForm();
                    break;
                case 1:
                    vybor = 0;
                    Console.Clear();
                    MenuSize();
                    break;
                case 2:
                    vybor = 0;
                    Console.Clear();
                    MenuTaste();
                    break;
                case 3:
                    vybor = 0;
                    Console.Clear();
                    MenuCountOfCakeSlice();
                    break;
                case 4:
                    vybor = 0;
                    Console.Clear();
                    MenuGlaze();
                    break;
                case 5:
                    vybor = 0;
                    Console.Clear();
                    MenuDecor();
                    break;
                case 6:
                    vybor = 0;
                    AddOrderToBook();
                    Console.WriteLine("\nЗаказ создан. Для выхода нажмите ESC.");
                    break;
            }
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            keyPressed = keyInfo.Key;
            if (keyPressed == ConsoleKey.Escape)
            {
                Console.Clear();
            }
            Menu();
        }

        private void MenuForm()
        {
            nazvanie = "Форма";

            string[] options = { " Круг - 600", " Квадрат - 500", " Беляш - 11600", " Луна - 900" };
            Options = new List<string>(options);

            int vybor = Run();

            switch (vybor)
            {
                case 0:
                    cena += 600;
                    Cake += options[0] + "; ";
                    break;
                case 1:
                    cena += 500;
                    Cake += options[1] + "; ";
                    break;
                case 2:
                    cena += 11600;
                    Cake += options[2] + "; ";
                    break;
                case 3:
                    cena += 900;
                    Cake += options[3] + "; ";
                    break;
            }

            Console.Clear();
            Menu();
        }

        private void MenuSize()
        {

            nazvanie = "Размер";

            string[] options = { "Маленький - 800", "Средний - 1000", "Большой - 1200" };
            Options = new List<string>(options);

            int vybor = Run();

            switch (vybor)
            {
                case 0:
                    cena += 800;
                    Cake += options[0] + "; ";
                    break;
                case 1:
                    cena += 1000;
                    Cake += options[1] + "; ";
                    break;
                case 2:
                    cena += 1200;
                    Cake += options[2] + "; ";
                    break;
            }

            Console.Clear();
            Menu();
        }

        private void MenuCountOfCakeSlice()
        {
            nazvanie = "Количество коржей";

            string[] options = { "1 коржык - 200", "2 коржык - 400", "3 коржык - 800", "4 коржык - 1600" };
            Options = new List<string>(options);

            int vybor = Run();

            switch (vybor)
            {
                case 0:
                    cena = cena + 200;
                    Cake += "Количество коржей: " + options[0] + "; ";
                    break;
                case 1:
                    cena += 400;
                    Cake += "Количество коржей: " + options[1] + "; ";
                    break;
                case 2:
                    cena += 800;
                    Cake += "Количество коржей: " + options[2] + "; ";
                    break;
                case 3:
                    cena += 1600;
                    Cake += "Количество коржей: " + options[3] + "; ";
                    break;
                case 4:
                    break;
            }

            Console.Clear();
            Menu();
        }

        private void MenuTaste()
        {
            nazvanie = "Вкус коржей";

            string[] options = { "Вкус фирменной шаурмы - 170", "Вкус шампура - 1000", "Вкус беляша - 80" };
            Options = new List<string>(options);

            int vybor = Run();

            switch (vybor)
            {
                case 0:
                    cena = cena + 170;
                    Cake += options[0] + "; ";
                    break;
                case 1:
                    cena += 1000;
                    Cake += options[1] + "; ";
                    break;
                case 2:
                    cena += 80;
                    Cake += options[2] + "; ";
                    break;
            }

            Console.Clear();
            Menu();
        }
        private void MenuGlaze()
        {
            nazvanie = "Глазурь";

            string[] options = { "Перхоть - 300", "Крахмал - 200", "Ванилька - 250", "Шоколадка - 200" };
            Options = new List<string>(options);

            int vybor = Run();

            switch (vybor)
            {
                case 0:
                    cena = cena + 300;
                    Cake += options[0] + "; ";
                    break;
                case 1:
                    cena += 200;
                    Cake += options[1] + "; ";
                    break;
                case 2:
                    cena += 250;
                    Cake += options[2] + "; ";
                    break;
                case 3:
                    cena += 200;
                    Cake += options[3] + "; ";
                    break;
            }

            Console.Clear();
            Menu();
        }

        private void MenuDecor()
        {
            nazvanie = "Декор";

            string[] options = { "Мухи - 400", "Волосы - 300", "Беляшы - 90", "Шаурма - 170" };
            Options = new List<string>(options);

            int vybor = Run();

            switch (vybor)
            {
                case 0:
                    cena = cena + 400;
                    Cake += options[0] + "; ";
                    break;
                case 1:
                    cena += 300;
                    Cake += options[1] + "; ";
                    break;
                case 2:
                    cena += 90;
                    Cake += options[2] + "; ";
                    break;
                case 3:
                    cena += 170;
                    Cake += options[3] + "; ";
                    break;
            }

            Console.Clear();
            Menu();
        }


        private void AddOrderToBook()
        {
            string order = $"{DateTime.Now}   Цена заказа: {cena}. Заказ: {Cake}\n";
            string path = @"Orders.txt";
            File.AppendAllText(path, order);
        }
        private void DisplayOptions()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(nazvanie);
            for (int i = 0; i < Options.Capacity; i++)
            {
                string currentOption = Options[i];
                Console.WriteLine(currentOption);
            }
            Console.WriteLine($"\nЦена: {cena} \nВаш торт: {Cake}");
        }
        private int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                new Thread(DisplayOptions).Start();
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;
                Console.SetCursorPosition(0, vybor);
                Console.WriteLine("  ");
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    vybor--;
                    if (vybor == -1)
                    {
                        vybor = Options.Capacity - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    vybor++;
                    if (vybor == Options.Capacity)
                    {
                        vybor = 0;
                    }
                }
                Console.SetCursorPosition(0, vybor);
                Console.WriteLine("->");
            } while (keyPressed != ConsoleKey.Enter);

            return vybor;
        }

    }
}

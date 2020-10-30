using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Drop
{
    class Program
    {
        static int score = 0, x1, y1, block, cursor;
        static bool y;



        static void DrawCreator(int[,] maparr, int b)
        {
            int i1 = 0, i2 = 0;

            switch (b)
            {
                case 1:
                    {
                        if (maparr[y1 + 1, x1] == 0)
                        {
                            Console.SetCursorPosition(x1 * 2, y1 + 1);
                            Console.Write("  ");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.SetCursorPosition(x1 * 2, y1);
                            Console.Write("* ");
                        }
                        if (maparr[y1 + 1, x1] == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.SetCursorPosition(x1 * 2, y1 + 1);
                            Console.Write("2 ");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.SetCursorPosition(x1 * 2, y1);
                            Console.Write("* ");
                        }
                        if (maparr[y1 + 1, x1] == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(x1 * 2, y1 + 1);
                            Console.Write("[]");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.SetCursorPosition(x1 * 2, y1);
                            Console.Write("* ");
                        }
                        if (maparr[y1 + 1, x1] == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(x1 * 2, y1 + 1);
                            Console.Write("O ");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.SetCursorPosition(x1 * 2, y1);
                            Console.Write("* ");
                        }
                        if (maparr[y1 + 1, x1] == 1)
                        {
                            Console.SetCursorPosition(x1 * 2, y1 + 1);
                            Console.Write("X ");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.SetCursorPosition(x1 * 2, y1);
                            Console.Write("* ");
                        }

                    }
                    break;
                case 2:
                    {
                        if (maparr[y1 - 1, x1] == 0)
                        {
                            Console.SetCursorPosition(x1 * 2, y1 - 1);
                            Console.Write("  ");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.SetCursorPosition(x1 * 2, y1);
                            Console.Write("* ");
                        }
                        if (maparr[y1 - 1, x1] == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.SetCursorPosition(x1 * 2, y1 - 1);
                            Console.Write("2 ");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.SetCursorPosition(x1 * 2, y1);
                            Console.Write("* ");
                        }
                        if (maparr[y1 - 1, x1] == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(x1 * 2, y1 - 1);
                            Console.Write("[]");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.SetCursorPosition(x1 * 2, y1);
                            Console.Write("* ");
                        }
                        if (maparr[y1 - 1, x1] == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(x1 * 2, y1 - 1);
                            Console.Write("O ");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.SetCursorPosition(x1 * 2, y1);
                            Console.Write("* ");
                        }
                        if (maparr[y1 - 1, x1] == 1)
                        {
                            Console.SetCursorPosition(x1 * 2, y1 - 1);
                            Console.Write("X ");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.SetCursorPosition(x1 * 2, y1);
                            Console.Write("* ");
                        }
                    }
                    break;
                case 3:
                    {
                        if (maparr[y1, x1 + 1] == 0)
                        {
                            Console.SetCursorPosition((x1 + 1) * 2, y1);
                            Console.Write("  ");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.SetCursorPosition(x1 * 2, y1);
                            Console.Write("* ");
                        }
                        if (maparr[y1, x1 + 1] == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.SetCursorPosition((x1 + 1) * 2, y1);
                            Console.Write("2 ");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.SetCursorPosition(x1 * 2, y1);
                            Console.Write("* ");
                        }
                        if (maparr[y1, x1 + 1] == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition((x1 + 1) * 2, y1);
                            Console.Write("[]");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.SetCursorPosition(x1 * 2, y1);
                            Console.Write("* ");
                        }
                        if (maparr[y1, x1 + 1] == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition((x1 + 1) * 2, y1);
                            Console.Write("O ");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.SetCursorPosition(x1 * 2, y1);
                            Console.Write("* ");
                        }
                        if (maparr[y1, x1 + 1] == 1)
                        {
                            Console.SetCursorPosition((x1 + 1) * 2, y1);
                            Console.Write("X ");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.SetCursorPosition(x1 * 2, y1);
                            Console.Write("* ");
                        }
                    }
                    break;
                case 4:
                    {
                        if (maparr[y1, x1 - 1] == 0)
                        {
                            Console.SetCursorPosition((x1 - 1) * 2, y1);
                            Console.Write("  ");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.SetCursorPosition(x1 * 2, y1);
                            Console.Write("* ");
                        }
                        if (maparr[y1, x1 - 1] == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.SetCursorPosition((x1 - 1) * 2, y1);
                            Console.Write("2 ");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.SetCursorPosition(x1 * 2, y1);
                            Console.Write("* ");
                        }
                        if (maparr[y1, x1 - 1] == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition((x1 - 1) * 2, y1);
                            Console.Write("[]");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.SetCursorPosition(x1 * 2, y1);
                            Console.Write("* ");
                        }
                        if (maparr[y1, x1 - 1] == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition((x1 - 1) * 2, y1);
                            Console.Write("O ");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.SetCursorPosition(x1 * 2, y1);
                            Console.Write("* ");
                        }
                        if (maparr[y1, x1 - 1] == 1)
                        {
                            Console.SetCursorPosition((x1 - 1) * 2, y1);
                            Console.Write("X ");
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.SetCursorPosition(x1 * 2, y1);
                            Console.Write("* ");
                        }
                    }
                    break;
                case 5:
                    {
                        for (i1 = 1; i1 <= 23; i1++)
                        {
                            for (i2 = 1; i2 <= maparr.GetUpperBound(0) - 1; i2++)
                            {
                                if (maparr[i1, i2] == 1)
                                {
                                    Console.ResetColor();
                                    Console.SetCursorPosition(i2 * 2, i1);
                                    Console.Write("X ");
                                }
                            }
                        }
                    }
                    break;
                case 6:
                    {
                        for (i1 = 1; i1 <= 23; i1++)
                        {
                            for (i2 = 1; i2 <= maparr.GetUpperBound(0) - 1; i2++)
                            {
                                if (maparr[i1, i2] == 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.SetCursorPosition(i2 * 2, i1);
                                    Console.Write("2 ");
                                }
                            }
                        }
                    }
                    break;
                case 7:
                    {
                        for (i1 = 1; i1 <= 23; i1++)
                        {
                            for (i2 = 1; i2 <= maparr.GetUpperBound(0) - 1; i2++)
                            {
                                if (maparr[i1, i2] == 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.SetCursorPosition(i2 * 2, i1);
                                    Console.Write("[]");
                                }
                            }
                        }
                    }
                    break;
                case 8:
                    {
                        for (i1 = 1; i1 <= 23; i1++)
                        {
                            for (i2 = 1; i2 <= maparr.GetUpperBound(0) - 1; i2++)
                            {
                                if (maparr[i1, i2] == 4)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.SetCursorPosition(i2 * 2, i1);
                                    Console.Write("O ");
                                }
                            }
                        }
                    }
                    break;
                case 9:
                    {
                        for (i1 = 1; i1 <= 23; i1++)
                        {
                            for (i2 = 1; i2 <= maparr.GetUpperBound(0) - 1; i2++)
                            {
                                if (maparr[i1, i2] == 0)
                                {
                                    Console.SetCursorPosition(i2 * 2, i1);
                                    Console.Write("  ");
                                }
                            }
                        }
                    }
                    break;
            }
            Console.ResetColor();
        }
        static void LogicCreator(int[,] maparr)
        {
            var key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    {
                        if (y1 > 1)
                        {
                            y1--;
                            DrawCreator(maparr, 1);
                        }
                    }
                    break;
                case ConsoleKey.DownArrow:
                    {
                        if (y1 < 23)
                        {
                            y1++;
                            DrawCreator(maparr, 2);
                        }
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    {
                        if (x1 > 1)
                        {
                            x1--;
                            DrawCreator(maparr, 3);
                        }
                    }
                    break;
                case ConsoleKey.RightArrow:
                    {
                        if (x1 < 23)
                        {
                            x1++;
                            DrawCreator(maparr, 4);
                        }
                    }
                    break;
                case ConsoleKey.D1:
                    {
                        bool b = false;
                        for (int i = 1; i <= 23; i++)
                        {
                            for (int j = 1; j <= 23; j++)
                            {
                                if (maparr[i, j] == 1)
                                {
                                    b = true;
                                }
                            }
                        }
                        if (b == false)
                        {
                            maparr[y1, x1] = 1;
                            Console.SetCursorPosition(50, 9);
                            Console.Write("              ");
                            DrawCreator(maparr, 5);
                        }
                    }
                    break;
                case ConsoleKey.D2:
                    {
                        maparr[y1, x1] = 2;
                        DrawCreator(maparr, 6);
                    }
                    break;
                case ConsoleKey.D3:
                    {
                        maparr[y1, x1] = 3;
                        block++;
                        if (block == 1)
                        {
                            Console.SetCursorPosition(50, 10);
                            Console.Write("                         ");
                        }
                        if (block == cursor)
                        {
                            Console.SetCursorPosition(50, 10);
                            Console.Write("                         ");
                        }
                        DrawCreator(maparr, 7);
                    }
                    break;
                case ConsoleKey.D4:
                    {
                        maparr[y1, x1] = 4;
                        cursor++;
                        if (cursor == 1)
                        {
                            Console.SetCursorPosition(50, 11);
                            Console.Write("                         ");
                        }
                        if (block == cursor)
                        {
                            Console.SetCursorPosition(50, 10);
                            Console.Write("                         ");
                        }
                        DrawCreator(maparr, 8);
                    }
                    break;
                case ConsoleKey.D0:
                    {
                        if (maparr[y1, x1] == 3)
                        {
                            block--;
                        }
                        if (maparr[y1, x1] == 4)
                        {
                            cursor--;
                        }
                        maparr[y1, x1] = 0;
                        DrawCreator(maparr, 9);
                    }
                    break;
                case ConsoleKey.Escape:
                    {
                        Console.ResetColor();
                        int x = 10;
                        bool b = true;
                        Console.SetCursorPosition(50, 9);
                        Console.Write("              ");
                        Console.SetCursorPosition(50, 9);
                        Console.WriteLine("Сохранить изменения?");
                        string[] exit = new string[3];
                        exit[0] = "Да";
                        exit[1] = "Нет";
                        exit[2] = "Продолжить редактирование";
                        Console.SetCursorPosition(50, 10);
                        Console.Write("                         ");
                        Console.SetCursorPosition(50, 10);
                        Console.Write(exit[0]);
                        Console.SetCursorPosition(50, 11);
                        Console.Write("                         ");
                        Console.SetCursorPosition(50, 11);
                        Console.Write(exit[1]);
                        Console.SetCursorPosition(50, 12);
                        Console.Write(exit[2]);
                        Console.SetCursorPosition(80, x);
                        Console.Write("<=");
                        var keys = Console.ReadKey(true);
                        while (b)
                        {
                            switch (keys.Key)
                            {
                                case ConsoleKey.UpArrow:
                                    {
                                        if (x > 10)
                                        {
                                            x--;
                                            Console.SetCursorPosition(80, x);
                                            Console.Write("<=");
                                            Console.SetCursorPosition(80, x + 1);
                                            Console.Write("  ");
                                        }
                                    }
                                    break;
                                case ConsoleKey.DownArrow:
                                    {
                                        if (x < 12)
                                        {
                                            x++;
                                            Console.SetCursorPosition(80, x);
                                            Console.Write("<=");
                                            Console.SetCursorPosition(80, x - 1);
                                            Console.Write("  ");
                                        }
                                    }
                                    break;
                                case ConsoleKey.Enter:
                                    {
                                        for (int h = 0; h <= 2; h++)
                                        {
                                            switch (exit[h])
                                            {
                                                case "Да":
                                                    {
                                                        b = false;
                                                        Console.SetCursorPosition(50, 9);
                                                        Console.Write("                    ");
                                                        Console.SetCursorPosition(50, 10);
                                                        Console.Write("  ");
                                                        Console.SetCursorPosition(50, 11);
                                                        Console.Write("   ");
                                                        Console.SetCursorPosition(50, 12);
                                                        Console.Write("                         ");
                                                        Console.SetCursorPosition(80, 10);
                                                        Console.Write("  ");
                                                        Console.SetCursorPosition(80, 11);
                                                        Console.Write("  ");
                                                        Console.SetCursorPosition(80, 12);
                                                        Console.Write("  ");
                                                        if (x == 10)
                                                        {
                                                            int hero = 0;
                                                            bool k = true;
                                                            for (int i = 1; i <= 23; i++)
                                                            {
                                                                for (int j = 1; j <= 23; j++)
                                                                {
                                                                    if (maparr[i, j] == 1)
                                                                    {
                                                                        hero = 1;
                                                                        if ((block == cursor) && (block != 0) && (cursor != 0))
                                                                        {
                                                                            k = false;
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                            if (block > cursor)
                                                            {
                                                                Console.SetCursorPosition(50, 10);
                                                                Console.Write("Блоков больше чем кружков");
                                                                b = false;
                                                            }
                                                            if (block < cursor)
                                                            {
                                                                Console.SetCursorPosition(50, 10);
                                                                Console.Write("Блоков меньше чем кружков");
                                                                b = false;
                                                            }

                                                            if (hero == 0)
                                                            {
                                                                Console.SetCursorPosition(50, 9);
                                                                Console.Write("Нужен персонаж");
                                                                b = false;
                                                            }
                                                            if (block == 0)
                                                            {
                                                                Console.SetCursorPosition(50, 10);
                                                                Console.Write("Нужен хотя бы один блок");
                                                                b = false;
                                                            }
                                                            if (cursor == 0)
                                                            {
                                                                Console.SetCursorPosition(50, 11);
                                                                Console.Write("Нужен хотя бы один кружок");
                                                                b = false;
                                                            }
                                                            if (k == false)
                                                            {
                                                                string file = @"Map1.txt";
                                                                if (File.Exists(file))
                                                                {
                                                                    using (StreamWriter sw = new StreamWriter(file))
                                                                    {
                                                                        for (int i = 0; i <= 24; i++)
                                                                        {
                                                                            for (int j = 0; j <= 24; j++)
                                                                            {
                                                                                sw.Write("{0} ", (maparr[i, j]));
                                                                            }
                                                                            sw.WriteLine();
                                                                        }
                                                                    }
                                                                    c = false;
                                                                    return;
                                                                }
                                                            }
                                                        }
                                                    }
                                                    break;
                                                case "Нет":
                                                    {
                                                        if (x == 11)
                                                        {
                                                            c = false;
                                                            return;
                                                        }
                                                    }
                                                    break;
                                                case "Продолжить редактирование":
                                                    {
                                                        if (x == 12)
                                                        {
                                                            b = false;
                                                        }
                                                    }
                                                    break;
                                            }
                                        }
                                    }
                                    break;
                            }
                            if (b == true)
                            {
                                keys = Console.ReadKey(true);
                            }
                        }
                    }
                    break;
            }
        }

        static void Draw(int[,] maparr, int b)
        {
            int i1 = 0, i2 = 0;
            bool v = true;
            for (i1 = 1; i1 <= maparr.Length - 1; i1++)
            {
                for (i2 = 1; i2 <= maparr.GetUpperBound(0) - 1; i2++)
                {
                    if (maparr[i1, i2] == 1)
                    {
                        v = false;
                        if (v == false) break;
                    }
                }
                if (v == false) break;
            }
            switch (b)
            {
                case 1:
                    {
                        if (maparr[i1 + 1, i2] == 0)
                        {
                            Console.SetCursorPosition(i2 * 2, i1 + 1);
                            Console.Write("  ");
                            Console.SetCursorPosition(i2 * 2, i1);
                            Console.Write("X ");
                        }
                        if ((maparr[i1 - 1, i2] == 3) && (maparr[i1 + 1, i2] == 0))
                        {
                            Console.SetCursorPosition(i2 * 2, i1 + 1);
                            Console.Write("  ");
                            Console.SetCursorPosition(i2 * 2, i1);
                            Console.Write("X ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(i2 * 2, i1 - 1);
                            Console.Write("[]");
                        }
                        if ((maparr[i1 - 1, i2] == 0) && (maparr[i1 - 2, i2] != 4))
                        {
                            Console.SetCursorPosition(i2 * 2, i1 + 1);
                            Console.Write("  ");
                            Console.SetCursorPosition(i2 * 2, i1);
                            Console.Write("X ");
                            Console.SetCursorPosition(i2 * 2, i1 - 1);
                            Console.Write("  ");
                        }
                    }
                    break;
                case 2:
                    {
                        if (maparr[i1 - 1, i2] == 0)
                        {
                            Console.SetCursorPosition(i2 * 2, i1 - 1);
                            Console.Write("  ");
                            Console.SetCursorPosition(i2 * 2, i1);
                            Console.Write("X ");
                        }
                        if ((maparr[i1 + 1, i2] == 3) && (maparr[i1 - 1, i2] == 0))
                        {
                            Console.SetCursorPosition(i2 * 2, i1 - 1);
                            Console.Write("  ");
                            Console.SetCursorPosition(i2 * 2, i1);
                            Console.Write("X ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(i2 * 2, i1 + 1);
                            Console.Write("[]");
                        }
                        if ((maparr[i1 + 1, i2] == 0) && (maparr[i1 + 2, i2] != 4))
                        {
                            Console.SetCursorPosition(i2 * 2, i1 - 1);
                            Console.Write("  ");
                            Console.SetCursorPosition(i2 * 2, i1);
                            Console.Write("X ");
                            Console.SetCursorPosition(i2 * 2, i1 + 1);
                            Console.Write("  ");
                        }
                    }
                    break;
                case 3:
                    {
                        if (maparr[i1, i2 + 1] == 0)
                        {
                            Console.SetCursorPosition((i2 + 1) * 2, i1);
                            Console.Write("  ");
                            Console.SetCursorPosition(i2 * 2, i1);
                            Console.Write("X ");
                        }
                        if ((maparr[i1, i2 - 1] == 3) && (maparr[i1, i2 + 1] == 0))
                        {
                            Console.SetCursorPosition((i2 + 1) * 2, i1);
                            Console.Write("  ");
                            Console.SetCursorPosition(i2 * 2, i1);
                            Console.Write("X ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition((i2 - 1) * 2, i1);
                            Console.Write("[]");
                        }
                        if ((maparr[i1, i2 - 1] == 0) && (maparr[i1, i2 - 2] != 4))
                        {
                            Console.SetCursorPosition((i2 + 1) * 2, i1);
                            Console.Write("  ");
                            Console.SetCursorPosition(i2 * 2, i1);
                            Console.Write("X ");
                            Console.SetCursorPosition((i2 - 1) * 2, i1);
                            Console.Write("  ");
                        }
                    }
                    break;
                case 4:
                    {
                        if (maparr[i1, i2 - 1] == 0)
                        {
                            Console.SetCursorPosition((i2 - 1) * 2, i1);
                            Console.Write("  ");
                            Console.SetCursorPosition(i2 * 2, i1);
                            Console.Write("X ");
                        }
                        if ((maparr[i1, i2 + 1] == 3) && (maparr[i1, i2 - 1] == 0))
                        {
                            Console.SetCursorPosition((i2 - 1) * 2, i1);
                            Console.Write("  ");
                            Console.SetCursorPosition(i2 * 2, i1);
                            Console.Write("X ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition((i2 + 1) * 2, i1);
                            Console.Write("[]");
                        }
                        if ((maparr[i1, i2 + 1] == 0) && (maparr[i1, i2 + 2] != 4))
                        {
                            Console.SetCursorPosition((i2 - 1) * 2, i1);
                            Console.Write("  ");
                            Console.SetCursorPosition(i2 * 2, i1);
                            Console.Write("X ");
                            Console.SetCursorPosition((i2 + 1) * 2, i1);
                            Console.Write("  ");
                        }
                    }
                    break;
                case 5:
                    {
                        if ((maparr[i1 + 1, i2] == 3) && (maparr[i1, i2] != 2))
                        {
                            Console.SetCursorPosition(i2 * 2, i1 + 2);
                            Console.Write("  ");
                            Console.SetCursorPosition(i2 * 2, i1);
                            Console.Write("X ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(i2 * 2, i1 + 1);
                            Console.Write("[]");
                        }
                    }
                    break;
                case 6:
                    {
                        if ((maparr[i1 - 1, i2] == 3) && (maparr[i1, i2] != 2))
                        {
                            Console.SetCursorPosition(i2 * 2, i1 - 2);
                            Console.Write("  ");
                            Console.SetCursorPosition(i2 * 2, i1);
                            Console.Write("X ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(i2 * 2, i1 - 1);
                            Console.Write("[]");
                        }
                    }
                    break;
                case 7:
                    {
                        if ((maparr[i1, i2 + 1] == 3) && (maparr[i1, i2] != 2))
                        {
                            Console.SetCursorPosition((i2 + 2) * 2, i1);
                            Console.Write("  ");
                            Console.SetCursorPosition(i2 * 2, i1);
                            Console.Write("X ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition((i2 + 1) * 2, i1);
                            Console.Write("[]");
                        }
                    }
                    break;
                case 8:
                    {
                        if ((maparr[i1, i2 - 1] == 3) && (maparr[i1, i2] != 2))
                        {
                            Console.SetCursorPosition((i2 - 2) * 2, i1);
                            Console.Write("  ");
                            Console.SetCursorPosition(i2 * 2, i1);
                            Console.Write("X ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition((i2 - 1) * 2, i1);
                            Console.Write("[]");
                        }
                    }
                    break;
            }
            if (y == true)
            {
                score += 1;
                Console.SetCursorPosition(56, 10);
                Console.Write("  ");
                Console.SetCursorPosition(56, 10);
                Console.Write(score);
                y = false;
            }
            Console.ResetColor();
        }

        static void Logic(int a, int[,] maparr)
        {
            int i1 = 0, i2 = 0;
            switch (a)
            {
                case 1:
                    bool v = true;
                    for (i1 = 1; i1 <= maparr.Length - 1; i1++)
                    {
                        for (i2 = 1; i2 <= maparr.GetUpperBound(0) - 1; i2++)
                        {
                            if (maparr[i1, i2] == 1)
                            {
                                v = false;
                                if (v == false) break;
                            }
                        }
                        if (v == false) break;
                    }
                    var key = Console.ReadKey(true);
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            {
                                if (maparr[i1 - 1, i2] == 0)
                                {
                                    maparr[i1, i2] = 0;
                                    maparr[i1 - 1, i2] = 1;
                                }
                                if ((maparr[i1 - 1, i2] == 3) && (maparr[i1 - 2, i2] == 0))
                                {
                                    maparr[i1, i2] = 0;
                                    maparr[i1 - 1, i2] = 1;
                                    maparr[i1 - 2, i2] = 3;
                                }
                                if ((maparr[i1 - 1, i2] == 3) && (maparr[i1 - 2, i2] == 4))
                                {
                                    maparr[i1, i2] = 0;
                                    maparr[i1 - 1, i2] = 1;
                                    maparr[i1 - 2, i2] = 0;
                                    y = true;
                                }
                            }
                            Draw(maparr, 1);
                            break;
                        case ConsoleKey.DownArrow:
                            {
                                if (maparr[i1 + 1, i2] == 0)
                                {
                                    maparr[i1, i2] = 0;
                                    maparr[i1 + 1, i2] = 1;
                                }
                                if ((maparr[i1 + 1, i2] == 3) && (maparr[i1 + 2, i2] == 0))
                                {
                                    maparr[i1, i2] = 0;
                                    maparr[i1 + 1, i2] = 1;
                                    maparr[i1 + 2, i2] = 3;
                                }
                                if ((maparr[i1 + 1, i2] == 3) && (maparr[i1 + 2, i2] == 4))
                                {
                                    maparr[i1, i2] = 0;
                                    maparr[i1 + 1, i2] = 1;
                                    maparr[i1 + 2, i2] = 0;
                                    y = true;
                                }
                            }
                            Draw(maparr, 2);
                            break;
                        case ConsoleKey.LeftArrow:
                            {
                                if (maparr[i1, i2 - 1] == 0)
                                {
                                    maparr[i1, i2] = 0;
                                    maparr[i1, i2 - 1] = 1;
                                }
                                if ((maparr[i1, i2 - 1] == 3) && (maparr[i1, i2 - 2] == 0))
                                {
                                    maparr[i1, i2] = 0;
                                    maparr[i1, i2 - 1] = 1;
                                    maparr[i1, i2 - 2] = 3;
                                }
                                if ((maparr[i1, i2 - 1] == 3) && (maparr[i1, i2 - 2] == 4))
                                {
                                    maparr[i1, i2] = 0;
                                    maparr[i1, i2 - 1] = 1;
                                    maparr[i1, i2 - 2] = 0;
                                    y = true;
                                }
                            }
                            Draw(maparr, 3);
                            break;
                        case ConsoleKey.RightArrow:
                            {
                                if (maparr[i1, i2 + 1] == 0)
                                {
                                    maparr[i1, i2] = 0;
                                    maparr[i1, i2 + 1] = 1;
                                }
                                if ((maparr[i1, i2 + 1] == 3) && (maparr[i1, i2 + 2] == 0))
                                {
                                    maparr[i1, i2] = 0;
                                    maparr[i1, i2 + 1] = 1;
                                    maparr[i1, i2 + 2] = 3;
                                }
                                if ((maparr[i1, i2 + 1] == 3) && (maparr[i1, i2 + 2] == 4))
                                {
                                    maparr[i1, i2] = 0;
                                    maparr[i1, i2 + 1] = 1;
                                    maparr[i1, i2 + 2] = 0;
                                    y = true;
                                }
                            }
                            Draw(maparr, 4);
                            break;
                        case ConsoleKey.Escape:
                            {
                                c = false;
                                return;
                            }
                        case ConsoleKey.Tab:
                            {
                                var keys = Console.ReadKey(true);
                                switch (keys.Key)
                                {
                                    case ConsoleKey.UpArrow:
                                        {
                                            if ((maparr[i1 + 1, i2] == 3) && (maparr[i1 - 1, i2] != 2))
                                            {
                                                maparr[i1 + 1, i2] = 0;
                                                maparr[i1, i2] = 3;
                                                maparr[i1 - 1, i2] = 1;
                                            }
                                        }
                                        Draw(maparr, 5);
                                        break;
                                    case ConsoleKey.DownArrow:
                                        {
                                            if ((maparr[i1 - 1, i2] == 3) && (maparr[i1 + 1, i2] != 2))
                                            {
                                                maparr[i1 - 1, i2] = 0;
                                                maparr[i1, i2] = 3;
                                                maparr[i1 + 1, i2] = 1;
                                            }
                                        }
                                        Draw(maparr, 6);
                                        break;
                                    case ConsoleKey.LeftArrow:
                                        {
                                            if ((maparr[i1, i2 + 1] == 3) && (maparr[i1, i2 - 1] != 2))
                                            {
                                                maparr[i1, i2 + 1] = 0;
                                                maparr[i1, i2] = 3;
                                                maparr[i1, i2 - 1] = 1;
                                            }
                                        }
                                        Draw(maparr, 7);
                                        break;
                                    case ConsoleKey.RightArrow:
                                        {
                                            if ((maparr[i1, i2 - 1] == 3) && (maparr[i1, i2 + 1] != 2))
                                            {
                                                maparr[i1, i2 - 1] = 0;
                                                maparr[i1, i2] = 3;
                                                maparr[i1, i2 + 1] = 1;
                                            }
                                        }
                                        Draw(maparr, 8);
                                        break;
                                }
                            }
                            break;
                    }
                    break;

                case 2:
                    bool m = false;
                    for (i1 = 1; i1 <= 23; i1++)
                    {
                        for (i2 = 1; i2 <= 23; i2++)
                        {
                            if (maparr[i1, i2] == 3)
                            {
                                m = true;
                            }
                        }
                    }
                    if (m == false)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(25, 10);
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Победа");
                        Console.ResetColor();
                        c = false;
                        Console.ReadLine();
                        return;
                    }
                    break;

            }
        }

        static bool c = true;

        static void Game(int[,] maparr)
        {
            c = true;
            while (c)
            {
                Console.SetCursorPosition(50, 10);
                Console.Write("Счёт: ");
                Console.SetCursorPosition(56, 10);
                Console.Write(score);
                Console.SetCursorPosition(60, 5);
                Console.Write("С помощью стрелочек необходимо блоки (");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(98, 5);
                Console.Write("[]");
                Console.ResetColor();
                Console.SetCursorPosition(100, 5);
                Console.Write(")");
                Console.SetCursorPosition(68, 6);
                Console.Write("затолкать в кружки (");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(88, 6);
                Console.Write("O");
                Console.ResetColor();
                Console.SetCursorPosition(89, 6);
                Console.Write(")");
                Console.SetCursorPosition(65, 7);
                Console.Write("Если блок оказался около стены,");
                Console.SetCursorPosition(60, 8);
                Console.Write("его можно вытащить с помощью кнопки \"Tab\"");
                Logic(2, maparr);
                if (Console.KeyAvailable)
                {
                    Logic(1, maparr);
                }
                Thread.Sleep(1);
            }
            Console.Clear();
            score = 0;
            Menu(maparr);
        }

        static void Game2(int[,] maparr)
        {
            x1 = 1; y1 = 1;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(x1 * 2, y1);
            Console.Write("* ");
            c = true;
            while (c)
            {
                if (Console.KeyAvailable)
                {
                    LogicCreator(maparr);
                }
                Thread.Sleep(1);
            }
            Console.Clear();
            Menu(maparr);
        }

        static void Menu(int[,] maparr)
        {
            int x = 1;
            Console.SetCursorPosition(10, 0);
            Console.WriteLine("Меню");
            string[] menu = new string[4];
            menu[0] = "Стандартный уровень";
            menu[1] = "Рандомный уровень";
            menu[2] = "Редактор";
            menu[3] = "Уровень из редактора";
            Console.SetCursorPosition(0, 1);
            Console.Write(menu[0]);
            Console.SetCursorPosition(0, 2);
            Console.Write(menu[1]);
            Console.SetCursorPosition(0, 3);
            Console.Write(menu[2]);
            Console.SetCursorPosition(0, 4);
            Console.Write(menu[3]);
            Console.SetCursorPosition(20, x);
            Console.Write("<=");
            var key = Console.ReadKey(true);
            while (true)    
            {
                switch (key.Key)
                {

                    case ConsoleKey.UpArrow:
                        {
                            if (x > 1)
                            {
                                x--;
                                Console.SetCursorPosition(20, x);
                                Console.Write("<=");
                                Console.SetCursorPosition(20, x + 1);
                                Console.Write("  ");
                            }
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (x < 4)
                            {
                                x++;
                                Console.SetCursorPosition(20, x);
                                Console.Write("<=");
                                Console.SetCursorPosition(20, x - 1);
                                Console.Write("  ");
                            }
                            break;
                        }
                    case ConsoleKey.Enter:
                        for (int i1 = 0; i1 <= 3; i1++)
                        {
                            switch (menu[i1])
                            {
                                case "Стандартный уровень":
                                    {
                                        if (x == 1)
                                        {
                                            Set(ref maparr);
                                            Rend(maparr);
                                            Game(maparr);
                                        }
                                    }
                                    break;
                                case "Рандомный уровень":
                                    {
                                        if (x == 2)
                                        {
                                            Set(ref maparr);
                                            maparr = new int[25, 25]{{ 0,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,0 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 0,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,0 } };

                                            int i = 0, j = 0;
                                            int g = 7, d = 7, k = 7;
                                            Random rand = new Random();
                                            for (int y = 1; y <= g; y++)
                                            {
                                                i = rand.Next(1, 23);
                                                j = rand.Next(1, 23);
                                                if ((maparr[i, j] != 1) && (maparr[i, j] != 4) && (maparr[i, j] != 2))
                                                {
                                                    maparr[i, j] = 3;
                                                }
                                                else
                                                {
                                                    g++;
                                                    continue;
                                                }
                                            }
                                            for (int y = 1; y <= d; y++)
                                            {
                                                i = rand.Next(1, 23);
                                                j = rand.Next(1, 23);
                                                if ((maparr[i, j] != 1) && (maparr[i, j] != 3) && (maparr[i, j] != 2))
                                                {
                                                    maparr[i, j] = 4;
                                                }
                                                else
                                                {
                                                    d++;
                                                    continue;
                                                }
                                            }
                                            for (int y = 1; y <= k; y++)
                                            {
                                                i = rand.Next(1, 23);
                                                j = rand.Next(1, 23);
                                                if ((maparr[i, j] != 1) && (maparr[i, j] != 3) && (maparr[i, j] != 4))
                                                {
                                                    maparr[i, j] = 2;
                                                }
                                                else
                                                {
                                                    k++;
                                                    continue;
                                                }
                                            }
                                            Rend(maparr);
                                            Game(maparr);
                                            x = 1;
                                        }
                                    }
                                    break;
                                case "Редактор":
                                    {
                                        if (x == 3)
                                        {
                                            Console.Clear();
                                            int x1 = 11;
                                            bool b = true;
                                            Console.SetCursorPosition(30, 10);
                                            Console.WriteLine("Что редактировать?");
                                            string[] menus = new string[2];
                                            menus[0] = "Новый уровень";
                                            menus[1] = "Уровень из файла";
                                            Console.SetCursorPosition(30, 11);
                                            Console.Write(menus[0]);
                                            Console.SetCursorPosition(30, 12);
                                            Console.Write(menus[1]);
                                            Console.SetCursorPosition(50, x1);
                                            Console.Write("<=");
                                            var keys = Console.ReadKey(true);
                                            while (b)
                                            {
                                                switch (keys.Key)
                                                {
                                                    case ConsoleKey.UpArrow:
                                                        {
                                                            if (x1 > 11)
                                                            {
                                                                x1--;
                                                                Console.SetCursorPosition(50, x1);
                                                                Console.Write("<=");
                                                                Console.SetCursorPosition(50, x1 + 1);
                                                                Console.Write("  ");
                                                            }
                                                            break;
                                                        }
                                                    case ConsoleKey.DownArrow:
                                                        {
                                                            if (x1 < 12)
                                                            {
                                                                x1++;
                                                                Console.SetCursorPosition(50, x1);
                                                                Console.Write("<=");
                                                                Console.SetCursorPosition(50, x1 - 1);
                                                                Console.Write("  ");
                                                            }
                                                            break;
                                                        }
                                                    case ConsoleKey.Escape:
                                                        {
                                                            Console.Clear();
                                                            Menu(maparr);
                                                        }
                                                        break;
                                                    case ConsoleKey.Enter:
                                                        {
                                                            for (int i2 = 0; i2 <= 1; i2++)
                                                            {
                                                                switch (menus[i2])
                                                                {
                                                                    case "Новый уровень":
                                                                        {
                                                                            if (x1 == 11)
                                                                            {
                                                                                block = 0;
                                                                                cursor = 0;
                                                                                Set(ref maparr);
                                                                                maparr = new int[25, 25]{{ 0,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,0 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 0,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,0 } };

                                                                                Rend(maparr);
                                                                                Game2(maparr);
                                                                            }
                                                                        }
                                                                        break;
                                                                    case "Уровень из файла":
                                                                        {
                                                                            if (x1 == 12)
                                                                            {
                                                                                block = 0;
                                                                                cursor = 0;
                                                                                string file = @"Map1.txt";
                                                                                if (File.Exists(file))
                                                                                {
                                                                                    string[] lines = File.ReadAllLines(file);
                                                                                    int[,] num = new int[25, 25];
                                                                                    for (int i = 0; i < lines.Length; i++)
                                                                                    {
                                                                                        string[] temp = lines[i].Split(' ');
                                                                                        for (int j = 0; j < temp.Length - 1; j++)
                                                                                            num[i, j] = Convert.ToInt32(temp[j]);
                                                                                    }
                                                                                    maparr = num;

                                                                                    for (int i = 1; i <= 23; i++)
                                                                                    {
                                                                                        for (int j = 1; j <= 23; j++)
                                                                                        {
                                                                                            if (maparr[i, j] == 3)
                                                                                            {
                                                                                                block++;
                                                                                            }
                                                                                            if (maparr[i, j] == 4)
                                                                                            {
                                                                                                cursor++;
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                    Rend(maparr);
                                                                                    Game2(maparr);
                                                                                }
                                                                                else
                                                                                {
                                                                                    Set(ref maparr);
                                                                                    maparr = new int[25, 25]{{ 0,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,0 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 0,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,0 } };
                                                                                    using (StreamWriter sw = File.AppendText(file))
                                                                                    {
                                                                                        for (int i = 0; i <= 24; i++)
                                                                                        {
                                                                                            for (int j = 0; j <= 24; j++)
                                                                                            {
                                                                                                sw.Write("{0} ", (maparr[i, j]));
                                                                                            }
                                                                                            sw.WriteLine();
                                                                                        }
                                                                                    }
                                                                                    Rend(maparr);
                                                                                    Game2(maparr);
                                                                                }
                                                                            }
                                                                            break;
                                                                        }
                                                                }
                                                            }
                                                        }
                                                        break;
                                                }
                                                keys = Console.ReadKey(true);
                                            }
                                            x = 1;
                                        }
                                    }
                                    break;
                                case "Уровень из редактора":
                                    {
                                        if (x == 4)
                                        {
                                            string file = @"Map1.txt";
                                            if (File.Exists(file))
                                            {
                                                string[] lines = File.ReadAllLines(file);
                                                int[,] num = new int[25, 25];
                                                for (int i = 0; i < lines.Length; i++)
                                                {
                                                    string[] temp = lines[i].Split(' ');
                                                    for (int j = 0; j < temp.Length - 1; j++)
                                                        num[i, j] = Convert.ToInt32(temp[j]);
                                                }
                                                maparr = num;
                                            }
                                            else if (!File.Exists(file))
                                            {
                                                Set(ref maparr);
                                                maparr = new int[25, 25]{{ 0,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,0 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                                                     { 0,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,0 } };
                                                using (StreamWriter sw = File.AppendText(file))
                                                {
                                                    for (int i = 0; i <= 24; i++)
                                                    {
                                                        for (int j = 0; j <= 24; j++)
                                                        {
                                                            sw.Write("{0} ", (maparr[i, j]));
                                                        }
                                                        sw.WriteLine();
                                                    }
                                                }
                                            }
                                            Rend(maparr);
                                            Game(maparr);
                                            x = 1;
                                        }
                                    }
                                    break;
                            }
                        }
                        break;
                }
                key = Console.ReadKey(true);
            }
        }

        static void Rend(int[,] maparr)
        {
            Console.Clear();
            {
                for (int i = 0; i <= 24; i++)
                {
                    for (int j = 0; j <= 24; j++)
                    {
                        if (maparr[i, j] == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("2 ");
                        }
                        if (maparr[i, j] == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("O ");
                        }
                        if (maparr[i, j] == 1)
                        {
                            Console.Write("X ");
                        }
                        if (maparr[i, j] == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("[]");
                        }
                        if (maparr[i, j] == 0)
                        {
                            Console.ResetColor();
                            Console.Write("  ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

        static void Set(ref int[,] maparr)
        {
            maparr = new int[25, 25] {{ 0,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,0 },
                                       { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                       { 2,0,0,0,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,0,0,0,0,0,2 },
                                       { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,0,0,0,0,0,0,2 },
                                       { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                       { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                       { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                       { 2,0,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                       { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3,0,0,0,0,0,0,2 },
                                       { 2,0,0,0,0,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                       { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                       { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                       { 2,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,2 },
                                       { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                       { 2,0,0,0,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                       { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                       { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                       { 2,0,0,0,0,0,0,3,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                       { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                       { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,4,0,0,0,0,0,0,2 },
                                       { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                       { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                       { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                       { 2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2 },
                                       { 0,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2,0 } };
        }

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int[,] maparr = new int[100, 100];
            Set(ref maparr);
            Menu(maparr);
        }
    }
}

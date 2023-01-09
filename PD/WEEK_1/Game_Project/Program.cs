using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using EZInput;
using System.IO;

using System.Text;
using System.Threading.Tasks;

namespace gamecsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] plane = new char[2, 3]   {
                { ' ', '^', ' '},
                    { '<', '=', '>'}
            };
            int ship_uper_part_x = 20;
            int ship_uper_part_y = 27;
            int ship_inner_part_x = 21;
            int ship_inner_part_y = 27;
            int ship_right_part_y = 28;
            int ship_right_part_x = 21;
            int ship_left_part_x = 21;
            int ship_left_part_y = 26;
            char previousitem = ' ';
            // ___________________________ eniemies level 1 _______________________

            int enemy_upper_part_x = 2;
            int enemy_upper_part_y = 38;
            int enemy_inner_part_x = 3;
            int enemy_inner_part_y = 38;
            int last_enemy_lives = 5;
            int enemy_right_part_y = 39;
            int enemy_right_part_x = 3;
            int enemy_left_part_x = 3;
            int enemy_left_part_y = 36;
            int enemy_lower_part_x = 4;
            int enemy_lower_part_y = 38;
            // enemy 3
            int enemy3_upper_part_x = 1;
            int enemy3_upper_part_y = 30;
            int enemy3_inner_part_x = 2;
            int enemy3_inner_part_y = 30;

            int enemy3_right_part_y = 31;
            int enemy3_right_part_x = 2;
            int enemy3_left_part_x = 2;
            int enemy3_left_part_y = 29;
            int enemy3_lower_part_x = 3;
            int enemy3_lower_part_y = 30;
            // enemy2
            int enemy2_upper_part_x = 2;
            int enemy2_upper_part_y = 4;
            int enemy2_inner_part_x = 3;
            int enemy2_inner_part_y = 4;
            int enemy2_right_part_y = 5;
            int enemy2_right_part_x = 3;
            int enemy2_left_part_x = 3;
            int enemy2_left_part_y = 2;
            int enemy2_lower_part_x = 4;
            int enemy2_lower_part_y = 4;
            char[,] maze = new char[24, 71];
            string path = "E:\\semester2\\game\\gamecsharp\\gamecsharp\\bin\\Debug\\maze.txt";
            read_data(path, maze);
            print_maze(maze);
            while (true)
            {
                Thread.Sleep(70);
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    moveshipUp(maze, ref ship_uper_part_x, ref ship_uper_part_y, ref ship_inner_part_x, ref ship_inner_part_y, ref ship_right_part_x, ref ship_right_part_y, ref ship_left_part_x, ref ship_left_part_y, ref previousitem);
                }
                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    moveshipDown(maze, ref ship_uper_part_x, ref ship_uper_part_y, ref ship_inner_part_x, ref ship_inner_part_y, ref ship_right_part_x, ref ship_right_part_y, ref ship_left_part_x, ref ship_left_part_y, ref previousitem);
                }
                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    moveshipRight(maze, ref ship_uper_part_x, ref ship_uper_part_y, ref ship_inner_part_x, ref ship_inner_part_y, ref ship_right_part_x, ref ship_right_part_y, ref ship_left_part_x, ref ship_left_part_y, ref previousitem);
                }
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    moveshipLeft(maze, ref ship_uper_part_x, ref ship_uper_part_y, ref ship_inner_part_x, ref ship_inner_part_y, ref ship_right_part_x, ref ship_right_part_y, ref ship_left_part_x, ref ship_left_part_y, ref previousitem);
                }
                if (Keyboard.IsKeyPressed(Key.Space))
                {
                    FIRE(maze, ref ship_uper_part_x, ref ship_uper_part_y);
                }
                if (ENEMY1TRUE)
                {
                    enemyfirst(maze, ref enemy_upper_part_x, ref enemy_upper_part_y, ref enemy_inner_part_x, ref enemy_inner_part_y, ref enemy_right_part_x, ref enemy_right_part_y, ref enemy_left_part_x, ref enemy_left_part_y, ref enemy_lower_part_x, ref enemy_lower_part_y);
                }
                else
                {
                    endfires1enemy();
                }
                enemy1fire();

            }
            Console.ReadKey();

        }
        void enemyfirst(char[,] maze, ref int enemy_upper_part_x, ref int enemy_upper_part_y, ref int enemy_inner_part_x, ref int enemy_inner_part_y, ref int enemy_right_part_x, ref int enemy_right_part_y, ref int enemy_left_part_x, ref int enemy_left_part_y, ref int enemy_lower_part_x, ref int enemy_lower_part_y)
        {
            /*  if (count == 1)
              {
                  SetConsoleTextAttribute(color, 6);
              }*/

            if (enemy1 == 0)
            {
                if (maze[enemy_right_part_x, enemy_right_part_y + 1] != '|')
                {

                    // upper
                    previousitem = maze[enemy_upper_part_x, enemy_upper_part_y + 1];
                    gotoxy(enemy_upper_part_y, enemy_upper_part_x);
                    cout << previousitem;
                    maze[enemy_upper_part_x, enemy_upper_part_y] = previousitem;
                    enemy_upper_part_y = enemy_upper_part_y + 1;
                    gotoxy(enemy_upper_part_y, enemy_upper_part_x);
                    cout << "_";
                    maze[enemy_upper_part_x][enemy_upper_part_y] = '_';
                    // right
                    previousitem = maze[enemy_right_part_x][enemy_right_part_y + 1];
                    gotoxy(enemy_right_part_y, enemy_right_part_x);
                    cout << previousitem;
                    maze[enemy_right_part_x][enemy_right_part_y] = previousitem;
                    enemy_right_part_y = enemy_right_part_y + 1;
                    maze[enemy_right_part_x][enemy_right_part_y] = '>';
                    gotoxy(enemy_right_part_y, enemy_right_part_x);
                    cout << ">";
                    //  iner
                    previousitem = maze[enemy_inner_part_x][enemy_inner_part_y + 1];
                    gotoxy(enemy_inner_part_y, enemy_inner_part_x);
                    cout << previousitem;
                    enemy_inner_part_y = enemy_inner_part_y + 1;
                    gotoxy(enemy_inner_part_y, enemy_inner_part_x);
                    cout << "_";
                    maze[enemy_inner_part_x][enemy_inner_part_y];
                    // left
                    previousitem = maze[enemy_left_part_x][enemy_left_part_y + 1];
                    gotoxy(enemy_left_part_y, enemy_left_part_x);
                    cout << previousitem;
                    maze[enemy_left_part_x][enemy_left_part_y] = previousitem;
                    enemy_left_part_y = enemy_left_part_y + 1;
                    maze[enemy_left_part_x][enemy_left_part_y] = '<';
                    gotoxy(enemy_left_part_y, enemy_left_part_x);
                    cout << "<";

                    // lower
                    previousitem = maze[enemy_lower_part_x][enemy_lower_part_y + 1];
                    gotoxy(enemy_lower_part_y, enemy_lower_part_x);
                    cout << previousitem;
                    maze[enemy_lower_part_x][enemy_lower_part_y] = previousitem;
                    enemy_lower_part_y = enemy_lower_part_y + 1;
                    gotoxy(enemy_lower_part_y, enemy_lower_part_x);
                    cout << "*";
                    maze[enemy_lower_part_x][enemy_lower_part_y] = '*';
                }
                if (maze[enemy_right_part_x][enemy_right_part_y + 1] == '|')
                {
                    enemy1 = 1;
                }
            }
            if (enemy1 == 1)
            {

                if (maze[enemy_right_part_x][enemy_right_part_y - 1] != '|')
                {
                    // upper
                    previousitem = maze[enemy_upper_part_x][enemy_upper_part_y - 1];
                    gotoxy(enemy_upper_part_y, enemy_upper_part_x);
                    cout << previousitem;
                    maze[enemy_upper_part_x][enemy_upper_part_y] = previousitem;
                    enemy_upper_part_y = enemy_upper_part_y - 1;
                    gotoxy(enemy_upper_part_y, enemy_upper_part_x);
                    cout << "_";
                    maze[enemy_upper_part_x][enemy_upper_part_y] = '_';
                    // left
                    previousitem = maze[enemy_left_part_x][enemy_left_part_y - 1];
                    gotoxy(enemy_left_part_y, enemy_left_part_x);
                    cout << previousitem;
                    maze[enemy_left_part_x][enemy_left_part_y] = previousitem;
                    enemy_left_part_y = enemy_left_part_y - 1;
                    maze[enemy_left_part_x][enemy_left_part_y] = '<';
                    gotoxy(enemy_left_part_y, enemy_left_part_x);
                    cout << "<";
                    //  iner
                    previousitem = maze[enemy_inner_part_x][enemy_inner_part_y - 1];
                    gotoxy(enemy_inner_part_y, enemy_inner_part_x);
                    cout << previousitem;
                    enemy_inner_part_y = enemy_inner_part_y - 1;
                    gotoxy(enemy_inner_part_y, enemy_inner_part_x);
                    cout << "_";
                    maze[enemy_inner_part_x][enemy_inner_part_y];
                    // right
                    previousitem = maze[enemy_right_part_x][enemy_right_part_y - 1];
                    gotoxy(enemy_right_part_y, enemy_right_part_x);
                    cout << previousitem;
                    maze[enemy_right_part_x][enemy_right_part_y] = previousitem;
                    enemy_right_part_y = enemy_right_part_y - 1;
                    maze[enemy_right_part_x][enemy_right_part_y] = '>';
                    gotoxy(enemy_right_part_y, enemy_right_part_x);
                    cout << ">";

                    // lower
                    previousitem = maze[enemy_lower_part_x][enemy_lower_part_y - 1];
                    gotoxy(enemy_lower_part_y, enemy_lower_part_x);
                    cout << previousitem;
                    maze[enemy_lower_part_x][enemy_lower_part_y] = previousitem;
                    enemy_lower_part_y = enemy_lower_part_y - 1;
                    gotoxy(enemy_lower_part_y, enemy_lower_part_x);
                    cout << "*";
                    maze[enemy_lower_part_x][enemy_lower_part_y] = '*';
                }
                if (maze[enemy_right_part_x][enemy_right_part_y - 1] == '|')
                {
                    enemy1 = 0;
                }
            }
            
        }
        static void FIRE(char[,] maze, ref int ship_uper_part_x, ref int ship_uper_part_y)
        {

            Console.SetCursorPosition(ship_uper_part_y, ship_uper_part_x - 1);
            Console.Write("!");
            maze[ship_uper_part_x - 1, ship_uper_part_y] = '!';
        }

        static void moveshipLeft(char[,] maze, ref int ship_uper_part_x, ref int ship_uper_part_y, ref int ship_inner_part_x, ref int ship_inner_part_y, ref int ship_right_part_x, ref int ship_right_part_y, ref int ship_left_part_x, ref int ship_left_part_y, ref char previousitem)
        {
            if (maze[ship_left_part_x, ship_left_part_y - 1] != '|')
            {
                maze[ship_uper_part_x, ship_uper_part_y] = ' ';
                maze[ship_inner_part_x, ship_inner_part_y] = ' ';
                maze[ship_left_part_x, ship_left_part_y] = ' ';
                maze[ship_right_part_x, ship_right_part_y] = ' ';
                Console.SetCursorPosition(ship_uper_part_y, ship_uper_part_x);
                Console.Write(" ");
                Console.SetCursorPosition(ship_inner_part_y, ship_inner_part_x);
                Console.Write(" ");
                Console.SetCursorPosition(ship_left_part_y, ship_left_part_x);
                Console.Write(" ");
                Console.SetCursorPosition(ship_right_part_y, ship_right_part_x);
                Console.Write(" ");

                ship_uper_part_y = ship_uper_part_y - 1;
                ship_inner_part_y = ship_inner_part_y - 1;
                ship_left_part_y = ship_left_part_y - 1;
                ship_right_part_y = ship_right_part_y - 1;

                maze[ship_uper_part_x, ship_uper_part_y] = '^';

                maze[ship_inner_part_x, ship_inner_part_y] = '=';
                maze[ship_left_part_x, ship_left_part_y] = '<';
                maze[ship_right_part_x, ship_right_part_y] = '>';
                //  SetConsoleTextAttribute(color, 4);
                Console.SetCursorPosition(ship_uper_part_y, ship_uper_part_x);
                Console.Write("^");
                Console.SetCursorPosition(ship_inner_part_y, ship_inner_part_x);
                Console.Write("=");
                Console.SetCursorPosition(ship_left_part_y, ship_left_part_x);
                Console.Write("<");
                Console.SetCursorPosition(ship_right_part_y, ship_right_part_x);
                Console.Write(">");
                //  SetConsoleTextAttribute(color, 7);
            }
        }
        static void moveshipRight(char[,] maze, ref int ship_uper_part_x, ref int ship_uper_part_y, ref int ship_inner_part_x, ref int ship_inner_part_y, ref int ship_right_part_x, ref int ship_right_part_y, ref int ship_left_part_x, ref int ship_left_part_y, ref char previousitem)
        {
            if (maze[ship_right_part_x, ship_right_part_y + 1] != '|')
            {
                maze[ship_uper_part_x, ship_uper_part_y] = ' ';
                maze[ship_inner_part_x, ship_inner_part_y] = ' ';
                maze[ship_left_part_x, ship_left_part_y] = ' ';
                maze[ship_right_part_x, ship_right_part_y] = ' ';
                Console.SetCursorPosition(ship_uper_part_y, ship_uper_part_x);
                Console.Write(" ");
                Console.SetCursorPosition(ship_inner_part_y, ship_inner_part_x);
                Console.Write(" ");
                Console.SetCursorPosition(ship_left_part_y, ship_left_part_x);
                Console.Write(" ");
                Console.SetCursorPosition(ship_right_part_y, ship_right_part_x);
                Console.Write(" ");

                ship_uper_part_y = ship_uper_part_y + 1;
                ship_inner_part_y = ship_inner_part_y + 1;
                ship_left_part_y = ship_left_part_y + 1;
                ship_right_part_y = ship_right_part_y + 1;

                maze[ship_uper_part_x, ship_uper_part_y] = '^';
                maze[ship_inner_part_x, ship_inner_part_y] = '=';
                maze[ship_left_part_x, ship_left_part_y] = '<';
                maze[ship_right_part_x, ship_right_part_y] = '>';
                // SetConsoleTextAttribute(color, 4);
                Console.SetCursorPosition(ship_uper_part_y, ship_uper_part_x);
                Console.Write("^");
                Console.SetCursorPosition(ship_inner_part_y, ship_inner_part_x);
                Console.Write("=");
                Console.SetCursorPosition(ship_left_part_y, ship_left_part_x);
                Console.Write("<");
                Console.SetCursorPosition(ship_right_part_y, ship_right_part_x);
                Console.Write(">");
                //  SetConsoleTextAttribute(color, 7);
            }
        }
        static void moveshipDown(char[,] maze, ref int ship_uper_part_x, ref int ship_uper_part_y, ref int ship_inner_part_x, ref int ship_inner_part_y, ref int ship_right_part_x, ref int ship_right_part_y, ref int ship_left_part_x, ref int ship_left_part_y, ref char previousitem)
        {

            if (maze[ship_inner_part_x + 1, ship_inner_part_y] != '#')
            {
                maze[ship_uper_part_x, ship_uper_part_y] = ' ';
                maze[ship_inner_part_x, ship_inner_part_y] = ' ';
                maze[ship_left_part_x, ship_left_part_y] = ' ';
                maze[ship_right_part_x, ship_right_part_y] = ' ';
                Console.SetCursorPosition(ship_uper_part_y, ship_uper_part_x);
                Console.Write(" ");
                Console.SetCursorPosition(ship_inner_part_y, ship_inner_part_x);
                Console.Write(" ");
                Console.SetCursorPosition(ship_left_part_y, ship_left_part_x);
                Console.Write(" ");
                Console.SetCursorPosition(ship_right_part_y, ship_right_part_x);
                Console.Write(" ");

                ship_uper_part_x = ship_uper_part_x + 1;
                ship_inner_part_x = ship_inner_part_x + 1;
                ship_left_part_x = ship_left_part_x + 1;
                ship_right_part_x = ship_right_part_x + 1;
                maze[ship_uper_part_x, ship_uper_part_y] = '^';
                maze[ship_inner_part_x, ship_inner_part_y] = '=';
                maze[ship_left_part_x, ship_left_part_y] = '<';
                maze[ship_right_part_x, ship_right_part_y] = '>';
                //  SetConsoleTextAttribute(color, 4);
                Console.SetCursorPosition(ship_uper_part_y, ship_uper_part_x);
                Console.Write("^");
                Console.SetCursorPosition(ship_inner_part_y, ship_inner_part_x);
                Console.Write("=");
                Console.SetCursorPosition(ship_left_part_y, ship_left_part_x);
                Console.Write("<");
                Console.SetCursorPosition(ship_right_part_y, ship_right_part_x);
                Console.Write(">");
                //  SetConsoleTextAttribute(color, 7);
            }
        }
        static void moveshipUp(char[,] maze, ref int ship_uper_part_x, ref int ship_uper_part_y, ref int ship_inner_part_x, ref int ship_inner_part_y, ref int ship_right_part_x, ref int ship_right_part_y, ref int ship_left_part_x, ref int ship_left_part_y, ref char previousitem)
        {
            if (maze[ship_uper_part_x - 1, ship_uper_part_y] != '#')
            {
                maze[ship_uper_part_x, ship_uper_part_y] = ' ';
                maze[ship_inner_part_x, ship_inner_part_y] = ' ';
                maze[ship_left_part_x, ship_left_part_y] = ' ';
                maze[ship_right_part_x, ship_right_part_y] = ' ';
                Console.SetCursorPosition(ship_uper_part_y, ship_uper_part_x);
                Console.Write(" ");
                Console.SetCursorPosition(ship_inner_part_y, ship_inner_part_x);
                Console.Write(" ");
                Console.SetCursorPosition(ship_left_part_y, ship_left_part_x);
                Console.Write(" ");
                Console.SetCursorPosition(ship_right_part_y, ship_right_part_x);
                Console.Write(" ");

                ship_uper_part_x = ship_uper_part_x - 1;
                ship_inner_part_x = ship_inner_part_x - 1;
                ship_left_part_x = ship_left_part_x - 1;
                ship_right_part_x = ship_right_part_x - 1;
                maze[ship_uper_part_x, ship_uper_part_y] = '^';
                maze[ship_inner_part_x, ship_inner_part_y] = '=';
                maze[ship_left_part_x, ship_left_part_y] = '<';
                maze[ship_right_part_x, ship_right_part_y] = '>';
                //          SetConsoleTextAttribute(color, 4);
                Console.SetCursorPosition(ship_uper_part_y, ship_uper_part_x);
                Console.Write("^");
                Console.SetCursorPosition(ship_inner_part_y, ship_inner_part_x);
                Console.Write("=");
                Console.SetCursorPosition(ship_left_part_y, ship_left_part_x);
                Console.Write("<");
                Console.SetCursorPosition(ship_right_part_y, ship_right_part_x);
                Console.Write(">");
                //    SetConsoleTextAttribute(color, 7);
            }
        }
        static void print_maze(char[,] maze)
        {
            for (int row = 0; row < 24; row++)
            {
                for (int col = 0; col < 71; col++)
                {
                    Console.Write(maze[row, col]);
                }
                Console.WriteLine();
            }
        }
        static void read_data(string path, char[,] maze)
        {
            StreamReader file = new StreamReader(path);
            string record;

            if (File.Exists(path))
            {
                int row = 0;
                while ((record = file.ReadLine()) != null)
                {
                    for (int a = 0; a < 70; a++)
                    {
                        maze[row, a] = record[a];

                    };
                    row = row + 1;
                }
            }
            file.Close();
        }

    }
}

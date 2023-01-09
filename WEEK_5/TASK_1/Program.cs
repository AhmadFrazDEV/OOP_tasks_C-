using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TASK_1.BL;
using TASK_1.UI;

namespace TASK_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            mypoint Points1 = new mypoint();
            mypoint Points2 = new mypoint();
            MyLine Line = new MyLine(Points1, Points2);
            while(true)
            {
                string option =MENUUI.menu();
                if(option == "1")
                {
                    int X, Y;
                    Console.WriteLine("Enter begin X cordinate");
                    X = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter begin Y cordinate");
                    Y = int.Parse(Console.ReadLine());
                    Points1 = new mypoint(X, Y);

                    int X2, Y2;
                    Console.WriteLine("Enter End X cordinate");
                    X2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter End Y cordinate");
                    Y2 = int.Parse(Console.ReadLine());
                    Points2 = new mypoint(X2,Y2);
                    Line = new MyLine(Points1, Points2);

                }
                else if(option == "2")
                {
                    mypoint newpoint=Line.getBegin();
                    Console.WriteLine("Enter Update Begin Point");
                    int X = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Update Begin Point");
                    int Y = int.Parse(Console.ReadLine());
                    newpoint.setXY(X, Y);
                    Line.setBegin(newpoint);
                }
                else if(option == "3")
                {
                    mypoint newpoint = Line.getEnd();
                    Console.WriteLine("Enter Update End Point");
                    int X = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Update End Point");
                    int Y = int.Parse(Console.ReadLine());
                    newpoint.setXY(X, Y);
                    Line.setEnd(newpoint);
                }
                else if(option == "4")
                {
                    mypoint newpoint = Line.getBegin();
                    Console.WriteLine("Update Begin Point X is " + newpoint.getX() +"  Update Begin point Y is "+newpoint.getY());
                }
                else if(option == "5")
                {
                    mypoint newpoint = Line.getEnd();
                    Console.WriteLine("Update End Point X is " + newpoint.getX() + "  Update End point Y is " + newpoint.getY());
                }
                else if (option == "6")
                {
                    double result = Points1.distanceWithObject(Points1);
                    Console.WriteLine("Length of the Line is " + result);
                }
                else if(option == "7")
                {
                    double result = Line.getGradient();
                    Console.WriteLine("Length of Gradient is " + result);
                }
                else if(option == "8")
                {
                    double result = Points1.distanceFromZero();
                    Console.WriteLine("Distance of Begin Point From " + result);
                }
                else if(option == "9")
                {
                    double result = Points2.distanceFromZero();
                    Console.WriteLine("Distance of Begin Point From " + result);
                }
                else if(option == "10")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}

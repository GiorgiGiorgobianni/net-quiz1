using System;
using net_quiz_1;


class Program
{
  
    static void Main(string[] args)
    {
        #region Task1
        int myAge = 20;
        double bankBalance = 1234.5;
        if (bankBalance >= 1000)
        {
            Console.WriteLine("You have a healthy bank balance");
        }
        else
        {
            Console.WriteLine("I need to save money");
        }
        #endregion

        #region Task2
        Rectangle rectangle = new Rectangle(2.1, 3.2);
        rectangle.DisplayRectangleArea();

        Circle circle = new Circle(3);
        circle.DisplayCircleInfo();
        #endregion

        #region Task 3
        Person person = new Person(4, "Gio");
        person.PrintDetails();
        #endregion

    }




}


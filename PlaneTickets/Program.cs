using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlaneTickets.Classes;

namespace PlaneTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Application.Run(new Form1());

            const string str = "======Лабораторна робота №1======\n" +
                               "=Виконали студенти групи IТ-81: =\n" +
                               "=Гончаров Олександр IТ-8129     =\n" +
                               "=Щупiй Кирило IТ-8130           =\n" +
                               "=================================\n";
            Console.WriteLine(str);

            CtorsTest.Test();
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}

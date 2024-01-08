using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_CustomList_DanielMinty
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CustomList<double> list = new CustomList<double>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            list.AddAtIndex(1.5, 1);
            list.AddAtIndex(3.5, 4);
            list.AddAtIndex(5.5, 7);

            list.Remove(4);
            list.Remove(2);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            //Test CheckIntegrity()
            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }

            Console.ReadLine();

        }
    }
}

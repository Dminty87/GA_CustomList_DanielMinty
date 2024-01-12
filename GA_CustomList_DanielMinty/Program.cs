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
            //Create a new CustomList
            CustomList<double> list = new CustomList<double>();

            //Test the Add method
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            //Test the AddAtIndex method
            list.AddAtIndex(1.5, 1);
            list.AddAtIndex(3.5, 4);
            list.AddAtIndex(5.5, 7);

            //Test the Remove method
            list.Remove(4);
            list.Remove(2);

            //Test the GetItem method and Count property
            //for each index from 0 to Count-1
            for (int i = 0; i < list.Count; i++)
            {
                //print the item at the current index using GetItem
                Console.WriteLine(list.GetItem(i));
                //Expected result { 1, 1.5, 3, 3.5, 5, 5.5 } each on a new line

            }

            //Test CheckIntegrity method by adding numerous items to the list
            for (int i = 0; i < 10000; i++)
            {
                list.Add(i);
            }

            //Keep the console availible for the user to read
            Console.ReadLine();

        }
    }
}

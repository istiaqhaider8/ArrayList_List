using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Istiaq
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList myList = new ArrayList();

            //myList.Add(100);
            //myList.Add(300);
            //myList.Add("English");

            List<int> myList = new List<int>();

            myList.Add(199);
            myList.Add(299);
            myList.Add(299);
            myList.Add(299);
            myList.Add(299);
            myList.Add(299);

            foreach(object myNumbers in myList)
            {
                Console.WriteLine(myNumbers);
            }

            Console.ReadKey();
        }
    }
}

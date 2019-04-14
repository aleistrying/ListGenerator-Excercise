using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3C2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> vList = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                vList.Add(i);
            }
            for (int i = 0; i < vList.Count; i++)
            {
                Console.WriteLine(vList[i]);
            }
            for (int i = vList.Count - 1; i >= 0; i--)
            {
                if (vList[i] % 2 == 0)
                {
                    vList.Remove(vList[i]);
                }
            }
            for (int i = 0; i < vList.Count; i++)
            {
                Console.WriteLine(vList[i]);
            }

            List<int> fList = new List<int>();
            for (int i = 1; i <= 5; i++)
            {
                fList.Add(i);
            }
            Console.WriteLine();
            for (int i = 0; i < fList.Count; i++)
            {
                Console.WriteLine(fList[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                if(fList[i] == 1 || fList[i] == 2 || fList[i] == 3)
                {
                    fList.Remove(fList[i]);
                }

            }
            for (int i = 0; i < fList.Count; i++)
            {
                Console.WriteLine(fList[i]);
            }

            Console.ReadLine();
        }
    }
}

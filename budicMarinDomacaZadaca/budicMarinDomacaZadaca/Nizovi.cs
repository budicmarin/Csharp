using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budicMarinDomacaZadaca
{
    class Nizovi
    {
        public void Zadatak1()
        {
            int num;
            int[] arry = new int[10];
            for(int i=0;i<10;i++)
            {
                num = Convert.ToInt32(Console.ReadLine());
                arry[i] = num*num;

            }
            foreach(int g in arry)
            {
                Console.WriteLine(g);
            }
        }
        public void Zadatak2()
        {
            int[] arry = { 1, 2, 3, 4, 5, 6, 7, 8, 9,};
            int[] arry2 = { 2, 12, 32, 52, 45, 789, 98, 10, 23 };
            bool ima = false;
            int counter = 0;
            for(int i=0;i<9;i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (arry[i] == arry2[j])
                    {
                        ima = true; counter++; break;
                    }
                }
            }
            if (ima) Console.WriteLine("Ima "+counter+" isti element");
            else Console.WriteLine("Nemaju iste elemente");


        }
        public void Zadatak3()
        {
            int[] arry = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arry2 = { 23, 14, 25, 16, 78, 90, 14, 10, 123, 32 };
            int[] arry3 = arry;
        }
        public void Zadatak4()
        {
            int[,] arry = new int[11,11];
            for(int i=0;i<11;i++)
            {
                for(int j=0;j<11;j++)
                {
                    arry[i,j] = i * j;
                }
            }
            Console.WriteLine(arry[7,5]);

        }
        public void Zadatak5()
        {
            int []arry = new int[10];
            int[] arry1 = new int[10];
            int counter = 0;
            int counter1 = 0;
            int num ;
            bool istina = true;
            while(counter!=10&&counter1!=10&&istina)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                {
                    istina = false;
                }
                if (num % 2 != 0)
                {
                    arry[counter] = num;
                    counter++;
                }
                if (num % 2 == 0)
                {
                    arry1[counter1] = num;
                    counter1++;
                }
            }
            foreach (int g in arry) Console.Write(g+" ");
            Console.WriteLine();
            foreach (int h in arry1) Console.Write(h+" ");
        }
    }
}
 
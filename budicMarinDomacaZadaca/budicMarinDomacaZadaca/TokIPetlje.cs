using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budicMarinDomacaZadaca
{
    class TokIPetlje
    {
        public void Zadatak1()
        {
            string temp = Console.ReadLine();
            if (temp.Length <= 4)
            {
                Console.WriteLine(temp);
            }
            else
            {
                string newstring = temp.Remove(0, 2);
                newstring = newstring.Remove(newstring.Length - 2);

                Console.WriteLine(newstring);
            }
        }
        public void Zadatak2()
        {
            int godina = Convert.ToInt32(Console.ReadLine());
            if (godina % 4 == 0)
            {
                Console.WriteLine("U godini " + godina + " održavaju se ljetne olimpijske igre");
            }
            else if ((godina - 2) % 4 == 0)
            {
                Console.WriteLine("U godini " + godina + " održavaju se zinske olimpijske igre");
            }
            else
            {
                Console.WriteLine("U godini " + godina + " ne održavaju se olimpijske igre");
            }
        }
        public void Zadatak3()
        {
            int broj = Convert.ToInt32(Console.ReadLine());
            if (broj % 4 == 0 && broj % 6 == 0) Console.WriteLine("Broj je djeljiv sa 4 i sa 6");
            else if (!(broj % 4 == 0) && !(broj % 6 == 0)) Console.WriteLine("Broj nije djeljiv sa 4 ni sa 6");
            else if (broj % 4 == 0) Console.WriteLine("Broj je djeljiv s 4");
            else if (broj % 6 == 0) Console.WriteLine("Broj je djeljiv s 6");
        }
        public void Zadatak4()
        {
            string hrvStranica = Console.ReadLine();
            if (hrvStranica.Substring(0, 4) == "www.")
            {
                if (hrvStranica.Substring(hrvStranica.Length - 3) == ".hr") Console.WriteLine("Ovo je hrvatska stranica");
                else Console.WriteLine("Ovo nije hrvatska stranica");
            }
            else
            {
                Console.WriteLine("Ovo nije web stranica");
            }
        }
        public void Zadatak5()
        {
            for (int i = 1; i <= 1001; i++)
            {
                if (i % 2 != 0) Console.WriteLine(i);

            }
        }
        public void Zadatak6()
        {
            string temp = Console.ReadLine();
            int i = temp.Length;
            i = i - 1;
            while (!(temp.Length <= 0))
            {
                Console.WriteLine(temp);
                temp = temp.Substring(0, i);
                i--;
            }

        }
        public void Zadatak7()
        {
            int zastavica;
            int num = 100;
            for (int i=1;i<=num;i++)
            {
                zastavica = 0;
                for (int j = 2; j <=i/2; j++)
                {
                    if (i % j == 0)
                    {
                        
                        zastavica = 1;
                        break;
                        
                    }
                }
                
                if (zastavica == 0 &&i!=1)
                {
                    Console.WriteLine(i);
                }

            }
        }
        public void Zadatak8()
        {
            int zbroj = 0;
            Console.WriteLine("Upiši vrijednosti karta od 1-13");
            while (!(zbroj >=31))
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num >= 1 &&num<= 13)
                {
                    zbroj = zbroj + num;
                }
                else
                {
                    Console.WriteLine("Upisao si broj koji nije u intervalu od 1-13");
                }

               
                
            }
            if (zbroj == 31) Console.WriteLine("Pobijedio si");
            if (zbroj > 31) Console.WriteLine("Izgubio si");




        }
        public void Zadatak9()
        {
            Console.WriteLine(Math.PI);
        }
        public void Zadatak10()
        {
            int num;
            int number=Convert.ToInt32(Console.ReadLine());
            num = number.ToString().Length;
            int[] arr=new int [num];
            int counter = 0;
           while(number!=0)
            {
                int temp = number;
                number = number / 10;
                arr[counter] = temp - (number * 10);
            }
            bool ima = false;
           for(int i=0;i<arr.Length;i++)
            {
                for (int j=0;j<arr.Length;j++)
                {
                    if (i != j)
                    {
                        if (arr[i] == arr[j])
                        {
                            ima = true;
                            
                        }
                    }
                }
            }
            if (ima==true)
            {
                Console.WriteLine("Ne");
            }
            else
            {
                Console.WriteLine("Da");
            }

        }
        

    }
}

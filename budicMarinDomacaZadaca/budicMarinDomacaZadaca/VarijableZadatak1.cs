using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budicMarinDomacaZadaca
{
    class VarijableZadatak
    {
        public void varijable1()
        {
            byte a= 100;
            byte b= 3;
            int x = a / b;
            double y = a % b;
            Console.WriteLine("a/b = "+x);
            Console.WriteLine("a%b = " + y);

        }
        public void varijable2()
        {
            Console.WriteLine("Upisi niz znakova");
            string temp=Console.ReadLine();
            string sVelika = temp.ToUpper();
            Console.WriteLine(sVelika);
            string sMala = temp.ToLower();
            Console.WriteLine(sMala);
            string sPrvaTri=temp.Substring(0,3);
            Console.WriteLine(sPrvaTri);
            
            string sZadnjihPet = temp.Substring(temp.Length - 5);
            Console.WriteLine(sZadnjihPet);
            if (temp.Length > 11)
            {
                string s8_11 = temp.Substring(8, 11);
                Console.WriteLine(s8_11);
            }
            else
            {
                Console.WriteLine("Nemogu prinaći niz od 8 do 11 znaka");
            }



        }
        public void varijable3()
        {
            string temp = Console.ReadLine();
            temp=temp.Replace("\u0020", "_" );
            Console.WriteLine(temp);
        }
        public void varijable4()
        {
            int f = Convert.ToInt32(Console.ReadLine());
            int c = (f - 32) * 5 / 9;
            Console.WriteLine(f + "Farenhitea = " + c + "Celsiusa ");
        }
    }
}

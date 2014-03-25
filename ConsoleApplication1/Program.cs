using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LOTO
{
    class Loto
        static void Main(string[] args)
        {
            int[] tabLoto = new int[6];
            int verif;
            Random toto = new Random();
            DateTime dateTirage = DateTime.Now;

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("*     ****            *     ****  *****  ****    ");
            Console.WriteLine("*     **              *     *  *    *    *  *    ");
            Console.WriteLine("****  ***             ****  ****    *    ****    ");
            Console.WriteLine("\n--Nous sommes le : " + dateTirage + "----------");

            for (int i = 0; i < 6; i++)
            {
                verif = toto.Next(149);
                if(tabLoto.Contains(verif)){
                    i = i - 1;
                }else{
                    tabLoto[i] = toto.Next(1,49);
                }
            }
            Console.WriteLine("\n" + tabLoto[0] + "  " + tabLoto[1] + "  " + tabLoto[2] + "  " + tabLoto[3] + "  " + tabLoto[4] + "  " + tabLoto[5]);
            Console.ReadKey(true);
        }
    }
}

using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace dem3
{
    internal class Program
    {
        //. Elabore um programa para calcular quantos dias demora uma tartaruga a subir um poço
        //  de 30m de altura, sabendo que por cada dia que passa a tartaruga sobe 2m e desce 1m.


        static void Main(string[] args)
         {
            int poco = 30;
            int subida = 2;
            int descida = 1;

            
            int alturaAltural = 0;
            int dias = 0;


            for (; alturaAltural < poco; dias++)
            {
                alturaAltural += subida;

                if (alturaAltural < poco) 
                {
                    alturaAltural -= descida;
                }
            }

            Console.WriteLine(dias);
           
        }
    }
}

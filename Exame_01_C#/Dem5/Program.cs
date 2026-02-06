using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dem5
{
    internal class Program
    {
        // Elabore um programa para imprimir o número de dias de um dado mês e ano.Anos
        // bissextos deverão ser tratados convenientemente.
        // Nota:
        // Anos bissextos são múltiplos de 4 e não são múltiplos de 100, exceto os anos múltiplos de
        // 400, que também são bissextos. (2 valores


        static void Main(string[] args)
        {
            //int mes;
            //int ano;
            //int dias = 0;

            //Console.Write("Digite o mês (1 a 12): ");
            //mes = int.Parse(Console.ReadLine());

            //Console.Write("Digite o ano: ");
            //ano = int.Parse(Console.ReadLine());


            //if (mes == 1)
            //{
            //    dias = 31;
            //}
            //else
            //{
            //    if (mes == 2)
            //    {

            //        if (ano % 400 == 0)
            //        {
            //            dias = 29;
            //        }
            //        else
            //        {
            //            if (ano % 100 == 0)
            //            {
            //                dias = 28;
            //            }
            //            else
            //            {
            //                if (ano % 4 == 0)
            //                {
            //                    dias = 29;
            //                }
            //                else
            //                {
            //                    dias = 28;
            //                }
            //            }
            //        }
            //    }
            //    else
            //    {
            //        if (mes == 3)
            //        {
            //            dias = 31;
            //        }
            //        else
            //        {
            //            if (mes == 4)
            //            {
            //                dias = 30;
            //            }
            //            else
            //            {
            //                if (mes == 5)
            //                {
            //                    dias = 31;
            //                }
            //                else
            //                {
            //                    if (mes == 6)
            //                    {
            //                        dias = 30;
            //                    }
            //                    else
            //                    {
            //                        if (mes == 7)
            //                        {
            //                            dias = 31;
            //                        }
            //                        else
            //                        {
            //                            if (mes == 8)
            //                            {
            //                                dias = 31;
            //                            }
            //                            else
            //                            {
            //                                if (mes == 9)
            //                                {
            //                                    dias = 30;
            //                                }
            //                                else
            //                                {
            //                                    if (mes == 10)
            //                                    {
            //                                        dias = 31;
            //                                    }
            //                                    else
            //                                    {
            //                                        if (mes == 11)
            //                                        {
            //                                            dias = 30;
            //                                        }
            //                                        else
            //                                        {
            //                                            if (mes == 12)
            //                                            {
            //                                                dias = 31;
            //                                            }
            //                                        }
            //                                    }
            //                                }
            //                            }
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }

            //   // Console.WriteLine("Número de dias: " + dias);
            //}

            //Console.WriteLine("Número de dias: " + dias);

            
                int ano;

                Console.Write("Digite o ano: ");
                ano = int.Parse(Console.ReadLine());

                if (ano % 400 == 0 || (ano % 4 == 0 && ano % 100 != 0))
                {
                    Console.WriteLine(ano + " é bissexto");
                }
                else
                {
                    Console.WriteLine(ano + " é comum");
                }
            

        }
    }
}










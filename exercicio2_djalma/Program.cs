using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2_djalma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            string cidade = null;

            Console.WriteLine("Para escoler a cidade, digite um número de 1 a 7. ");
            Console.WriteLine("\n1- Atibaia. \n2- Bragança Paulista. \n3- Mairiporã. \n4- Nazaré.");
            Console.WriteLine("5- Terra Preta. \n6- Extrema. \n7- Vargem.");
            Console.Write("\nDigite um dos números acima, e escolha sua cidade: ");
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    cidade = "Atibaia";
                    break;
                case 2:
                    cidade = "Bragança Paulista";
                    break;
                case 3:
                    cidade = "Mairiporã.";
                    break;
                case 4:
                    cidade = "Nazaré Paulista";
                    break;
                case 5:
                    cidade = "Terra Preta";
                    break;
                case 6:
                    cidade = "Extrema";
                    break;
                case 7:
                    cidade = "Vargem";
                    break;

            }
            string dataconvertida = converterdata();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(cidade + ", " + dataconvertida);




            Console.ReadKey();

        }

        public static String converterdata()
        {

            int dia, mes, ano;
            string mesE = null;
            Console.WriteLine("\n\nAgora digite uma data no formato dd/mm/aaaa, NÃO ESQUEÇA DAS BARRAS. ");
            Console.Write("\nDigite uma data: ");
            var dt = Convert.ToDateTime(Console.ReadLine());
            dia = dt.Day;
            mes = dt.Month;
            ano = dt.Year;

            switch (mes)
            {
                case 1:
                    mesE = "Janeiro";
                    break;
                case 2:
                    mesE = "Fevereiro";
                    break;
                case 3:
                    mesE = "Março";
                    break;
                case 4:
                    mesE = "Abril";
                    break;
                case 5:
                    mesE = "Maio";
                    break;
                case 6:
                    mesE = "Junho";
                    break;
                case 7:
                    mesE = "Julho";
                    break;
                case 8:
                    mesE = "Agosto";
                    break;
                case 9:
                    mesE = "Setembro";
                    break;
                case 10:
                    mesE = "Outubro";
                    break;
                case 11:
                    mesE = "Novembro";
                    break;
                case 12:
                    mesE = "Dezembro";
                    break;


            }
            string dtformatada = dia + " de " + mesE + " de " + ano + ".";
            return dtformatada;
        }
    }
}

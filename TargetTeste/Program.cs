using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Collections.Generic;

namespace Target
{



    class Program
    {
        static void Main(string[] args)
        {
            // Ex5 errado e não executando
            Console.WriteLine("Escolha o código");
            Console.WriteLine("1.Código 1:");
            Console.WriteLine("2.Código 2:");
            Console.WriteLine("3.Código 3:");
            Console.WriteLine("4.Código 4:");
            Console.WriteLine("5.Código 5:");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Codigo1();
                    break;
                case "2":
                    Codigo2();
                    break;
                case "3":
                    Codigo3();
                    break;
                case "4":
                    Codigo4();
                    break;
                case "5":
                    Codigo5();
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    return;

            }
        }
        static void Codigo1()
        {
            int indice = 13;

            int soma = 0;
            int k = 0;

            while (k < indice)
            {
                k = k + 1;
                soma = soma + k;
            }
            Console.WriteLine("A soma é " + soma);
        }
        static void Codigo2()
        {
            // criar variável temporária(a1) para mudar o valor de a e guardar o anterior.
            Console.WriteLine("Digite um numero para verificar:");
            int numero = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;

            while (a < numero)
            {
                int a1 = a;
                a = b;
                b = a + b;
            }
            if (a == numero)
            {
                Console.WriteLine("O número " + numero + " pertence a sequencia ");
            }
            else
            {
                Console.WriteLine("Não pertence");
            }

        }
        static void Codigo3()
        {
            // Arquivo não disponível, lista instanciada abaixo com valores aleatórios.

            List<double> fat_diario = new List<double>
            {
                0.0, 5868.0, 0.0, 10000.0, 5858.0, 0.0, 0.0, 898.0, 8888.0, 8630.0,0.0, 8685.0, 5000.0, 9637.0
            };

            // Usar Linq para consultar

            var dias_fat = fat_diario.Where(p => p > 0).ToArray();

            double fat_min = dias_fat.Min();
            double fat_max = dias_fat.Max();

            double med_fat = dias_fat.Average();

            string med_fat_inv = med_fat.ToString("f2", CultureInfo.InvariantCulture);

            int dia_acima_med = dias_fat.Count(p => p > med_fat);

            Console.WriteLine("Menor faturamento: " + fat_min);
            Console.WriteLine("Maior faturamento: " + fat_max);
            Console.WriteLine("Faturamento medio: " + med_fat_inv);
            Console.WriteLine("Dias em que o faturamento foi acima da media: " + dia_acima_med);
        }
        static void Codigo4()
        {
            double sp = 67843.43;
            double rj = 36678.66;
            double mg = 29229.88;
            double es = 27165.48;
            double outros = 19849.53;

            double valor_total = sp + rj + mg + es + outros;
            Console.WriteLine("Valor total:" + valor_total);

            double per_sp = (sp / valor_total) * 100;
            double per_rj = (rj / valor_total) * 100;
            double per_mg = (mg / valor_total) * 100;
            double per_es = (es / valor_total) * 100;
            double per_outros = (outros / valor_total) * 100;


            Console.WriteLine($"SP: {per_sp:F2}%");
            Console.WriteLine($"RJ: {per_rj:F2}%");
            Console.WriteLine($"MG: {per_mg:F2}%");
            Console.WriteLine($"ES: {per_es:F2}%");
            Console.WriteLine($"Outros:{per_outros:F2}%");




        }
        static void Codigo5()
        {
            Console.WriteLine("entrar string");
            string entrada = Console.ReadLine();

            // Inverte 
            string inverter = InverterString(entrada);


        }

        // 
        static string InverterString(string original)
        {
            
            string resultado = "";

            // xxxxxxxxxxxxxxx erro
            for (int i = original.Length; i >= 1; i++)
            {
               
                resultado += original[i];
            }

            return resultado;
        }
    }
}










    
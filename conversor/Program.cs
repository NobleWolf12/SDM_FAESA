using System;
using System.Text.RegularExpressions;

namespace conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            string repetir = "sim";
            string valor = "";
            double num;
            do
            {
                Console.WriteLine("Converter para \nB para Binario D para Digital S para sair: ");
                string tipo = Console.ReadLine();

                if (tipo.ToUpper() != "S")
                {
                    Console.WriteLine("digite o numero a ser convertido: ");
                    valor = Console.ReadLine();
                    double valorConvertido = 0;

                    if (double.TryParse(valor, out num))
                    {

                        switch (tipo.ToUpper())
                        {
                            case "B":

                                Console.WriteLine(DecimalParaBinario(valor));
                                break;

                            case "D":

                                valorConvertido = Convert.ToInt32(valor, 2);
                                Console.WriteLine(valorConvertido);

                                break;


                            default:
                                Console.WriteLine("Opção invalida");
                                break;
                        }

                    }
                    else {
                        Console.WriteLine("Valor invalido!!!");
                    }

                }
                else {
                    repetir = "não";
                    Console.WriteLine("Até mais!!!");
                    Console.WriteLine("Adolfo Santos Gotler");
                }

            } while (repetir == "sim");
        }

        public static string DecimalParaBinario(string numero)
        {

            string valor = "";

            int dividendo = Convert.ToInt32(numero);

            if (dividendo == 0 || dividendo == 1)
            {

                return Convert.ToString(dividendo);

            }

            else
            {

                while (dividendo > 0)
                {

                    valor += Convert.ToString(dividendo % 2);

                    dividendo = dividendo / 2;

                }

                return InverterString(valor);

            }

        }
        public static string InverterString(string str)
        {
            int tamanho = str.Length;

            char[] caracteres = new char[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                caracteres[i] = str[tamanho - 1 - i];
            }

            return new string(caracteres);
        }

    }
}

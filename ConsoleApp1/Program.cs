using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<float> notas = new List<float>();
            int i = 0;
            string valorLido=null;
            float soma;
            float media;
            int nNotas=0;

            while (true)
            { 
                Console.WriteLine($"Digite a {(i + 1)}ª nota (Número real ou inteiro de 0 a 10. Digitar media para obter media  ou sair para sair)");
                valorLido = Console.ReadLine();
                
                if (valorLido == "media")
                {
                    soma = notas.AsQueryable().Sum();
                    media = soma / nNotas;

                    Console.WriteLine($"Sua média é {media}");
                    if (media < 7) 
                    {
                        Console.WriteLine("Você esta abaixo da média, estude mais!");
                    }
                    else 
                    { 
                        Console.WriteLine("Você esta acima da média e foi aprovado!");
                    }
                    i = 0;
                    notas.Clear();
                    Console.ReadKey();
                    Console.Clear();

                }
               
                if (valorLido != "media" && valorLido != "sair")
                {
                    float.Parse(valorLido);
                    notas.Add(float.Parse(valorLido));
                    i++;
                    nNotas = i;
                }
               
                if (valorLido == "sair")
                {
                    break;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_LÓGICA_1____THAYSA_ZOOBY_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] palavras = new string[] { "uva", "abacaxi", "melancia", "banana" };

            Random random = new Random();

            int indiceRandomico = random.Next(palavras.Length);

            string forca = palavras[indiceRandomico];

            char[] forcaArray = forca.ToCharArray();

            string encriptada = "";

            for (int i = 0; i < forcaArray.Length; i++) { encriptada += "_"; }

            char[] encriptadaArray = encriptada.ToCharArray();                        

            Console.WriteLine("ADIVINHE A FRUTA: " + encriptada);          
    
            while (encriptadaArray.Contains('_')) {
               
                Console.WriteLine("DIGITE UMA LETRA: ");

                string letra = Console.ReadLine().ToLower();

                char letraCaractere = letra.ToCharArray()[0];

                for (int i = 0; i < forcaArray.Length; i++)
                {
                    if (forcaArray[i] == letraCaractere) { encriptadaArray[i] = letraCaractere; }                              
                }

                Console.WriteLine(encriptadaArray);
            }

            Console.WriteLine("VOCÊ ESCAPOU DA FORCA!");
        }
    }
}

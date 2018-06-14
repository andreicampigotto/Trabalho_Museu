using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museu
{
    public class Fardas
    {
        string[] nomeCabecaFarda = new string[150];
        string[] nomeFarda= new string[150];
        string[] graduacaoFarda = new string[150];
        int[] ano = new int[150];
        int[] cod = new int[150];
        int qtda = 0;

        public Fardas()
        {
            nomeFarda[qtda] = "Túnica Verde-Oliva";
            nomeCabecaFarda[qtda] = "Quepe oficial";
            graduacaoFarda[qtda] = "Oficial";
            ano[qtda] = 1960;
            cod[qtda]++;
            qtda++;

            nomeFarda[qtda] = "Fraque Exercito Brasileiro";
            nomeCabecaFarda[qtda] = "Quepe de Gala";
            graduacaoFarda[qtda] = "Sargento";
            ano[qtda] = 1888;
            cod[qtda]++;
            qtda++;

            nomeFarda[qtda] = "Jacketa de um Oficial Panzer";
            nomeCabecaFarda[qtda] = "Quepe Oficial Panzer";
            graduacaoFarda[qtda] = "Ofial Panzer";
            ano[qtda] = 1938;
            cod[qtda]++;
            qtda++;
           
        } // vetor alimentado

        public void iniciar()
        {
            int op = 0;

           do
            {
                try
                {
                    Console.Clear();
                    op = Menu();
                    switch (op)
                    {
                        case 0:
                            Console.WriteLine("\nSAIR");
                            break;
                        case 1:
                            cadastrar();
                            break;
                        case 2:
                            listar();
                            break;
                        case 3:
                            alterar();
                            break;
                        case 4:
                            remover();
                            break;
                        default:
                            Console.WriteLine("Opção Inválida");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro.: " + e.ToString());
                }
                Console.ReadKey();
            } while (op != 0);
        }
        public int Menu()
        {
            Console.WriteLine(
                            @"\nQUADROS:
                              -----------------------------
                            |  1  |       NOVA FARDA       |
                            |------------------------------|
                            |  2  |      LISTAR FARDA      |
                            |------------------------------|
                            |  3  |     ALTERAR FARDA      |
                            |------------------------------|
                            |  4  |     REMOVER FARDA      |
                            |------------------------------|
                            |  0  |         SAIR           |
                              -----------------------------");

         return Convert.ToInt32(Console.ReadLine());//retorna opçã
        }


    }
}

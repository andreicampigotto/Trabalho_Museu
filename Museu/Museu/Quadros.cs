using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museu
{
    public class Quadros
    {
        string[] nomeDoQuadro = new string[150];
        string[] pintor = new string[150];
        int[] ano = new int[150];
        double[] valorDoQuadro = new double[150];
        int[] cod = new int[150];
        int qtda = 0;

        public Quadros()
        {
            nomeDoQuadro[qtda] = "Batalha de Avaí";
            pintor[qtda] = "Pedro Américo de Figueiredo e Melo";
            ano[qtda] = 1877;
            valorDoQuadro[qtda] = 0000;
            cod[qtda]++;
            qtda++;

            nomeDoQuadro[qtda] = "A Face da Guerra";
            pintor[qtda] = "Salvador Dalí";
            ano[qtda] = 1940;
            valorDoQuadro[qtda] = 000;
            cod[qtda]++;
            qtda++;

            nomeDoQuadro[qtda] = "Independência ou Morte";
            pintor[qtda] = "Pedro Américo de Figueiredo e Melo";
            ano[qtda] = 1888;
            valorDoQuadro[qtda] = 0000;
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
                    op = menu();
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
        public int menu()
        {
            Console.WriteLine(
                            @"\nQUADROS:
                              -----------------------------
                            |  1  |      NOVO QUADRO       |
                            |------------------------------|
                            |  2  |     LISTAR QUADROS     |
                            |------------------------------|
                            |  3  |    ALTERAR QUADROS     |
                            |------------------------------|
                            |  4  |    REMOVER QUADROS     |
                            |------------------------------|
                            |  0  |         SAIR           |
                              -----------------------------");//retorna opção

        }

    }
}

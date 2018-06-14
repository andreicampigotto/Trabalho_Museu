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
        string[] descricao = new string[150];
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
            descricao[qtda] = "Quadro em homenagem a vitória do Brasil na batalha da triplice fronteira.";
            cod[qtda]++;
            qtda++;

            nomeDoQuadro[qtda] = "A Face da Guerra";
            pintor[qtda] = "Salvador Dalí";
            ano[qtda] = 1940;
            valorDoQuadro[qtda] = 0000;
            descricao[qtda] = "Quadro demonstrando que a guerra só tráz sofrimento.";
            cod[qtda]++;
            qtda++;

            nomeDoQuadro[qtda] = "Independência ou Morte";
            pintor[qtda] = "Pedro Américo de Figueiredo e Melo";
            ano[qtda] = 1888;
            descricao[qtda] = "";
            valorDoQuadro[qtda] = 0000;
            cod[qtda]++;
            qtda++;
        } // vetor pré alimentado

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
                              ----------------------------- ");

         return Convert.ToInt32(Console.ReadLine());//retorna opção

        }
        public void cadastrar()
        {
            Console.Write("\n ~ ~ ~ Cadastro de Quadros ~ ~ ~ ");
           //verificação códico
            cod[qtda] = cod[qtda - 1] + 1;

            inserirDados(qtda);//insere dados conforme indice qtda

            qtda++;//validado aqui
        }
        public void inserirDados(int qtda)
        {
            if (qtda >= 0)
            {

                Console.WriteLine("\n Código: " + cod[qtda]);

                solicitarNome(qtda);
                solicitarPintor(qtda);
                solicitarAno(qtda);
                solicitarValor(qtda);
                solicitarDescricao(qtda);

                Console.WriteLine("\nSALVO");
            }
            else
            {
                Console.WriteLine("\nNão foi possivel salvar");
            }
        }
        private void solicitarNome(int qtda)
        {
            try
            {
                Console.WriteLine("Nome: ");
                nomeDoQuadro[qtda] = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Infome um Nome Válido");
                solicitarNome(qtda);
            }

        }
        private void solicitarPintor(int qtda)
        {
            try
            {
                Console.WriteLine("Pintor: ");
                pintor[qtda] = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Infome uma Descrição válida");
                solicitarPintor(qtda);
            }
        }
        private void solicitarAno(int qtda)
        {
            try
            {
                Console.WriteLine("Categoria: ");
                ano[qtda] = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Infome uma Categoria válida");
                solicitarAno(qtda);
            }
        }
        private void solicitarValor(int qtda)
        {
            try
            {
                Console.WriteLine("Quantidade: ");
                valorDoQuadro[qtda] = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Infome uma Quantidade válida");
                solicitarValor(qtda);
            }
        }
        private void solicitarDescricao(int qtda)
        {
            try
            {
                Console.WriteLine("Quantidade: ");
                descricao[qtda] = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Infome uma Quantidade válida");
                solicitarDescricao(qtda);
            }
        }
        public void listar()
        {
            Console.WriteLine("\n ~ ~ ~ Lista de Quadros ~ ~ ~ ");
            //listar
            Console.WriteLine(string.Format("Códico:   {0}, Nome do Quadro:   {1}, Pintor:    {2}, Ano:    {3}, Valor do Quadro:    {4}, Descrição:   {5}", cod, nomeDoQuadro, pintor, ano, valorDoQuadro, descricao)); 
        }

        public void alterar()
        {
            Console.WriteLine("\n ~ ~ ~ Alterar dados dos Quadros ~ ~ ~ ");
             
        }

    }
}

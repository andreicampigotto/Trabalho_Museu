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
        string[] descricao = new string[150];
        int[] ano = new int[150];
        int[] cod = new int[150];
        int qtda = 0;

        public Fardas()
        {
            nomeFarda[qtda] = "Túnica Verde-Oliva";
            nomeCabecaFarda[qtda] = "Quepe oficial";
            graduacaoFarda[qtda] = "Oficial";
            ano[qtda] = 1960;
            descricao[qtda] = "Usada em Eventos";
            cod[qtda]++;
            qtda++;

            nomeFarda[qtda] = "Fraque Exercito Brasileiro";
            nomeCabecaFarda[qtda] = "Quepe de Gala";
            graduacaoFarda[qtda] = "Sargento";
            descricao[qtda] = "Usada em casamentos militares";
            ano[qtda] = 1888;
            cod[qtda]++;
            qtda++;

            nomeFarda[qtda] = "Jacketa de um Oficial Panzer";
            nomeCabecaFarda[qtda] = "Quepe Oficial Panzer";
            graduacaoFarda[qtda] = "Ofial Panzer";
            descricao[qtda] = "Usada pelos oficiais Panzers na II guerra mundial";
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
                              ----------------------------- ");

         return Convert.ToInt32(Console.ReadLine());//retorna opçã
        }
        public void cadastrar()
        {
            Console.Write("\n ~ ~ ~ Cadastro de Fardas ~ ~ ~ ");
            //verificação códico
            cod[qtda] = cod[qtda - 1] + 1;

            inserirDados(qtda);//insere dados conforme indice qtda

            qtda++;//validado aqui
        }
        public void inserirDados(int qtda)
        {
            if (qtda >= 0)
            {

                Console.WriteLine("\n- Código: " + cod[qtda]);

                solicitarFarda(qtda);
                solicitarBoina(qtda);
                solicitarGraduacaoFarda(qtda);
                solicitarAno(qtda);
                solicitarDescricao(qtda);

                Console.WriteLine("\nSALVO");
            }
            else
            {
                Console.WriteLine("\nNão foi possivel salvar");
            }
        }
        private void solicitarFarda(int qtda)
        {
            try
            {
                Console.WriteLine("Nome: ");
                nomeFarda[qtda] = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Infome um Nome Válido");
                solicitarFarda(qtda);
            }

        }
        private void solicitarBoina(int qtda)
        {
            try
            {
                Console.WriteLine("Pintor: ");
                nomeCabecaFarda[qtda] = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Infome uma Descrição válida");
                solicitarBoina(qtda);
            }
        }
        private void solicitarGraduacaoFarda(int qtda)
        {
            try
            {
                Console.WriteLine("Categoria: ");
                graduacaoFarda[qtda] = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Infome uma Categoria válida");
                solicitarGraduacaoFarda(qtda);
            }
        }
        private void solicitarAno(int qtda)
        {
            try
            {
                Console.WriteLine("Quantidade: ");
                ano[qtda] = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Infome uma Quantidade válida");
                solicitarAno(qtda);
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


    }
}

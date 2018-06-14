using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museu
{
    class CadastroFidelidade
    {
       private int[] cod;
        private String[] nome;
        private String[] sobrenome;
        private int[] idade;
        private char[] sexo;
        private String[] nacionalidade;
        private String[] profissao;
        private int[] quantidadeDeVisitas;
        private int[] telefone;
        private int[] cpf;
        int cont = 0;

        public CadastroFidelidade()
        
        {
            
            cont = 0;
            cpf = new int[100];
            nome = new String[100];
            sobrenome = new String[100];
            idade = new int[100];
            telefone = new int[100];
            quantidadeDeVisitas = new int[100];
            profissao = new String[100];
            nacionalidade = new String[100];
            sexo = new char[100];
                    
        }
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
                            Console.WriteLine("\nSaindo...");
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
            Console.Write(
                   @"---------------------------------------
                     |  1  |        Novo cliente           |
                     |-------------------------------------|
                     |  2  |      Listar clientes          |
                     |-------------------------------------|
                     |  3  |      Editar clientes          |
                     |-------------------------------------|
                     |  4  |      Remover clientes         |
                     |-------------------------------------|
                     |  0  |            Sair               |
                     ---------------------------------------      
                      OPÇÃO: ");

            return solicitarOpcao();
        }
        //Operações
        private int solicitarOpcao()
        {
            int op = 0;
            try
            {
                op = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("\nOpção inválida!");
                solicitarOpcao();
            }
            return op;
        }
        public void cadastrar()
        {
            Console.Write("\n--- Cadastro de clientes ---");
            if (cont == 0) cod[cont] = cont + 1;
            else cod[cont] = cod[cont - 1] + 1;

            inserirDados(cont);

            cont++;
        }

        public void inserirDados(int n)
        {
            if (n >= 0)
            {
                Console.WriteLine("\n- Código: " + cod[n]);

                solicitarCpf(n);
                solicitarNome(n);
                solicitarSobreNome(n);
                solicitarIdade(n);
                solicitarSexo(n);
                solicitarNacionalidade(n);
                solicitarProfissao(n);
                solicitarQuantidadeDeVisitas(n);
                solicitarTelefone(n);

                

                Console.WriteLine("\nSalvo!");
            }
            else
            {
                Console.WriteLine("\nNão foi possivel inserir!");
            }
        }
        public void listar()
        {
            Console.WriteLine("\n--- Lista de clientes ---");

            for (int n = 0; n < cont; n++)
            {
                imprimirCliente(n);
            }
            
        }
        public void alterar()
        {
            Console.WriteLine("\n--- Editar clientes ---");
            inserirDados(buscarCliente());
        }

        public void remover()
        {
            int buscado = buscarCliente();
            if (buscado >= 0)
            {
                for (int i = buscado; i < cont; i++)
                {
                    cod[i] = cod[i + 1];
                    nome[i] = nome[i + 1];
                    sobrenome[i] = sobrenome[i + 1];
                    idade[i] = idade[i + 1];
                    
                }
                Console.WriteLine("\nRemovido!");
                cont--;
            }
            else
            {
                Console.WriteLine("\nNão foi possível excluir!");
            }
        }

        //Buscas e Impressões
    
        

       

        }
    }


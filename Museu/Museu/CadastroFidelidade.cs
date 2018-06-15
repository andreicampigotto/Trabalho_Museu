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
        private double[] cpf; //salario
        private String[] nome;
        private String[] sobrenome;
        private int[] idade;
        private String[] nacionalidade; //funcao
        private String[] profissao; //turno
        private String[] sexo; //setor
        private double[] quantidadeDeVisitas;  //salarioByHrs
        private double[] quantidadeGastosNoMuseu;   //hrsBySemana
        private double[] telefoneContato; // descontos

        int cont;

        public CadastroFidelidade() 
        {
            cont = 0;
            cod = new int[100];
            cpf = new double[100];
            nome = new String[100];
            sobrenome = new String[100];
            idade = new int[100];//ou dataNascimento -> calcIdade();
            nacionalidade = new String[100];
            profissao = new String[100];
            sexo = new String[100];
            quantidadeDeVisitas = new double[100];
            quantidadeGastosNoMuseu = new double[100];
            telefoneContato = new double[100];

            //cadastrar();
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
            Console.WriteLine(
                @"\nFidelidade:
                            -------------------------------------------
                            |  1  |          NOVO CLIENTE             |
                            |-----------------------------------------|
                            |  2  |        LISTAR CLIENTES            |
                            |-----------------------------------------|
                            |  3  |        ALTERAR CLIENTES           |
                            |-----------------------------------------|
                            |  4  |      REMOVER CLIENTES             |
                            |-----------------------------------------|
                            |  0  |               SAIR                |
                            ------------------------------------------- ");
            Console.Write("\nOpção: ");

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
            Console.Write("\n--- Cadastro de Clientes ---");
            if (cont == 0) cod[cont] = cont + 1;
            else cod[cont] = cod[cont - 1] + 1;

            inserirDados(cont);

            cont++;
        }
        public void inserirDados(int n)
        {
            if (n >= 0 && n < 100)
            {
                Console.WriteLine("\n- Código: " + cod[n]);

                solicitarCpf(n);
                solicitarNome(n);
                solicitarSobrenome(n);
                solicitarIdade(n);
                solicitarNacionalidade(n);
                solicitarProfissao(n);
                solicitarSexo(n);
                solicitarQuantidadeDeVisitas(n);
                solicitarQuantidadeGastosNoMuseu(n);
                solicitarTelefoneContato(n);
           

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
            Console.WriteLine("Média gastos por visita: R$" + imprimirMediaVisita());
            
        }




                    
        

        }
    }


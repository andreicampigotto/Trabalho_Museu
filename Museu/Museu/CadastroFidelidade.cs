using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museu
{
    class CadastroFidelidade
    {
        private int[] numeroCliente;
        private String[] nomeCliente;
        private String[] sobrenomeCliente;
        private int[] idade;
        private int[] nascimentoDia;
        private int[] nascimentoMes;
        private int[] nascimentoAno;
        private String[] profissao;
        private String[] nacionalidade;
        private String[] cidadeResidencia;
        private int[] cpf;
        private int[] numeroDeVisitas;
        private int[] numeroTelefone;
        private char[] sexo;
        

        int contador;
        private int pontuacao;

        public CadastroFidelidade()
        {
            contador = 0;
           
            numeroCliente = new int[100];
            nomeCliente = new String[100];
            sobrenomeCliente = new String[100];
            idade = new int[100];
            nascimentoDia = new int[100];
            nascimentoMes = new int[100];
            nascimentoAno = new int[100];
            profissao = new String[100];
            nacionalidade = new String[100];
            cidadeResidencia = new String[100];          
            numeroDeVisitas = new int[100];
            numeroTelefone = new int[100];
            sexo = new char[100];
            cpf = new int[100];
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
                    Console.WriteLine("Error 0x00000000, Something wrong found in your operation: " + e.ToString());
                }
                Console.ReadKey();
            } while (op != 0);
        }

        public int menu()
        {
            Console.Write(
                   @"---------------------------------------
                     |  1  |        Novo Cliente           |
                     |-------------------------------------|
                     |  2  |      Listar Clientes          |
                     |-------------------------------------|
                     |  3  |      Editar Clientes          |
                     |-------------------------------------|
                     |  4  |      Remover Cliente          |
                     |-------------------------------------|
                     |  0  |            Sair               |
                     ---------------------------------------      
                      OPÇÃO: ");

            return Convert.ToInt32(Console.ReadLine());
        }

        public void cadastrar()
        {
            Console.Write("\n--- Cadastro Fidelidade ---");
            if (contador == 0) numeroCliente[contador] = contador + 1;
            else numeroCliente[contador] = numeroCliente[contador - 1] + 1;
            inserirDados(contador);

            contador++;
        }

        public void inserirDados(int n)
        {
            if (n >= 0)
            {
                do
                {
                    Console.Write("\nCPF: ");
                    cpf[n] = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nNúmero de cadastro: ");
                    numeroCliente[n] = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Nome do cliente: ");
                    nomeCliente[n] = Console.ReadLine());

                    Console.Write("Sobre nome: ");
                    sobrenomeCliente[n] = Console.ReadLine());


                    Console.Write("\nSexo: Digite ( M ) para Masculino ou ( F ) para Feminino ");
                    sexo[n] = Convert.ToChar(Console.ReadLine());

                    Console.Write("Idade: ");
                    idade[n] = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nDia do nascimento: ");
                    nascimentoDia[n] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nMês do nascimento: ");
                    nascimentoMes[n] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\nAno do nascimento: ");
                    nascimentoAno[n] = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nProfissão: ");
                    profissao[n] = Console.ReadLine();

                    Console.Write("\nNacionalidade: ");
                    nacionalidade[n] = Console.ReadLine();

                    Console.Write("\nCidade em que Reside: ");
                    cidadeResidencia[n] = Console.ReadLine();

                    Console.Write("\nNúmero para contato: ");
                    numeroTelefone[n] = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Número de visitas: ");
                    numeroDeVisitas[n] = Convert.ToInt32(Console.ReadLine());
                   
                    if (nomeCliente[n] == "")
                    {
                        Console.WriteLine("\nInforme os dados necessários!");
                    }
                } while (nomeCliente[n] == "");

                Console.WriteLine("\nSalvo!");
            }
            else
            {
                Console.WriteLine("\nNão foi possivel inserir!");
            }
        }

        public void listar()
        {
            Console.WriteLine("\n--- Lista de Clientes ---");

            for (int n = 0; n < contador; n++)
            {
                imprimirClientes(n);
            }
            
        }

        public void imprimirClientes(int i)
        {

            pontuacao = 999999;

            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("O cliente com maior pontuação é ganhador de 2 ingressos válidos para ano inteiro");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("CPF: " + cpf[i]);
            Console.WriteLine("Número de cadastro: " + numeroCliente[i]);
            Console.WriteLine("Nome do cliente: " + nomeCliente[i] + " " + sobrenomeCliente[i]);
            Console.WriteLine("Sexo: " + sexo[i]);
            Console.WriteLine("Idade: " + idade[i]);
            Console.WriteLine("Nascimento: " + nascimentoDia[i] + " / " + nascimentoMes[i] + " / " + nascimentoAno[i]);
            Console.WriteLine("Profissão: " + profissao[i]);
            Console.WriteLine("Nacionalidade: " + nacionalidade[i]);
            Console.WriteLine("Cidade em que reside: " + cidadeResidencia[i]);
            Console.WriteLine("Número para contato: " + numeroTelefone[i]);
            Console.WriteLine("Número de visitas: " + numeroDeVisitas[i]);
            Console.WriteLine("Pontuação: " + pontuacao);
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("O cliente com maior pontuação é ganhador de 2 ingressos válidos para ano inteiro");
            Console.WriteLine("--------------------------------------------------------------------------------");

        }

        public void alterar()
        {
            Console.WriteLine("\n--- Editar dados do cliente ---");
            inserirDados(buscarCliente());
        }

        public int buscarCliente()
        {
            int op = 0, buscado = -1;

            Console.Write("\n--- Buscar Cliente ---\n");
            Console.Write("\n1- Buscar por CPF");
            Console.Write("\n2- Buscar por número de cadastro");
            Console.Write("\n0- Cancelar");
            Console.Write("\nOpção: ");
            op = Convert.ToInt32(Console.ReadLine());

            if (op != 1 && op != 2 && op != 3)
            {
                Console.WriteLine("\nSaindo...");
            }
            else
            {
                buscado = BuscarBy(op);
            }
            return buscado;
        }

        public int BuscarBy(int op)
        {
            int indice = -1, numeroClienteF, cpfF;
           
         

            if (op == 1)
            {
                Console.Write("\nInforme o CPF do cliente: ");
                cpfF = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < contador; i++)
                {
                    if (cpf[i] == cpfF)
                    {
                        indice = i;
                    }
                }
            }
            else if (op == 2)
            {
                Console.Write("\nInforme o numero de cadastro: ");
                numeroClienteF = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < contador; i++)
                {
                    if (numeroCliente[i] == numeroClienteF)
                    {
                        indice = i;
                    }
                }
                return indice;
            }

            private void imprimircpfF(int i)
        {
            throw new NotImplementedException();
        }

        public double calcSalario(double salarioByHoras, double hrsBySemana, double descontos)
        {
            return (salarioByHoras * (hrsBySemana * 5)) - descontos;
        }

        public double imprimirFolhaDePagamento()
        {
            double total = 0;
            if (cont > 0)
            {
                for (int i = 0; i < cont; i++)
                {
                    total += salario[i];
                }
            }
            return total;
        }

        public void remover()
        {
            int buscado = buscarFuncionario();
            if (buscado >= 0)
            {
                for (int i = buscado; i < cont; i++)
                {
                    cod[i] = cod[i + 1];
                    nome[i] = nome[i + 1];
                    sobrenome[i] = sobrenome[i + 1];
                    idade[i] = idade[i + 1];
                    funcao[i] = funcao[i + 1];
                    turno[i] = turno[i + 1];
                    setor[i] = setor[i + 1];
                    salarioByHrs[i] = salarioByHrs[i + 1];
                    hrsBySemana[i] = hrsBySemana[i + 1];
                    salario[i] = salario[i + 1];
                    descontos[i] = descontos[i + 1];
                }
                Console.WriteLine("\nRemovido!");
                cont--;
            }
            else
            {
                Console.WriteLine("\nNão foi possível excluir!");
            }

        }
    }
}

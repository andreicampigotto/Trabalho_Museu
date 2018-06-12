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
        private int[] nascimento;
        private String[] profissao;
        private String[] nacionalidade;
        private String[] cidadeResidencia;
        private int[] cpf;
        private double[] pontuacao;
        private double[] totalGastosEmIngressos;
        private int[] numeroTelefone;
        private char[] sexo;

        int contador;

        public CadastroFidelidade()
        {
            contador = 0;
            numeroCliente = new int[100];
            nomeCliente = new String[100];
            sobrenomeCliente = new String[100];
            idade = new int[100];
            nascimento = new int[100];
            profissao = new String[100];
            nacionalidade = new String[100];
            cidadeResidencia = new String[100];
            pontuacao = new double[100];
            totalGastosEmIngressos = new double[100];
            numeroTelefone = new int[100];
            sexo = new char[100];

            cadastrar();
        }

        public void iniciar()
        {
            int op = 0;

            do
            {
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

            return Int32.Parse(Console.ReadLine());
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
            do
            {
                Console.Write("\nCPF: ");
                cpf[n] = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nNúmero do cliente: ");
                numeroCliente[n] = Convert.ToInt32(Console.ReadLine());

                SolicitarNome(n);
                SolicitarSobrenome(n);



                Console.Write("\nSexo: Digite ( M ) para Masculino ou ( F ) para Feminino ");
                sexo[n] = Convert.ToChar(Console.ReadLine());


                SolicitarIdade(n);

                Console.Write("\nNascimento: ");
                nascimento[n] = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nProfissão: ");
                profissao[n] = Console.ReadLine();

                Console.Write("\nNacionalidade: ");
                nacionalidade[n] = Console.ReadLine();

                Console.Write("\nCidade em que Reside: ");
                cidadeResidencia[n] = Console.ReadLine();

                Console.Write("\nNúmero para contato: ");
                numeroTelefone[n] = Convert.ToInt32(Console.ReadLine());


            } while (nomeCliente[n] == "");

            Console.WriteLine("\nSalvo!");
        }

        private void SolicitarIdade(int n)
        {
            try
            {
                Console.Write("\nIdade: ");
                idade[n] = Convert.ToInt32(Console.ReadLine());
                if (idade[n] < 0 || idade[n] > 128)
                {
                    Console.WriteLine("Idade deve estar no intervalo de 0 até 128.");
                    SolicitarIdade(n);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Idade deve conter somente números");
                SolicitarIdade(n);
            }

        }

        private void SolicitarSobrenome(int n)
        {

            Console.Write("\nSobrenome: ");
            sobrenomeCliente[n] = Console.ReadLine();

            while (sobrenomeCliente[n].Count() < 3)
            {
                // TODO mensagem de erro do sobrenome
                Console.Write("\nSobrenome: ");
                sobrenomeCliente[n] = Console.ReadLine();
            }
        }

        private void SolicitarNome(int n)
        {
            Console.Write("\nNome: ");
            nomeCliente[n] = Console.ReadLine();

            while (nomeCliente[n] == "" || nomeCliente[n].Count() < 3)
            {
                Console.WriteLine("\nInforme os dados necessários!");
                Console.Write("\nNome: ");
                nomeCliente[n] = Console.ReadLine();
            }
        }

        public void listar()
        {
            Console.WriteLine("\n--- Lista de Funcionários ---");
            int op = Int32.Parse(Console.ReadLine());

            for (int n = 0; n < cont; n++)
            {
                imprimirFuncionario(n);
            }
            Console.WriteLine("Folha de Pagamento: R$" + imprimirFolhaDePagamento());
            Console.WriteLine("Maior Salario: R$" + maiorSalario());

        }

        public void imprimirFuncionario(int i)
        {
            Console.WriteLine("- Código: " + cod[i]);
            Console.WriteLine("Nome: " + nome[i] + " " + sobrenome[i]);
            Console.WriteLine("Idade: " + idade[i]);
            Console.WriteLine("Função: " + funcao[i]);
            Console.WriteLine("Turno: " + turno[i]);
            Console.WriteLine("Setor: " + setor[i]);
            Console.WriteLine("--- Salário ---");
            Console.WriteLine("Salário por hora: R$" + salarioByHrs[i]);
            Console.WriteLine("Horas por semana: " + hrsBySemana[i]);
            Console.WriteLine("Descontos: R$" + descontos[i]);
            Console.WriteLine("Salário Liquido: R$" + salario[i]);
            Console.WriteLine("\n--\n");
        }

        public double maiorSalario()
        {
            double maiorSalario = salario[0];

            for (int n = 0; n < cont; n++)
            {
                if (maiorSalario < salario[n])
                {
                    maiorSalario = salario[n];
                }
            }

            return maiorSalario;
        }

        public void alterar()
        {
            Console.WriteLine("\n--- Alterar dados do Funcionários ---");
            inserirDados(buscarFuncionario());
        }

        public int buscarFuncionario()
        {
            int op = 0, buscado = -1;

            do
            {
                Console.Write("\n--- Buscar Funcionário ---\n");
                Console.Write("\n1- Buscar por Códiogo");
                Console.Write("\n2- Buscar por Nome");
                Console.Write("\n3- Buscar por Setor");
                Console.Write("\n0- Cancelar");
                Console.Write("\nOpção: ");
                op = Int32.Parse(Console.ReadLine());

                if (op != 1 && op != 2 && op != 3) Console.WriteLine("\nSaindo...");
                else buscado = buscarBy(op);

            } while (buscado == -1);

            return buscado;
        }

        public int buscarBy(int op)
        {
            int indice = -1, codF = 0;
            String nomeF, setorF;
            do
            {
                if (op == 2)
                {
                    Console.Write("\nInforme o Nome do Funcionário: ");
                    nomeF = Console.ReadLine();
                    for (int i = 0; i < cont; i++)
                    {
                        if (nomeF.Equals(nome[i]))
                        {
                            imprimirFuncionario(i);
                        }
                    }
                }
                else if (op == 3)
                {
                    Console.Write("\nInforme o Setor do Funcionário: ");
                    setorF = Console.ReadLine();
                    for (int i = 0; i < cont; i++)
                    {
                        if (setorF.Equals(setor[i]))
                        {
                            imprimirFuncionario(i);
                        }
                    }
                }
                Console.Write("\nInforme o código do Funcionário: ");
                codF = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < cont; i++)
                {
                    if (cod[i] == codF)
                    {
                        indice = i;
                    }
                }

            } while (indice == -1);

            return indice;
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
    }
}

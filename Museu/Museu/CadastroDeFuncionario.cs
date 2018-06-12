﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museu
{
    class CadastroDeFuncionarios
    {
        private int[] cod;
        private String[] nome;
        private String[] sobrenome;
        private int[] idade;
        private String[] funcao;
        private String[] turno;
        private String[] setor;
        private double[] salarioByHrs;
        private double[] hrsBySemana;
        private double[] salario;
        private double[] descontos;

        int cont;        

        public CadastroDeFuncionarios()
        {
            cont = 0;
            cod = new int[100];
            nome = new String[100];
            sobrenome = new String[100];
            idade = new int[100];//ou dataNascimento -> calcIdade();
            funcao = new String[100];
            turno = new String[100];
            setor = new String[100];
            salarioByHrs = new double[100];
            hrsBySemana = new double[100];
            salario = new double[100];
            descontos = new double[100];
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
            Console.WriteLine("\n---- Funcionários ---");
            Console.WriteLine("1- Novo funcionário");
            Console.WriteLine("2- Listar funcionários");
            Console.WriteLine("3- Alterar funcionário");
            Console.WriteLine("4- Remover funcionário");
            Console.WriteLine("0- Sair");
            Console.Write("\nOpção: ");
            return Int32.Parse(Console.ReadLine());
        }

        public void cadastrar()
        {
            Console.Write("\n--- Cadastro de Funcionário ---");
            if (cont == 0) cod[cont] = cont + 1;
            else cod[cont] = cod[cont - 1] + 1;
            inserirDados(cont);

            cont++;
        }

        public void inserirDados(int n)
        {
            do
            {
                Console.WriteLine("\n- Código: " + cod[n]);
                Console.Write("\nNome: ");
                nome[n] = Console.ReadLine();

                Console.Write("\nSobrenome: ");
                sobrenome[n] = Console.ReadLine();

                Console.Write("\nIdade: ");
                idade[n] = Int32.Parse(Console.ReadLine());

                Console.Write("\nFunção: ");
                funcao[n] = Console.ReadLine();

                Console.Write("\nTurno: ");
                turno[n] = Console.ReadLine();

                Console.Write("\nSalario(hora): R$");
                salarioByHrs[n] = Double.Parse(Console.ReadLine());

                Console.Write("\nHoras trabalhadas(semana): ");
                hrsBySemana[n] = Double.Parse(Console.ReadLine());

                Console.Write("\nDescontos: R$");
                descontos[n] = Double.Parse(Console.ReadLine());

                salario[n] = calcSalario(salarioByHrs[n], hrsBySemana[n], descontos[n]);
                //Ou imprimirSetores("MateriaisBelicos, Fardas, Veiculos") e armazenar opção
                Console.Write("\nSetor: ");
                setor[n] = Console.ReadLine();

                if (nome[n] == "")
                {
                    Console.WriteLine("\nInforme os dados necessários!");
                }
            } while (nome[n] == "");

            Console.WriteLine("\nSalvo!");
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museu
{
    class Veiculos
    {
        //Armas, munições, granadas, facas, baionetas
        //variaveis tipo private = são utilizadas apenas aqui
        private int[] cod;
        private String[] nome;
        private String[] categoria;
        private String[] descricao;
        private int[] quantidade;

        int cont;

        public Veiculos()//Método construtor inicializando variáveis
        {
            cont = 0;
            cod = new int[100];
            nome = new String[100];
            descricao = new String[100];
            categoria = new String[100];
            quantidade = new int[100];
        }

        //método que inicializa o menu() de opçoes para o gerenciamento de materiais belicos
        public void iniciar()
        {
            int op = 0;

            do
            {
                op = menu();//munu de opções
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
<<<<<<< HEAD
            Console.WriteLine("\n---- Veículos ---");
            Console.WriteLine("1 - Novo veículo");
            Console.WriteLine("2 - Listar veículos ");
            Console.WriteLine("3 - Editar veículos");
            Console.WriteLine("4 - Remover Veículos");
            Console.WriteLine("0- Sair");
            Console.Write("\nOpção: ");
            return Int32.Parse(Console.ReadLine());//retorna opção
=======
            Console.Write(
                  @" ---------------------------------------
                     |  1  |     Cadastrar veículo         |
                     |-------------------------------------|
                     |  2  |      Listar veículos          |
                     |-------------------------------------|
                     |  3  |      Editar veículos          |
                     |-------------------------------------|
                     |  4  |      Remover veículos         |
                     |-------------------------------------|
                     |  0  |            Sair               |
                     ---------------------------------------      
                      OPÇÃO: ");

            return Convert.ToInt32(Console.ReadLine());
>>>>>>> 9f42bc8ea81d16227294fe2a7403f532be916406
        }

        public void cadastrar()
        {
            Console.Write("\n--- Cadastro de veículos ---");
            //Tipo um IDENTITY
            if (cont == 0) cod[cont] = cont + 1;
            else cod[cont] = cod[cont - 1] + 1;

            inserirDados(cont);//insere dados conforme indice cont

            cont++;
        }

        public void inserirDados(int n)
        {
            do
            {
<<<<<<< HEAD
                Console.WriteLine("\nNúmero de cadastro: " + cod[n]);
                Console.Write("\nNome: ");
=======
                Console.WriteLine("\n- Número de cadastro: " + cod[n]);
                Console.Write("\nNome veículo: ");
>>>>>>> 9f42bc8ea81d16227294fe2a7403f532be916406
                nome[n] = Console.ReadLine();

                Console.Write("\nDescrição do veículo: ");
                descricao[n] = Console.ReadLine();

                Console.Write("\nCategoria do veículo: ");
                categoria[n] = Console.ReadLine();

                Console.Write("\nQuantidade de veículos: ");
                quantidade[n] = Int32.Parse(Console.ReadLine());

                if (nome[n] == "")//validação simples
                {
                    Console.WriteLine("\nInforme os dados necessários!");
                }
            } while (nome[n] == "");

            Console.WriteLine("\nSalvo!");
        }

        public void listar()
        {
            Console.WriteLine("\n--- Lista de veículos ---");
            Console.WriteLine("\nTotal de veículos: " + totalDeVeiculos());//Soma quantidade de materiais belicos
            for (int n = 0; n < cont; n++)
            {
                imprimirVeiculos(n);
            }
        }

        public void imprimirVeiculos(int i)
        {
            Console.WriteLine("Número de cadastro: " + cod[i]);
            Console.WriteLine("Nome veículo: " + nome[i]);
            Console.WriteLine("Descrição veículo: " + descricao[i]);
            Console.WriteLine("Categoria do veículo: " + categoria[i]);
            Console.WriteLine("Quantidade de veículos: " + quantidade[i]);
            Console.WriteLine("\n--\n");
        }

        public void alterar()
        {
            Console.WriteLine("\n--- Editar veículos ---");
            inserirDados(buscarVeiculos());//retorna índice do material belico. buscado
        }

        public int buscarVeiculos()
        {
            int op = 0, buscado = -1;

            do
            {
                Console.Write("\n--- Buscar Veículos ---\n");
                Console.Write("\n1- Buscar por Número de cadastro");
                Console.Write("\n2- Buscar por Nome");
                Console.Write("\n2- Buscar por Categoria");
                Console.Write("\n0- Cancelar");
                Console.Write("\nOpção: ");
                op = Int32.Parse(Console.ReadLine());

                if (op != 1 && op != 2 && op != 3) Console.WriteLine("\nSaindo...");
                else buscado = buscarBy(op);//busca por opção

            } while (buscado == -1);

            return buscado;
        }

        //Busca por opção e retorna indice do materiai belico buscado
        public int buscarBy(int op)
        {
            int indice = -1, codMB = 0;
            String nomeMB, categoriaMB;
            do
            {
                if (op == 2)
                {
                    Console.Write("\nInforme o nome do veículo: ");
                    nomeMB = Console.ReadLine();
                    for (int i = 0; i < cont; i++)
                    {
                        if (nomeMB.Equals(nome[i]))
                        {
                            imprimirVeiculos(i);
                        }
                    }
                }
                else if (op == 3)
                {
                    Console.Write("\nInforme a categoria do veículo: ");
                    categoriaMB = Console.ReadLine();
                    for (int i = 0; i < cont; i++)
                    {
                        if (categoriaMB.Equals(categoria[i]))
                        {
                            imprimirVeiculos(i);
                        }
                    }
                }
                Console.Write("\nInforme o número de cadastro do veículo: ");
                codMB = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < cont; i++)
                {
                    if (cod[i] == codMB)
                    {
                        indice = i;
                    }
                }

            } while (indice == -1);

            return indice;
        }

        public int totalDeVeiculos()
        {
            int total = 0;
            if (cont > 0)
            {
                for (int i = 0; i < cont; i++)
                {
                    total += quantidade[i];
                }
            }
            return total;
        }

        public void remover()
        {
            //O índice removido da espaço ao seu sucessor, e assim sucessivamente. Ao final, decrementa contador de cadastros.
            int buscado = buscarVeiculos();
            for (int i = buscado; i < cont; i++)
            {
                cod[i] = cod[i + 1];
                nome[i] = nome[i + 1];
                descricao[i] = descricao[i + 1];
                categoria[i] = categoria[i + 1];
                quantidade[i] = quantidade[i + 1];
            }
            Console.WriteLine("\nRemovido!");
            cont--;
        }
    }
}

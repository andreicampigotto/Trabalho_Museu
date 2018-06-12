using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace Museu
{
    class MaterialBelico
    {
        //Armas, munições, granadas, facas, baionetas
        //variaveis tipo private = são utilizadas apenas aqui
        private int[] cod;
        private String[] nome;
        private String[] categoria;
        private String[] descricao;
        private int[] quantidade;

        int cont;

        public MaterialBelico()//Método construtor inicializando variáveis
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
                try
                {
                    Console.Clear();
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
                }catch(Exception e){
                    Console.WriteLine("Erro.: "+e.ToString());
                }
                Console.ReadKey();
            } while (op != 0);
        }

        public int menu()
        {
            Console.WriteLine("\n---- Materiais Béçicos ---");
            Console.WriteLine("1- Novo Material Bélico");
            Console.WriteLine("2- Listar Materiais Bélicos");
            Console.WriteLine("3- Alterar Material Bélico");
            Console.WriteLine("4- Remover Material Bélico");
            Console.WriteLine("0- Sair");
            Console.Write("\nOpção: ");
            return Convert.ToInt32(Console.ReadLine());//retorna opção
        }

        public void cadastrar()
        {
            Console.Write("\n--- Cadastro de Material Bélico ---");
            //Tipo um IDENTITY
            if (cont == 0) cod[cont] = cont + 1;
            else cod[cont] = cod[cont - 1] + 1;

            inserirDados(cont);//insere dados conforme indice cont

            cont++;
        }

        public void inserirDados(int n)
        {
            if (n >= 0)
            {
                do
                {
                    Console.WriteLine("\n- Código: " + cod[n]);

                    solicitarNome(n);
                    solicitarDescricao(n);
                    solicitarCategoria(n);
                    solicitarQuantidade(n);

                } while (nome[n] == "");

                Console.WriteLine("\nSalvo!");
            }
            else
            {
                Console.WriteLine("\nNão foi possivel inserir!");
            }
        }

        private void solicitarQuantidade(int n)
        {
            try
            {
                Console.WriteLine("Quantidade: ");
                quantidade[n] = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Infome uma Quantidade válida");
                solicitarQuantidade(n);
            }
        }

        private void solicitarCategoria(int n)
        {
            try
            {
                Console.WriteLine("Categoria: ");
                categoria[n] = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Infome uma Categoria válida");
                solicitarCategoria(n);
            }
        }

        private void solicitarDescricao(int n)
        {
            try
            {
                Console.WriteLine("Descrição: ");
                descricao[n] = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Infome uma Descrição válida");
                solicitarDescricao(n);
            }
        }

        private void solicitarNome(int n)
        {
            try
            {
                Console.WriteLine("Nome: ");
                nome[n] = Console.ReadLine();
            }catch(Exception e){
                Console.WriteLine("Infome um Nome Válido");
                solicitarNome(n);
            }
        }

        public void listar()
        {
            Console.WriteLine("\n--- Lista de Materias Bélicos ---");

            Console.WriteLine("\nTotal de Materiais Bélicos: " + totalDeMateriaisBelicos());//Soma quantidade de materiais belicos
            for (int n = 0; n < cont; n++)
            {
                imprimirMaterialBelico(n);
            }
        }

        public void imprimirMaterialBelico(int i)
        {
            Console.WriteLine("- Código: " + cod[i]);
            Console.WriteLine("Nome: " + nome[i]);
            Console.WriteLine("Descrição: " + descricao[i]);
            Console.WriteLine("Categoria: " + categoria[i]);
            Console.WriteLine("Quantidade: " + quantidade[i]);
            Console.WriteLine("\n--\n");
        }

        public void alterar()
        {
            Console.WriteLine("\n--- Alterar dados do Material Bélico ---");
            inserirDados(buscarMaterialBelico());//retorna índice do material belico. buscado
        }

        public int buscarMaterialBelico()
        {
            int op = 0, buscado = -1;

            Console.Write("\n--- Buscar Material Belico ---\n");
            Console.Write("\n1- Buscar por Códiogo");
            Console.Write("\n2- Buscar por Nome");
            Console.Write("\n2- Buscar por Categoria");
            Console.Write("\n0- Cancelar");
            Console.Write("\nOpção: ");
            op = Int32.Parse(Console.ReadLine());

            if (op != 1 && op != 2 && op != 3) Console.WriteLine("\nSaindo...");
            else buscado = buscarBy(op);//busca por opção

            return buscado;
        }

        //Busca por opção e retorna indice do materiai belico buscado
        public int buscarBy(int op)
        {
            int indice = -1, codMB = 0;
            String nomeMB, categoriaMB;

            if (op == 2)
            {
                Console.Write("\nInforme o Nome do Material Bélico: ");
                nomeMB = Console.ReadLine();
                for (int i = 0; i < cont; i++)
                {
                    if (nomeMB.Equals(nome[i]))
                    {
                        imprimirMaterialBelico(i);
                    }
                }
            }
            else if (op == 3)
            {
                Console.Write("\nInforme a Categoria do Material Bélico: ");
                categoriaMB = Console.ReadLine();
                for (int i = 0; i < cont; i++)
                {
                    if (categoriaMB.Equals(categoria[i]))
                    {
                        imprimirMaterialBelico(i);
                    }
                }
            }
            Console.Write("\nInforme o código do Material Bélico: ");
            codMB = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cont; i++)
            {
                if (cod[i] == codMB)
                {
                    indice = i;
                }
            }

            return indice;
        }

        public int totalDeMateriaisBelicos()
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
            int buscado = buscarMaterialBelico();
            if (buscado >= 0)
            {
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
            else
            {
                Console.WriteLine("\nNão foi possível excluir!");
            }
        }
    }
}

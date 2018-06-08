using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Museu
{
    class start
    {
        Roupas roupas = new Roupas();
        Armas armas = new Armas();
        Quadros quadros = new Quadros();
        Veiculos veiculos = new Veiculos();
        Funcionarios funcionarios = new Funcionarios();
        Fidelidade fidelidade = new Fidelidade();

        public start()
        {
            MenuPrincipal();
        }
        public void Menu()
        {
            Console.Write(


                    @" ------------------------------------ 
                     |  1  |       Funcionários            |
                     |-------------------------------------|
                     |  2  |         Fidelidade            |
                     |-------------------------------------|
                     |  3  |           Roupas              |
                     |-------------------------------------|
                     |  4  |           Armas               |
                     |-------------------------------------|
                     |  5  |          Veiculos             |
                     |-------------------------------------|
                     |  6  |          Quadros              |
                      ------------------------------------- ");

        }
    }
}

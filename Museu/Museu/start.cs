﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Museu
{
    class start
    {
        Fardas roupas = new Fardas();
        MaterialBelico armas = new MaterialBelico();
        Quadros quadros = new Quadros();
        Veiculos veiculos = new Veiculos();
        CadastroDeFuncionario cadastrofuncionarios = new CadastroDeFuncionario();
        CadastroFidelidade cadastroFidelidade = new CadastroFidelidade();

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
                      ------------------------------------- 
                        
                      OPÇÃO: " );
        }
            public void MenuPrincipal()
            {

            }



        }
    }


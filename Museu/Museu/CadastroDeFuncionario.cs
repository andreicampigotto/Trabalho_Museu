using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museu
{
    class CadastroDeFuncionario
    {
        String[] nome = new String[30];
        String[] sobrenome = new String[30];
        int idade = 0;
        String[] funcao = new String[40];

        double salarioPorHoras = 0;
        int horasSemanais = 0;

        public CadastroDeFuncionario(String nome, String sobrenome, int idade, String funcao, double salarioPorHoras, int horasSemanais)
        {

        }

        public double calcSalario(){

            return horasSemanais * salarioPorHoras;
        }


    }
}

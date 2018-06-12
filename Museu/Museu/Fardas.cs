using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museu
{
    public class Fardas
    {
        string[] nomeCabecaFarda = new string[150];
        string[] nomeFarda= new string[150];
        string[] graduacaoFarda = new string[150];
        int[] ano = new int[150];
        int qtda = 0;

        public Fardas()
        {
            nomeFarda[qtda] = "Túnica Verde-Oliva";
            nomeCabecaFarda[qtda] = "Quepe oficial";
            graduacaoFarda[qtda] = "Oficial";
            ano[qtda] = 1960;
            qtda++;

            nomeFarda[qtda] = "Fraque Exercito Brasileiro";
            nomeCabecaFarda[qtda] = "Quepe de Gala";
            graduacaoFarda[qtda] = "Sargento";
            ano[qtda] = 1888;
            qtda++;

            nomeFarda[qtda] = "Jacketa de um Oficial Panzer";
            nomeCabecaFarda[qtda] = "Quepe Oficial Panzer";
            graduacaoFarda[qtda] = "Ofial Panzer";
            ano[qtda] = 1938;
            qtda++;
           
        } // vetor alimentado


    }
}

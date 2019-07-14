using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico09.Entities
{

    /// <summary>
    /// Classe principal da lib, a aplicação "principall" deve instanciar e usar essa classe.
    /// </summary>
    public class CaixaEletronico
    {
        Cofre cofre = new Cofre();
        Carregar carregar = new Carregar();
        Sacar sacar = new Sacar();

        public CaixaEletronico() { }

 

    }
}

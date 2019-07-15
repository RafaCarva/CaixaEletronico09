using System;
using System.Collections.Generic;
using System.Text;
using CaixaEletronico09.Entities;

namespace CaixaEletronico09
{

    /// <summary>
    /// Classe principal da lib, a aplicação "principall" deve instanciar e usar essa classe.
    /// </summary>
    public class CaixaEletronico
    {
        public Cofre cofre = new Cofre();
        public Carregar carregar = new Carregar();
        public Sacar sacar = new Sacar();

        /// <summary>
        /// A classe concreta do projeto que importar essa lib
        /// usará uma instância dessa classe para executar todas as
        /// operações. As regras de negócio estão em cada uma das 
        /// classes concretas que implementem uma das interfaces.
        /// </summary>
        public CaixaEletronico() { }

 

    }
}

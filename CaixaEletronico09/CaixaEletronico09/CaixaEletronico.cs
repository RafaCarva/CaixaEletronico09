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

        /// <summary>
        /// A classe concreta do projeto que importar essa lib
        /// usará uma instância dessa classe para executar todas as
        /// operações. As regras de negócio estão em cada uma das 
        /// classes concretas que implementem uma das interfaces.
        /// </summary>
        public CaixaEletronico() { }

 

    }
}

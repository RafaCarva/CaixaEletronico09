using CaixaEletronico09.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico09
{
    /// <summary>
    /// Prove a interface para o carregamento do caixa.
    /// </summary>
    public interface ICarregar
    {

       Cofre CarregaCaixa(Cofre cofre, int nota, int quantidade);
    }

}
using CaixaEletronico09.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico09
{
    interface ISacar
    {
        void sacarDinheiro(Cofre cofre, int valor);
    }
}

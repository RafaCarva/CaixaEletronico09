using System;
using System.Collections.Generic;
using System.Text;

namespace CaixaEletronico09.Entities
{
    public sealed class Sacar : ISacar
    {
  
        public void sacarDinheiro(Cofre cofre, int valor)
        {
            //Lógica caso o valor solicitado exista no caixa:
            if ((valor <= cofre.totalCofre) && (valor%10 == 0))
            {
                //desconta o valor do total do caixa
                cofre.totalCofre -= valor;

                //desconta as maiores cédulas do caixa
                int valorTemporario = valor; 

                if(valorTemporario >= 50)
                {
                    //Descobrir quantas notas de 50 existem no valor solicitado
                    int totalNotas50 = valorTemporario / 50; 
                    //Descontar do cofre o número de notas de 50 sacado
                    cofre.totalNotas50 -= totalNotas50;
                    //Descontar o VALOR do total de notas de 50 sacado da var temp
                    valorTemporario -= totalNotas50 * 50; 
                }if(valorTemporario >= 20)
                {
                    int totalNotas20 = valorTemporario / 20; 
                    cofre.totalNotas20 -= totalNotas20;
                    valorTemporario -= totalNotas20 * 20;
                }
                if (valorTemporario >= 10)
                {
                    int totalNotas10 = valorTemporario / 10; 
                    cofre.totalNotas10 -= totalNotas10;
                    valorTemporario -= totalNotas10 * 10;
                }
                
                //Retorno de sucesso para o usuário
                Console.WriteLine("R$ "
                    + valor
                    +",00"
                    +" sacado com sucesso!");
            }
            else Console.WriteLine("Valor indisponível");
                      
        }
    }
}

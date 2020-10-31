using System;

namespace B5S
{
    class Program
    {
        /**
         * A função recebe um inteiro entre 1 e 12 e retorna o mês correspondente por extenso. Caso o mês informado não esteja entre 1 e 12, deverá ser retornado "Mes Inexistente"
         * Ex: Se recebe 1, retorna "janeiro"
         * Ex2: Se receber 13, retorna "Mes Inexistente"
         *
         * @param int $mes - Inteiro representando o mês a ser exibido por extenso
         * @return string
         */
        static void Main(string[] args)
        {            
            Console.WriteLine("Digite um numero: ");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O mes " +mes+ " é " +MesCorrespondente(mes));           
        }

        static public string MesCorrespondente(int mes)
        {            
            switch (mes)
            {
                case 1:
                    return "Janeiro";
                case 2:
                    return "Fevereiro";                  
                case 3:
                    return "Março";                    
                case 4:
                    return "Abril";
                case 5:
                    return "Maio";
                case 6:
                    return "Junho";
                case 7:
                    return "Julho";
                case 8:
                    return "Agosto";
                case 9:
                    return "Setembro";
                case 10:
                    return "Outubro";
                case 11:
                    return "Novembro";
                case 12:
                    return "Dezembro";
                default:
                    return "Mes inexistente";
            }

        }
    }

   
}

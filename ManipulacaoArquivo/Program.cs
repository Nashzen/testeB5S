using System;
using System.IO;

/**
* A função deverá ler o arquivo data.dat e retornar o número de linhas que atende pelo menos uma das condições abaixo:
* 1 - A quantidade de números zeros na linha é um multiplo de 3
* 2 - A quantidade de números 1 é um multiplo de 2
*
* @return int - O número de linhas que atende ao menos uma das condições necessárias
*/
/**
 * REFERENCIAS: 
 * https://www.daniweb.com/programming/software-development/threads/37710/reading-dat-file-data-into-an-array
 * http://www.macoratti.net/14/04/c_iotb1.htm
 **/

namespace ManipulacaoArquivo
{
    class Program
    {        
        static void Main(string[] args)
        {            
            ManipulacaoArquivo();
        }

        public static void ManipulacaoArquivo()
        {
            string localArquivo = @"C:\Users\leo-s\Documents\GitHub\testeB5S\ManipulacaoArquivo\data.dat"; //variavel para identificar o local do arquivo

            StreamReader arquivo = new StreamReader(localArquivo, System.Text.Encoding.Default);
            string conteudoArquivo = arquivo.ReadToEnd().Trim(); //Ler o arquivo
            string[] conteudoLinha = System.Text.RegularExpressions.Regex.Split(conteudoArquivo, "\\s+", System.Text.RegularExpressions.RegexOptions.None); //conteudo da linha

            int umMultiploDe2 = 0;
            int zeroMultiploDe3 = 0;

            foreach (string linha in conteudoLinha) //Loop para verificar cada linha do arquivo
            {                
                char[] arrayLinha = linha.ToCharArray(); //Array para pegar cada caractere do array
                int quantidadeDeZero = 0;
                int quantidadeDeUm = 0;

                foreach (char letra in arrayLinha) //Loop para verificar cada caractere do array
                {
                    if(letra == '0')
                    {
                        quantidadeDeZero++; 
                    }
                    if(letra == '1')
                    {
                        quantidadeDeUm++;
                    }                   
                }
                //Contadores das linhas que possuem as validações necessárias
                if(quantidadeDeUm % 2 == 0)
                {
                    umMultiploDe2++;
                }
                if(quantidadeDeZero % 3 == 0)
                {
                    zeroMultiploDe3++;
                }
            }            
            Console.WriteLine("Linhas em que a quantidade de zeros é multipla de três: " + zeroMultiploDe3);
            Console.WriteLine("Linhas em que a quantidade de uns é multipla de dois: " + umMultiploDe2);
        }
    }
}
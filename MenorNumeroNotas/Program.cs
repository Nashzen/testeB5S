using System;

namespace MenorNumeroNotas
{
    /**
     * A função será utilizada em um sistema de caixa.
     * Ela receberá um valor inteiro, representando o valor a ser sacado e um array contendo quais tipos de cédulas ela tem disponível.
     * O array de cédulas disponiveis indica quais valores de cédulas existirão no caixa, a quantidade das mesmas é ilimitada. No caso do input [2,5,50], o caixa terá quantidades ilimitadas de notas de 2, 5 e 50 para devolver ao cliente.
     * A função deverá retornar o mínimo de cédulas necessarias possivel para o saque em formato de um array, cuja chave seja o valor da cédula e o valor a quantidade daquela cédula que será sacada.
     *
     * Exemplo: Caso o input submetido for 150 e [5, 50, 100], o sistema deverá retornar o array ["100"=>1, "50"=>1].
     * Exemplo 2: Caso o input submetido for 150 e [2, 5, 10], o sistema deverá retornar o array ["10"=>15].
     *
     * @param int   $valor   - O valor a ser sacado
     * @param array $cedulas - Array contendo as cédulas disponíveis. Ex: [2,5,10,50,100]
     *
     * @return array
     */
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[0];        
            int[] cedulas = new int[0];
            bool inserirValor = true;

            Console.WriteLine("Insira o valor a ser sacado");

            int valorSacado = Int32.Parse(Console.ReadLine());

            while (inserirValor)
            {
                Console.Clear();
                Console.WriteLine("Insira o valor de uma cédula");

                Array.Resize(ref cedulas, cedulas.Length + 1);
                cedulas[cedulas.Length - 1] = Int32.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("Inserir outra cédula?");
                string resposta = Console.ReadLine();

                if (resposta == "N" || resposta == "n")
                {
                    Console.Clear();
                    int[] x = menorNumeroNotas(valorSacado, cedulas);
                    for (int contador = 0; contador <= cedulas.Length - 1; contador++)
                    {
                        Console.WriteLine("Cédula: " + cedulas[contador] + "  Quantidade: " + x[contador]);
                    }
                    Console.ReadLine();
                }
            }
        }

        static int[] menorNumeroNotas(int valor, int[] cedulas)
        {
            int[] numeroDeCedulas = new int[cedulas.Length];

            for (int contador = cedulas.Length; contador >= 1; contador--)
            {
                if (valor - cedulas[contador - 1] >= 0)
                {
                    valor -= cedulas[contador - 1];
                    numeroDeCedulas[contador - 1]++;
                }
            }

            if (valor > 0)
            {
                Console.WriteLine("Desculpe, mas estamos sem cédulas para completar seu saque. Valor restante para saque : " + valor);
                Console.WriteLine("Pressione ENTER para continuar.");
                Console.ReadLine();
            }

            return numeroDeCedulas;

        }
    }
}

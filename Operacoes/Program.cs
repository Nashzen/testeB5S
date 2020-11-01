using System;
using System.Linq;

namespace Operacoes
{
    /**
        * A função recebe um array de inteiros com pelo menos 2 itens e uma string que contem a operação a ser realizada com cada item do array.
        * Caso o array possua menos que dois itens, deverá ser retornado false.
        * Ex: Se a função recebe o array [1,2,3] e a string "soma", a mesma deverá retornar 6
        * A função deverá aceitar as operações "soma", "subtracao", "multiplicacao" e "divisao". Caso a função receba qualquer outra operação, ela deverá retornar "undefined operation".
        *
        * @param array $valores - Array que contem apenas números inteiros.
        * @param string $operacao - A operação a ser realizada com os inteiros existentes no array
        * @return string|int|float
        */
    class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[0];
            String resposta;
            bool validadorArray = true;
            bool validadorOperacao = true;

            while (validadorArray)
            {
                Console.WriteLine("Insira um valor na lista");
                Array.Resize(ref valores, valores.Length + 1);

                valores[valores.Length - 1] = Int32.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("Deseja inserir outro valor? (S/N)");
                resposta = Console.ReadLine();

                if (resposta == "n" || resposta == "N")
                {

                    validadorArray = false;

                    if (valores.Length < 2)
                    {
                        Console.WriteLine("Array com menos de 2 valores não são aceitos. Insira mais valores.");
                        Console.WriteLine("Aperte ENTER para continuar.");
                        Console.ReadLine();
                        Console.Clear();

                        validadorArray = true;
                    }


                }

            }

            while (validadorOperacao)
            {
                Console.Clear();
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("soma");
                Console.WriteLine("sub");
                Console.WriteLine("mult");
                Console.WriteLine("div");


                String operacao = Console.ReadLine();

                if (
                    "soma" != operacao &&
                    "sub" != operacao &&
                    "mult" != operacao &&
                    "div" != operacao
                    )

                {
                    Console.WriteLine("Operação não definida");
                }
                else if ("div" == operacao && valores.Contains(0))
                {
                    Console.WriteLine("ERRO::: Não é possivel dividir por 0");
                }
                else
                {
                    Console.WriteLine("O resultado da " + operacao + " é: " + operacoes(valores, operacao));
                    Console.ReadLine();
                    validadorOperacao = false;
                }


            }
        }

        static float operacoes(int[] valores, string operacao)
        {
            float resultado = 0;

            Console.WriteLine("tamanho : " + valores.Length);
            Console.ReadLine();

            if (operacao == "soma") { resultado = soma(valores); }
            if (operacao == "sub") { resultado = sub(valores); }
            if (operacao == "mult") { resultado = mult(valores); }
            if (operacao == "div") { resultado = div(valores); }

            return resultado;
        }

        static float soma(int[] valores)
        {

            int somaTotal = 0;

            for (int contador = 0; contador <= valores.Length - 1; contador++)
            {

                somaTotal += valores[contador];
            }
            return somaTotal;
        }

        static float sub(int[] valores)
        {
            int subTotal = 0;

            for (int contador = 0; contador <= valores.Length - 1; contador++)
            {
                subTotal -= valores[contador];
            }
            return subTotal;
        }


        static float mult(int[] valores)
        {
            int multTotal = 1;

            for (int contador = 0; contador <= valores.Length - 1; contador++)
            {
                multTotal = multTotal * valores[contador];
            }
            return multTotal;
        }

        static float div(int[] valores)
        {
            int[] valoresClone = (int[])valores.Clone();

            int divTotal = 1;

            for (int contador = 0; contador <= valoresClone.Length - 2; contador++)
            {
                divTotal = valoresClone[contador] / valoresClone[contador + 1];
                valoresClone[contador + 1] = divTotal;


            }
            return divTotal;
        }


    }
}

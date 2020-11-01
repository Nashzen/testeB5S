using System;

namespace OrdenarArray
{
    class Program
    {
        /**
         * A função deverá receber um array de inteiros como parâmetro e deverá retornar o mesmo array ordenado em ordem crescente.
         * Ex: Se a função receber o array [5,1,0,7,3,3], deverá retornar o array [0,1,3,3,5,7].
         *
         * @param array $array - Array a ser ordenado
         * @return array
         */
        static void Main(string[] args)
        {
            int[] valores = new int[0];
            String resposta;
            bool validadorArray = true;

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
                }

            }

            Console.WriteLine("Seu array ordenado fica: ");
            valores = ordenarArray(valores);
            for (int contador = 0; contador < valores.Length; contador++)
            {
                Console.WriteLine(valores[contador]);
            }
            Console.ReadLine();
        }

        static int[] ordenarArray(int[] valores)
        {
            Array.Sort(valores);

            return valores;
        }
    }
}

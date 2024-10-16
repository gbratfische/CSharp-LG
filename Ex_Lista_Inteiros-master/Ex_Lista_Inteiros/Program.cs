using System;
using System.Collections;
using System.Collections.Generic;


namespace Ex_Lista_Inteiros
{
    internal class Program
    {
        static void Main()
        {
            // 1. Criar uma lista de inteiros
            List<int> numeros = new List<int>();
            string valor_entrada;

            // 2. Adicionar elementos à lista com entrada do usuário
            while (true)
            {
                Console.Write("Informe um número inteiro (ou 'sair' para finalizar): ");
                valor_entrada = Console.ReadLine();

                // Verifica se o usuário deseja sair
                if (valor_entrada.ToLower() == "sair")
                    break;

                // Tenta converter a entrada para um inteiro
                if (int.TryParse(valor_entrada, out int numero))
                {
                    numeros.Add(numero);
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
                }
            }

            // 3. Mostrar a lista após as adições de valores pelo usuário
            Console.WriteLine("3 - Lista após adições: " + string.Join(", ", numeros));

            // 4. Adicionar múltiplos elementos usando AddRange
            List<int> maisNumeros = new List<int> { 40, 50, 60 };
            numeros.AddRange(maisNumeros);
            Console.WriteLine("4 - Lista após AddRange (3 valores: 40-50-60): " + string.Join(", ", numeros));

            // 5. Inserir um elemento em uma posição específica
            numeros.Insert(2, 25); // Insere o número 25 na posição 2
            Console.WriteLine("5 - Lista após inserção do valor 25 na posição 2: " + string.Join(", ", numeros));

            // 6. Remover um elemento específico
            numeros.Remove(40); // Remove a primeira ocorrência do número 30
            Console.WriteLine("6 - Lista após remoção do número 40 (1ª ocorrência): " + string.Join(", ", numeros));

            // 7. Remover um elemento pelo índice
            if (numeros.Count > 0) // Verifica se há elementos na lista antes de remover
            {
                numeros.RemoveAt(0); // Remove o elemento no índice 0
                Console.WriteLine("7 - Lista após remoção do primeiro elemento (posição 0): " + string.Join(", ", numeros));
            }

            // 8. Percorrer os elementos da lista
            Console.WriteLine("8 - Percorrendo a lista:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            #region Buscar_Elemento
            // 9. Verificar se a lista contém um elemento
            Console.Write("Informe um número inteiro para procurar na lista: ");
            valor_entrada = Console.ReadLine();

            // Tenta converter a entrada para um inteiro
            if (int.TryParse(valor_entrada, out int valor_busca))
            {
                if (numeros.Contains(valor_busca))
                {
                    Console.WriteLine($"9 - A lista contém o número {valor_busca}.");
                }
                else
                {
                    Console.WriteLine($"9 - A lista NÃO contém o número {valor_busca}.");
                }
            }
            #endregion Buscar_Elemento

            // 10. Reordenar a lista em ordem crescente
            numeros.Sort();
            Console.WriteLine("10 - Lista após reordenação: " + string.Join(", ", numeros));

            // 11. Limpar a lista
            numeros.Clear();
            Console.WriteLine("11 - Lista após limpeza: " + (numeros.Count == 0 ? "Lista vazia" : string.Join(", ", numeros)));
            Console.ReadKey();
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace Autokey_Cipher
{
    public class AutoKeyCipher
    {
        public AutoKeyCipher()
        {
            TabulaRecta = GetTabulaRecta();
        }

        private char[][] TabulaRecta { get; set; }

        public string Cipher(
            string clearText, string keyword)
        {
            string result = string.Empty;

            keyword += clearText;
            keyword = keyword.Substring(0, clearText.Length);

            for (int i = 0; i < clearText.Length; i++)
            {
                int row = clearText[i] - 'a';
                int col = keyword[i] - 'a';

                result += TabulaRecta[row][col];
            }

            return result;
        }

        public string Decipher(
            string cipherText, string keyword)
        {
            string result = string.Empty;

            TabulaRecta = TransposeMatrix(TabulaRecta);

            for (int i = 0; i < cipherText.Length; i++)
            {
                int row = keyword[i] - 'a';
                int col = IndexOf(TabulaRecta[row], cipherText[i]);

                result += TabulaRecta[0][col];
                keyword += TabulaRecta[0][col];
            }

            return result;
        }

        private static char[][] TransposeMatrix(char[][] matrix)
        {
            char[][] result = new char[matrix[0].Length][];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new char[matrix.Length];
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    result[col][row] = matrix[row][col];
                }
            }

            return result;
        }

        private char[][] GetTabulaRecta()
        {
            List<char> alphabet = Enumerable.Range('a', 'z' - 'a' + 1).Select(x => (char)x).ToList();
            char[][] tabulaRecta = new char['z' - 'a' + 1][];
            for (int i = 0; i < tabulaRecta.Length; i++)
            {
                tabulaRecta[i] = alphabet.ToArray();
                var first = alphabet.First();
                alphabet.Remove(first);
                alphabet.Insert(alphabet.Count, first);
            }

            return tabulaRecta;
        }

        private int IndexOf(char[] array, char toFind)
        {
            int result = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == toFind)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }
    }
}
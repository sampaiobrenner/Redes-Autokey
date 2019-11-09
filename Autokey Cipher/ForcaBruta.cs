using System;
using System.Diagnostics;

namespace Autokey_Cipher
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public static class ForcaBruta
    {
        public static string ExecutarForcaBruta(string cifra, string textoOriginal, int tamanhoDaChave, string chaveOriginal, out long tempoDeExecucao)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            const string dict = @"Palavras.txt";
            var dictionary = new List<string>();
            var countRefs = new Dictionary<string, int>();

            string attempt;
            const int limiter = 2;

            using (var sr = File.OpenText(dict))
            {
                var wordpre = "";
                while ((wordpre = sr.ReadLine()) != null)
                {
                    if (wordpre.Length >= limiter)
                        dictionary.Add(wordpre);
                }
            }

            using (var sr = File.OpenText(dict))
            {
                var word = "";
                while ((word = sr.ReadLine()) != null)
                {
                    if (!IsAllLetters(word) || word.Length != tamanhoDaChave) continue;

                    attempt = DecipherVeginere(cifra, word);
                    if (dictionary.Any(attempt.Contains))
                        countRefs.Add(word, dictionary.Count(s => attempt.Contains(s)));
                }
            }

            stopWatch.Stop();
            tempoDeExecucao = stopWatch.ElapsedMilliseconds;

            foreach (var item in countRefs.OrderByDescending(r => r.Value))
                if (DecipherVeginere(cifra, item.Key) == textoOriginal && item.Key == chaveOriginal)
                    return $"Chave: {item.Key} {Environment.NewLine}Cifra: {cifra} {Environment.NewLine}Texto: {DecipherVeginere(cifra, item.Key)}";

            return "Não foram encontrados resultados.";
        }

        private static string DecipherVeginere(string text, string key) => new AutoKeyCipher().Decipher(text, key);

        private static bool IsAllLetters(string s) => s.All(char.IsLetter);
    }
}
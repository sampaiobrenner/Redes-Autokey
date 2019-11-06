using static System.Char;

namespace Autokey_Cipher
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class ForcaBruta
    {
        public string ExecutarForcaBruta(string cifra, string textoOriginal)
        {
            var dict = @"Palavras.txt";
            var output = @"output2.txt";
            var dictionary = new List<string>();

            var countRefs = new Dictionary<string, int>();

            if (!File.Exists(output))
                using (File.CreateText(output))
                {
                }

            var value = cifra;
            string attempt;
            double progress = 0, total = 0;
            var limiter = 2;

            using (var sr = File.OpenText(dict))
            {
                var wordpre = "";
                while ((wordpre = sr.ReadLine()) != null)
                {
                    total += 1;
                    if (wordpre.Length >= limiter)
                        dictionary.Add(wordpre);
                }
            }

            for (var keylength = 1; keylength <= 5; keylength++)
            {
                using (var sr = File.OpenText(dict))
                {
                    var word = "";
                    while ((word = sr.ReadLine()) != null)
                    {
                        progress += 1;
                        if (IsAllLetters(word))
                        {
                            if (word.Length == keylength)
                            {
                                attempt = DecipherVeginere(value, word);
                                if (dictionary.Any(attempt.Contains))
                                {
                                    Console.WriteLine("\r[S] " + word + "\t\t" + attempt);
                                    using (var sw = File.AppendText(output))
                                        sw.WriteLine("\r[S] " + word + "\t\t" + attempt);

                                    countRefs.Add(word, dictionary.Count(s => attempt.Contains(s)));
                                }
                            }
                        }
                        Console.Write("\r>{0:n}%", (500 / total) * progress);
                    }
                }
            }

            Console.WriteLine("  [Total: {0}]", total);
            Console.WriteLine("");

            foreach (var item in countRefs.OrderByDescending(r => r.Value))
                if (DecipherVeginere(value, item.Key) == textoOriginal)
                    return $"Chave: {item.Key} | Cifra: {value} | Texto: {DecipherVeginere(value, item.Key)}";

            return "Não foram encontrados resultados.";
        }

        private string DecipherVeginere(string text, string key) => new AutoKeyCipher().Decipher(text, key);

        private bool IsAllLetters(string s) => s.All(IsLetter);
    }
}
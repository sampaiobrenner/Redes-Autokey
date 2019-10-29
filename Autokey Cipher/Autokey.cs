using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Autokey_Cipher
{
    public static class Autokey
    {
        private static readonly char[] Alphabet = " !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~".ToCharArray();

        public static string SubstituirCaracteresEspeciais(this string texto)
        {
            var textoRetorno = new StringBuilder(texto);

            // Mapeia os caracteres que serão substituido com expressões regulares
            var regAmin = new Regex("[ã|à|â|ä|á|å]");
            var regAmai = new Regex("[Ã|À|Â|Ä|Á|Å]");
            var regEmin = new Regex("[é|è|ê|ë]");
            var regEmai = new Regex("[É|È|Ê|Ë]");
            var regImin = new Regex("[í|ì|î|ï]");
            var regImai = new Regex("[Í|Ì|Î|Ï]");
            var regOmin = new Regex("[õ|ò|ó|ô|ö]");
            var regOmai = new Regex("[Õ|Ó|Ò|Ô|Ö]");
            var regUmin = new Regex("[ù|ú|û|ü|µ]");
            var regUmai = new Regex("[Ü|Ú|Ù|Û]");
            var regYmin = new Regex("[ý|ÿ]");
            var regYmai = new Regex("[Ý]");
            var regAEmin = new Regex("[æ]");
            var regAEmai = new Regex("[Æ]");
            var regOEmin = new Regex("[œ]");
            var regOEmai = new Regex("[Œ]");
            var regCmin = new Regex("[ç]");
            var regCmai = new Regex("[Ç]");
            var regDmai = new Regex("[Ð]");
            var regNmin = new Regex("[ñ]");
            var regNmai = new Regex("[Ñ]");
            var regSmin = new Regex("[š]");
            var regSmai = new Regex("[Š]");
            var regGrau1 = new Regex("[º]");
            var regGrau2 = new Regex("[°]");
            var regNUm = new Regex("¹");
            var regNDois = new Regex("²");
            var regNTres = new Regex("³");
            var regLibra = new Regex("£");
            var regCents = new Regex("¢");
            var regNegacao = new Regex("¬");
            var regAgudo = new Regex("´");
            var regGrave = new Regex("`");
            var regCircunflexo = new Regex("^");
            var regTil = new Regex("~");
            var regTrema = new Regex("¨");
            var regInterrogacaoInvertido = new Regex("¿");
            var regMeio = new Regex("½");
            var regEComercial = new Regex("&");
            var regAspasSimples = new Regex("\'");
            var regAspasDuplas = new Regex("\"");

            // Subtitui os caracteres mapeados
            textoRetorno = new StringBuilder(regAmin.Replace(textoRetorno.ToString(), "a"));
            textoRetorno = new StringBuilder(regAmai.Replace(textoRetorno.ToString(), "A"));
            textoRetorno = new StringBuilder(regEmin.Replace(textoRetorno.ToString(), "e"));
            textoRetorno = new StringBuilder(regEmai.Replace(textoRetorno.ToString(), "E"));
            textoRetorno = new StringBuilder(regImin.Replace(textoRetorno.ToString(), "i"));
            textoRetorno = new StringBuilder(regImai.Replace(textoRetorno.ToString(), "I"));
            textoRetorno = new StringBuilder(regOmin.Replace(textoRetorno.ToString(), "o"));
            textoRetorno = new StringBuilder(regOmai.Replace(textoRetorno.ToString(), "O"));
            textoRetorno = new StringBuilder(regUmin.Replace(textoRetorno.ToString(), "u"));
            textoRetorno = new StringBuilder(regUmai.Replace(textoRetorno.ToString(), "U"));
            textoRetorno = new StringBuilder(regYmin.Replace(textoRetorno.ToString(), "y"));
            textoRetorno = new StringBuilder(regYmai.Replace(textoRetorno.ToString(), "Y"));
            textoRetorno = new StringBuilder(regAEmin.Replace(textoRetorno.ToString(), "ae"));
            textoRetorno = new StringBuilder(regAEmai.Replace(textoRetorno.ToString(), "AE"));
            textoRetorno = new StringBuilder(regOEmin.Replace(textoRetorno.ToString(), "oe"));
            textoRetorno = new StringBuilder(regOEmai.Replace(textoRetorno.ToString(), "OE"));
            textoRetorno = new StringBuilder(regCmin.Replace(textoRetorno.ToString(), "c"));
            textoRetorno = new StringBuilder(regCmai.Replace(textoRetorno.ToString(), "C"));
            textoRetorno = new StringBuilder(regDmai.Replace(textoRetorno.ToString(), "D"));
            textoRetorno = new StringBuilder(regNmin.Replace(textoRetorno.ToString(), "n"));
            textoRetorno = new StringBuilder(regNmai.Replace(textoRetorno.ToString(), "N"));
            textoRetorno = new StringBuilder(regSmin.Replace(textoRetorno.ToString(), "s"));
            textoRetorno = new StringBuilder(regSmai.Replace(textoRetorno.ToString(), "S"));
            textoRetorno = new StringBuilder(regGrau1.Replace(textoRetorno.ToString(), "o"));
            textoRetorno = new StringBuilder(regGrau2.Replace(textoRetorno.ToString(), "o"));
            textoRetorno = new StringBuilder(regNUm.Replace(textoRetorno.ToString(), "1"));
            textoRetorno = new StringBuilder(regNDois.Replace(textoRetorno.ToString(), "2"));
            textoRetorno = new StringBuilder(regNTres.Replace(textoRetorno.ToString(), "3"));
            textoRetorno = new StringBuilder(regLibra.Replace(textoRetorno.ToString(), ""));
            textoRetorno = new StringBuilder(regCents.Replace(textoRetorno.ToString(), ""));
            textoRetorno = new StringBuilder(regNegacao.Replace(textoRetorno.ToString(), ""));
            textoRetorno = new StringBuilder(regAgudo.Replace(textoRetorno.ToString(), ""));
            textoRetorno = new StringBuilder(regGrave.Replace(textoRetorno.ToString(), ""));
            textoRetorno = new StringBuilder(regCircunflexo.Replace(textoRetorno.ToString(), ""));
            textoRetorno = new StringBuilder(regTil.Replace(textoRetorno.ToString(), ""));
            textoRetorno = new StringBuilder(regTrema.Replace(textoRetorno.ToString(), ""));
            textoRetorno = new StringBuilder(regInterrogacaoInvertido.Replace(textoRetorno.ToString(), ""));
            textoRetorno = new StringBuilder(regMeio.Replace(textoRetorno.ToString(), ""));
            textoRetorno = new StringBuilder(regEComercial.Replace(textoRetorno.ToString(), ""));
            textoRetorno = new StringBuilder(regAspasSimples.Replace(textoRetorno.ToString(), ""));
            textoRetorno = new StringBuilder(regAspasDuplas.Replace(textoRetorno.ToString(), ""));

            return textoRetorno.ToString();
        }

        public static string Encrypt(string plain, string pass)
        {
            var message = plain.ToCharArray();
            var keystream = (pass + plain).ToCharArray();

            for (var i = 0; i < message.Length; i++)
            {
                var keyidx = Array.IndexOf(Alphabet, keystream[i]);
                var msgidx = Array.IndexOf(Alphabet, message[i]);

                message[i] = Alphabet[(Alphabet.Length + keyidx + msgidx) % Alphabet.Length];
            }
            return new string(message);
        }

        public static string Decrypt(string encrypted, string pass)
        {
            var message = encrypted.ToCharArray();
            var keystream = (pass + encrypted).ToCharArray();

            for (var i = 0; i < message.Length; i++)
            {
                var keyidx = Array.IndexOf(Alphabet, keystream[i]);
                var msgidx = Array.IndexOf(Alphabet, message[i]);

                message[i] = Alphabet[(Alphabet.Length + msgidx - keyidx) % Alphabet.Length];
                keystream[i + pass.Length] = message[i];
            }
            return new string(message);
        }
    }
}
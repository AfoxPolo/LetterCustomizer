using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Globalization;

namespace ConversorDeCaracteres {
    
    public static class Auxiliar {

    }

    /// <summary>
    /// ----------------------------------------- CODE LIMPO
    /// </summary>
    
    
    // CLASSE Idioma
    public static class Idioma {

        public struct PALAVRA {
            public string Portugues;
            public string Ingles;
            public string Espanhol;
        }

        public static Dictionary<string, PALAVRA> FRASES = new Dictionary<string, PALAVRA> {
            { "Iniciar", new PALAVRA { Portugues = "Iniciar", Ingles = "Start", Espanhol = "Comienzo" } },
            { "Sair", new PALAVRA { Portugues = "Sair", Ingles = "Exit", Espanhol = "Sal" } },
            { "Programa", new PALAVRA { Portugues = "Programa", Ingles = "Program", Espanhol = "Programa" } },
            { "Preferencias", new PALAVRA { Portugues = "Preferencias", Ingles = "Preferences", Espanhol = "Preferencias" } },
            { "Escreva seu texto aqui", new PALAVRA { Portugues = "Escreva seu texto aqui", Ingles = "Write your text here", Espanhol = "Escribe tu texto aquí" } },
            { "Escolha uma fonte", new PALAVRA { Portugues = "Escolha uma fonte", Ingles = "Choose a font", Espanhol = "Elija una fuente" } },
            { "Copiar", new PALAVRA { Portugues = "Copiar", Ingles = "Copy", Espanhol = "Copiar" } },
            { "Local de arquivos", new PALAVRA { Portugues = "Local de arquivos", Ingles = "File location", Espanhol = "Ubicación del archivo" } },
            { "Tema", new PALAVRA { Portugues = "Tema", Ingles = "Theme", Espanhol = "Tema" } },
            { "Idioma", new PALAVRA { Portugues = "Idioma", Ingles = "Language", Espanhol = "Idioma" } },
            { "Desenvolvedor", new PALAVRA { Portugues = "Desenvolvedor", Ingles = "Developer", Espanhol = "Desarrollador" } },
            { "Ajuda", new PALAVRA { Portugues = "Ajuda", Ingles = "Help", Espanhol = "Ayuda" } },
            { "Usar Molduras", new PALAVRA { Portugues = "Usar Molduras", Ingles = "Use Frames", Espanhol = "Usar marcos" } },
            { "Branco", new PALAVRA { Portugues = "Branco", Ingles = "White", Espanhol = "Blanco" } },
            { "Azul Forte", new PALAVRA { Portugues = "Azul Forte", Ingles = "Dark blue", Espanhol = "Azul oscuro" } },
            { "Portugues", new PALAVRA { Portugues = "Portugues", Ingles = "Portuguese", Espanhol = "Portugués" } },
            { "Ingles", new PALAVRA { Portugues = "Ingles", Ingles = "English", Espanhol = "Inglés" } },
            { "Espanhol", new PALAVRA { Portugues = "Espanhol", Ingles = "Spanish", Espanhol = "Español" } },
            { "Você tem certeza que deseja finalizar o programa?", new PALAVRA { Portugues = "Você tem certeza que deseja finalizar o programa?", Ingles = "Are you sure you want to end the program?", Espanhol = "¿Está seguro de que desea finalizar el programa?" } },
            { "você tem certeza que deseja reiniciar programa?", new PALAVRA { Portugues = "você tem certeza que deseja reiniciar programa?", Ingles = "are you sure you want to restart the program?", Espanhol = "¿Estás seguro de que deseas reiniciar el programa?" } },
            { "Fechar programa", new PALAVRA { Portugues = "Fechar programa", Ingles = "Close program", Espanhol = "Cerrar programa" } },
            { "Reiniciar programa", new PALAVRA { Portugues = "Reiniciar programa", Ingles = "Restart program", Espanhol = "Reiniciar programa" } },
            { "Éstá função esta indisponivel no momento", new PALAVRA { Portugues = "Éstá função esta indisponivel no momento", Ingles = "This function is currently unavailable", Espanhol = "Esta función no está disponible actualmente" } },
            { "ERRO - idioma invalido", new PALAVRA { Portugues = "ERRO - idioma invalido", Ingles = "ERROR - invalid language", Espanhol = "ERROR: idioma no válido" } },
            { "Sobre", new PALAVRA { Portugues = "Sobre", Ingles = "On", Espanhol = "Sobre" } },
            { "Programa desenvolvido por AfoxPolo", new PALAVRA { Portugues = "Programa desenvolvido por AfoxPolo", Ingles = "Program developed by AfoxPolo", Espanhol = "Programa desarrollado por AfoxPolo" } },
            { "Deseja Acessar o git do desenvolvedor no navegador?", new PALAVRA { Portugues = "Deseja Acessar o git do desenvolvedor no navegador?", Ingles = "Do you want to Access the developer git in the browser?", Espanhol = "¿Quieres acceder al git del desarrollador en el navegador?" } },
            { "Entrar em contato", new PALAVRA { Portugues = "Entrar em contato", Ingles = "Do you want to Access the developer git in the browser?", Espanhol = "¿Quieres acceder al git del desarrollador en el navegador?" } },
            { "Versão do programa", new PALAVRA { Portugues = "Versão do programa", Ingles = "Program version", Espanhol = "Versión del programa" } },
            { "Para mais informaçoes acesse o git do desenvolvedor em 'Ajuda/Desenvolvedor'", new PALAVRA { Portugues = "Para mais informaçoes acesse o git do desenvolvedor em 'Ajuda/Desenvolvedor'", Ingles = "For more information visit the developer git in 'Help / Developer'", Espanhol = "Para obtener más información, visite el desarrollador git en 'Ayuda / Desarrollador'" } },
            { "O TEXTO FICA ASSIM", new PALAVRA { Portugues = "O TEXTO FICA ASSIM", Ingles = "THE TEXT IS LIKE THIS", Espanhol = "EL TEXTO ES ASÍ" } },
            //{ "", new PALAVRA { Portugues = "", Ingles = "", Espanhol = "" } },
        };

        public static string Tradusir(this string txt) {

            string resultado;

            if (FRASES.ContainsKey(txt)) {
                if (STATUS_GERAL.idiomaAtual == idiomasEnum.Portugues) {
                    resultado = FRASES[txt].Portugues;
                }
                else if (STATUS_GERAL.idiomaAtual == idiomasEnum.Ingles) {
                    resultado = FRASES[txt].Ingles;
                }
                else if (STATUS_GERAL.idiomaAtual == idiomasEnum.Espanhol) {
                    resultado = FRASES[txt].Espanhol;
                }
                else {
                    resultado = "ERRO (CODE-ER: 01) Nenhum idioma definido?";
                }
            }
            else {
                resultado = $"ERRO (CODE-ER: 02) Frase não esta contida nas traducoes [Frase: \"{txt}\"]";
            }


            return resultado;
        }

    }

    //CLASSE ConverteFonte
    public class ConvertFonte {

        public static string Fonte1(string txt, bool BloquearMoldura = false) {
            return alterarCaractere(txt, "abcdefghijklmnopqrstuvwxyz", BloquearMoldura);
        }
        public static string Fonte2(string txt, bool BloquearMoldura = false) {
            return alterarCaractere(txt, "คЪcdεƒgн¡jкłмหσpqяรтuvωxყz", BloquearMoldura);
        }
        public static string Fonte3(string txt, bool BloquearMoldura = false) {
            return alterarCaractere(txt, "Aþς₫є₣gђijк∟м∩øÞqяSTџ√ώxyz", BloquearMoldura);
        }
        public static string Fonte4(string txt, bool BloquearMoldura = false) {
            return alterarCaractere(txt, "ΔβĆĐ€₣ǤĦƗĴҜŁΜŇØƤΩŘŞŦỮVŴЖ¥Ž", BloquearMoldura);
        }
        public static string Fonte5(string txt, bool BloquearMoldura = false) {
            return alterarCaractereExtremo(txt, new string[] { "A̶", "B̶", "C̶", "D̶", "E̶", "F̶", "G̶", "H̶", "I̶", "J̶", "K̶", "L̶", "M̶", "N̶", "O̶", "P̶", "Q̶", "R̶", "S̶", "T̶", "U̶", "V̶", "W̶", "X̶", "Y̶", "Z̶" }, BloquearMoldura);
        }
        public static string Fonte6(string txt, bool BloquearMoldura = false) {
            return alterarCaractereExtremo(txt, new string[] { "α̲̅", "B̲̅", "C̲̅", "D̲̅", "є̲̅", "F̲̅", "G̲̅", "н̲̅", "I̲̅", "J̲̅", "K̲̅", "L̲̅", "м̲̅", "и̲̅", "σ̲̅", "ρ̲̅", "Q̲̅", "я̲̅", "S̲̅", "т̲̅", "υ̲̅", "V̲̅", "W̲̅", "X̲̅", "Y̲̅", "Z̲̅" }, new string[] { "[", "]" }, BloquearMoldura);
            
        }
        public static string Fonte7(string txt, bool BloquearMoldura = false) {
            return alterarCaractereExtremo(txt, new string[] { "🅰", "🅱", "🅲", "🅳", "🅴", "🅵", "🅶", "🅷", "🅸", "🅹", "🅺", "🅻", "🅼", "🅽", "🅾", "🅿", "🆀", "🆁", "🆂", "🆃", "🆄", "🆅", "🆆", "🆇", "🆈", "🆉" }, BloquearMoldura);
        }
        public static string Fonte8(string txt, bool BloquearMoldura = false) {
            return alterarCaractereExtremo(txt, new string[] { "𝒜", "𝐵", "𝒞", "𝒟", "𝐸", "𝐹", "𝒢", "𝐻", "𝐼", "𝒥", "𝒦", "𝐿", "𝑀", "𝒩", "𝒪", "𝒫", "𝒬", "𝑅", "𝒮", "𝒯", "𝒰", "𝒱", "𝒲", "𝒳", "𝒴", "𝒵" }, BloquearMoldura);
        }
        public static string Fonte9(string txt, bool BloquearMoldura = false) {
            return "💤";
        }
        public static string Fonte10(string txt, bool BloquearMoldura = false) {
            return "💤";
        }

        private static string alterarCaractere(string txt, string fonte, bool BloquearMoldura = false) {
            StringBuilder listaRetorno = new StringBuilder();
            char[] listaCaracteres;
            char[] listaCaracteresComum;

            listaCaracteres = $"{fonte} -_@#$".ToCharArray();
            listaCaracteresComum = "abcdefghijklmnopqrstuvwxyz -_@#$".ToCharArray();

            foreach (char letra in txt) {
                for (int i = 0; i < 32; i++) {
                    if (letra.ToString().ToLower().RemoveAccents() == listaCaracteresComum[i].ToString()) {
                        listaRetorno.Append(listaCaracteres[i]);
                    }
                }
            }

            if (STATUS_GERAL.aplicarMoldura == true && BloquearMoldura == false) {
                return $"{STATUS_GERAL.molduraAtual[0]}{listaRetorno}{STATUS_GERAL.molduraAtual[1]}";
            }
            return listaRetorno.ToString();
        }

        private static string alterarCaractereExtremo(string txt, string[] letrasArray, bool BloquearMoldura = false) {

            StringBuilder listaRetorno = new StringBuilder();
            List<string> listaCaracteres = new List<string>();
            char[] listaCaracteresComum;
            string[] caracteresEspeciais = new string[] { " ", "-", "_", "@", "#", "$" };

            foreach (string letra in letrasArray) {
                listaCaracteres.Add(letra);
            }
            foreach (string caractere in caracteresEspeciais) {
                listaCaracteres.Add(caractere);
            }

            //listaCaracteres = $"{letra} -_@#$";
            listaCaracteresComum = "abcdefghijklmnopqrstuvwxyz -_@#$".ToCharArray();

            foreach (char letra2 in txt) {
                for (int i = 0; i < 32; i++) {
                    if (letra2.ToString().ToLower().RemoveAccents() == listaCaracteresComum[i].ToString()) {
                        listaRetorno.Append(listaCaracteres[i]);
                    }
                }
            }

            if (STATUS_GERAL.aplicarMoldura == true && BloquearMoldura == false) {
                return $"{STATUS_GERAL.molduraAtual[0]}{listaRetorno}{STATUS_GERAL.molduraAtual[1]}";
            }
            return listaRetorno.ToString();
        }

        private static string alterarCaractereExtremo(string txt, string[] letrasArray, string[] moldura, bool BloquearMoldura = false) {
            return $"{moldura[0]}{alterarCaractereExtremo(txt, letrasArray, BloquearMoldura)}{moldura[1]}";
        }
    }

    // CLASSE FERRAMENTA
    public static class Ferramentas {
        public static string RemoveAccents(this string text) {
            StringBuilder sbReturn = new StringBuilder();
            char[] arrayText = text.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letter in arrayText) {
                if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
                    sbReturn.Append(letter);
            }
            return sbReturn.ToString();
        }
    }

    #region TEMAS E CORES

    // CLASSE COR/MOLDE
    public class ConjuntoCor {
        public Color Fundo;
        public Color Fonte;
        public Color Interior;
        public Color Reversa;

        public ConjuntoCor(Color Fundo, Color Fonte, Color Interior, Color Reversa) {
            this.Fundo = Fundo;
            this.Fonte = Fonte;
            this.Interior = Interior;
            this.Reversa = Reversa;
        }
    }
    // CLASSE COR
    class Cor {
        
        // CORES
        public ConjuntoCor Branco;
        public ConjuntoCor AzulForte;
        public ConjuntoCor PretoEVerde;
        

        // ATRIBUIR CORES
        public Cor() {
            Branco = new ConjuntoCor(
                Color.FromName("Control"),
                Color.FromName("Black"),
                Color.FromName("Window"),
                Color.FromName("White"));

            AzulForte = new ConjuntoCor(
                Color.FromArgb(0, 7, 59),
                Color.FromArgb(255, 255, 255),
                Color.FromArgb(0, 12, 100),
                Color.FromArgb(0, 0, 0));

            PretoEVerde = new ConjuntoCor(
                Color.FromArgb(0, 0, 0),
                Color.FromArgb(0, 0, 0),
                Color.FromArgb(0, 0, 0),
                Color.FromArgb(0, 0, 0));

            
        }

        public static Cor Pintar() {
            Cor Objeto = new Cor();
            return Objeto;
        }
        
    }

    #endregion
}

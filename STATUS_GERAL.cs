namespace ConversorDeCaracteres {


    public enum idiomasEnum { Portugues, Ingles, Espanhol };
    

    class STATUS_GERAL {

        public static Cor Tema = new Cor();
        public static ConjuntoCor TemaAtual = Tema.Branco;

        public static idiomasEnum idiomaAtual = idiomasEnum.Ingles;

        public static bool aplicarMoldura = false;
        public static string[] molduraAtual = new string[2];


    }
}

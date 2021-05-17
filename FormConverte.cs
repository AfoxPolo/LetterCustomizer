using System;
using System.Threading;
using System.Windows.Forms;

namespace ConversorDeCaracteres {
    public partial class FormConverte : Form {


        public FormConverte() {
            InitializeComponent();
        }
        private void FormConverte_Load(object sender, EventArgs e) {

            definirIdioma();
            atualizarTema();
            atualizarListaDeMoldura();
            lbMolduras.Enabled = false;

            AtualizarListaDeFontes();
            lbFontes.SelectedIndex = 0;

        }


        // Botão Copiar
        private void btnCopiar_Click(object sender, EventArgs e) {
            Thread td = new Thread(new ThreadStart(() => {
                Clipboard.SetText(tbResultado.Text);
            }));
            td.SetApartmentState(ApartmentState.STA);
            td.IsBackground = true;
            td.Start();
        }

        // Metodo Atualizar idioma da form atual
        public void definirIdioma() {
            menuPaiPrograma.Text = "Programa".Tradusir();
            menuPaiPrograma_LocalDeArquivos.Text = "Local de arquivos".Tradusir();
            menuPaiPrograma_ReiniciarPrograma.Text = "Reiniciar programa".Tradusir();
            menuPaiPrograma_Sair.Text = "Sair".Tradusir();

            menuPaiPreferencias.Text = "Preferencias".Tradusir();
            menuPaiPreferencias_Tema.Text = "Tema".Tradusir();
            menuPaiPreferencias_Tema_Branco.Text = "Branco".Tradusir();
            menuPaiPreferencias_Tema_Escuro.Text = "Azul Forte".Tradusir();
            menuPaiPreferencias_Idioma.Text = "Idioma".Tradusir();
            menuPaiPreferencias_Idioma_Portugues.Text = "Portugues".Tradusir();
            menuPaiPreferencias_Idioma_Ingles.Text = "Ingles".Tradusir();
            menuPaiPreferencias_Idioma_Espanhol.Text = "Espanhol".Tradusir();

            menuPaiSobre.Text = "Sobre".Tradusir();
            menuPaiSobre_Desenvolvedor.Text = "Desenvolvedor".Tradusir();
            menuPaiSobre_VersaoDoPrograma.Text = "Versão do programa".Tradusir();

            lblEscrevaSeuNomeAqui.Text = "Escreva seu texto aqui".Tradusir();
            lblEscolhaUmaFonte.Text = "Escolha uma fonte".Tradusir();
            btnCopiar.Text = "Copiar".Tradusir();
            cbMoldura.Text = "Usar Molduras".Tradusir();

            AtualizarListaDeFontes();
        }
        

        // Botão Menu-Programa-Sair
        private void menuPaiPrograma_Sair_Click(object sender, EventArgs e) {

            string texto = "Você tem certeza que deseja finalizar o programa?".Tradusir();
            string texto2 = "Fechar programa".Tradusir(); 

            DialogResult res = MessageBox.Show(texto, texto2, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        
            if (res == DialogResult.Yes) {
                Close();
            }

        }

        // Botão Menu-Programa-Reiniciar Programa
        private void menuPaiPrograma_ReiniciarPrograma_Click(object sender, EventArgs e) {

            string texto = "você tem certeza que deseja reiniciar programa?".Tradusir();
            string texto2 = "Reiniciar programa".Tradusir();

            DialogResult res = MessageBox.Show(texto, texto2, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (res == DialogResult.Yes) {
                Application.Restart();
            }

        }

        // Botão Menu-Programa-Local de arquivos
        private void menuPaiPrograma_LocalDeArquivos_Click(object sender, EventArgs e) {
            MessageBox.Show("éstá função esta indisponivel no momento".Tradusir());

            

            #region ...
            //Thread td = new Thread(new ThreadStart(() => { 
            //    FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            //    DialogResult result = folderDlg.ShowDialog();
            //    MessageBox.Show(result.ToString());
            //}));



            //td.SetApartmentState(ApartmentState.STA);
            //td.IsBackground = true;
            //td.Start();
            #endregion

        }


        // Botão Menu-Preferencia-Tema-Branco
        private void menuPaiPreferencias_Tema_Branco_Click(object sender, EventArgs e) {

            STATUS_GERAL.TemaAtual = STATUS_GERAL.Tema.Branco;
            atualizarTema();

        }
        // Botão Menu-Preferencia-Tema-Azul Forte
        private void menuPaiPreferencias_Tema_AzulForte_Click(object sender, EventArgs e) {

            STATUS_GERAL.TemaAtual = STATUS_GERAL.Tema.AzulForte;
            atualizarTema();

        }

        // Botão Menu-Preferencias-Idioma-Portugues
        private void menuPaiPreferencias_Idioma_Portugues_Click(object sender, EventArgs e) {
            STATUS_GERAL.idiomaAtual = idiomasEnum.Portugues;
            definirIdioma();
        }
        // Botão Menu-Preferencias-Idioma-Ingles
        private void menuPaiPreferencias_Idioma_Ingles_Click(object sender, EventArgs e) {
            STATUS_GERAL.idiomaAtual = idiomasEnum.Ingles;
            definirIdioma();
        }
        // Botão Menu-Preferencias-Idioma-Espanhol
        private void menuPaiPreferencias_Idioma_Espanhol_Click(object sender, EventArgs e) {
            STATUS_GERAL.idiomaAtual = idiomasEnum.Espanhol;
            definirIdioma();
        }

        // Botão Menu-Sobre-Desenvolvedor
        private void menuPaiSobre_Desenvolvedor_Click(object sender, EventArgs e) {

            string texto1 = $"Programa desenvolvido por AfoxPolo".Tradusir();
            string texto2 = $"Deseja Acessar o git do desenvolvedor no navegador?".Tradusir();
            string texto3 = $"Entrar em contato".Tradusir();
            string texto4 = @"https://github.com/AfoxPolo";

            DialogResult res = MessageBox.Show($"{texto1}\n{texto2}\nLink: {texto4}", $"{texto3}", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            if (res == DialogResult.Yes) {
                System.Diagnostics.Process.Start(@"https://github.com/AfoxPolo");
            }
        }
        // Botão Menu-Sobre-Versao do programa
        private void menuPaiSobre_VersaoDoPrograma_Click(object sender, EventArgs e) {

            string texto1 = "Versão do programa".Tradusir();
            string texto2 = "Para mais informaçoes acesse o git do desenvolvedor em 'Ajuda/Desenvolvedor'".Tradusir();

            MessageBox.Show($"{texto1}: 0.1 (BETA)\n{texto2}");
        }

        // Disparo de eventos ao selecionar items do menu
        #region Atualizar cores da fonte do menu ao selecionar
        // Meu Programa
        private void menuPaiPrograma_DropDownOpened(object sender, EventArgs e) {
            if (STATUS_GERAL.TemaAtual != STATUS_GERAL.Tema.Branco) {
                menuPaiPrograma.ForeColor = STATUS_GERAL.TemaAtual.Reversa;
            }
        }
        private void menuPaiPrograma_DropDownClosed(object sender, EventArgs e) {
            if (STATUS_GERAL.TemaAtual != STATUS_GERAL.Tema.Branco) {
                menuPaiPrograma.ForeColor = STATUS_GERAL.TemaAtual.Fonte;
            }
        }
        // Menu Prederencias
        private void menuPaiPreferencias_DropDownOpened(object sender, EventArgs e) {
            if (STATUS_GERAL.TemaAtual != STATUS_GERAL.Tema.Branco) {
                menuPaiPreferencias.ForeColor = STATUS_GERAL.TemaAtual.Reversa;
            }
        }
        private void menuPaiPreferencias_DropDownClosed(object sender, EventArgs e) {
            if (STATUS_GERAL.TemaAtual != STATUS_GERAL.Tema.Branco) {
                menuPaiPreferencias.ForeColor = STATUS_GERAL.TemaAtual.Fonte;
            }
        }
        // Menu Sobre
        private void menuPaiSobre_DropDownOpened(object sender, EventArgs e) {
            if (STATUS_GERAL.TemaAtual != STATUS_GERAL.Tema.Branco) {
                menuPaiSobre.ForeColor = STATUS_GERAL.TemaAtual.Reversa;
            }
        }
        private void menuPaiSobre_DropDownClosed(object sender, EventArgs e) {
            if (STATUS_GERAL.TemaAtual != STATUS_GERAL.Tema.Branco) {
                menuPaiSobre.ForeColor = STATUS_GERAL.TemaAtual.Fonte;
            }
        }
        #endregion

        // Metodo atualizar tema
        private void atualizarTema() {

            BackColor = STATUS_GERAL.TemaAtual.Fundo;
            ForeColor = STATUS_GERAL.TemaAtual.Fonte;
            btnCopiar.BackColor = STATUS_GERAL.TemaAtual.Fundo;

            tbTextoUsuario.BackColor = STATUS_GERAL.TemaAtual.Interior;
            tbTextoUsuario.ForeColor = STATUS_GERAL.TemaAtual.Fonte;

            tbResultado.BackColor = STATUS_GERAL.TemaAtual.Interior;
            tbResultado.ForeColor = STATUS_GERAL.TemaAtual.Fonte;

            lbFontes.BackColor = STATUS_GERAL.TemaAtual.Interior;
            lbFontes.ForeColor = STATUS_GERAL.TemaAtual.Fonte;

            lbMolduras.BackColor = STATUS_GERAL.TemaAtual.Interior;
            lbMolduras.ForeColor = STATUS_GERAL.TemaAtual.Fonte;

            // MENU
            menuStrip1.BackColor = STATUS_GERAL.TemaAtual.Interior;
            menuStrip1.ForeColor = STATUS_GERAL.TemaAtual.Fonte;

            foreach (ToolStripMenuItem menuPai in menuStrip1.Items) {
                menuPai.BackColor = STATUS_GERAL.TemaAtual.Interior;
                menuPai.ForeColor = STATUS_GERAL.TemaAtual.Fonte;
            }

            // MENU/Programa
            foreach (Object menuItem in menuPaiPrograma.DropDownItems) {

                if (menuItem.GetType() == typeof(ToolStripMenuItem)) {

                    ToolStripMenuItem m = (ToolStripMenuItem)menuItem;

                    m.BackColor = STATUS_GERAL.TemaAtual.Interior;
                    m.ForeColor = STATUS_GERAL.TemaAtual.Fonte;
                }

            }

            // MENU/Preferencias
            foreach (ToolStripMenuItem menuItem in menuPaiPreferencias.DropDownItems) {
                menuItem.BackColor = STATUS_GERAL.TemaAtual.Interior;
                menuItem.ForeColor = STATUS_GERAL.TemaAtual.Fonte;
            }

            foreach (ToolStripMenuItem menuItem in menuPaiPreferencias_Tema.DropDownItems) {
                menuItem.BackColor = STATUS_GERAL.TemaAtual.Interior;
                menuItem.ForeColor = STATUS_GERAL.TemaAtual.Fonte;
            }
            foreach (ToolStripMenuItem menuItem in menuPaiPreferencias_Idioma.DropDownItems) {
                menuItem.BackColor = STATUS_GERAL.TemaAtual.Interior;
                menuItem.ForeColor = STATUS_GERAL.TemaAtual.Fonte;
            }

            // MENU/Sobre
            foreach (ToolStripMenuItem menuItem in menuPaiSobre.DropDownItems) {
                menuItem.BackColor = STATUS_GERAL.TemaAtual.Interior;
                menuItem.ForeColor = STATUS_GERAL.TemaAtual.Fonte;
            }

        }


        // ListBox
        #region ListBox

        // Atualizar fonte atual ao selecionar
        private void lbFontes_SelectedIndexChanged(object sender, EventArgs e) {
            // MessageBox.Show($"Item selecionado: {lbFontes.SelectedIndex}");

            switch (lbFontes.SelectedIndex) {
                case 0:
                    tbResultado.Clear();
                    tbResultado.Text = ConvertFonte.Fonte1(tbTextoUsuario.Text);
                    break;
                case 1:
                    tbResultado.Clear();
                    tbResultado.Text = ConvertFonte.Fonte2(tbTextoUsuario.Text);
                    break;
                case 2:
                    tbResultado.Clear();
                    tbResultado.Text = ConvertFonte.Fonte3(tbTextoUsuario.Text);
                    break;
                case 3:
                    tbResultado.Clear();
                    tbResultado.Text = ConvertFonte.Fonte4(tbTextoUsuario.Text);
                    break;
                case 4:
                    tbResultado.Clear();
                    tbResultado.Text = ConvertFonte.Fonte5(tbTextoUsuario.Text);
                    break;
                case 5:
                    tbResultado.Clear();
                    tbResultado.Text = ConvertFonte.Fonte6(tbTextoUsuario.Text);
                    break;
                case 6:
                    tbResultado.Clear();
                    tbResultado.Text = ConvertFonte.Fonte7(tbTextoUsuario.Text);
                    break;
                case 7:
                    tbResultado.Clear();
                    tbResultado.Text = ConvertFonte.Fonte8(tbTextoUsuario.Text);
                    break;
                case 8:
                    tbResultado.Clear();
                    tbResultado.Text = ConvertFonte.Fonte9(tbTextoUsuario.Text);
                    break;
                case 9:
                    tbResultado.Clear();
                    tbResultado.Text = ConvertFonte.Fonte10(tbTextoUsuario.Text);
                    break;
            }

            
        }

        // exibe todas as fontes na ListBox
        void AtualizarListaDeFontes() {
            lbFontes.Items.Clear();
            lbFontes.Items.Add(ConvertFonte.Fonte1("O TEXTO FICA ASSIM".Tradusir(), true));
            lbFontes.Items.Add(ConvertFonte.Fonte2("O TEXTO FICA ASSIM".Tradusir(), true));
            lbFontes.Items.Add(ConvertFonte.Fonte3("O TEXTO FICA ASSIM".Tradusir(), true));
            lbFontes.Items.Add(ConvertFonte.Fonte4("O TEXTO FICA ASSIM".Tradusir(), true));
            lbFontes.Items.Add(ConvertFonte.Fonte5("O TEXTO FICA ASSIM".Tradusir(), true));
            lbFontes.Items.Add(ConvertFonte.Fonte6("O TEXTO FICA ASSIM".Tradusir(), true));
            lbFontes.Items.Add(ConvertFonte.Fonte7("O TEXTO FICA ASSIM".Tradusir(), true));
            lbFontes.Items.Add(ConvertFonte.Fonte8("O TEXTO FICA ASSIM".Tradusir(), true));
            lbFontes.Items.Add(ConvertFonte.Fonte9("O TEXTO FICA ASSIM".Tradusir(), true));
            lbFontes.Items.Add(ConvertFonte.Fonte10("O TEXTO FICA ASSIM".Tradusir(), true));
            lbFontes.SelectedIndex = 0;
        }

        // ativar ou desativar moldura
        private void cbMoldura_CheckedChanged(object sender, EventArgs e) {
            if (cbMoldura.Checked == true) {
                STATUS_GERAL.aplicarMoldura = true;
                lbMolduras.Enabled = true;
                lbMolduras.SelectedIndex = 0;
            }
            else {
                STATUS_GERAL.aplicarMoldura = false;
                lbMolduras.Enabled = false;
                lbMolduras.SelectedIndex = -1;

                int cache = lbFontes.SelectedIndex;
                lbFontes.SelectedIndex = -1;
                lbFontes.SelectedIndex = cache;
            }
        }

        // exibe as molduras na ListBox
        void atualizarListaDeMoldura() {
            lbMolduras.Items.Clear();
            lbMolduras.Items.Add("꧁ঔৣ☬✞ ✞☬ঔৣ꧂");
            lbMolduras.Items.Add("꧁༺ ༻꧂");
            lbMolduras.Items.Add("✞ঔৣ۝ ۝ঔৣ✞");
            lbMolduras.Items.Add("◥༒۝ ۝༒◤");
            lbMolduras.Items.Add("✼  ҉　 ҉　 ҉　  ҉　 ҉　 ҉　✼");
            lbMolduras.Items.Add("♥♡♥♡ ♡♥♡♥");
        }

        // Atualiza a moldura atual ao selecionar 
        private void lbMolduras_SelectedIndexChanged(object sender, EventArgs e) {
            int cache = lbFontes.SelectedIndex;
            switch (lbMolduras.SelectedIndex) {
                case 0:
                    STATUS_GERAL.molduraAtual[0] = "꧁ঔৣ☬✞";
                    STATUS_GERAL.molduraAtual[1] = "✞☬ঔৣ꧂";

                    lbFontes.SelectedIndex = -1;
                    lbFontes.SelectedIndex = cache;

                    break;
                case 1:
                    STATUS_GERAL.molduraAtual[0] = "꧁༺";
                    STATUS_GERAL.molduraAtual[1] = "༻꧂";

                    lbFontes.SelectedIndex = -1;
                    lbFontes.SelectedIndex = cache;

                    break;
                case 2:
                    STATUS_GERAL.molduraAtual[0] = "✞ঔৣ۝";
                    STATUS_GERAL.molduraAtual[1] = " ۝ঔৣ✞";

                    lbFontes.SelectedIndex = -1;
                    lbFontes.SelectedIndex = cache;

                    break;
                case 3:
                    STATUS_GERAL.molduraAtual[0] = "◥༒۝";
                    STATUS_GERAL.molduraAtual[1] = "۝༒◤";

                    lbFontes.SelectedIndex = -1;
                    lbFontes.SelectedIndex = cache;

                    break;
                case 4:
                    STATUS_GERAL.molduraAtual[0] = "✼  ҉　 ҉　 ҉";
                    STATUS_GERAL.molduraAtual[1] = " ҉　 ҉　 ҉　✼";

                    lbFontes.SelectedIndex = -1;
                    lbFontes.SelectedIndex = cache;

                    break;
                case 5:
                    STATUS_GERAL.molduraAtual[0] = "♥♡♥♡";
                    STATUS_GERAL.molduraAtual[1] = "♡♥♡♥";

                    lbFontes.SelectedIndex = -1;
                    lbFontes.SelectedIndex = cache;

                    break;
            }
        }


        // exibe todas as fontes na ListBox
        #endregion

        // evento atualizar caracteres
        private void tbTextoUsuario_TextChanged(object sender, EventArgs e) {
            int cache = lbFontes.SelectedIndex;
            lbFontes.SelectedIndex = -1;
            lbFontes.SelectedIndex = cache;
        }
    }
}

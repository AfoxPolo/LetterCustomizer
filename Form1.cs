using System;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace ConversorDeCaracteres {
    public partial class FormMain : Form {


        public FormMain() {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e) {
            definirIdioma();
            atualizarTema();
        }


        // Botão iniciar
        private void btnIniciar_Click(object sender, EventArgs e) {

            //Close();
            //new Thread(() => Application.Run(new FormConverte())).Start();

            // este botão não esta ativo pois foi subistituido pela picture box

        }

        // Botão Sair
        private void btnSair_Click(object sender, EventArgs e) {
            Close();
        }

        // Metodo Atualizar idioma da form atual
        public void definirIdioma() {

            btnIniciar.Text = "Iniciar".Tradusir();
            btnSair.Text = "Sair".Tradusir();
            
        }

        // Metodo Atualizar tema da form atual
        public void atualizarTema() {
            BackColor = STATUS_GERAL.TemaAtual.Fundo;
            ForeColor = STATUS_GERAL.TemaAtual.Fonte;

            btnIniciar.BackColor = STATUS_GERAL.TemaAtual.Interior;
            btnIniciar.ForeColor = STATUS_GERAL.TemaAtual.Fonte;

            btnSair.BackColor = STATUS_GERAL.TemaAtual.Interior;
            btnSair.ForeColor = STATUS_GERAL.TemaAtual.Fonte;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e) {
            PB_logo.BackgroundImage = Properties.Resources.logo_press;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e) {
            PB_logo.BackgroundImage = Properties.Resources.logo;
        }

        // Botão iniciar
        private void PB_logo_Click(object sender, EventArgs e) {

            Close();
            new Thread(() => Application.Run(new FormConverte())).Start();

        }
    }
}

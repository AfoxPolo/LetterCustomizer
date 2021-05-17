namespace ConversorDeCaracteres {
    partial class FormConverte {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPaiPrograma = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaiPrograma_LocalDeArquivos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuPaiPrograma_ReiniciarPrograma = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaiPrograma_Sair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaiPreferencias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaiPreferencias_Tema = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaiPreferencias_Tema_Branco = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaiPreferencias_Tema_Escuro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaiPreferencias_Idioma = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaiPreferencias_Idioma_Portugues = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaiPreferencias_Idioma_Ingles = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaiPreferencias_Idioma_Espanhol = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaiSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaiSobre_Desenvolvedor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaiSobre_VersaoDoPrograma = new System.Windows.Forms.ToolStripMenuItem();
            this.tbTextoUsuario = new System.Windows.Forms.TextBox();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.lbFontes = new System.Windows.Forms.ListBox();
            this.lblEscrevaSeuNomeAqui = new System.Windows.Forms.Label();
            this.lblEscolhaUmaFonte = new System.Windows.Forms.Label();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.lbMolduras = new System.Windows.Forms.ListBox();
            this.cbMoldura = new System.Windows.Forms.CheckBox();
            this.fbd1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPaiPrograma,
            this.menuPaiPreferencias,
            this.menuPaiSobre});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(779, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPaiPrograma
            // 
            this.menuPaiPrograma.BackColor = System.Drawing.SystemColors.Control;
            this.menuPaiPrograma.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPaiPrograma_LocalDeArquivos,
            this.toolStripSeparator1,
            this.menuPaiPrograma_ReiniciarPrograma,
            this.menuPaiPrograma_Sair});
            this.menuPaiPrograma.Name = "menuPaiPrograma";
            this.menuPaiPrograma.Size = new System.Drawing.Size(71, 20);
            this.menuPaiPrograma.Text = "Programa";
            this.menuPaiPrograma.DropDownClosed += new System.EventHandler(this.menuPaiPrograma_DropDownClosed);
            this.menuPaiPrograma.DropDownOpened += new System.EventHandler(this.menuPaiPrograma_DropDownOpened);
            // 
            // menuPaiPrograma_LocalDeArquivos
            // 
            this.menuPaiPrograma_LocalDeArquivos.Name = "menuPaiPrograma_LocalDeArquivos";
            this.menuPaiPrograma_LocalDeArquivos.Size = new System.Drawing.Size(180, 22);
            this.menuPaiPrograma_LocalDeArquivos.Text = "Local de arquivos";
            this.menuPaiPrograma_LocalDeArquivos.Click += new System.EventHandler(this.menuPaiPrograma_LocalDeArquivos_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuPaiPrograma_ReiniciarPrograma
            // 
            this.menuPaiPrograma_ReiniciarPrograma.Name = "menuPaiPrograma_ReiniciarPrograma";
            this.menuPaiPrograma_ReiniciarPrograma.Size = new System.Drawing.Size(180, 22);
            this.menuPaiPrograma_ReiniciarPrograma.Text = "Reiniciar programa";
            this.menuPaiPrograma_ReiniciarPrograma.Click += new System.EventHandler(this.menuPaiPrograma_ReiniciarPrograma_Click);
            // 
            // menuPaiPrograma_Sair
            // 
            this.menuPaiPrograma_Sair.Name = "menuPaiPrograma_Sair";
            this.menuPaiPrograma_Sair.Size = new System.Drawing.Size(180, 22);
            this.menuPaiPrograma_Sair.Text = "Sair";
            this.menuPaiPrograma_Sair.Click += new System.EventHandler(this.menuPaiPrograma_Sair_Click);
            // 
            // menuPaiPreferencias
            // 
            this.menuPaiPreferencias.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPaiPreferencias_Tema,
            this.menuPaiPreferencias_Idioma});
            this.menuPaiPreferencias.Name = "menuPaiPreferencias";
            this.menuPaiPreferencias.Size = new System.Drawing.Size(83, 20);
            this.menuPaiPreferencias.Text = "Preferencias";
            this.menuPaiPreferencias.DropDownClosed += new System.EventHandler(this.menuPaiPreferencias_DropDownClosed);
            this.menuPaiPreferencias.DropDownOpened += new System.EventHandler(this.menuPaiPreferencias_DropDownOpened);
            // 
            // menuPaiPreferencias_Tema
            // 
            this.menuPaiPreferencias_Tema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPaiPreferencias_Tema_Branco,
            this.menuPaiPreferencias_Tema_Escuro});
            this.menuPaiPreferencias_Tema.Name = "menuPaiPreferencias_Tema";
            this.menuPaiPreferencias_Tema.Size = new System.Drawing.Size(111, 22);
            this.menuPaiPreferencias_Tema.Text = "Tema";
            // 
            // menuPaiPreferencias_Tema_Branco
            // 
            this.menuPaiPreferencias_Tema_Branco.Name = "menuPaiPreferencias_Tema_Branco";
            this.menuPaiPreferencias_Tema_Branco.Size = new System.Drawing.Size(127, 22);
            this.menuPaiPreferencias_Tema_Branco.Text = "Branco";
            this.menuPaiPreferencias_Tema_Branco.Click += new System.EventHandler(this.menuPaiPreferencias_Tema_Branco_Click);
            // 
            // menuPaiPreferencias_Tema_Escuro
            // 
            this.menuPaiPreferencias_Tema_Escuro.Name = "menuPaiPreferencias_Tema_Escuro";
            this.menuPaiPreferencias_Tema_Escuro.Size = new System.Drawing.Size(127, 22);
            this.menuPaiPreferencias_Tema_Escuro.Text = "Azul Forte";
            this.menuPaiPreferencias_Tema_Escuro.Click += new System.EventHandler(this.menuPaiPreferencias_Tema_AzulForte_Click);
            // 
            // menuPaiPreferencias_Idioma
            // 
            this.menuPaiPreferencias_Idioma.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPaiPreferencias_Idioma_Portugues,
            this.menuPaiPreferencias_Idioma_Ingles,
            this.menuPaiPreferencias_Idioma_Espanhol});
            this.menuPaiPreferencias_Idioma.Name = "menuPaiPreferencias_Idioma";
            this.menuPaiPreferencias_Idioma.Size = new System.Drawing.Size(111, 22);
            this.menuPaiPreferencias_Idioma.Text = "Idioma";
            // 
            // menuPaiPreferencias_Idioma_Portugues
            // 
            this.menuPaiPreferencias_Idioma_Portugues.Name = "menuPaiPreferencias_Idioma_Portugues";
            this.menuPaiPreferencias_Idioma_Portugues.Size = new System.Drawing.Size(128, 22);
            this.menuPaiPreferencias_Idioma_Portugues.Text = "Portugues";
            this.menuPaiPreferencias_Idioma_Portugues.Click += new System.EventHandler(this.menuPaiPreferencias_Idioma_Portugues_Click);
            // 
            // menuPaiPreferencias_Idioma_Ingles
            // 
            this.menuPaiPreferencias_Idioma_Ingles.Name = "menuPaiPreferencias_Idioma_Ingles";
            this.menuPaiPreferencias_Idioma_Ingles.Size = new System.Drawing.Size(128, 22);
            this.menuPaiPreferencias_Idioma_Ingles.Text = "Ingles";
            this.menuPaiPreferencias_Idioma_Ingles.Click += new System.EventHandler(this.menuPaiPreferencias_Idioma_Ingles_Click);
            // 
            // menuPaiPreferencias_Idioma_Espanhol
            // 
            this.menuPaiPreferencias_Idioma_Espanhol.Name = "menuPaiPreferencias_Idioma_Espanhol";
            this.menuPaiPreferencias_Idioma_Espanhol.Size = new System.Drawing.Size(128, 22);
            this.menuPaiPreferencias_Idioma_Espanhol.Text = "Espanhol";
            this.menuPaiPreferencias_Idioma_Espanhol.Click += new System.EventHandler(this.menuPaiPreferencias_Idioma_Espanhol_Click);
            // 
            // menuPaiSobre
            // 
            this.menuPaiSobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPaiSobre_Desenvolvedor,
            this.menuPaiSobre_VersaoDoPrograma});
            this.menuPaiSobre.Name = "menuPaiSobre";
            this.menuPaiSobre.Size = new System.Drawing.Size(49, 20);
            this.menuPaiSobre.Text = "Sobre";
            this.menuPaiSobre.DropDownClosed += new System.EventHandler(this.menuPaiSobre_DropDownClosed);
            this.menuPaiSobre.DropDownOpened += new System.EventHandler(this.menuPaiSobre_DropDownOpened);
            // 
            // menuPaiSobre_Desenvolvedor
            // 
            this.menuPaiSobre_Desenvolvedor.Name = "menuPaiSobre_Desenvolvedor";
            this.menuPaiSobre_Desenvolvedor.Size = new System.Drawing.Size(180, 22);
            this.menuPaiSobre_Desenvolvedor.Text = "Desenvolvedor";
            this.menuPaiSobre_Desenvolvedor.Click += new System.EventHandler(this.menuPaiSobre_Desenvolvedor_Click);
            // 
            // menuPaiSobre_VersaoDoPrograma
            // 
            this.menuPaiSobre_VersaoDoPrograma.Name = "menuPaiSobre_VersaoDoPrograma";
            this.menuPaiSobre_VersaoDoPrograma.Size = new System.Drawing.Size(180, 22);
            this.menuPaiSobre_VersaoDoPrograma.Text = "Versão do programa";
            this.menuPaiSobre_VersaoDoPrograma.Click += new System.EventHandler(this.menuPaiSobre_VersaoDoPrograma_Click);
            // 
            // tbTextoUsuario
            // 
            this.tbTextoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTextoUsuario.Location = new System.Drawing.Point(12, 79);
            this.tbTextoUsuario.Multiline = true;
            this.tbTextoUsuario.Name = "tbTextoUsuario";
            this.tbTextoUsuario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTextoUsuario.Size = new System.Drawing.Size(359, 109);
            this.tbTextoUsuario.TabIndex = 1;
            this.tbTextoUsuario.TextChanged += new System.EventHandler(this.tbTextoUsuario_TextChanged);
            // 
            // tbResultado
            // 
            this.tbResultado.AcceptsReturn = true;
            this.tbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResultado.Location = new System.Drawing.Point(12, 190);
            this.tbResultado.Multiline = true;
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.ReadOnly = true;
            this.tbResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResultado.Size = new System.Drawing.Size(359, 109);
            this.tbResultado.TabIndex = 2;
            // 
            // lbFontes
            // 
            this.lbFontes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFontes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFontes.FormattingEnabled = true;
            this.lbFontes.HorizontalScrollbar = true;
            this.lbFontes.ItemHeight = 18;
            this.lbFontes.Location = new System.Drawing.Point(377, 79);
            this.lbFontes.Name = "lbFontes";
            this.lbFontes.ScrollAlwaysVisible = true;
            this.lbFontes.Size = new System.Drawing.Size(191, 254);
            this.lbFontes.TabIndex = 3;
            this.lbFontes.SelectedIndexChanged += new System.EventHandler(this.lbFontes_SelectedIndexChanged);
            // 
            // lblEscrevaSeuNomeAqui
            // 
            this.lblEscrevaSeuNomeAqui.AutoSize = true;
            this.lblEscrevaSeuNomeAqui.Location = new System.Drawing.Point(9, 63);
            this.lblEscrevaSeuNomeAqui.Name = "lblEscrevaSeuNomeAqui";
            this.lblEscrevaSeuNomeAqui.Size = new System.Drawing.Size(115, 13);
            this.lblEscrevaSeuNomeAqui.TabIndex = 4;
            this.lblEscrevaSeuNomeAqui.Text = "Escreva seu texto aqui";
            // 
            // lblEscolhaUmaFonte
            // 
            this.lblEscolhaUmaFonte.AutoSize = true;
            this.lblEscolhaUmaFonte.Location = new System.Drawing.Point(374, 63);
            this.lblEscolhaUmaFonte.Name = "lblEscolhaUmaFonte";
            this.lblEscolhaUmaFonte.Size = new System.Drawing.Size(95, 13);
            this.lblEscolhaUmaFonte.TabIndex = 5;
            this.lblEscolhaUmaFonte.Text = "Escolha uma fonte";
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(12, 306);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(359, 29);
            this.btnCopiar.TabIndex = 6;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // lbMolduras
            // 
            this.lbMolduras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMolduras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMolduras.FormattingEnabled = true;
            this.lbMolduras.HorizontalScrollbar = true;
            this.lbMolduras.ItemHeight = 18;
            this.lbMolduras.Location = new System.Drawing.Point(574, 79);
            this.lbMolduras.Name = "lbMolduras";
            this.lbMolduras.ScrollAlwaysVisible = true;
            this.lbMolduras.Size = new System.Drawing.Size(191, 254);
            this.lbMolduras.TabIndex = 7;
            this.lbMolduras.SelectedIndexChanged += new System.EventHandler(this.lbMolduras_SelectedIndexChanged);
            // 
            // cbMoldura
            // 
            this.cbMoldura.AutoSize = true;
            this.cbMoldura.Location = new System.Drawing.Point(574, 62);
            this.cbMoldura.Name = "cbMoldura";
            this.cbMoldura.Size = new System.Drawing.Size(93, 17);
            this.cbMoldura.TabIndex = 9;
            this.cbMoldura.Text = "Usar molduras";
            this.cbMoldura.UseVisualStyleBackColor = true;
            this.cbMoldura.CheckedChanged += new System.EventHandler(this.cbMoldura_CheckedChanged);
            // 
            // FormConverte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 351);
            this.Controls.Add(this.cbMoldura);
            this.Controls.Add(this.lbMolduras);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.lblEscolhaUmaFonte);
            this.Controls.Add(this.lblEscrevaSeuNomeAqui);
            this.Controls.Add(this.lbFontes);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.tbTextoUsuario);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormConverte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConverte";
            this.Load += new System.EventHandler(this.FormConverte_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPaiPrograma;
        private System.Windows.Forms.ToolStripMenuItem menuPaiSobre;
        private System.Windows.Forms.ToolStripMenuItem menuPaiPrograma_LocalDeArquivos;
        private System.Windows.Forms.ToolStripMenuItem menuPaiPrograma_Sair;
        private System.Windows.Forms.ToolStripMenuItem menuPaiPreferencias;
        private System.Windows.Forms.ToolStripMenuItem menuPaiPreferencias_Tema;
        private System.Windows.Forms.ToolStripMenuItem menuPaiPreferencias_Tema_Branco;
        private System.Windows.Forms.ToolStripMenuItem menuPaiPreferencias_Tema_Escuro;
        private System.Windows.Forms.ToolStripMenuItem menuPaiPreferencias_Idioma;
        private System.Windows.Forms.ToolStripMenuItem menuPaiPreferencias_Idioma_Portugues;
        private System.Windows.Forms.ToolStripMenuItem menuPaiPreferencias_Idioma_Ingles;
        private System.Windows.Forms.ToolStripMenuItem menuPaiPreferencias_Idioma_Espanhol;
        private System.Windows.Forms.ToolStripMenuItem menuPaiSobre_Desenvolvedor;
        private System.Windows.Forms.TextBox tbTextoUsuario;
        private System.Windows.Forms.TextBox tbResultado;
        private System.Windows.Forms.ListBox lbFontes;
        private System.Windows.Forms.Label lblEscrevaSeuNomeAqui;
        private System.Windows.Forms.Label lblEscolhaUmaFonte;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.ToolStripMenuItem menuPaiPrograma_ReiniciarPrograma;
        private System.Windows.Forms.ToolStripMenuItem menuPaiSobre_VersaoDoPrograma;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ListBox lbMolduras;
        private System.Windows.Forms.CheckBox cbMoldura;
        private System.Windows.Forms.FolderBrowserDialog fbd1;
    }
}
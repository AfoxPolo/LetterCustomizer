namespace ConversorDeCaracteres {
    partial class FormMain {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.PB_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            resources.ApplyResources(this.btnSair, "btnSair");
            this.btnSair.Name = "btnSair";
            this.btnSair.TabStop = false;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnIniciar
            // 
            resources.ApplyResources(this.btnIniciar, "btnIniciar");
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // PB_logo
            // 
            this.PB_logo.BackgroundImage = global::ConversorDeCaracteres.Properties.Resources.logo;
            resources.ApplyResources(this.PB_logo, "PB_logo");
            this.PB_logo.Name = "PB_logo";
            this.PB_logo.TabStop = false;
            this.PB_logo.Click += new System.EventHandler(this.PB_logo_Click);
            this.PB_logo.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.PB_logo.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PB_logo);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.PictureBox PB_logo;
    }
}


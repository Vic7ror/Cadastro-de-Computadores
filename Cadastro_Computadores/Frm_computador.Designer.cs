namespace Cadastro_Computadores
{
    partial class frm_computador
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.bl_professor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbx_status = new System.Windows.Forms.ComboBox();
            this.txt_ano = new System.Windows.Forms.MaskedTextBox();
            this.lbl_tipoDeDefeito = new System.Windows.Forms.Label();
            this.txt_tipoDeDefeito = new System.Windows.Forms.TextBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_ano = new System.Windows.Forms.Label();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.txt_discoRigido = new System.Windows.Forms.TextBox();
            this.txt_memoria = new System.Windows.Forms.TextBox();
            this.txt_placaMae = new System.Windows.Forms.TextBox();
            this.lbl_discoRigido = new System.Windows.Forms.Label();
            this.lbl_memoria = new System.Windows.Forms.Label();
            this.lbl_placaMae = new System.Windows.Forms.Label();
            this.txt_processador = new System.Windows.Forms.TextBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.dtg_computadores = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_computadores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Computadores";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(3, 32);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(239, 26);
            this.txt_nome.TabIndex = 1;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(3, 11);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(54, 18);
            this.lbl_nome.TabIndex = 2;
            this.lbl_nome.Text = "Nome:";
            // 
            // bl_professor
            // 
            this.bl_professor.AutoSize = true;
            this.bl_professor.Location = new System.Drawing.Point(3, 65);
            this.bl_professor.Name = "bl_professor";
            this.bl_professor.Size = new System.Drawing.Size(102, 18);
            this.bl_professor.TabIndex = 3;
            this.bl_professor.Text = "Processador:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cbx_status);
            this.panel1.Controls.Add(this.txt_ano);
            this.panel1.Controls.Add(this.lbl_tipoDeDefeito);
            this.panel1.Controls.Add(this.txt_tipoDeDefeito);
            this.panel1.Controls.Add(this.lbl_status);
            this.panel1.Controls.Add(this.lbl_ano);
            this.panel1.Controls.Add(this.lbl_marca);
            this.panel1.Controls.Add(this.txt_marca);
            this.panel1.Controls.Add(this.txt_discoRigido);
            this.panel1.Controls.Add(this.txt_memoria);
            this.panel1.Controls.Add(this.txt_placaMae);
            this.panel1.Controls.Add(this.lbl_discoRigido);
            this.panel1.Controls.Add(this.lbl_memoria);
            this.panel1.Controls.Add(this.lbl_placaMae);
            this.panel1.Controls.Add(this.txt_processador);
            this.panel1.Controls.Add(this.lbl_nome);
            this.panel1.Controls.Add(this.bl_professor);
            this.panel1.Controls.Add(this.txt_nome);
            this.panel1.Location = new System.Drawing.Point(18, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 299);
            this.panel1.TabIndex = 4;
            // 
            // cbx_status
            // 
            this.cbx_status.FormattingEnabled = true;
            this.cbx_status.Items.AddRange(new object[] {
            "",
            "Funcionando",
            "Com Defeito"});
            this.cbx_status.Location = new System.Drawing.Point(272, 138);
            this.cbx_status.Name = "cbx_status";
            this.cbx_status.Size = new System.Drawing.Size(236, 26);
            this.cbx_status.TabIndex = 20;
            // 
            // txt_ano
            // 
            this.txt_ano.Location = new System.Drawing.Point(269, 89);
            this.txt_ano.Mask = "0000";
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(239, 26);
            this.txt_ano.TabIndex = 19;
            this.txt_ano.ValidatingType = typeof(int);
            // 
            // lbl_tipoDeDefeito
            // 
            this.lbl_tipoDeDefeito.AutoSize = true;
            this.lbl_tipoDeDefeito.Location = new System.Drawing.Point(269, 170);
            this.lbl_tipoDeDefeito.Name = "lbl_tipoDeDefeito";
            this.lbl_tipoDeDefeito.Size = new System.Drawing.Size(119, 18);
            this.lbl_tipoDeDefeito.TabIndex = 18;
            this.lbl_tipoDeDefeito.Text = "Tipo de Defeito:";
            // 
            // txt_tipoDeDefeito
            // 
            this.txt_tipoDeDefeito.Location = new System.Drawing.Point(269, 191);
            this.txt_tipoDeDefeito.Name = "txt_tipoDeDefeito";
            this.txt_tipoDeDefeito.Size = new System.Drawing.Size(239, 26);
            this.txt_tipoDeDefeito.TabIndex = 17;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(269, 118);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(56, 18);
            this.lbl_status.TabIndex = 16;
            this.lbl_status.Text = "Status:";
            // 
            // lbl_ano
            // 
            this.lbl_ano.AutoSize = true;
            this.lbl_ano.Location = new System.Drawing.Point(269, 65);
            this.lbl_ano.Name = "lbl_ano";
            this.lbl_ano.Size = new System.Drawing.Size(40, 18);
            this.lbl_ano.TabIndex = 14;
            this.lbl_ano.Text = "Ano:";
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Location = new System.Drawing.Point(269, 11);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(56, 18);
            this.lbl_marca.TabIndex = 12;
            this.lbl_marca.Text = "Marca:";
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(269, 32);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(239, 26);
            this.txt_marca.TabIndex = 11;
            // 
            // txt_discoRigido
            // 
            this.txt_discoRigido.Location = new System.Drawing.Point(3, 244);
            this.txt_discoRigido.Name = "txt_discoRigido";
            this.txt_discoRigido.Size = new System.Drawing.Size(239, 26);
            this.txt_discoRigido.TabIndex = 10;
            // 
            // txt_memoria
            // 
            this.txt_memoria.Location = new System.Drawing.Point(3, 191);
            this.txt_memoria.Name = "txt_memoria";
            this.txt_memoria.Size = new System.Drawing.Size(239, 26);
            this.txt_memoria.TabIndex = 9;
            // 
            // txt_placaMae
            // 
            this.txt_placaMae.Location = new System.Drawing.Point(3, 138);
            this.txt_placaMae.Name = "txt_placaMae";
            this.txt_placaMae.Size = new System.Drawing.Size(239, 26);
            this.txt_placaMae.TabIndex = 8;
            // 
            // lbl_discoRigido
            // 
            this.lbl_discoRigido.AutoSize = true;
            this.lbl_discoRigido.Location = new System.Drawing.Point(3, 223);
            this.lbl_discoRigido.Name = "lbl_discoRigido";
            this.lbl_discoRigido.Size = new System.Drawing.Size(135, 18);
            this.lbl_discoRigido.TabIndex = 7;
            this.lbl_discoRigido.Text = "Disco Rígido(HD):";
            // 
            // lbl_memoria
            // 
            this.lbl_memoria.AutoSize = true;
            this.lbl_memoria.Location = new System.Drawing.Point(3, 170);
            this.lbl_memoria.Name = "lbl_memoria";
            this.lbl_memoria.Size = new System.Drawing.Size(74, 18);
            this.lbl_memoria.TabIndex = 6;
            this.lbl_memoria.Text = "Memória:";
            // 
            // lbl_placaMae
            // 
            this.lbl_placaMae.AutoSize = true;
            this.lbl_placaMae.Location = new System.Drawing.Point(3, 119);
            this.lbl_placaMae.Name = "lbl_placaMae";
            this.lbl_placaMae.Size = new System.Drawing.Size(87, 18);
            this.lbl_placaMae.TabIndex = 5;
            this.lbl_placaMae.Text = "Placa Mãe:";
            // 
            // txt_processador
            // 
            this.txt_processador.Location = new System.Drawing.Point(3, 85);
            this.txt_processador.Name = "txt_processador";
            this.txt_processador.Size = new System.Drawing.Size(239, 26);
            this.txt_processador.TabIndex = 4;
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Location = new System.Drawing.Point(26, 349);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(236, 36);
            this.btn_salvar.TabIndex = 19;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.IndianRed;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.ForeColor = System.Drawing.Color.White;
            this.btn_limpar.Location = new System.Drawing.Point(289, 349);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(239, 36);
            this.btn_limpar.TabIndex = 20;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // dtg_computadores
            // 
            this.dtg_computadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_computadores.Location = new System.Drawing.Point(563, 44);
            this.dtg_computadores.Name = "dtg_computadores";
            this.dtg_computadores.Size = new System.Drawing.Size(279, 336);
            this.dtg_computadores.TabIndex = 21;
            // 
            // frm_computador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 392);
            this.Controls.Add(this.dtg_computadores);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_computador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de computador";
            this.Load += new System.EventHandler(this.frm_computador_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_computadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label bl_professor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.TextBox txt_discoRigido;
        private System.Windows.Forms.TextBox txt_memoria;
        private System.Windows.Forms.TextBox txt_placaMae;
        private System.Windows.Forms.Label lbl_discoRigido;
        private System.Windows.Forms.Label lbl_memoria;
        private System.Windows.Forms.Label lbl_placaMae;
        private System.Windows.Forms.TextBox txt_processador;
        private System.Windows.Forms.Label lbl_tipoDeDefeito;
        private System.Windows.Forms.TextBox txt_tipoDeDefeito;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_ano;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.MaskedTextBox txt_ano;
        private System.Windows.Forms.ComboBox cbx_status;
        private System.Windows.Forms.DataGridView dtg_computadores;
    }
}


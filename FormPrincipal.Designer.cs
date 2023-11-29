namespace AppEmpresa
{
    partial class FormPrincipal
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
            this.btnInserir = new System.Windows.Forms.Button();
            this.cbxTurno = new System.Windows.Forms.ComboBox();
            this.mskDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pbxAniversario = new System.Windows.Forms.PictureBox();
            this.btnLocalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAniversario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.Color.White;
            this.btnInserir.Location = new System.Drawing.Point(458, 20);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(174, 47);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "INSERIR";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // cbxTurno
            // 
            this.cbxTurno.FormattingEnabled = true;
            this.cbxTurno.Items.AddRange(new object[] {
            "DIA",
            "NOITE"});
            this.cbxTurno.Location = new System.Drawing.Point(32, 164);
            this.cbxTurno.Name = "cbxTurno";
            this.cbxTurno.Size = new System.Drawing.Size(121, 24);
            this.cbxTurno.TabIndex = 1;
            // 
            // mskDataNascimento
            // 
            this.mskDataNascimento.Location = new System.Drawing.Point(195, 164);
            this.mskDataNascimento.Mask = "00/00/0000";
            this.mskDataNascimento.Name = "mskDataNascimento";
            this.mskDataNascimento.Size = new System.Drawing.Size(175, 22);
            this.mskDataNascimento.TabIndex = 2;
            this.mskDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(32, 39);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 4;
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.AllowUserToAddRows = false;
            this.dgvFuncionario.AllowUserToDeleteRows = false;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Location = new System.Drawing.Point(32, 278);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.ReadOnly = true;
            this.dgvFuncionario.RowHeadersWidth = 51;
            this.dgvFuncionario.RowTemplate.Height = 24;
            this.dgvFuncionario.Size = new System.Drawing.Size(600, 150);
            this.dgvFuncionario.TabIndex = 5;
            this.dgvFuncionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellClick);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(32, 99);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(375, 22);
            this.txtNome.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "NOME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "TURNO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(191, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "DATA DE NASCIMENTO";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(32, 232);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(193, 22);
            this.txtMatricula.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "MATRÍCULA";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(458, 80);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(174, 47);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.OrangeRed;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(458, 139);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(174, 47);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(458, 197);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(174, 47);
            this.btnFechar.TabIndex = 14;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(264, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(320, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 18;
            // 
            // pbxAniversario
            // 
            this.pbxAniversario.Image = global::AppEmpresa.Properties.Resources.aniversario;
            this.pbxAniversario.Location = new System.Drawing.Point(268, 17);
            this.pbxAniversario.Name = "pbxAniversario";
            this.pbxAniversario.Size = new System.Drawing.Size(115, 75);
            this.pbxAniversario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAniversario.TabIndex = 17;
            this.pbxAniversario.TabStop = false;
            this.pbxAniversario.Click += new System.EventHandler(this.pbxAniversario_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.BackgroundImage = global::AppEmpresa.Properties.Resources.localizar;
            this.btnLocalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLocalizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLocalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLocalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizar.Location = new System.Drawing.Point(137, 22);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(87, 57);
            this.btnLocalizar.TabIndex = 15;
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbxAniversario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvFuncionario);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskDataNascimento);
            this.Controls.Add(this.cbxTurno);
            this.Controls.Add(this.btnInserir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE FUNCIONÁRIOS";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAniversario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.ComboBox cbxTurno;
        private System.Windows.Forms.MaskedTextBox mskDataNascimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbxAniversario;
        private System.Windows.Forms.Label label7;
    }
}


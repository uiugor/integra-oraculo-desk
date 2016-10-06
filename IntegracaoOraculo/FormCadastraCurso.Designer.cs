namespace IntegracaoOraculo
{
    partial class FormCadastraCurso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastraCurso));
            this.gbAlunosEx = new System.Windows.Forms.GroupBox();
            this.gbCursos = new System.Windows.Forms.GroupBox();
            this.dgvAlunosCurso = new System.Windows.Forms.DataGridView();
            this.cbCompras = new System.Windows.Forms.CheckBox();
            this.cbEstoque = new System.Windows.Forms.CheckBox();
            this.cbFaturamento = new System.Windows.Forms.CheckBox();
            this.cbFinanceiro = new System.Windows.Forms.CheckBox();
            this.cbGerencial = new System.Windows.Forms.CheckBox();
            this.cbOperacional = new System.Windows.Forms.CheckBox();
            this.cbRastreamento = new System.Windows.Forms.CheckBox();
            this.cbSuporte = new System.Windows.Forms.CheckBox();
            this.btInserir = new System.Windows.Forms.Button();
            this.dgvCusosAlunos = new System.Windows.Forms.DataGridView();
            this.cbCadastros = new System.Windows.Forms.CheckBox();
            this.gbAlunosEx.SuspendLayout();
            this.gbCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCusosAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAlunosEx
            // 
            this.gbAlunosEx.Controls.Add(this.dgvAlunosCurso);
            this.gbAlunosEx.Location = new System.Drawing.Point(13, 13);
            this.gbAlunosEx.Name = "gbAlunosEx";
            this.gbAlunosEx.Size = new System.Drawing.Size(1005, 270);
            this.gbAlunosEx.TabIndex = 0;
            this.gbAlunosEx.TabStop = false;
            this.gbAlunosEx.Text = "Alunos Cadastrados";
            // 
            // gbCursos
            // 
            this.gbCursos.Controls.Add(this.dgvCusosAlunos);
            this.gbCursos.Controls.Add(this.cbCadastros);
            this.gbCursos.Controls.Add(this.cbSuporte);
            this.gbCursos.Controls.Add(this.cbRastreamento);
            this.gbCursos.Controls.Add(this.cbOperacional);
            this.gbCursos.Controls.Add(this.cbGerencial);
            this.gbCursos.Controls.Add(this.cbFinanceiro);
            this.gbCursos.Controls.Add(this.cbFaturamento);
            this.gbCursos.Controls.Add(this.cbEstoque);
            this.gbCursos.Controls.Add(this.cbCompras);
            this.gbCursos.Location = new System.Drawing.Point(13, 302);
            this.gbCursos.Name = "gbCursos";
            this.gbCursos.Size = new System.Drawing.Size(495, 270);
            this.gbCursos.TabIndex = 0;
            this.gbCursos.TabStop = false;
            this.gbCursos.Text = "Cursos Cadastrados";
            // 
            // dgvAlunosCurso
            // 
            this.dgvAlunosCurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAlunosCurso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAlunosCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunosCurso.Location = new System.Drawing.Point(6, 21);
            this.dgvAlunosCurso.Name = "dgvAlunosCurso";
            this.dgvAlunosCurso.RowTemplate.Height = 24;
            this.dgvAlunosCurso.Size = new System.Drawing.Size(980, 243);
            this.dgvAlunosCurso.TabIndex = 0;
            this.dgvAlunosCurso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunosCurso_CellClick);
            // 
            // cbCompras
            // 
            this.cbCompras.AutoSize = true;
            this.cbCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCompras.Location = new System.Drawing.Point(6, 21);
            this.cbCompras.Name = "cbCompras";
            this.cbCompras.Size = new System.Drawing.Size(150, 21);
            this.cbCompras.TabIndex = 0;
            this.cbCompras.Text = "Módulo Compras";
            this.cbCompras.UseVisualStyleBackColor = true;
            this.cbCompras.Click += new System.EventHandler(this.cbCompras_Click);
            // 
            // cbEstoque
            // 
            this.cbEstoque.AutoSize = true;
            this.cbEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstoque.Location = new System.Drawing.Point(6, 48);
            this.cbEstoque.Name = "cbEstoque";
            this.cbEstoque.Size = new System.Drawing.Size(146, 21);
            this.cbEstoque.TabIndex = 0;
            this.cbEstoque.Text = "Módulo Estoque";
            this.cbEstoque.UseVisualStyleBackColor = true;
            // 
            // cbFaturamento
            // 
            this.cbFaturamento.AutoSize = true;
            this.cbFaturamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFaturamento.Location = new System.Drawing.Point(6, 75);
            this.cbFaturamento.Name = "cbFaturamento";
            this.cbFaturamento.Size = new System.Drawing.Size(178, 21);
            this.cbFaturamento.TabIndex = 0;
            this.cbFaturamento.Text = "Módulo Faturamento";
            this.cbFaturamento.UseVisualStyleBackColor = true;
            // 
            // cbFinanceiro
            // 
            this.cbFinanceiro.AutoSize = true;
            this.cbFinanceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFinanceiro.Location = new System.Drawing.Point(6, 102);
            this.cbFinanceiro.Name = "cbFinanceiro";
            this.cbFinanceiro.Size = new System.Drawing.Size(163, 21);
            this.cbFinanceiro.TabIndex = 0;
            this.cbFinanceiro.Text = "Módulo Financeiro";
            this.cbFinanceiro.UseVisualStyleBackColor = true;
            // 
            // cbGerencial
            // 
            this.cbGerencial.AutoSize = true;
            this.cbGerencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGerencial.Location = new System.Drawing.Point(6, 129);
            this.cbGerencial.Name = "cbGerencial";
            this.cbGerencial.Size = new System.Drawing.Size(157, 21);
            this.cbGerencial.TabIndex = 0;
            this.cbGerencial.Text = "Módulo Gerencial";
            this.cbGerencial.UseVisualStyleBackColor = true;
            // 
            // cbOperacional
            // 
            this.cbOperacional.AutoSize = true;
            this.cbOperacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperacional.Location = new System.Drawing.Point(6, 156);
            this.cbOperacional.Name = "cbOperacional";
            this.cbOperacional.Size = new System.Drawing.Size(175, 21);
            this.cbOperacional.TabIndex = 0;
            this.cbOperacional.Text = "Módulo Operacional";
            this.cbOperacional.UseVisualStyleBackColor = true;
            // 
            // cbRastreamento
            // 
            this.cbRastreamento.AutoSize = true;
            this.cbRastreamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRastreamento.Location = new System.Drawing.Point(6, 183);
            this.cbRastreamento.Name = "cbRastreamento";
            this.cbRastreamento.Size = new System.Drawing.Size(188, 21);
            this.cbRastreamento.TabIndex = 0;
            this.cbRastreamento.Text = "Módulo Rastreamento";
            this.cbRastreamento.UseVisualStyleBackColor = true;
            // 
            // cbSuporte
            // 
            this.cbSuporte.AutoSize = true;
            this.cbSuporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSuporte.Location = new System.Drawing.Point(6, 210);
            this.cbSuporte.Name = "cbSuporte";
            this.cbSuporte.Size = new System.Drawing.Size(144, 21);
            this.cbSuporte.TabIndex = 0;
            this.cbSuporte.Text = "Módulo Suporte";
            this.cbSuporte.UseVisualStyleBackColor = true;
            // 
            // btInserir
            // 
            this.btInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInserir.Location = new System.Drawing.Point(13, 592);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(120, 38);
            this.btInserir.TabIndex = 1;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // dgvCusosAlunos
            // 
            this.dgvCusosAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCusosAlunos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCusosAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCusosAlunos.Location = new System.Drawing.Point(225, 21);
            this.dgvCusosAlunos.Name = "dgvCusosAlunos";
            this.dgvCusosAlunos.RowTemplate.Height = 24;
            this.dgvCusosAlunos.Size = new System.Drawing.Size(262, 243);
            this.dgvCusosAlunos.TabIndex = 1;
            this.dgvCusosAlunos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCusosAlunos_CellFormatting);
            // 
            // cbCadastros
            // 
            this.cbCadastros.AutoSize = true;
            this.cbCadastros.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCadastros.Location = new System.Drawing.Point(6, 237);
            this.cbCadastros.Name = "cbCadastros";
            this.cbCadastros.Size = new System.Drawing.Size(160, 21);
            this.cbCadastros.TabIndex = 0;
            this.cbCadastros.Text = "Módulo Cadastros";
            this.cbCadastros.UseVisualStyleBackColor = true;
            // 
            // FormCadastraCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1029, 689);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.gbCursos);
            this.Controls.Add(this.gbAlunosEx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadastraCurso";
            this.Text = "Inserir Curso";
            this.Load += new System.EventHandler(this.FormCadastraCurso_Load);
            this.gbAlunosEx.ResumeLayout(false);
            this.gbCursos.ResumeLayout(false);
            this.gbCursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCusosAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAlunosEx;
        private System.Windows.Forms.DataGridView dgvAlunosCurso;
        private System.Windows.Forms.GroupBox gbCursos;
        private System.Windows.Forms.CheckBox cbSuporte;
        private System.Windows.Forms.CheckBox cbRastreamento;
        private System.Windows.Forms.CheckBox cbOperacional;
        private System.Windows.Forms.CheckBox cbGerencial;
        private System.Windows.Forms.CheckBox cbFinanceiro;
        private System.Windows.Forms.CheckBox cbFaturamento;
        private System.Windows.Forms.CheckBox cbEstoque;
        private System.Windows.Forms.CheckBox cbCompras;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.DataGridView dgvCusosAlunos;
        private System.Windows.Forms.CheckBox cbCadastros;
    }
}
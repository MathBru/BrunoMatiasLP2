namespace Trabalho1
{
    partial class Viagem
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cadastrar = new System.Windows.Forms.Button();
            this.modelo_txt = new System.Windows.Forms.TextBox();
            this.marca_txt = new System.Windows.Forms.TextBox();
            this.placa_txt = new System.Windows.Forms.TextBox();
            this.capPassageiros_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Capacidade = new System.Windows.Forms.Label();
            this.id_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adicionar = new System.Windows.Forms.Button();
            this.Relatorio_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(141, 115);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(70, 23);
            this.Cadastrar.TabIndex = 0;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click_1);
            // 
            // modelo_txt
            // 
            this.modelo_txt.Location = new System.Drawing.Point(79, 12);
            this.modelo_txt.Name = "modelo_txt";
            this.modelo_txt.Size = new System.Drawing.Size(132, 20);
            this.modelo_txt.TabIndex = 2;
            // 
            // marca_txt
            // 
            this.marca_txt.Location = new System.Drawing.Point(79, 38);
            this.marca_txt.Name = "marca_txt";
            this.marca_txt.Size = new System.Drawing.Size(132, 20);
            this.marca_txt.TabIndex = 3;
            // 
            // placa_txt
            // 
            this.placa_txt.Location = new System.Drawing.Point(79, 64);
            this.placa_txt.Name = "placa_txt";
            this.placa_txt.Size = new System.Drawing.Size(132, 20);
            this.placa_txt.TabIndex = 4;
            // 
            // capPassageiros_txt
            // 
            this.capPassageiros_txt.Location = new System.Drawing.Point(79, 89);
            this.capPassageiros_txt.Name = "capPassageiros_txt";
            this.capPassageiros_txt.Size = new System.Drawing.Size(132, 20);
            this.capPassageiros_txt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Placa:";
            // 
            // Capacidade
            // 
            this.Capacidade.AutoSize = true;
            this.Capacidade.Location = new System.Drawing.Point(6, 92);
            this.Capacidade.Name = "Capacidade";
            this.Capacidade.Size = new System.Drawing.Size(67, 13);
            this.Capacidade.TabIndex = 10;
            this.Capacidade.Text = "Capacidade:";
            // 
            // id_text
            // 
            this.id_text.Location = new System.Drawing.Point(103, 146);
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(32, 20);
            this.id_text.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID:";
            // 
            // adicionar
            // 
            this.adicionar.Location = new System.Drawing.Point(141, 144);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(70, 23);
            this.adicionar.TabIndex = 13;
            this.adicionar.Text = "Adicionar";
            this.adicionar.UseVisualStyleBackColor = true;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // Relatorio_btn
            // 
            this.Relatorio_btn.Location = new System.Drawing.Point(12, 173);
            this.Relatorio_btn.Name = "Relatorio_btn";
            this.Relatorio_btn.Size = new System.Drawing.Size(199, 23);
            this.Relatorio_btn.TabIndex = 14;
            this.Relatorio_btn.Text = "RELATORIO";
            this.Relatorio_btn.UseVisualStyleBackColor = true;
            this.Relatorio_btn.Click += new System.EventHandler(this.Relatorio_btn_Click);
            // 
            // Viagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 203);
            this.Controls.Add(this.Relatorio_btn);
            this.Controls.Add(this.adicionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id_text);
            this.Controls.Add(this.Capacidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.capPassageiros_txt);
            this.Controls.Add(this.placa_txt);
            this.Controls.Add(this.marca_txt);
            this.Controls.Add(this.modelo_txt);
            this.Controls.Add(this.Cadastrar);
            this.Name = "Viagem";
            this.Text = "Viagem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.TextBox modelo_txt;
        private System.Windows.Forms.TextBox marca_txt;
        private System.Windows.Forms.TextBox placa_txt;
        private System.Windows.Forms.TextBox capPassageiros_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Capacidade;
        private System.Windows.Forms.TextBox id_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adicionar;
        private System.Windows.Forms.Button Relatorio_btn;
    }
}


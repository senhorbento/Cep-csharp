
namespace consumindo_api_rest_csharp
{
    partial class JanelaPrincipal
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
            this.BtFechar = new System.Windows.Forms.Button();
            this.BtConsultar = new System.Windows.Forms.Button();
            this.LbLogradouro = new System.Windows.Forms.Label();
            this.LbDigite = new System.Windows.Forms.Label();
            this.TxBoxInput = new System.Windows.Forms.TextBox();
            this.LbCep = new System.Windows.Forms.Label();
            this.TxBoxCep = new System.Windows.Forms.TextBox();
            this.TxBoxLogradouro = new System.Windows.Forms.TextBox();
            this.TxBoxComplemento = new System.Windows.Forms.TextBox();
            this.TxBoxBairro = new System.Windows.Forms.TextBox();
            this.TxBoxLocalidade = new System.Windows.Forms.TextBox();
            this.TxBoxUf = new System.Windows.Forms.TextBox();
            this.TxBoxSiafi = new System.Windows.Forms.TextBox();
            this.TxBoxDdd = new System.Windows.Forms.TextBox();
            this.TxBoxGia = new System.Windows.Forms.TextBox();
            this.TxBoxIbge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtFechar
            // 
            this.BtFechar.Location = new System.Drawing.Point(12, 376);
            this.BtFechar.Name = "BtFechar";
            this.BtFechar.Size = new System.Drawing.Size(75, 23);
            this.BtFechar.TabIndex = 0;
            this.BtFechar.Text = "Fechar";
            this.BtFechar.UseVisualStyleBackColor = true;
            this.BtFechar.Click += new System.EventHandler(this.BtFechar_Click);
            // 
            // BtConsultar
            // 
            this.BtConsultar.Location = new System.Drawing.Point(223, 29);
            this.BtConsultar.Name = "BtConsultar";
            this.BtConsultar.Size = new System.Drawing.Size(75, 20);
            this.BtConsultar.TabIndex = 1;
            this.BtConsultar.Text = "Consultar";
            this.BtConsultar.UseVisualStyleBackColor = true;
            this.BtConsultar.Click += new System.EventHandler(this.BtConsultar_Click);
            // 
            // LbLogradouro
            // 
            this.LbLogradouro.AutoSize = true;
            this.LbLogradouro.Location = new System.Drawing.Point(44, 84);
            this.LbLogradouro.Name = "LbLogradouro";
            this.LbLogradouro.Size = new System.Drawing.Size(61, 13);
            this.LbLogradouro.TabIndex = 2;
            this.LbLogradouro.Text = "Logradouro";
            // 
            // LbDigite
            // 
            this.LbDigite.AutoSize = true;
            this.LbDigite.Location = new System.Drawing.Point(44, 32);
            this.LbDigite.Name = "LbDigite";
            this.LbDigite.Size = new System.Drawing.Size(64, 13);
            this.LbDigite.TabIndex = 3;
            this.LbDigite.Text = "Digite o cep";
            // 
            // TxBoxInput
            // 
            this.TxBoxInput.Location = new System.Drawing.Point(117, 29);
            this.TxBoxInput.MaxLength = 8;
            this.TxBoxInput.Name = "TxBoxInput";
            this.TxBoxInput.Size = new System.Drawing.Size(100, 20);
            this.TxBoxInput.TabIndex = 4;
            // 
            // LbCep
            // 
            this.LbCep.AutoSize = true;
            this.LbCep.Location = new System.Drawing.Point(44, 58);
            this.LbCep.Name = "LbCep";
            this.LbCep.Size = new System.Drawing.Size(26, 13);
            this.LbCep.TabIndex = 5;
            this.LbCep.Text = "Cep";
            // 
            // TxBoxCep
            // 
            this.TxBoxCep.Enabled = false;
            this.TxBoxCep.Location = new System.Drawing.Point(117, 55);
            this.TxBoxCep.MaxLength = 8;
            this.TxBoxCep.Name = "TxBoxCep";
            this.TxBoxCep.Size = new System.Drawing.Size(181, 20);
            this.TxBoxCep.TabIndex = 6;
            // 
            // TxBoxLogradouro
            // 
            this.TxBoxLogradouro.Enabled = false;
            this.TxBoxLogradouro.Location = new System.Drawing.Point(117, 81);
            this.TxBoxLogradouro.MaxLength = 8;
            this.TxBoxLogradouro.Name = "TxBoxLogradouro";
            this.TxBoxLogradouro.Size = new System.Drawing.Size(181, 20);
            this.TxBoxLogradouro.TabIndex = 7;
            // 
            // TxBoxComplemento
            // 
            this.TxBoxComplemento.Enabled = false;
            this.TxBoxComplemento.Location = new System.Drawing.Point(117, 107);
            this.TxBoxComplemento.MaxLength = 8;
            this.TxBoxComplemento.Name = "TxBoxComplemento";
            this.TxBoxComplemento.Size = new System.Drawing.Size(181, 20);
            this.TxBoxComplemento.TabIndex = 8;
            // 
            // TxBoxBairro
            // 
            this.TxBoxBairro.Enabled = false;
            this.TxBoxBairro.Location = new System.Drawing.Point(117, 133);
            this.TxBoxBairro.MaxLength = 8;
            this.TxBoxBairro.Name = "TxBoxBairro";
            this.TxBoxBairro.Size = new System.Drawing.Size(181, 20);
            this.TxBoxBairro.TabIndex = 9;
            // 
            // TxBoxLocalidade
            // 
            this.TxBoxLocalidade.Enabled = false;
            this.TxBoxLocalidade.Location = new System.Drawing.Point(117, 159);
            this.TxBoxLocalidade.MaxLength = 8;
            this.TxBoxLocalidade.Name = "TxBoxLocalidade";
            this.TxBoxLocalidade.Size = new System.Drawing.Size(181, 20);
            this.TxBoxLocalidade.TabIndex = 10;
            // 
            // TxBoxUf
            // 
            this.TxBoxUf.Enabled = false;
            this.TxBoxUf.Location = new System.Drawing.Point(117, 185);
            this.TxBoxUf.MaxLength = 8;
            this.TxBoxUf.Name = "TxBoxUf";
            this.TxBoxUf.Size = new System.Drawing.Size(181, 20);
            this.TxBoxUf.TabIndex = 11;
            // 
            // TxBoxSiafi
            // 
            this.TxBoxSiafi.Enabled = false;
            this.TxBoxSiafi.Location = new System.Drawing.Point(117, 289);
            this.TxBoxSiafi.MaxLength = 8;
            this.TxBoxSiafi.Name = "TxBoxSiafi";
            this.TxBoxSiafi.Size = new System.Drawing.Size(181, 20);
            this.TxBoxSiafi.TabIndex = 12;
            // 
            // TxBoxDdd
            // 
            this.TxBoxDdd.Enabled = false;
            this.TxBoxDdd.Location = new System.Drawing.Point(117, 263);
            this.TxBoxDdd.MaxLength = 8;
            this.TxBoxDdd.Name = "TxBoxDdd";
            this.TxBoxDdd.Size = new System.Drawing.Size(181, 20);
            this.TxBoxDdd.TabIndex = 13;
            // 
            // TxBoxGia
            // 
            this.TxBoxGia.Enabled = false;
            this.TxBoxGia.Location = new System.Drawing.Point(117, 237);
            this.TxBoxGia.MaxLength = 8;
            this.TxBoxGia.Name = "TxBoxGia";
            this.TxBoxGia.Size = new System.Drawing.Size(181, 20);
            this.TxBoxGia.TabIndex = 14;
            // 
            // TxBoxIbge
            // 
            this.TxBoxIbge.Enabled = false;
            this.TxBoxIbge.Location = new System.Drawing.Point(117, 211);
            this.TxBoxIbge.MaxLength = 8;
            this.TxBoxIbge.Name = "TxBoxIbge";
            this.TxBoxIbge.Size = new System.Drawing.Size(181, 20);
            this.TxBoxIbge.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Complemento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Siafi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "DDD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Gia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ibge";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "UF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Localidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Bairro";
            // 
            // JanelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxBoxIbge);
            this.Controls.Add(this.TxBoxGia);
            this.Controls.Add(this.TxBoxDdd);
            this.Controls.Add(this.TxBoxSiafi);
            this.Controls.Add(this.TxBoxUf);
            this.Controls.Add(this.TxBoxLocalidade);
            this.Controls.Add(this.TxBoxBairro);
            this.Controls.Add(this.TxBoxComplemento);
            this.Controls.Add(this.TxBoxLogradouro);
            this.Controls.Add(this.TxBoxCep);
            this.Controls.Add(this.LbCep);
            this.Controls.Add(this.TxBoxInput);
            this.Controls.Add(this.LbDigite);
            this.Controls.Add(this.LbLogradouro);
            this.Controls.Add(this.BtConsultar);
            this.Controls.Add(this.BtFechar);
            this.Name = "JanelaPrincipal";
            this.Text = "Consultar Cep";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtFechar;
        private System.Windows.Forms.Button BtConsultar;
        private System.Windows.Forms.Label LbLogradouro;
        private System.Windows.Forms.Label LbDigite;
        private System.Windows.Forms.TextBox TxBoxInput;
        private System.Windows.Forms.Label LbCep;
        private System.Windows.Forms.TextBox TxBoxCep;
        private System.Windows.Forms.TextBox TxBoxLogradouro;
        private System.Windows.Forms.TextBox TxBoxComplemento;
        private System.Windows.Forms.TextBox TxBoxBairro;
        private System.Windows.Forms.TextBox TxBoxLocalidade;
        private System.Windows.Forms.TextBox TxBoxUf;
        private System.Windows.Forms.TextBox TxBoxSiafi;
        private System.Windows.Forms.TextBox TxBoxDdd;
        private System.Windows.Forms.TextBox TxBoxGia;
        private System.Windows.Forms.TextBox TxBoxIbge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}


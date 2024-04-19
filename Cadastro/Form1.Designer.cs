namespace Cadastro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCod = new TextBox();
            nome = new Label();
            textBox1 = new TextBox();
            dtNascimento = new Label();
            dateTimePicker1 = new DateTimePicker();
            tpPessoa = new Label();
            listTipo = new ListBox();
            label2 = new Label();
            textBox2 = new TextBox();
            Endereco = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            button1 = new Button();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 37);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Código ";
            // 
            // txtCod
            // 
            txtCod.BorderStyle = BorderStyle.FixedSingle;
            txtCod.Location = new Point(83, 35);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(65, 23);
            txtCod.TabIndex = 1;
            txtCod.TextChanged += txtCod_TextChanged;
            // 
            // nome
            // 
            nome.AutoSize = true;
            nome.Location = new Point(33, 109);
            nome.Name = "nome";
            nome.Size = new Size(40, 15);
            nome.TabIndex = 2;
            nome.Text = "Nome";
            nome.Click += nome_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(83, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dtNascimento
            // 
            dtNascimento.AutoSize = true;
            dtNascimento.Location = new Point(2, 194);
            dtNascimento.Name = "dtNascimento";
            dtNascimento.Size = new Size(71, 15);
            dtNascimento.TabIndex = 4;
            dtNascimento.Text = "Nascimento";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(83, 188);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(264, 23);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // tpPessoa
            // 
            tpPessoa.AutoSize = true;
            tpPessoa.Location = new Point(5, 272);
            tpPessoa.Name = "tpPessoa";
            tpPessoa.Size = new Size(72, 15);
            tpPessoa.TabIndex = 6;
            tpPessoa.Text = "Tipo  pessoa";
            // 
            // listTipo
            // 
            listTipo.BorderStyle = BorderStyle.FixedSingle;
            listTipo.FormattingEnabled = true;
            listTipo.ItemHeight = 15;
            listTipo.Location = new Point(83, 270);
            listTipo.Name = "listTipo";
            listTipo.Size = new Size(264, 17);
            listTipo.TabIndex = 7;
            listTipo.SelectedIndexChanged += listTipo_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 349);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 8;
            label2.Text = "CPF/CNPJ";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(83, 341);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(264, 23);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Endereco
            // 
            Endereco.AutoSize = true;
            Endereco.Location = new Point(17, 431);
            Endereco.Name = "Endereco";
            Endereco.Size = new Size(56, 15);
            Endereco.TabIndex = 10;
            Endereco.Text = "Endereço";
            Endereco.Click += Endereco_Click;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(83, 423);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(264, 23);
            textBox3.TabIndex = 11;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(477, 111);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 12;
            label3.Text = "Contato";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(537, 109);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(264, 23);
            textBox4.TabIndex = 13;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(489, 189);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 14;
            label4.Text = "Email";
            label4.Click += label4_Click;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(537, 186);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(264, 23);
            textBox5.TabIndex = 15;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(462, 270);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 16;
            label5.Text = "Observação";
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(537, 264);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(264, 23);
            textBox6.TabIndex = 17;
            // 
            // button1
            // 
            button1.FlatAppearance.MouseDownBackColor = SystemColors.ControlDark;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.ControlDark;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(353, 507);
            button1.Name = "button1";
            button1.Size = new Size(124, 36);
            button1.TabIndex = 18;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(433, 343);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 19;
            label6.Text = "Código categoria";
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Location = new Point(537, 341);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(84, 23);
            textBox7.TabIndex = 20;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(469, 423);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 21;
            label7.Text = "Categoria";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(539, 423);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 22;
            label8.Click += label8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(852, 554);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox7);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(Endereco);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(listTipo);
            Controls.Add(tpPessoa);
            Controls.Add(dateTimePicker1);
            Controls.Add(dtNascimento);
            Controls.Add(textBox1);
            Controls.Add(nome);
            Controls.Add(txtCod);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCod;
        private Label nome;
        private TextBox textBox1;
        private Label dtNascimento;
        private DateTimePicker dateTimePicker1;
        private Label tpPessoa;
        private ListBox listTipo;
        private Label label2;
        private TextBox textBox2;
        private Label Endereco;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Button button1;
        private Button button3;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private Label label8;
    }
}

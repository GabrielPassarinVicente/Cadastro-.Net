namespace Cadastro
{
    partial class Cadastro
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
            label1 = new Label();
            textCadastrar = new TextBox();
            label2 = new Label();
            btnCadastrar = new Button();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 44);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuário";
            // 
            // textCadastrar
            // 
            textCadastrar.BorderStyle = BorderStyle.FixedSingle;
            textCadastrar.Location = new Point(107, 36);
            textCadastrar.Name = "textCadastrar";
            textCadastrar.Size = new Size(214, 23);
            textCadastrar.TabIndex = 1;
            textCadastrar.TextChanged += textCadastrar_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 126);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 2;
            label2.Text = "Crie uma senha";
            // 
            // btnCadastrar
            // 
            btnCadastrar.FlatAppearance.MouseDownBackColor = SystemColors.ControlDarkDark;
            btnCadastrar.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Location = new Point(116, 199);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(153, 30);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(107, 119);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(111, 150);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Mostrar senha";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(380, 235);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(btnCadastrar);
            Controls.Add(label2);
            Controls.Add(textCadastrar);
            Controls.Add(label1);
            Name = "Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            Load += Cadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textCadastrar;
        private Label label2;
        private Button btnCadastrar;
        private TextBox textBox1;
        private CheckBox checkBox1;
    }
}
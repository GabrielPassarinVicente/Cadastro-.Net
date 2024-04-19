namespace Cadastro
{
    partial class Categoria
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
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 128);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Categoria";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 62);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 2;
            label2.Text = "Código";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(75, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(65, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.FlatAppearance.MouseDownBackColor = SystemColors.ControlDark;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.ControlDark;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(122, 213);
            button1.Name = "button1";
            button1.Size = new Size(117, 38);
            button1.TabIndex = 6;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(75, 125);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(220, 23);
            textBox3.TabIndex = 7;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // Categoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(360, 263);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Categoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categoria";
            Load += Categoria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox3;
    }
}
namespace Cadastro
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            novaSenha = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 151);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuário";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.MenuBar;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(73, 148);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 226);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Senha";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.MenuBar;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(73, 219);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(247, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.FlatAppearance.MouseDownBackColor = SystemColors.ControlDarkDark;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.ControlDarkDark;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(109, 390);
            button1.Name = "button1";
            button1.Size = new Size(149, 32);
            button1.TabIndex = 4;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(73, 260);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 19);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Mostrar senha";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // novaSenha
            // 
            novaSenha.FlatAppearance.BorderSize = 0;
            novaSenha.FlatAppearance.MouseDownBackColor = SystemColors.ControlDark;
            novaSenha.FlatAppearance.MouseOverBackColor = SystemColors.ControlDark;
            novaSenha.FlatStyle = FlatStyle.Flat;
            novaSenha.Location = new Point(191, 255);
            novaSenha.Name = "novaSenha";
            novaSenha.Size = new Size(129, 26);
            novaSenha.TabIndex = 7;
            novaSenha.Text = "Esqueci a senha";
            novaSenha.UseVisualStyleBackColor = true;
            novaSenha.Click += novaSenha_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = SystemColors.ControlDark;
            button2.FlatAppearance.MouseOverBackColor = SystemColors.ControlDark;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(85, 307);
            button2.Name = "button2";
            button2.Size = new Size(200, 27);
            button2.TabIndex = 8;
            button2.Text = "Cadastrar - se";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(120, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(354, 434);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(novaSenha);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            TransparencyKey = Color.White;
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private CheckBox checkBox1;
        private Button novaSenha;
        private Button button2;
        private PictureBox pictureBox1;
    }
}
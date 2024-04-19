namespace Cadastro
{
    partial class Logins
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
            dataGridViewLogin = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLogin).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewLogin
            // 
            dataGridViewLogin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLogin.Location = new Point(14, 60);
            dataGridViewLogin.Name = "dataGridViewLogin";
            dataGridViewLogin.Size = new Size(352, 378);
            dataGridViewLogin.TabIndex = 0;
            dataGridViewLogin.CellContentClick += dataGridViewLogin_CellContentClick;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(262, 12);
            button1.Name = "button1";
            button1.Size = new Size(109, 39);
            button1.TabIndex = 1;
            button1.Text = "Exportar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Logins
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 450);
            Controls.Add(button1);
            Controls.Add(dataGridViewLogin);
            Name = "Logins";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Logins";
            Load += Logins_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLogin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewLogin;
        private Button button1;
    }
}
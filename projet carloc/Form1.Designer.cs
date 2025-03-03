namespace projet_carloc
{
    partial class F
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            groupBox2 = new GroupBox();
            button2 = new Button();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            tabPage2 = new TabPage();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(21, 17);
            groupBox1.Margin = new Padding(2, 1, 2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 1, 2, 1);
            groupBox1.Size = new Size(702, 218);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inscription";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(233, 185);
            button1.Name = "button1";
            button1.Size = new Size(207, 29);
            button1.TabIndex = 6;
            button1.Text = "S'inscrire";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(233, 145);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(207, 23);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(299, 127);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 4;
            label3.Text = "Mot de passe";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(233, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(316, 74);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(233, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(289, 17);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Nom d'utilisateur";
            label1.Click += label1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(6, 6);
            tabControl1.Margin = new Padding(2, 1, 2, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(752, 456);
            tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(statusStrip1);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2, 1, 2, 1);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2, 1, 2, 1);
            tabPage1.Size = new Size(744, 428);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Inscription et Connexion";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(2, 405);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(740, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "Bienvenue :";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(68, 17);
            toolStripStatusLabel1.Text = "Bienvenue :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(21, 239);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(702, 161);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Connexion";
            // 
            // button2
            // 
            button2.Location = new Point(233, 122);
            button2.Name = "button2";
            button2.Size = new Size(207, 33);
            button2.TabIndex = 4;
            button2.Text = "Se connecter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(233, 93);
            textBox5.Name = "textBox5";
            textBox5.PasswordChar = '*';
            textBox5.Size = new Size(207, 23);
            textBox5.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(299, 75);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 2;
            label5.Text = "Mot de passe";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(233, 37);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(207, 23);
            textBox4.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(289, 19);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 0;
            label4.Text = "Nom d'utilisateur";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2, 1, 2, 1);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2, 1, 2, 1);
            tabPage2.Size = new Size(744, 428);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // F
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 464);
            Controls.Add(tabControl1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "F";
            Text = "CarLoc accueil";
            Load += F_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private Button button2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}

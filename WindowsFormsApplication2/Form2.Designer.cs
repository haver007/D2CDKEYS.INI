namespace WindowsFormsApplication2
{
    partial class Form2
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.keys = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.spacing = new System.Windows.Forms.TextBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.target = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.praefix = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // keys
            // 
            this.keys.Location = new System.Drawing.Point(128, 12);
            this.keys.Name = "keys";
            this.keys.Size = new System.Drawing.Size(280, 22);
            this.keys.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Keys";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Delimiter";
            // 
            // spacing
            // 
            this.spacing.Location = new System.Drawing.Point(128, 40);
            this.spacing.MaxLength = 1;
            this.spacing.Name = "spacing";
            this.spacing.Size = new System.Drawing.Size(280, 22);
            this.spacing.TabIndex = 3;
            this.spacing.Text = ":";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // target
            // 
            this.target.Location = new System.Drawing.Point(128, 124);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(280, 22);
            this.target.TabIndex = 6;
            this.target.Text = "cdkeys.ini";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Output filename";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(416, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Generate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Listname";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // listname
            // 
            this.listname.Location = new System.Drawing.Point(128, 68);
            this.listname.Name = "listname";
            this.listname.Size = new System.Drawing.Size(280, 22);
            this.listname.TabIndex = 9;
            this.listname.Text = "listname";
            this.listname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "praefix";
            // 
            // praefix
            // 
            this.praefix.Location = new System.Drawing.Point(128, 96);
            this.praefix.Name = "praefix";
            this.praefix.Size = new System.Drawing.Size(280, 22);
            this.praefix.TabIndex = 11;
            this.praefix.Text = "pr";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 171);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(487, 44);
            this.button4.TabIndex = 14;
            this.button4.Text = "Switch to Two File";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 227);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.praefix);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listname);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.target);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spacing);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.keys);
            this.Name = "Form2";
            this.Text = "CDKEYS.INI GENERATOR by haver1337";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox keys;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox spacing;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox target;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox listname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox praefix;
        private System.Windows.Forms.Button button4;
    }
}


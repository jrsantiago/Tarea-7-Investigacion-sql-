namespace DataBaseConectivity
{
    partial class Ventas
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
            this.addButton = new System.Windows.Forms.Button();
            this.VV = new System.Windows.Forms.Label();
            this.nameTxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ageTxtbox = new System.Windows.Forms.TextBox();
            this.genderTxtbox = new System.Windows.Forms.TextBox();
            this.PasswordTxtbox = new System.Windows.Forms.TextBox();
            this.EmailTxtbox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(15, 198);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(108, 24);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // VV
            // 
            this.VV.AutoSize = true;
            this.VV.Location = new System.Drawing.Point(12, 49);
            this.VV.Name = "VV";
            this.VV.Size = new System.Drawing.Size(44, 13);
            this.VV.TabIndex = 1;
            this.VV.Text = "Nombre";
            // 
            // nameTxtbox
            // 
            this.nameTxtbox.Location = new System.Drawing.Point(121, 49);
            this.nameTxtbox.Name = "nameTxtbox";
            this.nameTxtbox.Size = new System.Drawing.Size(100, 20);
            this.nameTxtbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Edad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Genero";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // ageTxtbox
            // 
            this.ageTxtbox.Location = new System.Drawing.Point(121, 76);
            this.ageTxtbox.Name = "ageTxtbox";
            this.ageTxtbox.Size = new System.Drawing.Size(100, 20);
            this.ageTxtbox.TabIndex = 8;
            // 
            // genderTxtbox
            // 
            this.genderTxtbox.Location = new System.Drawing.Point(121, 105);
            this.genderTxtbox.Name = "genderTxtbox";
            this.genderTxtbox.Size = new System.Drawing.Size(100, 20);
            this.genderTxtbox.TabIndex = 9;
            // 
            // PasswordTxtbox
            // 
            this.PasswordTxtbox.Location = new System.Drawing.Point(121, 162);
            this.PasswordTxtbox.Name = "PasswordTxtbox";
            this.PasswordTxtbox.PasswordChar = '*';
            this.PasswordTxtbox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTxtbox.TabIndex = 10;
            // 
            // EmailTxtbox
            // 
            this.EmailTxtbox.Location = new System.Drawing.Point(121, 131);
            this.EmailTxtbox.Name = "EmailTxtbox";
            this.EmailTxtbox.Size = new System.Drawing.Size(100, 20);
            this.EmailTxtbox.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 24);
            this.button2.TabIndex = 13;
            this.button2.Text = "Display";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 237);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(341, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statuslbl
            // 
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(0, 17);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 259);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.EmailTxtbox);
            this.Controls.Add(this.PasswordTxtbox);
            this.Controls.Add(this.genderTxtbox);
            this.Controls.Add(this.ageTxtbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTxtbox);
            this.Controls.Add(this.VV);
            this.Controls.Add(this.addButton);
            this.Name = "Ventas";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label VV;
        private System.Windows.Forms.TextBox nameTxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ageTxtbox;
        private System.Windows.Forms.TextBox genderTxtbox;
        private System.Windows.Forms.TextBox PasswordTxtbox;
        private System.Windows.Forms.TextBox EmailTxtbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statuslbl;
    }
}


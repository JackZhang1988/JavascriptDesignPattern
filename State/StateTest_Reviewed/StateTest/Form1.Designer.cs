namespace StateTest
{
    partial class Form1
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
            this.buttonCardin = new System.Windows.Forms.Button();
            this.buttonInputpsw = new System.Windows.Forms.Button();
            this.buttonCardout = new System.Windows.Forms.Button();
            this.textBoxCardNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPsw = new System.Windows.Forms.TextBox();
            this.textBoxATM = new System.Windows.Forms.TextBox();
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCardin
            // 
            this.buttonCardin.Location = new System.Drawing.Point(256, 19);
            this.buttonCardin.Name = "buttonCardin";
            this.buttonCardin.Size = new System.Drawing.Size(92, 20);
            this.buttonCardin.TabIndex = 0;
            this.buttonCardin.Text = "Card In";
            this.buttonCardin.UseVisualStyleBackColor = true;
            this.buttonCardin.Click += new System.EventHandler(this.buttonCardin_Click);
            // 
            // buttonInputpsw
            // 
            this.buttonInputpsw.Location = new System.Drawing.Point(256, 57);
            this.buttonInputpsw.Name = "buttonInputpsw";
            this.buttonInputpsw.Size = new System.Drawing.Size(92, 20);
            this.buttonInputpsw.TabIndex = 1;
            this.buttonInputpsw.Text = "Input Psw";
            this.buttonInputpsw.UseVisualStyleBackColor = true;
            this.buttonInputpsw.Click += new System.EventHandler(this.buttonInputpsw_Click);
            // 
            // buttonCardout
            // 
            this.buttonCardout.Location = new System.Drawing.Point(256, 139);
            this.buttonCardout.Name = "buttonCardout";
            this.buttonCardout.Size = new System.Drawing.Size(92, 24);
            this.buttonCardout.TabIndex = 2;
            this.buttonCardout.Text = "Card Out";
            this.buttonCardout.UseVisualStyleBackColor = true;
            this.buttonCardout.Click += new System.EventHandler(this.cardout_Click);
            // 
            // textBoxCardNumber
            // 
            this.textBoxCardNumber.Location = new System.Drawing.Point(98, 19);
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(143, 20);
            this.textBoxCardNumber.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Card Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password";
            // 
            // textBoxPsw
            // 
            this.textBoxPsw.Location = new System.Drawing.Point(98, 57);
            this.textBoxPsw.Name = "textBoxPsw";
            this.textBoxPsw.Size = new System.Drawing.Size(143, 20);
            this.textBoxPsw.TabIndex = 6;
            // 
            // textBoxATM
            // 
            this.textBoxATM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxATM.Location = new System.Drawing.Point(15, 185);
            this.textBoxATM.Multiline = true;
            this.textBoxATM.Name = "textBoxATM";
            this.textBoxATM.ReadOnly = true;
            this.textBoxATM.Size = new System.Drawing.Size(333, 364);
            this.textBoxATM.TabIndex = 8;
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.Location = new System.Drawing.Point(256, 96);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(92, 24);
            this.buttonWithdraw.TabIndex = 9;
            this.buttonWithdraw.Text = "Withdraw 10$";
            this.buttonWithdraw.UseVisualStyleBackColor = true;
            this.buttonWithdraw.Click += new System.EventHandler(this.buttonWithdraw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 561);
            this.Controls.Add(this.buttonWithdraw);
            this.Controls.Add(this.textBoxATM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPsw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCardNumber);
            this.Controls.Add(this.buttonCardout);
            this.Controls.Add(this.buttonInputpsw);
            this.Controls.Add(this.buttonCardin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCardin;
        private System.Windows.Forms.Button buttonInputpsw;
        private System.Windows.Forms.Button buttonCardout;
        private System.Windows.Forms.TextBox textBoxCardNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPsw;
        private System.Windows.Forms.TextBox textBoxATM;
        private System.Windows.Forms.Button buttonWithdraw;
    }
}


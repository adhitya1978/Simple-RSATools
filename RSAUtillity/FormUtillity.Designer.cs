namespace RSAUtillity
{
    partial class FormUtillity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUtillity));
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxXml = new System.Windows.Forms.CheckBox();
            this.checkBoxBin = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxXml
            // 
            this.checkBoxXml.AutoSize = true;
            this.checkBoxXml.Location = new System.Drawing.Point(101, 360);
            this.checkBoxXml.Name = "checkBoxXml";
            this.checkBoxXml.Size = new System.Drawing.Size(118, 17);
            this.checkBoxXml.TabIndex = 1;
            this.checkBoxXml.Text = "Generate as xml file";
            this.checkBoxXml.UseVisualStyleBackColor = true;
            // 
            // checkBoxBin
            // 
            this.checkBoxBin.AutoSize = true;
            this.checkBoxBin.Location = new System.Drawing.Point(101, 384);
            this.checkBoxBin.Name = "checkBoxBin";
            this.checkBoxBin.Size = new System.Drawing.Size(131, 17);
            this.checkBoxBin.TabIndex = 2;
            this.checkBoxBin.Text = "Generate as binary file";
            this.checkBoxBin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "1st Prime (P)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "2nd Prime (Q)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modulus (N)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Private Exponent (D)";
            // 
            // textBoxP
            // 
            this.textBoxP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxP.Location = new System.Drawing.Point(13, 33);
            this.textBoxP.Multiline = true;
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(379, 55);
            this.textBoxP.TabIndex = 7;
            // 
            // textBoxQ
            // 
            this.textBoxQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxQ.Location = new System.Drawing.Point(13, 107);
            this.textBoxQ.Multiline = true;
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(379, 52);
            this.textBoxQ.TabIndex = 8;
            // 
            // textBoxN
            // 
            this.textBoxN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxN.Location = new System.Drawing.Point(13, 190);
            this.textBoxN.Multiline = true;
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(379, 49);
            this.textBoxN.TabIndex = 9;
            // 
            // textBoxD
            // 
            this.textBoxD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxD.Location = new System.Drawing.Point(13, 268);
            this.textBoxD.Multiline = true;
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(379, 71);
            this.textBoxD.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxKey);
            this.groupBox1.Location = new System.Drawing.Point(261, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 49);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Keysize (Bits)";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(18, 17);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(102, 20);
            this.textBoxKey.TabIndex = 0;
            // 
            // FormUtillity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 410);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxBin);
            this.Controls.Add(this.checkBoxXml);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUtillity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produce RSA Key";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxXml;
        private System.Windows.Forms.CheckBox checkBoxBin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxKey;
    }
}
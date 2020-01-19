namespace Final_Project
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.rdoPigLatin = new System.Windows.Forms.RadioButton();
            this.rdoPigGreek = new System.Windows.Forms.RadioButton();
            this.lblTranslationType = new System.Windows.Forms.Label();
            this.txtTranslation = new System.Windows.Forms.TextBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter English text here:";
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(51, 47);
            this.txtEnglish.Multiline = true;
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEnglish.Size = new System.Drawing.Size(523, 152);
            this.txtEnglish.TabIndex = 1;
            // 
            // rdoPigLatin
            // 
            this.rdoPigLatin.AutoSize = true;
            this.rdoPigLatin.Location = new System.Drawing.Point(188, 219);
            this.rdoPigLatin.Name = "rdoPigLatin";
            this.rdoPigLatin.Size = new System.Drawing.Size(66, 17);
            this.rdoPigLatin.TabIndex = 2;
            this.rdoPigLatin.TabStop = true;
            this.rdoPigLatin.Text = "Pig Latin";
            this.rdoPigLatin.UseVisualStyleBackColor = true;
            this.rdoPigLatin.CheckedChanged += new System.EventHandler(this.rdoPigLatin_CheckedChanged);
            // 
            // rdoPigGreek
            // 
            this.rdoPigGreek.AutoSize = true;
            this.rdoPigGreek.Location = new System.Drawing.Point(340, 219);
            this.rdoPigGreek.Name = "rdoPigGreek";
            this.rdoPigGreek.Size = new System.Drawing.Size(72, 17);
            this.rdoPigGreek.TabIndex = 3;
            this.rdoPigGreek.TabStop = true;
            this.rdoPigGreek.Text = "Pig Greek";
            this.rdoPigGreek.UseVisualStyleBackColor = true;
            this.rdoPigGreek.CheckedChanged += new System.EventHandler(this.rdoPigGreek_CheckedChanged);
            // 
            // lblTranslationType
            // 
            this.lblTranslationType.AutoSize = true;
            this.lblTranslationType.Location = new System.Drawing.Point(48, 239);
            this.lblTranslationType.Name = "lblTranslationType";
            this.lblTranslationType.Size = new System.Drawing.Size(59, 13);
            this.lblTranslationType.TabIndex = 4;
            this.lblTranslationType.Text = "Translation";
            // 
            // txtTranslation
            // 
            this.txtTranslation.Location = new System.Drawing.Point(51, 267);
            this.txtTranslation.Multiline = true;
            this.txtTranslation.Name = "txtTranslation";
            this.txtTranslation.ReadOnly = true;
            this.txtTranslation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTranslation.Size = new System.Drawing.Size(523, 152);
            this.txtTranslation.TabIndex = 5;
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(51, 455);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(75, 23);
            this.btnTranslate.TabIndex = 6;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(155, 455);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(499, 455);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnTranslate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(623, 509);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.txtTranslation);
            this.Controls.Add(this.lblTranslationType);
            this.Controls.Add(this.rdoPigGreek);
            this.Controls.Add(this.rdoPigLatin);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.RadioButton rdoPigLatin;
        private System.Windows.Forms.RadioButton rdoPigGreek;
        private System.Windows.Forms.Label lblTranslationType;
        private System.Windows.Forms.TextBox txtTranslation;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}


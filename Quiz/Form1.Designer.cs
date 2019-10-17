namespace Quiz
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
            this.lblQNumber = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.chkResonse01 = new System.Windows.Forms.CheckBox();
            this.chkResponse02 = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "This is my quiz";
            // 
            // lblQNumber
            // 
            this.lblQNumber.AutoSize = true;
            this.lblQNumber.Location = new System.Drawing.Point(67, 60);
            this.lblQNumber.Name = "lblQNumber";
            this.lblQNumber.Size = new System.Drawing.Size(16, 13);
            this.lblQNumber.TabIndex = 1;
            this.lblQNumber.Text = "1)";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(89, 60);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(110, 13);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Question place holder";
            // 
            // chkResonse01
            // 
            this.chkResonse01.AutoSize = true;
            this.chkResonse01.Location = new System.Drawing.Point(68, 87);
            this.chkResonse01.Name = "chkResonse01";
            this.chkResonse01.Size = new System.Drawing.Size(80, 17);
            this.chkResonse01.TabIndex = 3;
            this.chkResonse01.Text = "checkBox1";
            this.chkResonse01.UseVisualStyleBackColor = true;
            // 
            // chkResponse02
            // 
            this.chkResponse02.AutoSize = true;
            this.chkResponse02.Location = new System.Drawing.Point(68, 111);
            this.chkResponse02.Name = "chkResponse02";
            this.chkResponse02.Size = new System.Drawing.Size(80, 17);
            this.chkResponse02.TabIndex = 4;
            this.chkResponse02.Text = "checkBox2";
            this.chkResponse02.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(283, 11);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Begin";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(68, 164);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Grade";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 301);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.chkResponse02);
            this.Controls.Add(this.chkResonse01);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblQNumber);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQNumber;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.CheckBox chkResonse01;
        private System.Windows.Forms.CheckBox chkResponse02;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button button1;
    }
}


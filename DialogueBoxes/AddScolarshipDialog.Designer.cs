namespace DialogueBoxes
{
    partial class AddScolarshipDialog
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.enterScolarshipTb = new System.Windows.Forms.TextBox();
            this.enterEUScolTb = new System.Windows.Forms.TextBox();
            this.enterSalaryTb = new System.Windows.Forms.TextBox();
            this.incomeTb = new System.Windows.Forms.TextBox();
            this.calcScolarshipBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.calculatedSalaryTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(106, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Въведи стипендия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(65, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Европейска стипендия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(202, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Заплата:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(178, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Общ доход:";
            // 
            // enterScolarshipTb
            // 
            this.enterScolarshipTb.Location = new System.Drawing.Point(355, 54);
            this.enterScolarshipTb.Name = "enterScolarshipTb";
            this.enterScolarshipTb.Size = new System.Drawing.Size(168, 22);
            this.enterScolarshipTb.TabIndex = 4;
            // 
            // enterEUScolTb
            // 
            this.enterEUScolTb.Location = new System.Drawing.Point(355, 120);
            this.enterEUScolTb.Name = "enterEUScolTb";
            this.enterEUScolTb.Size = new System.Drawing.Size(168, 22);
            this.enterEUScolTb.TabIndex = 5;
            // 
            // enterSalaryTb
            // 
            this.enterSalaryTb.Location = new System.Drawing.Point(355, 185);
            this.enterSalaryTb.Name = "enterSalaryTb";
            this.enterSalaryTb.Size = new System.Drawing.Size(168, 22);
            this.enterSalaryTb.TabIndex = 6;
            // 
            // incomeTb
            // 
            this.incomeTb.Location = new System.Drawing.Point(355, 246);
            this.incomeTb.Name = "incomeTb";
            this.incomeTb.Size = new System.Drawing.Size(168, 22);
            this.incomeTb.TabIndex = 7;
            // 
            // calcScolarshipBtn
            // 
            this.calcScolarshipBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calcScolarshipBtn.Location = new System.Drawing.Point(182, 313);
            this.calcScolarshipBtn.Name = "calcScolarshipBtn";
            this.calcScolarshipBtn.Size = new System.Drawing.Size(135, 40);
            this.calcScolarshipBtn.TabIndex = 8;
            this.calcScolarshipBtn.Text = "Пресметни";
            this.calcScolarshipBtn.UseVisualStyleBackColor = true;
            this.calcScolarshipBtn.Click += new System.EventHandler(this.calcScolarshipBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.okBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okBtn.Location = new System.Drawing.Point(221, 388);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(96, 33);
            this.okBtn.TabIndex = 9;
            this.okBtn.Text = "ОК";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.Location = new System.Drawing.Point(400, 388);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(95, 33);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Изход";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // calculatedSalaryTb
            // 
            this.calculatedSalaryTb.Location = new System.Drawing.Point(355, 322);
            this.calculatedSalaryTb.Name = "calculatedSalaryTb";
            this.calculatedSalaryTb.Size = new System.Drawing.Size(168, 22);
            this.calculatedSalaryTb.TabIndex = 11;
            this.calculatedSalaryTb.Visible = false;
            // 
            // AddScolarshipDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 442);
            this.Controls.Add(this.calculatedSalaryTb);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.calcScolarshipBtn);
            this.Controls.Add(this.incomeTb);
            this.Controls.Add(this.enterSalaryTb);
            this.Controls.Add(this.enterEUScolTb);
            this.Controls.Add(this.enterScolarshipTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddScolarshipDialog";
            this.Text = "AddScolarshipDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox enterScolarshipTb;
        private System.Windows.Forms.TextBox enterEUScolTb;
        private System.Windows.Forms.TextBox enterSalaryTb;
        private System.Windows.Forms.TextBox incomeTb;
        private System.Windows.Forms.Button calcScolarshipBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox calculatedSalaryTb;
    }
}
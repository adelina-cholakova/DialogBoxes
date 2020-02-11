namespace DialogueBoxes
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
            this.addNameBtn = new System.Windows.Forms.Button();
            this.addScolarshipBtn = new System.Windows.Forms.Button();
            this.enteredNameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.namesListBox = new System.Windows.Forms.ListBox();
            this.scolarshipsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addNameBtn
            // 
            this.addNameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addNameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNameBtn.Location = new System.Drawing.Point(76, 59);
            this.addNameBtn.Name = "addNameBtn";
            this.addNameBtn.Size = new System.Drawing.Size(346, 37);
            this.addNameBtn.TabIndex = 0;
            this.addNameBtn.Text = "Форма за въвеждане на име";
            this.addNameBtn.UseVisualStyleBackColor = false;
            this.addNameBtn.Click += new System.EventHandler(this.addNameBtn_Click);
            // 
            // addScolarshipBtn
            // 
            this.addScolarshipBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.addScolarshipBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addScolarshipBtn.Location = new System.Drawing.Point(76, 135);
            this.addScolarshipBtn.Name = "addScolarshipBtn";
            this.addScolarshipBtn.Size = new System.Drawing.Size(403, 43);
            this.addScolarshipBtn.TabIndex = 1;
            this.addScolarshipBtn.Text = "Форма за въвеждане на стипендия";
            this.addScolarshipBtn.UseVisualStyleBackColor = false;
            this.addScolarshipBtn.Click += new System.EventHandler(this.addScolarshipBtn_Click);
            // 
            // enteredNameTb
            // 
            this.enteredNameTb.Location = new System.Drawing.Point(472, 67);
            this.enteredNameTb.Name = "enteredNameTb";
            this.enteredNameTb.Size = new System.Drawing.Size(186, 22);
            this.enteredNameTb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(73, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Списък с имена на студенти";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(481, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Списък със стипендии";
            // 
            // namesListBox
            // 
            this.namesListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.namesListBox.FormattingEnabled = true;
            this.namesListBox.ItemHeight = 16;
            this.namesListBox.Location = new System.Drawing.Point(76, 320);
            this.namesListBox.Name = "namesListBox";
            this.namesListBox.Size = new System.Drawing.Size(218, 180);
            this.namesListBox.TabIndex = 5;
            // 
            // scolarshipsListBox
            // 
            this.scolarshipsListBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.scolarshipsListBox.FormattingEnabled = true;
            this.scolarshipsListBox.ItemHeight = 16;
            this.scolarshipsListBox.Location = new System.Drawing.Point(484, 320);
            this.scolarshipsListBox.Name = "scolarshipsListBox";
            this.scolarshipsListBox.Size = new System.Drawing.Size(218, 180);
            this.scolarshipsListBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 527);
            this.Controls.Add(this.scolarshipsListBox);
            this.Controls.Add(this.namesListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enteredNameTb);
            this.Controls.Add(this.addScolarshipBtn);
            this.Controls.Add(this.addNameBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNameBtn;
        private System.Windows.Forms.Button addScolarshipBtn;
        private System.Windows.Forms.TextBox enteredNameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox namesListBox;
        private System.Windows.Forms.ListBox scolarshipsListBox;
    }
}


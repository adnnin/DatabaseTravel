namespace BD_Travel_dot_net_4_7
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.Passpdata = new System.Windows.Forms.TextBox();
            this.Kids = new System.Windows.Forms.CheckBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FIO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Паспортные данные";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Passpdata
            // 
            this.Passpdata.Location = new System.Drawing.Point(169, 83);
            this.Passpdata.Name = "Passpdata";
            this.Passpdata.Size = new System.Drawing.Size(192, 20);
            this.Passpdata.TabIndex = 5;
            // 
            // Kids
            // 
            this.Kids.AutoSize = true;
            this.Kids.Location = new System.Drawing.Point(172, 115);
            this.Kids.Name = "Kids";
            this.Kids.Size = new System.Drawing.Size(101, 17);
            this.Kids.TabIndex = 6;
            this.Kids.Text = "Наличие детей";
            this.Kids.UseVisualStyleBackColor = true;
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(169, 23);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(192, 20);
            this.Id.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Id";
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(168, 56);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(193, 20);
            this.FIO.TabIndex = 9;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 272);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Kids);
            this.Controls.Add(this.Passpdata);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Добавить Туриста";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Passpdata;
        private System.Windows.Forms.CheckBox Kids;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FIO;
    }
}
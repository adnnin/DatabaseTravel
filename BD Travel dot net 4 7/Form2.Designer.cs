namespace BD_Travel_dot_net_4_7
{
    partial class Form2
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
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.турфирмаDataSet1 = new BD_Travel_dot_net_4_7.ТурфирмаDataSet();
            this.ComboFIO = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboTyr = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpFinish = new System.Windows.Forms.DateTimePicker();
            this.CountryTour = new System.Windows.Forms.TextBox();
            this.MestoProjiv = new System.Windows.Forms.TextBox();
            this.Org_pit = new System.Windows.Forms.TextBox();
            this.Org_eks = new System.Windows.Forms.TextBox();
            this.dostavka = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.турфирмаDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(113, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите данные для оформления заказа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Выберите туриста:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(325, 62);
            this.button1.TabIndex = 8;
            this.button1.Text = "Оформить заказ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // турфирмаDataSet1
            // 
            this.турфирмаDataSet1.DataSetName = "ТурфирмаDataSet";
            this.турфирмаDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ComboFIO
            // 
            this.ComboFIO.FormattingEnabled = true;
            this.ComboFIO.Location = new System.Drawing.Point(281, 129);
            this.ComboFIO.Name = "ComboFIO";
            this.ComboFIO.Size = new System.Drawing.Size(319, 21);
            this.ComboFIO.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Выберите тур:";
            // 
            // ComboTyr
            // 
            this.ComboTyr.FormattingEnabled = true;
            this.ComboTyr.Location = new System.Drawing.Point(281, 102);
            this.ComboTyr.Name = "ComboTyr";
            this.ComboTyr.Size = new System.Drawing.Size(319, 21);
            this.ComboTyr.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Дата начала:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Дата окончания:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Страна тура:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Место проживания:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Организация питания:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Организация экскурсий:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(73, 322);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Способ доставки к месту экскурсии:";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(281, 156);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(319, 20);
            this.dtpStart.TabIndex = 26;
            // 
            // dtpFinish
            // 
            this.dtpFinish.Location = new System.Drawing.Point(281, 182);
            this.dtpFinish.Name = "dtpFinish";
            this.dtpFinish.Size = new System.Drawing.Size(319, 20);
            this.dtpFinish.TabIndex = 27;
            // 
            // CountryTour
            // 
            this.CountryTour.Location = new System.Drawing.Point(281, 208);
            this.CountryTour.Name = "CountryTour";
            this.CountryTour.Size = new System.Drawing.Size(319, 20);
            this.CountryTour.TabIndex = 28;
            // 
            // MestoProjiv
            // 
            this.MestoProjiv.Location = new System.Drawing.Point(281, 237);
            this.MestoProjiv.Name = "MestoProjiv";
            this.MestoProjiv.Size = new System.Drawing.Size(319, 20);
            this.MestoProjiv.TabIndex = 29;
            // 
            // Org_pit
            // 
            this.Org_pit.Location = new System.Drawing.Point(281, 263);
            this.Org_pit.Name = "Org_pit";
            this.Org_pit.Size = new System.Drawing.Size(319, 20);
            this.Org_pit.TabIndex = 30;
            // 
            // Org_eks
            // 
            this.Org_eks.Location = new System.Drawing.Point(281, 289);
            this.Org_eks.Name = "Org_eks";
            this.Org_eks.Size = new System.Drawing.Size(319, 20);
            this.Org_eks.TabIndex = 31;
            // 
            // dostavka
            // 
            this.dostavka.Location = new System.Drawing.Point(281, 315);
            this.dostavka.Name = "dostavka";
            this.dostavka.Size = new System.Drawing.Size(319, 20);
            this.dostavka.TabIndex = 32;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 508);
            this.Controls.Add(this.dostavka);
            this.Controls.Add(this.Org_eks);
            this.Controls.Add(this.Org_pit);
            this.Controls.Add(this.MestoProjiv);
            this.Controls.Add(this.CountryTour);
            this.Controls.Add(this.dtpFinish);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboTyr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ComboFIO);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Заказ";
            ((System.ComponentModel.ISupportInitialize)(this.турфирмаDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ТурфирмаDataSet турфирмаDataSet1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ComboFIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboTyr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpFinish;
        private System.Windows.Forms.TextBox CountryTour;
        private System.Windows.Forms.TextBox MestoProjiv;
        private System.Windows.Forms.TextBox Org_pit;
        private System.Windows.Forms.TextBox Org_eks;
        private System.Windows.Forms.TextBox dostavka;
    }
}
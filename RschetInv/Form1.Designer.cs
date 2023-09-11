namespace RschetInv
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label8 = new Label();
            pogrBox = new ComboBox();
            panel3 = new Panel();
            label6 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            summa = new Label();
            tm = new Label();
            label3 = new Label();
            time = new Label();
            edchTxt = new TextBox();
            timeTxt = new TextBox();
            ostTxt = new TextBox();
            button1 = new Button();
            brandCombo = new ComboBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            radioButton1 = new RadioButton();
            panel4 = new Panel();
            label9 = new Label();
            label10 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Cursor = Cursors.Hand;
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(529, 507);
            tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(radioButton1);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(pogrBox);
            tabPage1.Controls.Add(panel3);
            tabPage1.Controls.Add(panel2);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(tm);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(time);
            tabPage1.Controls.Add(edchTxt);
            tabPage1.Controls.Add(timeTxt);
            tabPage1.Controls.Add(ostTxt);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(brandCombo);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(521, 479);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Двойное сканирование";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(40, 226);
            label8.Name = "label8";
            label8.Size = new Size(116, 21);
            label8.TabIndex = 26;
            label8.Text = "Погрешность";
            label8.Visible = false;
            // 
            // pogrBox
            // 
            pogrBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pogrBox.FormattingEnabled = true;
            pogrBox.Items.AddRange(new object[] { "0.1", "0.15", "0.2", "0.33" });
            pogrBox.Location = new Point(40, 265);
            pogrBox.Name = "pogrBox";
            pogrBox.Size = new Size(62, 29);
            pogrBox.TabIndex = 25;
            pogrBox.Visible = false;
            pogrBox.SelectedIndexChanged += pogrBox_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Cyan;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(281, 265);
            panel3.Name = "panel3";
            panel3.Size = new Size(198, 90);
            panel3.TabIndex = 24;
            panel3.Paint += panel3_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(77, 14);
            label6.Name = "label6";
            label6.Size = new Size(42, 21);
            label6.TabIndex = 22;
            label6.Text = "НОТ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.MintCream;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(91, 56);
            label7.Name = "label7";
            label7.Size = new Size(0, 25);
            label7.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cyan;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(281, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(198, 90);
            panel2.TabIndex = 23;
            panel2.Paint += panel2_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(35, 22);
            label4.Name = "label4";
            label4.Size = new Size(134, 21);
            label4.TabIndex = 22;
            label4.Text = "Без округления";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MintCream;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(91, 56);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(summa);
            panel1.Location = new Point(281, 167);
            panel1.Name = "panel1";
            panel1.Size = new Size(198, 90);
            panel1.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(35, 23);
            label2.Name = "label2";
            label2.Size = new Size(143, 21);
            label2.TabIndex = 22;
            label2.Text = "Количество Инв.";
            // 
            // summa
            // 
            summa.AutoSize = true;
            summa.BackColor = Color.MintCream;
            summa.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            summa.ForeColor = Color.Black;
            summa.Location = new Point(91, 56);
            summa.Name = "summa";
            summa.Size = new Size(0, 25);
            summa.TabIndex = 21;
            // 
            // tm
            // 
            tm.AutoSize = true;
            tm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tm.Location = new Point(292, 10);
            tm.Name = "tm";
            tm.Size = new Size(65, 21);
            tm.TabIndex = 18;
            tm.Text = "Бизнес";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(40, 141);
            label3.Name = "label3";
            label3.Size = new Size(45, 21);
            label3.TabIndex = 17;
            label3.Text = "Ед.Ч";
            label3.Visible = false;
            // 
            // time
            // 
            time.AutoSize = true;
            time.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            time.Location = new Point(40, 71);
            time.Name = "time";
            time.Size = new Size(60, 21);
            time.TabIndex = 16;
            time.Text = "Время";
            // 
            // edchTxt
            // 
            edchTxt.Cursor = Cursors.IBeam;
            edchTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            edchTxt.Location = new Point(40, 165);
            edchTxt.Name = "edchTxt";
            edchTxt.Size = new Size(196, 29);
            edchTxt.TabIndex = 15;
            edchTxt.Visible = false;
            edchTxt.TextChanged += edchTxt_TextChanged;
            edchTxt.KeyPress += edchTxt_KeyPress;
            // 
            // timeTxt
            // 
            timeTxt.Cursor = Cursors.IBeam;
            timeTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            timeTxt.Location = new Point(40, 95);
            timeTxt.Name = "timeTxt";
            timeTxt.Size = new Size(196, 29);
            timeTxt.TabIndex = 14;
            timeTxt.TextAlign = HorizontalAlignment.Center;
            timeTxt.KeyPress += timeTxt_KeyPress;
            // 
            // ostTxt
            // 
            ostTxt.Cursor = Cursors.IBeam;
            ostTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ostTxt.Location = new Point(40, 34);
            ostTxt.Name = "ostTxt";
            ostTxt.Size = new Size(196, 29);
            ostTxt.TabIndex = 13;
            ostTxt.TextAlign = HorizontalAlignment.Center;
            ostTxt.TextChanged += ostTxt_TextChanged;
            ostTxt.KeyPress += ostTxt_KeyPress;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(40, 361);
            button1.Name = "button1";
            button1.Size = new Size(196, 90);
            button1.TabIndex = 12;
            button1.Text = "Расчет";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // brandCombo
            // 
            brandCombo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            brandCombo.FormattingEnabled = true;
            brandCombo.Items.AddRange(new object[] { "Спортмастер", "Фандей", "Остин", "Дэмикс", "Урбан вайб", "Другое" });
            brandCombo.Location = new Point(281, 36);
            brandCombo.Name = "brandCombo";
            brandCombo.Size = new Size(198, 29);
            brandCombo.TabIndex = 11;
            brandCombo.SelectedIndexChanged += brandCombo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 10);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 10;
            label1.Text = "Остаток";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(514, 430);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Пересчет";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(40, 322);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(118, 25);
            radioButton1.TabIndex = 27;
            radioButton1.TabStop = true;
            radioButton1.Text = "Аутсорсинг";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Visible = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Cyan;
            panel4.Controls.Add(label9);
            panel4.Controls.Add(label10);
            panel4.Location = new Point(281, 361);
            panel4.Name = "panel4";
            panel4.Size = new Size(198, 90);
            panel4.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(44, 12);
            label9.Name = "label9";
            label9.Size = new Size(100, 21);
            label9.TabIndex = 22;
            label9.Text = "Аутсорсинг";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.MintCream;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(91, 56);
            label10.Name = "label10";
            label10.Size = new Size(0, 25);
            label10.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 507);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Калькулятор инвентаризаторов";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label tm;
        private Label label3;
        private Label time;
        private TextBox edchTxt;
        private TextBox timeTxt;
        private TextBox ostTxt;
        private Button button1;
        private ComboBox brandCombo;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label summa;
        private Panel panel2;
        private Label label4;
        private Label label5;
        private Panel panel3;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox pogrBox;
        private Panel panel4;
        private Label label9;
        private Label label10;
        private RadioButton radioButton1;
    }
}
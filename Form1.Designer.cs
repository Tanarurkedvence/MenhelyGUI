namespace MenhelyGUI
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            allapot = new Label();
            nem = new Label();
            suly = new Label();
            nev = new Label();
            akivalasztott = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            fajta = new Label();
            kor = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 30);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Fajta:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(473, 82);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Név:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(473, 117);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 2;
            label3.Text = "Fajta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(473, 152);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 3;
            label4.Text = "Kor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(473, 192);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 4;
            label5.Text = "Súly";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(473, 237);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 5;
            label6.Text = "Nem:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(473, 276);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 6;
            label7.Text = "Állapot:";
            // 
            // allapot
            // 
            allapot.AutoSize = true;
            allapot.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            allapot.Location = new Point(587, 276);
            allapot.Name = "allapot";
            allapot.Size = new Size(0, 15);
            allapot.TabIndex = 7;
            // 
            // nem
            // 
            nem.AutoSize = true;
            nem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            nem.Location = new Point(587, 237);
            nem.Name = "nem";
            nem.Size = new Size(0, 15);
            nem.TabIndex = 12;
            // 
            // suly
            // 
            suly.AutoSize = true;
            suly.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            suly.Location = new Point(587, 192);
            suly.Name = "suly";
            suly.Size = new Size(0, 15);
            suly.TabIndex = 11;
            // 
            // nev
            // 
            nev.AutoSize = true;
            nev.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            nev.Location = new Point(587, 82);
            nev.Name = "nev";
            nev.Size = new Size(0, 15);
            nev.TabIndex = 8;
            // 
            // akivalasztott
            // 
            akivalasztott.AutoSize = true;
            akivalasztott.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            akivalasztott.Location = new Point(473, 30);
            akivalasztott.Name = "akivalasztott";
            akivalasztott.Size = new Size(161, 21);
            akivalasztott.TabIndex = 13;
            akivalasztott.Text = "A kiválasztott kutya";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(27, 132);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(271, 274);
            listBox1.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(392, 339);
            button1.Name = "button1";
            button1.Size = new Size(226, 67);
            button1.TabIndex = 15;
            button1.Text = "Örökbefogadás";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(95, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 16;
            comboBox1.Text = "Összesen";
            // 
            // fajta
            // 
            fajta.AutoSize = true;
            fajta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            fajta.Location = new Point(587, 117);
            fajta.Name = "fajta";
            fajta.Size = new Size(0, 15);
            fajta.TabIndex = 17;
            // 
            // kor
            // 
            kor.AutoSize = true;
            kor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kor.Location = new Point(587, 152);
            kor.Name = "kor";
            kor.Size = new Size(0, 15);
            kor.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 465);
            Controls.Add(kor);
            Controls.Add(fajta);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(akivalasztott);
            Controls.Add(nem);
            Controls.Add(suly);
            Controls.Add(nev);
            Controls.Add(allapot);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Mancs Menhely";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label allapot;
        private Label nem;
        private Label suly;
        private Label label11;
        private Label label12;
        private Label nev;
        private Label akivalasztott;
        private ListBox listBox1;
        private Button button1;
        private ComboBox comboBox1;
        private Label fajta;
        private Label kor;
    }
}

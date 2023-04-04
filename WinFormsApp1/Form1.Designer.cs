namespace WinFormsApp1
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
            this.button1Input = new System.Windows.Forms.Button();
            this.textBox1Name = new System.Windows.Forms.TextBox();
            this.button2Output = new System.Windows.Forms.Button();
            this.label1Nick = new System.Windows.Forms.Label();
            this.buttonLabel = new System.Windows.Forms.Button();
            this.buttonBoxEkle = new System.Windows.Forms.Button();
            this.listBox1NickVolume = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonComboEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonMesajYaz = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1Volume = new System.Windows.Forms.Button();
            this.trackBar1Ses = new System.Windows.Forms.TrackBar();
            this.groupBox2List1 = new System.Windows.Forms.GroupBox();
            this.checkBox3Zeytin = new System.Windows.Forms.CheckBox();
            this.checkBox2Domates = new System.Windows.Forms.CheckBox();
            this.checkBox1Marul = new System.Windows.Forms.CheckBox();
            this.groupBox3List2 = new System.Windows.Forms.GroupBox();
            this.radioButton3Zeytin = new System.Windows.Forms.RadioButton();
            this.radioButton2Domates = new System.Windows.Forms.RadioButton();
            this.radioButton1Marul = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1Ses)).BeginInit();
            this.groupBox2List1.SuspendLayout();
            this.groupBox3List2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1Input
            // 
            this.button1Input.Location = new System.Drawing.Point(545, 208);
            this.button1Input.Name = "button1Input";
            this.button1Input.Size = new System.Drawing.Size(150, 37);
            this.button1Input.TabIndex = 0;
            this.button1Input.Text = "Input";
            this.button1Input.UseVisualStyleBackColor = true;
            this.button1Input.Click += new System.EventHandler(this.button1Input_Click);
            // 
            // textBox1Name
            // 
            this.textBox1Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBox1Name.Location = new System.Drawing.Point(589, 251);
            this.textBox1Name.Name = "textBox1Name";
            this.textBox1Name.Size = new System.Drawing.Size(235, 27);
            this.textBox1Name.TabIndex = 1;
            this.textBox1Name.TextChanged += new System.EventHandler(this.textBox1Name_TextChanged);
            // 
            // button2Output
            // 
            this.button2Output.Location = new System.Drawing.Point(724, 208);
            this.button2Output.Name = "button2Output";
            this.button2Output.Size = new System.Drawing.Size(150, 37);
            this.button2Output.TabIndex = 2;
            this.button2Output.Text = "Output";
            this.button2Output.UseVisualStyleBackColor = true;
            this.button2Output.Click += new System.EventHandler(this.button2Output_Click);
            // 
            // label1Nick
            // 
            this.label1Nick.AutoSize = true;
            this.label1Nick.Location = new System.Drawing.Point(89, 15);
            this.label1Nick.Name = "label1Nick";
            this.label1Nick.Size = new System.Drawing.Size(50, 20);
            this.label1Nick.TabIndex = 3;
            this.label1Nick.Text = "label1";
            this.label1Nick.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonLabel
            // 
            this.buttonLabel.Location = new System.Drawing.Point(37, 61);
            this.buttonLabel.Name = "buttonLabel";
            this.buttonLabel.Size = new System.Drawing.Size(155, 35);
            this.buttonLabel.TabIndex = 4;
            this.buttonLabel.Text = "DenemeLabel";
            this.buttonLabel.UseVisualStyleBackColor = true;
            this.buttonLabel.Click += new System.EventHandler(this.buttonLabel_Click);
            // 
            // buttonBoxEkle
            // 
            this.buttonBoxEkle.Location = new System.Drawing.Point(37, 220);
            this.buttonBoxEkle.Name = "buttonBoxEkle";
            this.buttonBoxEkle.Size = new System.Drawing.Size(155, 33);
            this.buttonBoxEkle.TabIndex = 5;
            this.buttonBoxEkle.Text = "Box Ekle";
            this.buttonBoxEkle.UseVisualStyleBackColor = true;
            this.buttonBoxEkle.Click += new System.EventHandler(this.buttonBoxEkle_Click);
            // 
            // listBox1NickVolume
            // 
            this.listBox1NickVolume.FormattingEnabled = true;
            this.listBox1NickVolume.ItemHeight = 20;
            this.listBox1NickVolume.Location = new System.Drawing.Point(37, 340);
            this.listBox1NickVolume.Name = "listBox1NickVolume";
            this.listBox1NickVolume.Size = new System.Drawing.Size(155, 104);
            this.listBox1NickVolume.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.comboBox1.Location = new System.Drawing.Point(37, 259);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonComboEkle
            // 
            this.buttonComboEkle.Location = new System.Drawing.Point(37, 293);
            this.buttonComboEkle.Name = "buttonComboEkle";
            this.buttonComboEkle.Size = new System.Drawing.Size(155, 34);
            this.buttonComboEkle.TabIndex = 8;
            this.buttonComboEkle.Text = "Combo Ekle";
            this.buttonComboEkle.UseVisualStyleBackColor = true;
            this.buttonComboEkle.Click += new System.EventHandler(this.buttonComboEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonMesajYaz);
            this.groupBox1.Controls.Add(this.buttonSil);
            this.groupBox1.Location = new System.Drawing.Point(599, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 176);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler Kısayol";
            // 
            // buttonMesajYaz
            // 
            this.buttonMesajYaz.Location = new System.Drawing.Point(16, 46);
            this.buttonMesajYaz.Name = "buttonMesajYaz";
            this.buttonMesajYaz.Size = new System.Drawing.Size(135, 47);
            this.buttonMesajYaz.TabIndex = 1;
            this.buttonMesajYaz.Text = "Mesaj Yaz";
            this.buttonMesajYaz.UseVisualStyleBackColor = true;
            this.buttonMesajYaz.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(16, 109);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(135, 47);
            this.buttonSil.TabIndex = 0;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.button1Volume);
            this.panel1.Controls.Add(this.trackBar1Ses);
            this.panel1.Controls.Add(this.listBox1NickVolume);
            this.panel1.Controls.Add(this.buttonComboEkle);
            this.panel1.Controls.Add(this.buttonLabel);
            this.panel1.Controls.Add(this.buttonBoxEkle);
            this.panel1.Controls.Add(this.label1Nick);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(880, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 461);
            this.panel1.TabIndex = 10;
            // 
            // button1Volume
            // 
            this.button1Volume.Location = new System.Drawing.Point(37, 109);
            this.button1Volume.Name = "button1Volume";
            this.button1Volume.Size = new System.Drawing.Size(155, 34);
            this.button1Volume.TabIndex = 14;
            this.button1Volume.Text = "button1";
            this.button1Volume.UseVisualStyleBackColor = true;
            this.button1Volume.Click += new System.EventHandler(this.button1Volume_Click);
            // 
            // trackBar1Ses
            // 
            this.trackBar1Ses.BackColor = System.Drawing.Color.DimGray;
            this.trackBar1Ses.Location = new System.Drawing.Point(37, 158);
            this.trackBar1Ses.Maximum = 100;
            this.trackBar1Ses.Name = "trackBar1Ses";
            this.trackBar1Ses.Size = new System.Drawing.Size(155, 56);
            this.trackBar1Ses.TabIndex = 13;
            this.trackBar1Ses.Scroll += new System.EventHandler(this.trackBar1Ses_Scroll);
            // 
            // groupBox2List1
            // 
            this.groupBox2List1.Controls.Add(this.checkBox3Zeytin);
            this.groupBox2List1.Controls.Add(this.checkBox2Domates);
            this.groupBox2List1.Controls.Add(this.checkBox1Marul);
            this.groupBox2List1.Location = new System.Drawing.Point(545, 302);
            this.groupBox2List1.Name = "groupBox2List1";
            this.groupBox2List1.Size = new System.Drawing.Size(134, 154);
            this.groupBox2List1.TabIndex = 11;
            this.groupBox2List1.TabStop = false;
            this.groupBox2List1.Text = "List1";
            // 
            // checkBox3Zeytin
            // 
            this.checkBox3Zeytin.AutoSize = true;
            this.checkBox3Zeytin.Location = new System.Drawing.Point(15, 105);
            this.checkBox3Zeytin.Name = "checkBox3Zeytin";
            this.checkBox3Zeytin.Size = new System.Drawing.Size(72, 24);
            this.checkBox3Zeytin.TabIndex = 2;
            this.checkBox3Zeytin.Text = "Zeytin";
            this.checkBox3Zeytin.UseVisualStyleBackColor = true;
            // 
            // checkBox2Domates
            // 
            this.checkBox2Domates.AutoSize = true;
            this.checkBox2Domates.Location = new System.Drawing.Point(15, 75);
            this.checkBox2Domates.Name = "checkBox2Domates";
            this.checkBox2Domates.Size = new System.Drawing.Size(91, 24);
            this.checkBox2Domates.TabIndex = 1;
            this.checkBox2Domates.Text = "Domates";
            this.checkBox2Domates.UseVisualStyleBackColor = true;
            // 
            // checkBox1Marul
            // 
            this.checkBox1Marul.AutoSize = true;
            this.checkBox1Marul.Location = new System.Drawing.Point(15, 45);
            this.checkBox1Marul.Name = "checkBox1Marul";
            this.checkBox1Marul.Size = new System.Drawing.Size(69, 24);
            this.checkBox1Marul.TabIndex = 0;
            this.checkBox1Marul.Text = "Marul";
            this.checkBox1Marul.UseVisualStyleBackColor = true;
            // 
            // groupBox3List2
            // 
            this.groupBox3List2.Controls.Add(this.radioButton3Zeytin);
            this.groupBox3List2.Controls.Add(this.radioButton2Domates);
            this.groupBox3List2.Controls.Add(this.radioButton1Marul);
            this.groupBox3List2.Location = new System.Drawing.Point(724, 305);
            this.groupBox3List2.Name = "groupBox3List2";
            this.groupBox3List2.Size = new System.Drawing.Size(134, 154);
            this.groupBox3List2.TabIndex = 12;
            this.groupBox3List2.TabStop = false;
            this.groupBox3List2.Text = "List2";
            // 
            // radioButton3Zeytin
            // 
            this.radioButton3Zeytin.AutoSize = true;
            this.radioButton3Zeytin.Location = new System.Drawing.Point(11, 102);
            this.radioButton3Zeytin.Name = "radioButton3Zeytin";
            this.radioButton3Zeytin.Size = new System.Drawing.Size(71, 24);
            this.radioButton3Zeytin.TabIndex = 2;
            this.radioButton3Zeytin.TabStop = true;
            this.radioButton3Zeytin.Text = "Zeytin";
            this.radioButton3Zeytin.UseVisualStyleBackColor = true;
            this.radioButton3Zeytin.CheckedChanged += new System.EventHandler(this.radioButton3Zeytin_CheckedChanged);
            // 
            // radioButton2Domates
            // 
            this.radioButton2Domates.AutoSize = true;
            this.radioButton2Domates.Location = new System.Drawing.Point(11, 72);
            this.radioButton2Domates.Name = "radioButton2Domates";
            this.radioButton2Domates.Size = new System.Drawing.Size(90, 24);
            this.radioButton2Domates.TabIndex = 1;
            this.radioButton2Domates.TabStop = true;
            this.radioButton2Domates.Text = "Domates";
            this.radioButton2Domates.UseVisualStyleBackColor = true;
            this.radioButton2Domates.CheckedChanged += new System.EventHandler(this.radioButton2Domates_CheckedChanged);
            // 
            // radioButton1Marul
            // 
            this.radioButton1Marul.AutoSize = true;
            this.radioButton1Marul.Location = new System.Drawing.Point(11, 42);
            this.radioButton1Marul.Name = "radioButton1Marul";
            this.radioButton1Marul.Size = new System.Drawing.Size(68, 24);
            this.radioButton1Marul.TabIndex = 0;
            this.radioButton1Marul.TabStop = true;
            this.radioButton1Marul.Text = "Marul";
            this.radioButton1Marul.UseVisualStyleBackColor = true;
            this.radioButton1Marul.CheckedChanged += new System.EventHandler(this.radioButton1Marul_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1114, 485);
            this.Controls.Add(this.groupBox3List2);
            this.Controls.Add(this.groupBox2List1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2Output);
            this.Controls.Add(this.textBox1Name);
            this.Controls.Add(this.button1Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1Ses)).EndInit();
            this.groupBox2List1.ResumeLayout(false);
            this.groupBox2List1.PerformLayout();
            this.groupBox3List2.ResumeLayout(false);
            this.groupBox3List2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1Input;
        private TextBox textBox1Name;
        private Button button2Output;
        private Label label1Nick;
        private Button buttonLabel;
        private Button buttonBoxEkle;
        private ListBox listBox1NickVolume;
        private ComboBox comboBox1;
        private Button buttonComboEkle;
        private GroupBox groupBox1;
        private Button buttonMesajYaz;
        private Button buttonSil;
        private Panel panel1;
        private GroupBox groupBox2List1;
        private CheckBox checkBox3Zeytin;
        private CheckBox checkBox2Domates;
        private CheckBox checkBox1Marul;
        private GroupBox groupBox3List2;
        private RadioButton radioButton3Zeytin;
        private RadioButton radioButton2Domates;
        private RadioButton radioButton1Marul;
        private TrackBar trackBar1Ses;
        private Button button1Volume;
    }
}
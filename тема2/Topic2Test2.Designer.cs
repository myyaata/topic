﻿using static тема_1.Form1;
using static тема2.MainWindow;

namespace тема2
{
    partial class Topic2Test2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Topic2Test2));
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button2 = new RoundButton();
            groupBox1 = new RoundedGroupBox();
            roundedPanel9 = new RoundedPanel();
            roundedPanel8 = new RoundedPanel();
            roundedPanel7 = new RoundedPanel();
            roundedPanel6 = new RoundedPanel();
            roundedPanel5 = new RoundedPanel();
            roundedPanel4 = new RoundedPanel();
            roundedPanel3 = new RoundedPanel();
            roundedPanel2 = new RoundedPanel();
            roundedPanel1 = new RoundedPanel();
            roundedPanel10 = new RoundedPanel();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label3 = new Label();
            Button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.Location = new Point(460, 516);
            button3.Name = "button3";
            button3.Size = new Size(198, 46);
            button3.TabIndex = 17;
            button3.Text = "Перейти к тесту 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.YellowGreen;
            button2.Font = new Font("Times New Roman", 13.875F);
            button2.ForeColor = Color.FromArgb(64, 64, 64);
            button2.Location = new Point(482, 330);
            button2.Name = "button2";
            button2.Size = new Size(207, 61);
            button2.TabIndex = 16;
            button2.Text = "Вперед";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(roundedPanel9);
            groupBox1.Controls.Add(roundedPanel8);
            groupBox1.Controls.Add(roundedPanel7);
            groupBox1.Controls.Add(roundedPanel6);
            groupBox1.Controls.Add(roundedPanel5);
            groupBox1.Controls.Add(roundedPanel4);
            groupBox1.Controls.Add(roundedPanel3);
            groupBox1.Controls.Add(roundedPanel2);
            groupBox1.Controls.Add(roundedPanel1);
            groupBox1.Controls.Add(roundedPanel10);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label3);
            groupBox1.CornerRadius = 60;
            groupBox1.Location = new Point(168, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(730, 404);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // roundedPanel9
            // 
            roundedPanel9.BackColor = Color.Silver;
            roundedPanel9.CornerRadius = 20;
            roundedPanel9.ForeColor = SystemColors.AppWorkspace;
            roundedPanel9.Location = new Point(562, 42);
            roundedPanel9.Margin = new Padding(2, 2, 2, 2);
            roundedPanel9.Name = "roundedPanel9";
            roundedPanel9.Size = new Size(49, 12);
            roundedPanel9.TabIndex = 26;
            // 
            // roundedPanel8
            // 
            roundedPanel8.BackColor = Color.Silver;
            roundedPanel8.CornerRadius = 20;
            roundedPanel8.ForeColor = SystemColors.AppWorkspace;
            roundedPanel8.Location = new Point(503, 42);
            roundedPanel8.Margin = new Padding(2, 2, 2, 2);
            roundedPanel8.Name = "roundedPanel8";
            roundedPanel8.Size = new Size(49, 12);
            roundedPanel8.TabIndex = 25;
            // 
            // roundedPanel7
            // 
            roundedPanel7.BackColor = Color.Silver;
            roundedPanel7.CornerRadius = 20;
            roundedPanel7.ForeColor = SystemColors.AppWorkspace;
            roundedPanel7.Location = new Point(445, 42);
            roundedPanel7.Margin = new Padding(2, 2, 2, 2);
            roundedPanel7.Name = "roundedPanel7";
            roundedPanel7.Size = new Size(49, 12);
            roundedPanel7.TabIndex = 24;
            // 
            // roundedPanel6
            // 
            roundedPanel6.BackColor = Color.Silver;
            roundedPanel6.CornerRadius = 20;
            roundedPanel6.ForeColor = SystemColors.AppWorkspace;
            roundedPanel6.Location = new Point(386, 42);
            roundedPanel6.Margin = new Padding(2, 2, 2, 2);
            roundedPanel6.Name = "roundedPanel6";
            roundedPanel6.Size = new Size(49, 12);
            roundedPanel6.TabIndex = 23;
            // 
            // roundedPanel5
            // 
            roundedPanel5.BackColor = Color.Silver;
            roundedPanel5.CornerRadius = 20;
            roundedPanel5.ForeColor = SystemColors.AppWorkspace;
            roundedPanel5.Location = new Point(328, 42);
            roundedPanel5.Margin = new Padding(2, 2, 2, 2);
            roundedPanel5.Name = "roundedPanel5";
            roundedPanel5.Size = new Size(49, 12);
            roundedPanel5.TabIndex = 22;
            // 
            // roundedPanel4
            // 
            roundedPanel4.BackColor = Color.Silver;
            roundedPanel4.CornerRadius = 20;
            roundedPanel4.ForeColor = SystemColors.AppWorkspace;
            roundedPanel4.Location = new Point(270, 42);
            roundedPanel4.Margin = new Padding(2, 2, 2, 2);
            roundedPanel4.Name = "roundedPanel4";
            roundedPanel4.Size = new Size(49, 12);
            roundedPanel4.TabIndex = 21;
            // 
            // roundedPanel3
            // 
            roundedPanel3.BackColor = Color.Silver;
            roundedPanel3.CornerRadius = 20;
            roundedPanel3.ForeColor = SystemColors.AppWorkspace;
            roundedPanel3.Location = new Point(211, 42);
            roundedPanel3.Margin = new Padding(2, 2, 2, 2);
            roundedPanel3.Name = "roundedPanel3";
            roundedPanel3.Size = new Size(49, 12);
            roundedPanel3.TabIndex = 20;
            // 
            // roundedPanel2
            // 
            roundedPanel2.BackColor = Color.Silver;
            roundedPanel2.CornerRadius = 20;
            roundedPanel2.ForeColor = SystemColors.AppWorkspace;
            roundedPanel2.Location = new Point(153, 42);
            roundedPanel2.Margin = new Padding(2, 2, 2, 2);
            roundedPanel2.Name = "roundedPanel2";
            roundedPanel2.Size = new Size(49, 12);
            roundedPanel2.TabIndex = 19;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.Silver;
            roundedPanel1.CornerRadius = 20;
            roundedPanel1.ForeColor = SystemColors.AppWorkspace;
            roundedPanel1.Location = new Point(94, 42);
            roundedPanel1.Margin = new Padding(2, 2, 2, 2);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(49, 12);
            roundedPanel1.TabIndex = 18;
            // 
            // roundedPanel10
            // 
            roundedPanel10.BackColor = Color.Silver;
            roundedPanel10.CornerRadius = 20;
            roundedPanel10.ForeColor = SystemColors.AppWorkspace;
            roundedPanel10.Location = new Point(36, 42);
            roundedPanel10.Margin = new Padding(2, 2, 2, 2);
            roundedPanel10.Name = "roundedPanel10";
            roundedPanel10.Size = new Size(49, 12);
            roundedPanel10.TabIndex = 17;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Font = new Font("Times New Roman", 13.875F);
            radioButton2.ForeColor = Color.FromArgb(64, 64, 64);
            radioButton2.Location = new Point(36, 188);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(71, 31);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Нет";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Font = new Font("Times New Roman", 13.875F);
            radioButton1.ForeColor = Color.FromArgb(64, 64, 64);
            radioButton1.Location = new Point(36, 144);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(60, 31);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Да";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 13.875F);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(29, 70);
            label3.Name = "label3";
            label3.Size = new Size(639, 27);
            label3.TabIndex = 14;
            label3.Text = "Продолжаете ли Вы работать после окончания рабочего дня?";
            label3.Click += label3_Click;
            // 
            // Button1
            // 
            Button1.Location = new Point(446, 178);
            Button1.Name = "Button1";
            Button1.Size = new Size(193, 46);
            Button1.TabIndex = 13;
            Button1.Text = "Начать тест 2";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(490, 117);
            label2.Name = "label2";
            label2.Size = new Size(102, 22);
            label2.TabIndex = 12;
            label2.Text = "Тест 2 из 3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(382, 32);
            label1.Name = "label1";
            label1.Size = new Size(327, 22);
            label1.TabIndex = 11;
            label1.Text = "Тест №2: отбор персонала в IT-сфере";
            // 
            // Topic2Test2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1067, 614);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(groupBox1);
            Controls.Add(Button1);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Topic2Test2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Topic2Test2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button button3;
        private RoundButton button2;
        private RoundedGroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label3;
        private Button Button1;
        private Label label2;
        private Label label1;
		private RoundedPanel roundedPanel9;
		private RoundedPanel roundedPanel8;
		private RoundedPanel roundedPanel7;
		private RoundedPanel roundedPanel6;
		private RoundedPanel roundedPanel5;
		private RoundedPanel roundedPanel4;
		private RoundedPanel roundedPanel3;
		private RoundedPanel roundedPanel2;
		private RoundedPanel roundedPanel1;
		private RoundedPanel roundedPanel10;
	}
}
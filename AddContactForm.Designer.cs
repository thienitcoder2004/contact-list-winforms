﻿namespace contact_list_winforms
{
    partial class AddContactForm
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(359, 301);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Lưu";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(201, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(372, 27);
            textBox1.TabIndex = 2;
            textBox1.Text = "Họ Tên";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(201, 192);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(372, 27);
            textBox2.TabIndex = 3;
            textBox2.Text = "Số Điện Thoại";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(201, 249);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(372, 27);
            textBox3.TabIndex = 4;
            textBox3.Text = "Email";
            // 
            // AddContactForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "AddContactForm";
            Text = "AddContactForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
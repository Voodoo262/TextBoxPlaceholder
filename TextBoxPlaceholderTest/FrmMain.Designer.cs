﻿namespace Com.RjfTech.Common.UserInterface
{
    partial class FrmMain
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new Com.RjfTech.Common.UserInterface.TextBoxPlaceholder();
            this.textBox2 = new Com.RjfTech.Common.UserInterface.TextBoxPlaceholder();
            this.textBox3 = new Com.RjfTech.Common.UserInterface.TextBoxPlaceholder();
            this.textBox4 = new Com.RjfTech.Common.UserInterface.TextBoxPlaceholder();
            this.btnFocus = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.label1, 0, 1);
            this.tlpMain.Controls.Add(this.label2, 0, 2);
            this.tlpMain.Controls.Add(this.label3, 0, 3);
            this.tlpMain.Controls.Add(this.label4, 0, 4);
            this.tlpMain.Controls.Add(this.textBox1, 1, 1);
            this.tlpMain.Controls.Add(this.textBox2, 1, 2);
            this.tlpMain.Controls.Add(this.textBox3, 1, 3);
            this.tlpMain.Controls.Add(this.textBox4, 1, 4);
            this.tlpMain.Controls.Add(this.btnFocus, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 5;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMain.Size = new System.Drawing.Size(602, 267);
            this.tlpMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Initialize with Placeholder and No Text";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Initialize with Placeholder and Text";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Initialize with No Placeholder and No Text";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Initialize with No Placeholder and Text";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(304, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Placeholder = "Placeholder";
            this.textBox1.PlaceholderColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.Size = new System.Drawing.Size(295, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(304, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Placeholder = "Placeholder";
            this.textBox2.PlaceholderColor = System.Drawing.SystemColors.GrayText;
            this.textBox2.Size = new System.Drawing.Size(295, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Text";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox3.Location = new System.Drawing.Point(304, 175);
            this.textBox3.Name = "textBox3";
            this.textBox3.Placeholder = null;
            this.textBox3.PlaceholderColor = System.Drawing.SystemColors.GrayText;
            this.textBox3.Size = new System.Drawing.Size(295, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox4.Location = new System.Drawing.Point(304, 229);
            this.textBox4.Name = "textBox4";
            this.textBox4.Placeholder = null;
            this.textBox4.PlaceholderColor = System.Drawing.SystemColors.GrayText;
            this.textBox4.Size = new System.Drawing.Size(295, 20);
            this.textBox4.TabIndex = 8;
            // 
            // btnFocus
            // 
            this.btnFocus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFocus.AutoSize = true;
            this.tlpMain.SetColumnSpan(this.btnFocus, 2);
            this.btnFocus.Location = new System.Drawing.Point(196, 15);
            this.btnFocus.Name = "btnFocus";
            this.btnFocus.Size = new System.Drawing.Size(210, 23);
            this.btnFocus.TabIndex = 0;
            this.btnFocus.Text = "Initial focus, click to query textbox values";
            this.btnFocus.UseVisualStyleBackColor = true;
            this.btnFocus.Click += new System.EventHandler(this.btnFocus_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 267);
            this.Controls.Add(this.tlpMain);
            this.Name = "FrmMain";
            this.Text = "TextBoxPlaceholder Test";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private TextBoxPlaceholder textBox1;
        private TextBoxPlaceholder textBox2;
        private TextBoxPlaceholder textBox3;
        private TextBoxPlaceholder textBox4;
        private System.Windows.Forms.Button btnFocus;
    }
}


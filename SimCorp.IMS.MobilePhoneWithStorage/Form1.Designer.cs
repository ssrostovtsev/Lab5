﻿namespace SimCorp.IMS.MobilePhoneWithStorage {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.MessageListBox = new System.Windows.Forms.ListBox();
            this.SMSNumberComboBox = new System.Windows.Forms.ComboBox();
            this.SMSTextTextBox = new System.Windows.Forms.TextBox();
            this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ApplyFilterButton = new System.Windows.Forms.Button();
            this.OrCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddMessageButton = new System.Windows.Forms.Button();
            this.AddMessageTimer = new System.Windows.Forms.Timer(this.components);
            this.DeleteMessageTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MessageListBox
            // 
            this.MessageListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MessageListBox.FormattingEnabled = true;
            this.MessageListBox.Location = new System.Drawing.Point(0, 193);
            this.MessageListBox.Name = "MessageListBox";
            this.MessageListBox.Size = new System.Drawing.Size(543, 108);
            this.MessageListBox.TabIndex = 0;
            // 
            // SMSNumberComboBox
            // 
            this.SMSNumberComboBox.FormattingEnabled = true;
            this.SMSNumberComboBox.Location = new System.Drawing.Point(362, 12);
            this.SMSNumberComboBox.Name = "SMSNumberComboBox";
            this.SMSNumberComboBox.Size = new System.Drawing.Size(169, 21);
            this.SMSNumberComboBox.TabIndex = 1;
            // 
            // SMSTextTextBox
            // 
            this.SMSTextTextBox.Location = new System.Drawing.Point(362, 50);
            this.SMSTextTextBox.Name = "SMSTextTextBox";
            this.SMSTextTextBox.Size = new System.Drawing.Size(169, 20);
            this.SMSTextTextBox.TabIndex = 2;
            // 
            // FromDateTimePicker
            // 
            this.FromDateTimePicker.Location = new System.Drawing.Point(257, 88);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.FromDateTimePicker.TabIndex = 3;
            // 
            // ToDateTimePicker
            // 
            this.ToDateTimePicker.Location = new System.Drawing.Point(410, 88);
            this.ToDateTimePicker.Name = "ToDateTimePicker";
            this.ToDateTimePicker.Size = new System.Drawing.Size(121, 20);
            this.ToDateTimePicker.TabIndex = 4;
            // 
            // ApplyFilterButton
            // 
            this.ApplyFilterButton.Location = new System.Drawing.Point(224, 152);
            this.ApplyFilterButton.Name = "ApplyFilterButton";
            this.ApplyFilterButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyFilterButton.TabIndex = 5;
            this.ApplyFilterButton.Text = "Apply filter";
            this.ApplyFilterButton.UseVisualStyleBackColor = true;
            this.ApplyFilterButton.Click += new System.EventHandler(this.ApplyFilterButton_Click);
            // 
            // OrCheckBox
            // 
            this.OrCheckBox.AutoSize = true;
            this.OrCheckBox.Location = new System.Drawing.Point(224, 123);
            this.OrCheckBox.Name = "OrCheckBox";
            this.OrCheckBox.Size = new System.Drawing.Size(223, 17);
            this.OrCheckBox.TabIndex = 7;
            this.OrCheckBox.Text = "Use OR instead of AND in filter conditions";
            this.OrCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sender number starts with";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Message text contains";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "To";
            // 
            // AddMessageButton
            // 
            this.AddMessageButton.Location = new System.Drawing.Point(12, 10);
            this.AddMessageButton.Name = "AddMessageButton";
            this.AddMessageButton.Size = new System.Drawing.Size(75, 23);
            this.AddMessageButton.TabIndex = 12;
            this.AddMessageButton.Text = "Add msg";
            this.AddMessageButton.UseVisualStyleBackColor = true;
            this.AddMessageButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddMessageTimer
            // 
            this.AddMessageTimer.Enabled = true;
            this.AddMessageTimer.Interval = 5000;
            this.AddMessageTimer.Tick += new System.EventHandler(this.AddMessageTimer_Tick);
            // 
            // DeleteMessageTimer
            // 
            this.DeleteMessageTimer.Enabled = true;
            this.DeleteMessageTimer.Interval = 10000;
            this.DeleteMessageTimer.Tick += new System.EventHandler(this.DeleteMessageTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 301);
            this.Controls.Add(this.AddMessageButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrCheckBox);
            this.Controls.Add(this.ApplyFilterButton);
            this.Controls.Add(this.ToDateTimePicker);
            this.Controls.Add(this.FromDateTimePicker);
            this.Controls.Add(this.SMSTextTextBox);
            this.Controls.Add(this.SMSNumberComboBox);
            this.Controls.Add(this.MessageListBox);
            this.Name = "Form1";
            this.Text = "Mobile Phone with storage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MessageListBox;
        private System.Windows.Forms.ComboBox SMSNumberComboBox;
        private System.Windows.Forms.TextBox SMSTextTextBox;
        private System.Windows.Forms.DateTimePicker FromDateTimePicker;
        private System.Windows.Forms.DateTimePicker ToDateTimePicker;
        private System.Windows.Forms.Button ApplyFilterButton;
        private System.Windows.Forms.CheckBox OrCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddMessageButton;
        private System.Windows.Forms.Timer AddMessageTimer;
        private System.Windows.Forms.Timer DeleteMessageTimer;
    }
}


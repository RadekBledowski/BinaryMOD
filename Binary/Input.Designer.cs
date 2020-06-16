﻿namespace Binary
{
	partial class Input
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
			this.InputTextBox = new System.Windows.Forms.TextBox();
			this.InputLabel = new System.Windows.Forms.Label();
			this.InputButtonOK = new System.Windows.Forms.Button();
			this.InputButtonCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// InputTextBox
			// 
			this.InputTextBox.Location = new System.Drawing.Point(12, 32);
			this.InputTextBox.Name = "InputTextBox";
			this.InputTextBox.Size = new System.Drawing.Size(325, 23);
			this.InputTextBox.TabIndex = 0;
			// 
			// InputLabel
			// 
			this.InputLabel.AutoSize = true;
			this.InputLabel.Location = new System.Drawing.Point(12, 14);
			this.InputLabel.Name = "InputLabel";
			this.InputLabel.Size = new System.Drawing.Size(66, 15);
			this.InputLabel.TabIndex = 1;
			this.InputLabel.Text = "Input value";
			// 
			// InputButtonOK
			// 
			this.InputButtonOK.AutoSize = true;
			this.InputButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.InputButtonOK.Location = new System.Drawing.Point(143, 61);
			this.InputButtonOK.Name = "InputButtonOK";
			this.InputButtonOK.Size = new System.Drawing.Size(94, 25);
			this.InputButtonOK.TabIndex = 2;
			this.InputButtonOK.Text = "OK";
			this.InputButtonOK.UseVisualStyleBackColor = true;
			this.InputButtonOK.Click += new System.EventHandler(this.InputButtonOK_Click);
			// 
			// InputButtonCancel
			// 
			this.InputButtonCancel.AutoSize = true;
			this.InputButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.InputButtonCancel.Location = new System.Drawing.Point(243, 61);
			this.InputButtonCancel.Name = "InputButtonCancel";
			this.InputButtonCancel.Size = new System.Drawing.Size(94, 25);
			this.InputButtonCancel.TabIndex = 2;
			this.InputButtonCancel.Text = "Cancel";
			this.InputButtonCancel.UseVisualStyleBackColor = true;
			this.InputButtonCancel.Click += new System.EventHandler(this.InputButtonCancel_Click);
			// 
			// Input
			// 
			this.AcceptButton = this.InputButtonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.InputButtonCancel;
			this.ClientSize = new System.Drawing.Size(350, 97);
			this.Controls.Add(this.InputButtonCancel);
			this.Controls.Add(this.InputButtonOK);
			this.Controls.Add(this.InputLabel);
			this.Controls.Add(this.InputTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Input";
			this.Text = "Editor";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox InputTextBox;
		private System.Windows.Forms.Label InputLabel;
		private System.Windows.Forms.Button InputButtonOK;
		private System.Windows.Forms.Button InputButtonCancel;
	}
}
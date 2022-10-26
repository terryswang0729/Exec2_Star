namespace Exec2_Star
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.leftStarsButton = new System.Windows.Forms.Button();
			this.rowsLabel = new System.Windows.Forms.Label();
			this.rowsTextBox = new System.Windows.Forms.TextBox();
			this.midStarsButton = new System.Windows.Forms.Button();
			this.RightStarsButton = new System.Windows.Forms.Button();
			this.resultTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// leftStarsButton
			// 
			this.leftStarsButton.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.leftStarsButton.Location = new System.Drawing.Point(280, 57);
			this.leftStarsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.leftStarsButton.Name = "leftStarsButton";
			this.leftStarsButton.Size = new System.Drawing.Size(70, 33);
			this.leftStarsButton.TabIndex = 0;
			this.leftStarsButton.Text = "靠左星號";
			this.leftStarsButton.UseVisualStyleBackColor = true;
			this.leftStarsButton.Click += new System.EventHandler(this.leftStarsButton_Click);
			// 
			// rowsLabel
			// 
			this.rowsLabel.AutoSize = true;
			this.rowsLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.rowsLabel.Location = new System.Drawing.Point(55, 65);
			this.rowsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.rowsLabel.Name = "rowsLabel";
			this.rowsLabel.Size = new System.Drawing.Size(41, 20);
			this.rowsLabel.TabIndex = 1;
			this.rowsLabel.Text = "列數";
			// 
			// rowsTextBox
			// 
			this.rowsTextBox.Location = new System.Drawing.Point(98, 65);
			this.rowsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.rowsTextBox.Multiline = true;
			this.rowsTextBox.Name = "rowsTextBox";
			this.rowsTextBox.Size = new System.Drawing.Size(134, 21);
			this.rowsTextBox.TabIndex = 2;
			// 
			// midStarsButton
			// 
			this.midStarsButton.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.midStarsButton.Location = new System.Drawing.Point(355, 57);
			this.midStarsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.midStarsButton.Name = "midStarsButton";
			this.midStarsButton.Size = new System.Drawing.Size(70, 33);
			this.midStarsButton.TabIndex = 3;
			this.midStarsButton.Text = "等腰星號";
			this.midStarsButton.UseVisualStyleBackColor = true;
			this.midStarsButton.Click += new System.EventHandler(this.midStarsButton_Click);
			// 
			// RightStarsButton
			// 
			this.RightStarsButton.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.RightStarsButton.Location = new System.Drawing.Point(430, 57);
			this.RightStarsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.RightStarsButton.Name = "RightStarsButton";
			this.RightStarsButton.Size = new System.Drawing.Size(70, 33);
			this.RightStarsButton.TabIndex = 4;
			this.RightStarsButton.Text = "靠右星號";
			this.RightStarsButton.UseVisualStyleBackColor = true;
			this.RightStarsButton.Click += new System.EventHandler(this.RightStarsButton_Click);
			// 
			// resultTextBox
			// 
			this.resultTextBox.Location = new System.Drawing.Point(58, 114);
			this.resultTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.resultTextBox.Multiline = true;
			this.resultTextBox.Name = "resultTextBox";
			this.resultTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.resultTextBox.Size = new System.Drawing.Size(448, 192);
			this.resultTextBox.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 360);
			this.Controls.Add(this.resultTextBox);
			this.Controls.Add(this.RightStarsButton);
			this.Controls.Add(this.midStarsButton);
			this.Controls.Add(this.rowsTextBox);
			this.Controls.Add(this.rowsLabel);
			this.Controls.Add(this.leftStarsButton);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button leftStarsButton;
		private System.Windows.Forms.Label rowsLabel;
		private System.Windows.Forms.TextBox rowsTextBox;
		private System.Windows.Forms.Button midStarsButton;
		private System.Windows.Forms.Button RightStarsButton;
		private System.Windows.Forms.TextBox resultTextBox;
	}
}


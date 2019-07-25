namespace ClockState
{
	partial class SafeForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.buttonUse = new System.Windows.Forms.Button();
			this.buttonAlarm = new System.Windows.Forms.Button();
			this.buttonPhone = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 37);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(318, 92);
			this.textBox1.TabIndex = 1;
			// 
			// buttonUse
			// 
			this.buttonUse.Location = new System.Drawing.Point(12, 135);
			this.buttonUse.Name = "buttonUse";
			this.buttonUse.Size = new System.Drawing.Size(75, 23);
			this.buttonUse.TabIndex = 2;
			this.buttonUse.Text = "金庫使用";
			this.buttonUse.UseVisualStyleBackColor = true;
			this.buttonUse.Click += new System.EventHandler(this.ButtonUse_Click);
			// 
			// buttonAlarm
			// 
			this.buttonAlarm.Location = new System.Drawing.Point(93, 135);
			this.buttonAlarm.Name = "buttonAlarm";
			this.buttonAlarm.Size = new System.Drawing.Size(75, 23);
			this.buttonAlarm.TabIndex = 3;
			this.buttonAlarm.Text = "非常ベル";
			this.buttonAlarm.UseVisualStyleBackColor = true;
			this.buttonAlarm.Click += new System.EventHandler(this.ButtonAlarm_Click);
			// 
			// buttonPhone
			// 
			this.buttonPhone.Location = new System.Drawing.Point(174, 135);
			this.buttonPhone.Name = "buttonPhone";
			this.buttonPhone.Size = new System.Drawing.Size(75, 23);
			this.buttonPhone.TabIndex = 4;
			this.buttonPhone.Text = "非常通話";
			this.buttonPhone.UseVisualStyleBackColor = true;
			this.buttonPhone.Click += new System.EventHandler(this.ButtonPhone_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(255, 135);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(75, 23);
			this.buttonExit.TabIndex = 5;
			this.buttonExit.Text = "終了";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// SafeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 173);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonPhone);
			this.Controls.Add(this.buttonAlarm);
			this.Controls.Add(this.buttonUse);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "SafeForm";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button buttonUse;
		private System.Windows.Forms.Button buttonAlarm;
		private System.Windows.Forms.Button buttonPhone;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Timer timer1;
	}
}


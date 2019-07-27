namespace CommandPainter
{
	partial class Form1
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
			this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
			this.buttonClear = new System.Windows.Forms.Button();
			this.buttonRed = new System.Windows.Forms.Button();
			this.buttonBlue = new System.Windows.Forms.Button();
			this.buttonGreen = new System.Windows.Forms.Button();
			this.buttonUndo = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxCanvas
			// 
			this.pictureBoxCanvas.Location = new System.Drawing.Point(12, 48);
			this.pictureBoxCanvas.Name = "pictureBoxCanvas";
			this.pictureBoxCanvas.Size = new System.Drawing.Size(406, 210);
			this.pictureBoxCanvas.TabIndex = 0;
			this.pictureBoxCanvas.TabStop = false;
			this.pictureBoxCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBoxCanvas_MouseMove);
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(12, 12);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(75, 23);
			this.buttonClear.TabIndex = 1;
			this.buttonClear.Text = "Clear";
			this.buttonClear.UseVisualStyleBackColor = true;
			this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
			// 
			// buttonRed
			// 
			this.buttonRed.Location = new System.Drawing.Point(93, 12);
			this.buttonRed.Name = "buttonRed";
			this.buttonRed.Size = new System.Drawing.Size(28, 23);
			this.buttonRed.TabIndex = 2;
			this.buttonRed.Text = "赤";
			this.buttonRed.UseVisualStyleBackColor = true;
			this.buttonRed.Click += new System.EventHandler(this.ButtonRed_Click);
			// 
			// buttonBlue
			// 
			this.buttonBlue.Location = new System.Drawing.Point(161, 12);
			this.buttonBlue.Name = "buttonBlue";
			this.buttonBlue.Size = new System.Drawing.Size(28, 23);
			this.buttonBlue.TabIndex = 3;
			this.buttonBlue.Text = "青";
			this.buttonBlue.UseVisualStyleBackColor = true;
			this.buttonBlue.Click += new System.EventHandler(this.ButtonBlue_Click);
			// 
			// buttonGreen
			// 
			this.buttonGreen.Location = new System.Drawing.Point(127, 12);
			this.buttonGreen.Name = "buttonGreen";
			this.buttonGreen.Size = new System.Drawing.Size(28, 23);
			this.buttonGreen.TabIndex = 4;
			this.buttonGreen.Text = "緑";
			this.buttonGreen.UseVisualStyleBackColor = true;
			this.buttonGreen.Click += new System.EventHandler(this.ButtonGreen_Click);
			// 
			// buttonUndo
			// 
			this.buttonUndo.Location = new System.Drawing.Point(195, 12);
			this.buttonUndo.Name = "buttonUndo";
			this.buttonUndo.Size = new System.Drawing.Size(75, 23);
			this.buttonUndo.TabIndex = 5;
			this.buttonUndo.Text = "UnDo";
			this.buttonUndo.UseVisualStyleBackColor = true;
			this.buttonUndo.Click += new System.EventHandler(this.ButtonUndo_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(430, 270);
			this.Controls.Add(this.buttonUndo);
			this.Controls.Add(this.buttonGreen);
			this.Controls.Add(this.buttonBlue);
			this.Controls.Add(this.buttonRed);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.pictureBoxCanvas);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxCanvas;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Button buttonRed;
		private System.Windows.Forms.Button buttonBlue;
		private System.Windows.Forms.Button buttonGreen;
		private System.Windows.Forms.Button buttonUndo;
	}
}


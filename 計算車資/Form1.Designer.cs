namespace 計算車資
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.resultlbl = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.agetxtb = new System.Windows.Forms.TextBox();
			this.calcbtn = new System.Windows.Forms.Button();
			this.malebtn = new System.Windows.Forms.RadioButton();
			this.femalebtn = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.femalebtn);
			this.groupBox1.Controls.Add(this.malebtn);
			this.groupBox1.Controls.Add(this.calcbtn);
			this.groupBox1.Controls.Add(this.agetxtb);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(21, 21);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(315, 120);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "客戶資訊";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.resultlbl);
			this.groupBox2.Location = new System.Drawing.Point(21, 167);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(315, 131);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "計算結果";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "年齡:";
			// 
			// resultlbl
			// 
			this.resultlbl.AutoSize = true;
			this.resultlbl.Location = new System.Drawing.Point(16, 40);
			this.resultlbl.Name = "resultlbl";
			this.resultlbl.Size = new System.Drawing.Size(33, 12);
			this.resultlbl.TabIndex = 0;
			this.resultlbl.Text = "label1";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(159, 37);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 0;
			this.label3.Text = "性別:";
			// 
			// agetxtb
			// 
			this.agetxtb.Location = new System.Drawing.Point(55, 34);
			this.agetxtb.Name = "agetxtb";
			this.agetxtb.Size = new System.Drawing.Size(80, 22);
			this.agetxtb.TabIndex = 1;
			// 
			// calcbtn
			// 
			this.calcbtn.Location = new System.Drawing.Point(55, 62);
			this.calcbtn.Name = "calcbtn";
			this.calcbtn.Size = new System.Drawing.Size(77, 25);
			this.calcbtn.TabIndex = 2;
			this.calcbtn.Text = "計算";
			this.calcbtn.UseVisualStyleBackColor = true;
			this.calcbtn.Click += new System.EventHandler(this.calcbtn_Click);
			// 
			// malebtn
			// 
			this.malebtn.AutoSize = true;
			this.malebtn.Location = new System.Drawing.Point(197, 35);
			this.malebtn.Name = "malebtn";
			this.malebtn.Size = new System.Drawing.Size(35, 16);
			this.malebtn.TabIndex = 3;
			this.malebtn.Text = "男";
			this.malebtn.UseVisualStyleBackColor = true;
			// 
			// femalebtn
			// 
			this.femalebtn.AutoSize = true;
			this.femalebtn.Location = new System.Drawing.Point(238, 35);
			this.femalebtn.Name = "femalebtn";
			this.femalebtn.Size = new System.Drawing.Size(35, 16);
			this.femalebtn.TabIndex = 3;
			this.femalebtn.TabStop = true;
			this.femalebtn.Text = "女";
			this.femalebtn.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(351, 313);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label resultlbl;
		private System.Windows.Forms.RadioButton femalebtn;
		private System.Windows.Forms.RadioButton malebtn;
		private System.Windows.Forms.Button calcbtn;
		private System.Windows.Forms.TextBox agetxtb;
		private System.Windows.Forms.Label label3;
	}
}


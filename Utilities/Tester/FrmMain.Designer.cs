namespace Tester
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.btnTestJsonString = new System.Windows.Forms.Button();
			this.pnlMain = new System.Windows.Forms.Panel();
			this.btnGetRankings = new System.Windows.Forms.Button();
			this.btnTestRaceReader = new System.Windows.Forms.Button();
			this.btnImageReader = new System.Windows.Forms.Button();
			this.pnlMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnTestJsonString
			// 
			this.btnTestJsonString.Location = new System.Drawing.Point(10, 10);
			this.btnTestJsonString.Name = "btnTestJsonString";
			this.btnTestJsonString.Size = new System.Drawing.Size(268, 21);
			this.btnTestJsonString.TabIndex = 0;
			this.btnTestJsonString.Text = "Test Json String Reader";
			this.btnTestJsonString.UseVisualStyleBackColor = true;
			this.btnTestJsonString.Click += new System.EventHandler(this.ClickedTestJsonStringReader);
			// 
			// pnlMain
			// 
			this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlMain.Controls.Add(this.btnImageReader);
			this.pnlMain.Controls.Add(this.btnGetRankings);
			this.pnlMain.Controls.Add(this.btnTestRaceReader);
			this.pnlMain.Controls.Add(this.btnTestJsonString);
			this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMain.Location = new System.Drawing.Point(0, 0);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(292, 252);
			this.pnlMain.TabIndex = 1;
			// 
			// btnGetRankings
			// 
			this.btnGetRankings.Location = new System.Drawing.Point(10, 66);
			this.btnGetRankings.Name = "btnGetRankings";
			this.btnGetRankings.Size = new System.Drawing.Size(268, 23);
			this.btnGetRankings.TabIndex = 2;
			this.btnGetRankings.Text = "Test Get Rankings";
			this.btnGetRankings.UseVisualStyleBackColor = true;
			this.btnGetRankings.Click += new System.EventHandler(this.ClickedGetRankings);
			// 
			// btnTestRaceReader
			// 
			this.btnTestRaceReader.Location = new System.Drawing.Point(10, 37);
			this.btnTestRaceReader.Name = "btnTestRaceReader";
			this.btnTestRaceReader.Size = new System.Drawing.Size(268, 23);
			this.btnTestRaceReader.TabIndex = 2;
			this.btnTestRaceReader.Text = "Test Race Events Reader";
			this.btnTestRaceReader.UseVisualStyleBackColor = true;
			this.btnTestRaceReader.Click += new System.EventHandler(this.ClickedTestRaceEventReader);
			// 
			// btnImageReader
			// 
			this.btnImageReader.Location = new System.Drawing.Point(10, 95);
			this.btnImageReader.Name = "btnImageReader";
			this.btnImageReader.Size = new System.Drawing.Size(268, 23);
			this.btnImageReader.TabIndex = 2;
			this.btnImageReader.Text = "Test Image Reader";
			this.btnImageReader.UseVisualStyleBackColor = true;
			this.btnImageReader.Click += new System.EventHandler(this.ClickedTestImageReader);
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 252);
			this.Controls.Add(this.pnlMain);
			this.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Test App";
			this.pnlMain.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnTestJsonString;
		private System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.Button btnTestRaceReader;
		private System.Windows.Forms.Button btnGetRankings;
		private System.Windows.Forms.Button btnImageReader;
	}
}


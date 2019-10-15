namespace ProjectCreator
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
			this.btnCreate = new System.Windows.Forms.Button();
			this.pnlMain = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.txtModuleName = new System.Windows.Forms.TextBox();
			this.txtFriendlyName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pnlMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(230, 58);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(75, 23);
			this.btnCreate.TabIndex = 0;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.ClickedCreateProject);
			// 
			// pnlMain
			// 
			this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlMain.Controls.Add(this.txtFriendlyName);
			this.pnlMain.Controls.Add(this.label2);
			this.pnlMain.Controls.Add(this.txtModuleName);
			this.pnlMain.Controls.Add(this.label1);
			this.pnlMain.Controls.Add(this.btnCreate);
			this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMain.Location = new System.Drawing.Point(0, 0);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(318, 94);
			this.pnlMain.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "Module Name:";
			// 
			// txtModuleName
			// 
			this.txtModuleName.Location = new System.Drawing.Point(105, 10);
			this.txtModuleName.Name = "txtModuleName";
			this.txtModuleName.Size = new System.Drawing.Size(200, 18);
			this.txtModuleName.TabIndex = 2;
			// 
			// txtFriendlyName
			// 
			this.txtFriendlyName.Location = new System.Drawing.Point(105, 34);
			this.txtFriendlyName.Name = "txtFriendlyName";
			this.txtFriendlyName.Size = new System.Drawing.Size(200, 18);
			this.txtFriendlyName.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "Friendly Name:";
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(318, 94);
			this.Controls.Add(this.pnlMain);
			this.Font = new System.Drawing.Font("Anonymous Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Project Creator";
			this.pnlMain.ResumeLayout(false);
			this.pnlMain.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Panel pnlMain;
		private System.Windows.Forms.TextBox txtModuleName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFriendlyName;
		private System.Windows.Forms.Label label2;
	}
}


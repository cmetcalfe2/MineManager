namespace MineManager {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.batFileTextBox = new System.Windows.Forms.TextBox();
			this.batFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.BatFileButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.saveConfigButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.processNameTextBox = new System.Windows.Forms.TextBox();
			this.startMinerButton = new System.Windows.Forms.Button();
			this.killMinerButton = new System.Windows.Forms.Button();
			this.runAtBootCheckbox = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.windowProcessTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// batFileTextBox
			// 
			this.batFileTextBox.Location = new System.Drawing.Point(12, 37);
			this.batFileTextBox.Name = "batFileTextBox";
			this.batFileTextBox.Size = new System.Drawing.Size(178, 20);
			this.batFileTextBox.TabIndex = 0;
			// 
			// batFileDialog
			// 
			this.batFileDialog.FileName = "openFileDialog1";
			// 
			// BatFileButton
			// 
			this.BatFileButton.Location = new System.Drawing.Point(196, 35);
			this.BatFileButton.Name = "BatFileButton";
			this.BatFileButton.Size = new System.Drawing.Size(75, 23);
			this.BatFileButton.TabIndex = 1;
			this.BatFileButton.Text = "Select File";
			this.BatFileButton.UseVisualStyleBackColor = true;
			this.BatFileButton.Click += new System.EventHandler(this.BatFileButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Miner .bat file:";
			// 
			// saveConfigButton
			// 
			this.saveConfigButton.Location = new System.Drawing.Point(12, 188);
			this.saveConfigButton.Name = "saveConfigButton";
			this.saveConfigButton.Size = new System.Drawing.Size(75, 23);
			this.saveConfigButton.TabIndex = 3;
			this.saveConfigButton.Text = "Save";
			this.saveConfigButton.UseVisualStyleBackColor = true;
			this.saveConfigButton.Click += new System.EventHandler(this.saveConfigButton_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Miner Process Name:";
			// 
			// processNameTextBox
			// 
			this.processNameTextBox.Location = new System.Drawing.Point(12, 81);
			this.processNameTextBox.Name = "processNameTextBox";
			this.processNameTextBox.Size = new System.Drawing.Size(259, 20);
			this.processNameTextBox.TabIndex = 5;
			// 
			// startMinerButton
			// 
			this.startMinerButton.Location = new System.Drawing.Point(12, 218);
			this.startMinerButton.Name = "startMinerButton";
			this.startMinerButton.Size = new System.Drawing.Size(75, 23);
			this.startMinerButton.TabIndex = 6;
			this.startMinerButton.Text = "Start Miner";
			this.startMinerButton.UseVisualStyleBackColor = true;
			this.startMinerButton.Click += new System.EventHandler(this.startMinerButton_Click);
			// 
			// killMinerButton
			// 
			this.killMinerButton.Location = new System.Drawing.Point(93, 218);
			this.killMinerButton.Name = "killMinerButton";
			this.killMinerButton.Size = new System.Drawing.Size(75, 23);
			this.killMinerButton.TabIndex = 7;
			this.killMinerButton.Text = "Kill Miner";
			this.killMinerButton.UseVisualStyleBackColor = true;
			this.killMinerButton.Click += new System.EventHandler(this.killMinerButton_Click);
			// 
			// runAtBootCheckbox
			// 
			this.runAtBootCheckbox.AutoSize = true;
			this.runAtBootCheckbox.Location = new System.Drawing.Point(12, 159);
			this.runAtBootCheckbox.Name = "runAtBootCheckbox";
			this.runAtBootCheckbox.Size = new System.Drawing.Size(147, 17);
			this.runAtBootCheckbox.TabIndex = 9;
			this.runAtBootCheckbox.Text = "Run when windows starts";
			this.runAtBootCheckbox.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(150, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Miner Window Process Name:";
			// 
			// windowProcessTextBox
			// 
			this.windowProcessTextBox.Location = new System.Drawing.Point(13, 130);
			this.windowProcessTextBox.Name = "windowProcessTextBox";
			this.windowProcessTextBox.Size = new System.Drawing.Size(258, 20);
			this.windowProcessTextBox.TabIndex = 11;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 258);
			this.Controls.Add(this.windowProcessTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.runAtBootCheckbox);
			this.Controls.Add(this.killMinerButton);
			this.Controls.Add(this.startMinerButton);
			this.Controls.Add(this.processNameTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.saveConfigButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BatFileButton);
			this.Controls.Add(this.batFileTextBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "MineManager";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox batFileTextBox;
		private System.Windows.Forms.OpenFileDialog batFileDialog;
		private System.Windows.Forms.Button BatFileButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button saveConfigButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox processNameTextBox;
		private System.Windows.Forms.Button startMinerButton;
		private System.Windows.Forms.Button killMinerButton;
		private System.Windows.Forms.CheckBox runAtBootCheckbox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox windowProcessTextBox;
	}
}


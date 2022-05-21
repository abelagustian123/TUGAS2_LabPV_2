/*
 * Created by SharpDevelop.
 * User: Abel Agustian
 * Date: 21/05/2022
 * Time: 18:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PV2_Abel_Agustian_Sidauruk_201401031
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnopenupload = new System.Windows.Forms.Button();
			this.btnsaveupload = new System.Windows.Forms.Button();
			this.btnopendownload = new System.Windows.Forms.Button();
			this.btnsavedownload = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.Input_id = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.label4 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Info;
			this.label1.Location = new System.Drawing.Point(24, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(220, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tes Upload File";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.DarkTurquoise;
			this.pictureBox1.Location = new System.Drawing.Point(24, 73);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(220, 203);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Info;
			this.label2.Location = new System.Drawing.Point(303, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(220, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tes Download File";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.DarkTurquoise;
			this.pictureBox2.Location = new System.Drawing.Point(303, 73);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(220, 203);
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// btnopenupload
			// 
			this.btnopenupload.Location = new System.Drawing.Point(24, 293);
			this.btnopenupload.Name = "btnopenupload";
			this.btnopenupload.Size = new System.Drawing.Size(97, 34);
			this.btnopenupload.TabIndex = 4;
			this.btnopenupload.Text = "Open File";
			this.btnopenupload.UseVisualStyleBackColor = true;
			this.btnopenupload.Click += new System.EventHandler(this.BtnopenuploadClick);
			// 
			// btnsaveupload
			// 
			this.btnsaveupload.Location = new System.Drawing.Point(147, 293);
			this.btnsaveupload.Name = "btnsaveupload";
			this.btnsaveupload.Size = new System.Drawing.Size(97, 34);
			this.btnsaveupload.TabIndex = 5;
			this.btnsaveupload.Text = "Save File";
			this.btnsaveupload.UseVisualStyleBackColor = true;
			this.btnsaveupload.Click += new System.EventHandler(this.BtnsaveuploadClick);
			// 
			// btnopendownload
			// 
			this.btnopendownload.Location = new System.Drawing.Point(303, 293);
			this.btnopendownload.Name = "btnopendownload";
			this.btnopendownload.Size = new System.Drawing.Size(97, 34);
			this.btnopendownload.TabIndex = 6;
			this.btnopendownload.Text = "Open File";
			this.btnopendownload.UseVisualStyleBackColor = true;
			this.btnopendownload.Click += new System.EventHandler(this.BtnopendownloadClick);
			// 
			// btnsavedownload
			// 
			this.btnsavedownload.Location = new System.Drawing.Point(426, 293);
			this.btnsavedownload.Name = "btnsavedownload";
			this.btnsavedownload.Size = new System.Drawing.Size(97, 34);
			this.btnsavedownload.TabIndex = 7;
			this.btnsavedownload.Text = "Save File";
			this.btnsavedownload.UseVisualStyleBackColor = true;
			this.btnsavedownload.Click += new System.EventHandler(this.BtnsavedownloadClick);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Teal;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(303, 254);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 22);
			this.label3.TabIndex = 8;
			this.label3.Text = "Input ID";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Input_id
			// 
			this.Input_id.Location = new System.Drawing.Point(402, 254);
			this.Input_id.Name = "Input_id";
			this.Input_id.Size = new System.Drawing.Size(121, 22);
			this.Input_id.TabIndex = 9;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.Control;
			this.label4.Location = new System.Drawing.Point(24, 341);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(499, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "Input ID untuk di load";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(24, 375);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(499, 150);
			this.dataGridView1.TabIndex = 11;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(549, 537);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Input_id);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnsavedownload);
			this.Controls.Add(this.btnopendownload);
			this.Controls.Add(this.btnsaveupload);
			this.Controls.Add(this.btnopenupload);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "PV2_Abel-Agustian-Sidauruk_201401031";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox Input_id;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnsavedownload;
		private System.Windows.Forms.Button btnopendownload;
		private System.Windows.Forms.Button btnsaveupload;
		private System.Windows.Forms.Button btnopenupload;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
	}
}

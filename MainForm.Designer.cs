/*
 * Created by SharpDevelop.
 * User: CANO
 * Date: 24/10/2013
 * Time: 07:14 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace convertidor
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(21, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Pesos";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(20, 38);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(97, 20);
			this.textBox1.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(112, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Dolares";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(67, 123);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(136, 20);
			this.textBox2.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(154, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 30);
			this.label3.TabIndex = 4;
			this.label3.Text = "Tipo de Cambio";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(154, 38);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(99, 20);
			this.textBox3.TabIndex = 5;
			this.textBox3.TextChanged += new System.EventHandler(this.TextBox3TextChanged);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Silver;
			this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.button1.Location = new System.Drawing.Point(84, 205);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 24);
			this.button1.TabIndex = 6;
			this.button1.Text = "convertir";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.Color.Silver;
			this.Name = "MainForm";
			this.Text = "convertidor";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
	}
}

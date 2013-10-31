using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace convertidor
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		double pesos;
		double dolar;
		double cambio;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			try{
			dolar = System.Double.Parse(textBox3.Text);
            pesos = System.Double.Parse(textBox1.Text);
            cambio=pesos/dolar;
            textBox2.Text = cambio.ToString();
            if(textBox1.Text == ""|| textBox3.Text == ""){
            	//MessageBox.Show("");
            }
            
			}
			catch(FormatException){
				if(textBox1.Text == "" || textBox3.Text == ""){
            	MessageBox.Show("no se aceptan campos vacios");
            }
		
				else MessageBox.Show("no se aceptan letras solo numeros");
			}
			if(textBox1.Text.StartsWith("0") || textBox3.Text.StartsWith("0")){
				textBox2.Clear();
				MessageBox.Show("no acepta solo ceros");
			}
			
			
		}
		
		void TextBox3TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}

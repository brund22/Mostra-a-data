/*
 * Created by SharpDevelop.
 * User: Ol
 * Date: 13/01/2018
 * Time: 22:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MostraData
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
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
		void Button1Click(object sender, EventArgs e)
		{
DateTime a = DateTime.Now;
string data = DateTime.Now.ToString("dd:MM:yyyy");
string hora = DateTime.Now.ToString("HH:mm:ss");
textBox1.Text = ""+hora ;
textBox2.Text = ""+data ;
        
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{


		}
		void DataClick(object sender, EventArgs e)
		{
	
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
	}
}

/*
 * Created by SharpDevelop.
 * User: Gede Lumbung
 * Date: 7/9/2011
 * Time: 4:10 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Collections;

namespace stack_form
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public Stack isi = new Stack();
		public Queue isi2 = new Queue();
		
		public MainForm()
		{
			InitializeComponent();
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (isi.Count>5 || isi2.Count>5) {
				MessageBox.Show("Data penuh, hapus dulu data sebelumnya..!!!");
			}
			else{
				label1.Text = "";
				label2.Text = "";
				isi.Push(inData.Text.ToString());
				isi2.Enqueue(inData.Text.ToString());
				foreach(string d in isi)
		        {
					label1.Text += d.ToString()+"\n";
		        }
				foreach(string q in isi2)
		        {
					label2.Text += q.ToString()+"\n";
		        }
				inData.Text="";
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			if (isi.Count==0 || isi2.Count==0) {
				MessageBox.Show("Tidak ada data yang bisa dihapus...!!!");
			}
			else{
				label1.Text = "";
				label2.Text = "";
				string h_s = (string) isi.Pop();
				string h_q = (string) isi2.Dequeue();
				foreach(string d in isi)
		        {
					label1.Text += d.ToString()+"\n";
		        }
				foreach(string q in isi2)
		        {
					label2.Text += q.ToString()+"\n";
		        }
			}
		}
	}
}

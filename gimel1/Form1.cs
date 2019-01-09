using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gimel1
{
	public partial class Form1 : Form
	{
		int score = 0;
		int strt = 0;
		public Form1()
		{
			InitializeComponent();
			randomnumbers();
		}

		private void randomnumbers()
		{
			Random labalrandom = new Random();
			label1.Text = Convert.ToString(labalrandom.Next(100));
			label2.Text = Convert.ToString(labalrandom.Next(100));
			label3.Text = Convert.ToString(labalrandom.Next(100));
			label4.Text = Convert.ToString(labalrandom.Next(100));
			label5.Text = Convert.ToString(labalrandom.Next(100));
			label1.ForeColor = Color.Black;
			label2.ForeColor = Color.Black;
			label3.ForeColor = Color.Black;
			label4.ForeColor = Color.Black;
			label5.ForeColor = Color.Black;
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			textBox5.Text = "";

		}

		private void gameToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

			begin();
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (strt == 1)
			{
				if (textBox1.Text == label1.Text)// && textBox2.Text == label2.Text && textBox3.Text == label3.Text && textBox4.Text == label4.Text && textBox5.Text == label5.Text)
				{
					score++;
				}
				if (textBox2.Text == label2.Text)
				{
					score++;
				}
				if (textBox3.Text == label3.Text)
				{
					score++;
				}
				if (textBox4.Text == label4.Text)
				{
					score++;
				}
				if (textBox5.Text == label5.Text)
				{
					score++;
				}
				if (score == 5)
				{
					MessageBox.Show("you win!");
					listBox1.Items.Add($"{score}");
					score = 0;
					strt = 0;
					

				}
				else
				{
					MessageBox.Show("MIstake!");
					listBox1.Items.Add($"{score}");
					score = 0;
					strt = 0;
					
				}
			}
			else
			{
				MessageBox.Show("you need to click start");
			}
		}

		private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			randomnumbers();

		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			begin();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			begin();
		}
		private void begin()
		{

			label1.ForeColor = Form1.DefaultBackColor;
			label2.ForeColor = Form1.DefaultBackColor;
			label3.ForeColor = Form1.DefaultBackColor;
			label4.ForeColor = Form1.DefaultBackColor;
			label5.ForeColor = Form1.DefaultBackColor;
			strt = 1;
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			begin();
		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{
			begin();
		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{
			begin();
		}
	}
}

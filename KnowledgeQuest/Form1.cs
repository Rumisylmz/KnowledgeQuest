using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnowledgeQuest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int questionno = 0, dogru = 0 , yanlis = 0;

        private void btnb_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnnext.Enabled = true;

            label8.Text = btnb.Text;

            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }
        }
        private void btnc_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnnext.Enabled = true;

            label8.Text = btnc.Text;

            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void btnd_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnnext.Enabled = true;

            label8.Text = btnd.Text;

            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btna_Click(object sender, EventArgs e)
        {
            btna.Enabled = false;
            btnb.Enabled = false;
            btnc.Enabled = false;
            btnd.Enabled = false;
            btnnext.Enabled = true;

            label8.Text = btna.Text;

            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            btna.Enabled = true;
            btnb.Enabled = true;
            btnc.Enabled = true;
            btnd.Enabled=true;
            btnnext.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible=false;

           questionno++;
            label4.Text = questionno.ToString();

            if (questionno == 1)
            {
                richTextBox1.Text = "In wich year was the Republic of Turkey declared?";
                btna.Text = "1920";
                btnb.Text = "1921";
                btnc.Text = "1922";
                btnd.Text = "1923";
                label7.Text = "1923";
            }

            if (questionno == 2)
            {
                richTextBox1.Text = "Which city is not in the Aegean region ?";
                btna.Text = "İzmir";
                btnb.Text = "Balıkesir";
                btnc.Text = "Aydın";
                btnd.Text = "Manisa";
                label7.Text = "Balıkesir";

            }
            if (questionno == 3) 
            {
                richTextBox1.Text = "Which author does the Last Birds belong to?";
                btna.Text = "Sait Faik";
                btnb.Text = "Cemal Süreyya";
                btnc.Text = "Atilla İlhan";
                btnd.Text = "Reşat Nuri Güntekin";
                label7.Text = "Sait Faik";
                btnnext.Text = "Result";
            }
            if (questionno == 4)
            {
                btna.Enabled = false;
                btnb.Enabled = false;
                btnc.Enabled = false;
                btnd.Enabled = false;
                btnnext.Enabled = false;
                MessageBox.Show("True : " + dogru + "\n" + "False : " + yanlis);
            }
        }
    }
}

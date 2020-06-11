using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //from mid to left add 
        private void buttonLeft_Click(object sender,EventArgs e)
        {
            if(listBoxMid.SelectedIndex != -1)
            {
                listBoxLeft.Items.Add(listBoxMid.SelectedItem);
                listBoxMid.Items.Remove(listBoxMid.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please make a choice!");
            }
        }
        //from mid to right add 
        private void buttonRight_Click(object sender,EventArgs e)
        {
            if(listBoxMid.SelectedIndex != -1)
            {
                listBoxRight.Items.Add(listBoxMid.SelectedItem);
                listBoxMid.Items.Remove(listBoxMid.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please make a choice!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

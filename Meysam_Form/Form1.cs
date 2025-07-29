using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meysam_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_send_Click(object sender, EventArgs e)
        {
            list.Items.Add(txt.Text);
            cmb.Items.Add(txt.Text);
            txt.Text = "";
         
        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            list.Items.Remove(list.SelectedItem);
        }
    }
}

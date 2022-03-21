using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W5_Pratikum
{
    public partial class FormMateri : Form
    {
        public FormMateri()
        {
            InitializeComponent();
        }
        private void FormMateri_Load(object sender, EventArgs e)
        {
            rad_Btn_Red.Checked = true;
            lblHasil.ForeColor = Color.Black;
        }

        private void listBoxCollection_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblHasil.Text = listBoxCollection.SelectedItem.ToString();
        }
        private void chk_Box_Aktif_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Box_Aktif.Checked == true)
            {
                if (rad_Btn_Red.Checked == true)
                    lblHasil.ForeColor = Color.Red;
                else if (rad_Btn_Blue.Checked == true)
                    lblHasil.ForeColor = Color.Blue;
            }
            else
                lblHasil.ForeColor = Color.Black;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            string text = txtBoxInput.Text;
            bool isDuplicate = false;
            foreach (var name in listBoxCollection.Items)
            {
                if (name.ToString().Equals(text))
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (isDuplicate)
            {
                MessageBox.Show("Data Kembar");
            }
            else
            {
                listBoxCollection.Items.Add(text);
                txtBoxInput.Text = "";
            }
        }

        private void rad_Btn_Red_CheckedChanged(object sender, EventArgs e)
        {
            lblHasil.ForeColor = Color.Red;
        }

        private void rad_Btn_Blue_CheckedChanged(object sender, EventArgs e)
        {
            lblHasil.ForeColor = Color.Blue;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtBoxInput.Clear();
            listBoxCollection.Items.Clear();
            chk_Box_Aktif.Checked = false;
            rad_Btn_Red.Checked = true;
            lblHasil.ForeColor = Color.Black;
            lblHasil.Text = "";
        }
    }
}
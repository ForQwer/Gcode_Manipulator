using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_2
{
    public partial class Options : Form
    {


        public Options()
        {
            InitializeComponent();
            Main();
            Update();
        }
        public void Main()
        {
            // Initialize text boxes and checkboxes
            txt_BedSizeX.Text = GcodeManipulator.bedSizeX.ToString();
            txt_BedSizeY.Text = GcodeManipulator.bedSizeY.ToString();
            txt_TopIdentifier.Text = GcodeManipulator.TopIdentifier;
            chk_OriginLeft.Checked = GcodeManipulator.OriginLeft;
            chk_OriginUp.Checked = GcodeManipulator.OriginUp;

            txt_OffSetXMinus.Text = GcodeManipulator.offSetXMinus.ToString();
            txt_OffSetXPlus.Text = GcodeManipulator.offSetXPlus.ToString();
            txt_OffSetYMinus.Text = GcodeManipulator.offSetYMinus.ToString();
            txt_OffSetYPlus.Text = GcodeManipulator.offSetYPlus.ToString();


            lbl_OffSetXMinus.BackColor = Color.Red;
            lbl_OffSetXPlus.BackColor = Color.Green;
            lbl_OffSetYMinus.BackColor = Color.Orange;
            lbl_OffSetYPlus.BackColor = Color.Purple;
        }


        private void Update(object sender, EventArgs e)
        {
            txt_BedSizeX.KeyPress += NumbersOnly;
            txt_BedSizeY.KeyPress += NumbersOnly;
            txt_OffSetXMinus.KeyPress += NumbersOnly;
            txt_OffSetXPlus.KeyPress += NumbersOnly;
            txt_OffSetYMinus.KeyPress += NumbersOnly;
            txt_OffSetYPlus.KeyPress += NumbersOnly;

        }
        private void NumbersOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
        private void Options_FormClosed(object sender, FormClosedEventArgs e)
        {

            int.TryParse(txt_BedSizeX.Text, out GcodeManipulator.bedSizeX);
            int.TryParse(txt_BedSizeY.Text, out GcodeManipulator.bedSizeY);
            int.TryParse(txt_OffSetXMinus.Text, out GcodeManipulator.offSetXMinus);
            int.TryParse(txt_OffSetXPlus.Text, out GcodeManipulator.offSetXPlus);
            int.TryParse(txt_OffSetYMinus.Text, out GcodeManipulator.offSetYMinus);
            int.TryParse(txt_OffSetYPlus.Text, out GcodeManipulator.offSetYPlus);
            GcodeManipulator.OriginLeft = chk_OriginLeft.Checked;
            GcodeManipulator.OriginUp = chk_OriginUp.Checked;
            GcodeManipulator.TopIdentifier = txt_TopIdentifier.Text;
        }
    }
}

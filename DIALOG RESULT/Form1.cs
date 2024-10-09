using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIALOG_RESULT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnotvori_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Odaberite Yes / No / Cancle", "Naslovna linija Dijaloga za poruke", MessageBoxButtons.YesNoCancel);

            switch (DialogResult)
            {
                case DialogResult.Yes:
                    txtdialogresolt.AppendText("izabrali ste dugme YES");
                    break;

                case DialogResult.No:
                    txtdialogresolt.AppendText("izabrali ste dugme NO");
                    break;

                case DialogResult.Cancel:
                    txtdialogresolt.AppendText("izabrali ste dugme CANCLE ");
                    break;
            }
        }
    }
}

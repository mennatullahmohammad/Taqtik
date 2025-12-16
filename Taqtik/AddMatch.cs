using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taqtik
{
    public partial class AddMatch : Form
    {
        public AddMatch()
        {
            InitializeComponent();
        }

        private void button_addSubs_Click(object sender, EventArgs e)
        {
            AddSubs addSubsForm = new AddSubs();
            addSubsForm.ShowDialog();
        }

        private void textBox_homeFouls_TextChanged(object sender, EventArgs e)
        {
            //alielzanati
        }
    }
}

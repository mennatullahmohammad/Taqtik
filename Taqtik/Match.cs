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
    public partial class Match : Form
    {
        public Match()
        {
            InitializeComponent();
        }

        private void Match_Load(object sender, EventArgs e)
        {
            
        }

        private void button_viewSubs_Click(object sender, EventArgs e)
        {
            Subs subsForm = new Subs();
            subsForm.ShowDialog();
        }

        private void textBox_homeShots_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class DataEntry : Form
    {
        public DataEntry()
        {
            InitializeComponent();
        }

        private void button_addMatch_Click(object sender, EventArgs e)
        {
            AddMatch addMatchForm = new AddMatch();
            addMatchForm.Show();
            this.Hide();

        }
    }
}

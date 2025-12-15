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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button_adduser_Click(object sender, EventArgs e)
        {


            AddUser adduser = new AddUser();
            adduser.Show();
        }
    }
}

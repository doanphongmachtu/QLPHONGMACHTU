using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            loadDecor();
        }

        public void loadDecor()
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            panel1.BackColor = Color.FromArgb(200, panel1.BackColor);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Modaless : Form
    {
        public Modaless()
        {
            InitializeComponent();
        }
        Form12 modaless = null;

        private void 모달리스대화상자_Click(object sender, EventArgs e)
        {
            if(modaless == null)
            {
                modaless = new Form12();
                modaless.Show();
            }

        }
    }
}

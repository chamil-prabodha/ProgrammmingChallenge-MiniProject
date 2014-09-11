using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MeBox : Form
    {
        public MeBox()
        {
            InitializeComponent();
        }

        private void Okay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        
    }
}

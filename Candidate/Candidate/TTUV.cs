using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL.Models;

namespace Candidate
{
    public partial class TTUV : Form
    {
        public TTUV()
        {
            InitializeComponent();
        }

        private void tsmiFind_Click(object sender, EventArgs e)
        {
            FindUV ttuv = new FindUV();
            ttuv.ShowDialog();
        }
    }
}

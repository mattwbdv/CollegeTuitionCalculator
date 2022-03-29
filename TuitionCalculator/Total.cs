using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuitionCalculator
{
    public partial class Total : Form
    {
        public Total()
        {
            InitializeComponent();
        }

        private void okay_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }
    }
}

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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            var answerCalc = 0;
            if(AllenCheck.Checked == true)
            {
                answerCalc += 1500;
            }
            if(PikeCheck.Checked == true)
            {
                answerCalc += 1600;
            }
            if(FarthingCheck.Checked == true)
            {
                answerCalc += 1800;
            }
            if(SuitesCheck.Checked == true)
            {
                answerCalc += 2500;
            }
            if(SevenCheck.Checked == true)
            {
                answerCalc += 600;
            }
            if(FourteenCheck.Checked == true)
            {
                answerCalc += 1200;
            }
            if(UnlimitedCheck.Checked == true)
            {
                answerCalc += 1700;
            }
            Total total = new Total();
            total.answer.Text = (answerCalc.ToString());

            if(total.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}

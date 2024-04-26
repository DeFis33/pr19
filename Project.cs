using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR19
{
    public partial class Project : Form
    {
        public Project()
        {
            InitializeComponent();
        }
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info form = new Info();
            form.Show();
        }
        private void btnMath_Click(object sender, EventArgs e)
        {
            try
            {
                double x, z, y, v1, v2, v3, v4, v5, v6;
                x = Convert.ToDouble(textBoxDate1.Text);
                z = Convert.ToDouble(textBoxDate2.Text);
                v1 = Math.Tan(Math.PI - x);
                v2 = Math.Sin(3 * Math.PI / 2 + z);
                v3 = Math.Cos(Math.PI + x * z);
                v4 = Math.Cos(3 * Math.PI / 2 + x) / Math.Sin(3 * Math.PI / 2 + x);
                v5 = v1 * v2;
                v6 = v3 * v4;
                y = v5 / v6;
                y = Math.Round(y, 5);
                textBoxResult.Text = y.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Проверьте правильность введенных данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxDate1.Clear();
                textBoxDate2.Clear();
                textBoxResult.Clear();
            }
        }
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDate1.Clear();
            textBoxDate2.Clear();
            textBoxResult.Clear();
        }
        private void программаРасчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnMath_Click(sender, e);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
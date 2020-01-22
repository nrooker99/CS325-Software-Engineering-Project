using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP02
{
    public partial class CashReport : Form
    {
        private int idNum;
        public CashReport(int id)
        {
            idNum = id;
            int numEnrollees = DBMng.getTotalNumOfEnrollees();
            int income = DBMng.getIncome();
            InitializeComponent();
            label4.Text = numEnrollees.ToString();
            label5.Text = income.ToString();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HSPinfoGUI newform = new HSPinfoGUI(idNum);
            newform.ShowDialog();

        }
    }
}

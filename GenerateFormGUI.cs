using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;

namespace CP02
{
    // Commented out most of the stuff because we can implement untill next iteration

    public partial class GenerateFormGUI : Form
    {
        int[] numEnrollees;
        double[] totalIncomes;
        private Button button1;
        double enrolleePayments;
        public GenerateFormGUI()
        {
            //InitializeComponent();

        }
       /* private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GenerateFormGUIHelper h = new CreateFormGUIHelper();
            h.ShowDialog();   
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GenerateFormGUI
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.button1);
            this.Name = "GenerateFormGUI";
            this.ResumeLayout(false);

        }*/
    }
}


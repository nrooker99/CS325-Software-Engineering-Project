using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CP02
{
    // Commented out most of the stuff because we can implement untill next iteration
    public partial class GenerateFormGUIHelper : Form
    {
        private int[] numEnrollees;
        private double[] totalIncomes;
        private double enrolleePayments;
        public GenerateFormGUIHelper()
        {
            /*InitializeComponent();
            generateMonthlyForm();

            // Printing number of enrollees
            //enrollees = textBox1.Text;
            for (int i = 0; i < numEnrollees.Length; i++)
            {
                listbox1.Item.add(numEnrollees[i]);
            }

            // Printing incomes
            //income = textBox2.Text;
            for (int i = 0; i < totalIncome.Length; i++)
            {
                listbox2.Item.add(totalIncomes[i]);
            }

            // Printing the payment amount
            //payments = textBox3.Text;
            listbox2.Item.add(totalPayments);*/

        }
       /* public void generateMonthlyForm()
        {
            // Connecting to the database and setting up needed objects
            MySqlConnection mycon = new MySqlConnection();
            mycon = DBMng.connectOutOfSIUE();
            mycon.Open();

            int month = getCurrentMonth(mycon);

            // find info for current month
            numEnrollees = findNumEnrollees(mycon);
            totalIncomes = getTotalIncome(mycon);
            enrolleePayments = getEnrolleePayments(mycon);
            //int numBills = getNumBills(mycon);
            mycon.Close();

        }
        public int getCurrentMonth(MySqlConnection mycon)
        {
            MySqlDataReader rd;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            string getDate = "SELECT MONTH(CURRENT_TIMESTAMP);";
            cmd.CommandText = getDate;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            rd.Read();
            int month = rd.GetInt32(0);
            rd.Close();
            return month;
        }

        public int[] findNumEnrollees(MySqlConnection mycon) //FIX
        {
            MySqlDataReader rd;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;

            // finding number of plans so we can loop through each one and count number of enrollees
            string findingNumberOfPlans = "SELECT COUNT(*) FROM plan;";
            cmd.CommandText = findingNumberOfPlans;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            rd.Read();
            int i = rd.GetInt32(0);

            // creating array to hold number of enrollees per plan. Length = number of plans counted + 1 to account for starting at index 1.
            int[] enrolleesInEachPlan = new int[i + 1];

            // looping through each plan and counting number of employees in each one, storing it into the integer array
            for (int j = 1; j < i + 1; j++)
            {
                string getEnrollees = "SELECT COUNT(*) FROM primaryEnrollee" +
                                      "WHERE plan$id = " + j + ";";
                cmd.CommandText = getEnrollees;
                cmd.Prepare();
                rd = cmd.ExecuteReader();
                rd.Read();

                // Add the ammount of enrollees from each plan to the array
                enrolleesInEachPlan[j] = rd.GetInt32(0);
            }

            rd.Close();
            return enrolleesInEachPlan;
        }

        public double[] getTotalIncome(MySqlConnection mycon)
        {
            MySqlDataReader rd;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;

            // finding number of plans so we can loop through them and store their respective incomes
            string findingNumberOfPlans = "SELECT COUNT(*) from plan;";
            cmd.CommandText = findingNumberOfPlans;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            rd.Read();
            int i = rd.GetInt32(0);

            double[] totalIncomesForEachPlan = new double[i + 1];

            for (int j = 0; j < i + 1; j++)
            {
                string findingIncome = "SELECT income FROM plan" +
                                       "WHERE id = " + j + ";";
                cmd.CommandText = findingIncome;
                cmd.Prepare();
                rd = cmd.ExecuteReader();
                rd.Read();

                // Add each income from each plan to the array
                totalIncomesForEachPlan[j] = rd.GetDouble(0);
            }

            rd.Close();
            return totalIncomesForEachPlan;

        }

        public double getEnrolleePayments(MySqlConnection mycon)
        {
            MySqlDataReader rd;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;

            string getPayments = "SELECT payments FROM primaryEnrollee;";
            cmd.CommandText = getPayments;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            double totalPayments;

            // while there are rows left in the table, read each value and add to total
            while (rd.Read())
            {
                double x = rd.GetDouble(0);
                totalPayments = +x;
            }
            rd.Close();
            return totalPayments;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // GenerateFormGUIHelper
            // 
            this.ClientSize = new System.Drawing.Size(426, 253);
            this.Name = "GenerateFormGUIHelper";
            this.ResumeLayout(false);

        }*/

        /*public int getNumBills(MySqlConnection mycon)
        {
            MySqlDataReader rd;
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mycon;
            string getBills = "SELECT COUNT (*) FROM HSP;";
            cmd.CommandText = getBills;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            rd.Read();
            int numBills = rd.GetInt32(0);
            rd.Close();
            // mycon.Close();
            return numBills;
        }*/


    }
}

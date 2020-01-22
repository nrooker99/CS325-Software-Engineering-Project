using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

public class GenerateForm
{
    // Commented out most of the stuff because we can implement untill next iteration

    public GenerateForm()
	{
        
        
        
    }

   /* public void generateMonthlyForm()
    {
        // Connecting to the database and setting up needed objects
        MySqlConnection mycon = new MySqlConnection();
        mycon = connectAtSIUE();
        mycon.Open();

        int month = getCurrentMonth(mycon);
        
        // find info for current month
        int[] numEnrollees = findNumEnrollees(mycon);
        double[] totalIncomes = getTotalIncome(mycon);
        double enrolleePayments = getEnrolleePayments(mycon);
        //int numBills = getNumBills(mycon);
        createForm(numEnrollees, totalIncomes, enrolleePayments);
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
        int[] enrolleesInEachPlan = new int[i+1];

        // looping through each plan and counting number of employees in each one, storing it into the integer array
        for(int j=1;j<i+1;j++)
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
        int i = GetInt32(0);

        double[] totalIncomesForEachPlan = new double[i + 1];

        for(int j=0;j<i+1;j++)
        { 
            string findingIncome = "SELECT income FROM plan" +
                                   "WHERE id = " + j + ";";
            cmd.CommandText = findingIncome;
            cmd.Prepare();
            rd = cmd.ExecuteReader();
            rd.Read();

            // Add each income from each plan to the array
            totalIncomesForEachPlan[j]=rd.GetDouble(0);
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
            totalPayments = totalPayments + x;
        }
        rd.Close();
        return totalPayments;
    }
    
    *//*public int getNumBills(MySqlConnection mycon)
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
    }*//*

    public void createForm(int[] numEnrollees, double[] totalIncome, double enrolleePayments)
    {
        string enrollees = "Number of Enrollees";
        string income = "Total Income";
        string payments = "Total Payments";

        // Printing number of enrollees
        enrollees = textBox1.Text;
        for(int i=1;i<=numEnrollees.Length;i++)
        {
            Console.WriteLine(numEnrollees[i]);
        }

        // Printing incomes
        income = textBox2.Text;
        for(int i=1;i<=totalIncome;i++)
        {
            Console.WriteLine(totalIncome[i]);
        }

        // Printing the payment amount
        payments = textBox3.Text;
        Console.WriteLine(enrolleePayments);
    }*/
}

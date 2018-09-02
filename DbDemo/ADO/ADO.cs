using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DbDemo.Models;

namespace DbDemo.ADO
{
    public class Ado
    {
        public int DeleteData(int EmployeeId)
        {
            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["DataContext"].ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "delete Emplyees  where EmplyeeId=" + EmployeeId;
            cnn.Open();
            int i = cmd.ExecuteNonQuery();

            cnn.Close();
            return i;
        }
        public int UpdateData(Emplyee emp)
        {
            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["DataContext"].ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "update Emplyees set EmpName='" + emp.EmpName + "' where EmplyeeId=" + emp.EmplyeeId;
            cnn.Open();
            int i = cmd.ExecuteNonQuery();

            cnn.Close();
            return i;
        }
        public int InsertData()
        {
            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["DataContext"].ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "insert into Emplyees (EmpName) values ('Hello')";
            cnn.Open();
            int i = cmd.ExecuteNonQuery();

            cnn.Close();
            return i;
        }

        public DataTable getEmployeeBYAdaptor()
        {
            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["DataContext"].ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "select * from Emplyees";



            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = cmd;
            cnn.Open();
            DataSet dataSet = new DataSet();
            adaptor.Fill(dataSet, "Epl");
            cnn.Close();
            return dataSet.Tables[0];
        }
        public Emplyee getEmployee()
        {
            var emp = new Emplyee();

            SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["DataContext"].ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "select * from Emplyees";
            cnn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                emp.EmplyeeId = int.Parse(reader.GetValue(0).ToString());

                emp.EmpName = reader.GetValue(1).ToString();
            }


            reader.Close();
            cmd.Dispose();
            cnn.Close();
            return emp;
        }
    }
}
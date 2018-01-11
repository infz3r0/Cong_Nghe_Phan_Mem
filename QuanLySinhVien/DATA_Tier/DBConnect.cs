using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DATA_Tier
{
    public class DBConnect
    {
        private string connect = DATA_Tier.Properties.Settings.Default.connectstringLong;

        private SqlDataAdapter myAdapter;
        private SqlConnection conn;

        public DBConnect()
        {
            conn = new SqlConnection(connect);
        }

        private SqlConnection openConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                {
                    conn.Open();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
            }
            return conn;
        }
        public DataTable executeSelectQuery(string _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            DataTable dataTable = new DataTable();
            myAdapter = new SqlDataAdapter();
            dataTable = null;
            DataSet ds = new DataSet();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch (SqlException e)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
            return dataTable;
        }


        public bool executeInsertQuery(string _query, SqlParameter[] sqlParameter)
        {
            myAdapter = new SqlDataAdapter();
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myAdapter.InsertCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }

        public bool executeUpdateQuery(string _query, SqlParameter[] sqlParameter)
        {
            myAdapter = new SqlDataAdapter();
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myAdapter.UpdateCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }

        public bool executeDeleteQuery(string _query, SqlParameter[] sqlParameter)
        {
            myAdapter = new SqlDataAdapter();
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myAdapter.DeleteCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }

        public int executeNonQuery(string _query, SqlParameter[] sqlParameter)
        {
            int row = -1;
            myAdapter = new SqlDataAdapter();
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myAdapter.SelectCommand = myCommand;
                row = (int)myCommand.ExecuteScalar();
            }
            catch (SqlException e)
            {
                return -2;
            }
            finally
            {
                conn.Close();
            }
            return row;
        }

        public void FillDataTable(string _query, SqlParameter[] sqlParameter, ref DataTable dt)
        {
            SqlCommand myCommand = new SqlCommand();
            myAdapter = new SqlDataAdapter();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(dt);
            }
            catch (SqlException e)
            {
                return;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}

using EmployeeManagement.Model;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace EmployeeManagement.Repositories
{
    public class BaseRepository
    {
        protected SqlDataAdapter Adapter { get; set; }
        public DataSet Data { get; set; } = new DataSet();

        protected readonly string ConnectionString = "Data Source=DESKTOP-7EJJG8P;Initial Catalog=test;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;";//ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        protected DataSet RefillData()
        {
            Data.Clear();
            Adapter.Fill(Data);
            return Data;
        }

        protected DataSet UpdateData()
        {
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(Adapter);
            Adapter.Update(Data);
            return RefillData();
        }

        protected void PrepareData(SqlCommand sqlcommand)
        {
            sqlcommand.Connection = new SqlConnection(ConnectionString);
            Adapter = new SqlDataAdapter(sqlcommand);

            RefillData();
        }
    }
}

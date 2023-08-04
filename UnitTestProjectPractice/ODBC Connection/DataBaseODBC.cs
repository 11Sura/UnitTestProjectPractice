using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents.DocumentStructures;

namespace UnitTestProjectPractice.ODBC_Connection
{
    [TestClass]
    public class DataBaseODBC
    {
        OdbcConnection connection;
        [TestMethod]
        [TestCategory("odbc")]
        public void DatabaseConnectionMain()
        {
            string connectionString= "Driver={MySQL ODBC 8.1 Unicode Driver};Server=rmgtestingserver:3333;Database=projects;User=root@%;Password=root;";
            connection = new OdbcConnection(connectionString);
            string query = "select * from project;";
            connection.Open();
            OdbcCommand command = new OdbcCommand(query, connection);
            OdbcDataReader table = command.ExecuteReader();
            Console.WriteLine(table.Read());

            while(table.Read())
            {

                Console.WriteLine(table[0].ToString()+"   "+table[1].ToString()+"   "+table[2].ToString());
            }
            connection.Close();
        }

    }
}

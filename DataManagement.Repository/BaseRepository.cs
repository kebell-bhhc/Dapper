using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataManagement.Repository
{
    public class BaseRepository : IDisposable
    {
        protected IDbConnection con;
        protected string connectionString;
        public BaseRepository()
        {
            //Todo: Change this into a factory
            connectionString = @"Data Source=SAC-KEBELL\SQL2014;Initial Catalog=DataManagement;Integrated Security=True";
            con = new SqlConnection(connectionString);
        }
        public void Dispose()
        {
            //throw new NotImplementedException();  
        }
    }
}

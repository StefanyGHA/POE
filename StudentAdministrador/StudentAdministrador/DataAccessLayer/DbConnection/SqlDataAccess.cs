using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;
using Microsoft.Data.SqlClient;

namespace DataAccessLayer.DbConnection
{
    public class SqlDataAccess
    {
        private readonly string _conenectionString;
        public SqlDataAccess()
        { 
            _conenectionString = "Data Source=CDS1-PC3;Initial Catalog=StudentAdministradorDB;Integrated Security=True;Trust Server Certificate=True";
        }

        public SqlConnection GetConnection()
        {
        return new SqlConnection(_conenectionString);
        }

    }
}

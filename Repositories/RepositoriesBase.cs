using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace pj.Repositories
{
    public abstract class RepositoriesBase
    {
        private readonly string _connectionString;
        public RepositoriesBase()
        {
            _connectionString = "Server(local); Database=master; Integrated Security=true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

    }
}

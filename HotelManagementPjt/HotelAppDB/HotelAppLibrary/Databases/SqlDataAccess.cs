using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlTypes;
using System.Data;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace HotelAppLibrary.Databases
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;
        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }
        public List<T> LoadData<T, U>(
                                    string sqlStatment,
                                    U parameters,
                                    string connectionStringName,
                                    bool isStoredProcedure = false)
        {
            string connectionString = _config.GetConnectionString(connectionStringName);
            CommandType commandType = CommandType.Text;

            if (isStoredProcedure == true)
            {
                commandType = CommandType.StoredProcedure;
            }

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(sqlStatment, parameters, commandType: commandType).ToList();
                return rows;
            }
        }

        public void SaveData<T>(
                                string sqlStatment,
                                T parameters,
                                string connectionStringName,
                                bool isStoredProcedure = false)
        {
            string connectionString = _config.GetConnectionString(connectionStringName);
            CommandType commandType = CommandType.Text;

            if (isStoredProcedure == true)
            {
                commandType = CommandType.StoredProcedure;
            }

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(sqlStatment, parameters, commandType: commandType);

            }

        }



    }
}

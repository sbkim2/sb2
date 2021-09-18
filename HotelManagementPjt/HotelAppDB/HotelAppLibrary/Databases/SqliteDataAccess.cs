﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Dapper;

namespace HotelAppLibrary.Databases
{
    public class SqliteDataAccess : ISqliteDataAccess
    {
        private readonly IConfiguration _config;
        public SqliteDataAccess(IConfiguration config)
        {
            _config = config;
        }
        public List<T> LoadData<T, U>(string sqlStatment,
                                    U parameters,
                                    string connectionStringName)
        {
            string connectionString = _config.GetConnectionString(connectionStringName);


            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(sqlStatment, parameters).ToList();
                return rows;
            }
        }

        public void SaveData<T>(string sqlStatment,
                                T parameters,
                                string connectionStringName)
        {
            string connectionString = _config.GetConnectionString(connectionStringName);

            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Execute(sqlStatment, parameters);

            }

        }
    }
}

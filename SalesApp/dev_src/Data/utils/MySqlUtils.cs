using System;
using System.IO;
using MySql.Data.MySqlClient;

namespace SalesApp.dev_src.utils
{
    public class MySqlUtils
    {

        public static MySqlConnectionStringBuilder ConnectionString { get; set; } = new MySqlConnectionStringBuilder
        {
                Server = "127.0.0.1", // server hosting the mysql server
                UserID = "root", // user id for mysql
                Password = "rootroot", // password for mysql
                Port = 3306, // port to connect on, 3306 is default for MySQL
                Database = "sale", // name of db to connect to in rdbms
                AllowBatch = true, // allows batches of commands to be sent, defaults to true,
                //AllowLoadLocalInfileInPath = "./", // only files in specified dir can be uploaded, AllowLoadLocalInfile will override if set to true
                //AllowLoadLocalInfile = false, // allows file uploads from anywhere if set to true
                //ConnectionTimeout = 30 // default is 15, amount of time until app throws a timeout error
        };

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString.ConnectionString);
        }

        public static void RunSchema(string path, MySqlConnection connection)
        {
            string schema = File.ReadAllText(path);
            MySqlCommand mySqlCommand = connection.CreateCommand();
            mySqlCommand.CommandText = schema;

            // used when manipulating the DB
            mySqlCommand.ExecuteNonQuery();
        }
    }

}

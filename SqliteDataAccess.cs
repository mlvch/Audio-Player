//using Dapper;
using System;
using System.Collections.Generic;
//using System.Configuration;
//using System.Data;
//using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BassPlayerApp
{
    public class SqliteDataAccess
    {
        private static string connectionString = @"URI=file:C:\Malevich\c#\BassPlayerApp\BassPlayerApp\AudioDB.db";
        //public static List<Song> LoadAudios()
        //{
        //    using (IDbConnection cnn = new SQLConnection(connectionString))
        //    {
        //        var output = cnn.Query<Song>("select * from Song", new DynamicParameters());
        //        return output.ToList();
        //    }
        //}

        public static void SaveAudioList(string song)
        {
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    string query = "insert into Song (FileLinks) values (" + item +")";
            //    SqlCommand command = new SqlCommand();
            //    command.Connection = connection;
            //    command.CommandText = query;
            //    //command.Parameters.Add("@FileLinks", SqlDbType.Text);
            //    command.ExecuteNonQuery();
            //}

            //var cnn = new SQLiteConnection(connectionString);
            //cnn.Open();
            //cnn.Execute("insert into [Song](FileLinks) values (@FileLinks)", song);
            //cnn.Close();
        }

        //private static string LoadConnectionString(string id="Default")
        //{
        //    return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace Albatros
{
    class SQLiteManager
    {
        public void initDB()
        {
            string tableBirthQuery = @"CREATE TABLE[aircraft](
                                        [id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                        [code] NVARCHAR(5) NULL,
                                        [type] VARCHAR(10) NULL)";
            //SQLiteConnection sQLiteConnection = new SQLiteConnection();
            SQLiteConnection.CreateFile("albatroslocaldb.db3");
            using (SQLiteConnection connection = new SQLiteConnection("data source= albatroslocaldb.db3"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    connection.Open();
                    cmd.CommandText = tableBirthQuery;
                    cmd.ExecuteNonQuery();

                    //Insertion of data
                    cmd.CommandText = "INSERT INTO aircraft(code,type) VALUES('AQC','Q400')";
                    cmd.ExecuteNonQuery();
                    Console.WriteLine(cmd.CommandText.ToString());

                    cmd.CommandText = "INSERT INTO aircraft(code,type) VALUES('AQD','Q400')";
                    cmd.ExecuteNonQuery();
                    Console.WriteLine(cmd.CommandText.ToString());

                    cmd.CommandText = "INSERT INTO aircraft(code,type) VALUES('AQE','Q400')";
                    cmd.ExecuteNonQuery();
                    Console.WriteLine(cmd.CommandText.ToString());

                    cmd.CommandText = "INSERT INTO aircraft(code,type) VALUES('AQF','Q400')";
                    cmd.ExecuteNonQuery();
                    Console.WriteLine(cmd.CommandText.ToString());

                    Console.WriteLine("----------------B700------------------");
                    cmd.CommandText = "INSERT INTO aircraft(code,type) VALUES('ANG','B700')";
                    cmd.ExecuteNonQuery();
                    Console.WriteLine(cmd.CommandText.ToString());

                    cmd.CommandText = "INSERT INTO aircraft(code,type) VALUES('ANH','B700')";
                    Console.WriteLine(cmd.CommandText.ToString());

                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "INSERT INTO aircraft(code,type) VALUES('AOK','B700')";
                    Console.WriteLine(cmd.CommandText.ToString());
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "INSERT INTO aircraft(code,type) VALUES('ATU','B700')";
                    cmd.ExecuteNonQuery();
                    Console.WriteLine(cmd.CommandText.ToString());

                    cmd.CommandText = "INSERT INTO aircraft(code,type) VALUES('ALM','B700')";
                    cmd.ExecuteNonQuery();
                    Console.WriteLine(cmd.CommandText.ToString());

                    cmd.CommandText = "INSERT INTO aircraft(code,type) VALUES('AVO','B700')";
                    cmd.ExecuteNonQuery();
                    Console.WriteLine(cmd.CommandText.ToString());

                    cmd.CommandText = "INSERT INTO aircraft(code,type) VALUES('AVP','B700')";
                    cmd.ExecuteNonQuery();
                    Console.WriteLine(cmd.CommandText.ToString());

                    connection.Close();
                }
            }
        }

        public static SQLiteConnection conSqlite = new SQLiteConnection("data source= albatroslocaldb.db3");
    }
}

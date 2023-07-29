using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Classes
{
    public class DBconnection
    {
        
        public static string DBaddress = @"Data Source= D:\Software\Projects\OOP 1 Project\Library Project\LibraryProject\bin\DB\\library.db; Version=3;New=False;Compress=True;Read Only=False;";
        public static string ConnState;
        public static void ConTest()
        {
            using (SQLiteConnection conn = new SQLiteConnection(DBaddress))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    try
                    {
                        conn.Open();
                        ConnState = "Database connected.";
                    }
                    catch (Exception)
                    {
                        ConnState = "Error of Datebase Connection !";
                    }
                }
                else { ConnState = "Database connected."; }
            }
        }
    }
}

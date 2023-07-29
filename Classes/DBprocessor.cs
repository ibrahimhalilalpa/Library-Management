using LibraryProject.Classes.Parameters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace LibraryProject.Classes
{
    public class DBprocessor
    {

        ///Book List
        // Grid fill / Data extraction
        public static bool GridFillInBookList(DataGrid grd)
        {
            int checkdatagrid = 0;
            SQLiteConnection cnt = new SQLiteConnection(DBconnection.DBaddress);
            SQLiteCommand cmd = new SQLiteCommand("Select * from tbl_BookList", cnt);

            // SQLiteCommand cmd = new SQLiteCommand("Select * from tbl_BookList where PageNumber= '200'", cnt);

            try // operations: creating adapter,filling datatable
            {
                DataTable dataTableindatabase = new DataTable();
                SQLiteDataAdapter sqlAdaptor = new SQLiteDataAdapter(cmd);
                sqlAdaptor.Fill(dataTableindatabase);
                grd.ItemsSource = null;
                grd.ItemsSource = dataTableindatabase.DefaultView;
            }
            catch (Exception error404)
            {
                MessageBox.Show(error404.ToString());
            }

            finally
            {
                cnt.Dispose();

            }
            if (checkdatagrid > 0) return true; else return false;
        }


        //Data adding
        public static bool addBook(Books data)
        {
            int insert = 0;
            using (SQLiteConnection conn = new SQLiteConnection(DBconnection.DBaddress))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {
                    command.CommandText = "INSERT INTO tbl_BookList(Barcode, BookName, Author, BookType, SubjectOfBook, PageNumber, LanguageOfBook, PrintingDate, Publisher, EscrowStatus, AmountOfStock, State)  VALUES (@Barcode,@BookName, @Author, @BookType, @SubjectOfBook, @PageNumber, @LanguageOfBook, @PrintingDate, @Publisher, @EscrowStatus, @AmountOfStock, @State)";

                    command.Parameters.AddWithValue("@Barcode", data.Barcode);
                    command.Parameters.AddWithValue("@BookName", data.BookName);
                    command.Parameters.AddWithValue("@Author", data.Author);
                    command.Parameters.AddWithValue("@BookType", data.BookType);
                    command.Parameters.AddWithValue("@SubjectOfBook", data.SubjectOfBook);
                    command.Parameters.AddWithValue("@PageNumber", data.PageNumber);
                    command.Parameters.AddWithValue("@LanguageOfBook", data.LanguageOfBook);
                    command.Parameters.AddWithValue("@PrintingDate", data.PrintingDate);
                    command.Parameters.AddWithValue("@Publisher", data.Publisher);
                    command.Parameters.AddWithValue("@EscrowStatus", data.EscrowStatus);
                    command.Parameters.AddWithValue("@AmountOfStock", data.AmountOfStock);
                    command.Parameters.AddWithValue("@State", data.State);


                    try
                    {
                        insert = command.ExecuteNonQuery();
                    }
                    catch (SQLiteException e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                    finally
                    {
                        conn.Close();
                        //conn.Dispose();
                    }
                }
            }
            if (insert > 0) return true; else return false;

        }


        //Data search
        public static bool BookListSearchBook(DataGrid grd, string key) //(Bookname)

        {
            int search = 0;
            SQLiteConnection cnt = new SQLiteConnection(DBconnection.DBaddress);
            SQLiteCommand cmd = new SQLiteCommand("Select * From tbl_BookList where BookName like '%" + key + "%' ", cnt);

            try
            {
                DataTable dataTableindatabase = new DataTable();
                SQLiteDataAdapter sqlAdaptor = new SQLiteDataAdapter(cmd);
                sqlAdaptor.Fill(dataTableindatabase);
                grd.ItemsSource = null;
                grd.ItemsSource = dataTableindatabase.DefaultView;
            }
            catch (Exception error404)
            {
                MessageBox.Show(error404.ToString());
            }

            finally
            {
                cnt.Dispose();
            }
            if (search > 0) return true; else return false;
        }
        public static bool BookListSearchAuthor(DataGrid grd, string key) // (Author)

        {
            sbyte search = 0;
            SQLiteConnection cnt = new SQLiteConnection(DBconnection.DBaddress);
            SQLiteCommand cmd = new SQLiteCommand("Select * From tbl_BookList where Author like '%" + key + "%' ", cnt);

            try 
            {
                DataTable dataTableindatabase = new DataTable();
                SQLiteDataAdapter sqlAdaptor = new SQLiteDataAdapter(cmd);
                sqlAdaptor.Fill(dataTableindatabase);
                grd.ItemsSource = null;
                grd.ItemsSource = dataTableindatabase.DefaultView;
            }
            catch (Exception error404)
            {
                MessageBox.Show(error404.ToString());
            }

            finally
            {
                cnt.Dispose();
            }
            if (search > 0) return true; else return false;
        }


        //Data deletion
        public static bool DeleteBookById(int id)
        {
            int del = 0;
            using (SQLiteConnection conn = new SQLiteConnection(DBconnection.DBaddress))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {
                    command.CommandText = "delete from tbl_BookList where ID = " + id + "";

                    try
                    {
                        del = command.ExecuteNonQuery();
                    }
                    catch (SQLiteException e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }
                conn.Close();
                //conn.Dispose();
            }
            if (del > 0) return true; else return false;
        }




        ///Escrow List
        //Grid fill / Data extraction
        public static bool GridFillInEscrowList(DataGrid grd)
        {
            int checkdatagrid = 0;
            SQLiteConnection cnt = new SQLiteConnection(DBconnection.DBaddress);
            SQLiteCommand cmd = new SQLiteCommand("select ec.ID, ec.ReaderID, ec.BookID, b.Barcode , ec.EscrowDate, ec.ReturnDate, b.BookName , b.Author, b.SubjectOfBook , b.PageNumber, b.Publisher, u.NameSurname, u.Email from tbl_EscrowList as ec inner join tbl_BookList as b on b.ID=BookID inner join tbl_Users as u on u.ID=ReaderID where ec.ReturnDate <= date()", cnt);

            try
            {
                DataTable dataTableindatabase = new DataTable();
                SQLiteDataAdapter sqlAdaptor = new SQLiteDataAdapter(cmd);
                sqlAdaptor.Fill(dataTableindatabase);
                grd.ItemsSource = null;
                grd.ItemsSource = dataTableindatabase.DefaultView;
            }
            catch (Exception error404)
            {
                MessageBox.Show(error404.ToString());
            }

            finally
            {
                cnt.Dispose();
            }
            if (checkdatagrid > 0) return true; else return false;
        }


        //Data adding
        public static bool addEscrow(Escrow data)
        {
            int insert = 0;
            using (SQLiteConnection conn = new SQLiteConnection(DBconnection.DBaddress))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {

                    command.CommandText = "INSERT INTO tbl_EscrowList(ReaderID,BookID,EscrowDate,ReturnDate,NameSurname)  VALUES (@ReaderID,@BookID,@EscrowDate, @ReturnDate,@NameSurname)";


                    command.Parameters.AddWithValue("@ReaderID", data.ReaderID);
                    command.Parameters.AddWithValue("@BookID", data.BookID);
                    command.Parameters.AddWithValue("@EscrowDate", data.EscrowDate);
                    command.Parameters.AddWithValue("@ReturnDate", data.ReturnDate);
                    command.Parameters.AddWithValue("@NameSurname", data.NameSurname);

                    try
                    {
                        insert = command.ExecuteNonQuery();
                    }
                    catch (SQLiteException e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }
                conn.Close();
                //conn.Dispose();
            }
            if (insert > 0) return true; else return false;

        }


        //Data search
        public static bool EscowListSearchBook(DataGrid grd, string key) //(Escrow Book)

        {
            int search = 0;
            SQLiteConnection cnt = new SQLiteConnection(DBconnection.DBaddress);
            SQLiteCommand cmd = new SQLiteCommand("Select * From tbl_EscrowList where BookName like '%" + key + "%' " , cnt);

            try
            {
                DataTable dataTableindatabase = new DataTable();
                SQLiteDataAdapter sqlAdaptor = new SQLiteDataAdapter(cmd);
                sqlAdaptor.Fill(dataTableindatabase);
                grd.ItemsSource = null;
                grd.ItemsSource = dataTableindatabase.DefaultView;
            }
            catch (Exception error404)
            {
                MessageBox.Show(error404.Message.ToString()); // mesaj kutusuna hatayı basacak
            }

            finally
            {
                cnt.Dispose();
            }
            if (search > 0) return true; else return false;
        }
        public static bool EscowListSearchUsername(DataGrid grd, string key) //(Username)

        {
            int search = 0;
            SQLiteConnection cnt = new SQLiteConnection(DBconnection.DBaddress);
            SQLiteCommand cmd = new SQLiteCommand("Select * From tbl_EscrowList where Username like '%" + key + "%' ", cnt);

            try
            {

                DataTable dataTableindatabase = new DataTable();
                SQLiteDataAdapter sqlAdaptor = new SQLiteDataAdapter(cmd);
                sqlAdaptor.Fill(dataTableindatabase);
                grd.ItemsSource = null;
                grd.ItemsSource = dataTableindatabase.DefaultView;
            }
            catch (Exception error404)
            {
                MessageBox.Show(error404.ToString()); // mesaj kutusuna hatayı basacak
            }

            finally
            {
                cnt.Dispose();

            }
            if (search > 0) return true; else return false;
        }


        //Data deletion
        public static bool deleteEscrowBookById(int dltID)
        {

            int del = 0;
            using (SQLiteConnection conn = new SQLiteConnection(DBconnection.DBaddress))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {
                    command.CommandText = "delete from tbl_EscrowList where BookName = " + dltID + "";


                    try
                    {
                        del = command.ExecuteNonQuery();
                    }
                    catch (SQLiteException e)
                    {
                        MessageBox.Show(e.ToString());
                        //Log
                        throw;
                    }
                }
                conn.Close();
                //conn.Dispose();
            }
            if (del > 0) return true; else return false;
        }



        ///Reader List
        //Grid fill / Data extraction
        public static bool GridFillInReaderList(DataGrid grd)
        {
            int checkdatagrid = 0;
            SQLiteConnection cnt = new SQLiteConnection(DBconnection.DBaddress);
            SQLiteCommand cmd = new SQLiteCommand("Select * From tbl_ReaderList ", cnt);

            try
            {
                DataTable dataTableindatabase = new DataTable();
                SQLiteDataAdapter sqlAdaptor = new SQLiteDataAdapter(cmd);
                sqlAdaptor.Fill(dataTableindatabase);
                grd.ItemsSource = null;
                grd.ItemsSource = dataTableindatabase.DefaultView;
            }
            catch (Exception error404)
            {
                MessageBox.Show(error404.ToString());
            }

            finally
            {
                cnt.Dispose();

            }
            if (checkdatagrid > 0) return true; else return false;
        }

        public static bool deleteReaderById(int dltID)
        {

            int del = 0;
            using (SQLiteConnection conn = new SQLiteConnection(DBconnection.DBaddress))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {
                    command.CommandText = "delete from tbl_ReaderList where ID = " + dltID + "";


                    try
                    {
                        del = command.ExecuteNonQuery();
                    }
                    catch (SQLiteException e)
                    {
                        MessageBox.Show(e.ToString());
                        //Log
                        throw;
                    }
                }
                conn.Close();
                //conn.Dispose();
            }
            if (del > 0) return true; else return false;
        }





        ///Expired List
        //Grid fill / Data extraction
        public static bool GridFillInExpiredList(DataGrid grd)
        {
            sbyte checkdatagrid = 0;
            SQLiteConnection cnt = new SQLiteConnection(DBconnection.DBaddress);
            SQLiteCommand cmd = new SQLiteCommand("select ec.ID, ec.ReaderID, ec.BookID, b.Barcode , ec.EscrowDate, ec.ReturnDate, b.BookName , b.Author, b.SubjectOfBook , b.PageNumber, b.Publisher, u.NameSurname, u.Email from tbl_EscrowList as ec inner join tbl_BookList as b on b.ID=BookID inner join tbl_Users as u on u.ID=ReaderID where ec.ReturnDate >= date()", cnt);

            try
            {

                DataTable dataTableindatabase = new DataTable();
                SQLiteDataAdapter sqlAdaptor = new SQLiteDataAdapter(cmd);
                sqlAdaptor.Fill(dataTableindatabase);
                grd.ItemsSource = null;
                grd.ItemsSource = dataTableindatabase.DefaultView;
            }
            catch (Exception error404)
            {
                MessageBox.Show(error404.ToString());
            }

            finally
            {
                cnt.Dispose();
            }
            if (checkdatagrid > 0) return true; else return false;
        }

        public static bool deleteExpiredBookById(int dltID)
        {

            int del = 0;
            using (SQLiteConnection conn = new SQLiteConnection(DBconnection.DBaddress))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {
                    command.CommandText = "delete from tbl_Expired where ID = " + dltID + "";


                    try
                    {
                        del = command.ExecuteNonQuery();
                    }
                    catch (SQLiteException e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }
                conn.Close();
                //conn.Dispose();
            }
            if (del > 0) return true; else return false;
        }



        ///Users
        //Data adding
        public static bool addUser(User data)
        {
            int insert = 0;
            using (SQLiteConnection conn = new SQLiteConnection(DBconnection.DBaddress))
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {


                    command.CommandText = "INSERT INTO tbl_Users(NameSurname,Password,Username,Email,Rank)  VALUES (@NameSurname,@Password, @Username,@Email,@Rank)";

                    command.Parameters.AddWithValue("@NameSurname", data.NameSurname);
                    command.Parameters.AddWithValue("@Password", data.Password);
                    command.Parameters.AddWithValue("@Username", data.Username);
                    command.Parameters.AddWithValue("@Email", data.Email);
                    command.Parameters.AddWithValue("@Rank", data.Rank);

                    try
                    {
                        insert = command.ExecuteNonQuery();
                    }
                    catch (SQLiteException e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }
                conn.Close();
                //conn.Dispose();
            }
            if (insert > 0) return true; else return false;

        }

        //Data Cryptography
        //Source: https://www.c-sharpcorner.com/article/compute-sha256-hash-in-c-sharp/ //Advanced #Programming​ with #C​, Lecture 6
        public static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}

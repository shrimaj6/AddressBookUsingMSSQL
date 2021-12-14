using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AddressBookUsingLINQ
{
    class AddressBookRepo
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AddressBook;Integrated Security=True";

        SqlConnection connection = new SqlConnection(connectionString);

        public bool AddAddressBooks(AddressBookModel model)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand command = new SqlCommand("SpAddressBookDetails", this.connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@FirstName", model.FirstName);
                    command.Parameters.AddWithValue("@LastName", model.LastName);
                    command.Parameters.AddWithValue("@Address", model.Address);
                    command.Parameters.AddWithValue("@City", model.City);
                    command.Parameters.AddWithValue("@State", model.State);
                    command.Parameters.AddWithValue("@Zip", model.Zip);
                    command.Parameters.AddWithValue("@Phone_No", model.Phone_No);
                    command.Parameters.AddWithValue("@Email", model.Email);

                    this.connection.Open();
                    var result = command.ExecuteNonQuery();

                    this.connection.Close();
                    if (result != 0)
                    {
                        return true;
                    }
                    return false;


                    
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }
            finally
            {
                this.connection.Close();
            }
        }
    }
}

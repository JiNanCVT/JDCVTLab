using CalligraphySample.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.ObjectModel;

namespace CalligraphySample.DataHelper
{
    public static class CalligrapherDataHelper
    {
        public static ObservableCollection<Calligraphyer> Load()
        {
            ObservableCollection<Calligraphyer> calligraphyers = new ObservableCollection<Calligraphyer>();

            var cnn = DataHelper.CreateConnection();
            string sql = "select * from  T_Calligrapher";
            SqlCommand cmmd = new SqlCommand(sql, cnn);
            cnn.Open();
            var reader = cmmd.ExecuteReader();
            while (reader.Read())
            {
                Calligraphyer c = new Calligraphyer((Guid)reader["ID"], (string)reader["Name"], (string)reader["Description"]);
                calligraphyers.Add(c);
            }
            cnn.Close();
            return calligraphyers;
        }

        public static void Insert(Calligraphyer c)
        {
            var cnn = DataHelper.CreateConnection();
            string sql = @"INSERT INTO T_Calligrapher
                (ID,Name, Description) VALUES   (@ID, @Name, @Description)";
            SqlCommand cmmd = new SqlCommand(sql, cnn);
            cmmd.Parameters.Add(new SqlParameter("ID", c.Id));
            cmmd.Parameters.Add(new SqlParameter("Name", c.Name));
            cmmd.Parameters.Add(new SqlParameter("Description", c.Description));
            cnn.Open();
            cmmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}

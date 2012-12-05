using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseSampleConsole
{
    public class Data
    {
        /// <summary>
        /// 创建数据库连接
        /// </summary>
        /// <returns>数据库连接</returns>
        private static SqlConnection GetConnection()
        {
            SqlConnection cnn = new SqlConnection();
            //连接字符串
            cnn.ConnectionString = @"Data Source=JUSTAPC\SQLDEV;Initial Catalog=CalligraphyTeachingSample;Persist Security Info=True;User ID=sa;Password=zuolun";
            return cnn;
        }

        /// <summary>
        /// 读取数据（书法家)
        /// </summary>
        public static void ReadCalligrapherData()
        {
            SqlConnection cnn = GetConnection();

            //查询字符串，查询所有的书法家
            string sql = "select * from T_Calligrapher";

            //命令
            SqlCommand cmd = new SqlCommand(sql, cnn);

            //打开连接
            cnn.Open();

            //执行命令返回Reader
            SqlDataReader reader = cmd.ExecuteReader();

            Console.WriteLine("读取所有数据（书法家）");

            //遍历数据
            //Read到最后一行，Read（）返回false，退出循环
            while(reader.Read())
            {
                //读取当前行第一列的数据
                int id = (int)reader[0];
                //读取当前行第二列的数据
                string name = (string)reader[1];
                //拼字符串
                string str = string.Format("ID = {0}, Name = {1}", id, name);
                Console.WriteLine(str);
            }

            //关闭连接
            cnn.Close();
        }

        /// <summary>
        /// 加载数据（书法家）到实体类，带条件
        /// </summary>
        public static void ReadCalligrapherToEntities()
        {
        }
    }
}

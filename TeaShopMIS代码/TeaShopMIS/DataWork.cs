using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TeaShopMIS
{
    class DataWork
    {

        static string connstr = ConfigurationManager.AppSettings["DBConn"];

        /// <summary>
        /// 数据查询操作
        /// </summary>
        /// <param name="str">ＳＱＬ查询语句</param>
        /// <returns>数据查询结果DataTable</returns>
        public static DataTable DataQuery(string str)
        {
            SqlConnection conn = new SqlConnection(connstr);

            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(str, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            conn.Close();

            return dt;
        }

        /// <summary>
        /// 数据操作函数（增删改）
        /// </summary>
        /// <param name="str">ＳＱＬ增删改语句</param>
        /// <returns>受影响的行数</returns>
        public static int DataExecute(string str)
        {
            SqlConnection conn = new SqlConnection(connstr);

            conn.Open();

            SqlCommand cmd = new SqlCommand(str, conn);

            int i = cmd.ExecuteNonQuery();

            conn.Close();

            return i;
        }


        // <summary>
        /// 数据操作函数(插入数据并返回id
        /// </summary>
        /// <param name="str">输入参数：插入语句</param>
        /// <returns>返回值：生成的记录ID</returns>
        public static int ExecuteScalar(string str)
        {
            //1、创建并打开数据库连接          
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);//2、创建执行对象
            int i = int.Parse(cmd.ExecuteScalar().ToString());  //3、执行操作，返回生成的记录ID
            conn.Close(); //4、关闭连接
            return i;    //5、返回结果
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection objCon, objCon2;
    SqlCommand objCmd, objCmd2;
    SqlDataReader objDR, objDR2;
    string strDbCon, strDbCon2, strallSQL, srtqrySQL;

    protected void Page_Load(object sender, EventArgs e)
    {
        /* 資料庫連接字串 */
        strDbCon = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                   "AttachDbFilename=" +
                   Server.MapPath("App_Data\\Product.mdf") +
                   ";Integrated Security=True";

        /* 建立Connection物件 */
        objCon = new SqlConnection(strDbCon);
        /* 開始資料庫連接  */
        objCon.Open();
        /*建立Command物件的SQL指令 */
        strallSQL = "SELECT * FROM Product";
        /*取得DataReader物件 */
        objCmd = new SqlCommand(strallSQL, objCon);

        objDR = objCmd.ExecuteReader();
        if (objDR.HasRows)
        {
            /* 顯示資料表的記錄 */
            showdb.Text = " ";

            while (objDR.Read())
            {
                showdb.Text += objDR["number"] + " - ";
                showdb.Text += objDR["price"] + "<br />";
            }
        }
        else
        {
            showdb.Text = "資料表中沒有記錄資料!";
        }
        objDR.Close(); // 關閉DataReader
        objCon.Close(); // 關閉資料庫連接
    }

    protected void imds_Click1(object sender, EventArgs e)
    {
        string temQrytn;
        
        temQrytn = querytbx.Text;
        
        /* 資料庫連接字串 */
        strDbCon2 = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                   "AttachDbFilename=" +
                   Server.MapPath("App_Data\\Product.mdf") +
                   ";Integrated Security=True";

        /* 建立Connection物件 */
        objCon2 = new SqlConnection(strDbCon);
        /* 開始資料庫連接  */
        objCon2.Open();
        /*建立Command物件的SQL指令 */
        srtqrySQL = "SELECT * FROM Product WHERE number ='" + temQrytn + "'";
        /*取得DataReader物件 */
        objCmd2 = new SqlCommand(srtqrySQL, objCon2);

        objDR2 = objCmd2.ExecuteReader();
        if (objDR2.HasRows)
        {
            /* 顯示資料表的記錄 */
           qrylab .Text = " ";

            while (objDR2.Read())
            {
              qrylab.Text += objDR2["number"] + " - ";
              qrylab.Text += objDR2["price"] + "<br />";
           
            }
        }
        else
        {
                qrylab.Text = "資料表中沒有記錄資料!";
        }
        objDR2.Close(); // 關閉DataReader
        objCon2.Close(); // 關閉資料庫連接
    }
}
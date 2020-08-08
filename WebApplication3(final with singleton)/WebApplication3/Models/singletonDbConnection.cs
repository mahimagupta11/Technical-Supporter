using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class singletonDbConnection
    {
        private singletonDbConnection()
        {
           con=new SqlConnection("Data Source=DESKTOP-QD0ODA9\\SQLEXPRESS;Initial Catalog=TSS;Integrated Security=True");
        }
        public static int count = 0;

        //  static string strcon = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        //// public SqlConnection con = new SqlConnection(strcon);
        public SqlConnection con = null;// new SqlConnection("Data Source=DESKTOP-2V8VSA9;Initial Catalog=TSS;Integrated Security=True");
      // public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

       private static readonly object lockObject = new object();
        private static singletonDbConnection instance;
       /* public singletonDbConnection Instance
        {
            get
            {
                if (instance == null)
                {
                   // lock (lockObject)
                    //{
                       // if (instance == null)
                       // {
                            instance = new singletonDbConnection();

                       // }
                    ////}
                }
                return instance;
            }


        }*/

        public static singletonDbConnection getobj()
        {
            if (instance == null)
            {
                 lock (lockObject)
                {
                 if (instance == null)
                 {
                instance = new singletonDbConnection();
         
                     }
                }
            }
            return instance;
        }
        public  SqlConnection Con
        {
            get
            {
                //count1++;
                return con;

            }

        }
    }
}

/*
public class singletonDbConnection
{
    private singletonDbConnection()
    {


    }
    public static int count = 0;
    public static int count1 = 0;
    static string strcon = "Data Source=DESKTOP-2V8VSA9;Initial Catalog=TSS;Integrated Security=True";
    public SqlConnection con = new SqlConnection(strcon);
    // public SqlConnection con= null;
    private static singletonDbConnection instance;
    public static singletonDbConnection Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new singletonDbConnection();
                // con = new SqlConnection();
                count++;
            }
            return instance;
        }
    }

    public int getcount()
    {
        return count;
    }
    public SqlConnection Con
    {
        get
        {
            //count1++;
            return con;

        }

    }
}
//public SqlConnection getconnect()
//{

//    string strcon = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
//    SqlConnection con = new SqlConnection(strcon);
//    return con;
//}
//public int getCount()
//{
//    return count;
}*/







//public class Singleton
//{
//    private static Singleton jdbc;
//    String url = "jdbc:oracle:thin:@localhost:1521:orcl";
//    String user = "scott";
//    String pass = "tiger";
//    Connection con = null;

//    private Singleton() { }
//    public static Singleton getInstance()
//    {
//        if (jdbc == null)
//        {
//            jdbc = new Singleton();
//        }
//        return jdbc;
//    }

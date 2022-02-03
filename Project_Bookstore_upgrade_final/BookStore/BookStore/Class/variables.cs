using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Class
{
    class variables
    {
        public static string p_username_focus = "Enter user name";
        public static string p_userpassword_focus = "Enter password";
        public static string p_msg_username = "User login : ";
        public static string p_msg_password = "User password : ";
        public static string p_msg_user_Invalid = "Invalid User Credentials.";


        public static string p_branchcode = string.Empty;
        public static string p_subofbranchcode = string.Empty;
        public static string p_inputter = string.Empty;
        public static string p_user_id = string.Empty;
        public static string p_profile_id = string.Empty;
        public static string p_profile_name = string.Empty;
        public static string p_sysstem_control = string.Empty;

        public static Boolean p_EnableForm = true;


        /// Connection Sql server 
        public static string p_Connection = string.Empty;
        public static SqlConnection p_con = new SqlConnection();

        //Form Tittle
        public static string p_version = "v1.0.0";
        public static string p_frm_register = "Register branch "+ p_version;
        public static string p_frm_exchange = "Exchange rate information "+ p_version;
        public static string p_frm_pos_list = "Pos list "+ p_version;
        public static string p_frm_customer = "Register customer "+ p_version;
        public static string p_frm_supply = "Register suppply "+ p_version;
        public static string p_frm_product_line = "Register product line "+ p_version;
        public static string p_frm_author = "Register author " + p_version;
        public static string p_frm_publish = "Register publish " + p_version;

        public static string p_exchangerateinfo = string.Empty;
        public static string p_bestcurrencycode = string.Empty;
        public static string p_secondcurrencycode = string.Empty;
        public static string p_bestcurrencysymbol = string.Empty;
        public static string p_secondcurrencysymbol = string.Empty;
        public static Boolean p_exchange = false;

        public static float p_exchangerate = 0;
        public static float p_beasecurrency = 0;
        public static float p_secondcurrecy = 0;

        //Form Message
        public static string p_message_titil = "Book Store " + p_version;
        public static string p_message_successful = "Book Store " + p_version;

        public static string p_message_insert = "Record has been registered completed ! ";
        public static string p_message_updated = "Record has been updated completed ! ";
        public static string p_message_purchase = "Purchase order has been completed ! ";





    }
}

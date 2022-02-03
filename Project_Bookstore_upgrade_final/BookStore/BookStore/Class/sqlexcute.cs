using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Class
{
    class sqlexcute
    {
        SqlCommand p_cmd;
        public DataTable getdata(string vSql)
        {
            DataTable dt = new DataTable();
            using (p_cmd=new SqlCommand(vSql, variables.p_con))
            {
                if (variables.p_con.State == ConnectionState.Closed)
                {
                    variables.p_con.Open();
                }
                p_cmd.CommandTimeout = 99999999;
                dt.Load(p_cmd.ExecuteReader());
                variables.p_con.Close();
            }
           return dt;
        }

        public DataTable proc_getdata(string vproc_name,string[] param)
        {
            DataTable dt = new DataTable();
            string str = vproc_name + " ";
            for(int i=0; i < param.Length; i++)
            {
                str = str + "N'" + param[i] + "',";
            }
            str = str.Substring(0,str.Length-1);
            using (p_cmd = new SqlCommand(str, variables.p_con))
            {
                if (variables.p_con.State == ConnectionState.Closed)
                {
                    variables.p_con.Open();
                }
                p_cmd.CommandTimeout = 99999999;
                dt.Load(p_cmd.ExecuteReader());
                variables.p_con.Close();
            }
            return dt;
        }


        public void Filter_ComboBox(ComboBox Cbo, string SQL, string Val, string ID)
        {
            Cbo.DataSource = getdata(SQL);
            Cbo.ValueMember = ID;
            Cbo.DisplayMember = Val;
            Cbo.AutoCompleteMode = AutoCompleteMode.Suggest;
            Cbo.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        public void Filter_ComboBox(KryptonComboBox Cbo, string SQL, string Val, string ID)
        {
            Cbo.DataSource = getdata(SQL);
            Cbo.ValueMember = ID;
            Cbo.DisplayMember = Val;
            Cbo.AutoCompleteMode = AutoCompleteMode.Suggest;
            Cbo.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        public bool IsNumeric(object Expression)
        {
            double retNum;
            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        public bool cbo_empty(ComboBox cbo)
        {
            if (cbo.SelectedItem == null || cbo.SelectedIndex == -1 || string.IsNullOrEmpty(cbo.Text) || cbo.SelectedValue.ToString() == string.Empty)
            {
                return false;
            }
            return true;
        }

        public bool cbo_empty(KryptonComboBox cbo)
        {
            if (cbo.SelectedItem == null || cbo.SelectedIndex == -1 || string.IsNullOrEmpty(cbo.Text) || cbo.SelectedValue.ToString() == string.Empty)
            {
                return false;
            }
            return true;
        }

        public string Rights(string value, int length)
        {
            if (String.IsNullOrEmpty(value)) return string.Empty;

            return value.Length <= length ? value : value.Substring(value.Length - length);
        }

        public double Rounds(decimal Value)
        {
            int Values = (int)Value;
            try
            {
                string s = Values.ToString();
                string s1 = "";
                if (Convert.ToDouble(Rights(Values.ToString(), 2)) < 50)
                {
                    Values = Convert.ToInt32(Left(Values.ToString(), s.Length - 2));
                    s1 = Values.ToString() + "00";
                    Values = Convert.ToInt32(s1);
                }
                else
                {
                    Values = Convert.ToInt32(Left(Values.ToString(), s.Length - 2));
                    s1 = Values.ToString() + "00";
                    Values = Convert.ToInt32(s1);
                    Values = Values + 100;
                }

            }
            catch { }
            return Values;
        }
        public string Left(string str, int length)
        {
            return str.Substring(0, Math.Min(length, str.Length));
        }

        public string control_name(object sender, EventArgs e)
        {
            try
            {
                string vMenuID = string.Empty;
                if (sender is TextBox)
                {
                    TextBox obj = (TextBox)sender;
                    vMenuID = obj.Name;
                }
                else if (sender is Label)
                {
                    Label obj = (Label)sender;
                    vMenuID = obj.Name;
                }
                else if (sender is Bunifu.Framework.UI.BunifuCards)
                {
                    Bunifu.Framework.UI.BunifuCards obj = (Bunifu.Framework.UI.BunifuCards)sender;
                    vMenuID = obj.Name;
                }
                else if (sender is KryptonButton)
                {
                    KryptonButton obj = (KryptonButton)sender;
                    vMenuID = obj.Name;
                }

                else if (sender is PictureBox)
                {
                    PictureBox obj = (PictureBox)sender;
                    vMenuID = obj.Name;
                }

                return vMenuID;
            }
            catch
            {
                return string.Empty;
            }
        }

        public void exchangerate(string vstatus)
        {
            try
            {
                DataTable dt = new DataTable();
                string[] p =
                {
                    vstatus,
                    variables.p_branchcode
                };
                dt = proc_getdata("proc_exchange_rate", p);
                if (dt.Rows.Count > 0)
                {
                    if(dt.Rows[0]["bestcurrency"].ToString()=="" || dt.Rows[0]["bestcurrency"].ToString() == string.Empty)
                    {
                        variables.p_exchange = false;
                    }
                    else
                    {
                        variables.p_exchange = true;
                    }

                    variables.p_exchangerateinfo = dt.Rows[0]["exchangeinfo"].ToString();
                    variables.p_bestcurrencycode = dt.Rows[0]["bestcurrency"].ToString();
                    variables.p_secondcurrencycode = dt.Rows[0]["secondcurrency"].ToString();
                    variables.p_bestcurrencysymbol = dt.Rows[0]["bestsymbol"].ToString();
                    variables.p_secondcurrencysymbol = dt.Rows[0]["secondsymbol"].ToString();
                    float.TryParse(dt.Rows[0]["bestexchange"].ToString(), out variables.p_beasecurrency);
                    float.TryParse(dt.Rows[0]["secondcurrency"].ToString(), out variables.p_secondcurrecy);
                }
            }
            catch { }
        }

        public  bool IsValidEmail(string eMail)
        {
            bool Result = false;

            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(eMail);
                Result = (eMail.LastIndexOf(".") > eMail.LastIndexOf("@"));
            }
            catch
            {
                Result = false;
            };

            return Result;
        }
    }
}

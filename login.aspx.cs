using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; //this namespace is for sqlclient server  
using System.Configuration; // 
using System.Windows;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace HotelProsj4
{
    public partial class login : System.Web.UI.Page
    {
        private HotelProjectEntities dx = new HotelProjectEntities();
 
        protected void Page_Load(object sender, EventArgs e)
        {
            String error = Label4.Text;

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string box11 = box1.Text;
            int box12 = int.Parse(box11);
            string box22 = box2.Text;
            dx.Customers.Load();
            Customer c = dx.Customers.Where(u => u.Phone_nr.Equals(box12)).FirstOrDefault();

            if (c != null)
            {
                if (box22.Equals(c.Password))
                {
                    Session["phone"] = c.Phone_nr;
                    //Session["name"] = c.FirstName;
                    //Session["user"] = c;
                    Response.Redirect("reservation.aspx");
                } else
                {
                    Label4.Text = "WRONG PASSWORD GIRLL";
                    Response.Redirect("login.aspx");
                }
            }
        }
    }
}

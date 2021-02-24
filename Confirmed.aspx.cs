using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; //this namespace is for sqlclient server  
using System.Configuration; // //
using System.Windows;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace HotelProsj4
{
    public partial class Confirmed : System.Web.UI.Page
    {
        HotelProjectEntities dx = new HotelProjectEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            dx.Customers.Load();
            dx.Reservations.Load();

            if (Session["phone"] != null)
            {
                string ph = (Session["phone"]).ToString();
                int phonenum = int.Parse(ph);
                Customer c = dx.Customers.Where(u => u.Phone_nr.Equals(phonenum)).FirstOrDefault();
                Reservation r = dx.Reservations.Where(u => u.Phone_nr.Equals(phonenum)).LastOrDefault();

                Confirm.Text = "Dear " + c.FirstName + " " + c.LastName + ", we hope you will enjoy your stay at Starlight Hotel."
                    + "<br>nHere is your reservation(s)";

                    Res.Text = "<br>Check in: " + r.Check_in + "<br>Check out: " + r.Check_out + "<br>rice: "
                        + r.price + ".";
            }
            }
    }
}
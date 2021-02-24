using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HotelProsj4
{
    public partial class checkbooking : System.Web.UI.Page
    {
        HotelProjectEntities dx = new HotelProjectEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["phone"] != null)
            {
                string ph = (Session["phone"]).ToString();
                int phonenum = int.Parse(ph);
                Customer cu = dx.Customers.Where(u => u.Phone_nr.Equals(phonenum)).FirstOrDefault();

                List<Reservation> reslist = new List<Reservation>();

                reslist = dx.Reservations.Where(u => u.Phone_nr.Equals(phonenum)).ToList();

                welcomegirl.Text = "Dear " + cu.FirstName + ", here are your booking(s).";

                if (reslist != null)
                {
                    foreach (Reservation r in reslist)
                    {
                        Label1.Text = Label1.Text + "<br>" + "Check-in time: " + r.Check_in + "<br>" + 
                            "Check-out time: " + r.Check_out + "<br>" + "Price: " + r.price + "<br>";

                    }
                } else
                {
                    Label1.Text = "You do not have any reservations.";
                }
            }
            else
            {
                Label1.Text = "You need to log in to see your reservations.";

            }

        }
    }
}
    

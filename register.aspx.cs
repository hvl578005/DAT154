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
    public partial class register : System.Web.UI.Page
    {

        private HotelProjectEntities dx = new HotelProjectEntities();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dx.Customers.Load();

            Customer cu = new Customer();
            cu.Phone_nr = Int32.Parse(box1.Text);
            cu.FirstName = box2.Text;
            cu.LastName = box3.Text;
            cu.Password = box4.Text;
            Session["phone"] = cu.Phone_nr;

            dx.Customers.Add(cu);
            dx.SaveChanges();

            Response.Redirect("Reservation.aspx");
        }
    }
}
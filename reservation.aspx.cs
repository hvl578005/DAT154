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
    public partial class reservation : System.Web.UI.Page
    {
        HotelProjectEntities dx = new HotelProjectEntities();
        Customer c;
        int phonenum;

        protected void Page_Load(object sender, EventArgs e)
        {
            //dx.Load();
            dx.Customers.Load();

            if (Session["phone"] != null)
            {
                string ph = (Session["phone"]).ToString();
                phonenum = int.Parse(ph);
                //int phonenum = (Session["phone"]);
                c = dx.Customers.Where(u => u.Phone_nr.Equals(phonenum)).FirstOrDefault();
                welcomegirl.Text = "Welcome " + c.FirstName + " " + c.LastName + "!";

                Beds.Text = "1 bed";
                Price.Text = "500";
            }
        }

        public void Selection_Change(Object sender, EventArgs e)
        {

            DateTime x = DateTime.Parse(TextBox1.Text);
            DateTime y = DateTime.Parse(TextBox2.Text);
            int xy = x.Day;
            int yx = y.Day;

            if (DropDownList1.SelectedValue == "Double")
            {
                Beds.Text = "2 beds";
                Price.Text = "700";
            }
            else if (DropDownList1.SelectedValue == "Deluxe")
            {
                Beds.Text = "2 beds, 1 sofa";
                Price.Text = "1000";
            }
            else
            {
                Beds.Text = "1 bed";
                Price.Text = "500";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dx.Reservations.Load();
            dx.Rooms.Load();
            String quality = DropDownList1.SelectedValue;

            DateTime x = DateTime.Parse(TextBox1.Text);
            DateTime y = DateTime.Parse(TextBox2.Text);
            int pris = y.Day - x.Day;

            List<Room> roomList = dx.Rooms.Where(rm => rm.Quality == quality).ToList();

            List<int> resList = dx.Reservations
                .Where(res => (res.Check_in >= x && res.Check_out <= y) || (res.Check_in >= y && res.Check_out <= y) || (res.Check_in <= x && res.Check_out >= x) || (res.Check_in <= x && res.Check_out >= y))
                .Select(row => row.Room_id).ToList();

            List<Room> ledige = new List<Room>();

            foreach (Room item in dx.Rooms)
            {
                if (!resList.Contains(item.Room_id))
                {
                    if(item.Quality == quality) ledige.Add(item);
                }
            }

            if (ledige.FirstOrDefault() != null)
            {
                Reservation re = new Reservation();
                Room r = ledige.FirstOrDefault();
                re.Phone_nr = phonenum;
                re.Room_id = r.Room_id;
                re.Check_in = x;
                re.Check_out = y;
                re.price = r.Price*pris;

                dx.Reservations.Add(re);
                dx.SaveChanges();

                Response.Redirect("Confirmed.aspx");
            }
            else
            {
                welcomegirl.Text = "Cannot book room is taken";
            }
        }
    }
}
using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationLayerWeb
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StudentBusiness Conn = new StudentBusiness();
            listBoxStudents.Items.Clear();
            foreach (Student s in Conn.GetAllStudents())
            {
                listBoxStudents.Items.Add(s.ToString());
            }
        }
    }
}
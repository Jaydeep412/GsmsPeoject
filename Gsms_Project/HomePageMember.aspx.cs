﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gsms_Project
{
    public partial class HomePageMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bmiBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("BMICalculator.aspx");
        }

        protected void conltBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListOfConsultant.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("WelcomePage.aspx");
        }
    }
}
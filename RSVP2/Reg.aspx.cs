﻿using RSVP2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RSVP2
{
    public partial class Reg : System.Web.UI.Page
    {
        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Summary.aspx");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (IsPostBack)
            { 


                GuestResponse rsvp = 
                    new GuestResponse(name.Text, email.Text, phone.Text, CheckBoxYN.Checked);
                ResponseRepository.GetRepository().AddResponse(rsvp);

                if (rsvp.WillAttend.HasValue && rsvp.WillAttend.Value) 
                    { Response.Redirect("seeyouthere.html"); } 
                else { Response.Redirect("sorryyoucantcome.html"); }
            }
        }

        
    }
}
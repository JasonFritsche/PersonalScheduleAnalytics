﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmDashboard : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string username = Session["UserName"].ToString();
        usernameLabel.InnerText = username;
    }

    protected void LnkBtnUpdateUsers_Click(object sender, EventArgs e)
    {

    }

    protected void LnkBtnUpdateCategories_Click(object sender, EventArgs e)
    {

    }

    protected void LnkBtnUpdateTimeSheets_Click(object sender, EventArgs e)
    {

    }

    protected void LnkBtnExitApp_Click(object sender, EventArgs e)
    {

    }
}
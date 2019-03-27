using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Visitor : System.Web.UI.Page
{
    string imgurl = "http://localhost:63434/Images/france_river_lake_215018.jpg";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        SubmitImg();
    }
    void SubmitImg()
    {
        img.ImageUrl = imgurl;
    }
}
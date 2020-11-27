﻿using NorthwindSystem.BLL;
using NorthwindSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class ProductGridViewCustomized : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductController sysmgr = new ProductController();
            List<Product> info = sysmgr.ListAllProducts();
            ProductGrid.DataSource = info;
            ProductGrid.DataBind();
        }
    }
}
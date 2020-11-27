using NorthwindSystem.BLL;
using NorthwindSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class SimplyQuery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                RegionController sysmgr = new RegionController();
                List<Region> info = sysmgr.ListAllRegions();

                AllRegions.DataSource = info;
                AllRegions.DataBind();

                RegionsDDL.DataSource = info;
                RegionsDDL.DataValueField = "RegionID";
                RegionsDDL.DataTextField = "RegionDescription";
                RegionsDDL.DataBind();
            }
        }

        protected void RegionDDLSearch_Click(object sender, EventArgs e)
        {
            RegionController sysmgr = new RegionController();
            Region info = sysmgr.FindRegionByID(int.Parse(RegionsDDL.SelectedValue));

            RegionID.Text = info.RegionID.ToString();
            RegionDescription.Text = info.RegionDescription;
        }

        protected void RegionSearch_Click(object sender, EventArgs e)
        {

            //connection to an instance of the controller class
            RegionController sysmgr = new RegionController();

            Region info = sysmgr.FindRegionByID(int.Parse(RegionArg.Text));

            RegionID.Text = info.RegionID.ToString();
            RegionDescription.Text = info.RegionDescription;

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using NorthwindSystem.DAL;
using NorthwindSystem.Entities;
#endregion

namespace NorthwindSystem.BLL
{
    //This class will be accessed by the webpage
    //The webpage is in a seperate project so this class needs to be public

    public class RegionController
    {
        //The BLL is the interface to the system and contains methods to be used from the outside user (Presentation Layer) like the webpage
        //These methods must be public

        //Generally 2 types of lookups
        //1. Find a record by the PK
        //2. Get all records in a particular table

        //Lookup by PK
        public Region FindRegionByID(int regionID)
        { 
            //Using closes and destroys resources when you are done with them
            using(var context = new NorthwindSystemContext())
            {
                //There are methods in EF that allow you to do some common queries
                //This example will allow you to search by PK
                //So since this is a common search something was created already in EF for us to do this search
                return context.Regions.Find(regionID);
            }
        }

        public List<Region> ListAllRegions()
        {
            using (var context = new NorthwindSystemContext())
            {
                //This method will you to retrieve all the records of your DbSet
                //DbSet is not a list so you have to convert it to a list to return
                return context.Regions.ToList();
            }
        }
    }
}

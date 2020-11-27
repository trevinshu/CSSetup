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
    public class ProductController
    {
        public List<Product> ListAllProducts()
        {
            using (var context = new NorthwindSystemContext())
            {
                //This method will you to retrieve all the records of your DbSet
                //DbSet is not a list so you have to convert it to a list to return
                return context.Products.ToList();
            }
        }
    }
}

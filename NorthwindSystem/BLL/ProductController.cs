using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Additional Namespaces
using NorthwindSystem.DAL;
using NorthwindSystem.Entities;
using System.ComponentModel;
#endregion


namespace NorthwindSystem.BLL
{
    [DataObject(true)]
    public class ProductController
    {
        [DataObjectMethod(DataObjectMethodType.Select,true)]
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

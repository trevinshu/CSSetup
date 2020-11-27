using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion

namespace NorthwindSystem.Entities
{
    //Annotations are used to assist Entity Framework in the mapping of your class to the SQL table
    //Annotations are placed BEFORE the property
    [Table("Products")]
    public class Product
    {
        private string _QuantityPerUnit;
        //If you use the same as the SQL attribute for your property name, order of the properties does not matter
        //If the propery names are different then you must have them in the same or as the table
        //https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/sql-server-data-type-mappings
        //If the attribute in the SQL table is nullable we place a ? after the datatype(we do not do this for strings)
        //[Key] is a single attribute Primary Key

        //For composite keys we need to specify an order 
        //[Key, Column(order = 1)]
        //public int firstCompositePKAttributeID{get;set;}
        //[Key, Column (order =2)]
        //public int secondCompositePKAttributeID{get;set;}

        //The full definition of the [Key] annotation is 
        //[Key, DatabaseGenerated(DatabaseGeneratedOption.xxxx)]
        //.xxxx - > Identity: Primary key on the SQL table is Identity. Identity is the default so we can just use [Key]
        //      - > None: Primary Key is not identity, user supplied
        [Key]
        public int ProductID { get; set; }
        //validation annotations(sql constraints and null/not null)
        //Should put validations on. It is optional but a good idea
        //Required does not need a message but it displays a poor message if you don't provide one
        [Required(ErrorMessage = "Product Name is required")]
        [StringLength(40, ErrorMessage = "Product Name is limited to 40 characters")]
        public string ProductName { get; set; }

        //Foreign Keys
        //The only time we need to use [ForeignKey] is if the FK table does not have the same name FK attribute as the PK attribute in the parent
        //OR if your property name is not the same name as the attribute in the SQL table
        public int? SupplierID { get; set; }
        public int? CategoryID { get; set; }
        //We can use fully implemented properties with mapping. Let's do this for nullable string fields to send a null to the DB instead of "". We did this in Razor
        //public string QuantityPerUnit { get; set; }
        //Create a fully implemented property for QuantityPerUnit that sets a NULL instead of nothing
        public string QuantityPerUnit
        {
            get
            {
                return _QuantityPerUnit;
            }
            set
            {
                _QuantityPerUnit = string.IsNullOrEmpty(value) ? null : value;
            }
        }
        [Range(0.00, double.MaxValue, ErrorMessage = "Unit Price must be 0.00 or greater")]
        public decimal? UnitPrice { get; set; }
        [Range(0.00, Int16.MaxValue, ErrorMessage = "Units In Stock  must be 0 or greater")]
        public Int16? UnitsInStock { get; set; }
        [Range(0.00, Int16.MaxValue, ErrorMessage = "Units On Order must be 0 or greater")]
        public Int16? UnitsOnOrder { get; set; }
        [Range(0.00, Int16.MaxValue, ErrorMessage = "Reorder 0 must be 0 or greater")]
        public Int16? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        [NotMapped]
        public string ProductNameScream
        {
            get
            {
                return ProductName.ToUpper();
            }
        }
    }
}

//Create the Region Entity
//Complete Exercise 5 Entities



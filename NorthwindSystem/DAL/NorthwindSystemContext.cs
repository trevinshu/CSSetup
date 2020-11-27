using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.Data.Entity;
using NorthwindSystem.Entities;
#endregion

namespace NorthwindSystem.DAL
{
    //The DAL class is responsible for the communication between the DB and the Library project(NorthwindSystem)
    //We have a connection string that points to the DB. The DAL class will use that with the EF

    //We want to restrict access to this class only to other classes in the same library project (NorthwindSystem)
    //Therefore the access is INTERNAL


//WE need to inherit from the DBContext class.It contains classes and methods to allow us to interact with the DB
//DB Context allows
    //Manage database connection
    //query the database
    //save data to the database

    internal class NorthwindSystemContext:DbContext
    {
        //We need a constructor that passes the connection string to the EF via the inherited DbContect class
        //So, we pass the connection string name to the DbContext of EF to reference the DB
        public NorthwindSystemContext():base("NWDB")
        {
        }

        //Properties to interact with EF
        //These properties represent the table and the data in that table

        //Our NorthwindSystem project has many references that contain methods, properties and classes coded by others that enable us to do many things. We need to add on to that functionality with some customer properties.


        //Think of a DbSet as a reference to the entity which contains the data from the database
        //You need a DBSet for each entity that you have

        public DbSet<Product> Products { get; set; }
        public DbSet<Region> Regions { get; set; }

    }
}

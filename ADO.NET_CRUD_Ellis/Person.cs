using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_CRUD_Ellis
{
    public class Person
    {
       public int BusinessEntityID { get; set; }
        public string PersonType { get; set; }
        public int NameStyle { get; set; }
        public string FirstName { get; set; }
        public string ?MiddleName { get; set; }
        public string LastName { get; set; }
        public string ?Suffix { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{FirstName} {MiddleName} {LastName} {Suffix} {BusinessEntityID} {PersonType} {NameStyle}";
            }
        }
        public string Name
        {
            get
            {
                return $" {LastName}, {FirstName} {MiddleName}: {BusinessEntityID}";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ADO.NET_CRUD_Ellis
{
    public class DataAccess
    {
        public List<Person> getPerson(string businessEntityID)
        {
            try
            {
                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AW2019")))
                {
                    var output = connection.Query<Person>("dbo.spPeople_getPerson @BusinessEntityID", new { BusinessEntityID = businessEntityID }).ToList();
                    return output;
                }
            }
            catch (Exception ex)
            {
                return null;            
            }

        }

        public List<Person> getAllPeople()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AW2019")))
            {
                var output = connection.Query<Person>("dbo.spPeople_getAll").ToList();
                return output;
            }
        }
    }
}

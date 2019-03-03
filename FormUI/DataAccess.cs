using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FormUI
{
    public class DataAccess
    {
        public List<Post> GetPosts(string title)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PlutoContext")))
            {
                List<Post> output = connection.Query<Post>($"SELECT * FROM Posts WHERE Title = '{title}'").ToList();
                return output;
            }
        }
    }
}
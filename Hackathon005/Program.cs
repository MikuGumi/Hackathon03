using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Hackathon005
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlCommand cmd;
            SqlConnection con;
            con = new SqlConnection("Data Source=DESKTOP-8JARA15; Initial Catalog=Hackathon005; Integrated Security=True");
            con.Open();
            string[] lines = System.IO.File.ReadAllLines(@"D:\test03.TXT");
            string insertQuery = "insert into Hackathon005(TickNumber,FlyingDay,Birthday) values(@TickNumber,@FlyingDay,@Birthday)";

            using (cmd = new SqlCommand(insertQuery, con))
            {
                cmd.Parameters.Add("@TickNumber", SqlDbType.NChar);
                cmd.Parameters.Add("@FlyingDay", SqlDbType.DateTime);
                cmd.Parameters.Add("@Birthday", SqlDbType.DateTime);
            };

            foreach (string line in lines)
            {
                string a = line.Substring(0, 3);
                if (line.Substring(0, 3) == "695" || line.Substring(0, 3) == "525")
                {
                    cmd.Parameters["@TickNumber"].Value = line.Substring(0, 13);
                    cmd.Parameters["@FlyingDay"].Value = DateTime.ParseExact(line.Substring(13, 8), "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    cmd.Parameters["@Birthday"].Value = DateTime.ParseExact(line.Substring(21, 8), "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    cmd.ExecuteNonQuery();
                }


            }

            Console.ReadLine();

        }        
    }
}

using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProjectBikeStore.Models.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBikeStore.Services
{
    public class ReadMTResultService
    {
        public static System.Data.DataSet ExecReadData(DochDochContext _context,string sql)
        {
            var ds =new System.Data.DataSet();
            string conStr = _context.Database.GetConnectionString();
            var conn = new SqlConnection(conStr);
            var da = new SqlDataAdapter(sql,conn);
            
            try 
            {
                da.Fill(ds);
            }
            catch(Exception) { }
            return ds;
        }
    }
}

using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class JobServices
    {
        
        public List<Job> GetAllJob()
        {
            Model1 db = new Model1();
            return db.Jobs.ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211
{

    public class Account
    {
        public string AccountID { get; set; }
        public string Name { get; set; }
        public DateTime OpenDate { get; set; }
        public string BranchName { get; set; }
        public string TypeID { get; set; }

        public Account(){ }
    }
}

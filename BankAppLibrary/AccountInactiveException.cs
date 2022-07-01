using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppLibrary
{
    public class AccountInactiveException : ApplicationException
    {
        //public AccountInactiveException()
        //{

        //}
        //public AccountInactiveException(string msg):base(msg)
        //{

        //}
        public AccountInactiveException(string msg=null, Exception innerExp=null) : base(msg, innerExp)
        {

        }
    }
}

using BusinessObjects_EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_EntityFramework
{
    public class AccountMemberDAO
    {
        MyStoreContext context=new MyStoreContext();
        public AccountMember Login(string email,string password)
        {
            AccountMember am = context.AccountMembers
                                        .FirstOrDefault(x=>x.EmailAddress==email 
                                                && x.MemberPassword==password);
            return am;
        }
    }
}

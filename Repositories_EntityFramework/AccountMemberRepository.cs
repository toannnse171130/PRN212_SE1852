using BusinessObjects_EntityFramework;
using DataAccessLayer_EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories_EntityFramework
{
    public class AccountMemberRepository : IAccountMemberRepository
    {
        AccountMemberDAO accountMemberDAO=new AccountMemberDAO();
        public AccountMember Login(string email, string password)
        {
            return accountMemberDAO.Login(email, password);
        }
    }
}

using BusinessObjects_EntityFramework;
using Repositories_EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services_EntityFramework
{
    public class AccountMemberService : IAccountMemberService
    {
        IAccountMemberRepository accountMemberRepository;
        public AccountMemberService()
        {
            accountMemberRepository = new AccountMemberRepository();
        }
        public AccountMember Login(string email, string password)
        {
            return accountMemberRepository.Login(email, password);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp12
{
    public class PrimaryConstructors(IAccountService accountService)
    {
        private readonly IAccountService _accountService = accountService;
    }

    public interface IAccountService { }
}

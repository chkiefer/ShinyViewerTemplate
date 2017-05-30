using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace installPackages
{
    class Program
    {
        static void Main(string[] args)
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            bool isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);

            if (isAdmin)
            {
                r_calls Rinstance;
                Rinstance = new r_calls();
                Rinstance.initREngine();
                Rinstance.installPackages();
            }
            else
            {
                
            }

            

        }
    }
}

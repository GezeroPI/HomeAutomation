using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Alarm
{
    static class User
    {
        private static readonly string _passphrase = "9098";
        private static readonly string _passphrase2 = "4142";

        public static async Task<bool> ArmDesarm()
        {
            var result = true;
            while (result)
            {
                var input = Console.In.ReadLine();
                if (input == _passphrase || input == _passphrase2)
                {
                    if (input == _passphrase)
                    {
                        await ApiComm.GetResponseAsync("http://localhost:50122/api/SaveRecords/ArmDesarm/KwnasCode/-");
                    }
                    else
                    {
                        await ApiComm.GetResponseAsync("http://localhost:50122/api/SaveRecords/ArmDesarm/NicksCode/-");
                    }
                    result = false;
                }
            }
            return result;
        }
    }
}

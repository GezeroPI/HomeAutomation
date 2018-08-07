using System;
using System.Collections.Generic;
using System.Text;

namespace Alarm
{
    static class User
    {
        private static readonly string _passphrase = "9098";

        public static bool ArmDesarm()
        {
            var result = true;
            while (result)
            {
                var keimeno = Console.In.ReadLine();
                if (keimeno.ToString() == _passphrase)
                {
                    result = false;
                }
            }
            return result;
        }
    }
}

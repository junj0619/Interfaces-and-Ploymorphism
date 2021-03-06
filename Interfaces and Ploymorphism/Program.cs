﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Ploymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();

            encoder.RegisterNotification(new MailNotificationChannel());
            encoder.RegisterNotification(new SmsNotificationChannel());

            encoder.Encode(new Video());
        }
    }
}

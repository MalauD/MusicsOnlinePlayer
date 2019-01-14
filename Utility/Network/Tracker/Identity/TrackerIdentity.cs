﻿using System;
using System.Net;
namespace Utility.Network.Tracker.Identity
{
    public class TrackerIdentity : Identity
    {
        public TrackerIdentity(IPEndPoint ip)
        {
            base.IPEndPoint = ip;
        }
    }
}

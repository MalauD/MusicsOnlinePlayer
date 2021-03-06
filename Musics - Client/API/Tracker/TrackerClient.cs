﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Network.Tracker;
using Utility.Network.Tracker.Identity;

namespace Musics___Client.API.Tracker
{
    public sealed class TrackerClient : ClientSetup
    {
        public TrackerIdentity Trackeridentity { get; set; }

        public bool Connect(TrackerIdentity ti)
        {
            SetupSocket(ti.IPEndPoint.Port, 10000);
            Task<bool> a = Connect(ti.IPEndPoint);
            a.Wait(new TimeSpan(0,0,10));
            if (!a.Result)
                return false;
            StartReceiving();
            Trackeridentity = ti;
            return true;
        }
    }
}

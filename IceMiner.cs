// IceMiner

// Some Excess need to be removed here
using System;
using System.Threading;

// API 
using BotSharp;
using Sanderling;

namespace PublicIceMiningScript
{
    public class IMS : Core
    {
        public static string GetAuthor()
        { return "Defec Author"; }
        public static string GetVersion()
        { return "0.0.0.1"; }
        public static string GetDescription()
        { return "Public Ice Mining Script for Sanderling"; }

        //  [ Config Start ]
        var _LocalMon           = false;   // Monitors Local for Neuts & Hostiles

        // [ Location Stuff ]
        string _DropOffBM       = "Home: DropOff";  // Where you drop your load off
        string _IceAnomoly      = "Clear Icicle Belt"; // Add your Ice Belt Name Here
        string _OverviewName    = "Mining"; // Name of which Overview your mining is done under

        // [ Mining Stuff ]
        int _NumberofMiners     = 2; // in most use cases this number never changes
        int _MiningRange        = 10000; // Manuel Setting to keep ice in range without Boosts

        var _UseMiningDrones    = false;   // Set to true if your using them
        string _MiningDrones    = "Ice Harvesting Drone I";  // Set your mining drone here

        int _OreHoldFill        = 85; // Percentage at which to return to Dock

        // [ Defenses ]
        var _UseHardners        = false;  // Use em if you got em

        var _UseActiveBoost     = false;  // If your using Shield Boosters
        var _PermaActiveBoost   = false;  // if your Cap Stable while running Shield Boosts

        int _SOSWarpOut         = 65;  // Shield Percentage to warp to safety

        var _UseCombatDrones    = false;   // Self Explanitory if you have them
        string _CombatDrones    = "Warrior II";  // Set your combat drone name here
        
        // [ Config End ]
        // Do not edit below this line

        public void IMSrun()
        {
        // Lets get some threads started
        Thread localMonThread = new Thread(new ThreadStart(LocalMon));
        Thread shieldMonThread = new Thread(new ThreadStart(ShieldMon));

        }

        // [ Functions Start ]
        
        // Misc Stuff
        public void SanderlingVersionCheck()
        { }

        // Monitoring Functions
        public void LocalMon()
        { }
        public void ShieldMon()
        { }

        // Shield Stuff
        public void ActiveHardners()
        { }
        public void PermaBoost()
        { }
        public void ShieldBoost()
        { }

        // Mining Stuff
        public void MinerCheck()
        { }
        public void TargetCheck()
        { }
        public void MineRoid()
        { }

        // Drone Stuff
        public void MiningDronesLaunch()
        { }
        public void DronesMine()
        { }

        public void CombatDronesLaunch()
        { }
        public void DronesFight()
        { }

        public void AllDronesRecall()
        { }

        // Return & Dock
        public void DockUpUnload()
        { }
        
        // Emergency Warpout OMG WTF BBQ
        public void EmergencyMode()
        { }

        // [ Functions End ]

        // [ Utility Stuff ]

    }
}

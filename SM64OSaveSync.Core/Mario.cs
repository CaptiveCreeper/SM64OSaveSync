using System;

namespace SM64OSaveSync.Core
{
    public class Mario
    {
        public Level Castle {get;set;}
        public Level Bob_ombBattlefield { get;set;}
        public Level WhompsFortress {get;set;}
        public Level JollyRoggerBay {get;set;}
        public Level CoolCoolMountain {get;set;}
        public Level BoosBigHaunt {get;set;}
        public Level HazyMazeCave {get;set;}
        public Level LethalLavaLand {get;set;}
        public Level ShiftingSandLand {get;set;}
        public Level DireDireDocks {get;set;}
        public Level SnowmansLand {get;set;}
        public Level WetDryWorld {get;set;}
        public Level TallTallMountain {get;set;}
        public Level TinyHugeIsland {get;set;}
        public Level TickTockClock {get;set;}
        public Level RainbowRide {get;set;}
        public Level BowserDarkWorld {get;set;}
        public Level BowserFireSea {get;set;}
        public Level BowserSky {get;set;}
        public Level PrincessSecretSlide {get;set;}
        public Level CaverntOfTheMetalCap {get;set;}
        public Level TowerofTheWingCap {get;set;}
        public Level VanishCapUnderTheMoat {get;set;}
        public Level WingMarioOverTheRainbow {get;set;}
        public Level TheSecretAquarium { get;set;}

        public bool WingCapActive { get; set; }
        public bool MetalCapActive { get; set; }
        public bool VanishCapActive { get; set; }
        public bool HasKeyBasement { get; set; }
        public bool UsedKeyBasement { get; set; }
        public bool HasKey2ndFloor { get; set; }
        public bool UsedKey2ndFloor { get; set; }
        public bool MoatDrained { get; set; }
        public bool PortalMovedBack { get; set; }



        public bool DoorAnimationSeenSecretSlide { get; set; }
        public bool DoorAnimationSeenWhompsFortress { get; set; }
        public bool DoorAnimationSeenCoolCoolMountain{ get; set; }
        public bool DoorAnimationSeenJollyRogerBay{ get; set; }
        public bool DoorAnimationSeenBowserDarkWorld { get; set; }
        public bool DoorAnimationSeenBowserFireSea{ get; set; }
        public bool DoorAnimationSeenTickTockClock{ get; set; }





        public bool FileOccupied { get; set; }

        public Int16 CheckSum { get; set; }



    }
}

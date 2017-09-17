using System;
using SM64OSaveSync.Core;
using System.IO;
using System.Collections;
using System.Linq;

namespace SM64OSaveSync.File
{
    public class Read
    {
        public static Save ReadSave(string filePath)
        {
            //🍌🍌🍌🍌🍌🍌🍌🍌🍌🍌🍌🍌🍌🍌🍌🍌🍌

            byte[] data = System.IO.File.ReadAllBytes(filePath);
            Save workingSave = new Save();

            workingSave.A = ReadMario(data.Take(56).ToArray());
            workingSave.A_Backup = ReadMario(data.Skip(0x0038).Take(56).ToArray());

            workingSave.B = ReadMario(data.Skip(0x0070).Take(56).ToArray());
            workingSave.B_Backup = ReadMario(data.Skip(0x00A8).Take(56).ToArray());

            workingSave.C = ReadMario(data.Skip(0x00E0).Take(56).ToArray());
            workingSave.C_Backup = ReadMario(data.Skip(0x0118).Take(56).ToArray());

            workingSave.D = ReadMario(data.Skip(0x0150).Take(56).ToArray());
            workingSave.D_Backup = ReadMario(data.Skip(0x0188).Take(56).ToArray());

            return workingSave;
        }
        private static Mario ReadMario(byte[] mario)
        {
            if (mario.Length == 56)
            {
                Mario workingMario = new Mario();

                //Always Get the stars for the Level first then assign coin max and cannon unlocked
                workingMario.Bob_ombBattlefield = ReadLevelStars(mario[0x0C]);
                workingMario.Bob_ombBattlefield.CoinHighScore = mario[0x25];
                workingMario.Bob_ombBattlefield.CanonOpen = GetBit(mario[0x0D],7);

                workingMario.WhompsFortress = ReadLevelStars(mario[0x0D]);
                workingMario.WhompsFortress.CoinHighScore = mario[0x26];
                workingMario.WhompsFortress.CanonOpen = GetBit(mario[0x0E], 7);

                workingMario.JollyRoggerBay = ReadLevelStars(mario[0x0E]);
                workingMario.JollyRoggerBay.CoinHighScore = mario[0x27];
                workingMario.JollyRoggerBay.CanonOpen = GetBit(mario[0x0F], 7);

                workingMario.CoolCoolMountain = ReadLevelStars(mario[0x0F]);
                workingMario.CoolCoolMountain.CoinHighScore = mario[0x28];
                workingMario.CoolCoolMountain.CanonOpen = GetBit(mario[0x10], 7);

                workingMario.BoosBigHaunt = ReadLevelStars(mario[0x10]);
                workingMario.BoosBigHaunt.CoinHighScore = mario[0x29];
                workingMario.BoosBigHaunt.CanonOpen = GetBit(mario[0x11], 7);

                workingMario.HazyMazeCave = ReadLevelStars(mario[0x11]);
                workingMario.HazyMazeCave.CoinHighScore = mario[0x2A];
                workingMario.HazyMazeCave.CanonOpen = GetBit(mario[0x12], 7);

                workingMario.LethalLavaLand = ReadLevelStars(mario[0x12]);
                workingMario.LethalLavaLand.CoinHighScore = mario[0x2B];
                workingMario.LethalLavaLand.CanonOpen = GetBit(mario[0x13], 7);

                workingMario.ShiftingSandLand = ReadLevelStars(mario[0x13]);
                workingMario.ShiftingSandLand.CoinHighScore = mario[0x2C];
                workingMario.ShiftingSandLand.CanonOpen = GetBit(mario[0x14], 7);

                workingMario.DireDireDocks = ReadLevelStars(mario[0x14]);
                workingMario.DireDireDocks.CoinHighScore = mario[0x2D];
                workingMario.DireDireDocks.CanonOpen = GetBit(mario[0x15], 7);

                workingMario.SnowmansLand = ReadLevelStars(mario[0x15]);
                workingMario.SnowmansLand.CoinHighScore = mario[0x2E];
                workingMario.SnowmansLand.CanonOpen = GetBit(mario[0x16], 7);

                workingMario.WetDryWorld = ReadLevelStars(mario[0x16]);
                workingMario.WetDryWorld.CoinHighScore = mario[0x2F];
                workingMario.WetDryWorld.CanonOpen = GetBit(mario[0x17], 7);

                workingMario.TallTallMountain = ReadLevelStars(mario[0x17]);
                workingMario.TallTallMountain.CoinHighScore = mario[0x30];
                workingMario.TallTallMountain.CanonOpen = GetBit(mario[0x18], 7);

                workingMario.TinyHugeIsland = ReadLevelStars(mario[0x18]);
                workingMario.TinyHugeIsland.CoinHighScore = mario[0x31];
                workingMario.TinyHugeIsland.CanonOpen = GetBit(mario[0x19], 7);

                workingMario.TickTockClock = ReadLevelStars(mario[0x19]);
                workingMario.TickTockClock.CoinHighScore = mario[0x32];
                workingMario.TickTockClock.CanonOpen = GetBit(mario[0x1A], 7);

                workingMario.RainbowRide = ReadLevelStars(mario[0x1A]);
                workingMario.RainbowRide.CoinHighScore = mario[0x32];
                workingMario.RainbowRide.CanonOpen = GetBit(mario[0x1B], 7);

                workingMario.Castle = ReadLevelStars(mario[0x08]);

                workingMario.BowserDarkWorld = ReadLevelStars(mario[0x1B]);

                workingMario.BowserFireSea = ReadLevelStars(mario[0x08]);

                workingMario.BowserSky = ReadLevelStars(mario[0x08]);

                workingMario.PrincessSecretSlide = ReadLevelStars(mario[0x08]);

                workingMario.CaverntOfTheMetalCap = ReadLevelStars(mario[0x08]);

                workingMario.TowerofTheWingCap = ReadLevelStars(mario[0x08]);

                workingMario.VanishCapUnderTheMoat = ReadLevelStars(mario[0x08]);

                workingMario.WingMarioOverTheRainbow = ReadLevelStars(mario[0x08]);

                workingMario.TheSecretAquarium = ReadLevelStars(mario[0x08]);



                workingMario.CapLocation.X = BitConverter.ToInt16(mario, 0x02);
                workingMario.CapLocation.Y = BitConverter.ToInt16(mario, 0x04);
                workingMario.CapLocation.Z = BitConverter.ToInt16(mario, 0x06);

                workingMario.FileOccupied = GetBit(mario[0x0B], 0);
                workingMario.WingCapActive = GetBit(mario[0x0B], 1);
                workingMario.MetalCapActive = GetBit(mario[0x0B], 2);
                workingMario.VanishCapActive = GetBit(mario[0x0B], 3);
                workingMario.HasKeyBasement = GetBit(mario[0x0B], 4);
                workingMario.HasKey2ndFloor = GetBit(mario[0x0B], 5);
                workingMario.UsedKeyBasement = GetBit(mario[0x0B], 6);
                workingMario.UsedKey2ndFloor = GetBit(mario[0x0B], 7);

                workingMario.PortalMovedBack = GetBit(mario[0x0A], 0);
                workingMario.MoatDrained = GetBit(mario[0x0A], 1);
                workingMario.DoorAnimationSeenSecretSlide = GetBit(mario[0x0A], 2);
                workingMario.DoorAnimationSeenWhompsFortress = GetBit(mario[0x0A], 3);
                workingMario.DoorAnimationSeenCoolCoolMountain = GetBit(mario[0x0A], 4);
                workingMario.DoorAnimationSeenJollyRogerBay = GetBit(mario[0x0A], 5);
                workingMario.DoorAnimationSeenBowserDarkWorld = GetBit(mario[0x0A], 6);
                workingMario.DoorAnimationSeenBowserFireSea = GetBit(mario[0x0A], 7);

                workingMario.DoorAnimationSeenTickTockClock = GetBit(mario[0x09], 4);

                if (mario[0x00] == 0x08)
                {
                    workingMario.CapLocation.Map = LostCap.LevelLostIn.ShiftingSandLand;
                }
                else if (mario[0x00] == 0x0C)
                {
                    workingMario.CapLocation.Map = LostCap.LevelLostIn.SnowmansLand;
                }
                else if (mario[0x00] == 0x24)
                {
                    workingMario.CapLocation.Map = LostCap.LevelLostIn.TallTallMountain;
                }
                else
                {
                    workingMario.CapLocation.Map = LostCap.LevelLostIn.NotLost;
                }

                return workingMario;
            }
            else
            {
                throw new Exception("Byte Array Passed must be 56 bytes");
            }
        }
        private static Level ReadLevelStars(byte level)
        {
            Level workingLevel = new Level();
            workingLevel.Star1 = GetBit(level, 0);
            workingLevel.Star2 = GetBit(level, 1);
            workingLevel.Star3 = GetBit(level, 2);
            workingLevel.Star4 = GetBit(level, 3);
            workingLevel.Star5 = GetBit(level, 4);
            workingLevel.Star6 = GetBit(level, 5);
            workingLevel.Star7 = GetBit(level, 6);
            return workingLevel;
        }
        public static bool GetBit(byte b, int bitNumber)
        {
            return (b & (1 << bitNumber)) != 0;
        }

    }
}

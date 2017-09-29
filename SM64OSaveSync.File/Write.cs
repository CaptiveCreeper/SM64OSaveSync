using SM64OSaveSync.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SM64OSaveSync.File
{
    public class Write
    {
        public static byte[] WriteSave(Save workingSave)
        {
            byte[] data = new byte[512];

            WriteMario(workingSave.A).CopyTo(data, 0);
            WriteMario(workingSave.A_Backup).CopyTo(data, 0x0038);

            WriteMario(workingSave.B).CopyTo(data, 0x0070);
            WriteMario(workingSave.B_Backup).CopyTo(data, 0x00A8);

            WriteMario(workingSave.C).CopyTo(data, 0x00E0);
            WriteMario(workingSave.C_Backup).CopyTo(data, 0x0118);

            WriteMario(workingSave.D).CopyTo(data, 0x0150);
            WriteMario(workingSave.D_Backup).CopyTo(data, 0x0188);

            return data;
        }
        private static byte[] WriteMario(Mario workingMario)
        {
            byte[] data = new byte[56];

            data[0x0C] = WriteLevelStars(workingMario.Bob_ombBattlefield, false);
            data[0x25] = workingMario.Bob_ombBattlefield.CoinHighScore;

            data[0x0D] = WriteLevelStars(workingMario.WhompsFortress, workingMario.Bob_ombBattlefield.CanonOpen);
            data[0x26] = workingMario.WhompsFortress.CoinHighScore;

            data[0x0E] = WriteLevelStars(workingMario.JollyRoggerBay, workingMario.WhompsFortress.CanonOpen);
            data[0x27] = workingMario.JollyRoggerBay.CoinHighScore;

            data[0x0F] = WriteLevelStars(workingMario.CoolCoolMountain, workingMario.JollyRoggerBay.CanonOpen);
            data[0x28] = workingMario.CoolCoolMountain.CoinHighScore;

            data[0x10] = WriteLevelStars(workingMario.BoosBigHaunt, workingMario.CoolCoolMountain.CanonOpen);
            data[0x29] = workingMario.BoosBigHaunt.CoinHighScore;

            data[0x11] = WriteLevelStars(workingMario.HazyMazeCave, workingMario.BoosBigHaunt.CanonOpen);
            data[0x2A] = workingMario.HazyMazeCave.CoinHighScore;

            data[0x12] = WriteLevelStars(workingMario.LethalLavaLand, workingMario.HazyMazeCave.CanonOpen);
            data[0x2B] = workingMario.LethalLavaLand.CoinHighScore;

            data[0x13] = WriteLevelStars(workingMario.ShiftingSandLand, workingMario.LethalLavaLand.CanonOpen);
            data[0x2C] = workingMario.ShiftingSandLand.CoinHighScore;

            data[0x14] = WriteLevelStars(workingMario.DireDireDocks, workingMario.ShiftingSandLand.CanonOpen);
            data[0x2D] = workingMario.DireDireDocks.CoinHighScore;

            data[0x15] = WriteLevelStars(workingMario.SnowmansLand, workingMario.DireDireDocks.CanonOpen);
            data[0x2E] = workingMario.SnowmansLand.CoinHighScore;

            data[0x16] = WriteLevelStars(workingMario.WetDryWorld, workingMario.SnowmansLand.CanonOpen);
            data[0x2F] = workingMario.WetDryWorld.CoinHighScore;

            data[0x17] = WriteLevelStars(workingMario.TallTallMountain, workingMario.WetDryWorld.CanonOpen);
            data[0x30] = workingMario.TallTallMountain.CoinHighScore;

            data[0x18] = WriteLevelStars(workingMario.TinyHugeIsland, workingMario.TallTallMountain.CanonOpen);
            data[0x31] = workingMario.TinyHugeIsland.CoinHighScore;

            data[0x19] = WriteLevelStars(workingMario.TickTockClock, workingMario.TinyHugeIsland.CanonOpen);
            data[0x32] = workingMario.TickTockClock.CoinHighScore;

            data[0x1A] = WriteLevelStars(workingMario.RainbowRide, workingMario.TickTockClock.CanonOpen);
            data[0x32] = workingMario.RainbowRide.CoinHighScore;


            data[0x08] = WriteLevelStars(workingMario.Castle, workingMario.RainbowRide.CanonOpen);
            data[0x08] = WriteLevelStars(workingMario.BowserDarkWorld, false);
            data[0x08] = WriteLevelStars(workingMario.BowserFireSea, false);
            data[0x08] = WriteLevelStars(workingMario.BowserSky, false);
            data[0x08] = WriteLevelStars(workingMario.PrincessSecretSlide, false);
            data[0x08] = WriteLevelStars(workingMario.CaverntOfTheMetalCap, false);
            data[0x08] = WriteLevelStars(workingMario.TowerofTheWingCap, false);
            data[0x08] = WriteLevelStars(workingMario.VanishCapUnderTheMoat, false);
            data[0x08] = WriteLevelStars(workingMario.WingMarioOverTheRainbow, false);
            data[0x08] = WriteLevelStars(workingMario.TheSecretAquarium, false);

            bool[] flagByte1 = new bool[8];
            flagByte1[0] = workingMario.FileOccupied;
            flagByte1[1] = workingMario.WingCapActive;
            flagByte1[2] = workingMario.MetalCapActive;
            flagByte1[3] = workingMario.VanishCapActive;
            flagByte1[4] = workingMario.HasKeyBasement;
            flagByte1[5] = workingMario.HasKey2ndFloor;
            flagByte1[6] = workingMario.UsedKeyBasement;
            flagByte1[7] = workingMario.UsedKey2ndFloor;
            data[0x0B] = CreateByte(flagByte1);

            bool[] flagByte2 = new bool[8];
            flagByte2[0] = workingMario.PortalMovedBack;
            flagByte2[1] = workingMario.MoatDrained;
            flagByte2[2] = workingMario.DoorAnimationSeenSecretSlide;
            flagByte2[3] = workingMario.DoorAnimationSeenWhompsFortress;
            flagByte2[4] = workingMario.DoorAnimationSeenCoolCoolMountain;
            flagByte2[5] = workingMario.DoorAnimationSeenJollyRogerBay;
            flagByte2[6] = workingMario.DoorAnimationSeenBowserDarkWorld;
            flagByte2[7] = workingMario.DoorAnimationSeenBowserFireSea;
            data[0x0A] = CreateByte(flagByte2);

            bool[] flagByte3 = new bool[8];
            flagByte3[0] = false;
            flagByte3[1] = false;
            flagByte3[2] = false;
            flagByte3[3] = false;
            flagByte3[4] = workingMario.DoorAnimationSeenTickTockClock;
            flagByte3[5] = false;
            flagByte3[6] = false;
            flagByte3[7] = false;
            data[0x09] = CreateByte(flagByte3);
            data[0x09] = 0x10;





            //This must be at the end.
            //CheckSum is simply the sum of all the bytes in the save
            Int16 Sum = (Int16)data.Sum(x => (long)x);
            byte[] checksum = GetBytesFrom16BitInt(Sum);
            checksum.CopyTo(data, 0x0036);
            return data;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="workingLevel"></param>
        /// <param name="canonFlag">This is the canon flag for the previous level because it is writing the byte and that is where the flag is saved</param>
        /// <returns></returns>
        private static byte WriteLevelStars(Level workingLevel, bool canonFlag)
        {
            byte data = new byte();

            bool[] bits = new bool[8];
            bits[0] = workingLevel.Star1;
            bits[1] = workingLevel.Star2;
            bits[2] = workingLevel.Star3;
            bits[3] = workingLevel.Star4;
            bits[4] = workingLevel.Star5;
            bits[5] = workingLevel.Star6;
            bits[6] = workingLevel.Star7;
            bits[7] = canonFlag;

            data = CreateByte(bits);

            return data;
        }
        //THIS IS THE PROBLEM CHILD FUNCTION
        private static byte CreateByte(bool[] workingLevel)
        {
            byte data = new byte();

            string temp = "";
            for (int i = 0; i < 8; i++)
            {
                if (workingLevel[i])
                {
                    temp += "1";
                }
                else
                {
                    temp += "0";
                }
            }
            data = Convert.ToByte(temp, 2);
            return data;
        }
        private static byte CreateByteOLD(bool[] workingLevel)
        {
            byte[] data = new byte[1];
            BitArray a = new BitArray(workingLevel);
            a.CopyTo(data, 0);
            return data[0];
        }
        private static byte[] GetBytesFrom16BitInt(Int16 value)
        {
            byte[] data = new byte[2];
            data[0] = (byte)(value & 0xff);
            data[1] = (byte)((value >> 8) & 0xff);
            return data;
        }
    }
}

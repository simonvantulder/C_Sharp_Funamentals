using System;

namespace Phone
{
    public class Nokia : Phone, IRingable
    {
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) : base(versionNumber, batteryPercentage, carrier, ringTone)
        {
            isUnlocked = false;
        }
        private bool isUnlocked;

        // This is just a fun way to make Nokia special
        private static string silentTone = "Zzz zzz zzz";
        public string Ring()
        {
            // ternary expression:
            // if   ( is true)  ? do this  : else, do this
            return (isUnlocked) ? RingTone : silentTone;
        }
        public string Unlock()
        {
            isUnlocked = true;
            return "Unlocked your Nokia Note with creepy facial recognition that you shouldnt use";
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("++++++++++++++++++");
            Console.WriteLine($"Nokia: {VersionNumber}");
            Console.WriteLine($"Carrier: {Carrier}");
            Console.WriteLine($"Ring Tone: {RingTone}");
            Console.WriteLine("++++++++++++++++++");
        }
    }
}
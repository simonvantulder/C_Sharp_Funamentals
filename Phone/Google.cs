using System;
namespace Phone
{
public class Google : Phone, IRingable 
{
    public Google(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
        : base(versionNumber, batteryPercentage, carrier, ringTone) 
        {
            isUnlocked = false;
        }
    private bool isUnlocked;

    public string Ring() 
    {
        // your code here
        return $"Your Google Pixel is Ringing: {RingTone}";
    }

    public string Unlock() 
    {
        return "Unlocked your Google Pixel";
    }


        public override void DisplayInfo()
        {
        // your code here
        Console.WriteLine($"You have a Google {VersionNumber}, your phone is {this.BatteryPercentage}% charged, you use {Carrier}, youre ringtone is {RingTone}");
        }
    }
    
}
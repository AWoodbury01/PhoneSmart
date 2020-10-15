using System.ComponentModel;

namespace PhoneSmart.Models
{
    public class PhoneModel
    {
        public int PhoneModelId { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        [DisplayName("Operating System")]
        public string OS { get; set; }
        public string Ram { get; set; }

        [DisplayName("Display Type")]
        public string DisplayType { get; set; }

        [DisplayName("Display Size")]
        public double DisplaySize { get; set; }

        [DisplayName("Refresh Rate")]
        public string RefreshRate { get; set; }

        public string Processor { get; set; }

        [DisplayName("Main Camera")]
        public string MainCam { get; set; }

        [DisplayName("Secondary Camera")]
        public string SecondaryCam { get; set; }

        [DisplayName("Front Camera")]
        public string FrontCam { get; set; }
        public string Battery { get; set; }
        public string Security { get; set; }

        [DisplayName("Wireless Charging")]
        public bool isWirelessCharge { get; set; }

        [DisplayName("Water Resistance")]
        public bool isWaterResist { get; set; }


        public string PhoneURL { get; set; }
    }
}

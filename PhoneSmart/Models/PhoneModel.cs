namespace PhoneSmart.Models
{
    public class PhoneModel
    {
        public int PhoneModelId { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string OS { get; set; }
        public string Ram { get; set; }
        public string DisplayType { get; set; }
        public double DisplaySize { get; set; }
        public string RefreshRate { get; set; }
        public string Processor { get; set; }
        public string MainCam { get; set; }
        public string SecondaryCam { get; set; }
        public string FrontCam { get; set; }
        public string Battery { get; set; }
        public string Security { get; set; }
        public bool isWirelessCharge { get; set; }
        public bool isWaterResist { get; set; }

    }
}

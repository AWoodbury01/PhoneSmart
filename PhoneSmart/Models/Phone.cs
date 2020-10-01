namespace PhoneSmart.Models
{
    public class Phone
    {
        public int PhoneId { get; set; }
        public string UserId { get; set; }
        public string Color { get; set; }
        public string Storage { get; set; }
        public string Condition { get; set; }
        public int PhoneModelId { get; set; }
        public ApplicationUser User { get; set; }
        public PhoneModel PhoneModel { get; set; }
        public object ViewBag { get; }

    }
}

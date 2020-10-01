using System.Collections.Generic;

namespace PhoneSmart.Models.PhoneViewModels
{
    public class PhoneCompareViewModel
    {
        public IEnumerable<Phone> ComparePhoneOne { get; set; }
        public IEnumerable<Phone> ComparePhoneTwo { get; set; }
        public IEnumerable<PhoneModel> ComparePhoneModelOne { get; set; }
        public IEnumerable<PhoneModel> ComparePhoneModelTwo { get; set; }

        public Phone Phone { get; set; }
        public PhoneModel PhoneModel { get; set; }
    }
}

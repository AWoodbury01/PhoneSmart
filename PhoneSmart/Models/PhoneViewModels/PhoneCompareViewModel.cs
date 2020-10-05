using Microsoft.AspNetCore.Mvc.Rendering;

namespace PhoneSmart.Models.PhoneViewModels
{
    public class PhoneCompareViewModel
    {
        public SelectList PhoneDropdownOne { get; set; }

        public PhoneModel PhoneOne { get; set; }
        public SelectList PhoneDropdownTwo { get; set; }

        public PhoneModel PhoneTwo { get; set; }
        //public IEnumerable<PhoneModel> ComparePhoneModelOne { get; set; }
        //public IEnumerable<PhoneModel> ComparePhoneModelTwo { get; set; }

        //public Phone Phone { get; set; }
        //public PhoneModel PhoneModel { get; set; }
    }
}

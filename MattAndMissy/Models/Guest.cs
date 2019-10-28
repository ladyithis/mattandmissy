using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MattAndMissy.Models
{
    public class Guest
    {
        public Guest()
        {

        }

        public int ID { get; set; }
        public string InvitationCode { get; set; }
        public string Name { get; set; }
        public bool? Attending { get; set; }
        public MealOption? MealPreference { get; set; }
        public DateTime? RespondDate { get; set; }
    }

    public enum MealOption
    {
        Vegan,
        Meat
    }
}

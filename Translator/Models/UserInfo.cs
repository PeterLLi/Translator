using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Translator.Models
{
    public class UserInfo
    {
        [Key]
        public int UserId { get; set; }

        [ForeignKey("ApplicationUser")]
        public string Id { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Ethnicity")]
        public string Ethnicity { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }

        [Display(Name = "Province/State")]
        public string Province { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

        [Display(Name = "Languages Known")]
        public string LanguagesSpoken { get; set; }

        [Display(Name = "Languaged Desired")]
        public string LanguageDesired { get; set; }

        public int FriendId1 { get; set; }

        public int FriendId2 { get; set; }

        public int FriendId3 { get; set; }
    }
}
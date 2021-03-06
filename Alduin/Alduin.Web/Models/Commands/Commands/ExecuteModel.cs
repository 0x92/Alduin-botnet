﻿using Alduin.Web.Models.Commands;
using System.ComponentModel.DataAnnotations;

namespace Alduin.Web.Models
{
    public class ExecuteModel : CommandBaseModel
    {
        [Required]
        [Display(Name = "File direct link")]
        public string Url { get; set; }
        [Required]
        [Display(Name = "File new name")]
        public string Name { get; set; }
        [Display(Name = "Run it too")]
        public bool Run { get; set; }
        [Display(Name = "Also use a proxy")]
        public bool Proxy { get; set; }
    }
}

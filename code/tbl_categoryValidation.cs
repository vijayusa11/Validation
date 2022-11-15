using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace code
{
    public class tbl_categoryValidation
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Description is urgent required")]
        public string Description { get; set; }
    }

    [MetadataType(typeof(tbl_categoryValidation))]
    public partial class tbl_category
    {

    }
}
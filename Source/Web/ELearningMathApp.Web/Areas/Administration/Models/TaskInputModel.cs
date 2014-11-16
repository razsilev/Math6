using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearningMathApp.Web.Areas.Administration.Models
{
    public class TaskInputModel
    {
        [AllowHtml]
        [Required]
        [MinLength(3)]
        [Display(Name = "Task Content")]
        [DataType("tinymce_full")]
        [UIHint("tinymce_full")]
        public string Condition { get; set; }
    }
}
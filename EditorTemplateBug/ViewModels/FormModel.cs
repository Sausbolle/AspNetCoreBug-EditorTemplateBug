using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EditorTemplateBug.ViewModels
{
    public class FormModel
    {

        [Required]
        [Display(Name = "Some Text Input")]
        public string TextInput { get; set; }

        [Required]
        [Display(Name = "Some Selected Option")]
        public SelectOptionsEnum SelectedOption { get; set; }
    }

    public enum SelectOptionsEnum
    {
        SelectOne,
        SelectTwo,
        SelectThree,
        SelectFour
    }

}

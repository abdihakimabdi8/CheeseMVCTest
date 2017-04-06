﻿using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class AddCheeseViewModel
    {

        [Required]
        [Display(Name = "Cheese Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must give your cheese a description")]
        public string Description { get; set; }

        [Required(ErrorMessage ="Provide Category")]
        [Display(Name = "Category")]
        public int CategoryID {get; set;}

        public CheeseCategory Category { get; set; }

        public List<SelectListItem> Categories { get; set; }

        public AddCheeseViewModel()
        {

            Categories = new List<SelectListItem>();

            // <option value="0">Hard</option>
            Categories.Add(new SelectListItem
            {
                Value = ((int)Category.ID).ToString(),
                Text = Category.Name
            });

        }
    }
}
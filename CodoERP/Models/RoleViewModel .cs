﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodoERP.Models
{
    public class RoleViewModel
    {//Create a role with asp.net identity
        //3
        // Debug sequence 1
        public RoleViewModel() { }

        public RoleViewModel(ApplicationRole role)
        {
            Id = role.Id;
            Name = role.Name;
        }

        public string Id { get; set; }
        public string Name { get; set; }
    }
}
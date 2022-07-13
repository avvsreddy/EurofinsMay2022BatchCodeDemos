﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnowledgeHubPortal.Models.Entities
{
    public class Article
    {
        public int ArticleID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Url { get; set; }
        public string Description { get; set; }
        public Catagory Catagory { get; set; }
        public int CatagoryID { get; set; }
        public string PostedBy { get; set; }
        public DateTime PostedOn { get; set; }
        public bool IsApproved { get; set; }

    }
}
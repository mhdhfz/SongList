﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SongList.Models
{
    public class Song
    {
        public int SongId { get; set; }

        [Required(ErrorMessage = "Please enter song name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a year")]
        [Range(1900, 2021, ErrorMessage = "Year must between 1900 and 2021")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Please enter the rating")]
        [Range(1, 5, ErrorMessage = "Rating must between 1 and 5")]
        public int? Rating { get; set; }


    }
}

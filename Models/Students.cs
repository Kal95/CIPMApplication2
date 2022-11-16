﻿using System.ComponentModel.DataAnnotations;

namespace CIPMApplication2.Models;

public class Students : Common
{
   
    [Required]
    public string Title { get; set; }

    [Required]
    public string FrstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    public Gender Gender { get; set; }

    [Required]
    public string Discipline { get; set; }

    [Required]
    public string Institution { get; set; }

    [Required]
    public int ExpectedYearOfGraduation { get; set; }
}

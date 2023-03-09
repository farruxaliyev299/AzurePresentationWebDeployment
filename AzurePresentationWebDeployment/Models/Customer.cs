using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AzurePresentationWebDeployment.Models;

public partial class Customer
{
    [Key]
    public int Id { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public int? Age { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public string? CardNumber { get; set; }
}

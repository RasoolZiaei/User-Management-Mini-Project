using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain;

public class User(string firstName, string lastName,string fullName, string nationalCod, byte[] identificationImage)
{
    //[Browsable(browsable: false)]
    [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.None)]
    public Guid Id { get; protected set; } = Guid.NewGuid();

    [Required(AllowEmptyStrings = false)]
    [StringLength(maximumLength: 25, MinimumLength = 3)]
    [DisplayName(displayName: "First Name")]
    public string FirstName { get; set; } = firstName;

    [Required(AllowEmptyStrings = false)]
    [StringLength(maximumLength: 25, MinimumLength = 3)]
    [DisplayName(displayName: "Last Name")]
    public string LastName { get; set; } = lastName;

    [Required(AllowEmptyStrings = false)]
    [StringLength(maximumLength: 50, MinimumLength = 7)]
    [DisplayName(displayName: "Full Name")]
    public string FullName { get; set; } = fullName;

    [Required(AllowEmptyStrings = false)]
    [StringLength(maximumLength: 10, MinimumLength = 10)]
    [DisplayName(displayName: "National Cod")]
    public string NationalCod { get; set; } = nationalCod;

    public string? Address { get; set; }

    [Browsable(browsable: false)]
    public byte[] IdentificationImage { get; set; } = identificationImage;
}

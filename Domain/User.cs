using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain;

public class User(string firstName, string lastName,string fullName, int nationalCod)
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
    public int NationalCod { get; set; } = nationalCod;

    //[Browsable(browsable: false)]
    public string? Address { get; set; }

}

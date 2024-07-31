using System.ComponentModel.DataAnnotations;

namespace Dev.Lau.Blazor.Messaging.Shared.Messages;

public record ProductCreated
{
    [Required]
    [StringLength(30, ErrorMessage = "Identifier too long (30 character limit).")]
    public required string Name { get; set; }
}
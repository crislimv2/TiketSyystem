using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Lombok.NET;
using Microsoft.SqlServer.Server;

namespace Api.Models
{

  [With]
  [NoArgsConstructor]
  [AllArgsConstructor]
  public partial class User
  {
    [Key]
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    [Required(ErrorMessage = "Name is required!")]
    public string Name { get; set; }
    [JsonPropertyName("role")] // Note: Change "Role" to "role" for consistency
    [Required(ErrorMessage = "Role is required!")]
    public string Role { get; set; }

    [JsonPropertyName("createdTickets")]
    public DateTime CreatedTickets { get; set; } = DateTime.Now;
    [JsonIgnore]
    public string FormattedCreatedTickets => CreatedTickets.ToString("yyyy-MM-dd HH:mm:ss");

    [JsonPropertyName("updatedTickets")]
    public DateTime UpdatedTickets { get; set; }

    // Uncomment if you plan to use these collections
    // public ICollection<TicketHistory> TicketHistories { get; set; } = new List<TicketHistory>();
    // public ICollection<CommentHistory> CommentHistories { get; set; } = new List<CommentHistory>();
  }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Lombok.NET;

namespace Api.Models
{
  [With]
  [AllArgsConstructor]
  [NoArgsConstructor]
  public partial class Ticket
  {
    [Key]
    [JsonPropertyName("id")]
    [Required(ErrorMessage = "ID is required")]
    public Int64 Id { get; set; }

    [JsonPropertyName("summary")]
    [Required(ErrorMessage = "Summary is required")]
    [StringLength(100, ErrorMessage = "Summary can't be longer than 100 characters")]
    public string Summary { get; set; }

    [JsonPropertyName("description")]
    [StringLength(500, ErrorMessage = "Description can't be longer than 500 characters")]
    public string Description { get; set; }

    [JsonPropertyName("ticketTypeId")]
    [Required(ErrorMessage = "Ticket Type ID is required")]
    [ForeignKey("TicketType")]
    public Int64 TicketTypeId { get; set; }

    [JsonPropertyName("severityId")]

    public string SeverityId { get; set; } = "Low";

    [JsonPropertyName("creatorId")]
    [Required(ErrorMessage = "Creator ID is required")]
    [ForeignKey("Creator")]
    public string CreatorId { get; set; }

    [JsonPropertyName("updaterId")]
    [ForeignKey("Updater")]
    public string UpdaterId { get; set; }

    public TicketType TicketType { get; set; }
    public User Creator { get; set; }
    public User Updater { get; set; }

    // public List<TicketHistory> TicketHistories { get; set; }
    // public List<CommentHistory> CommentHistories { get; set; }
  }
}

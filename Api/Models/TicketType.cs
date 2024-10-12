using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Lombok.NET;

namespace Api.Models
{
  [With]
  [NoArgsConstructor]
  [AllArgsConstructor]
  public partial class TicketType {
    [Key]
    [JsonPropertyName("ticketTypeId")]
    public Int64 Id;

    [JsonPropertyName("ticketType")]
    public string Type;
  }
}
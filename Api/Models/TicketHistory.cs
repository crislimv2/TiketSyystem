

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Api.Models
{
  public partial class TicketHistory (){
    [Key]
    [JsonPropertyName("TicketHistoryId")]
    public Int64 Id;

    [JsonPropertyName("TicketId")]
    [ForeignKey("ticket")]
    public Int64 TicketId { get; set; }
    public Ticket ticket { get; set; }
  }
}
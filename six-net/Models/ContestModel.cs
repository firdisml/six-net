using System.ComponentModel.DataAnnotations.Schema;

namespace six_net.Models
{
    public class ContestModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Link { get; set; }

    }

}

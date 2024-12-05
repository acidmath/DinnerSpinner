using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DinnerSpinner.Data.Model {

    public class Restaurant {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required()]
        [StringLength(100)]
        public string Name { get; set; }

        public Restaurant(int id, string name) {
            Id = id;
            Name = name;
        }

    }
}

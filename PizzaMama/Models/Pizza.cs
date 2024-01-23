using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using JsonIgnoreAttribute = System.Text.Json.Serialization.JsonIgnoreAttribute;

namespace PizzaMama.Models
{
    public class Pizza
    {
        [JsonIgnore]
        [Display(Name = "ID de la pizza")]
        public int PizzaID { get; set; }
        [Display(Name = "Nom")]
        public string nom {  get; set; }
        [Display(Name = "Prix (€)")]
        public float prix { get; set; }
        [Display(Name = "Végétarienne ?")]
        public bool isVege { get; set; }
        [JsonIgnore]
        [Display(Name = "Ingrédients")]
        public string ingredients { get; set; }

        [NotMapped]
        [JsonPropertyName("ingredients")]
        public List<string> listIngredients
        {
            get
            {
                return ingredients?.Split(", ").ToList();
            }
        }
    }
}

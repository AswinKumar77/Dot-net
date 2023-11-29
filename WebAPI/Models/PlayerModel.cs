using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class PlayerModel
    {
        
        public int Id { get; set; }
       
        public string PlayerName { get; set; }
       
        public string CountryName { get; set; }
   
        public int Age {  get; set; }
    }
}

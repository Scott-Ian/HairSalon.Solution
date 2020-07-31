using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Restauraunt>();
    }

    public int StylistId { get; set; }
    public string Name { get; set; }
    public Date DateOfHire {get; set; }
    public int Wage { get; set; }
    
    public virtual ICollection<Client> Clients { get; set; }
  }
}
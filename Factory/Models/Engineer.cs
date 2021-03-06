using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachines>();
    }

    public int EngineerId {get; set;}
    public string EngineerName {get; set;}
    public string Description {get; set;}

    public virtual ICollection<EngineerMachines> JoinEntities {get;}
  }
}
using System.Collections.Generic;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<EngineerMachines>();
    }

    public int MachineId {get; set;}
    public string MachineName {get; set;}
    public string Description {get; set;}

    public virtual ICollection<EngineerMachines> JoinEntities {get;}
  }
}
namespace Market.Entity.Classes.DbClasses.BaseClasses
{
  public class BaseObject
  {
    public int Id { get; set; }

    public DateTime CreatedOn { get; set; }
    public DateTime LastModifiedOn { get; set; }

    public string CreatedBy { get; set; }
    public string LastModifiedBy { get; set; }

    public bool IsDeleted { get; set; }
    public bool IsActive { get; set; }

 
  }
}

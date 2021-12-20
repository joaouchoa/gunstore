namespace gunstore.Classes
{
    public abstract class Weapon
    {
        public int id { get; protected set; }
        public bool Active { get; set; }
    
        public void Delete()
        {
            this.Active = false;
        }
    }
}
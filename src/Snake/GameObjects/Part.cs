namespace Snake.GameObjects
{
    public class Part : BaseItem
    {
        public void Follow(BaseItem item)
        {
            this.Location = item.Location;
        }
    }
}

namespace AssemblyLine.Classes
{
    public class ObjectInfo
    {
        public string Name;
        public string Direction;
        //public int    ServoNumber;

        public ObjectInfo() { }

        public ObjectInfo(string Name, string Direction)
        {
            this.Name        = Name;
            this.Direction   = Direction;
            //this.ServoNumber = ServoNumber;
        }
    }
}
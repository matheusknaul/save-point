namespace Models.Entities
{
    public class RegisterManager<T> where T : class
    {
        public long LastRegisterId { get; private set; }
        public List<T> Registers { get; private set; } = new();
        private long _version = 0;


        public RegisterManager() 
        {
            LastRegisterId = 0;
            DesserializeRegisterManager();
        }

        public void CreateRegister(T entity)
        {
            Registers.Add(entity);
            LastRegisterId++;
        }

        /// <summary>
        /// Get all last state of Register Manager.
        /// </summary>
        private void DesserializeRegisterManager() { }
    }
}

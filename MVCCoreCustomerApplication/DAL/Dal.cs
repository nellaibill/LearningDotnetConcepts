namespace MVCCoreCustomerApplication.DAL
{
    public interface IDal
    {
        string Guid { get; set; }
        void Add();
        void Update();
    }
    public class EfDal : IDal
    {
        public string Guid { get; set; }
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
    public class AdoDal : IDal
    {
        public string Guid { get; set; }
        public AdoDal()
        {
            this.Guid=System.Guid.NewGuid().ToString();
        }
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}

using System;

namespace MVCCoreTraining
{
    public abstract class DBLayer
    {
        public Guid Value { get; set; }
        public DBLayer()
        {
            Value = Guid.NewGuid();
        }
        public abstract void Add();
    }

    public class Linq : DBLayer
    {
        public override void Add()
        {
            throw new System.NotImplementedException();
        }
    }

    public class EF : DBLayer
    {
        public override void Add()
        {
            throw new System.NotImplementedException();
        }
    }

}

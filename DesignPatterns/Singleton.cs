namespace DesignPatterns
{
    public  class Singleton
    {
        static Singleton instance;

        public string Setting { get; set; } = "Color blue";

        protected Singleton() { }

        public static Singleton Instance()
        {
            if(instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

    }
}

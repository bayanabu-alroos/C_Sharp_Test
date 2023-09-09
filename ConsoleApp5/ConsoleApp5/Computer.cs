class Computer
{
    public decimal Price { get; set; }
    public string ProductionYear { get; set; }
    public void GetStorageDetail() { }
    public void GetCPUDetail() { }


    public class CPU
    {
        public string CPUModel { get; set;}
        public string CPUSpeed { get; set; }

        public bool CanBeOverclocked { get; set; }

        private decimal CPUPrice { get; set; }

    }

    class Storage
    {
        public double StorageSize { get; set;}
        public string StorageType { get; set;}

        private decimal StoragePrice { get; set; }
    }
}


namespace EstateAgency
{
    public class EstateAgency 
    {
        public EstateAgency(int capacity)
        {
            Capacity = capacity;
            this.RealEstates = new List<RealEstate>();
        }

        public int Capacity { get; set; }
        public List<RealEstate> RealEstates  { get; set; }
        public int Count => this.RealEstates.Count;

        public void AddRealEstate(RealEstate realEstate)
        {
            if (Count< Capacity && !RealEstates.Any(a => a.Address == realEstate.Address))
            {
                RealEstates.Add(realEstate);
            }
                return;
          
        }
        public bool RemoveRealEstate(string address)
        {
            RealEstate realEstate = this.RealEstates.FirstOrDefault(re => re.Address == address);
            if (realEstate != null)
            {
                this.RealEstates.Remove(realEstate);
                return true;
            }
            return false;
        }
        public List<RealEstate> GetRealEstates(string postalCode)
        {
            return this.RealEstates.Where(re => re.PostalCode == postalCode).ToList();
        }

        public string GetCheapest() => this.RealEstates.MinBy(x => x.Price).ToString();
        public string GetLargest()
        { 
           var larges = this.RealEstates.Max(x => x.Size).ToString();
            return larges;

        }
        public string EstateReport()
        {
            return $"Real estates available:\n{string.Join("\n", RealEstates)}";
        }


    }
}

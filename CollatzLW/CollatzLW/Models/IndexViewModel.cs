namespace CollatzLW.Models
{
    public class IndexViewModel
    {
        public long Number { get; set; }
        public long Steps { get; set; }
        public List<long> Sequence { get; set; }
        public long Max { get; set; }
    }
}
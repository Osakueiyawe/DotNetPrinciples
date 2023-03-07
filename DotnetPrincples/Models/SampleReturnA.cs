using DotnetPrincples.Interfaces;

namespace DotnetPrincples.Models
{
    public class SampleReturnA:IReturnValue
    {
        public string name { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public string newAddition { get; set; }
    }
}

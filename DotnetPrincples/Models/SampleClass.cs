namespace DotnetPrincples.Models
{
    public class SampleClass
    {
        private string _encapsulation; 
        public string encapsulation
        {
            get
            {
                if(!string.IsNullOrEmpty(_encapsulation))
                {
                    return _encapsulation;
                }
                else
                {
                    return "default";
                }
            }
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    _encapsulation = value;
                }
                else
                {
                    _encapsulation = "defaultString";
                }
            }
        }
        public enum Levels
        {
            first = 1,
            second = 2,
            third = 3,
            fourth = 4,
            fifth = 5,
            sixth = 6,
            seventh = 7
        }
    }
}

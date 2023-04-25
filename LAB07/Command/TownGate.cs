namespace Command
{
    public class CityGate 
    {
        public string TalkToStranger(uint _time)
        {
            string words = string.Empty;

            for(int i = 0; i < _time; i++)
            {
                words += "bla!\n";
            }

            return words;
        }
    }
}
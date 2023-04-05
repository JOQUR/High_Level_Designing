namespace AbstractFactory
{
    public class AdjustableDesk : Desk
    {
        public int Levels { get; set; }
        public AdjustableDesk(Styles _style) 
        {
            Style = _style;
        }

        public void SetHeight(int height) => Levels = height;
    }

}
using TheWarTime.Characters;
using TheWarTime.Items;

namespace TheWarTime;

public class Root
{
    public Vendor Vendor { get; set; }
    public Items.Item Item { get; set; }
    public Characters.Character Character { get; set; }
}
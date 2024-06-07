using System.Collections.Generic;
using System.Reflection;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CalamityModMusic.Items.Placeables;

namespace CalamityModMusic
{
    public class AcceptanceTrackSwitchSystem : ModSystem
    {
        public override void PostSetupContent()
        {
            // This makes it so that the SCal "Acceptance" event records a regular acceptance music box, despite them
            // technically being 2 separate tracks
            if (!Main.dedServ)
            {
                // `musicToItem` is a Dictionary of music slots to item types that is used to
                // convert music boxes while music is playing
                //
                // It is marked as internal, so we need to use reflection to modify it directly, but
                // by doing so we can make it so that 2 different tracks point to the same music box
                FieldInfo info = typeof(MusicLoader).GetField("musicToItem", BindingFlags.NonPublic | BindingFlags.Static);
                var musicToItem = (Dictionary<int, int>)info.GetValue(null);

                int musicSlot = MusicLoader.GetMusicSlot(CalamityModMusic.Instance, "Sounds/Music/CalamitasDefeat_LongFade");
                int itemType = ModContent.ItemType<CalamitasDefeatMusicBox>();

                // The FieldInfo returns the same Dictionary instance as the one in the music loader,
                // so the field does not need to have its value re-set so long as the Dictionary is modified
                musicToItem[musicSlot] = itemType;
            }
        }
    }
}

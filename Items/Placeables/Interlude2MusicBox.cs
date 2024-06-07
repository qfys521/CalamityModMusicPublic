using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    public class Interlude2MusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.Interlude2MusicBox>();
        public override string MusicFilePath => "Sounds/Music/Interlude2";
    }
}
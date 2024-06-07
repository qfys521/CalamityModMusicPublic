using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    public class Interlude3MusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.Interlude3MusicBox>();
        public override string MusicFilePath => "Sounds/Music/Interlude3";
    }
}
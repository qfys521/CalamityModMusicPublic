using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("StormWeaverMusicbox")]
    public class StormWeaverMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.StormWeaverMusicBox>();
        public override string MusicFilePath => "Sounds/Music/StormWeaver";
    }
}

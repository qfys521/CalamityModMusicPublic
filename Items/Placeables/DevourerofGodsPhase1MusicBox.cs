using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("DoGMusicbox")]
    public class DevourerofGodsPhase1MusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.DevourerofGodsPhase1MusicBox>();
        public override string MusicFilePath => "Sounds/Music/DevourerofGodsPhase1";
    }
}

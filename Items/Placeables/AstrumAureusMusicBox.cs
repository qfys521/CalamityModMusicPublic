using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("AstrageldonMusicbox")]
    public class AstrumAureusMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.AstrumAureusMusicBox>();
        public override string MusicFilePath => "Sounds/Music/AstrumAureus";
    }
}

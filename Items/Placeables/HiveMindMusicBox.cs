using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("HiveMindMusicbox")]
    public class HiveMindMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.HiveMindMusicBox>();
        public override string MusicFilePath => "Sounds/Music/HiveMind";
    }
}

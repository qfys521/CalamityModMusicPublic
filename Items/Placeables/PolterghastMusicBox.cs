using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("PolterghastMusicbox")]
    public class PolterghastMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.PolterghastMusicBox>();
        public override string MusicFilePath => "Sounds/Music/Polterghast";
    }
}

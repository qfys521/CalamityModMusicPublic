using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("HigherAbyssMusicbox")]
    public class AbyssLayer2MusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.AbyssLayer2MusicBox>();
        public override string MusicFilePath => "Sounds/Music/AbyssLayer2";
    }
}

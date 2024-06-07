using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("SirenMusicbox")]
    public class AnahitaMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.AnahitaMusicBox>();
        public override string MusicFilePath => "Sounds/Music/Anahita";
    }
}

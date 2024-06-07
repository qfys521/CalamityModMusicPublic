using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("CryogenMusicbox")]
    public class CryogenMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.CryogenMusicBox>();
        public override string MusicFilePath => "Sounds/Music/Cryogen";
    }
}

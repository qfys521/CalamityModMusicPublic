using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("CalamitasMusicbox")]
    public class CalamitasCloneMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.CalamitasCloneMusicBox>();
        public override string MusicFilePath => "Sounds/Music/CalamitasClone";
    }
}

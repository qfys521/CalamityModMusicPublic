using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("DesertScourgeMusicbox")]
    public class DesertScourgeMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.DesertScourgeMusicBox>();
        public override string MusicFilePath => "Sounds/Music/DesertScourge";
    }
}

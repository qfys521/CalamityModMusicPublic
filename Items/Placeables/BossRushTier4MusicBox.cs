using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("BossRushTier4MusicboxItem")]
    public class BossRushTier4MusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.BossRushTier4MusicBox>();
        public override string MusicFilePath => "Sounds/Music/BossRushTier4";
    }
}

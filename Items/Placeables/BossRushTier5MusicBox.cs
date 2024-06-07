using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("BossRushTier5MusicboxItem")]
    public class BossRushTier5MusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.BossRushTier5MusicBox>();
        public override string MusicFilePath => string.Empty;
        public override bool Obtainable => false;
    }
}

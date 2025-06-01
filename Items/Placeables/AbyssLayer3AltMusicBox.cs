using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    public class AbyssLayer3AltMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.AbyssLayer3AltMusicBox>();
        public override string MusicFilePath => "Sounds/Music/AbyssLayer3Alt";
    }
}

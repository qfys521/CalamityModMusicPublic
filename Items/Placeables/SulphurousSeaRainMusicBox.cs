using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    public class SulphurousSeaRainMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.SulphurousSeaRainMusicBox>();
        public override string MusicFilePath => "Sounds/Music/SulphurousSeaRain";
    }
}

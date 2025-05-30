using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    public class AbyssLegacyMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.AbyssLegacyMusicBox>();
        public override string MusicFilePath => "Sounds/Music/AbyssLegacy";

        public override void AddRecipes()
        {
            // Does not play in-game
            CreateRecipe().
                AddIngredient(ModContent.ItemType<AbyssLayer1MusicBox>()).
                AddIngredient(ModContent.ItemType<AbyssLayer2MusicBox>()).
                AddIngredient(ModContent.ItemType<AbyssLayer3MusicBox>()).
                AddIngredient(ModContent.ItemType<AbyssLayer4MusicBox>()).
                AddTile(TileID.TinkerersWorkbench).
                Register();
        }
    }
}

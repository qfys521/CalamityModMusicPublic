using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    public class BrainstormTrailerMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.BrainstormTrailerMusicBox>();
        public override string MusicFilePath => "Sounds/Music/BrainstormTrailer";

        public override void AddRecipes()
        {
            var VCMM = ModLoader.TryGetMod("UnCalamityModMusic", out Mod vcmm);

            // Does not play in-game
            CreateRecipe().
                AddIngredient(ItemID.MusicBoxBoss3).
                AddIngredient(ModContent.ItemType<DevourerofGodsPhase1MusicBox>()).
                AddIngredient(ItemID.MusicBoxStorm).
                AddTile(TileID.TinkerersWorkbench).
                Register();

            // Alternate recipe for VCMM boxes in addition to the one above
            if (VCMM)
            {
                CreateRecipe().
                    AddIngredient(vcmm, "BrainofCthulhuMusicBox").
                    AddIngredient(ModContent.ItemType<DevourerofGodsPhase1MusicBox>()).
                    AddIngredient(vcmm, "RainDayMusicBox"). // Temporary; should be VCMM's Thunderstorm box when added. Vanilla storm music will not play with VCMM, so a Rain box must be used for now.
                    AddTile(TileID.TinkerersWorkbench).
                    Register();
            }
        }
    }
}

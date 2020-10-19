using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent;

namespace Terraria.Initializers
{
	partial class AssetInitializer
	{
        private static void LoadAvalonTextures(AssetRequestMode mode) {
            TextureAssets.Lightning1 = LoadAsset<Texture2D>("Images\\Lightning1", mode);
			TextureAssets.Lightning2 = LoadAsset<Texture2D>("Images\\Lightning2", mode);
			TextureAssets.Wood[7] = LoadAsset<Texture2D>("Images\\Tiles_5_7", mode);
			TextureAssets.Wood[8] = LoadAsset<Texture2D>("Images\\Tiles_5_8", mode);
			TextureAssets.Wood[9] = LoadAsset<Texture2D>("Images\\Tiles_5_9", mode);
			TextureAssets.AvalonChain39 = LoadAsset<Texture2D>("Images\\AvalonChain39", mode);
			TextureAssets.AvalonChain40 = LoadAsset<Texture2D>("Images\\AvalonChain40", mode);
			TextureAssets.AvalonChain41 = LoadAsset<Texture2D>("Images\\AvalonChain41", mode);
			TextureAssets.AvalonChain42 = LoadAsset<Texture2D>("Images\\AvalonChain42", mode);
			TextureAssets.AvalonChain43 = LoadAsset<Texture2D>("Images\\AvalonChain43", mode);
			TextureAssets.AvalonChain44 = LoadAsset<Texture2D>("Images\\AvalonChain44", mode);
			TextureAssets.BeamEnd = LoadAsset<Texture2D>("Images\\BeamEnd", mode);
			TextureAssets.BeamPhantasm = LoadAsset<Texture2D>("Images\\BeamPhantasm", mode);
			TextureAssets.BeamStart = LoadAsset<Texture2D>("Images\\BeamStart", mode);
			TextureAssets.BeamVenoshock = LoadAsset<Texture2D>("Images\\BeamVenoshock", mode);
			TextureAssets.ForceField = LoadAsset<Texture2D>("Images\\ForceField", mode);
			TextureAssets.Heart3 = LoadAsset<Texture2D>("Images\\Heart3", mode);
			TextureAssets.IckyCactus = LoadAsset<Texture2D>("Images\\Icky_Cactus", mode);
			TextureAssets.Mana2 = LoadAsset<Texture2D>("Images\\Mana2", mode);
			TextureAssets.Mana3 = LoadAsset<Texture2D>("Images\\Mana3", mode);
			TextureAssets.Mana4 = LoadAsset<Texture2D>("Images\\Mana4", mode);
			TextureAssets.Mana5 = LoadAsset<Texture2D>("Images\\Mana5", mode);
			TextureAssets.Mana6 = LoadAsset<Texture2D>("Images\\Mana6", mode);
			TextureAssets.ChainTTex= LoadAsset<Texture2D>("Images\\TrifectalBallChain", mode);
			TextureAssets.ConnectTTex = LoadAsset<Texture2D>("Images\\TrifectalBallConnect", mode);
			TextureAssets.OuterTTex = LoadAsset<Texture2D>("Images\\TrifectalBallSpikes", mode);
			TextureAssets.WallofSteel = LoadAsset<Texture2D>("Images\\WallofSteel", mode);
			for (int i = 0; i < 33; i++)
				TextureAssets.JukeTexture[i] = LoadAsset<Texture2D>("Images\\JukeboxButton_" + i, mode);
			TextureAssets.JukeTexture[33] = LoadAsset<Texture2D>("Images\\JukeboxStop", mode);
		}
	}
}

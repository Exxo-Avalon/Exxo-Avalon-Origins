namespace Terraria.ModLoader.Default
{
	public class UnloadedTile : ModTile
	{
		public override string Name{get;}

		public override string Texture => "ModLoader/UnloadedTile";

		public UnloadedTile(string name = null) {
			Name = name ?? base.Name;
		}

		public override void SetDefaults() {
			Main.tileSolid[Type] = true;
			Main.tileFrameImportant[Type] = true;
		}

		public override void MouseOver(int i, int j)
		{
			var tile = Main.tile[i, j];
			if(tile != null && tile.type == Type) {
				var frame = new UnloadedTileFrame(tile.frameX, tile.frameY);
				var info = ModContent.GetInstance<UnloadedTilesWorld>().infos[frame.FrameID];

				if(info != null) {
					Main.LocalPlayer.cursorItemIconEnabled = true;
					Main.LocalPlayer.cursorItemIconID = -1;
					Main.LocalPlayer.cursorItemIconText = $"{info.modName}: {info.name}";
				}
			}
		}
	}
}

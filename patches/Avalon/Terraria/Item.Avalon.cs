using Microsoft.Xna.Framework;
using Terraria.ID;

namespace Terraria
{
	partial class Item
	{
		// TODO: Stuff after setdefaults
		// TODO: Tooltips

		public int projFireDelay;
		public bool gemWand;
		public bool worksInVanity;
		public bool tome;
		public bool invince;
		public int torch;
		public int wallWand = -1;
		public int healStamina;
		public string name;
		public string toolTip;
		public string toolTip2;

		public bool IsArmor() => (headSlot > 0 || bodySlot > 0 || legSlot > 0) && !vanity;

		public bool IsWings(int invType) => invType == ItemID.DemonWings || invType == ItemID.AngelWings || invType == ItemID.BeeWings || invType == ItemID.FishronWings || invType == ItemID.BatWings || invType == ItemID.BeetleWings || invType == ItemID.BoneWings || invType == ItemID.ButterflyWings || invType == ItemID.FairyWings || invType == ItemID.FestiveWings || invType == ItemID.FinWings || invType == ItemID.FlameWings || invType == ItemID.FrozenWings || invType == ItemID.GhostWings || invType == ItemID.HarpyWings || invType == ItemID.LeafWings || invType == ItemID.SpookyWings || invType == ItemID.TatteredFairyWings;

		public void SetItemIDsWIthOffset(int regType) {
			int offsetType = regType - 2339;

			switch (offsetType) {
				case 2749:
					name = "Shadow Mirror";
					width = 24;
					height = 24;
					UseSound = SoundID.Item6;
					rare = 7;
					useAnimation = 90;
					useTime = 90;
					useTurn = true;
					mana = 30;
					value = 500000;
					useStyle = 4;
					toolTip = "Gaze in the mirror to return home";
					//TODO: toolTip2 = "Press " + Main.cMode + " to change waypoint modes";
					break;

				case 2750:
					name = "Anger Talisman";
					width = 30;
					height = 38;
					accessory = true;
					neckSlot = 7;
					value = Item.sellPrice(0, 9, 0, 0);
					rare = 5;
					defense = -10;
					toolTip = "27% increased damage and minus 10 defense";
					toolTip2 = "'Can you say, \"Grrr!\"?'";
					break;

				case 2751:
					name = "Crimson Potion";
					width = 10;
					height = 26;
					useTime = 15;
					useAnimation = 15;
					UseSound = SoundID.Item3;
					useStyle = 2;
					consumable = true;
					maxStack = 100;
					buffType = 140;
					buffTime = 18000;
					value = Item.sellPrice(0, 0, 3, 0);
					rare = 2;
					toolTip = "Enemies within a ten tile radius take damage";
					break;

				case 2752:
					name = "Goblin Army Knife";
					width = 24;
					height = 48;
					accessory = true;
					value = Item.sellPrice(0, 15, 0, 0);
					rare = 6;
					defense = 4;
					lifeRegen = 2;
					toolTip = "Immune time after being damaged increased, provides life/mana regen, +7% dmg and the holder can quintuple jump";
					toolTip2 = "Tells time, provides light, shows position, +4 block range, can craft certain items by hand, +2% crit, Shows ores/mobs";
					break;

				case 2753:
					name = "Goblin Toolbelt";
					width = 30;
					height = 22;
					accessory = true;
					value = Item.sellPrice(0, 5, 0, 0);
					rare = 4;
					toolTip = "Increases block placement range by 2, tells time and shows position";
					toolTip2 = "Can craft Tinkerer's Workshop and Work Bench items by hand";
					break;

				case 2754:
					name = "Ancient Headpiece";
					width = 28;
					height = 26;
					defense = 30; //40;
					headSlot = 169;
					rare = 9;
					value = Item.sellPrice(0, 50, 0, 0);
					toolTip = "20% increased damage";
					toolTip2 = "5% increased critical strike chance";
					break;

				case 2755:
					name = "Ancient Bodyplate";
					width = 34;
					height = 20;
					defense = 35; //45;
					bodySlot = 175;
					rare = 9;
					value = Item.sellPrice(0, 40, 0, 0);
					toolTip = "Enemies are more likely to target you";
					toolTip2 = "Minion knockback is increased by 10%";
					break;

				case 2756:
					name = "Ancient Leggings";
					width = 22;
					height = 18;
					defense = 25; //35;
					legSlot = 110;
					rare = 9;
					value = Item.sellPrice(0, 30, 0, 0);
					toolTip = "Increases your max number of minions by 3";
					toolTip2 = "Increases maximum mana by 80";
					break;

				case 2757:
					name = "Timechanger";
					width = 24;
					height = 24;
					shoot = 426;
					useStyle = 1;
					useTime = 30;
					useAnimation = 15;
					UseSound = SoundID.Item1;
					value = Item.sellPrice(0, 2, 70, 0);
					rare = 4;
					break;

				case 2758:
					name = "Shockwave Potion";
					width = 28;
					height = 28;
					useTime = 15;
					useAnimation = 15;
					rare = 2;
					toolTip = "Enemies take damage when you land";
					UseSound = SoundID.Item3;
					buffTime = 25200;
					buffType = 141;
					useStyle = 2;
					consumable = true;
					maxStack = 100;
					value = 1000;
					break;

				case 2759:
					name = "Reflex Charm";
					width = 30;
					height = 28;
					accessory = true;
					value = Item.sellPrice(0, 1, 8, 0);
					rare = 4;
					defense = 2;
					toolTip = "Gives a chance to reflect projectiles";
					break;

				case 2760:
					name = "Reflex Shield";
					width = 34;
					height = 36;
					accessory = true;
					value = Item.sellPrice(0, 17, 45, 0);
					rare = 9;
					defense = 6;
					shieldSlot = 5;
					toolTip = "Gives a chance to reflect projectiles and immunity to most debuffs";
					toolTip2 = "Grants immunity to fire blocks and knockback";
					break;

				case 2761:
					name = "Quad Whip";
					width = 44;
					height = 40;
					rare = 8;
					value = Item.sellPrice(0, 12, 0, 0);
					useAnimation = 20;
					useTime = 20;
					useStyle = 5;
					noMelee = true;
					noUseGraphic = true;
					UseSound = SoundID.Item1;
					shoot = 423;
					shootSpeed = 16f;
					useTurn = true;
					knockBack = 7;
					break;

				case 2762:
					name = "Inertia Boots";
					width = 32;
					height = 28;
					rare = 7;
					defense = 4;
					shoeSlot = 16;
					wingSlot = 27;
					value = Item.sellPrice(0, 16, 45, 0);
					accessory = true;
					toolTip = "Allows flight and slow fall and the wearer can run incredibly fast";
					toolTip2 = "The wearer has a chance to dodge attacks and negates fall damage";
					break;

				case 2763:
					name = "Frost Gauntlet";
					width = 26;
					height = 30;
					accessory = true;
					value = Item.sellPrice(0, 10, 0, 0);
					rare = 7;
					handOnSlot = 18;
					handOffSlot = 11;
					toolTip = "Melee attacks inflict Frostburn and increases damage and melee speed by 9%";
					toolTip2 = "Increases knockback and puts a damage-reducing shell around the holder when below 25% life";
					break;

				case 2764:
					name = "Hades' Cross";
					width = 38;
					height = 38;
					rare = 6;
					value = Item.sellPrice(0, 9, 72, 0);
					accessory = true;
					defense = 3;
					toolTip = "Provides the ability to breathe in, and free movement in lava";
					toolTip2 = "Negates damage from lava";
					break;

				case 2765:
					name = "Mana Compromise";
					width = 28;
					height = 48;
					rare = 8;
					value = Item.sellPrice(0, 6, 70, 0);
					accessory = true;
					toolTip = "Increases maximum mana by 100";
					toolTip2 = "10% decreased magic damage and 7% decreased mana usage";
					break;

				case 2766:
					name = "Transformation Talisman";
					width = 30;
					height = 28;
					rare = 9;
					defense = 2;
					value = Item.sellPrice(0, 10, 0, 0);
					accessory = true;
					toolTip = "Turns the holder into merfolk upon entering water and lava";
					toolTip2 = "Turns the holder into a werewolf at night";
					break;

				case 2767:
					name = "Life Dew";
					width = 26;
					height = 28;
					maxStack = 999;
					value = 100000;
					rare = 8;
					toolTip = "'The essence of living creatures'";
					break;

				case 2768:
					name = "Elixir of Life";
					UseSound = SoundID.Item3;
					healLife = 350;
					useStyle = 2;
					useTurn = true;
					useAnimation = 17;
					useTime = 17;
					maxStack = 60;
					consumable = true;
					width = 14;
					height = 24;
					rare = 7;
					potion = true;
					toolTip = "'It refreshes you'";
					value = 10000;
					break;

				case 2769:
					name = "Freeze Bolt";
					UseSound = SoundID.Item21;
					useStyle = 5;
					useTurn = true;
					useAnimation = 17;
					useTime = 17;
					width = 28;
					height = 30;
					rare = 5;
					noMelee = true;
					knockBack = 5;
					shootSpeed = 7;
					shoot = 424;
					autoReuse = true;
					damage = 43;
					mana = 11;
					magic = true;
					toolTip = "Casts a fast-moving bolt of ice";
					value = 50000;
					break;

				case 2770:
					name = "Dulling Talisman";
					width = 26;
					height = 32;
					rare = 4;
					value = Item.sellPrice(0, 1, 63, 0);
					accessory = true;
					defense = 10;
					lifeRegen = 2;
					toolTip = "Provides life regeneration";
					break;

				case 2771:
					name = "Chaos Tome";
					UseSound = SoundID.Item8;
					useStyle = 5;
					useTurn = true;
					useAnimation = 25;
					useTime = 25;
					width = 28;
					height = 30;
					noMelee = true;
					rare = 2;
					knockBack = 4;
					shootSpeed = 8;
					shoot = 425;
					autoReuse = true;
					damage = 24;
					mana = 8;
					magic = true;
					toolTip = "Casts a chaos bolt";
					value = 18400;
					break;

				case 2772:
					name = "Soul of Ice";
					width = 22;
					height = 22;
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createTile = 380;
					noUseGraphic = true;
					value = 50000;
					rare = 4;
					toolTip = "'The essence of ice creatures'";
					break;

				case 2773:
					name = "Magnet";
					width = 24;
					height = 24;
					rare = 5;
					accessory = true;
					toolTip = "Triples item grab range";
					value = 150000;
					break;

				case 2774:
					name = "Plantera's Fury";
					width = 76;
					height = 34;
					damage = 26;
					knockBack = 3;
					useAnimation = 4;
					useTime = 4;
					rare = 8;
					value = Item.sellPrice(0, 30, 0, 0);
					useStyle = 5;
					UseSound = SoundID.Item41;
					autoReuse = true;
					useTurn = false;
					crit += 2;
					useAmmo = 14;
					shoot = 14;
					shootSpeed = 14;
					noMelee = true;
					ranged = true;
					toolTip = "60% chance to not consume ammo";
					break;

				case 2775:
					name = "Confusion Talisman";
					width = 32;
					height = 24;
					accessory = true;
					rare = 5;
					toolTip = "12% chance for your attacks to confuse your enemies";
					value = Item.sellPrice(0, 3, 0, 0);
					break;

				case 2776:
					name = "Tactical Expulsor";
					width = 70;
					height = 22;
					damage = 31; // 200;
					knockBack = 3;
					useAnimation = 21;
					useTime = 21;
					rare = 9;
					value = Item.sellPrice(0, 20, 0, 0);
					useStyle = 5;
					UseSound = SoundID.Item38;
					autoReuse = true;
					useTurn = false;
					crit += 1;
					useAmmo = 14;
					shoot = 14;
					shootSpeed = 7f;
					noMelee = true;
					ranged = true;
					toolTip = "Fires a spread of eight bullets";
					break;

				case 2777:
					useStyle = 4;
					name = "Odd Fertilizer";
					width = 18;
					height = 22;
					rare = 4;
					consumable = true;
					useAnimation = 45;
					useTime = 45;
					maxStack = 20;
					toolTip = "Summons Plantera";
					break;

				case 2778:
					useStyle = 2;
					UseSound = SoundID.Item3;
					name = "Luck Potion";
					rare = 2;
					consumable = true;
					maxStack = 100;
					useTime = 15;
					useAnimation = 15;
					width = 18;
					height = 22;
					toolTip = "Doubles rare drop chance";
					buffType = 144;
					buffTime = 108000;
					break;

				case 2788:
					name = "Magmafrost Bolt";
					UseSound = SoundID.Item21;
					useStyle = 5;
					useTurn = true;
					useAnimation = 15;
					useTime = 15;
					width = 28;
					height = 30;
					rare = 8;
					noMelee = true;
					knockBack = 5;
					shootSpeed = 10;
					shoot = 427;
					autoReuse = true;
					damage = 67;
					mana = 10;
					magic = true;
					toolTip = "Casts a superfast-moving bolt of igneonic frost";
					value = Item.sellPrice(0, 10, 0, 0);
					break;

				case 2789:
					name = "Quadro Cannon";
					UseSound = SoundID.Item11;
					useStyle = 5;
					reuseDelay = 14;
					useAnimation = 16;
					useTime = 4;
					width = 28;
					height = 30;
					rare = 8;
					noMelee = true;
					knockBack = 5;
					shootSpeed = 14;
					shoot = 14;
					useAmmo = 14;
					autoReuse = true;
					damage = 16;
					ranged = true;
					toolTip = "Four round burst - only the first shot consumes ammo";
					toolTip2 = "Fires a spread of bullets";
					value = 780000;
					break;

				case 2816:
					rare = 8;
					UseSound = SoundID.Item1;
					name = "Vertex of Excalibur";
					useStyle = 1;
					damage = 85;
					useTurn = true;
					useAnimation = 16;
					autoReuse = true;
					useTime = 16;
					width = 68;
					height = 68;
					scale = 1.0f;
					knockBack = 5f;
					toolTip = "'The unification of dark and light'";
					melee = true;
					value = Item.sellPrice(0, 9, 63, 0);
					break;

				case 2817:
					name = "Demon Altar";
					width = 48;
					height = 34;
					useAnimation = 20;
					useTime = 20;
					consumable = true;
					maxStack = 99;
					createTile = 26;
					placeStyle = 4;
					useStyle = 1;
					rare = 1;
					toolTip = "The spirit of Cthulhu guards this altar";
					break;

				case 2818:
					name = "Instantanium Picksaw";
					useStyle = 1;
					useAnimation = 11;
					useTime = 5;
					knockBack = 5.5f;
					useTurn = true;
					autoReuse = true;
					width = 20;
					height = 12;
					damage = 30;
					pick = 350;
					axe = 35;
					UseSound = SoundID.Item1;
					rare = 9;
					value = 416000;
					melee = true;
					scale = 1.15f;
					tileBoost += 4;
					toolTip = "'The ultimate tool'";
					break;

				case 2819:
					name = "Berserker Bullet";
					shootSpeed = 6f;
					shoot = 428;
					damage = 18;
					width = 8;
					height = 8;
					maxStack = 2000;
					consumable = true;
					ammo = 14;
					knockBack = 4.0f;
					value = 200;
					ranged = true;
					rare = 9;
					break;

				case 2820:
					name = "Boomlash";
					rare = 8;
					value = Item.sellPrice(0, 2, 0, 0);
					magic = true;
					knockBack = 12f;
					channel = true;
					damage = 80;
					useAnimation = 30;
					useTime = 30;
					useStyle = 1;
					UseSound = SoundID.Item20;
					width = 26;
					height = 26;
					mana = 40;
					noMelee = true;
					shoot = 430;
					shootSpeed = 4f;
					toolTip = "Summons a terrain-destroying missile";
					break;

				case 2821:
					name = "Magic Grenade";
					rare = 9;
					value = Item.sellPrice(0, 10, 0, 0);
					magic = true;
					knockBack = 8f;
					damage = 85;
					useAnimation = 27;
					useTime = 27;
					useStyle = 1;
					UseSound = SoundID.Item1;
					width = 20;
					height = 20;
					mana = 40;
					noMelee = true;
					noUseGraphic = true;
					shoot = 431;
					shootSpeed = 8f;
					toolTip = "A small explosion that will not destroy tiles";
					break;

				case 2822:
					name = "Rainbringer";
					width = 24;
					height = 24;
					shoot = 432;
					useStyle = 1;
					useTime = 30;
					useAnimation = 15;
					UseSound = SoundID.Item1;
					value = Item.sellPrice(0, 2, 70, 0);
					rare = 4;
					break;

				case 2823:
					name = "Mythril Splitknife";
					ranged = true;
					maxStack = 999;
					value = 250;
					noMelee = true;
					noUseGraphic = true;
					consumable = true;
					useTime = 18;
					useAnimation = 18;
					useStyle = 1;
					damage = 25;
					knockBack = 2f;
					UseSound = SoundID.Item1;
					shootSpeed = 10f;
					toolTip = "Splits into three knives";
					shoot = 433;
					rare = 4;
					height = 24;
					width = 18;
					break;

				case 2824:
					name = "Orichalcum Splitblade";
					ranged = true;
					maxStack = 999;
					value = 250;
					noMelee = true;
					noUseGraphic = true;
					consumable = true;
					useTime = 18;
					useAnimation = 18;
					useStyle = 1;
					crit += 1;
					damage = 31;
					knockBack = 2f;
					UseSound = SoundID.Item1;
					shootSpeed = 10f;
					toolTip = "Splits into three knives";
					shoot = 434;
					rare = 4;
					height = 24;
					width = 18;
					break;

				case 2825:
					name = "Hallowed Kunai";
					ranged = true;
					maxStack = 999;
					value = 400;
					noMelee = true;
					noUseGraphic = true;
					consumable = true;
					useTime = 10;
					useAnimation = 10;
					useStyle = 1;
					crit += 2;
					damage = 38;
					knockBack = 2.5f;
					UseSound = SoundID.Item1;
					shootSpeed = 11f;
					shoot = 435;
					rare = 5;
					height = 34;
					width = 14;
					break;

				case 2826:
					name = "Chlorophyte Star";
					ranged = true;
					maxStack = 999;
					value = 500;
					noMelee = true;
					noUseGraphic = true;
					consumable = true;
					useTime = 10;
					useAnimation = 10;
					useStyle = 1;
					crit += 4;
					damage = 45;
					knockBack = 3.75f;
					UseSound = SoundID.Item1;
					shootSpeed = 9f;
					shoot = 436;
					rare = 7;
					height = 26;
					width = 26;
					break;

				case 2827:
					name = "Sunlight Kunai";
					ranged = true;
					maxStack = 999;
					value = 550;
					noMelee = true;
					noUseGraphic = true;
					consumable = true;
					useTime = 15;
					useAnimation = 15;
					useStyle = 1;
					crit += 6;
					damage = 49;
					knockBack = 4f;
					UseSound = SoundID.Item1;
					shootSpeed = 12f;
					shoot = 437;
					rare = 8;
					height = 34;
					width = 14;
					break;

				case 2828:
					useStyle = 2;
					UseSound = SoundID.Item3;
					name = "Blood Cast Potion";
					rare = 2;
					consumable = true;
					maxStack = 100;
					useTime = 15;
					useAnimation = 15;
					width = 18;
					height = 22;
					toolTip = "Adds your max life to your max mana";
					buffType = 145;
					buffTime = 18000;
					value = Item.sellPrice(0, 0, 5, 0);
					break;

				case 2829:
					name = "Eclipse of Doom";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 242;
					toolTip = "'B. Harold'";
					width = 30;
					height = 30;
					rare = 5;
					value = Item.sellPrice(0, 0, 10, 0);
					placeStyle = 27;
					break;

				case 2830:
					name = "Ruined Civilization";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 242;
					toolTip = "'B. Harold'";
					width = 30;
					height = 30;
					rare = 4;
					value = Item.sellPrice(0, 0, 10, 0);
					placeStyle = 28;
					break;

				case 2831:
					name = "Trespassing";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 242;
					toolTip = "'B. Harold'";
					width = 30;
					height = 30;
					rare = 2;
					value = Item.sellPrice(0, 0, 10, 0);
					placeStyle = 29;
					break;

				case 2832:
					name = "Birth of a Monster";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 242;
					toolTip = "'Sir E. Brum'";
					width = 30;
					height = 30;
					rare = 1;
					value = Item.sellPrice(0, 0, 10, 0);
					placeStyle = 30;
					break;

				case 2833:
					name = "Evil Ouroboros";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 242;
					toolTip = "'Sir E. Brum'";
					width = 30;
					height = 30;
					rare = 1;
					value = Item.sellPrice(0, 0, 10, 0);
					placeStyle = 31;
					break;

				case 2834:
					name = "A Comet Has Struck Ground";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 242;
					toolTip = "'B. Harold'";
					width = 30;
					height = 30;
					rare = 2;
					value = Item.sellPrice(0, 0, 10, 0);
					placeStyle = 32;
					break;

				case 2835:
					name = "Plantera's Rage";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 242;
					toolTip = "'B. Harold'";
					width = 30;
					height = 30;
					rare = 7;
					value = Item.sellPrice(0, 0, 10, 0);
					placeStyle = 33;
					break;

				case 2836:
					name = "Orange Brick";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createTile = 342;
					width = 12;
					height = 12;
					break;

				case 2837:
					name = "Orange Brick Wall";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 7;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createWall = 175;
					width = 12;
					height = 12;
					break;

				case 2838:
					name = "Orange Slab Wall";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 7;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createWall = 176;
					width = 12;
					height = 12;
					break;

				case 2839:
					name = "Orange Tiled Wall";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 7;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createWall = 177;
					width = 12;
					height = 12;
					break;

				case 2840:
					name = "Moonphaser";
					width = 24;
					height = 24;
					shoot = 438;
					useStyle = 1;
					useTime = 30;
					useAnimation = 15;
					toolTip = "Changes the phases of the Moon";
					toolTip2 = "Has a chance to trigger a Blood Moon if night";
					UseSound = SoundID.Item1;
					value = Item.sellPrice(0, 2, 70, 0);
					rare = 4;
					break;

				case 2841:
					name = "Jukebox";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					rare = 2;
					toolTip = "Used to play tunes";
					value = Item.sellPrice(0, 4, 0, 0);
					createTile = 343;
					width = 30;
					height = 30;
					break;

				case 2842:
					name = "Apollo's Quiver";
					width = 30;
					height = 30;
					accessory = true;
					toolTip = "20% chance to not consume arrows and 15% increased arrow damage";
					toolTip2 = "Increases arrow speed by 10% and critical strike chance by 5%";
					value = Item.sellPrice(0, 7, 0, 0);
					rare = 8;
					break;

				case 2843:
					name = "Crystal Edge";
					width = 30;
					height = 30;
					accessory = true;
					toolTip = "Increases damage by 25";
					value = Item.sellPrice(0, 4, 0, 0);
					rare = 4;
					break;

				case 2844:
					name = "Chaos Crystal";
					width = 28;
					height = 26;
					accessory = true;
					toolTip = "15% increased critical strike damage";
					value = Item.sellPrice(0, 3, 0, 0);
					rare = 7;
					break;

				case 2845:
					name = "Chaos Emblem";
					width = 28;
					height = 28;
					accessory = true;
					toolTip = "10% increased critical strike damage";
					toolTip2 = "10% increased damage";
					value = Item.sellPrice(0, 6, 0, 0);
					rare = 8;
					break;

				case 2846:
					name = "Beak";
					width = 32;
					height = 20;
					maxStack = 999;
					value = 50;
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = true;
					useTurn = true;
					autoReuse = true;
					createTile = 407;
					break;

				case 2847:
					name = "Starbright Potion";
					width = 10;
					height = 26;
					buffTime = 18000;
					buffType = 146;
					value = 2000;
					useAnimation = 15;
					useTime = 15;
					UseSound = SoundID.Item3;
					useStyle = 2;
					consumable = true;
					rare = 2;
					maxStack = 100;
					toolTip = "Fallen Stars fall more frequently";
					break;

				case 2848:
					name = "Alchemical Skull";
					width = 20;
					height = 22;
					rare = 4;
					accessory = true;
					value = 150000;
					defense = 8;
					toolTip = "Increases spawn rate and Attackers also take damage";
					toolTip2 = "The wearer can walk on water and lava and grants immunity to fire blocks";
					break;

				case 2849:
					name = "Bag of Fire";
					width = 24;
					height = 28;
					accessory = true;
					vanity = true;
					toolTip = "Flame particles cover you when you move";
					rare = 2;
					worksInVanity = true;
					value = Item.sellPrice(0, 1, 0, 0);
					break;

				case 2850:
					name = "Bag of Shadows";
					width = 24;
					height = 28;
					accessory = true;
					vanity = true;
					toolTip = "Shadow particles cover you when you move";
					rare = 1;
					worksInVanity = true;
					value = Item.sellPrice(0, 1, 0, 0);
					break;

				case 2851:
					name = "Eidetic Mirror";
					width = 24;
					height = 24;
					UseSound = SoundID.Item6;
					rare = 6;
					useAnimation = 90;
					useTime = 90;
					useTurn = true;
					value = Item.sellPrice(0, 2, 0, 0);
					useStyle = 4;
					toolTip = "Teleports you to a team member in multiplayer";
					toolTip2 = "Has no effect in singleplayer";
					break;

				case 2852:
					rare = 5;
					UseSound = SoundID.Item1;
					name = "Hallowed Greatsword";
					useStyle = 1;
					damage = 43;
					useTurn = true;
					useAnimation = 26;
					autoReuse = true;
					useTime = 26;
					width = 68;
					height = 68;
					scale = 1.5f;
					knockBack = 2f;
					melee = true;
					value = Item.sellPrice(0, 5, 55, 0);
					break;

				case 2853:
					name = "Banhammer";
					useTurn = true;
					autoReuse = true;
					useStyle = 1;
					useAnimation = 17;
					useTime = 10;
					hammer = 100;
					width = 64;
					height = 64;
					damage = 30;
					knockBack = 12f;
					scale = 1f;
					UseSound = SoundID.Item1;
					rare = 7;
					value = Item.sellPrice(0, 2, 0, 0);
					melee = true;
					toolTip = "Strong enough to destroy Hallowed Altars";
					toolTip2 = "Hallowed Altars can only be destroyed in Superhardmode";
					break;

				case 2854:
					name = "Heartstone";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = true;
					useTurn = true;
					autoReuse = true;
					createTile = 344;
					maxStack = 999;
					width = 16;
					height = 16;
					value = Item.sellPrice(0, 0, 1, 50);
					rare = 2;
					break;

				case 2855:
					name = "Heartstone Brick";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = true;
					useTurn = true;
					autoReuse = true;
					createTile = 345;
					maxStack = 999;
					width = 12;
					height = 12;
					value = 0;
					rare = 2;
					break;

				case 2856:
					name = "Heartstone Brick Wall";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 7;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createWall = 178;
					width = 12;
					height = 12;
					break;

				case 2857:
					rare = 2;
					UseSound = SoundID.Item1;
					name = "Desert Long Sword";
					useStyle = 1;
					damage = 29;
					useTurn = true;
					useAnimation = 27;
					useTime = 27;
					width = 40;
					height = 40;
					scale = 1f;
					knockBack = 3f;
					melee = true;
					value = Item.sellPrice(0, 0, 54, 0);
					break;

				case 2858:
					name = "Corruption Seed";
					shoot = 439;
					width = 8;
					height = 8;
					rare = 1;
					maxStack = 999;
					ammo = 51;
					toolTip = "For use with Blowpipes";
					damage = 2;
					ranged = true;
					break;

				case 2859:
					name = "Crystal Seed";
					shoot = 440;
					width = 8;
					height = 8;
					maxStack = 999;
					ammo = 51;
					rare = 3;
					toolTip = "For use with Blowpipes";
					damage = 5;
					ranged = true;
					break;

				case 2860:
					name = "Cursed Seed";
					shoot = 441;
					width = 8;
					height = 8;
					maxStack = 999;
					ammo = 51;
					rare = 3;
					toolTip = "For use with Blowpipes";
					damage = 9;
					ranged = true;
					break;

				case 2861:
					name = "Hellstone Dart";
					shoot = 442;
					width = 14;
					height = 28;
					rare = 2;
					maxStack = 999;
					ammo = 51;
					toolTip = "For use with Blowpipes";
					damage = 9;
					ranged = true;
					break;

				case 2862:
					name = "Jungle Seed";
					shoot = 443;
					width = 8;
					height = 8;
					maxStack = 999;
					ammo = 51;
					rare = 3;
					toolTip = "For use with Blowpipes";
					damage = 3;
					ranged = true;
					break;

				case 2863:
					useStyle = 5;
					autoReuse = true;
					useAnimation = 40;
					useTime = 40;
					name = "Reinforced Blowpipe";
					width = 38;
					height = 6;
					shoot = 10;
					useAmmo = 51;
					UseSound = SoundID.Item5;
					rare = 1;
					damage = 11;
					shootSpeed = 11f;
					noMelee = true;
					value = 10000;
					knockBack = 3.25f;
					toolTip = "Fires a spread of two seeds";
					toolTip2 = "Allows the collection of seeds for ammo";
					ranged = true;
					break;

				case 2864:
					useStyle = 5;
					autoReuse = true;
					useAnimation = 30;
					useTime = 30;
					name = "Hallowed Blowpipe";
					width = 38;
					height = 6;
					shoot = 10;
					useAmmo = 51;
					UseSound = SoundID.Item5;
					damage = 17;
					rare = 5;
					shootSpeed = 11f;
					noMelee = true;
					value = 10000;
					knockBack = 3.25f;
					toolTip = "Fires a spread of ten seeds";
					toolTip2 = "Allows the collection of seeds for ammo";
					ranged = true;
					break;

				case 2865:
					useStyle = 5;
					autoReuse = true;
					useAnimation = 28;
					useTime = 28;
					name = "Sun's Shadow";
					width = 38;
					height = 6;
					shoot = 10;
					useAmmo = 51;
					UseSound = SoundID.Item5;
					damage = 21;
					shootSpeed = 11f;
					rare = 8;
					noMelee = true;
					value = 10000;
					knockBack = 4f;
					toolTip = "Fires a spread of twelve seeds";
					toolTip2 = "Allows the collection of seeds for ammo";
					ranged = true;
					break;

				case 2866:
					name = "Crimson Seed";
					shoot = 444;
					width = 8;
					height = 8;
					rare = 1;
					maxStack = 999;
					ammo = 51;
					toolTip = "For use with Blowpipes";
					damage = 4;
					ranged = true;
					break;

				case 2867:
					useStyle = 5;
					autoReuse = true;
					useAnimation = 30;
					useTime = 30;
					name = "Lyonic Blowpipe";
					width = 38;
					height = 6;
					shoot = 10;
					useAmmo = 51;
					UseSound = SoundID.Item5;
					damage = 13;
					rare = 4;
					shootSpeed = 11f;
					noMelee = true;
					value = 10000;
					knockBack = 3.25f;
					toolTip = "Fires a spread of seven seeds";
					toolTip2 = "Allows the collection of seeds for ammo";
					ranged = true;
					break;

				case 2868:
					name = "Impervious Brick";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = true;
					useTurn = true;
					autoReuse = true;
					createTile = 346;
					maxStack = 999;
					width = 12;
					height = 12;
					value = 0;
					rare = 5;
					break;

				case 2869:
					useStyle = 1;
					name = "Icicle";
					shootSpeed = 9f;
					shoot = 445;
					damage = 11;
					width = 20;
					height = 20;
					maxStack = 999;
					consumable = true;
					UseSound = SoundID.Item1;
					useAnimation = 15;
					useTime = 15;
					noUseGraphic = true;
					noMelee = true;
					value = 0;
					knockBack = 3f;
					ranged = true;
					break;

				case 2870:
					mana = 16;
					damage = 61;
					useStyle = 5;
					name = "Devil's Scythe";
					shootSpeed = 0.2f;
					shoot = 446;
					width = 26;
					height = 28;
					UseSound = SoundID.Item8;
					autoReuse = true;
					useAnimation = 20;
					useTime = 20;
					rare = 5;
					noMelee = true;
					knockBack = 4.75f;
					scale = 0.9f;
					toolTip = "Casts a hellfire scythe";
					value = 40000;
					magic = true;
					break;

				case 2871:
					name = "Heaven's Tear";
					noMelee = true;
					useStyle = 5;
					useAnimation = 45;
					useTime = 45;
					knockBack = 8f;
					width = 30;
					height = 10;
					damage = 54;
					scale = 1.1f;
					noUseGraphic = true;
					shoot = 447;
					shootSpeed = 12f;
					toolTip = "'Heaven splits with each swing'";
					UseSound = SoundID.Item1;
					rare = 5;
					value = 54000;
					melee = true;
					channel = true;
					break;

				case 2872:
					mana = 20;
					damage = 28;
					useStyle = 1;
					name = "Hallowed Thorn";
					shootSpeed = 32f;
					shoot = 448;
					width = 26;
					height = 28;
					UseSound = SoundID.Item8;
					useAnimation = 28;
					useTime = 28;
					rare = 5;
					noMelee = true;
					knockBack = 2f;
					toolTip = "Summons a splitting, hallow thorn";
					value = 20000;
					magic = true;
					break;

				case 2873:
					name = "Vision Potion";
					width = 10;
					height = 26;
					buffTime = 10800;
					buffType = 147;
					value = 2000;
					useAnimation = 15;
					useTime = 15;
					UseSound = SoundID.Item3;
					useStyle = 2;
					consumable = true;
					rare = 2;
					maxStack = 30;
					toolTip = "Open caves light up";
					break;

				case 2874:
					rare = 4;
					UseSound = SoundID.Item1;
					name = "Fiery Blade of Grass";
					useStyle = 1;
					damage = 33;
					useTurn = true;
					useAnimation = 23;
					useTime = 23;
					width = 50;
					height = 54;
					scale = 1f;
					knockBack = 3.5f;
					melee = true;
					value = Item.sellPrice(0, 0, 54, 0);
					break;

				case 2875:
					name = "Moonfury";
					noMelee = true;
					useStyle = 5;
					useAnimation = 42;
					useTime = 42;
					knockBack = 6.75f;
					width = 30;
					height = 10;
					damage = 44;
					scale = 1.1f;
					noUseGraphic = true;
					shoot = 450;
					shootSpeed = 12f;
					UseSound = SoundID.Item1;
					rare = 3;
					value = 54000;
					melee = true;
					channel = true;
					break;

				case 2876:
					name = "Sporalash";
					noMelee = true;
					useStyle = 5;
					useAnimation = 46;
					useTime = 46;
					knockBack = 6.75f;
					width = 30;
					height = 10;
					damage = 33;
					scale = 1.1f;
					noUseGraphic = true;
					shoot = 451;
					shootSpeed = 10f;
					toolTip = "Has a chance to inflict Poison";
					UseSound = SoundID.Item1;
					rare = 3;
					value = 27000;
					melee = true;
					channel = true;
					break;

				case 2877:
					name = "Lifestone";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = true;
					useTurn = true;
					autoReuse = true;
					createTile = 347;
					maxStack = 999;
					width = 16;
					height = 16;
					value = Item.sellPrice(0, 0, 1, 50);
					rare = 4;
					break;

				case 2878:
					name = "Poison Spike";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = true;
					useTurn = true;
					autoReuse = true;
					createTile = 348;
					maxStack = 999;
					width = 12;
					height = 12;
					value = 0;
					rare = 2;
					break;

				case 2879:
					name = "Music Box Essence";
					width = 30;
					height = 30;
					value = Item.sellPrice(0, 5, 0, 0);
					rare = 4;
					break;

				case 2880:
					name = "Venoshock";
					width = 32;
					height = 34;
					toolTip = "Casts a beam from the player to the closest enemy";
					toolTip2 = "Beam locks on to enemy closest to cursor";
					rare = 6;
					shootSpeed = 0.4f;
					UseSound = SoundID.Item61;
					shoot = 453;
					value = 250000;
					crit = 3;
					damage = 46;
					magic = true;
					scale = 1f;
					knockBack = 5f;
					channel = true;
					useAnimation = 30;
					useTime = 30;
					useStyle = 5;
					noMelee = true;
					mana = 10;
					break;

				case 2881:
					name = "The Beak";
					width = 20;
					height = 20;
					consumable = true;
					useAnimation = 40;
					toolTip = "Summons Desert Beak";
					useTime = 40;
					maxStack = 20;
					useStyle = 4;
					break;

				case 2882:
					mana = 17;
					channel = true;
					damage = 40;
					useStyle = 1;
					name = "Cursed Flamelash";
					shootSpeed = 6f;
					shoot = 454;
					width = 26;
					height = 28;
					UseSound = SoundID.Item20;
					useAnimation = 23;
					useTime = 23;
					rare = 5;
					noMelee = true;
					knockBack = 4f;
					toolTip = "Summons a controllable ball of cursed fire";
					value = 250000;
					magic = true;
					break;

				case 2883:
					name = "Desert Beak Trophy";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 240;
					width = 30;
					height = 30;
					value = Item.sellPrice(0, 1, 0, 0);
					placeStyle = 56;
					rare = 1;
					break;

				case 2884:
					name = "Caesium Ore";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = true;
					useTurn = true;
					autoReuse = true;
					createTile = 349;
					maxStack = 999;
					width = 12;
					height = 12;
					value = Item.sellPrice(0, 0, 21, 0);
					rare = 7;
					break;

				case 2885:
					name = "Caesium Bar";
					width = 20;
					height = 20;
					value = Item.sellPrice(0, 1, 5, 0);
					rare = 7;
					maxStack = 999;
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					consumable = true;
					createTile = 239;
					placeStyle = 21;
					break;

				case 2886:
					name = "Caesium Galea";
					width = 26;
					height = 24;
					defense = 31;
					headSlot = 170;
					rare = 7;
					value = Item.sellPrice(0, 10, 0, 0);
					toolTip = "8% increased melee damage";
					break;

				case 2887:
					name = "Caesium Plate Mail";
					width = 26;
					height = 24;
					defense = 25;
					bodySlot = 176;
					rare = 7;
					value = Item.sellPrice(0, 9, 0, 0);
					toolTip = "5% increased melee critical strike chance";
					toolTip2 = "Melee attacks inflict On Fire!";
					break;

				case 2888:
					name = "Caesium Greaves";
					width = 22;
					height = 18;
					defense = 21;
					legSlot = 111;
					rare = 7;
					value = Item.sellPrice(0, 8, 0, 0);
					toolTip = "15% increased melee and movement speed";
					break;

				case 2889:
					name = "Shell Statue";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 105;
					width = 20;
					height = 20;
					value = 300;
					placeStyle = 51;
					break;

				case 2900:
					name = "Bag of Blood";
					width = 24;
					height = 28;
					accessory = true;
					vanity = true;
					toolTip = "Blood particles cover you when you move";
					rare = 2;
					worksInVanity = true;
					value = Item.sellPrice(0, 1, 0, 0);
					break;

				case 2901:
					name = "Earth Stone";
					width = height = 26;
					toolTip = "'The essence of the golem'";
					rare = 8;
					maxStack = 999;
					value = Item.sellPrice(0, 0, 75, 0);
					break;

				case 2902:
					name = "Element Shard";
					width = 14;
					height = 20;
					toolTip = "'A fragment of the elements'";
					rare = 8;
					maxStack = 999;
					value = 3000;
					break;

				case 2903:
					name = "Elemental Rod";
					width = height = 38;
					rare = 8;
					value = Item.sellPrice(0, 40, 0, 0);
					useAnimation = 23;
					useTime = 23;
					channel = true;
					mana = 19;
					useStyle = 1;
					shoot = 455;
					shootSpeed = 9f;
					toolTip = "Will inflict debuffs";
					UseSound = SoundID.Item20;
					crit = 16;
					damage = 45;
					knockBack = 4f;
					noMelee = true;
					magic = true;
					break;

				case 2904:
					name = "DNA Statue";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 105;
					width = 20;
					height = 20;
					value = 300;
					placeStyle = 52;
					break;

				case 2905:
					name = "Dark Matter Chunk";
					useStyle = 4;
					useTime = 45;
					useAnimation = 45;
					value = 0;
					height = 18;
					width = 24;
					toolTip = "Summons the Armageddon Slime";
					rare = 5;
					consumable = true;
					maxStack = 20;
					break;

				case 2906:
					name = "Dark Matter Gel";
					width = 16;
					height = 14;
					maxStack = 999;
					rare = 0;
					scale = 1;
					value = 20;
					break;

				case 2907:
					name = "Oblivion Ore";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = true;
					useTurn = true;
					autoReuse = true;
					createTile = 350;
					maxStack = 999;
					width = 12;
					height = 12;
					value = Item.sellPrice(0, 0, 24, 0);
					rare = 9;
					break;

				case 2908:
					name = "Oblivion Bar";
					width = 20;
					height = 20;
					value = Item.sellPrice(0, 1, 25, 0);
					rare = 9;
					maxStack = 999;
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					consumable = true;
					createTile = 239;
					placeStyle = 22;
					break;

				case 2909:
					name = "Opal";
					width = 12;
					height = 12;
					value = Item.sellPrice(0, 1, 0, 0);
					rare = 12;
					maxStack = 999;
					createTile = 178;
					placeStyle = 7;
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					consumable = true;
					break;

				case 2910:
					name = "Soul of Blight";
					width = 22;
					height = 22;
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createTile = 368;
					noUseGraphic = true;
					value = 80000;
					rare = 8;
					toolTip = "'The essence of death'";
					break;

				case 2911:
					name = "Berserker Headpiece";
					width = 28;
					height = 26;
					defense = 36; // 45;
					value = Item.sellPrice(0, 55, 0, 0);
					toolTip = "32% increased melee damage and 20% increased melee speed";
					toolTip2 = "5% decreased melee critical strike chance";
					headSlot = 172;
					rare = 10;
					break;

				case 2912:
					name = "Berserker Bodyarmor";
					width = 38;
					height = 20;
					defense = 42; // 45;
					value = Item.sellPrice(0, 60, 0, 0);
					toolTip = "Enemies are more likely to target you";
					toolTip2 = "Attackers also take full damage";
					bodySlot = 178;
					rare = 10;
					break;

				case 2913:
					name = "Berserker Cuisses";
					width = 22;
					height = 18;
					defense = 32; // 40;
					value = Item.sellPrice(0, 65, 0, 0);
					toolTip = "Melee stealth when standing still";
					toolTip2 = "Lightning strikes when damaged";
					legSlot = 113;
					rare = 10;
					break;

				case 2914:
					name = "Illegal Weapon Instructions";
					width = 28;
					height = 32;
					toolTip = "'Read if you dare'";
					value = 50;
					rare = 1;
					maxStack = 99;
					break;

				case 2915:
					name = "Soul of Humidity";
					width = 22;
					height = 22;
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createTile = 369;
					noUseGraphic = true;
					value = 70000;
					rare = 9;
					toolTip = "'The essence of moist creatures'";
					break;

				case 2916:
					name = "Awakened Rose Crown";
					width = 28;
					height = 26;
					defense = 25;
					value = Item.sellPrice(0, 40, 0, 0);
					toolTip = "20% increased magic damage";
					toolTip2 = "5% increased magic critical strike chance";
					headSlot = 173;
					rare = 10;
					break;

				case 2917:
					name = "Awakened Rose Plate Mail";
					width = 38;
					height = 20;
					defense = 21;
					value = Item.sellPrice(0, 40, 0, 0);
					toolTip = "Spectre Heal and Spectre Damage";
					bodySlot = 179;
					rare = 10;
					break;

				case 2918:
					name = "Awakened Rose Subligar";
					width = 22;
					height = 18;
					defense = 20;
					value = Item.sellPrice(0, 40, 0, 0);
					toolTip = "10% increased movement speed";
					toolTip2 = "10% decreased mana cost";
					legSlot = 114;
					rare = 10;
					break;

				case 2919:
					name = "Spectrum Helmet";
					width = 32;
					height = 26;
					defense = 32;
					value = Item.sellPrice(0, 40, 0, 0);
					toolTip = "20% increased ranged damage";
					toolTip2 = "3% increased ranged critical strike chance";
					headSlot = 174;
					rare = 10;
					break;

				case 2920:
					name = "Spectrum Breastplate";
					width = 38;
					height = 20;
					defense = 33;
					value = Item.sellPrice(0, 40, 0, 0);
					toolTip = "Stand still to activate stealth mode";
					bodySlot = 180;
					rare = 10;
					break;

				case 2921:
					name = "Spectrum Greaves";
					width = 22;
					height = 18;
					defense = 25;
					value = Item.sellPrice(0, 40, 0, 0);
					toolTip = "20% chance to not consume ammo";
					toolTip2 = "10% increased movement speed";
					legSlot = 115;
					rare = 10;
					break;

				case 2922:
					name = "Caesium Forge";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 352;
					width = 44;
					height = 30;
					value = 50000;
					toolTip = "Used to smelt high-end ore";
					rare = 5;
					break;

				case 2923:
					name = "Hydrolyth Ore";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = true;
					useTurn = true;
					autoReuse = true;
					createTile = 353;
					maxStack = 999;
					width = 12;
					height = 12;
					value = Item.sellPrice(0, 0, 15, 0);
					rare = 8;
					break;

				case 2924:
					name = "Hydrolyth Bar";
					width = 20;
					height = 20;
					value = Item.sellPrice(0, 1, 5, 0);
					rare = 8;
					maxStack = 999;
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					consumable = true;
					createTile = 239;
					placeStyle = 23;
					break;

				case 2931:
					name = "Armageddon Slime Trophy";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 240;
					width = 30;
					height = 30;
					value = Item.sellPrice(0, 1, 0, 0);
					placeStyle = 57;
					rare = 1;
					break;

				case 2940:
					name = "Milotic Crown";
					width = 32;
					height = 26;
					defense = 29;
					value = Item.sellPrice(0, 40, 0, 0);
					toolTip = "20% increased minion damage";
					toolTip2 = "Increases your max number of minions by 1";
					headSlot = 175;
					rare = 10;
					break;

				case 2941:
					name = "Milotic Skinplate";
					width = 38;
					height = 20;
					defense = 30;
					value = Item.sellPrice(0, 40, 0, 0);
					toolTip = "30% increased minion knockback";
					toolTip2 = "Increases your max number of minions by 2";
					bodySlot = 181;
					rare = 10;
					break;

				case 2942:
					name = "Milotic Jodpurs";
					width = 22;
					height = 18;
					defense = 28;
					value = Item.sellPrice(0, 40, 0, 0);
					toolTip = "Increases your max number of minions by 1";
					toolTip2 = "10% increased movement speed";
					legSlot = 116;
					rare = 10;
					break;

				case 2943:
					name = "Explosives Toggle";
					width = 20;
					height = 20;
					shoot = 599;
					useTime = 30;
					useAnimation = 15;
					UseSound = SoundID.Item1;
					useStyle = 1;
					maxStack = 1;
					rare = 8;
					toolTip = "Toggles explosives allowed";
					break;

				case 2944:
					name = "Blah's Helmet";
					width = 32;
					height = 26;
					defense = 50;
					value = Item.sellPrice(1, 0, 0, 0);
					toolTip = "29% increased damage";
					toolTip2 = "10% increased critical strike chance";
					headSlot = 176;
					rare = 10;
					break;

				case 2945:
					name = "Blah's Bodyarmor";
					width = 38;
					height = 20;
					defense = 50;
					value = Item.sellPrice(1, 0, 0, 0);
					toolTip = "30% decreased mana usage and increases your max number of minions by 6";
					toolTip2 = "Increases maximum mana by 500";
					bodySlot = 182;
					rare = 10;
					break;

				case 2946:
					name = "Blah's Cuisses";
					width = 22;
					height = 18;
					defense = 50;
					value = Item.sellPrice(1, 0, 0, 0);
					toolTip = "Melee weapons have a chance to instantly kill mobs | Teleportation to the";
					toolTip2 = "Ranged projectiles have a chance to split in two | cursor is enabled";
					legSlot = 117;
					rare = 10;
					break;

				case 2947:
					name = "Blah's Wings";
					width = 32;
					height = 28;
					rare = 10;
					defense = 4;
					wingSlot = 28;
					value = Item.sellPrice(2, 0, 0, 0);
					accessory = true;
					toolTip = "Allows flight and slow fall and the wearer can run incredibly fast";
					toolTip2 = "The wearer has a chance to dodge attacks and negates fall damage";
					break;

				case 2948: {
						name = "Onyx";
						width = 10;
						height = 14;
						value = 30000;
						maxStack = 999;
						rare = 8;
						createTile = 178;
						placeStyle = 8;
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						consumable = true;
						break;
					}

				case 2949:
					name = "Golden Shield";
					width = 16;
					height = 24;
					accessory = true;
					rare = 4;
					toolTip = "Immunity to Ichor";
					value = 100000;
					break;

				case 2950:
					name = "Oxygen Tank";
					width = 30;
					height = 30;
					accessory = true;
					rare = 4;
					toolTip = "Immunity to Suffocation";
					value = 100000;
					break;

				case 2951:
					name = "Vortex";
					width = 16;
					height = 24;
					accessory = true;
					rare = 4;
					toolTip = "Immunity to On Fire!";
					value = 100000;
					break;

				case 2952:
					name = "Fight of the Bumblebee";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 242;
					toolTip = "'Dan D. Lyon'";
					width = 30;
					height = 30;
					value = Item.sellPrice(0, 0, 10, 0);
					placeStyle = 34;
					break;

				case 2953:
					name = "Desert Helmet";
					width = 20;
					height = 28;
					defense = 7;
					headSlot = 177;
					rare = 2;
					value = Item.sellPrice(0, 1, 0, 0);
					toolTip = "5% decreased mana usage";
					toolTip2 = "5% increased ranged damage";
					break;

				case 2954:
					name = "Desert Chainmail";
					width = 26;
					height = 22;
					defense = 8;
					bodySlot = 183;
					rare = 2;
					value = Item.sellPrice(0, 1, 0, 0);
					toolTip = "5% decreased mana usage";
					toolTip2 = "Increases maximum mana by 20";
					break;

				case 2955:
					name = "Desert Greaves";
					width = 22;
					height = 18;
					defense = 7;
					legSlot = 118;
					rare = 2;
					value = Item.sellPrice(0, 1, 0, 0);
					toolTip = "5% increased melee damage";
					break;

				case 2956:
					name = "Rhodium Ore";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = true;
					useTurn = true;
					autoReuse = true;
					createTile = 355;
					maxStack = 999;
					width = 12;
					height = 12;
					value = Item.sellPrice(0, 0, 7, 0);
					rare = 3;
					break;

				case 2957:
					name = "Rhodium Bar";
					width = height = 20;
					value = Item.sellPrice(0, 0, 28, 0);
					rare = 3;
					maxStack = 999;
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					consumable = true;
					createTile = 239;
					placeStyle = 24;
					break;

				case 2958:
					name = "Rhodium Pickaxe";
					width = height = 34;
					autoReuse = melee = useTurn = true;
					pick = 80;
					useAnimation = 15;
					useTime = 13;
					UseSound = SoundID.Item1;
					toolTip = "Can mine Hellstone";
					value = 50000;
					rare = 3;
					crit = 5;
					damage = 11;
					knockBack = 2f;
					break;

				case 2959:
					name = "Rhodium Greatsword";
					width = height = 44;
					autoReuse = melee = useTurn = true;
					useAnimation = 20;
					useTime = 25;
					scale = 1.5f;
					UseSound = SoundID.Item1;
					value = 50000;
					crit = 5;
					rare = 3;
					damage = 25;
					knockBack = 5f;
					break;

				case 2960:
					name = "Rhodium Hamaxe";
					width = height = 32;
					autoReuse = melee = useTurn = true;
					axe = 18;
					hammer = 60;
					useAnimation = 20;
					useTime = 25;
					scale = 1.3f;
					UseSound = SoundID.Item1;
					value = 50000;
					rare = 3;
					crit = 5;
					damage = 17;
					knockBack = 2f;
					break;

				case 2961:
					name = "Rhodium Headgear";
					width = 20;
					height = 28;
					defense = 8;
					headSlot = 178;
					rare = 3;
					value = Item.sellPrice(0, 1, 0, 0);
					toolTip = "10% increased ranged damage";
					toolTip2 = "Increases maximum mana by 20";
					break;

				case 2962:
					name = "Rhodium Plate Mail";
					width = 26;
					height = 22;
					defense = 9;
					bodySlot = 184;
					rare = 3;
					value = Item.sellPrice(0, 1, 0, 0);
					toolTip = "10% increased melee damage and speed";
					break;

				case 2963:
					name = "Rhodium Greaves";
					width = 22;
					height = 18;
					defense = 8;
					legSlot = 119;
					rare = 3;
					value = Item.sellPrice(0, 1, 0, 0);
					toolTip = "10% increased magic damage";
					break;

				case 2964:
					name = "Desert Feather";
					width = height = 14;
					value = Item.sellPrice(0, 0, 1, 0);
					rare = 2;
					maxStack = 999;
					break;

				case 2965:
					name = "Empty Xeradon Bucket";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					width = 20;
					height = 20;
					maxStack = 99;
					autoReuse = true;
					break;

				case 2966:
					name = "Water Xeradon Bucket";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					width = 20;
					height = 20;
					maxStack = 99;
					autoReuse = true;
					break;

				case 2967:
					name = "Lava Xeradon Bucket";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					width = 20;
					height = 20;
					maxStack = 99;
					autoReuse = true;
					break;

				case 2968:
					name = "Honey Xeradon Bucket";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					width = 20;
					height = 20;
					maxStack = 99;
					autoReuse = true;
					break;

				case 2969:
					useStyle = 1;
					name = "Sticky Dynamite";
					shootSpeed = 4f;
					shoot = 458;
					width = 8;
					height = 28;
					maxStack = 100;
					consumable = true;
					UseSound = SoundID.Item1;
					useAnimation = 40;
					useTime = 40;
					noUseGraphic = true;
					noMelee = true;
					value = Item.sellPrice(0, 0, 35, 0);
					rare = 2;
					toolTip = "A large explosion that will destroy most tiles";
					toolTip2 = "'Tossing may be difficult.'";
					break;

				case 2970:
					rare = 5;
					UseSound = SoundID.Item1;
					name = "Caesium Spatha";
					useStyle = 1;
					damage = 58;
					useTurn = true;
					useAnimation = 16;
					//autoReuse = true;
					useTime = 16;
					width = 48;
					height = 56;
					scale = 1.1f;
					knockBack = 5f;
					melee = true;
					value = Item.sellPrice(0, 5, 0, 0);
					break;

				case 2971:
					useStyle = 5;
					autoReuse = true;
					useAnimation = 20;
					useTime = 20;
					name = "Caesium Crossbow";
					width = 52;
					height = 20;
					shoot = 1;
					useAmmo = 1;
					UseSound = SoundID.Item5;
					damage = 53;
					shootSpeed = 9.5f;
					noMelee = true;
					value = 75000;
					ranged = true;
					rare = 5;
					knockBack = 2.75f;
					break;

				case 2972:
					name = "Bottled Lava";
					toolTip = "'Drinking may be fatal'";
					maxStack = 100;
					width = 14;
					height = 24;
					value = 50;
					break;

				case 2973:
					name = "Bloodshot Lens";
					maxStack = 999;
					width = 16;
					height = 22;
					value = Item.sellPrice(0, 0, 20, 0);
					break;

				case 2974:
					name = "Berserker Arrow";
					width = 10;
					height = 20;
					value = Item.sellPrice(0, 0, 2, 0);
					maxStack = 2000;
					damage = 19;
					rare = 9;
					shootSpeed = 4f;
					shoot = 459;
					consumable = true;
					ranged = true;
					ammo = 1;
					knockBack = 4f;
					break;

				case 2975:
					name = "Possessed Armor Helmet";
					width = 20;
					height = 28;
					headSlot = 179;
					vanity = true;
					rare = 4;
					value = Item.sellPrice(0, 0, 20, 0);
					break;

				case 2976:
					name = "Possessed Armor Chainmail";
					width = 26;
					height = 22;
					bodySlot = 185;
					vanity = true;
					rare = 4;
					value = Item.sellPrice(0, 0, 20, 0);
					break;

				case 2977:
					name = "Possessed Armor Greaves";
					width = 22;
					height = 18;
					legSlot = 120;
					vanity = true;
					rare = 4;
					value = Item.sellPrice(0, 0, 20, 0);
					break;

				case 2978:
					name = "Aegis of Ages";
					width = 38;
					height = 42;
					rare = 10;
					value = Item.sellPrice(0, 25, 0, 0);
					accessory = true;
					shieldSlot = 7;
					toolTip = "+20 defense, +5 life regeneration, +20% damage";
					toolTip2 = "Effects are only active when below 33% life";
					break;

				case 2979:
					name = "Titan Shield";
					width = 38;
					height = 42;
					rare = 10;
					defense = 12;
					shieldSlot = 8;
					value = Item.sellPrice(0, 50, 0, 0);
					accessory = true;
					toolTip = "+15 defense, +3 life regeneration, +15% damage | Absorbs 25% of damage done to players on";
					toolTip2 = "Effects are only active when below 33% health  | your team (only active above 25% life)";
					break;

				case 2980:
					name = "Guardian Hammer";
					width = height = 32;
					damage = 200;
					UseSound = SoundID.Item1;
					rare = 9;
					value = Item.sellPrice(0, 25, 0, 0);
					melee = noUseGraphic = noMelee = true;
					shoot = 544;
					shootSpeed = 16f;
					useAnimation = 32;
					useTime = 32;
					useStyle = 5;
					knockBack = 10f;
					break;

				case 2981:
					name = "Bloodberry";
					maxStack = 999;
					width = 12;
					height = 14;
					value = 100;
					break;

				case 2982:
					name = "Bloodberry Seeds";
					useTurn = true;
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					maxStack = 999;
					consumable = true;
					createTile = 82;
					placeStyle = 7;
					width = 12;
					height = 14;
					value = 90;
					break;

				case 2983:
					name = "Elemental Arrow";
					width = 10;
					height = 20;
					value = Item.sellPrice(0, 0, 3, 0);
					maxStack = 2000;
					damage = 17;
					rare = 8;
					shootSpeed = 3.5f;
					shoot = 463;
					consumable = true;
					ranged = true;
					ammo = 1;
					knockBack = 5f;
					break;

				case 2984:
					name = "Flare Stone";
					width = 38;
					height = 38;
					rare = 7;
					value = Item.sellPrice(0, 3, 50, 0);
					accessory = true;
					toolTip = "Damage taken from lava contact is reduced";
					toolTip2 = "Weapons inflict fire damage and provides immunity to fire blocks";
					break;

				case 2985:
					name = "Slime Talisman";
					width = 38;
					height = 38;
					rare = 3;
					value = Item.sellPrice(0, 1, 0, 0);
					accessory = true;
					toolTip = "Provides immunity to slimes";
					break;

				case 2986:
					name = "Tome of the Distant Past";
					width = 28;
					height = 30;
					useStyle = 5;
					useAnimation = useTime = 15;
					damage = 30;
					autoReuse = magic = noMelee = true;
					shootSpeed = 7f;
					crit = -1;
					mana = 6;
					value = 27000;
					rare = 2;
					shoot = 464;
					knockBack = 4f;
					UseSound = SoundID.Item1;
					toolTip = "Summons a bone barrage";
					break;

				case 2987:
					name = "Rotten Eye";
					width = height = 18;
					value = 90;
					toolTip = "'Looks nasty!'";
					maxStack = 999;
					break;

				case 2988:
					name = "Rotten Bullet";
					width = 10;
					height = 10;
					damage = 15;
					ranged = true;
					shootSpeed = 1.5f;
					value = 10;
					rare = 3;
					shoot = 465;
					ammo = 14;
					maxStack = 2000;
					consumable = true;
					knockBack = 16f;
					toolTip = "Slow speed, low range, but high damage and knockback";
					break;

				case 2989:
					name = "Shurikerang";
					width = 34;
					height = 34;
					damage = 18;
					maxStack = 10;
					noMelee = true;
					noUseGraphic = true;
					crit = 3;
					useStyle = 1;
					useAnimation = useTime = 12;
					scale = 1.2f;
					UseSound = SoundID.Item1;
					ranged = true;
					shootSpeed = 12f;
					value = 30000;
					rare = 3;
					shoot = 466;
					knockBack = 3f;
					break;

				case 2990:
					name = "Strength Potion";
					width = 10;
					height = 26;
					buffTime = 3600 * 9;
					buffType = 150;
					value = 2000;
					useAnimation = 15;
					useTime = 15;
					UseSound = SoundID.Item3;
					useStyle = 2;
					consumable = true;
					rare = 3;
					maxStack = 100;
					toolTip = "Increases all stats";
					break;

				case 2991:
					name = "Acceleration Drill";
					useStyle = 5;
					useAnimation = 9;
					useTime = 7;
					knockBack = 1f;
					autoReuse = true;
					width = 76;
					channel = true;
					height = 26;
					damage = 25;
					//axe = 36;
					pick = 400;
					shoot = 467;
					shootSpeed = 32f;
					UseSound = SoundID.Item23;
					rare = 10;
					value = 1016000;
					melee = true;
					scale = 1f;
					noMelee = true;
					noUseGraphic = true;
					tileBoost += 6;
					// TODO: toolTip = "Press " + Main.cMode + " to change mining modes";
					break;

				case 2992:
					name = "GPS Potion";
					width = 10;
					height = 26;
					buffTime = 3600 * 5;
					buffType = 151;
					value = 2000;
					useAnimation = 15;
					useTime = 15;
					UseSound = SoundID.Item3;
					useStyle = 2;
					consumable = true;
					rare = 1;
					maxStack = 100;
					toolTip = "GPS Effect";
					break;

				case 2993:
					name = "Dragon Spine";
					useStyle = 4;
					useTime = 45;
					useAnimation = 45;
					value = 0;
					height = 18;
					width = 24;
					toolTip = "Summons the Dragon Lord";
					rare = 6;
					consumable = true;
					maxStack = 20;
					break;

				case 2994:
					name = "Dragon Scale";
					useTurn = true;
					useStyle = 1;
					autoReuse = true;
					useAnimation = 15;
					useTime = 10;
					consumable = true;
					createTile = 358;
					width = 14;
					height = 18;
					maxStack = 999;
					rare = 3;
					value = 1000;
					break;

				case 2995:
					name = "Diving Suit";
					width = 26;
					height = 22;
					defense = 4;
					bodySlot = 186;
					rare = 2;
					value = Item.sellPrice(0, 0, 20, 0);
					toolTip = "Greatly extends underwater breathing";
					toolTip2 = "10% increased damage while in water";
					break;

				case 2996:
					name = "Diving Pants";
					width = 22;
					height = 18;
					defense = 3;
					legSlot = 121;
					rare = 2;
					value = Item.sellPrice(0, 0, 20, 0);
					toolTip = "Greatly extends underwater breathing";
					toolTip2 = "10% increased damage while in water";
					break;

				case 2997:
					name = "Null Emblem";
					width = 38;
					height = 38;
					rare = 3;
					maxStack = 999;
					value = Item.sellPrice(0, 1, 0, 0);
					toolTip = "Craft it into a Wall of Flesh Emblem";
					break;

				case 2998:
					name = "Oblivion Brick";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = true;
					useTurn = true;
					autoReuse = true;
					createTile = 359;
					maxStack = 999;
					width = 12;
					height = 12;
					value = 0;
					rare = 7;
					break;

				case 2999:
					name = "Oblivion Glaive";
					useStyle = 5;
					useAnimation = 20;
					useTime = 20;
					shootSpeed = 5.6f;
					knockBack = 6.5f;
					width = 60;
					height = 60;
					damage = 120;
					scale = 1f;
					rare = 9;
					autoReuse = true;
					reuseDelay = 10;
					UseSound = SoundID.Item1;
					shoot = 468;
					value = Item.sellPrice(0, 20, 0, 0);
					noMelee = noUseGraphic = melee = true;
					break;

				case 3000:
					name = "Victory Piece";
					width = 36;
					height = 20;
					maxStack = 100;
					rare = 9;
					value = Item.sellPrice(0, 10, 0, 0);
					toolTip = "Victory is yours!";
					break;

				case 3001:
					name = "Crystal Fruit";
					maxStack = 999;
					consumable = true;
					width = 18;
					height = 18;
					useStyle = 4;
					useTime = 30;
					UseSound = SoundID.Item4;
					useAnimation = 30;
					toolTip = "Permanently increases maximum life by 25";
					toolTip2 = "Can only be used when you have 500 or more life";
					rare = 9;
					value = Item.sellPrice(0, 3, 0, 0);
					break;

				case 3002:
					name = "Eye of Oblivion";
					useStyle = 4;
					useTime = 45;
					useAnimation = 45;
					value = 0;
					height = 18;
					width = 24;
					toolTip = "Summons Oblivion";
					toolTip2 = "Use with care";
					rare = 8;
					consumable = true;
					maxStack = 20;
					break;

				case 3003:
					name = "Ice Sculpture";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 105;
					width = 20;
					height = 20;
					value = 500;
					placeStyle = 53;
					break;

				case 3004:
					name = "Orange Dungeon Vase";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 105;
					width = 20;
					height = 20;
					value = 300;
					placeStyle = 54;
					break;

				case 3005:
					name = "Soul of Torture";
					width = 22;
					height = 22;
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createTile = 370;
					noUseGraphic = true;
					value = 90000;
					rare = 10;
					toolTip = "'The essence of cruelty'";
					toolTip2 = "Increases critical strike chance if placed";
					break;

				case 3006:
					name = "Xeradon Anvil";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 360;
					width = 28;
					height = 14;
					value = 75000;
					toolTip = "Used to craft high-end items";
					rare = 7;
					break;

				case 3007:
					rare = 9;
					UseSound = SoundID.Item1;
					name = "Elemental Excalibur";
					useStyle = 1;
					damage = 120;
					useAnimation = 15;
					noMelee = false;
					useTime = 15;
					width = 30;
					height = 30;
					shoot = 469;
					scale = 1.1f;
					shootSpeed = 11f;
					knockBack = 8.5f;
					melee = true;
					value = Item.sellPrice(0, 90, 0, 0);
					autoReuse = true;
					break;

				case 3008:
					name = "The Golden Flames";
					width = 28;
					height = 30;
					useStyle = 5;
					channel = true;
					damage = 72;
					knockBack = 7f;
					UseSound = SoundID.Item20;
					shoot = 470;
					shootSpeed = 10f;
					crit = 11;
					value = 250000;
					magic = true;
					noMelee = true;
					rare = 7;
					toolTip = "'The flames are made of gold!'";
					useTime = 50;
					useAnimation = 50;
					mana = 14;
					break;

				case 3009:
					name = "Broken Vigilante Tome";
					width = 14;
					height = 18;
					maxStack = 99;
					rare = 8;
					value = Item.sellPrice(0, 2, 0, 0);
					break;

				case 3010:
					name = "Terraspin";
					width = 28;
					height = 30;
					useStyle = 5;
					channel = true;
					damage = 80;
					autoReuse = true;
					useTurn = true;
					knockBack = 7f;
					UseSound = SoundID.Item8;
					shoot = 472;
					shootSpeed = 9f;
					crit = 9;
					value = Item.sellPrice(0, 50, 0, 0);
					magic = true;
					noMelee = true;
					rare = 9;
					toolTip = "Fires a spread of typhoons";
					useTime = 25;
					useAnimation = 25;
					mana = 20;
					break;

				case 3011:
					name = "600 Watt Lightbulb";
					width = 28;
					height = 32;
					accessory = true;
					rare = 6;
					toolTip = "Immunity to Blackout";
					value = 100000;
					break;

				case 3012:
					name = "Greek Extinguisher";
					width = 28;
					height = 32;
					accessory = true;
					rare = 6;
					toolTip = "Immunity to Cursed Inferno";
					value = 100000;
					break;

				case 3013:
					name = "Nuclear Extinguisher";
					width = 28;
					height = 32;
					accessory = true;
					rare = 8;
					toolTip = "Immunity to Blackout and Cursed Inferno";
					value = 200000;
					break;

				case 3014:
					name = "Freezethrower";
					useStyle = 5;
					autoReuse = true;
					useAnimation = 30;
					useTime = 5;
					width = 50;
					height = 18;
					shoot = 473;
					useAmmo = 23;
					UseSound = SoundID.Item34;
					damage = 70;
					knockBack = 0.625f;
					shootSpeed = 8.5f;
					noMelee = true;
					value = 1000000;
					rare = 9;
					ranged = true;
					toolTip = "Uses gel for ammo";
					break;

				case 3015:
					name = "Hydrolyth Trace";
					useStyle = 4;
					useTime = 45;
					useAnimation = 45;
					value = 0;
					height = 18;
					width = 24;
					toolTip = "Calls forth a comet";
					rare = 8;
					consumable = true;
					maxStack = 999;
					break;

				case 3016:
					name = "Frosty Spectacle";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 242;
					toolTip = "'B. Harold'";
					width = 30;
					height = 30;
					rare = 1;
					value = Item.sellPrice(0, 0, 10, 0);
					placeStyle = 35;
					break;

				case 3017:
					name = "Bag of Frost";
					width = 24;
					height = 28;
					accessory = true;
					vanity = true;
					toolTip = "Frostburn particles cover you when you move";
					rare = 6;
					worksInVanity = true;
					value = Item.sellPrice(0, 1, 0, 0);
					break;

				case 3018:
					name = "Rock";
					width = 18;
					height = 18;
					maxStack = 999;
					value = 0;
					rare = 1;
					toolTip = "Used for crafting the Eye of Oblivion";
					break;

				case 3019:
					name = "Pointing Laser";
					width = 34;
					height = 34;
					maxStack = 999;
					value = 0;
					rare = 5;
					toolTip = "Used for crafting the Eye of Oblivion";
					break;

				case 3020:
					name = "Alien Device";
					width = 34;
					height = 34;
					maxStack = 999;
					value = 0;
					rare = 9;
					toolTip = "Used for crafting the Eye of Oblivion";
					break;

				case 3021:
					useStyle = 5;
					autoReuse = true;
					useAnimation = 15;
					useTime = 15;
					name = "Gleaming Twilight";
					width = 50;
					height = 30;
					shoot = 1;
					useAmmo = 1;
					UseSound = SoundID.Item5;
					damage = 90;
					shootSpeed = 11f;
					noMelee = true;
					value = 1000000;
					ranged = true;
					rare = 8;
					knockBack = 4.5f;
					break;

				case 3022:
					name = "Prime Staff";
					useStyle = 1;
					shootSpeed = 14f;
					shoot = 474;
					damage = 50;
					width = 38;
					height = 36;
					UseSound = SoundID.Item44;
					buffType = 152;
					useAnimation = 30;
					useTime = 30;
					noMelee = true;
					value = Item.sellPrice(0, 10, 0, 0);
					knockBack = 6.5f;
					toolTip = "Summons the might of Skeletron to fight for you";
					rare = 8;
					summon = true;
					mana = 14;
					break;

				case 3023:
					name = "Tungsten Bullet";
					shootSpeed = 3.25f;
					shoot = 14;
					damage = 12;
					width = 8;
					height = 8;
					maxStack = 2000;
					consumable = true;
					ammo = 14;
					knockBack = 3f;
					value = 15;
					ranged = true;
					break;

				case 3024:
					name = "Bloody Amulet";
					useStyle = 1;
					width = 22;
					height = 20;
					UseSound = SoundID.Item1;
					useAnimation = 40;
					useTime = 40;
					shoot = 495;
					rare = 8;
					maxStack = 999;
					consumable = true;
					toolTip = "Summons a Blood Moon";
					break;

				case 3025:
					name = "Time Shift Potion";
					width = 10;
					height = 26;
					buffTime = 32400;
					buffType = 153;
					value = 2000;
					useAnimation = 15;
					useTime = 15;
					UseSound = SoundID.Item3;
					useStyle = 2;
					consumable = true;
					rare = 4;
					maxStack = 100;
					toolTip = "Slows time down";
					break;

				case 3026:
					name = "Staff of the Tempest Frigid";
					useStyle = 1;
					shootSpeed = 14f;
					shoot = 478;
					damage = 152;
					width = 38;
					height = 36;
					UseSound = SoundID.Item44;
					buffType = 154;
					useAnimation = 30;
					useTime = 30;
					noMelee = true;
					value = Item.sellPrice(0, 30, 0, 0);
					knockBack = 8.5f;
					rare = 8;
					summon = true;
					mana = 30;
					break;

				case 3027:
					name = "Patella";
					width = height = 24;
					value = 90;
					maxStack = 999;
					break;

				case 3028:
					name = "Patella Bullet";
					width = 10;
					height = 10;
					damage = 15;
					ranged = true;
					shootSpeed = 1.5f;
					value = 10;
					rare = 3;
					shoot = 479;
					ammo = 14;
					maxStack = 2000;
					consumable = true;
					knockBack = 16f;
					toolTip = "Slow speed, low range, but high damage and knockback";
					break;

				case 3029:
					name = "Obsidian Lava Tube Wall";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 7;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createWall = 179;
					width = 12;
					height = 12;
					break;

				case 3030:
					name = "Rotten Flesh";
					width = height = 28;
					value = 10;
					maxStack = 999;
					break;

				case 3031:
					rare = 5;
					UseSound = SoundID.Item1;
					name = "Aeon's Eternity";
					useStyle = 1;
					damage = 36;
					useTurn = true;
					useAnimation = 20;
					autoReuse = true;
					shoot = 573;
					shootSpeed = 9f;
					useTime = 20;
					width = 44;
					height = 54;
					scale = 1.1f;
					knockBack = 5.5f;
					melee = true;
					value = Item.sellPrice(0, 1, 0, 0);
					break;

				case 3032:
					rare = 8;
					UseSound = SoundID.Item1;
					name = "True Aeon's Eternity";
					useStyle = 1;
					damage = 69;
					useTurn = true;
					useAnimation = 24;
					autoReuse = true;
					shoot = 480;
					shootSpeed = 8f;
					useTime = 24;
					width = 44;
					height = 54;
					scale = 1.1f;
					knockBack = 5f;
					melee = true;
					value = Item.sellPrice(0, 3, 0, 0);
					break;

				case 3033:
					name = "Giga Horn";
					width = 32;
					height = 34;
					useStyle = 5;
					useTurn = autoReuse = magic = noMelee = true;
					shoot = 481;
					mana = 60;
					value = Item.sellPrice(0, 9, 0, 0);
					knockBack = 4f;
					scale = 0.9f;
					damage = 45;
					reuseDelay = 14;
					useTime = useAnimation = 29;
					shootSpeed = 2f;
					crit = 3;
					rare = 8;
					UseSound = SoundID.Item57;
					toolTip = "Summons a powerful sonic blast";
					break;

				case 3034:
					name = "Hallowed Helmet";
					width = 18;
					height = 18;
					defense = 12;
					headSlot = 180;
					rare = 5;
					value = 250000;
					toolTip = "12% increased minion damage and knockback";
					toolTip2 = "Increases your max number of minions by 2";
					break;

				case 3042:
					name = "Berserker Nightmare";
					noMelee = noUseGraphic = melee = channel = autoReuse = true;
					useStyle = 5;
					useAnimation = useTime = 38;
					knockBack = shootSpeed = 10f;
					width = 30;
					height = 10;
					damage = 84;
					scale = 1.1f;
					shoot = 482;
					UseSound = SoundID.Item1;
					rare = 9;
					value = Item.sellPrice(0, 50, 0, 0);
					break;

				case 3043:
					name = "Lime Green Solution";
					shoot = 5;
					ammo = 780;
					width = 10;
					height = 12;
					value = Item.buyPrice(0, 0, 25, 0);
					rare = 3;
					maxStack = 999;
					toolTip = "Used by the Clentaminator";
					toolTip2 = "Spreads the Jungle";
					break;

				case 3044:
					name = "Green Ice Block";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createTile = 361;
					width = 12;
					height = 12;
					break;

				case 3060:
					name = "Creator's Tome";
					width = 20;
					height = 22;
					rare = 8;
					tome = true;
					toolTip = "+20% damage, +5% critical strike chance, -20% mana cost";
					toolTip2 = "25% chance to not consume ammo, 10 defense, +100 HP, +100 mana";
					value = 150000;
					break;

				case 3061:
					name = "Love Up and Down";
					width = 20;
					height = 22;
					rare = 7;
					tome = true;
					toolTip = "+15% damage, +7% critical strike chance, -25% mana cost";
					toolTip2 = "20% chance to not consume ammo, 7 defense, +80 HP, +80 mana";
					value = 150000;
					break;

				case 3062:
					name = "Christmas Tome";
					width = 20;
					height = 22;
					rare = 6;
					tome = true;
					toolTip = "+3% critical strike chance";
					value = 15000;
					break;

				case 3063:
					name = "The Voidlands";
					width = 20;
					height = 22;
					rare = 6;
					tome = true;
					toolTip = "+15% damage, +3% critical strike chance";
					toolTip2 = "+60 HP, +40 mana";
					value = 105000;
					break;

				case 3064:
					name = "Tale of the Red Lotus";
					width = 20;
					height = 22;
					rare = 4;
					tome = true;
					toolTip = "+5% ranged damage";
					toolTip2 = "+20 HP";
					value = 5000;
					break;

				case 3065:
					name = "Meditation's Flame";
					width = 20;
					height = 22;
					rare = 4;
					tome = true;
					toolTip = "+5% magic damage, -10% mana cost";
					toolTip2 = "+60 mana";
					value = 5000;
					break;

				case 3066:
					name = "Flanker's Tome";
					width = 20;
					height = 22;
					rare = 3;
					tome = true;
					toolTip = "+10% melee damage";
					value = 15000;
					break;

				case 3067:
					name = "Eternity's Moon";
					width = 20;
					height = 22;
					rare = 2;
					tome = true;
					toolTip = "+20 mana, -5% mana cost";
					value = 15000;
					break;

				case 3068:
					name = "Tale of the Dolt";
					width = 20;
					height = 22;
					rare = 5;
					tome = true;
					toolTip = "+15% melee damage";
					toolTip2 = "+20 HP, +20 mana";
					value = 15000;
					break;

				case 3069:
					name = "Tome of Distance";
					width = 20;
					height = 22;
					rare = 4;
					tome = true;
					toolTip = "+15% ranged damage, +40 HP, +20 mana";
					toolTip2 = "20% chance to not consume ammo";
					value = 15000;
					break;

				case 3070:
					name = "Misty Peach Blossoms";
					width = 20;
					height = 22;
					rare = 2;
					tome = true;
					toolTip = "+20 HP";
					toolTip2 = "+20 mana";
					value = 15000;
					break;

				case 3071:
					name = "Tome of the River Spirits";
					width = 20;
					height = 22;
					rare = 5;
					tome = true;
					toolTip = "+15% magic and minion damage";
					toolTip2 = "-5% mana cost";
					value = 15000;
					break;

				case 3072:
					name = "Adventures and Mishaps";
					width = 20;
					height = 22;
					rare = 7;
					tome = true;
					toolTip = "+60 HP, +5% damage";
					toolTip2 = "-10% mana cost";
					value = 20000;
					break;

				case 3073:
					name = "Underestimated Resolve";
					width = 20;
					height = 22;
					rare = 6;
					tome = true;
					toolTip = "+20 HP, +5% ranged damage";
					toolTip2 = "+4 defense";
					value = 20000;
					break;

				case 3074:
					name = "Burning Desire";
					width = 20;
					height = 22;
					rare = 3;
					tome = true;
					toolTip = "+40 HP";
					toolTip2 = "+40 mana";
					value = 15000;
					break;

				case 3075:
					name = "The Three Scholars";
					width = 20;
					height = 22;
					rare = 8;
					tome = true;
					toolTip = "+20 defense";
					value = 150000;
					break;

				case 3076:
					name = "Chant of the Water Dragon";
					width = 20;
					height = 22;
					rare = 8;
					tome = true;
					toolTip = "+20% magic damage";
					value = 150000;
					break;

				case 3077:
					name = "The Plum Harvest";
					width = 20;
					height = 22;
					rare = 8;
					tome = true;
					toolTip = "30% chance to not consume ammo";
					value = 150000;
					break;

				case 3078:
					name = "Dominance";
					width = 20;
					height = 22;
					rare = 9;
					tome = true;
					toolTip = "+22% damage, +8% critical strike chance, -10% mana cost";
					toolTip2 = "20% chance to not consume ammo, 11 defense, +140 mana, +80 HP";
					value = 250000;
					break;

				case 3079:
					name = "Emperor";
					width = 20;
					height = 22;
					rare = 9;
					tome = true;
					toolTip = "+25% damage, +12% critical strike chance, -20% mana cost";
					toolTip2 = "30% chance to not consume ammo, 14 defense, +200 mana, +100 HP";
					value = 250000;
					break;

				case 3080:
					name = "Onyx Hook";
					width = 26;
					height = 32;
					rare = 7;
					value = Item.sellPrice(0, 9, 0, 0);
					useAnimation = 20;
					useTime = 20;
					useStyle = 5;
					noMelee = true;
					UseSound = SoundID.Item1;
					noUseGraphic = true;
					shoot = 484;
					damage = 70;
					shootSpeed = 16f;
					useTurn = true;
					knockBack = 25f;
					break;

				case 3081:
					name = "Fleshy Tendril";
					width = height = 16;
					value = 50;
					maxStack = 999;
					break;

				case 3082:
					name = "Flesh Cap";
					width = 20;
					height = 28;
					headSlot = 181;
					toolTip = "10% increased minion damage";
					defense = 7;
					rare = 4;
					value = Item.sellPrice(0, 1, 0, 0);
					break;

				case 3083:
					name = "Flesh Wrappings";
					width = 26;
					height = 22;
					bodySlot = 187;
					toolTip = "9% increased minion knockback";
					toolTip2 = "10% increased movement speed";
					defense = 9;
					rare = 4;
					value = Item.sellPrice(0, 1, 20, 0);
					break;

				case 3084:
					name = "Flesh Pants";
					width = 22;
					height = 18;
					legSlot = 122;
					toolTip = "Increases your max number of minions by 2";
					defense = 7;
					rare = 4;
					value = Item.sellPrice(0, 1, 0, 0);
					break;

				case 3085:
					name = "Bloodstained Helmet";
					width = 20;
					height = 28;
					headSlot = 182;
					toolTip = "Shows the location of treasures and ores";
					toolTip2 = "Works in the vanity slot";
					defense = 3;
					rare = 2;
					worksInVanity = true;
					value = Item.sellPrice(0, 0, 90, 0);
					break;

				case 3086:
					name = "Hungry Staff";
					useStyle = 1;
					shootSpeed = 14f;
					shoot = 485;
					damage = 27;
					width = 38;
					height = 36;
					UseSound = SoundID.Item44;
					buffType = 155;
					useAnimation = 30;
					useTime = 30;
					noMelee = true;
					value = Item.sellPrice(0, 1, 0, 0);
					knockBack = 5.5f;
					rare = 4;
					summon = true;
					mana = 15;
					break;

				case 3087:
					name = "Opal Staff";
					mana = 14;
					UseSound = SoundID.Item43;
					useStyle = 5;
					damage = 90;
					useAnimation = 23;
					useTime = 23;
					width = 40;
					height = 40;
					shoot = 486;
					shootSpeed = 9.5f;
					knockBack = 7.5f;
					magic = true;
					autoReuse = true;
					value = 300000;
					rare = 8;
					noMelee = true;
					break;

				case 3088:
					name = "Onyx Staff";
					mana = 20;
					UseSound = SoundID.Item43;
					useStyle = 5;
					damage = 116;
					useAnimation = 19;
					useTime = 19;
					width = 40;
					height = 40;
					shoot = 487;
					shootSpeed = 9.5f;
					knockBack = 25.5f;
					magic = true;
					autoReuse = true;
					value = 350000;
					rare = 9;
					noMelee = true;
					break;

				case 3089:
					name = "Osmium Ore";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = true;
					useTurn = true;
					autoReuse = true;
					createTile = 371;
					maxStack = 999;
					width = 12;
					height = 12;
					value = Item.sellPrice(0, 0, 9, 0);
					rare = 3;
					break;

				case 3090:
					name = "Osmium Bar";
					width = height = 20;
					value = Item.sellPrice(0, 0, 36, 0);
					rare = 3;
					maxStack = 999;
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					consumable = true;
					createTile = 239;
					placeStyle = 25;
					break;

				case 3091:
					name = "Osmium Helmet";
					width = 20;
					height = 28;
					defense = 7;
					headSlot = 183;
					rare = 3;
					value = Item.sellPrice(0, 1, 20, 0);
					toolTip = "12% increased ranged damage";
					toolTip2 = "Increases maximum mana by 40";
					break;

				case 3092:
					name = "Osmium Jerkin";
					width = 26;
					height = 22;
					defense = 8;
					bodySlot = 188;
					rare = 3;
					value = Item.sellPrice(0, 1, 20, 0);
					toolTip = "12% increased melee damage and speed";
					break;

				case 3093:
					name = "Osmium Treads";
					width = 22;
					height = 18;
					defense = 7;
					legSlot = 123;
					rare = 3;
					value = Item.sellPrice(0, 1, 20, 0);
					toolTip = "12% increased magic damage";
					break;

				case 3094:
					name = "Osmium Pickaxe";
					width = height = 34;
					autoReuse = melee = useTurn = true;
					pick = 82;
					useAnimation = 13;
					useTime = 13;
					UseSound = SoundID.Item1;
					toolTip = "Can mine Hellstone";
					value = 50000;
					rare = 3;
					crit = 6;
					damage = 13;
					knockBack = 3f;
					break;

				case 3095:
					name = "Osmium Greatsword";
					width = height = 44;
					autoReuse = melee = useTurn = true;
					useAnimation = 20;
					useTime = 20;
					scale = 1.5f;
					UseSound = SoundID.Item1;
					value = 50000;
					crit = 5;
					rare = 3;
					damage = 28;
					knockBack = 5f;
					break;

				case 3096:
					name = "Demon Spikescale";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = true;
					useTurn = true;
					autoReuse = true;
					createTile = 372;
					maxStack = 999;
					ammo = 147;
					width = 12;
					height = 12;
					value = Item.sellPrice(0, 0, 1, 0);
					rare = 4;
					break;

				case 3097:
					name = "Bloodied Spike";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = true;
					useTurn = true;
					autoReuse = true;
					createTile = 374;
					maxStack = 999;
					ammo = 147;
					width = 12;
					height = 12;
					value = Item.sellPrice(0, 0, 1, 0);
					rare = 4;
					break;

				case 3098:
					autoReuse = true;
					useStyle = 1;
					name = "Knives of the Corruptor";
					shootSpeed = 15f;
					shoot = 488;
					damage = 45;
					width = 18;
					height = 20;
					UseSound = SoundID.Item39;
					useAnimation = 16;
					useTime = 16;
					noUseGraphic = true;
					noMelee = true;
					value = Item.sellPrice(0, 50, 0, 0);
					knockBack = 5.75f;
					melee = true;
					rare = 9;
					toolTip = "Rapidly throws daggers that explode into tiny eaters";
					break;

				case 3099:
					name = "The Heavenly Scent";
					width = 20;
					height = 22;
					rare = 7;
					tome = true;
					toolTip = "+2 life regen";
					value = 150000;
					break;

				case 3100:
					flame = true;
					name = "Jungle Torch";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					holdStyle = 1;
					ammo = 8;
					torch = 13;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createTile = 4;
					placeStyle = 13;
					width = 10;
					height = 12;
					rare = 3;
					value = Item.sellPrice(0, 0, 2, 0);
					break;

				case 3101:
					name = "Brimstone Block";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = true;
					useTurn = true;
					autoReuse = true;
					createTile = 375;
					maxStack = 999;
					width = 12;
					height = 12;
					value = 0;
					break;

				case 3102:
					name = "Underworld Key Mold";
					toolTip = "Used for crafting an Underworld Key";
					width = height = 30;
					maxStack = 999;
					rare = 11;
					break;

				case 3103:
					name = "Underworld Key";
					width = 14;
					height = 20;
					maxStack = 999;
					toolTip = "Unlocks an Underworld Chest in the dungeon";
					rare = 11;
					break;

				case 3104:
					name = "Underworld Chest";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 21;
					placeStyle = 48;
					width = 26;
					height = 22;
					value = 10000;
					break;

				case 3105:
					name = "Hellrazer";
					width = 52;
					height = 22;
					damage = 100;
					knockBack = 12f;
					useAnimation = 30;
					useTime = 30;
					rare = 11;
					value = Item.sellPrice(0, 30, 0, 0);
					useStyle = 5;
					UseSound = SoundID.Item40;
					autoReuse = true;
					useTurn = false;
					crit += 10;
					useAmmo = 14;
					shoot = 14;
					shootSpeed = 8f;
					noMelee = true;
					ranged = true;
					toolTip = "Fires a powerful, high velocity bullet";
					toolTip2 = "Most bullets turn into Explosive rounds";
					break;

				case 3106:
					name = "Forsaken Relic";
					width = 20;
					height = 28;
					accessory = true;
					toolTip = "Increases damage and critical strike chance by 7% while invincible";
					rare = 5;
					value = Item.sellPrice(0, 2, 0, 0);
					break;

				case 3107:
					name = "Forsaken Cross";
					width = 28;
					height = 28;
					accessory = true;
					toolTip = "Increases damage and critical strike chance by 7% while invincible";
					toolTip2 = "Increases length of invincibility after taking damage";
					rare = 7;
					value = Item.sellPrice(0, 3, 0, 0);
					break;

				case 3108:
					name = "Compressed Extractination Block";
					width = height = 12;
					toolTip = "Stick it in the Extractinator!";
					rare = 1;
					useStyle = 1;
					useTurn = true;
					useAnimation = 40;
					useTime = 40;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					break;

				case 3109:
					name = "Builder's Toolbelt";
					width = 30;
					height = 22;
					accessory = true;
					value = Item.sellPrice(0, 30, 0, 0);
					rare = 11;
					toolTip = "Increases block range by 10 and wall and tile placement speed by 45% and tells time and shows position";
					toolTip2 = "Can craft Tinkerer's Workshop, Anvil, Furnace, and Work Bench items by hand, and the holder can float";
					break;

				case 3110:
					name = "Guide Summon Doll";
					width = height = 20;
					rare = 1;
					useStyle = 4;
					useTurn = true;
					useAnimation = 30;
					useTime = 30;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					toolTip = "Summons the Guide";
					break;

				case 3111:
					name = "Orange Dungeon Work Bench";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 18;
					placeStyle = 27;
					width = 28;
					height = 14;
					value = 150;
					toolTip = "Used for basic crafting";
					break;

				case 3112:
					name = "Orange Dungeon Table";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 14;
					placeStyle = 31;
					width = 28;
					height = 14;
					value = 300;
					break;

				case 3113:
					name = "Orange Dungeon Chair";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 15;
					placeStyle = 32;
					width = 28;
					height = 14;
					value = 200;
					break;

				case 3114:
					flame = true;
					noWet = true;
					name = "Orange Dungeon Candle";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 33;
					placeStyle = 26;
					width = 8;
					height = 18;
					holdStyle = 1;
					break;

				case 3115:
					name = "Orange Dungeon Piano";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 87;
					placeStyle = 26;
					width = 20;
					height = 20;
					value = 300;
					break;

				case 3116:
					name = "Orange Dungeon Sofa";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 89;
					placeStyle = 29;
					width = 20;
					height = 20;
					value = 300;
					break;

				case 3117:
					name = "Orange Dungeon Bookcase";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 101;
					placeStyle = 28;
					width = 20;
					height = 20;
					value = 300;
					break;

				case 3118:
					name = "Orange Dungeon Candelabra";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 100;
					placeStyle = 27;
					width = 20;
					height = 20;
					value = 1500;
					break;

				case 3119:
					name = "Orange Chandelier";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 34;
					placeStyle = 33;
					width = 26;
					height = 26;
					value = 3000;
					break;

				case 3120:
					name = "Orange Platform";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createTile = 19;
					placeStyle = 26;
					width = 20;
					height = 20;
					value = 300;
					break;

				case 3121:
					name = "Orange Bed";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					maxStack = 99;
					consumable = true;
					createTile = 79;
					placeStyle = 27;
					width = 28;
					height = 20;
					value = 2000;
					break;

				case 3122:
					name = "Orange Lamp";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 93;
					placeStyle = 27;
					width = 10;
					height = 24;
					value = 500;
					break;

				case 3123:
					name = "Orange Dungeon Door";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					maxStack = 99;
					consumable = true;
					createTile = 10;
					placeStyle = 32;
					width = 14;
					height = 28;
					value = 200;
					break;

				case 3124:
					name = "Orange Bathtub";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 90;
					placeStyle = 27;
					width = 20;
					height = 20;
					value = 300;
					break;

				case 3125:
					name = "Ancient";
					width = 32;
					height = 34;
					useStyle = 5;
					useTurn = true;
					useAnimation = 25;
					useTime = 25;
					damage = 46;
					autoReuse = true;
					knockBack = 4f;
					UseSound = SoundID.Item34;
					shoot = 489;
					toolTip = "Creates a sandstorm";
					rare = 8;
					shootSpeed = 10f;
					crit += 2;
					mana = 19;
					noMelee = true;
					value = Item.sellPrice(0, 25, 0, 0);
					magic = true;
					break;

				case 3126:
					name = "Desert Key Mold";
					toolTip = "Used for crafting a Desert Key";
					width = height = 30;
					maxStack = 999;
					rare = 9;
					break;

				case 3127:
					name = "Desert Key";
					width = 14;
					height = 20;
					maxStack = 999;
					toolTip = "Unlocks a Desert Chest in the dungeon";
					rare = 9;
					break;

				case 3128:
					name = "Desert Chest";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 21;
					placeStyle = 50;
					width = 26;
					height = 22;
					value = 10000;
					break;

				case 3129:
					name = "Dragon Lord Trophy";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 240;
					width = 30;
					height = 30;
					value = Item.sellPrice(0, 1, 0, 0);
					placeStyle = 58;
					rare = 1;
					break;

				case 3130:
					name = "Orange Dresser";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 88;
					placeStyle = 24;
					width = 20;
					height = 20;
					value = 300;
					break;

				case 3131:
					name = "Chlorophyte Brick";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createTile = 377;
					width = 12;
					rare = 7;
					height = 12;
					break;

				case 3132:
					name = "Chlorophyte Brick Wall";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createWall = 180;
					rare = 7;
					width = 12;
					height = 12;
					break;

				case 3133:
					name = "Dark Slime Block";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createTile = 378;
					width = 12;
					height = 12;
					break;

				case 3134:
					name = "Dark Slime Block Wall";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 7;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createWall = 181;
					width = 12;
					height = 12;
					break;

				case 3135:
					name = "Spectre Headgear";
					width = 18;
					height = 18;
					defense = 11;
					headSlot = 184;
					rare = 8;
					value = 375000;
					toolTip = "10% decreased mana usage";
					toolTip2 = "10% increased magic damage";
					break;

				case 3136:
					name = "Ferozium Helmet";
					width = 18;
					height = 18;
					defense = 17;
					headSlot = 185;
					rare = 8;
					value = 350000;
					toolTip = "20% increased melee and ranged damage";
					break;

				case 3137:
					name = "Ferozium Breastplate";
					width = 18;
					height = 18;
					defense = 23;
					bodySlot = 189;
					rare = 8;
					value = 300000;
					toolTip = "17% increased melee and ranged critical strike chance";
					break;

				case 3138:
					name = "Ferozium Leggings";
					width = 18;
					height = 18;
					defense = 15;
					legSlot = 124;
					rare = 8;
					value = 250000;
					toolTip = "10% increased movement speed";
					toolTip = "12% increased melee attack speed";
					break;

				case 3139:
					name = "Ferozium Ore";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = true;
					useTurn = true;
					autoReuse = true;
					createTile = 379;
					maxStack = 999;
					width = 12;
					height = 12;
					value = Item.sellPrice(0, 0, 0, 75);
					rare = 7;
					break;

				case 3140:
					name = "Ferozium Bar";
					width = height = 20;
					value = Item.sellPrice(0, 0, 95, 0);
					rare = 7;
					maxStack = 999;
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					consumable = true;
					createTile = 239;
					placeStyle = 26;
					break;

				case 3141:
					name = "Ferozium Pickaxe";
					width = height = 38;
					autoReuse = melee = useTurn = true;
					pick = 195;
					useAnimation = 15;
					useTime = 15;
					UseSound = SoundID.Item1;
					value = 250000;
					rare = 7;
					crit = 6;
					damage = 17;
					knockBack = 3f;
					break;

				case 3142:
					name = "Ferozium Icesword";
					width = height = 52;
					autoReuse = melee = useTurn = true;
					useAnimation = 20;
					shoot = 445;
					shootSpeed = 15f;
					useTime = 20;
					scale = 1.5f;
					UseSound = SoundID.Item1;
					value = 350000;
					crit = 2;
					rare = 7;
					damage = 50;
					knockBack = 6f;
					break;

				case 3143:
					name = "Ferozium Waraxe";
					width = height = 54;
					autoReuse = melee = useTurn = true;
					useAnimation = 20;
					axe = (int)(120 / 5);
					useTime = 20;
					scale = 1.5f;
					UseSound = SoundID.Item1;
					value = 350000;
					crit = 2;
					rare = 7;
					damage = 30;
					knockBack = 8f;
					break;

				case 3144:
					name = "Ferozium Bullet";
					shootSpeed = 5.25f;
					shoot = 491;
					damage = 15;
					width = 8;
					height = 8;
					maxStack = 2000;
					consumable = true;
					ammo = 14;
					knockBack = 5f;
					rare = 7;
					value = 200;
					ranged = true;
					break;

				case 3145:
					name = "Ferozium Arrow";
					width = 10;
					height = 20;
					value = Item.sellPrice(0, 0, 1, 0);
					maxStack = 2000;
					damage = 15;
					rare = 7;
					shootSpeed = 4f;
					shoot = 492;
					consumable = true;
					ranged = true;
					ammo = 1;
					knockBack = 4f;
					break;

				case 3146:
					name = "Spiritbeam Fork";
					mana = 15;
					UseSound = SoundID.Item43;
					useStyle = 5;
					damage = 60;
					useAnimation = 19;
					useTime = 19;
					autoReuse = true;
					width = 40;
					height = 40;
					shoot = 294;
					shootSpeed = 6f;
					knockBack = 4.25f;
					value = Item.sellPrice(0, 30, 0, 0);
					magic = true;
					rare = 9;
					noMelee = true;
					break;

				case 3147:
					name = "Hell Armored Helmet";
					width = 20;
					height = 28;
					headSlot = 186;
					vanity = true;
					rare = 8;
					value = Item.sellPrice(0, 0, 90, 0);
					break;

				case 3148:

					name = "Hell Armored Chestplate";
					width = 26;
					height = 22;
					bodySlot = 190;
					vanity = true;
					rare = 8;
					value = Item.sellPrice(0, 0, 90, 0);
					break;

				case 3149:
					name = "Hell Armored Greaves";
					width = 22;
					height = 18;
					legSlot = 125;
					vanity = true;
					rare = 8;
					value = Item.sellPrice(0, 0, 90, 0);
					break;

				case 3150:
					name = "Solarium Rod";
					width = height = 12;
					rare = 9;
					value = Item.sellPrice(0, 1, 0, 0);
					maxStack = 100;
					consumable = true;
					toolTip = "Use at a Solarium Shrine";
					break;

				case 3151:
					name = "Solarium Ore";
					width = height = 14;
					createTile = 382;
					useAnimation = 15;
					useTime = 10;
					useStyle = 1;
					useTurn = true;
					autoReuse = true;
					consumable = true;
					value = Item.sellPrice(0, 0, 50, 0);
					maxStack = 999;
					rare = 9;
					break;

				case 3152:
					name = "Solarium Star";
					width = height = 16;
					rare = 9;
					value = Item.sellPrice(0, 1, 0, 0);
					maxStack = 999;
					break;

				case 3153:
					name = "Solarium Staff";
					width = height = 44;
					damage = 59;
					UseSound = SoundID.Item43;
					useStyle = 5;
					magic = autoReuse = noMelee = true;
					shootSpeed = 9f;
					knockBack = 6f;
					rare = 9;
					value = Item.sellPrice(0, 10, 0, 0);
					shoot = 493;
					useAnimation = useTime = mana = 19;
					break;

				case 3154:
					name = "Solar Flaresword";
					width = height = 52;
					damage = 65;
					UseSound = SoundID.Item1;
					melee = autoReuse = true;
					knockBack = 7f;
					rare = 9;
					value = Item.sellPrice(0, 9, 87, 65);
					useAnimation = useTime = 25;
					break;

				case 3155:
					name = "Solar Flare Bow";
					width = height = 30;
					damage = 69;
					useStyle = 5;
					UseSound = SoundID.Item5;
					shoot = useAmmo = 1;
					shootSpeed = 9f;
					rare = 9;
					ranged = autoReuse = noMelee = true;
					knockBack = 7f;
					value = Item.sellPrice(0, 8, 0, 0);
					useAnimation = useTime = 24;
					break;

				case 3156:
					name = "Blue Lihzahrd Brick";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createTile = 381;
					width = 12;
					height = 12;
					break;

				case 3157:
					name = "Blue Lihzahrd Brick Wall";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createWall = 182;
					width = 12;
					height = 12;
					break;

				case 3158:
					noMelee = true;
					useStyle = 1;
					name = "Possessed Flamesaw";
					shootSpeed = 14f;
					shoot = 494;
					damage = 95;
					knockBack = 9f;
					width = 14;
					//axe = 45;
					height = 28;
					UseSound = SoundID.Item1;
					useAnimation = 15;
					useTime = 15;
					noUseGraphic = true;
					rare = 10;
					toolTip = "Can chop trees instantly";
					value = Item.sellPrice(0, 40, 0, 0);
					melee = true;
					break;

				case 3159:
					noMelee = true;
					useStyle = 4;
					name = "Starfall";
					damage = 1000;
					knockBack = 16f;
					width = 28;
					height = 28;
					UseSound = SoundID.Item4;
					useAnimation = 35;
					useTime = 35;
					rare = 8;
					toolTip = "'The power of the stars consumes your mana'";
					value = Item.sellPrice(0, 40, 0, 0);
					magic = true;
					mana = 400;
					break;

				case 3160:
					name = "Nature's Endowment";
					width = 30;
					height = 28;
					accessory = true;
					toolTip = "25% decreased mana usage";
					toolTip2 = "+20 mana";
					rare = 5;
					value = Item.sellPrice(0, 2, 36, 0);
					break;

				case 3161:
					name = "Gift of Starpower";
					width = 28;
					height = 28;
					accessory = true;
					toolTip = "20% decreased mana usage and +40 mana";
					toolTip2 = "Automatically use mana potions when needed and 15% increased magic damage";
					rare = 7;
					value = Item.sellPrice(0, 8, 0, 0);
					break;

				case 3162:
					name = "Stamina Crystal";
					maxStack = 999;
					consumable = true;
					width = 18;
					height = 18;
					useStyle = 4;
					useTime = 30;
					UseSound = SoundID.Item4;
					useAnimation = 30;
					toolTip = "Permanently increases maximum stamina by 20";
					rare = 3;
					value = 95000;
					break;

				case 3163:
					name = "Staminastone";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = true;
					useTurn = true;
					autoReuse = true;
					createTile = 384;
					maxStack = 999;
					width = 16;
					height = 16;
					value = Item.sellPrice(0, 0, 2, 50);
					rare = 3;
					break;

				case 3164:
					name = "Lesser Stamina Potion";
					UseSound = SoundID.Item3;
					healStamina = 40;
					useStyle = 2;
					useTurn = true;
					useAnimation = 17;
					useTime = 17;
					maxStack = 30;
					consumable = true;
					width = 14;
					height = 24;
					value = 400;
					break;

				case 3165:
					name = "Stamina Potion";
					UseSound = SoundID.Item3;
					healStamina = 90;
					useStyle = 2;
					useTurn = true;
					useAnimation = 17;
					useTime = 17;
					maxStack = 50;
					rare = 2;
					consumable = true;
					width = 14;
					height = 24;
					value = 900;
					break;

				case 3166:
					name = "Greater Stamina Potion";
					UseSound = SoundID.Item3;
					healStamina = 130;
					useStyle = 2;
					useTurn = true;
					useAnimation = 17;
					useTime = 17;
					maxStack = 75;
					rare = 5;
					consumable = true;
					width = 14;
					height = 24;
					value = 2000;
					break;

				case 3167:
					name = "Super Stamina Potion";
					UseSound = SoundID.Item3;
					healStamina = 160;
					useStyle = 2;
					useTurn = true;
					useAnimation = 17;
					useTime = 17;
					maxStack = 99;
					rare = 8;
					consumable = true;
					width = 14;
					height = 24;
					value = 4000;
					break;

				case 3168:
					name = "Shadow Ring";
					width = 28;
					height = 28;
					accessory = true;
					toolTip = "Negates visual cloaking from stealth armors";
					toolTip2 = "Works in the vanity slot";
					rare = 6;
					worksInVanity = true;
					value = Item.sellPrice(0, 5, 0, 0);
					break;

				case 3169:
					name = "Vertebrae Wall";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createWall = 184;
					width = 12;
					height = 12;
					break;

				case 3588:
					name = "Lens Apparatus";
					width = height = 30;
					maxStack = 999;
					value = Item.sellPrice(0, 0, 60, 0);
					rare = 2;
					break;

				case 3589:
					name = "Infernasword";
					width = height = 44;
					useStyle = 1;
					UseSound = SoundID.Item1;
					shoot = 571;
					knockBack = 4f;
					shootSpeed = 9f;
					useTime = useAnimation = 18;
					damage = 71;
					melee = autoReuse = true;
					value = Item.sellPrice(0, 5);
					rare = 8;
					break;

				case 3590:
					name = "Flower of The Jungle";
					width = height = 26;
					useStyle = 1;
					UseSound = SoundID.Item1;
					shoot = 572;
					knockBack = shootSpeed = 5f;
					useTime = useAnimation = mana = 16;
					damage = 25;
					magic = noMelee = true;
					value = Item.sellPrice(0, 0, 60, 0);
					rare = 3;
					break;

				case 3591:
					name = "Energy Revolver";
					width = height = 30;
					useStyle = 5;
					UseSound = SoundID.Item12;
					shoot = 20;
					knockBack = 2f;
					shootSpeed = 15f;
					useTime = useAnimation = mana = 6;
					damage = 57;
					magic = noMelee = autoReuse = true;
					value = Item.sellPrice(0, 2, 60, 0);
					rare = 3;
					break;

				case 3604:
					name = "Dark Matter Wood";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					autoReuse = true;
					useTime = 10;
					width = 24;
					height = 14;
					consumable = true;
					maxStack = 999;
					createTile = 444;
					break;

				case 3605:
					name = "Dark Matter Wood Wall";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 7;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createWall = 208;
					width = 12;
					height = 12;
					break;

				case 3606:
					name = "Dark Matter Soil";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					autoReuse = true;
					useTime = 10;
					width = 24;
					height = 14;
					consumable = true;
					maxStack = 999;
					createTile = 448;
					break;

				case 3607:
					name = "Dark Sand Block";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					autoReuse = true;
					useTime = 10;
					width = 24;
					height = 14;
					consumable = true;
					maxStack = 999;
					createTile = 449;
					break;

				case 3608:
					name = "Dark Matter Block";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					autoReuse = true;
					useTime = 10;
					width = 24;
					height = 14;
					consumable = true;
					maxStack = 999;
					createTile = 446;
					break;

				case 3609:
					name = "Black Ice Block";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					autoReuse = true;
					useTime = 10;
					width = 24;
					height = 14;
					consumable = true;
					maxStack = 999;
					createTile = 450;
					break;

				case 3610:
					name = "Living Lightning Block";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					autoReuse = true;
					useTime = 10;
					width = 24;
					height = 14;
					consumable = true;
					maxStack = 999;
					createTile = 451;
					break;

				case 3611:
					name = "Thunderbolt in a Bottle";
					width = 16;
					height = 24;
					accessory = true;
					rare = 7;
					toolTip = "Allows the holder to double jump";
					value = 100000;
					break;

				case 3612:
					name = "Plasma Lamp";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 452;
					width = 20;
					height = 20;
					value = 1500;
					break;

				case 3613:
					name = "Volt Brick";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createTile = 453;
					width = 12;
					height = 12;
					break;

				case 3614:
					name = "Flask of Infection";
					UseSound = SoundID.Item3;
					useStyle = 2;
					useTurn = true;
					useAnimation = 17;
					useTime = 17;
					maxStack = 100;
					consumable = true;
					width = 14;
					height = 24;
					buffType = 171;
					buffTime = 54000;
					toolTip = "Melee attacks inflict Infected on enemies";
					value = Item.sellPrice(0, 0, 5, 0);
					rare = 4;
					break;

				case 3615:
					name = "Mystical Tome Page";
					width = height = 22;
					rare = 2;
					maxStack = 999;
					toolTip = "Used to craft Mystical Tomes";
					value = Item.sellPrice(0, 0, 3, 0);
					break;

				case 3616:
					name = "Restoration Band";
					width = 16;
					height = 24;
					accessory = true;
					rare = 3;
					defense = 1;
					lifeRegen = 1;
					toolTip = "Regenerates life, mana, and stamina";
					toolTip2 = "15% decreased mana and stamina usage";
					value = 10000;
					break;

				case 3617:
					name = "Effect Ring";
					width = 16;
					height = 24;
					accessory = true;
					rare = 3;
					toolTip = "Negates visual effect of werewolf buff";
					toolTip2 = "Works in the vanity slot";
					worksInVanity = true;
					value = 10000;
					break;

				case 3629:
					name = "Corruption Wings";
					width = 24;
					height = 8;
					accessory = true;
					toolTip = "Allows flight and slow fall";
					toolTip2 = "Grants extra bonuses if you are in the Corruption";
					value = 400000;
					rare = 5;
					wingSlot = 30;
					break;

				case 3630:
					name = "Crimson Wings";
					width = 24;
					height = 8;
					accessory = true;
					toolTip = "Allows flight and slow fall";
					toolTip2 = "Grants extra bonuses if you are in the Crimson";
					value = 400000;
					rare = 5;
					wingSlot = 31;
					break;

				case 3631:
					name = "Contagion Wings";
					width = 24;
					height = 8;
					accessory = true;
					toolTip = "Allows flight and slow fall";
					toolTip2 = "Grants extra bonuses if you are in the Contagion";
					value = 400000;
					rare = 5;
					wingSlot = 32;
					break;

				case 3632:
					name = "Omnibag";
					width = 24;
					height = 28;
					accessory = true;
					vanity = true;
					toolTip = "Blood, icky, frost, demonic, fire, and hallow particles cover you when you move";
					rare = 7;
					worksInVanity = true;
					value = Item.sellPrice(0, 10, 0, 0);
					break;

				case 3633:
					name = "Player Sensor";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createTile = 454;
					width = 12;
					height = 12;
					value = 2000;
					mech = true;
					break;

				case 3634:
					name = "Warm Gemspark Block";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createTile = 455;
					width = 12;
					height = 12;
					break;

				case 3635:
					name = "Slime Cap";
					width = 18;
					height = 18;
					toolTip = "3% increased minion damage";
					defense = 1;
					headSlot = 205;
					value = 5250;
					break;

				case 3636:
					name = "Slime Breastplate";
					width = 18;
					height = 18;
					toolTip = "3% increased minion knockback";
					defense = 2;
					bodySlot = 203;
					value = 5250;
					break;

				case 3637:
					name = "Slime Pants";
					width = 18;
					height = 18;
					defense = 1;
					legSlot = 135;
					value = 5250;
					break;

				case 3638:
					name = "Vampire Harpy Wings";
					width = 24;
					height = 8;
					accessory = true;
					toolTip = "Allows flight and slow fall and heals life";
					toolTip2 = "Other bonuses apply when in the Dark Matter";
					value = 800000;
					rare = 8;
					wingSlot = 33;
					break;

				case 3639:
					name = "Ethereal Wings";
					width = 24;
					height = 8;
					accessory = true;
					toolTip = "Allows flight and slow fall";
					toolTip2 = "Other bonuses apply when in the Dungeon";
					value = 800000;
					rare = 9;
					wingSlot = 34;
					break;

				case 3640:
					name = "Holy Wings";
					width = 24;
					height = 8;
					accessory = true;
					toolTip = "Allows flight and slow fall";
					toolTip2 = "Other bonuses apply when in the Hallow";
					value = 600000;
					rare = 8;
					wingSlot = 35;
					break;

				case 3641:
					name = "Plastic Brick";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createTile = 456;
					width = 12;
					height = 12;
					break;

				case 3642:
					name = "Plastic Brick Wall";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 7;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createWall = 209;
					width = 12;
					height = 12;
					break;

				case 3643:
					name = "Purple Bed";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					maxStack = 99;
					consumable = true;
					createTile = 79;
					placeStyle = 31;
					width = 28;
					height = 20;
					value = 2000;
					break;

				case 3644:
					name = "Purple Dungeon Chair";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 15;
					placeStyle = 38;
					width = 28;
					height = 14;
					value = 200;
					break;

				case 3645:
					name = "Purple Dungeon Table";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 14;
					placeStyle = 36;
					width = 28;
					height = 14;
					value = 300;
					break;

				case 3646:
					name = "Purple Dungeon Work Bench";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 18;
					placeStyle = 33;
					width = 28;
					height = 14;
					value = 150;
					toolTip = "Used for basic crafting";
					break;

				case 3647:
					name = "Purple Brick";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createTile = 457;
					width = 12;
					height = 12;
					break;

				case 3648:
					name = "Purple Brick Wall";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 7;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createWall = 213;
					width = 12;
					height = 12;
					break;

				case 3649:
					name = "Purple Slab Wall";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 7;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createWall = 214;
					width = 12;
					height = 12;
					break;

				case 3650:
					name = "Purple Tiled Wall";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 7;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createWall = 215;
					width = 12;
					height = 12;
					break;

				case 3651:
					name = "Purple Platform";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createTile = 19;
					placeStyle = 32;
					width = 20;
					height = 20;
					value = 300;
					break;

				case 3652:
					name = "Four Leaf Clover";
					width = height = 30;
					value = Item.sellPrice(5, 0, 0, 0);
					toolTip = "You are very lucky to have found this!";
					rare = 7;
					maxStack = 999;
					break;

				case 3653:
					name = "Fake Four Leaf Clover";
					width = height = 30;
					value = Item.sellPrice(0, 0, 30, 0);
					toolTip = "Aww... it's fake!";
					rare = 3;
					maxStack = 999;
					break;

				case 3654:
					name = "Purple Bookcase";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 101;
					width = 20;
					height = 20;
					value = 300;
					placeStyle = 33;
					break;

				case 3655:
					name = "Purple Lamp";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 93;
					placeStyle = 31;
					width = 10;
					height = 24;
					value = 500;
					break;

				case 3656:
					name = "Purple Sofa";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 89;
					placeStyle = 33;
					width = 20;
					height = 20;
					value = 300;
					break;

				case 3657:
					name = "Purple Dresser";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 88;
					placeStyle = 28;
					width = 20;
					height = 20;
					value = 300;
					break;

				case 3658:
					name = "Purple Piano";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 87;
					placeStyle = 30;
					width = 20;
					height = 20;
					value = 300;
					break;

				case 3659:
					name = "Snotline Fishing Rod";
					useStyle = 1;
					useAnimation = 8;
					useTime = 8;
					width = 24;
					height = 28;
					UseSound = SoundID.Item1;
					shoot = 360;
					fishingPole = 25;
					shootSpeed = 16.5f;
					rare = 3;
					value = Item.sellPrice(0, 0, 0, 0);
					break;

				case 3660:
					name = "Sickly Trout";
					maxStack = 999;
					width = 26;
					height = 26;
					value = Item.sellPrice(0, 0, 5, 0);
					rare = 1;
					break;

				case 3661:
					name = "Ickfish";
					maxStack = 1;
					width = 26;
					height = 26;
					questItem = true;
					value = Item.sellPrice(0, 0, 5, 0);
					uniqueStack = true;
					rare = -11;
					break;

				case 3662:
					name = "Snotpiranha";
					questItem = true;
					maxStack = 1;
					width = 26;
					height = 26;
					uniqueStack = true;
					rare = -11;
					break;

				case 3663:
					name = "Darkfin Tigerfish";
					maxStack = 999;
					width = 26;
					height = 26;
					value = Item.sellPrice(0, 0, 30, 0);
					rare = 6;
					break;

				case 3664:
					name = "Blightkoi";
					questItem = true;
					maxStack = 1;
					width = 26;
					height = 26;
					uniqueStack = true;
					rare = -11;
					break;

				case 3665:
					name = "Dungeon Helmet";
					width = 20;
					height = 28;
					headSlot = 206;
					vanity = true;
					rare = 8;
					value = Item.sellPrice(0, 0, 90, 0);
					break;

				case 3666:
					name = "Dungeon Plate Mail";
					width = 26;
					height = 22;
					bodySlot = 204;
					vanity = true;
					rare = 8;
					value = Item.sellPrice(0, 0, 90, 0);
					break;

				case 3667:
					name = "Dungeon Pants";
					width = 22;
					height = 18;
					legSlot = 136;
					vanity = true;
					rare = 8;
					value = Item.sellPrice(0, 0, 90, 0);
					break;

				case 3668:
					name = "Rusty Helmet";
					width = 20;
					height = 28;
					headSlot = 207;
					vanity = true;
					rare = 8;
					value = Item.sellPrice(0, 0, 90, 0);
					break;

				case 3669:
					name = "Rusted Chestplate";
					width = 26;
					height = 22;
					bodySlot = 205;
					vanity = true;
					rare = 8;
					value = Item.sellPrice(0, 0, 90, 0);
					break;

				case 3670:
					name = "Rusted Army Greaves";
					width = 22;
					height = 18;
					legSlot = 137;
					vanity = true;
					rare = 8;
					value = Item.sellPrice(0, 0, 90, 0);
					break;

				case 3671:
					name = "Hidden Blade";
					width = 16;
					height = 24;
					accessory = true;
					rare = 4;
					toolTip = "Immunity to Broken Weaponry";
					value = 100000;
					break;

				case 3672:
					name = "Ammo Magazine";
					width = 16;
					height = 24;
					accessory = true;
					rare = 4;
					toolTip = "Immunity to Unloaded";
					value = 100000;
					break;

				case 3673:
					name = "Bayonet";
					width = 16;
					height = 24;
					accessory = true;
					rare = 4;
					toolTip = "Immunity to Broken Weaponry and Unloaded";
					value = 100000;
					break;

				case 3674:
					name = "NNN";
					width = 16;
					height = 24;
					accessory = true;
					rare = 2;
					toolTip = "Reduces debuff time by 25%";
					value = 100000;
					break;

				case 3680:
					name = "Ectoplasm Wall";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 7;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createWall = 216;
					width = 12;
					height = 12;
					break;

				case 3681:
					name = "Oblivion Brick Wall";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 7;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createWall = 217;
					width = 12;
					height = 12;
					break;

				case 3682:
					useStyle = 5;
					autoReuse = true;
					useAnimation = 40;
					useTime = 40;
					name = "Hellstone Blowpipe";
					width = 38;
					height = 6;
					shoot = 10;
					useAmmo = 51;
					UseSound = SoundID.Item5;
					rare = 3;
					damage = 13;
					shootSpeed = 11f;
					noMelee = true;
					value = 10000;
					knockBack = 3.5f;
					toolTip = "Fires a spread of five seeds";
					toolTip2 = "Allows the collection of seeds for ammo";
					ranged = true;
					break;

				case 3688:
					name = "Rhotuka Spinner";
					maxStack = 999;
					width = height = 32;
					rare = 1;
					toolTip = "Charged with power";
					value = Item.sellPrice(0, 0, 0, 10);
					break;

				case 3689:
					name = "Rhotuka Spinner (Black Hole)";
					maxStack = 999;
					width = height = 32;
					rare = 8;
					ammo = 3688;
					shoot = 586;
					shootSpeed = 2f;
					damage = 40;
					toolTip = "Will pull enemies toward one struck";
					value = Item.sellPrice(0, 0, 4, 0);
					break;

				case 3690:
					name = "Rhotuka Spinner (Poison)";
					maxStack = 999;
					width = height = 32;
					rare = 2;
					ammo = 3688;
					shoot = 587;
					shootSpeed = 2f;
					damage = 32;
					toolTip = "Will envenom a struck enemy";
					value = Item.sellPrice(0, 0, 0, 50);
					break;

				case 3691:
					name = "Rhotuka Spinner (Scrambler)";
					maxStack = 999;
					width = height = 32;
					rare = 6;
					ammo = 3688;
					shoot = 588;
					shootSpeed = 2f;
					damage = 26;
					toolTip = "Will scramble the stats of a struck enemy";
					value = Item.sellPrice(0, 0, 4, 0);
					break;

				case 3692:
					name = "Rhotuka Spinner (Teleport)";
					maxStack = 999;
					width = height = 32;
					rare = 3;
					ammo = 3688;
					shoot = 589;
					shootSpeed = 2f;
					damage = 45;
					toolTip = "Will teleport a struck enemy somewhere ";
					value = Item.sellPrice(0, 0, 2, 0);
					break;

				case 3693:
					name = "Rhotuka Spinner (Confuse)";
					maxStack = 999;
					width = height = 32;
					rare = 4;
					ammo = 3688;
					shoot = 590;
					shootSpeed = 2f;
					damage = 42;
					toolTip = "Will confuse a struck enemy";
					value = Item.sellPrice(0, 0, 0, 40);
					break;

				case 3694:
					name = "Rhotuka Spinner (Weaken)";
					maxStack = 999;
					width = height = 32;
					rare = 5;
					ammo = 3688;
					shoot = 591;
					shootSpeed = 2f;
					damage = 22;
					toolTip = "Will weaken a struck enemy";
					value = Item.sellPrice(0, 0, 6, 0);
					break;

				case 3695:
					name = "Rhotuka Launcher";
					maxStack = 1;
					width = height = 32;
					rare = 3;
					useAmmo = 3688;
					useTurn = true;
					useStyle = 5;
					useAnimation = 22;
					useTime = 22;
					shoot = 586;
					shootSpeed = 14f;
					damage = 30;
					toolTip = "Launches Rhotuka spinners";
					value = Item.sellPrice(0, 0, 50, 0);
					break;

				case 3696:
					name = "Purple Dungeon Wand";
					wallWand = 3648;
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 7;
					autoReuse = true;
					createWall = 210;
					width = 8;
					height = 10;
					rare = 1;
					toolTip = "Places unsafe purple dungeon walls";
					break;

				case 3697:
					name = "Curse of Oblivion";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 242;
					toolTip = "'B. Harold'";
					width = 30;
					height = 30;
					rare = 9;
					value = Item.sellPrice(0, 0, 50, 0);
					placeStyle = 37;
					break;

				case 3698:
					name = "Bacterium Prime Trophy";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 240;
					width = 30;
					height = 30;
					value = Item.sellPrice(0, 1, 0, 0);
					placeStyle = 60;
					rare = 1;
					break;

				case 3699:
					name = "Shell Hammer";
					width = height = 56;
					projFireDelay = 240;
					knockBack = 12f;
					melee = useTurn = autoReuse = true;
					rare = 7;
					UseSound = SoundID.Item1;
					useStyle = maxStack = 1;
					useAnimation = useTime = 35;
					shoot = 594;
					shootSpeed = 5.5f;
					damage = 87;
					toolTip = "Lobs shells";
					value = Item.sellPrice(0, 6, 20, 0);
					break;

				case 3720:
					name = "Herbology Bench";
					useTurn = true;
					useStyle = 1;
					useAnimation = 15;
					useTime = 15;
					maxStack = 99;
					consumable = true;
					createTile = 473;
					width = 12;
					height = 20;
					value = 1000;
					break;

				case 3721:
					name = "Cool Gemspark Block";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createTile = 474;
					width = 12;
					height = 12;
					break;

				case 3722:
					name = "Tropic Stone";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createTile = 475;
					width = 12;
					height = 12;
					break;

				case 3723:
					name = "Tropical Mud";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createTile = 476;
					width = 12;
					height = 12;
					break;

				case 3724:
					name = "Tropics Wood";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createTile = 478;
					width = 12;
					height = 12;
					break;

				case 3725:
					name = "Twilight Plume Seeds";
					useTurn = true;
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					maxStack = 999;
					consumable = true;
					createTile = 82;
					placeStyle = 10;
					width = 12;
					height = 14;
					value = 90;
					break;

				case 3726:
					name = "Twilight Plume";
					maxStack = 999;
					width = 12;
					height = 14;
					value = 100;
					break;

				case 3727:
					name = "Black Sand";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createTile = 479;
					width = 12;
					height = 12;
					break;

				case 3728:
					name = "Tropic Grass Seeds";
					useTurn = true;
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					maxStack = 999;
					consumable = true;
					createTile = 477;
					width = 14;
					height = 14;
					value = 500;
					break;

				case 3729:
					name = "Smogscreen";
					useAnimation = useTime = 30;
					width = height = 24;
					damage = 64;
					magic = noMelee = true;
					mana = 10;
					shoot = 595;
					shootSpeed = 0.4f;
					crit += 3;
					knockBack = 5f;
					UseSound = SoundID.Item34;
					useStyle = 5;
					rare = 5;
					toolTip = "Casts smog";
					value = buyPrice(0, 2, 0, 0);
					break;

				case 3730:
					name = "Catalyzer";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					rare = 4;
					toolTip = "Used to convert materials";
					value = Item.sellPrice(0, 0, 30, 0);
					createTile = 480;
					width = 30;
					height = 30;
					break;

				case 3731:
					name = "Sulphur";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createTile = 481;
					width = 12;
					height = 12;
					rare = 4;
					value = Item.sellPrice(0, 0, 2, 0);
					break;

				case 3732:
					name = "Clash";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 242;
					toolTip = "'B. Harold'";
					width = 30;
					height = 30;
					rare = 4;
					value = Item.sellPrice(0, 0, 50, 0);
					placeStyle = 38;
					break;

				case 3733:
					name = "Molten Crown";
					width = 18;
					height = 18;
					defense = 3;
					headSlot = 208;
					rare = 3;
					toolTip = "Magic helmet";
					value = 30000;
					break;

				case 3734:
					name = "Molten Headgear";
					width = 18;
					height = 18;
					defense = 5;
					headSlot = 209;
					rare = 3;
					toolTip = "Ranged helmet";
					value = 30000;
					break;

				case 3735:
					name = "Yucky Crate";
					width = 12;
					height = 12;
					rare = 1;
					toolTip = "Right click to open";
					maxStack = 99;
					value = Item.sellPrice(0, 0, 10, 0);
					break;

				case 3736:
					name = "Ocean Crate";
					width = 12;
					height = 12;
					rare = 1;
					toolTip = "Right click to open";
					maxStack = 99;
					value = Item.sellPrice(0, 0, 10, 0);
					break;

				case 3737:
					name = "Dungeon Crate";
					width = 12;
					height = 12;
					rare = 1;
					toolTip = "Right click to open";
					maxStack = 99;
					value = Item.sellPrice(0, 0, 10, 0);
					break;

				case 3738:
					name = "Magic Conch";
					width = 24;
					height = 24;
					UseSound = SoundID.Item6;
					rare = 1;
					useAnimation = 90;
					useTime = 90;
					useTurn = true;
					value = Item.sellPrice(0, 1);
					useStyle = 4;
					toolTip = "If you listen closely, you can hear the ocean";
					break;

				case 3739:
					name = "Demon Conch";
					width = 24;
					height = 24;
					UseSound = SoundID.Item6;
					rare = 3;
					useAnimation = 90;
					useTime = 90;
					useTurn = true;
					value = Item.sellPrice(0, 1);
					useStyle = 4;
					toolTip = "If you listen closely, you can hear screams";
					break;

				case 3740:
					name = "Dark Star Heart";
					maxStack = 999;
					consumable = true;
					width = 18;
					height = 18;
					useStyle = 4;
					useTime = 30;
					UseSound = SoundID.Item4;
					useAnimation = 30;
					toolTip = "Permanently adds a 6th accessory slot";
					rare = 9;
					value = Item.sellPrice(0, 2);
					break;

				case 3741:
					rare = 3;
					UseSound = SoundID.Item5;
					name = "Rhodium Bow";
					useStyle = 5;
					damage = 21;
					useTurn = true;
					useAnimation = 18;
					useTime = 18;
					width = 18;
					height = 32;
					scale = 1f;
					knockBack = 1.3f;
					shoot = 1;
					shootSpeed = 9f;
					useAmmo = 1;
					ranged = noMelee = true;
					value = Item.sellPrice(0, 0, 50, 0);
					break;

				case 3742:
					rare = 3;
					UseSound = SoundID.Item5;
					name = "Osmium Bow";
					useStyle = 5;
					damage = 24;
					useTurn = true;
					useAnimation = 17;
					useTime = 17;
					width = 18;
					height = 32;
					scale = 1f;
					knockBack = 1.4f;
					shoot = 1;
					shootSpeed = 9f;
					useAmmo = 1;
					noMelee = true;
					ranged = true;
					value = Item.sellPrice(0, 0, 50, 0);
					break;

				case 3743:
					name = "Osmium Hamaxe";
					width = height = 32;
					autoReuse = melee = useTurn = true;
					axe = 20;
					hammer = 70;
					useAnimation = 14;
					useTime = 14;
					scale = 1.3f;
					UseSound = SoundID.Item1;
					value = 50000;
					rare = 3;
					crit = 5;
					damage = 19;
					knockBack = 2.2f;
					break;

				case 3744:
					rare = 3;
					UseSound = SoundID.Item5;
					name = "Bowshark";
					useStyle = 5;
					damage = 30;
					useTurn = true;
					useAnimation = 17;
					useTime = 17;
					width = 18;
					autoReuse = true;
					height = 32;
					scale = 1f;
					knockBack = 1.4f;
					shoot = 1;
					shootSpeed = 9f;
					useAmmo = 1;
					ranged = true;
					value = Item.sellPrice(0, 0, 50, 0);
					break;

				case 3745:
					name = "Hellbound Remote";
					value = 0;
					height = 18;
					width = 24;
					toolTip = "Summons the Wall of Steel";
					toolTip2 = "Toss into lava in the Underworld";
					rare = 6;
					maxStack = 1;
					break;

				case 3746:
					name = "Essence of Terraria";
					useStyle = 4;
					useTime = 45;
					useAnimation = 45;
					value = 0;
					height = 18;
					width = 24;
					toolTip = "Summons all bosses at once";
					rare = 6;
					maxStack = 1;
					break;

				case 3747:
					name = "Berserker Bar";
					width = 20;
					height = 20;
					value = Item.sellPrice(0, 2);
					rare = 9;
					maxStack = 999;
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					consumable = true;
					createTile = 239;
					placeStyle = 38;
					break;

				case 3749:
					name = "Dragon Stone";
					width = 38;
					height = 38;
					rare = 7;
					value = Item.sellPrice(0, 2, 0, 0);
					accessory = true;
					toolTip = "Provides immunity to flying creatures";
					break;

				case 3750:
					name = "Reflector Staff";
					useStyle = 1;
					shootSpeed = 14f;
					shoot = 606;
					damage = 120;
					width = 38;
					height = 36;
					UseSound = SoundID.Item44;
					buffType = 176;
					useAnimation = 30;
					useTime = 30;
					noMelee = true;
					value = Item.sellPrice(0, 30, 0, 0);
					knockBack = 8.5f;
					rare = 8;
					summon = true;
					mana = 30;
					break;

				case 3751:
					name = "Mechanical Stinger";
					useStyle = 4;
					useTime = 45;
					useAnimation = 45;
					value = 0;
					height = 18;
					width = 24;
					toolTip = "Summons Mechasting";
					rare = 7;
					consumable = true;
					maxStack = 20;
					break;

				case 3752:
					name = "Sky Brick";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = true;
					useTurn = true;
					autoReuse = true;
					createTile = 483;
					maxStack = 999;
					width = 12;
					height = 12;
					value = 0;
					rare = 7;
					break;

				case 3753:
					name = "Ectoplasmic Beacon";
					useStyle = 4;
					useTime = 45;
					useAnimation = 45;
					value = 0;
					height = 18;
					width = 24;
					toolTip = "Summons Phantasm";
					toolTip2 = "Must be used in the Hellcastle";
					rare = 4;
					consumable = true;
					maxStack = 20;
					break;

				case 3754:
					name = "Library Altar";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					rare = 8;
					toolTip = "The spirit of Oblivion guards this altar";
					value = Item.sellPrice(0, 0, 30, 0);
					createTile = 484;
					width = 30;
					height = 30;
					break;

				case 3755:
					name = "Vampire Teeth";
					width = 38;
					height = 38;
					rare = 7;
					value = Item.sellPrice(0, 2, 0, 0);
					accessory = true;
					toolTip = "Grants the ability for true melee attacks to lifesteal";
					break;

				case 3756:
					name = "Ghost in the Machine";
					width = 38;
					height = 38;
					rare = 7;
					maxStack = 999;
					value = Item.sellPrice(0, 2, 0, 0);
					toolTip = "'Ghostly sounds emanate from this mechanism'";
					break;

				case 3757:
					name = "Impervious Door";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					maxStack = 99;
					consumable = true;
					placeStyle = 1;
					createTile = 485;
					width = 14;
					height = 28;
					value = 200;
					break;

				case 3758:
					name = "Impervious Key";
					width = 14;
					height = 20;
					maxStack = 999;
					toolTip = "Opens the Library of Knowledge door";
					rare = 9;
					break;

				case 3759:
					name = "Alien Apparatus";
					width = 34;
					height = 34;
					maxStack = 999;
					value = 0;
					rare = 10;
					toolTip = "Used for crafting the Eye of Oblivion";
					break;

				case 3760:
					name = "Ectoplasm Door";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					maxStack = 99;
					consumable = true;
					placeStyle = 2;
					createTile = 485;
					width = 14;
					height = 28;
					value = 200;
					break;

				case 3761:
					name = "Bloodstained Chestplate";
					width = 26;
					height = 22;
					bodySlot = 207;
					vanity = true;
					rare = 2;
					value = Item.sellPrice(0, 0, 10, 0);
					break;

				case 3762:
					name = "Bloodstained Greaves";
					width = 22;
					height = 18;
					legSlot = 139;
					vanity = true;
					rare = 2;
					value = Item.sellPrice(0, 0, 10, 0);
					break;

				case 3763:
					name = "Tuhrtl Brick";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createTile = 487;
					width = 12;
					height = 12;
					break;

				case 3764:
					name = "Tuhrtl Brick Wall";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createWall = 222;
					width = 12;
					height = 12;
					break;

				case 3765:
					name = "Nest Block";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createTile = 491;
					width = 12;
					height = 12;
					break;

				case 3766:
					name = "Tomorrow's Phoenix";
					width = 20;
					height = 22;
					rare = 3;
					tome = true;
					toolTip = "8% increased minion damage, 5% increased minion knockback";
					value = Item.sellPrice(0, 0, 10);
					break;

				case 3767:
					name = "Southeastern Peacock";
					width = 20;
					height = 22;
					rare = 6;
					tome = true;
					toolTip = "+3% critical strike chance, -5% mana cost";
					toolTip2 = "8% increased minion damage, 5% increased minion knockback";
					value = Item.sellPrice(0, 0, 40);
					break;

				case 3768:
					name = "Scene of Carnage";
					width = 20;
					height = 22;
					rare = 8;
					tome = true;
					toolTip = "15% increased melee damage and speed";
					value = Item.sellPrice(0, 0, 40);
					break;

				case 3769:
					name = "The Oasis Remembered";
					width = 20;
					height = 22;
					rare = 8;
					tome = true;
					toolTip = "20% increased minion damage and knockback";
					value = Item.sellPrice(0, 0, 40);
					break;

				case 3770:
					name = "Purple Dungeon Door";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					maxStack = 99;
					consumable = true;
					placeStyle = 3;
					createTile = 485;
					width = 14;
					height = 28;
					value = 200;
					break;

				case 3771:
					name = "Eggman Trophy";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 240;
					width = 30;
					height = 30;
					value = Item.sellPrice(0, 1, 0, 0);
					placeStyle = 61;
					rare = 12;
					break;

				case 3772:
					name = "Resistant Wood Platform";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 999;
					consumable = true;
					createTile = 19;
					placeStyle = 33;
					width = 20;
					height = 20;
					value = 300;
					break;

				case 3773:
					name = "Amethyst Amulet";
					width = 30;
					height = 30;
					rare = 1;
					value = Item.sellPrice(0, 0, 30, 0);
					accessory = true;
					toolTip = "5% increased magic damage";
					break;

				case 3774:
					name = "Topaz Amulet";
					width = 30;
					height = 30;
					rare = 1;
					value = Item.sellPrice(0, 0, 30, 0);
					accessory = true;
					toolTip = "5% increased melee damage";
					break;

				case 3775:
					name = "Sapphire Amulet";
					width = 30;
					height = 30;
					rare = 1;
					value = Item.sellPrice(0, 0, 30, 0);
					accessory = true;
					toolTip = "Increases maximum mana by 40";
					break;

				case 3776:
					name = "Emerald Amulet";
					width = 30;
					height = 30;
					rare = 2;
					value = Item.sellPrice(0, 0, 50, 0);
					accessory = true;
					toolTip = "5% increased ranged damage";
					break;

				case 3777:
					name = "Ruby Amulet";
					width = 30;
					height = 30;
					rare = 2;
					value = Item.sellPrice(0, 0, 50, 0);
					accessory = true;
					toolTip = "Increases maximum life by 40";
					break;

				case 3778:
					name = "Diamond Amulet";
					width = 30;
					height = 30;
					rare = 2;
					value = Item.sellPrice(0, 0, 30, 0);
					accessory = true;
					defense = 5;
					break;

				case 3779:
					name = "Tourmaline Amulet";
					width = 30;
					height = 30;
					rare = 3;
					value = Item.sellPrice(0, 0, 70, 0);
					accessory = true;
					toolTip = "5% increased critical strike chance";
					break;

				case 3780:
					name = "Peridot Amulet";
					width = 30;
					height = 30;
					rare = 3;
					value = Item.sellPrice(0, 0, 70, 0);
					accessory = true;
					toolTip = "5% increased summon damage";
					break;

				case 3781:
					name = "Zircon Amulet";
					width = 30;
					height = 30;
					rare = 3;
					value = Item.sellPrice(0, 0, 70, 0);
					accessory = true;
					toolTip = "10% increased critical strike damage";
					break;

				case 3782:
					name = "Amulet of Power";
					width = 30;
					height = 30;
					rare = 3;
					value = Item.sellPrice(0, 0, 70, 0);
					accessory = true;
					toolTip = "Increases all stats";
					defense = 3;
					break;

				case 3783:
					name = "Magnet Potion";
					UseSound = SoundID.Item3;
					useStyle = 2;
					useTurn = true;
					useAnimation = 17;
					useTime = 17;
					maxStack = 100;
					consumable = true;
					width = 14;
					height = 24;
					buffType = 178;
					buffTime = 4 * 3600;
					toolTip = "Increases item grab range";
					value = 1000;
					rare = 3;
					break;

				case 3784:
					name = "Obsidian Rose Shield";
					width = 28;
					height = 40;
					rare = 6;
					value = Item.sellPrice(0, 3, 0, 0);
					accessory = true;
					toolTip = "Reduces damage from touching lava";
					toolTip2 = "Grants immunity to fire blocks and knockback";
					break;

				case 3785:
					name = "Bronze Pickaxe";
					width = height = 32;
					autoReuse = melee = useTurn = true;
					pick = 35;
					useAnimation = 21;
					useTime = 14;
					UseSound = SoundID.Item1;
					value = 750;
					damage = 5;
					scale = 0.75f;
					knockBack = 2f;
					break;

				case 3786:
					name = "Bronze Axe";
					width = height = 30;
					autoReuse = melee = useTurn = true;
					axe = 8;
					useAnimation = 28;
					useTime = 20;
					UseSound = SoundID.Item1;
					value = 700;
					damage = 3;
					scale = 1.05f;
					knockBack = 4f;
					break;

				case 3787:
					name = "Bronze Hammer";
					width = height = 30;
					autoReuse = melee = useTurn = true;
					hammer = 39;
					useAnimation = 31;
					useTime = 21;
					UseSound = SoundID.Item1;
					value = 700;
					damage = 7;
					scale = 1.2f;
					knockBack = 4.5f;
					break;

				case 3788:
					name = "Bronze Broadsword";
					width = height = 28;
					melee = true;
					useAnimation = 23;
					useTime = 23;
					UseSound = SoundID.Item1;
					value = 900;
					damage = 7;
					scale = 1.1f;
					knockBack = 5.2f;
					break;

				case 3789:
					name = "Bronze Shortsword";
					width = height = 30;
					melee = useTurn = true;
					useAnimation = 13;
					useTime = 13;
					UseSound = SoundID.Item1;
					useStyle = 3;
					value = 900;
					damage = 7;
					knockBack = 5.2f;
					break;

				case 3790:
					name = "Bronze Bow";
					width = height = 18;
					ranged = noMelee = true;
					useAnimation = useTime = 29;
					UseSound = SoundID.Item5;
					shoot = useAmmo = 1;
					shootSpeed = 6f;
					value = 1500;
					damage = 7;
					break;

				case 3791:
					name = "Bronze Helmet";
					width = 24;
					height = 24;
					defense = 2;
					headSlot = 211;
					value = Item.sellPrice(0, 0, 0, 40);
					break;

				case 3792:
					name = "Bronze Chainmail";
					width = 24;
					height = 24;
					defense = 2;
					bodySlot = 208;
					value = Item.sellPrice(0, 0, 0, 50);
					break;

				case 3793:
					name = "Bronze Greaves";
					width = 24;
					height = 24;
					defense = 2;
					legSlot = 140;
					value = Item.sellPrice(0, 0, 0, 40);
					break;

				case 3794:
					name = "Bronze Ore";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = useTurn = autoReuse = true;
					createTile = 492;
					maxStack = 999;
					width = height = 12;
					value = Item.sellPrice(0, 0, 0, 80);
					break;

				case 3795:
					name = "Bronze Bar";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = useTurn = autoReuse = true;
					createTile = 239;
					placeStyle = 39;
					maxStack = 999;
					width = height = 20;
					value = Item.sellPrice(0, 0, 2, 40);
					break;

				case 3796:
					name = "Bronze Watch";
					width = height = 26;
					accessory = true;
					toolTip = "Tells the time";
					value = 1500;
					break;

				case 3797:
					name = "Bronze Brick";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = useTurn = autoReuse = true;
					createTile = 497;
					maxStack = 999;
					width = height = 12;
					value = 0;
					break;

				case 3798:
					name = "Bronze Brick Wall";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = useTurn = autoReuse = true;
					createWall = 224;
					maxStack = 999;
					width = height = 12;
					value = 0;
					break;

				case 3799:
					name = "Nickel Pickaxe";
					width = height = 32;
					autoReuse = melee = useTurn = true;
					pick = 44;
					useAnimation = 19;
					useTime = 12;
					UseSound = SoundID.Item1;
					value = 850;
					damage = 6;
					scale = 1f;
					knockBack = 2f;
					break;

				case 3800:
					name = "Nickel Axe";
					width = height = 30;
					autoReuse = melee = useTurn = true;
					axe = 10;
					useAnimation = 26;
					useTime = 18;
					UseSound = SoundID.Item1;
					value = 800;
					damage = 4;
					scale = 1.05f;
					knockBack = 4f;
					break;

				case 3801:
					name = "Nickel Hammer";
					width = height = 30;
					autoReuse = melee = useTurn = true;
					hammer = 45;
					useAnimation = 27;
					useTime = 17;
					UseSound = SoundID.Item1;
					value = 800;
					damage = 8;
					scale = 1.22f;
					knockBack = 4.5f;
					break;

				case 3802:
					name = "Nickel Broadsword";
					width = height = 28;
					melee = true;
					useAnimation = 21;
					useTime = 21;
					UseSound = SoundID.Item1;
					value = 1000;
					damage = 11;
					scale = 1.15f;
					knockBack = 5.2f;
					break;

				case 3803:
					name = "Nickel Shortsword";
					width = height = 30;
					melee = useTurn = true;
					useAnimation = 11;
					useTime = 11;
					UseSound = SoundID.Item1;
					useStyle = 3;
					value = 1000;
					damage = 9;
					knockBack = 5.2f;
					break;

				case 3804:
					name = "Nickel Bow";
					width = height = 18;
					ranged = noMelee = true;
					useAnimation = useTime = 27;
					UseSound = SoundID.Item5;
					shoot = useAmmo = 1;
					shootSpeed = 6.5f;
					value = 1700;
					damage = 10;
					break;

				case 3805:
					name = "Nickel Helmet";
					width = 24;
					height = 24;
					defense = 3;
					headSlot = 212;
					value = Item.sellPrice(0, 0, 0, 60);
					break;

				case 3806:
					name = "Nickel Chainmail";
					width = 24;
					height = 24;
					defense = 3;
					bodySlot = 209;
					value = Item.sellPrice(0, 0, 0, 70);
					break;

				case 3807:
					name = "Nickel Greaves";
					width = 24;
					height = 24;
					defense = 3;
					legSlot = 141;
					value = Item.sellPrice(0, 0, 0, 50);
					break;

				case 3808:
					name = "Nickel Ore";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = useTurn = autoReuse = true;
					createTile = 493;
					maxStack = 999;
					width = height = 12;
					value = Item.sellPrice(0, 0, 0, 90);
					break;

				case 3809:
					name = "Nickel Bar";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = useTurn = autoReuse = true;
					createTile = 239;
					placeStyle = 40;
					maxStack = 999;
					width = height = 20;
					value = Item.sellPrice(0, 0, 2, 70);
					break;

				case 3810:
					name = "Nickel Anvil";
					useStyle = 1;
					useTurn = autoReuse = consumable = true;
					useAnimation = 15;
					useTime = 10;
					maxStack = 99;
					createTile = 16;
					placeStyle = 2;
					width = 28;
					height = 14;
					value = 5000;
					toolTip = "Used to craft items from metal bars";
					break;

				case 3811:
					name = "Nickel Fence";
					useStyle = 1;
					useTurn = autoReuse = consumable = true;
					useAnimation = 15;
					useTime = 7;
					maxStack = 999;
					createWall = 226;
					width = height = 12;
					break;

				case 3812:
					name = "Nickel Door";
					useStyle = 1;
					useTurn = consumable = true;
					useAnimation = 15;
					useTime = 10;
					maxStack = 99;
					placeStyle = 4;
					createTile = 485;
					width = 14;
					height = 28;
					value = 200;
					break;

				case 3813:
					name = "Nickel Brick";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = useTurn = autoReuse = true;
					createTile = 498;
					maxStack = 999;
					width = height = 12;
					value = 0;
					break;

				case 3814:
					name = "Nickel Brick Wall";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = useTurn = autoReuse = true;
					createWall = 225;
					maxStack = 999;
					width = height = 12;
					value = 0;
					break;

				case 3815:
					name = "Zinc Pickaxe";
					width = height = 32;
					autoReuse = melee = useTurn = true;
					pick = 53;
					useAnimation = 14;
					useTime = 10;
					UseSound = SoundID.Item1;
					value = 1500;
					damage = 6;
					knockBack = 2f;
					break;

				case 3816:
					name = "Zinc Axe";
					width = height = 30;
					autoReuse = melee = useTurn = true;
					axe = 11;
					useAnimation = 25;
					useTime = 17;
					UseSound = SoundID.Item1;
					value = 1500;
					damage = 4;
					scale = 1.05f;
					knockBack = 4f;
					break;

				case 3817:
					name = "Zinc Hammer";
					width = height = 30;
					autoReuse = melee = useTurn = true;
					hammer = 39;
					useAnimation = 28;
					useTime = 18;
					UseSound = SoundID.Item1;
					value = 1500;
					damage = 9;
					scale = 1.2f;
					knockBack = 4.5f;
					break;

				case 3818:
					name = "Zinc Broadsword";
					width = height = 28;
					melee = true;
					useAnimation = 23;
					useTime = 23;
					UseSound = SoundID.Item1;
					value = 1500;
					damage = 13;
					scale = 1.12f;
					knockBack = 5.2f;
					break;

				case 3819:
					name = "Zinc Shortsword";
					width = height = 30;
					melee = useTurn = true;
					useAnimation = 10;
					useTime = 10;
					UseSound = SoundID.Item1;
					useStyle = 3;
					value = 1700;
					damage = 9;
					knockBack = 4f;
					break;

				case 3820:
					name = "Zinc Bow";
					width = height = 18;
					ranged = noMelee = true;
					useAnimation = useTime = 25;
					UseSound = SoundID.Item5;
					shoot = useAmmo = 1;
					shootSpeed = 6.5f;
					value = 1700;
					damage = 10;
					break;

				case 3821:
					name = "Zinc Helmet";
					width = 24;
					height = 24;
					defense = 4;
					headSlot = 213;
					value = Item.sellPrice(0, 0, 1, 75);
					break;

				case 3822:
					name = "Zinc Chainmail";
					width = 24;
					height = 24;
					defense = 5;
					bodySlot = 210;
					value = Item.sellPrice(0, 0, 1, 75);
					break;

				case 3823:
					name = "Zinc Greaves";
					width = 24;
					height = 24;
					defense = 4;
					legSlot = 142;
					value = Item.sellPrice(0, 0, 1, 75);
					break;

				case 3824:
					name = "Zinc Ore";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = useTurn = autoReuse = true;
					createTile = 494;
					maxStack = 999;
					width = height = 12;
					value = Item.sellPrice(0, 0, 1, 0);
					break;

				case 3825:
					name = "Zinc Bar";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = useTurn = autoReuse = true;
					createTile = 239;
					placeStyle = 41;
					maxStack = 999;
					width = height = 20;
					value = Item.sellPrice(0, 0, 4, 0);
					break;

				case 3826:
					name = "Zinc Watch";
					width = height = 26;
					accessory = true;
					toolTip = "Tells the time";
					value = 1500;
					break;

				case 3827:
					name = "Zinc Brick";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = useTurn = autoReuse = true;
					createTile = 499;
					maxStack = 999;
					width = height = 12;
					value = 0;
					break;

				case 3828:
					name = "Zinc Brick Wall";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = useTurn = autoReuse = true;
					createWall = 227;
					maxStack = 999;
					width = height = 12;
					value = 0;
					break;

				case 3829:
					name = "Bismuth Pickaxe";
					width = height = 32;
					autoReuse = melee = useTurn = true;
					pick = 62;
					useAnimation = 14;
					useTime = 10;
					UseSound = SoundID.Item1;
					value = 4500;
					damage = 6;
					knockBack = 2f;
					break;

				case 3830:
					name = "Bismuth Axe";
					width = height = 30;
					autoReuse = melee = useTurn = true;
					axe = 12;
					useAnimation = 25;
					useTime = 17;
					UseSound = SoundID.Item1;
					value = 4500;
					damage = 4;
					scale = 1.05f;
					knockBack = 4f;
					break;

				case 3831:
					name = "Bismuth Hammer";
					width = height = 30;
					autoReuse = melee = useTurn = true;
					hammer = 61;
					useAnimation = 28;
					useTime = 18;
					UseSound = SoundID.Item1;
					value = 4500;
					damage = 11;
					scale = 1.2f;
					knockBack = 4.5f;
					break;

				case 3832:
					name = "Bismuth Broadsword";
					width = height = 28;
					melee = true;
					useAnimation = 18;
					useTime = 18;
					UseSound = SoundID.Item1;
					value = 4500;
					damage = 16;
					scale = 1.2f;
					knockBack = 5.2f;
					break;

				case 3833:
					name = "Bismuth Shortsword";
					width = height = 30;
					melee = useTurn = true;
					useAnimation = 10;
					useTime = 10;
					UseSound = SoundID.Item1;
					useStyle = 3;
					value = 4600;
					damage = 14;
					knockBack = 4f;
					break;

				case 3834:
					name = "Bismuth Bow";
					width = height = 18;
					ranged = noMelee = true;
					useAnimation = useTime = 20;
					UseSound = SoundID.Item5;
					shoot = useAmmo = 1;
					shootSpeed = 8f;
					value = 4600;
					damage = 12;
					break;

				case 3835:
					name = "Bismuth Helmet";
					width = 24;
					height = 24;
					defense = 5;
					headSlot = 214;
					value = Item.sellPrice(0, 0, 9, 75);
					break;

				case 3836:
					name = "Bismuth Chainmail";
					width = 24;
					height = 24;
					defense = 5;
					bodySlot = 211;
					value = Item.sellPrice(0, 0, 9, 75);
					break;

				case 3837:
					name = "Bismuth Greaves";
					width = 24;
					height = 24;
					defense = 5;
					legSlot = 143;
					value = Item.sellPrice(0, 0, 9, 75);
					break;

				case 3838:
					name = "Bismuth Ore";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = useTurn = autoReuse = true;
					createTile = 495;
					maxStack = 999;
					width = height = 12;
					value = Item.sellPrice(0, 0, 2);
					break;

				case 3839:
					name = "Bismuth Bar";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = useTurn = autoReuse = true;
					createTile = 239;
					placeStyle = 42;
					maxStack = 999;
					width = height = 20;
					value = Item.sellPrice(0, 0, 8);
					break;

				case 3840:
					name = "Bismuth Watch";
					width = height = 26;
					accessory = true;
					toolTip = "Tells the time";
					value = 1500;
					break;

				case 3841:
					name = "Bismuth Brick";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = useTurn = autoReuse = true;
					createTile = 500;
					maxStack = 999;
					width = height = 12;
					value = 0;
					break;

				case 3842:
					name = "Bismuth Brick Wall";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = useTurn = autoReuse = true;
					createWall = 228;
					maxStack = 999;
					width = height = 12;
					value = 0;
					break;

				case 3843:
					name = "Iridium Pickaxe";
					width = height = 34;
					autoReuse = melee = useTurn = true;
					pick = 85;
					useTime = useAnimation = 15;
					UseSound = SoundID.Item1;
					toolTip = "Can mine Hellstone";
					value = Item.sellPrice(0, 1, 0, 0);
					rare = 4;
					crit = 4;
					damage = 15;
					knockBack = 2.6f;
					break;

				case 3844:
					name = "Iridium Hamaxe";
					width = height = 34;
					autoReuse = melee = useTurn = true;
					axe = 22;
					hammer = 75;
					useAnimation = useTime = 13;
					scale = 1.2f;
					UseSound = SoundID.Item1;
					value = 50000;
					rare = 4;
					crit = 4;
					damage = 20;
					knockBack = 2.5f;
					break;

				case 3845:
					name = "Iridium Greatsword";
					width = height = 44;
					autoReuse = melee = useTurn = true;
					useAnimation = useTime = 18;
					scale = 1.4f;
					UseSound = SoundID.Item1;
					value = 50000;
					crit = 6;
					rare = 4;
					damage = 30;
					knockBack = 5.4f;
					break;

				case 3846:
					name = "Iridium Longbow";
					UseSound = SoundID.Item5;
					useAnimation = useTime = 16;
					useTurn = ranged = true;
					damage = 25;
					width = 18;
					height = 32;
					knockBack = 2f;
					shoot = useAmmo = 1;
					value = 25000;
					rare = 4;
					shootSpeed = 10f;
					break;

				case 3847:
					name = "Iridium Ore";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = useTurn = autoReuse = true;
					createTile = 496;
					maxStack = 999;
					width = height = 12;
					value = Item.sellPrice(0, 0, 5);
					rare = 3;
					break;

				case 3848:
					name = "Iridium Bar";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = useTurn = autoReuse = true;
					createTile = 239;
					placeStyle = 43;
					maxStack = 999;
					width = height = 20;
					value = Item.sellPrice(0, 0, 20);
					rare = 3;
					break;

				case 3849:
					name = "Iridium Hat";
					width = 20;
					height = 28;
					defense = 7;
					headSlot = 215;
					rare = 4;
					value = Item.sellPrice(0, 1, 20);
					toolTip = "14% increased melee damage and speed";
					toolTip2 = "11% increased ranged damage";
					break;

				case 3850:
					name = "Iridium Platemail";
					width = 26;
					height = 22;
					defense = 9;
					bodySlot = 212;
					rare = 4;
					value = Item.sellPrice(0, 1, 40);
					toolTip = "Increases maximum mana by 50";
					break;

				case 3851:
					name = "Iridium Pants";
					width = 22;
					height = 18;
					defense = 8;
					legSlot = 144;
					rare = 4;
					value = Item.sellPrice(0, 1, 30);
					toolTip = "15% increased magic damage";
					break;

				case 3852:
					name = "Iridium Brick";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = useTurn = autoReuse = true;
					createTile = 501;
					maxStack = 999;
					width = height = 12;
					value = 0;
					break;

				case 3853:
					name = "Iridium Brick Wall";
					useStyle = 1;
					useAnimation = 15;
					useTime = 10;
					consumable = useTurn = autoReuse = true;
					createWall = 229;
					maxStack = 999;
					width = height = 12;
					value = 0;
					break;

				case 3854:
					name = "Zinc Bullet";
					shootSpeed = 4.5f;
					shoot = 14;
					damage = 9;
					width = height = 8;
					maxStack = 2000;
					consumable = true;
					ammo = 14;
					knockBack = 3f;
					value = 15;
					ranged = true;
					break;

				case 3855:
					name = "Bismuth Crown";
					width = height = 18;
					headSlot = 216;
					value = 15000;
					vanity = true;
					break;

				case 3856:
					name = "Bronze Staff";
					mana = 5;
					UseSound = SoundID.Item43;
					useStyle = 5;
					damage = 17;
					useAnimation = useTime = 36;
					width = height = 40;
					shoot = 123;
					shootSpeed = 7.5f;
					knockBack = 4f;
					value = 4000;
					magic = true;
					rare = 1;
					noMelee = true;
					break;

				case 3857:
					name = "Zinc Staff";
					mana = 5;
					UseSound = SoundID.Item43;
					useStyle = 5;
					damage = 21;
					useAnimation = useTime = 30;
					width = height = 40;
					shoot = 123;
					shootSpeed = 7.5f;
					knockBack = 4f;
					value = 20000;
					magic = true;
					rare = 1;
					noMelee = true;
					autoReuse = true;
					break;

				case 3858:
					name = "Bismuth Staff";
					mana = 5;
					UseSound = SoundID.Item43;
					useStyle = 5;
					damage = 27;
					useAnimation = useTime = 24;
					width = height = 40;
					shoot = 123;
					shootSpeed = 7.5f;
					knockBack = 4f;
					value = 20000;
					magic = true;
					rare = 3;
					noMelee = true;
					autoReuse = true;
					break;

				case 3859:
					name = "Wall of Steel Trophy";
					useStyle = 1;
					useTurn = autoReuse = consumable = true;
					useAnimation = 15;
					useTime = 10;
					maxStack = 99;
					createTile = 240;
					width = height = 30;
					placeStyle = 62;
					rare = 8;
					value = Item.sellPrice(0, 1);
					break;

				case 3872:
					name = "Mechasting Trophy";
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					maxStack = 99;
					consumable = true;
					createTile = 240;
					width = 30;
					height = 30;
					value = Item.sellPrice(0, 1, 0, 0);
					placeStyle = 63;
					rare = 1;
					break;
			}
			if (offsetType >= 2779 && offsetType <= 2787) {
				name = "Monster Banner 2";
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				autoReuse = true;
				maxStack = 999;
				consumable = true;
				createTile = 91;
				placeStyle = 109 + offsetType - 2779;
				width = 10;
				height = 24;
				value = 1000;
				rare = 1;
			}

			if (offsetType >= 2790 && offsetType <= 2815) {
				name = "Monster Banner 3";
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				autoReuse = true;
				maxStack = 999;
				consumable = true;
				createTile = 91;
				placeStyle = 118 + offsetType - 2790;
				width = 10;
				height = 24;
				value = 1000;
				rare = 1;
			}

			if (offsetType >= 2890 && offsetType <= 2899) {
				name = "Monster Banner 4";
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				autoReuse = true;
				maxStack = 999;
				consumable = true;
				createTile = 91;
				placeStyle = 144 + offsetType - 2890;
				width = 10;
				height = 24;
				value = 1000;
				rare = 1;
			}

			if (offsetType >= 2925 && offsetType <= 2930) {
				name = "Phasecleavers";
				damage = 80;
				melee = true;
				width = height = 40;
				scale = 1.2f;
				UseSound = SoundID.Item15;
				useAnimation = useTime = 20;
				knockBack = 5.25f;
				rare = 7;
				value = 70000;
				useTurn = autoReuse = true;
				useStyle = 1;
			}

			if (offsetType >= 2932 && offsetType <= 2939) {
				name = "Monster Banner 5";
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				autoReuse = true;
				maxStack = 999;
				consumable = true;
				createTile = 91;
				placeStyle = 154 + offsetType - 2932;
				width = 10;
				height = 24;
				value = 1000;
				rare = 1;
			}

			if (offsetType >= 3035 && offsetType <= 3041) {
				name = "Monster Banner 6";
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				autoReuse = true;
				maxStack = 999;
				consumable = true;
				createTile = 91;
				placeStyle = 162 + offsetType - 3035;
				width = 10;
				height = 24;
				value = 1000;
				rare = 1;
			}

			if (offsetType >= 3045 && offsetType <= 3059) {
				if (offsetType == 3048 || offsetType == 3049)
					toolTip = "Compound of the five elements";
				if (offsetType == 3050) {
					useStyle = 1;
					useTurn = true;
					useAnimation = 15;
					useTime = 10;
					autoReuse = true;
					consumable = true;
					createTile = 458;
					toolTip = "Very fine!";

					if (offsetType == 3052 || offsetType == 3053)
						toolTip = "Part of a beast's body";
					if (offsetType == 3054 || offsetType == 3046)
						toolTip = "A mystical object containing an unknown force";
					name = "Mystical Tome Materials";
					width = height = 20;
					rare = 2;
					value = Item.sellPrice(0, 0, 2, 0);
					maxStack = 999;
				}
			}

			if (offsetType >= 3170 && offsetType <= 3178) {
				name = "Elemental Shards Lv2";
				width = height = 20;
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				autoReuse = true;
				maxStack = 999;
				consumable = true;
				createTile = 385;
				placeStyle = offsetType - 3170;
				value = Item.sellPrice(0, 0, 12, 0);
				switch (offsetType) {
					case 3170:
						toolTip = "'A fragment of fiery creatures'";
						rare = 4;
						break;

					case 3171:
						toolTip = "'A fragment of icy creatures'";
						rare = 5;
						break;

					case 3172:
						toolTip = "'A fragment of venomous creatures'";
						rare = 2;
						break;

					case 3173:
						toolTip = "'A fragment of deep earth creatures'";
						rare = 1;
						break;

					case 3174:
						toolTip = "'A fragment of flying creatures'";
						rare = 2;
						break;

					case 3175:
						toolTip = "'A fragment of undead creatures'";
						rare = 1;
						break;

					case 3176:
						toolTip = "'A fragment of water creatures'";
						rare = 3;
						break;

					case 3177:
						toolTip = "'A fragment of wicked creatures'";
						rare = 1;
						break;

					case 3178:
						toolTip = "'A fragment of hallow creatures'";
						rare = 6;
						break;

					case 3188:
						name = "Tome Forge";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						rare = 3;
						toolTip = "Used to craft Mystical Tomes";
						value = Item.sellPrice(0, 1, 0, 0);
						createTile = 386;
						width = 30;
						height = 30;
						break;

					case 3189:
						name = "Blah's Picksaw";
						useStyle = 1;
						useAnimation = 7;
						useTime = 7;
						knockBack = 7f;
						useTurn = true;
						autoReuse = true;
						width = 20;
						height = 12;
						damage = 50;
						pick = 425;
						axe = 50;
						UseSound = SoundID.Item1;
						rare = 10;
						value = 1016000;
						melee = true;
						scale = 1.15f;
						tileBoost += 6;
						toolTip = "The user can mine at warp speed";
						break;

					case 3190:
						name = "Blah's Warhammer";
						useStyle = 1;
						useAnimation = 9;
						useTime = 9;
						knockBack = 20f;
						useTurn = true;
						autoReuse = true;
						width = 40;
						height = 38;
						damage = 80;
						hammer = 250;
						UseSound = SoundID.Item1;
						rare = 10;
						value = 1016000;
						melee = true;
						scale = 1.15f;
						tileBoost += 6;
						toolTip = "You shouldn't have this";
						break;

					case 3191:
						name = "Phantom Mask";
						width = 20;
						height = 28;
						headSlot = 187;
						vanity = true;
						rare = 9;
						value = Item.sellPrice(0, 1, 10, 0);
						break;

					case 3192:
						name = "Phantom Shirt";
						width = 26;
						height = 22;
						bodySlot = 191;
						vanity = true;
						rare = 9;
						value = Item.sellPrice(0, 1, 20, 0);
						break;

					case 3193:
						name = "Phantom Pants";
						width = 22;
						height = 18;
						legSlot = 126;
						vanity = true;
						rare = 9;
						value = Item.sellPrice(0, 1, 0, 0);
						break;

					case 3195:
						name = "Elektriwave";
						useStyle = 1;
						useAnimation = 15;
						useTime = 15;
						knockBack = 6f;
						useTurn = true;
						autoReuse = true;
						width = 54;
						height = 34;
						damage = 106;
						UseSound = SoundID.Item1;
						rare = 10;
						value = 616000;
						melee = true;
						scale = 1;
						toolTip = "Has a chance to inflict Electrified";
						break;

					case 3196:
						name = "Superhardmode Bar";
						width = 18;
						height = 18;
						maxStack = 999;
						value = Item.sellPrice(0, 1, 30, 0);
						rare = 8;
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						consumable = true;
						createTile = 239;
						placeStyle = 36;
						break;

					case 3197:
						name = "Electrobullet";
						shootSpeed = 5.25f;
						shoot = 496;
						damage = 13;
						width = 8;
						height = 8;
						maxStack = 2000;
						consumable = true;
						ammo = 14;
						knockBack = 5f;
						rare = 10;
						value = 400;
						ranged = true;
						break;

					case 3198:
						rare = 8;
						UseSound = SoundID.Item1;
						name = "Soul Edge";
						useStyle = 1;
						damage = 93;
						useAnimation = 20;
						noMelee = false;
						useTime = 20;
						width = 30;
						height = 30;
						shoot = 297;
						scale = 1.1f;
						shootSpeed = 4f;
						knockBack = 6.5f;
						toolTip = "'Haunted by souls of darkness'";
						melee = true;
						value = Item.sellPrice(0, 80, 0, 0);
						autoReuse = true;
						break;

					case 3199:
						name = "Sand Castle";
						width = 48;
						height = 34;
						useAnimation = 20;
						useTime = 20;
						consumable = true;
						maxStack = 99;
						createTile = 388;
						useStyle = 1;
						rare = 1;
						break;

					case 3200:
						name = "Miner's Pickaxe";
						useStyle = 1;
						useAnimation = 19;
						useTime = 18;
						knockBack = 3.5f;
						useTurn = true;
						autoReuse = true;
						width = 20;
						height = 12;
						damage = 10;
						pick = 60;
						UseSound = SoundID.Item1;
						rare = 4;
						value = 16000;
						melee = true;
						scale = 1f;
						tileBoost++;
						break;

					case 3201:
						rare = 4;
						UseSound = SoundID.Item1;
						name = "Miner's Sword";
						useStyle = 1;
						damage = 20;
						useAnimation = 23;
						useTime = 23;
						width = 30;
						height = 30;
						scale = 1.2f;
						knockBack = 5.5f;
						melee = true;
						value = Item.sellPrice(0, 1, 0, 0);
						autoReuse = true;
						break;

					case 3202:
						name = "Aegis Dash";
						width = height = 26;
						accessory = true;
						damage = 70;
						knockBack = 10f;
						value = Item.sellPrice(0, 7, 0, 0);
						rare = 8;
						worksInVanity = true;
						toolTip = "Dash into enemies to damage them";
						toolTip2 = "Works in the vanity slot";
						shieldSlot = 6;
						break;

					case 3203:
						name = "Abeel's Helmet";
						width = 32;
						height = 26;
						defense = 50;
						value = Item.sellPrice(1, 0, 0, 0);
						toolTip = "29% increased damage";
						toolTip2 = "10% increased critical strike chance";
						headSlot = 188;
						rare = 10;
						break;

					case 3204:
						name = "Abeel's Bodyarmor";
						width = 38;
						height = 20;
						defense = 50;
						value = Item.sellPrice(1, 0, 0, 0);
						toolTip = "30% decreased mana usage and increases your max number of minions by 6";
						toolTip2 = "Increases maximum mana by 500";
						bodySlot = 192;
						rare = 10;
						break;

					case 3205:
						name = "Abeel's Cuisses";
						width = 22;
						height = 18;
						defense = 50;
						value = Item.sellPrice(1, 0, 0, 0);
						toolTip = "Melee weapons have a chance to instantly kill mobs | Teleportation to the";
						toolTip2 = "Ranged projectiles have a chance to split in two | cursor is enabled";
						legSlot = 127;
						rare = 10;
						break;

					case 3206:
						name = "Abeel's Wings";
						width = 32;
						height = 28;
						rare = 9;
						defense = 4;
						wingSlot = 29;
						value = Item.sellPrice(1, 0, 0, 0);
						accessory = true;
						toolTip = "Allows flight and slow fall and the wearer can run incredibly fast";
						toolTip2 = "The wearer has a chance to dodge attacks and negates fall damage";
						break;

					case 3207:
						name = "Titan Gauntlets";
						width = 26;
						height = 30;
						accessory = true;
						value = Item.sellPrice(0, 30, 0, 0);
						rare = 12;
						defense = 14;
						handOnSlot = 19;
						handOffSlot = 12;
						toolTip = "Attacks inflict Frostburn, increases damage and melee speed by 9%, reduces team member damage (only active above 25% HP)";
						toolTip2 = "Increases knockback, reduces dmg when below 25% HP, [+15 defense, +3 life regeneration, +15% damage] (Only when below 33% HP)";
						break;

					case 3208:
						name = "Oblivirod";
						useStyle = 1;
						useAnimation = 8;
						useTime = 8;
						width = 24;
						height = 28;
						UseSound = SoundID.Item1;
						shoot = 382;
						fishingPole = 110;
						shootSpeed = 15.5f;
						rare = 12;
						value = Item.sellPrice(0, 40, 0, 0);
						break;

					case 3209:
						name = "Platinum Crate";
						width = 12;
						height = 12;
						rare = 5;
						toolTip = "Right click to open";
						maxStack = 99;
						value = Item.sellPrice(0, 4, 0, 0);
						break;

					case 3210:
						name = "Spore Block";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createTile = 389;
						width = 12;
						height = 12;
						break;

					case 3211:
						name = "Gastropod Staff";
						useStyle = 1;
						shootSpeed = 14f;
						shoot = 498;
						damage = 40;
						width = 38;
						height = 36;
						UseSound = SoundID.Item44;
						buffType = 157;
						useAnimation = 30;
						useTime = 30;
						noMelee = true;
						value = Item.sellPrice(0, 1, 0, 0);
						knockBack = 4.5f;
						rare = 5;
						summon = true;
						mana = 13;
						break;

					case 3212:
						name = "Quack";
						width = 18;
						height = 18;
						useTurn = true;
						useTime = 30;
						useAnimation = 30;
						noUseGraphic = true;
						useStyle = 10;
						rare = 12;
						toolTip = "'May annoy others'";
						value = 100;
						break;

					case 3213:
						useStyle = 2;
						UseSound = SoundID.Item3;
						name = "Blah Potion";
						rare = 12;
						consumable = false;
						maxStack = 1;
						useTime = 15;
						useAnimation = 15;
						width = 18;
						height = 22;
						toolTip = "Various effects";
						buffType = 158;
						buffTime = 1080000;
						break;

					case 3214:
						name = "Santa's Beard";
						width = 18;
						height = 12;
						maxStack = 1;
						value = Item.buyPrice(0, 40, 0, 0);
						rare = 7;
						accessory = true;
						faceSlot = 9;
						vanity = true;
						break;

					case 3215:
						name = "Candy Cane";
						UseSound = SoundID.Item2;
						healLife = 60;
						useStyle = 2;
						useTurn = true;
						useAnimation = 15;
						useTime = 15;
						maxStack = 70;
						consumable = true;
						width = 14;
						height = 24;
						potion = true;
						value = 100;
						break;

					case 3216:
						name = "Chocolate Candy Cane Block";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createTile = 390;
						width = 12;
						height = 12;
						break;

					case 3217:
						name = "Chocolate Candy Cane Wall";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createWall = 185;
						width = 12;
						height = 12;
						break;

					case 3218:
						name = "Red Present";
						maxStack = 999;
						consumable = true;
						width = 12;
						height = 28;
						rare = 3;
						toolTip = "Right click to open";
						break;

					case 3219:
						name = "Sack of Toys";
						useStyle = 1;
						shootSpeed = 14f;
						shoot = 1;
						damage = 45;
						width = 38;
						height = 36;
						color = Color.Red;
						UseSound = SoundID.Item1;
						//channel = true;
						useAnimation = 24;
						useTime = 24;
						noMelee = true;
						value = Item.sellPrice(0, 1, 0, 0);
						knockBack = 4.5f;
						rare = 5;
						ranged = true;
						break;

					case 3220:
						name = "Dungeon Brick Wands";
						wallWand = 135;
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						createWall = 7;
						width = 8;
						height = 10;
						rare = 1;
						toolTip = "Places unsafe blue dungeon walls";
						break;

					case 3221:
						name = "Green Dungeon Wand";
						wallWand = 138;
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 7;
						autoReuse = true;
						createWall = 8;
						width = 8;
						height = 10;
						rare = 1;
						toolTip = "Places unsafe green dungeon walls";
						break;

					case 3222:
						name = "Pink Dungeon Wand";
						wallWand = 140;
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 7;
						autoReuse = true;
						createWall = 9;
						width = 8;
						height = 10;
						rare = 1;
						toolTip = "Places unsafe pink dungeon walls";
						break;

					case 3223:
						name = "Orange Dungeon Wand";
						wallWand = 2837;
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 7;
						autoReuse = true;
						createWall = 172;
						width = 8;
						height = 10;
						rare = 1;
						toolTip = "Places unsafe orange dungeon walls";
						break;

					case 3224:
						name = "Unvolandite Ore";
						width = height = 12;
						createTile = 391;
						useAnimation = 15;
						useTime = 10;
						useStyle = 1;
						useTurn = true;
						autoReuse = true;
						consumable = true;
						value = Item.sellPrice(0, 0, 50, 0);
						maxStack = 999;
						rare = 9;
						break;

					case 3225:
						name = "Vorazylcum Ore";
						width = height = 14;
						createTile = 392;
						useAnimation = 15;
						useTime = 10;
						useStyle = 1;
						useTurn = true;
						autoReuse = true;
						consumable = true;
						value = Item.sellPrice(0, 0, 50, 0);
						maxStack = 999;
						rare = 9;
						break;

					case 3226:
						name = "Unvolandite Bar";
						width = height = 16;
						rare = 9;
						value = Item.sellPrice(0, 2, 50, 0);
						maxStack = 999;
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						consumable = true;
						createTile = 239;
						placeStyle = 27;
						break;

					case 3227:
						name = "Vorazylcum Bar";
						width = height = 16;
						rare = 9;
						value = Item.sellPrice(0, 2, 0, 0);
						maxStack = 999;
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						consumable = true;
						createTile = 239;
						placeStyle = 28;
						break;

					case 3228:
						name = "Unvolandite Greatsword";
						width = height = 76;
						damage = 109;
						UseSound = SoundID.Item1;
						melee = autoReuse = true;
						knockBack = 7f;
						rare = 9;
						value = Item.sellPrice(0, 9, 87, 65);
						useAnimation = useTime = 22;
						break;

					case 3229:
						name = "Vorazylcum Katana";
						width = height = 56;
						damage = 111;
						UseSound = SoundID.Item1;
						melee = autoReuse = true;
						knockBack = 4f;
						rare = 10;
						value = Item.sellPrice(0, 10, 90, 0);
						useAnimation = useTime = 17;
						break;

					case 3230:
						name = "Unvolandite Picksaw";
						useStyle = 1;
						useAnimation = 9;
						useTime = 9;
						knockBack = 5.5f;
						useTurn = true;
						autoReuse = true;
						width = 20;
						height = 12;
						damage = 30;
						pick = 300;
						axe = 22;
						UseSound = SoundID.Item1;
						rare = 9;
						value = 416000;
						melee = true;
						scale = 1.15f;
						tileBoost += 5;
						break;

					case 3231:
						name = "Vorazylcum Picksaw";
						useStyle = 1;
						useAnimation = 8;
						useTime = 8;
						knockBack = 5.5f;
						useTurn = true;
						autoReuse = true;
						width = 20;
						height = 12;
						damage = 30;
						pick = 310;
						axe = 25;
						UseSound = SoundID.Item1;
						rare = 9;
						value = 516000;
						melee = true;
						scale = 1.15f;
						tileBoost += 6;
						break;

					case 3232:
						name = "Unvolandite-Kunzite Wave Staff";
						width = height = 44;
						damage = 94;
						UseSound = SoundID.Item43; // ?
						useStyle = 5;
						magic = autoReuse = noMelee = true;
						shootSpeed = 15f;
						knockBack = 3f;
						rare = 9;
						value = Item.sellPrice(0, 60, 0, 0);
						shoot = 501; //copy aqua scepter or golden shower's projectile, make dust pink
						useAnimation = useTime = 25;
						mana = 23;
						toolTip = "Sprays out a wave of showers";
						break;

					case 3233:
						name = "Vorazylcum-Kunzite Bolt Staff";
						width = height = 44;
						damage = 92;
						UseSound = SoundID.Item43;
						useStyle = 5;
						magic = autoReuse = noMelee = true;
						shootSpeed = 6f;
						knockBack = 3f;
						rare = 9;
						value = Item.sellPrice(0, 60, 0, 0);
						shoot = 500;
						useAnimation = useTime = 25;
						mana = 25;
						toolTip = "Fires a spread of magical bolts";
						break;

					case 3234:
						name = "Unvolandite Fusebow";
						width = height = 30;
						damage = 80;
						useStyle = 5;
						UseSound = SoundID.Item5;
						shoot = 502; //copy pulse bow projectile
						useAmmo = 1;
						shootSpeed = 9f;
						rare = 9;
						ranged = autoReuse = noMelee = true;
						knockBack = 5f;
						value = Item.sellPrice(0, 20, 0, 0);
						useAnimation = useTime = 15;
						toolTip = "Fires a spread of pulse arrows that explode on the final impact";
						break;

					case 3235:
						name = "Vorazylcum Fusebow";
						width = height = 30;
						damage = 84;
						useStyle = 5;
						UseSound = SoundID.Item8; // shadowbeam staff sound
						shoot = 503; //use shadowbeam staff proj
						useAmmo = 1;
						shootSpeed = 15f;
						rare = 9;
						ranged = autoReuse = noMelee = true;
						knockBack = 5f;
						value = Item.sellPrice(0, 20, 0, 0);
						useAnimation = useTime = 15;
						toolTip = "Fires a beam of energy";
						break;

					case 3236:
						name = "Unvolandite Headpiece";
						width = 28;
						height = 26;
						defense = 32;
						headSlot = 189;
						rare = 9;
						value = Item.sellPrice(0, 50, 0, 0);
						toolTip = "16% increased damage";
						toolTip2 = "6% increased critical strike chance";
						break;

					case 3237:
						name = "Unvolandite Bodyplate";
						width = 34;
						height = 20;
						defense = 33;
						bodySlot = 193;
						rare = 9;
						value = Item.sellPrice(0, 40, 0, 0);
						toolTip = "Enemies are a lot more likely to target you";
						toolTip2 = "Minion knockback is increased by 10%";
						break;

					case 3238:
						name = "Unvolandite Leggings";
						width = 22;
						height = 18;
						defense = 32;
						legSlot = 128;
						rare = 9;
						value = Item.sellPrice(0, 30, 0, 0);
						toolTip = "Increases your max number of minions by 2";
						toolTip2 = "Increases maximum mana by 80";
						break;

					case 3239:
						name = "Vorazylcum Headpiece";
						width = 28;
						height = 26;
						defense = 33;
						headSlot = 190;
						rare = 9;
						value = Item.sellPrice(0, 50, 0, 0);
						toolTip = "20% increased damage";
						toolTip2 = "7% increased critical strike chance";
						break;

					case 3240:
						name = "Vorazylcum Bodyplate";
						width = 34;
						height = 20;
						defense = 34;
						bodySlot = 194;
						rare = 9;
						value = Item.sellPrice(0, 40, 0, 0);
						toolTip = "Enemies are a lot more likely to target you";
						toolTip2 = "Minion knockback is increased by 10%";
						break;

					case 3241:
						name = "Vorazylcum Leggings";
						width = 22;
						height = 18;
						defense = 33;
						legSlot = 129;
						rare = 9;
						value = Item.sellPrice(0, 30, 0, 0);
						toolTip = "Increases your max number of minions by 3";
						toolTip2 = "Increases maximum mana by 100";
						break;

					case 3242:
						name = "Blah's Headguard";
						width = 32;
						height = 26;
						defense = 100;
						value = Item.sellPrice(2, 0, 0, 0);
						toolTip = "35% increased damage";
						toolTip2 = "11% increased critical strike chance";
						headSlot = 176;
						rare = 12;
						break;

					case 3243:
						name = "Blah's Hauberk";
						width = 38;
						height = 20;
						defense = 100;
						value = Item.sellPrice(2, 0, 0, 0);
						toolTip = "30% decreased mana usage and increases your max number of minions by 9";
						toolTip2 = "Increases maximum mana by 800";
						bodySlot = 182;
						rare = 12;
						break;

					case 3244:
						name = "Blah's Cuisses";
						width = 22;
						height = 18;
						defense = 100;
						value = Item.sellPrice(2, 0, 0, 0);
						toolTip = "Melee weapons have a chance to instantly kill mobs | Teleportation to the";
						toolTip2 = "Ranged projectiles have a chance to split in two | cursor is enabled";
						legSlot = 117;
						rare = 12;
						break;

					case 3245:
						name = "Kunzite";
						width = 10;
						height = 14;
						value = 50000;
						maxStack = 999;
						rare = 11;
						createTile = 178;
						placeStyle = 9;
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						consumable = true;
						break;

					case 3246:
						name = "Blah's Picksaw (Tier II)";
						useStyle = 1;
						useAnimation = 6;
						useTime = 6;
						knockBack = 5.5f;
						useTurn = true;
						autoReuse = true;
						width = 20;
						height = 12;
						damage = 55;
						pick = 700;
						axe = 60;
						UseSound = SoundID.Item1;
						rare = 12;
						value = 5016000;
						melee = true;
						scale = 1.15f;
						tileBoost += 8;
						break;

					case 3247:
						name = "Unvolandite Anvil";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 395;
						width = 28;
						height = 14;
						value = 100000;
						toolTip = "Used to craft shm items";
						rare = 9;
						break;

					case 3248:
						name = "Spiked Blast Shell";
						width = 10;
						height = 14;
						value = 5000;
						maxStack = 999;
						rare = 12;
						break;

					case 3249:
						name = "Ice Gel";
						width = 10;
						height = 14;
						value = 700;
						maxStack = 999;
						rare = 0;
						break;

					case 3250:
						useStyle = 2;
						UseSound = SoundID.Item3;
						name = "Shadow Potion";
						rare = 2;
						consumable = true;
						maxStack = 100;
						useTime = 15;
						useAnimation = 15;
						width = 18;
						height = 22;
						toolTip = "Enables teleportation to the cursor";
						buffType = 159;
						buffTime = 3600 * 7;
						break;

					case 3251:
						useStyle = 1;
						name = "Sand Bomb";
						shootSpeed = 5f;
						shoot = 504;
						width = 20;
						height = 20;
						maxStack = 999;
						consumable = true;
						UseSound = SoundID.Item1;
						useAnimation = 25;
						useTime = 25;
						noUseGraphic = true;
						noMelee = true;
						value = Item.buyPrice(0, 0, 4, 0);
						damage = 0;
						toolTip = "An explosion of sand that will not destroy tiles";
						break;

					case 3252:
						name = "Torch Launcher";
						width = 38;
						height = 18;
						ranged = noMelee = true;
						shootSpeed = 8f;
						useAnimation = useTime = 16;
						value = 39000;
						damage = 0;
						shoot = 505;
						knockBack = 0f;
						useStyle = 5;
						useAmmo = 8;
						UseSound = SoundID.Item5;
						rare = 2;
						break;

					case 3253:
						name = "Chaos Dust";
						width = 10;
						height = 14;
						value = 5000;
						maxStack = 999;
						//color = new Color(255, 105, 180, 150);
						rare = 4;
						break;

					case 3254:
						name = "Quad Sunfury";
						width = 52;
						height = 48;
						useTime = useAnimation = 61;
						damage = 100;
						knockBack = 8f;
						shootSpeed = 12f;
						shoot = 0;
						noUseGraphic = noMelee = melee = channel = true;
						UseSound = SoundID.Item1;
						rare = 8;
						toolTip = "Press the N key to change modes";
						scale = 1.1f;
						value = 999000;
						useStyle = 5;
						break;

					case 3255:
						name = "Nil Shrine";
						width = 48;
						height = 34;
						useAnimation = 20;
						useTime = 20;
						consumable = true;
						maxStack = 99;
						createTile = 394;
						//placeStyle = WorldGen.crimson == true ? 1 : 0;
						useStyle = 1;
						rare = 10;
						toolTip = "'Dark lives on in this shrine'";
						break;

					case 3256:
						name = "Soul of Delight";
						width = 20;
						height = 20;
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createTile = 396;
						noUseGraphic = true;
						value = Item.sellPrice(0, 2);
						rare = 8;
						toolTip = "'The essence of the jungle'";
						break;

					case 3257:
						name = "Lightning in a Bottle";
						width = 16;
						height = 18;
						accessory = true;
						toolTip = "Lightning strikes you when damaged";
						rare = 5;
						value = Item.sellPrice(0, 1, 44, 0);
						break;

					case 3258:
						name = "Corrupt Crate";
						width = 12;
						height = 12;
						rare = 1;
						toolTip = "Right click to open";
						maxStack = 99;
						value = Item.sellPrice(0, 0, 10, 0);
						break;

					case 3259:
						name = "Flesh Crate";
						width = 12;
						height = 12;
						rare = 1;
						toolTip = "Right click to open";
						maxStack = 99;
						value = Item.sellPrice(0, 0, 10, 0);
						break;

					case 3260:
						name = "Sweetstem";
						maxStack = 999;
						width = 12;
						height = 14;
						value = 100;
						break;

					case 3261:
						name = "Sweetstem Seeds";
						useTurn = true;
						useStyle = 1;
						useAnimation = 15;
						useTime = 10;
						maxStack = 999;
						consumable = true;
						createTile = 82;
						placeStyle = 8;
						width = 12;
						height = 14;
						value = 120;
						break;

					case 3262:
						useStyle = 2;
						UseSound = SoundID.Item3;
						name = "Rogue Potion";
						rare = 3;
						consumable = true;
						maxStack = 100;
						useTime = 15;
						useAnimation = 15;
						width = 18;
						height = 22;
						toolTip = "-5% ranged damage, 20% chance to not consume ammo";
						buffType = 160;
						buffTime = (int)(3600 * 4.5);
						break;

					case 3263:
						useStyle = 2;
						UseSound = SoundID.Item3;
						name = "Gauntlet Potion";
						rare = 3;
						consumable = true;
						maxStack = 100;
						useTime = 15;
						useAnimation = 15;
						width = 18;
						height = 22;
						toolTip = "-6 defense, +12% melee damage";
						buffType = 161;
						buffTime = 3600 * 5;
						break;

					case 3264:
						useStyle = 2;
						UseSound = SoundID.Item3;
						name = "Wisdom Potion";
						rare = 3;
						consumable = true;
						maxStack = 100;
						useTime = 15;
						useAnimation = 15;
						width = 18;
						height = 22;
						toolTip = "-8% magic damage, +60 mana";
						buffType = 162;
						buffTime = 3600 * 4;
						break;

					case 3265:
						name = "Bag of Hallows";
						width = 16;
						height = 18;
						accessory = true;
						vanity = true;
						toolTip = "Hallow particles cover you when you move";
						rare = 6;
						worksInVanity = true;
						value = Item.sellPrice(0, 2, 0, 0);
						break;

					case 3266:
						name = "Guardian Boots";
						width = 16;
						height = 18;
						accessory = true;
						defense = 2;
						toolTip = "Provides immunity to traps and knockback";
						rare = 5;
						value = Item.sellPrice(0, 1, 44, 0);
						break;

					case 3267:
						useStyle = 2;
						UseSound = SoundID.Item3;
						name = "Titanskin Potion";
						rare = 4;
						consumable = true;
						maxStack = 100;
						useTime = 15;
						useAnimation = 15;
						width = 18;
						height = 22;
						toolTip = "-8% damage, +15 defense";
						buffType = 165;
						buffTime = 3600 * 4;
						break;

					case 3268:
						useStyle = 2;
						UseSound = SoundID.Item3;
						name = "Invincibility Potion";
						rare = 2;
						consumable = true;
						maxStack = 100;
						useTime = 15;
						useAnimation = 15;
						width = 18;
						height = 22;
						invince = true;
						toolTip = "Grants invincibility";
						buffType = 163;
						buffTime = 600;
						break;

					case 3269:
						name = "Moonplate Block";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createTile = 397;
						width = 12;
						height = 12;
						break;

					case 3270:
						name = "Enchanted Bar";
						width = height = 16;
						rare = 2;
						value = Item.sellPrice(0, 0, 50, 0);
						maxStack = 999;
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						consumable = true;
						createTile = 239;
						placeStyle = 37;
						break;

					case 3271:
						useStyle = 1;
						name = "Enchanted Shuriken";
						shootSpeed = 9f;
						shoot = 523;
						damage = 13;
						width = 18;
						height = 20;
						maxStack = 999;
						rare = 2;
						consumable = true;
						UseSound = SoundID.Item1;
						useAnimation = 15;
						useTime = 15;
						noUseGraphic = true;
						noMelee = true;
						value = 30;
						ranged = true;
						break;

					case 3272:
						name = "Broken Hilt Piece";
						width = height = 14;
						value = 50;
						rare = 1;
						maxStack = 999;
						break;

					case 3273:
						name = "Golden Heart";
						width = 12;
						height = 12;
						break;

					case 3274:
						name = "Golden Apple";
						width = 12;
						height = 12;
						break;

					case 3275:
						name = "Golden Candy Cane";
						width = 12;
						height = 12;
						break;

					case 3276:
						name = "Platinum Heart";
						width = 12;
						height = 12;
						break;

					case 3277:
						name = "Platinum Apple";
						width = 12;
						height = 12;
						break;

					case 3278:
						name = "Platinum Candy Cane";
						width = 12;
						height = 12;
						break;

					case 3279:
						name = "Ethereal Heart";
						width = 16;
						height = 18;
						accessory = true;
						toolTip = "Grants a 10% chance for enemies to drop a platinum heart";
						rare = 7;
						value = Item.sellPrice(0, 1, 0, 0);
						break;

					case 3280:
						name = "Heart of the Golem";
						width = 16;
						height = 18;
						accessory = true;
						toolTip = "Grants a 5% chance for enemies to drop a platinum heart";
						rare = 7;
						value = Item.sellPrice(0, 1, 0, 0);
						break;

					case 3281:
						name = "Soul of the Golem";
						width = 16;
						height = 18;
						accessory = true;
						toolTip = "Grants a 15% chance for enemies to drop a platinum heart";
						rare = 9;
						value = Item.sellPrice(0, 3, 0, 0);
						break;

					case 3282:
						name = "Earthen Insignia";
						width = 16;
						height = 18;
						accessory = true;
						toolTip = "Earth related items receive a stat boost";
						rare = 8;
						value = Item.sellPrice(0, 3, 0, 0);
						break;

					case 3283:
						name = "Cloak of Assists";
						width = 16;
						height = 18;
						accessory = true;
						toolTip = "Increases movement speed after being damaged and releases bees when injured";
						toolTip2 = "Stars fall and lightning strikes when damaged";
						rare = 8;
						value = Item.sellPrice(0, 8, 0, 0);
						break;

					case 3284:
						name = "Sunstorm";
						width = 40;
						height = 40;
						useTime = useAnimation = 60;
						damage = 50;
						knockBack = 6f;
						shootSpeed = 12f;
						shoot = 524;
						noMelee = magic = true;
						UseSound = SoundID.Item8;
						rare = 8;
						toolTip = "Fires beams from the sun itself";
						scale = 1.1f;
						value = 999000;
						useStyle = 5;
						mana = 17;
						break;

					case 3285:
						name = "Summoner Emblem";
						width = 24;
						height = 24;
						accessory = true;
						toolTip = "15% increased minion damage";
						value = 100000;
						rare = 4;
						break;

					case 3286:
						autoReuse = true;
						name = "Pumpking's Sword";
						useStyle = 1;
						useAnimation = 26;
						useTime = 26;
						knockBack = 6.5f;
						width = 66;
						height = 66;
						shoot = 526;
						shootSpeed = 9f;
						damage = 90;
						scale = 1.15f;
						UseSound = SoundID.Item1;
						rare = 9;
						value = Item.sellPrice(0, 40, 0, 0);
						melee = true;
						break;

					case 3287:
						useStyle = 2;
						UseSound = SoundID.Item3;
						name = "Bee Repellent";
						rare = 1;
						consumable = true;
						maxStack = 100;
						useTime = 15;
						useAnimation = 15;
						width = 18;
						height = 22;
						toolTip = "Provides immunity to Hornets";
						buffType = 167;
						buffTime = 3600 * 6;
						break;

					case 3288:
						useStyle = 2;
						UseSound = SoundID.Item3;
						name = "Force Field Potion";
						rare = 4;
						consumable = true;
						maxStack = 100;
						useTime = 15;
						useAnimation = 15;
						width = 18;
						height = 22;
						toolTip = "Enables a projectile-reflecting force field";
						buffType = 168;
						buffTime = 3600 * 5;
						break;

					case 3289:
						name = "Spike Cannon";
						width = 56;
						height = 24;
						damage = 50;
						knockBack = 8;
						useAnimation = 15;
						useTime = 15;
						rare = 4;
						value = Item.sellPrice(0, 5, 0, 0);
						useStyle = 5;
						UseSound = SoundID.Item11;
						autoReuse = true;
						useTurn = false;
						crit += 2;
						useAmmo = ID.ItemID.Spike;
						shoot = 527;
						shootSpeed = 15;
						noMelee = true;
						ranged = true;
						toolTip = "Uses spikes for ammo";
						toolTip2 = "'You should be careful with this'";
						break;

					case 3290:
						name = "Sandy Stormcloud in a Bottle";
						width = height = 22;
						accessory = true;
						value = Item.sellPrice(0, 3, 0, 0);
						rare = 3;
						toolTip = "The holder can quadruple jump";
						break;

					case 3291:
						name = "Tourmaline";
						width = height = 12;
						value = 3000;
						maxStack = 999;
						rare = 1;
						createTile = 178;
						placeStyle = 10;
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						consumable = true;
						break;

					case 3292:
						name = "Peridot";
						width = height = 12;
						value = 4000;
						maxStack = 999;
						rare = 1;
						createTile = 178;
						placeStyle = 11;
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						consumable = true;
						break;

					case 3293:
						name = "Tourmaline Staff";
						mana = 9;
						UseSound = SoundID.Item43;
						useStyle = 5;
						damage = 28;
						useAnimation = 28;
						useTime = 28;
						width = 40;
						height = 40;
						shoot = 528;
						shootSpeed = 7.5f;
						knockBack = 4.5f;
						magic = true;
						autoReuse = true;
						value = 35000;
						rare = 1;
						noMelee = true;
						break;

					case 3294:
						name = "Peridot Staff";
						mana = 10;
						UseSound = SoundID.Item43;
						useStyle = 5;
						damage = 30;
						useAnimation = 26;
						useTime = 26;
						width = 40;
						height = 40;
						shoot = 529;
						shootSpeed = 7.75f;
						knockBack = 4.75f;
						magic = true;
						autoReuse = true;
						value = 36000;
						rare = 1;
						noMelee = true;
						break;

					case 3295:
						name = "Darklight Lance";
						useStyle = 5;
						useAnimation = 20;
						useTime = 20;
						shootSpeed = 5.6f;
						knockBack = 6.5f;
						width = 60;
						height = 60;
						damage = 99;
						scale = 1f;
						rare = 8;
						//autoReuse = true;
						UseSound = SoundID.Item1;
						shoot = 530;
						value = Item.sellPrice(0, 40, 0, 0);
						noMelee = noUseGraphic = melee = true;
						break;

					case 3296:
						name = "Rhodium Brick";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createTile = 400;
						width = 12;
						height = 12;
						break;

					case 3297:
						name = "Rhodium Brick Wall";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createWall = 186;
						rare = 0;
						width = 12;
						height = 12;
						break;

					case 3298:
						name = "Tritanorium Ore";
						width = height = 12;
						createTile = 401;
						useAnimation = 15;
						useTime = 10;
						useStyle = 1;
						useTurn = true;
						autoReuse = true;
						consumable = true;
						value = Item.sellPrice(0, 0, 20, 0);
						maxStack = 999;
						rare = 11;
						break;

					case 3299:
						name = "Tritanorium Bar";
						width = 18;
						height = 18;
						maxStack = 999;
						value = Item.sellPrice(0, 1, 0, 0);
						rare = 11;
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						consumable = true;
						createTile = 239;
						placeStyle = 29;
						break;

					case 3300:
						rare = 11;
						UseSound = SoundID.Item1;
						name = "Tritanorium Broadsword";
						useStyle = 1;
						damage = 110;
						useTurn = true;
						useAnimation = 16;
						autoReuse = true;
						useTime = 16;
						width = 56;
						height = 56;
						scale = 1.2f;
						knockBack = 15f;
						melee = true;
						value = Item.sellPrice(0, 8, 0, 0);
						break;

					case 3301:
						rare = 12;
						UseSound = SoundID.Item1;
						name = "Blah's Energy Blade";
						useStyle = 1;
						damage = 150;
						useTurn = true;
						useAnimation = 14;
						autoReuse = true;
						useTime = 14;
						width = 56;
						height = 56;
						scale = 1.2f;
						shoot = 531;
						shootSpeed = 9f;
						knockBack = 20f;
						melee = true;
						value = Item.sellPrice(3, 0, 0, 0);
						break;

					case 3302:
						name = "Duratanium Ore";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createTile = 402;
						width = 12;
						height = 12;
						value = Item.sellPrice(0, 0, 10, 0);
						rare = 3;
						break;

					case 3303:
						name = "Duratanium Bar";
						width = 18;
						height = 18;
						maxStack = 999;
						value = Item.sellPrice(0, 0, 30, 0);
						rare = 4;
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						consumable = true;
						createTile = 239;
						placeStyle = 30;
						break;

					case 3304:
						name = "Duratanium Helmet";
						width = height = 30;
						rare = 4;
						headSlot = 191;
						value = Item.sellPrice(0, 1, 40, 0);
						toolTip = "5% increased melee damage and speed";
						toolTip2 = "Enemies are more likely to target you";
						defense = 13;
						break;

					case 3305:
						name = "Duratanium Headgear";
						width = height = 30;
						rare = 4;
						headSlot = 192;
						value = Item.sellPrice(0, 1, 40, 0);
						toolTip = "6% increased magic damage";
						toolTip2 = "5% decreased mana usage";
						defense = 4;
						break;

					case 3306:
						name = "Duratanium Headpiece";
						width = height = 30;
						rare = 4;
						headSlot = 193;
						value = Item.sellPrice(0, 1, 40, 0);
						toolTip = "7% increased ranged damage";
						defense = 7;
						break;

					case 3307:
						name = "Duratanium Chainmail";
						width = height = 30;
						rare = 4;
						bodySlot = 195;
						value = Item.sellPrice(0, 1, 60, 0);
						toolTip = "5% increased damage";
						defense = 10;
						break;

					case 3308:
						name = "Duratanium Greaves";
						width = height = 20;
						rare = 4;
						legSlot = 130;
						value = Item.sellPrice(0, 1, 30, 0);
						toolTip = "5% increased movement speed";
						defense = 8;
						break;

					case 3309:
						rare = 4;
						UseSound = SoundID.Item1;
						name = "Duratanium Sword";
						useStyle = 1;
						damage = 40;
						useTurn = true;
						useAnimation = 24;
						autoReuse = true;
						useTime = 24;
						width = 40;
						height = 40;
						scale = 1.0f;
						knockBack = 5f;
						melee = true;
						value = Item.sellPrice(0, 1, 40, 0);
						break;

					case 3310:
						rare = 4;
						UseSound = SoundID.Item1;
						name = "Duratanium Pickaxe";
						useStyle = 1;
						damage = 10;
						useTurn = true;
						useAnimation = 11;
						autoReuse = true;
						pick = 110;
						toolTip = "Can mine Mythril, Orichalcum, and Naquadah";
						useTime = 11;
						width = 32;
						height = 32;
						scale = 1.0f;
						knockBack = 1f;
						melee = true;
						value = Item.sellPrice(0, 1, 40, 0);
						break;

					case 3311:
						name = "Duratanium Drill";
						useStyle = 5;
						useAnimation = 25;
						useTime = 13;
						shootSpeed = 32f;
						knockBack = 0f;
						width = 20;
						height = 12;
						damage = 10;
						pick = 110;
						UseSound = SoundID.Item23;
						shoot = 532;
						rare = 4;
						value = 54000;
						noMelee = true;
						noUseGraphic = true;
						melee = true;
						channel = true;
						toolTip = "Can mine Mythril, Orichalcum, and Naquadah";
						break;

					case 3312:
						rare = 4;
						UseSound = SoundID.Item1;
						name = "Duratanium Waraxe";
						useStyle = 1;
						damage = 25;
						useTurn = true;
						useAnimation = 18;
						autoReuse = true;
						axe = 15;
						useTime = 18;
						width = 38;
						height = 38;
						scale = 1.0f;
						knockBack = 4f;
						melee = true;
						value = Item.sellPrice(0, 1, 0, 0);
						break;

					case 3313:
						name = "Duratanium Chainsaw";
						useStyle = 5;
						useAnimation = 25;
						useTime = 6;
						shootSpeed = 40f;
						knockBack = 3.5f;
						width = 20;
						height = 12;
						damage = 25;
						axe = 15;
						UseSound = SoundID.Item23;
						shoot = 533;
						rare = 4;
						value = 88000;
						noMelee = true;
						noUseGraphic = true;
						melee = true;
						channel = true;
						break;

					case 3314:
						name = "Duratanium Glaive";
						useStyle = 5;
						useAnimation = 23;
						useTime = 23;
						shootSpeed = 5f;
						knockBack = 5.1f;
						width = 40;
						height = 40;
						damage = 31;
						scale = 1.1f;
						UseSound = SoundID.Item1;
						shoot = 534;
						rare = 4;
						value = 105000;
						noMelee = true;
						noUseGraphic = true;
						melee = true;
						break;

					case 3315:
						useStyle = 5;
						autoReuse = true;
						useAnimation = 21;
						useTime = 21;
						name = "Duratanium Repeater";
						width = 50;
						height = 18;
						shoot = 1;
						useAmmo = 1;
						UseSound = SoundID.Item5;
						damage = 31;
						shootSpeed = 10.5f;
						noMelee = true;
						value = 40000;
						ranged = true;
						rare = 4;
						knockBack = 1.5f;
						break;

					case 3316:
						name = "Naquadah Ore";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createTile = 403;
						width = 12;
						height = 12;
						value = Item.sellPrice(0, 0, 11, 0);
						rare = 3;
						break;

					case 3317:
						name = "Naquadah Bar";
						width = 18;
						height = 18;
						maxStack = 999;
						value = Item.sellPrice(0, 0, 44, 0);
						rare = 4;
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						consumable = true;
						createTile = 239;
						placeStyle = 31;
						break;

					case 3318:
						name = "Naquadah Headguard";
						width = height = 30;
						rare = 4;
						headSlot = 194;
						value = Item.sellPrice(0, 2, 40, 0);
						toolTip = "7% increased ranged damage";
						toolTip2 = "10% chance to not consume ammo";
						defense = 10;
						break;

					case 3319:
						name = "Naquadah Hood";
						width = height = 30;
						rare = 4;
						headSlot = 196;
						value = Item.sellPrice(0, 2, 40, 0);
						toolTip = "8% increased magic damage";
						toolTip2 = "7% decreased mana usage";
						defense = 6;
						break;

					case 3320:
						name = "Naquadah Mask";
						width = height = 30;
						rare = 4;
						headSlot = 195;
						value = Item.sellPrice(0, 2, 40, 0);
						toolTip = "8% increased melee damage and speed";
						toolTip2 = "Enemies are more likely to target you";
						defense = 18;
						break;

					case 3321:
						name = "Naquadah Breastplate";
						width = height = 30;
						rare = 4;
						bodySlot = 196;
						value = Item.sellPrice(0, 2, 60, 0);
						toolTip = "6% increased damage";
						defense = 14;
						break;

					case 3322:
						name = "Naquadah Shinguards";
						width = height = 20;
						rare = 4;
						legSlot = 131;
						value = Item.sellPrice(0, 2, 30, 0);
						toolTip = "6% increased movement speed";
						defense = 12;
						break;

					case 3323:
						rare = 4;
						UseSound = SoundID.Item1;
						name = "Naquadah Sword";
						useStyle = 1;
						damage = 43;
						useTurn = true;
						useAnimation = 24;
						useTime = 24;
						width = 50;
						height = 50;
						scale = 1.0f;
						knockBack = 4f;
						melee = true;
						value = Item.sellPrice(0, 1, 40, 0);
						break;

					case 3324:
						rare = 4;
						UseSound = SoundID.Item1;
						name = "Naquadah Pickaxe";
						useStyle = 1;
						damage = 12;
						useTurn = true;
						useAnimation = 9;
						autoReuse = true;
						pick = 150;
						toolTip = "Can mine Adamantite, Titanium, and Troxinium";
						useTime = 9;
						width = 32;
						height = 32;
						scale = 1.0f;
						knockBack = 1f;
						melee = true;
						value = Item.sellPrice(0, 1, 40, 0);
						break;

					case 3325:
						name = "Naquadah Drill";
						useStyle = 5;
						useAnimation = 25;
						useTime = 13;
						shootSpeed = 32f;
						knockBack = 0f;
						width = 20;
						height = 12;
						damage = 12;
						pick = 150;
						UseSound = SoundID.Item23;
						shoot = 535;
						rare = 4;
						value = 54000;
						noMelee = true;
						noUseGraphic = true;
						melee = true;
						channel = true;
						toolTip = "Can mine Adamantite, Titanium, and Troxinium";
						break;

					case 3326:
						rare = 4;
						UseSound = SoundID.Item1;
						name = "Naquadah Greataxe";
						useStyle = 1;
						damage = 29;
						useTurn = true;
						useAnimation = 12;
						autoReuse = true;
						axe = 18;
						useTime = 12;
						width = 48;
						height = 48;
						scale = 1.0f;
						knockBack = 7f;
						melee = true;
						value = Item.sellPrice(0, 1, 40, 0);
						break;

					case 3327:
						name = "Naquadah Chainsaw";
						useStyle = 5;
						useAnimation = 25;
						useTime = 6;
						shootSpeed = 40f;
						knockBack = 4.5f;
						width = 20;
						height = 12;
						damage = 29;
						axe = 18;
						UseSound = SoundID.Item23;
						shoot = 536;
						rare = 4;
						value = 108000;
						noMelee = true;
						noUseGraphic = true;
						melee = true;
						channel = true;
						break;

					case 3328:
						name = "Naquadah Trident";
						useStyle = 5;
						useAnimation = 23;
						useTime = 23;
						shootSpeed = 5f;
						knockBack = 5.5f;
						width = 40;
						height = 40;
						damage = 35;
						scale = 1.1f;
						UseSound = SoundID.Item1;
						shoot = 537;
						rare = 4;
						value = 105000;
						noMelee = true;
						noUseGraphic = true;
						melee = true;
						break;

					case 3329:
						useStyle = 5;
						autoReuse = true;
						useAnimation = 20;
						useTime = 20;
						name = "Naquadah Repeater";
						width = 50;
						height = 18;
						shoot = 1;
						useAmmo = 1;
						UseSound = SoundID.Item5;
						damage = 36;
						shootSpeed = 10.5f;
						noMelee = true;
						value = 70000;
						ranged = true;
						rare = 4;
						knockBack = 2.05f;
						break;

					case 3330:
						name = "Troxinium Ore";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createTile = 404;
						width = 12;
						height = 12;
						value = Item.sellPrice(0, 0, 15, 0);
						rare = 4;
						break;

					case 3331:
						name = "Troxinium Bar";
						width = 18;
						height = 18;
						maxStack = 999;
						value = Item.sellPrice(0, 0, 75, 0);
						rare = 5;
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						consumable = true;
						createTile = 239;
						placeStyle = 32;
						break;

					case 3332:
						name = "Troxinium Headpiece";
						width = height = 30;
						rare = 5;
						headSlot = 197;
						value = Item.sellPrice(0, 3, 40, 0);
						toolTip = "9% increased ranged damage";
						toolTip2 = "30% chance to not consume ammo";
						defense = 11;
						break;

					case 3333:
						name = "Troxinium Helmet";
						width = height = 30;
						rare = 5;
						headSlot = 198;
						value = Item.sellPrice(0, 3, 40, 0);
						toolTip = "11% increased melee damage and speed";
						toolTip2 = "Enemies are more likely to target you";
						defense = 23;
						break;

					case 3334:
						name = "Troxinium Hat";
						width = height = 30;
						rare = 5;
						headSlot = 199;
						value = Item.sellPrice(0, 3, 40, 0);
						toolTip = "10% increased magic damage";
						toolTip2 = "15% decreased mana usage";
						defense = 9;
						break;

					case 3335:
						name = "Troxinium Bodyarmor";
						width = height = 30;
						rare = 5;
						bodySlot = 197;
						value = Item.sellPrice(0, 2, 60, 0);
						toolTip = "8% increased damage";
						defense = 15;
						break;

					case 3336:
						name = "Troxinium Cuisses";
						width = height = 20;
						rare = 5;
						legSlot = 132;
						value = Item.sellPrice(0, 2, 30, 0);
						toolTip = "5% increased critical strike chance";
						defense = 13;
						break;

					case 3337:
						rare = 5;
						UseSound = SoundID.Item1;
						name = "Troxinium Sword";
						useStyle = 1;
						damage = 46;
						useTurn = true;
						useAnimation = 24;
						useTime = 24;
						width = 44;
						height = 44;
						scale = 1.4f;
						knockBack = 4f;
						melee = true;
						value = Item.sellPrice(0, 1, 40, 0);
						break;

					case 3338:
						rare = 5;
						UseSound = SoundID.Item1;
						name = "Troxinium Pickaxe";
						useStyle = 1;
						damage = 14;
						useTurn = true;
						useAnimation = 8;
						autoReuse = true;
						pick = 185;
						toolTip = "Can mine Ferozium";
						useTime = 8;
						width = 32;
						height = 32;
						scale = 1.0f;
						knockBack = 1f;
						melee = true;
						value = Item.sellPrice(0, 3, 40, 0);
						break;

					case 3339:
						name = "Troxinium Drill";
						useStyle = 5;
						useAnimation = 25;
						useTime = 13;
						shootSpeed = 32f;
						knockBack = 0f;
						width = 20;
						height = 12;
						damage = 14;
						pick = 185;
						UseSound = SoundID.Item23;
						shoot = 538;
						rare = 5;
						value = 54000;
						noMelee = true;
						noUseGraphic = true;
						melee = true;
						channel = true;
						toolTip = "Can mine Ferozium";
						break;

					case 3340:
						rare = 5;
						UseSound = SoundID.Item1;
						name = "Troxinium Waraxe";
						useStyle = 1;
						damage = 32;
						useTurn = true;
						useAnimation = 11;
						autoReuse = true;
						axe = 20;
						useTime = 11;
						width = 32;
						height = 32;
						scale = 1.0f;
						knockBack = 6f;
						melee = true;
						value = Item.sellPrice(0, 3, 40, 0);
						break;

					case 3341:
						name = "Troxinium Chainsaw";
						useStyle = 5;
						useAnimation = 25;
						useTime = 6;
						shootSpeed = 40f;
						knockBack = 4.5f;
						width = 20;
						height = 12;
						damage = 32;
						axe = 20;
						UseSound = SoundID.Item23;
						shoot = 539;
						rare = 5;
						value = 108000;
						noMelee = true;
						noUseGraphic = true;
						melee = true;
						channel = true;
						break;

					case 3342:
						name = "Troxinium Spear";
						useStyle = 5;
						useAnimation = 23;
						useTime = 23;
						shootSpeed = 5f;
						knockBack = 5.6f;
						width = 40;
						height = 40;
						damage = 41;
						scale = 1.1f;
						UseSound = SoundID.Item1;
						shoot = 540;
						rare = 5;
						value = 105000;
						noMelee = true;
						noUseGraphic = true;
						melee = true;
						break;

					case 3343:
						useStyle = 5;
						autoReuse = true;
						useAnimation = 21;
						useTime = 21;
						name = "Troxinium Repeater";
						width = 50;
						height = 18;
						shoot = 1;
						useAmmo = 1;
						UseSound = SoundID.Item5;
						damage = 42;
						shootSpeed = 10.5f;
						noMelee = true;
						value = 100000;
						ranged = true;
						rare = 5;
						knockBack = 1.5f;
						break;

					case 3344:
						name = "Naquadah Anvil";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 134;
						placeStyle = 2;
						width = 28;
						height = 14;
						value = 25000;
						toolTip = "Used to craft items from mythril, orichalcum, naquadah, adamantite, titanium, and troxinium bars";
						rare = 4;
						break;

					case 3345:
						name = "Troxinium Forge";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 133;
						placeStyle = 2;
						width = 28;
						height = 14;
						value = 55000;
						toolTip = "Used to smelt adamantite, titanium, and troxinium ore";
						rare = 5;
						break;

					case 3346:
						name = "Osmium Brick";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createTile = 405;
						width = 12;
						height = 12;
						break;

					case 3347:
						name = "Osmium Brick Wall";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createWall = 187;
						rare = 0;
						width = 12;
						height = 12;
						break;

					case 3348:
						name = "Shroomite Ore";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createTile = 406;
						width = 12;
						height = 12;
						value = Item.sellPrice(0, 0, 40, 0);
						rare = 7;
						break;

					case 3349:
						name = "Cobalt Shield Mark II";
						width = 24;
						height = 28;
						rare = 4;
						value = 54000;
						accessory = true;
						defense = 2;
						toolTip = "Increases defense when struck";
						break;

					case 3350:
						name = "Palladium Shield";
						width = 24;
						height = 28;
						rare = 4;
						value = 54000;
						accessory = true;
						defense = 2;
						toolTip = "Regenerates health when struck";
						break;

					case 3351:
						name = "Duratanium Shield";
						width = 24;
						height = 28;
						rare = 4;
						value = 54000;
						accessory = true;
						defense = 2;
						toolTip = "Slows the effects of damage over time debuffs";
						break;

					case 3352:
						name = "COmega Shield";
						width = 24;
						height = 28;
						rare = 8;
						value = 100000;
						accessory = true;
						defense = 4;
						toolTip = "Greatly increases defense and regenerates life when struck";
						toolTip2 = "Slows the effects of damage over time debuffs";
						break;

					case 3353:
						name = "POmega Shield";
						width = 24;
						height = 28;
						rare = 8;
						value = 100000;
						accessory = true;
						defense = 4;
						toolTip = "Quickly regenerates life and increases defense when struck";
						toolTip2 = "Slows the effects of damage over time debuffs";
						break;

					case 3354:
						name = "DOmega Shield";
						width = 24;
						height = 28;
						rare = 8;
						value = 100000;
						accessory = true;
						defense = 4;
						toolTip = "Increases defense and regenerates life when struck";
						toolTip2 = "Greatly slows the effects of damage over time debuffs";
						break;

					case 3355:
						name = "Sun Charm";
						useStyle = 1;
						width = 22;
						height = 20;
						UseSound = SoundID.Item1;
						useAnimation = 40;
						useTime = 40;
						shoot = 541;
						rare = 8;
						maxStack = 999;
						consumable = true;
						toolTip = "Summons a Solar Eclipse";
						break;

					case 3356:
						name = "Solar Fragment";
						width = height = 16;
						value = 10;
						rare = 7;
						maxStack = 999;
						toolTip = "'Hot!'";
						break;

					case 3357:
						name = "Large Tourmaline";
						width = 20;
						height = 20;
						toolTip = "For Capture the Gem";
						rare = 1;
						break;

					case 3358:
						name = "Tourmaline Hook";
						width = 24;
						height = 32;
						rare = 1;
						value = Item.sellPrice(0, 0, 54, 0);
						useAnimation = 20;
						useTime = 20;
						useStyle = 5;
						noMelee = true;
						UseSound = SoundID.Item1;
						noUseGraphic = true;
						shoot = 542;
						shootSpeed = 16f;
						useTurn = true;
						break;

					case 3359:
						name = "Large Peridot";
						width = 20;
						height = 20;
						toolTip = "For Capture the Gem";
						rare = 1;
						break;

					case 3360:
						name = "Peridot Hook";
						width = 24;
						height = 32;
						rare = 1;
						value = Item.sellPrice(0, 0, 54, 0);
						useAnimation = 20;
						useTime = 20;
						useStyle = 5;
						noMelee = true;
						noUseGraphic = true;
						UseSound = SoundID.Item1;
						shoot = 543;
						shootSpeed = 16f;
						useTurn = true;
						knockBack = 7;
						break;

					case 3361:
						name = "Tourmaline Robe";
						width = 18;
						height = 14;
						bodySlot = 198;
						defense = 5;
						value = Item.sellPrice(0, 0, 50, 0) * 3;
						toolTip = "Increases maximum mana by 100";
						toolTip2 = "Reduces mana usage by 15%";
						rare = 2;
						break;

					case 3362:
						name = "Peridot Robe";
						width = 18;
						height = 14;
						bodySlot = 199;
						defense = 5;
						value = Item.sellPrice(0, 0, 50, 0) * 4;
						toolTip = "Increases maximum mana by 120";
						toolTip2 = "Reduces mana usage by 16%";
						rare = 2;
						break;

					case 3363:
						name = "Totem of the Golem";
						useStyle = 4;
						width = 20;
						height = 20;
						UseSound = SoundID.Item1;
						useAnimation = 15;
						useTime = 10;
						rare = 8;
						maxStack = 1;
						consumable = false;
						toolTip = "Teleports you to the Hidden Temple";
						break;

					case 3364:
						name = "Viruthorn Helmet";
						width = height = 30;
						rare = 1;
						headSlot = 200;
						value = Item.sellPrice(0, 0, 54, 0);
						toolTip = "3% increased damage";
						defense = 6;
						break;

					case 3365:
						name = "Viruthorn Scalemail";
						width = height = 30;
						rare = 1;
						bodySlot = 200;
						value = Item.sellPrice(0, 0, 54, 0);
						toolTip = "7% increased melee speed";
						defense = 8;
						break;

					case 3366:
						name = "Viruthorn Greaves";
						width = height = 20;
						rare = 1;
						legSlot = 133;
						value = Item.sellPrice(0, 0, 54, 0);
						toolTip = "3% increased damage";
						defense = 6;
						break;

					case 3367:
						rare = 1;
						UseSound = SoundID.Item1;
						name = "Snotsabre";
						useStyle = 1;
						damage = 17;
						useTurn = true;
						useAnimation = 20;
						autoReuse = true;
						useTime = 20;
						width = 40;
						height = 40;
						scale = 1f;
						knockBack = 3f;
						melee = true;
						value = Item.sellPrice(0, 0, 36, 0);
						break;

					case 3368:
						rare = 1;
						UseSound = SoundID.Item1;
						name = "Goldmine Pickaxe";
						useStyle = 1;
						damage = 9;
						useTurn = true;
						useAnimation = 20;
						autoReuse = true;
						pick = 69;
						toolTip = "Able to mine Dungeon Brick";
						useTime = 20;
						width = 32;
						height = 32;
						scale = 1f;
						knockBack = 0.5f;
						melee = true;
						value = Item.sellPrice(0, 0, 36, 0);
						break;

					case 3369:
						rare = 1;
						UseSound = SoundID.Item1;
						name = "Axe of Sickness";
						useStyle = 1;
						damage = 15;
						useTurn = true;
						useAnimation = 20;
						autoReuse = true;
						axe = 12;
						useTime = 20;
						width = 32;
						height = 32;
						scale = 1f;
						knockBack = 0.5f;
						melee = true;
						value = Item.sellPrice(0, 0, 36, 0);
						break;

					case 3370:
						rare = 1;
						UseSound = SoundID.Item1;
						name = "Mucus Hammer";
						useStyle = 1;
						damage = 11;
						useTurn = true;
						useAnimation = 20;
						autoReuse = true;
						hammer = 59;
						useTime = 20;
						width = 32;
						height = 32;
						scale = 1f;
						knockBack = 4f;
						melee = true;
						value = Item.sellPrice(0, 0, 36, 0);
						break;

					case 3371:
						rare = 1;
						UseSound = SoundID.Item5;
						name = "Wheezebow";
						useStyle = 5;
						damage = 16;
						useTurn = true;
						useAnimation = 20;
						useTime = 20;
						width = 18;
						height = 32;
						scale = 1f;
						knockBack = 0f;
						shoot = 1;
						shootSpeed = 9f;
						useAmmo = 1;
						ranged = true;
						value = Item.sellPrice(0, 0, 36, 0);
						break;

					case 3372:
						name = "Baccilite Ore";
						useStyle = 1;
						useAnimation = 15;
						useTime = 10;
						consumable = true;
						useTurn = true;
						autoReuse = true;
						createTile = 409;
						maxStack = 999;
						width = 12;
						height = 12;
						value = Item.sellPrice(0, 0, 7, 0);
						rare = 1;
						break;

					case 3373:
						name = "Baccilite Bar";
						width = height = 20;
						value = Item.sellPrice(0, 0, 28, 0);
						rare = 1;
						maxStack = 999;
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						consumable = true;
						createTile = 239;
						placeStyle = 33;
						break;

					case 3374:
						name = "Booger";
						width = 14;
						height = 18;
						maxStack = 999;
						rare = 1;
						value = 750;
						break;

					case 3375:
						name = "Yucky Bit";
						width = 14;
						height = 18;
						maxStack = 999;
						value = 750;
						break;

					case 3376:
						name = "Chunkstone Block";
						useStyle = 1;
						useAnimation = 15;
						useTime = 10;
						consumable = true;
						useTurn = true;
						autoReuse = true;
						createTile = 408;
						maxStack = 999;
						width = 12;
						height = 12;
						value = 0;
						rare = 0;
						break;

					case 3377:
						name = "Coughwood Helmet";
						width = height = 30;
						headSlot = 201;
						value = Item.sellPrice(0, 0, 2, 0);
						defense = 2;
						break;

					case 3378:
						name = "Coughwood Breastplate";
						width = height = 30;
						bodySlot = 201;
						value = Item.sellPrice(0, 0, 2, 0);
						defense = 2;
						break;

					case 3379:
						name = "Coughwood Greaves";
						width = height = 20;
						legSlot = 134;
						value = Item.sellPrice(0, 0, 1, 0);
						defense = 2;
						break;

					case 3380:
						UseSound = SoundID.Item1;
						name = "Coughwood Sword";
						useStyle = 1;
						damage = 10;
						useTurn = true;
						useAnimation = 18;
						useTime = 18;
						width = 30;
						height = 30;
						scale = 1f;
						knockBack = 3f;
						melee = true;
						value = Item.sellPrice(0, 0, 4, 0);
						break;

					case 3381:
						name = "Coughwood Platform";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						autoReuse = true;
						useTime = 10;
						width = 24;
						height = 14;
						scale = 1f;
						maxStack = 999;
						createTile = 19;
						placeStyle = 27;
						consumable = true;
						break;

					case 3382:
						name = "Coughwood";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						autoReuse = true;
						useTime = 10;
						width = 24;
						height = 14;
						consumable = true;
						scale = 1f;
						maxStack = 999;
						createTile = 412;
						break;

					case 3383:
						name = "Coughwood Work Bench";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						autoReuse = true;
						consumable = true;
						useTime = 10;
						width = 24;
						height = 14;
						scale = 1f;
						maxStack = 99;
						createTile = 18;
						placeStyle = 28;
						break;

					case 3384:
						name = "Coughwood Door";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						autoReuse = true;
						consumable = true;
						useTime = 10;
						width = 24;
						height = 14;
						scale = 1f;
						maxStack = 99;
						createTile = 10;
						placeStyle = 33;
						break;

					case 3385:
						name = "Coughwood Table";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						autoReuse = true;
						useTime = 10;
						width = 24;
						height = 14;
						scale = 1f;
						maxStack = 99;
						consumable = true;
						createTile = 14;
						placeStyle = 32;
						break;

					case 3386:
						name = "Coughwood Chair";
						useStyle = 1;
						consumable = true;
						useTurn = true;
						useAnimation = 15;
						autoReuse = true;
						useTime = 10;
						width = 24;
						height = 14;
						scale = 1f;
						maxStack = 99;
						createTile = 15;
						placeStyle = 33;
						break;

					case 3387:
						name = "Yellow Ice Block";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						autoReuse = true;
						useTime = 10;
						width = 24;
						height = 14;
						consumable = true;
						scale = 1f;
						maxStack = 999;
						createTile = 411;
						break;

					case 3388:
						name = "Yellow Solution";
						shoot = 6;
						ammo = 780;
						width = 10;
						height = 12;
						value = Item.buyPrice(0, 0, 25, 0);
						rare = 3;
						maxStack = 999;
						toolTip = "Used by the Clentaminator";
						toolTip2 = "Spreads the Contagion";
						break;

					case 3389:
						UseSound = SoundID.Item1;
						name = "Virulent Knives";
						useStyle = 1;
						damage = 46;
						useTurn = true;
						noUseGraphic = true;
						noMelee = true;
						useAnimation = 18;
						autoReuse = true;
						useTime = 18;
						shoot = 547;
						shootSpeed = 11f;
						width = 30;
						height = 30;
						scale = 1f;
						knockBack = 3f;
						melee = true;
						rare = 8;
						toolTip = "Throws homing knives";
						value = Item.sellPrice(0, 20, 0, 0);
						break;

					case 3390:
						name = "Snotsand Block";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						autoReuse = true;
						useTime = 10;
						width = 24;
						height = 14;
						scale = 1f;
						maxStack = 999;
						consumable = true;
						createTile = 413;
						break;

					case 3391:
						name = "Contagion Key Mold";
						width = 24;
						height = 14;
						scale = 1f;
						rare = 8;
						maxStack = 999;
						toolTip = "Used for crafting a Contagion Key";
						break;

					case 3392:
						name = "Contagion Key";
						width = 24;
						height = 14;
						scale = 1f;
						maxStack = 999;
						rare = 8;
						toolTip = "Opens a Contagion Chest in the Dungeon";
						break;

					case 3393:
						name = "Contagion Chest";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						autoReuse = true;
						consumable = true;
						useTime = 10;
						width = 24;
						height = 14;
						scale = 1f;
						maxStack = 99;
						createTile = 21;
						placeStyle = 52;
						value = Item.sellPrice(0, 0, 2, 0);
						break;

					case 3394:
						name = "Virulent Pike";
						useStyle = 5;
						useAnimation = 20;
						useTime = 20;
						shootSpeed = 3.6f;
						knockBack = 2.5f;
						width = 36;
						height = 36;
						damage = 22;
						scale = 1f;
						rare = 1;
						//autoReuse = true;
						UseSound = SoundID.Item1;
						shoot = 545;
						value = Item.sellPrice(0, 0, 36, 0);
						noMelee = noUseGraphic = melee = true;
						break;

					case 3395:
						name = "Band of Stamina";
						width = 22;
						height = 22;
						accessory = true;
						rare = 1;
						toolTip = "Increases maximum stamina by 60";
						value = 50000;
						break;

					case 3396:
						useStyle = 5;
						useAnimation = 13;
						useTime = 13;
						name = "Pee Shooter";
						width = 24;
						height = 28;
						shoot = 14;
						useAmmo = 14;
						UseSound = SoundID.Item11;
						damage = 8;
						shootSpeed = 7f;
						noMelee = true;
						value = 50000;
						scale = 0.9f;
						rare = 1;
						ranged = true;
						break;

					case 3397:
						name = "Pathogen";
						width = 12;
						height = 14;
						maxStack = 999;
						value = 4500;
						rare = 3;
						toolTip = "'Blech'";
						break;

					case 3398:
						autoReuse = true;
						rare = 4;
						mana = 5;
						UseSound = SoundID.Item13;
						name = "Pathogen Mist";
						useStyle = 5;
						damage = 24;
						useAnimation = 11;
						useTime = 11;
						width = 24;
						height = 28;
						shoot = 546;
						scale = 0.9f;
						shootSpeed = 14f;
						knockBack = 5f;
						toolTip = "Fires a blast of infected mist";
						magic = true;
						value = 500000;
						break;

					case 3399:
						name = "Bacterial Totem";
						useStyle = 4;
						useTime = 45;
						useAnimation = 45;
						value = 0;
						height = 18;
						width = 24;
						toolTip = "Summons Bacterium Prime";
						toolTip2 = "'Rumors say to not hit the main body in its first phase'";
						consumable = true;
						maxStack = 20;
						break;

					case 3400:
						name = "The Cell";
						useStyle = 5;
						useAnimation = 45;
						useTime = 45;
						knockBack = 6.5f;
						width = 30;
						height = 10;
						damage = 17;
						scale = 1.1f;
						noUseGraphic = true;
						shoot = 548;
						shootSpeed = 12f;
						UseSound = SoundID.Item1;
						rare = 1;
						value = 27000;
						melee = true;
						channel = true;
						noMelee = true;
						break;

					case 3401:
						name = "Ickgrass Seeds";
						useTurn = true;
						useStyle = 1;
						useAnimation = 15;
						useTime = 10;
						maxStack = 999;
						consumable = true;
						createTile = 410;
						width = 14;
						height = 14;
						value = 500;
						break;

					case 3402:
						name = "Pathogen Bullet";
						shootSpeed = 7f;
						shoot = 550;
						damage = 11;
						width = 8;
						height = 8;
						maxStack = 2000;
						consumable = true;
						ammo = 14;
						knockBack = 3f;
						value = 100;
						ranged = true;
						rare = 3;
						break;

					case 3403:
						name = "Pathogen Arrow";
						width = 10;
						height = 20;
						value = Item.sellPrice(0, 0, 0, 50);
						maxStack = 2000;
						damage = 13;
						rare = 3;
						shootSpeed = 4f;
						shoot = 551;
						consumable = true;
						ranged = true;
						ammo = 1;
						knockBack = 4f;
						break;

					case 3404:
						name = "Barfbush Seeds";
						useTurn = true;
						useStyle = 1;
						useAnimation = 15;
						useTime = 10;
						maxStack = 999;
						consumable = true;
						createTile = 82;
						placeStyle = 9;
						width = 12;
						height = 14;
						value = 90;
						break;

					case 3405:
						name = "Barfbush";
						maxStack = 999;
						width = 12;
						height = 14;
						value = 100;
						break;

					case 3406:
						name = "Band of Slime";
						width = 22;
						height = 22;
						accessory = true;
						rare = 1;
						toolTip = "Reduces damage taken by 20% and negates fall damage";
						toolTip2 = "All tiles are slippery";
						value = 50000;
						break;

					case 3407:
						rare = 0;
						UseSound = SoundID.Item5;
						name = "Coughwood Bow";
						useStyle = 5;
						damage = 9;
						useTurn = true;
						useAnimation = 20;
						useTime = 20;
						width = 18;
						height = 32;
						scale = 1f;
						knockBack = 0f;
						shoot = 1;
						shootSpeed = 7f;
						ranged = true;
						useAmmo = 1;
						value = Item.sellPrice(0, 0, 10, 0);
						break;

					case 3408:
						name = "Coughwood Wall";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 7;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createWall = 190;
						width = 12;
						height = 12;
						break;

					case 3409:
						name = "Coughwood Chest";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 21;
						placeStyle = 54;
						width = 26;
						height = 22;
						value = 500;
						break;

					case 3410:
						name = "Coughwood Hammer";
						autoReuse = true;
						useStyle = 1;
						useTurn = true;
						useAnimation = 30;
						useTime = 20;
						hammer = 42;
						width = 24;
						height = 28;
						damage = 7;
						knockBack = 5.5f;
						scale = 1.2f;
						UseSound = SoundID.Item1;
						value = 50;
						melee = true;
						break;

					case 3411:
						name = "Sticky Charm";
						width = 22;
						height = 22;
						accessory = true;
						rare = 3;
						toolTip = "Reduces damage taken by 20% and negates fall damage";
						toolTip2 = "Provides immunity to slimes";
						value = 200000;
						break;

					case 3412:
						name = "Zircon";
						width = height = 12;
						value = 4400;
						maxStack = 999;
						rare = 1;
						//createTile = 178;
						//placeStyle = 11;
						//useStyle = 1;
						//useTurn = true;
						//useAnimation = 15;
						//useTime = 10;
						//autoReuse = true;
						//consumable = true;
						break;

					case 3413:
						name = "Zircon Staff";
						mana = 9;
						UseSound = SoundID.Item43;
						useStyle = 5;
						damage = 32;
						useAnimation = 23;
						useTime = 23;
						width = 40;
						height = 40;
						shoot = 553;
						shootSpeed = 7.75f;
						knockBack = 4.75f;
						magic = true;
						autoReuse = true;
						value = 36000;
						rare = 2;
						noMelee = true;
						break;

					case 3414:
						name = "Crimson Altar";
						width = 48;
						height = 34;
						useAnimation = 20;
						useTime = 20;
						consumable = true;
						maxStack = 99;
						createTile = 26;
						autoReuse = true;
						placeStyle = 5;
						useStyle = 1;
						rare = 1;
						toolTip = "The spirit of Cthulhu guards this altar";
						break;

					case 3415:
						name = "Icky Altar";
						width = 48;
						height = 34;
						useAnimation = 20;
						useTime = 20;
						consumable = true;
						maxStack = 99;
						createTile = 26;
						autoReuse = true;
						placeStyle = 6;
						useStyle = 1;
						rare = 1;
						toolTip = "The spirit of Cthulhu guards this altar";
						break;

					case 3423:
						name = "Zircon Robe";
						width = 18;
						height = 14;
						bodySlot = 202;
						defense = 6;
						value = Item.sellPrice(0, 0, 50, 0) * 4;
						toolTip = "Increases maximum mana by 120";
						toolTip2 = "Reduces mana usage by 18%";
						rare = 2;
						break;

					case 3424:
						name = "Zircon Hook";
						width = 24;
						height = 32;
						rare = 2;
						value = Item.sellPrice(0, 0, 54, 0);
						useAnimation = 20;
						useTime = 20;
						useStyle = 5;
						noMelee = true;
						noUseGraphic = true;
						UseSound = SoundID.Item1;
						shoot = 554;
						shootSpeed = 16f;
						useTurn = true;
						knockBack = 7;
						break;

					case 3425:
						name = "Slime Table";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 14;
						placeStyle = 33;
						width = 26;
						height = 20;
						value = 300;
						break;

					case 3426:
						name = "Slime Bathtub";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 90;
						placeStyle = 28;
						width = 20;
						height = 20;
						value = 300;
						break;

					case 3427:
						name = "Slime Bed";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						maxStack = 99;
						consumable = true;
						autoReuse = true;
						createTile = 79;
						placeStyle = 28;
						width = 28;
						height = 20;
						value = 2000;
						break;

					case 3428:
						name = "Slime Bookcase";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 101;
						placeStyle = 29;
						width = 20;
						height = 20;
						value = 300;
						break;

					case 3429:
						name = "Slime Candelabra";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 100;
						placeStyle = 28;
						width = 20;
						height = 20;
						value = 1500;
						break;

					case 3430:
						noWet = true;
						name = "Slime Candle";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 33;
						placeStyle = 27;
						width = 8;
						height = 18;
						break;

					case 3431:
						name = "Slime Chair";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 15;
						placeStyle = 34;
						width = 12;
						height = 30;
						break;

					case 3432:
						name = "Slime Chandelier";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 34;
						placeStyle = 34;
						width = 26;
						height = 26;
						value = 3000;
						break;

					case 3433:
						name = "Slime Chest";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 21;
						placeStyle = 36;
						width = 26;
						height = 22;
						value = 500;
						break;

					case 3434:
						name = "Slime Sofa";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 89;
						placeStyle = 30;
						width = 20;
						height = 20;
						value = 300;
						break;

					case 3435:
						name = "Slime Door";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						maxStack = 99;
						consumable = true;
						createTile = 10;
						placeStyle = 34;
						width = 14;
						height = 28;
						value = 200;
						break;

					case 3436:
						name = "Slime Dresser";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 88;
						placeStyle = 25;
						width = 20;
						height = 20;
						value = 300;
						break;

					case 3437:
						name = "Slime Lamp";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 93;
						placeStyle = 28;
						width = 10;
						height = 24;
						value = 500;
						break;

					case 3438:
						name = "Slime Lantern";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createTile = 42;
						placeStyle = 33;
						width = 12;
						height = 28;
						break;

					case 3439:
						name = "Slime Piano";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 87;
						placeStyle = 27;
						width = 20;
						height = 20;
						value = 300;
						break;

					case 3440:
						name = "Slime Platform";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createTile = 19;
						placeStyle = 28;
						width = 8;
						height = 10;
						break;

					case 3441:
						name = "Slime Work Bench";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 18;
						placeStyle = 29;
						width = 28;
						height = 14;
						value = 150;
						toolTip = "Used for basic crafting";
						break;

					case 3442:
						name = "Slime Clock";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 104;
						placeStyle = 24;
						width = 20;
						height = 20;
						value = 300;
						break;

					case 3443:
						name = "Bag of Ick";
						width = 24;
						height = 28;
						accessory = true;
						vanity = true;
						toolTip = "Icky particles cover you when you move";
						rare = 2;
						worksInVanity = true;
						value = Item.sellPrice(0, 1, 0, 0);
						break;

					case 3444:
						flame = true;
						name = "Pathogen Torch";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						holdStyle = 1;
						//ammo = 8;
						//torch = 13;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createTile = 4;
						placeStyle = 14;
						width = 10;
						height = 12;
						rare = 3;
						value = Item.sellPrice(0, 0, 2, 0);
						break;

					case 3445:
						flame = true;
						noWet = true;
						name = "Slime Torch";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						holdStyle = 1;
						//ammo = 8;
						//torch = 13;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createTile = 4;
						placeStyle = 15;
						width = 10;
						height = 12;
						value = Item.sellPrice(0, 0, 0, 15);
						break;

					case 3446:
						flame = true;
						noWet = true;
						name = "Cyan Torch";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						holdStyle = 1;
						//ammo = 8;
						//torch = 13;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createTile = 4;
						placeStyle = 16;
						width = 10;
						height = 12;
						value = Item.sellPrice(0, 0, 0, 15);
						break;

					case 3447:
						flame = true;
						noWet = true;
						name = "Lime Torch";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						holdStyle = 1;
						//ammo = 8;
						//torch = 13;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createTile = 4;
						placeStyle = 17;
						width = 10;
						height = 12;
						value = Item.sellPrice(0, 0, 0, 15);
						break;

					case 3448:
						flame = true;
						noWet = true;
						name = "Brown Torch";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						holdStyle = 1;
						//ammo = 8;
						//torch = 13;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createTile = 4;
						placeStyle = 18;
						width = 10;
						height = 12;
						value = Item.sellPrice(0, 0, 0, 15);
						break;

					case 3449:
						name = "Large Zircon";
						width = 20;
						height = 20;
						toolTip = "For Capture the Gem";
						rare = 1;
						break;

					case 3450:
						name = "Hallowed Altar";
						width = 48;
						height = 34;
						useAnimation = 20;
						useTime = 20;
						consumable = true;
						maxStack = 99;
						createTile = 415;
						autoReuse = true;
						placeStyle = 0;
						useStyle = 1;
						rare = 5;
						//toolTip = "The spirit of Cthulhu guards this altar";
						break;

					case 3451:
						name = "Pyroscoric Ore";
						useStyle = 1;
						useAnimation = 15;
						useTime = 10;
						consumable = true;
						useTurn = true;
						autoReuse = true;
						createTile = 416;
						maxStack = 999;
						width = 12;
						height = 12;
						value = Item.sellPrice(0, 0, 20, 0);
						rare = 8;
						break;

					case 3452:
						name = "Pyroscoric Bar";
						width = 20;
						height = 20;
						value = Item.sellPrice(0, 1, 0, 0);
						rare = 8;
						maxStack = 999;
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						consumable = true;
						createTile = 239;
						placeStyle = 34;
						break;

					case 3453:
						rare = 8;
						UseSound = SoundID.Item1;
						name = "Pyroscoric Longsword";
						useStyle = 1;
						damage = 97;
						useTurn = true;
						useAnimation = 25;
						autoReuse = false;
						useTime = 25;
						width = 44;
						height = 44;
						scale = 1.0f;
						knockBack = 7f;
						toolTip = "'It burns, I tell you!'";
						melee = true;
						value = Item.sellPrice(0, 7, 63, 0);
						break;

					case 3454:
						name = "Pyroscoric Bullet";
						shootSpeed = 9f;
						shoot = 555;
						damage = 19;
						width = 8;
						height = 8;
						maxStack = 2000;
						consumable = true;
						ammo = 14;
						knockBack = 4f;
						value = 1200;
						ranged = true;
						rare = 8;
						break;

					case 3455:
						name = "Triton Bullet";
						shootSpeed = 11f;
						shoot = 557;
						damage = 17;
						width = 8;
						height = 8;
						maxStack = 2000;
						consumable = true;
						ammo = 14;
						knockBack = 20f;
						value = 1200;
						ranged = true;
						rare = 8;
						break;

					case 3456:
						name = "Pyroscoric Pickaxe";
						useStyle = 1;
						useAnimation = 11;
						useTime = 9;
						knockBack = 3.5f;
						useTurn = true;
						autoReuse = true;
						width = 20;
						height = 12;
						damage = 30;
						pick = 250;
						UseSound = SoundID.Item1;
						rare = 8;
						value = 416000;
						melee = true;
						scale = 1.15f;
						tileBoost += 2;
						break;

					case 3457:
						name = "Tritanorium Pickaxe";
						useStyle = 1;
						useAnimation = 15;
						useTime = 13;
						knockBack = 6.5f;
						useTurn = true;
						autoReuse = true;
						width = 20;
						height = 12;
						damage = 30;
						pick = 260;
						UseSound = SoundID.Item1;
						rare = 8;
						value = 516000;
						melee = true;
						scale = 1.15f;
						tileBoost += 2;
						break;

					case 3458:
						name = "Pyroscoric Brick";
						useStyle = 1;
						useAnimation = 15;
						useTime = 10;
						consumable = true;
						useTurn = true;
						autoReuse = true;
						createTile = 417;
						maxStack = 999;
						width = 12;
						height = 12;
						break;

					case 3459:
						name = "Lead Brick";
						useStyle = 1;
						useAnimation = 15;
						useTime = 10;
						consumable = true;
						useTurn = true;
						autoReuse = true;
						createTile = 418;
						maxStack = 999;
						width = 12;
						height = 12;
						break;

					case 3460:
						name = "Iron Brick";
						useStyle = 1;
						useAnimation = 15;
						useTime = 10;
						consumable = true;
						useTurn = true;
						autoReuse = true;
						createTile = 419;
						maxStack = 999;
						width = 12;
						height = 12;
						break;

					case 3461:
						name = "Lead Brick Wall";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 7;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createWall = 191;
						width = 12;
						height = 12;
						break;

					case 3462:
						name = "Iron Brick Wall";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 7;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createWall = 192;
						width = 12;
						height = 12;
						break;

					case 3463:
						name = "Eye of the Gods";
						width = 24;
						height = 28;
						accessory = true;
						toolTip = "Shows the location and stats of enemies";
						rare = 4;
						value = Item.sellPrice(0, 3, 0, 0);
						break;

					case 3464:
						name = "Ferozium Brick";
						useStyle = 1;
						useAnimation = 15;
						useTime = 10;
						consumable = true;
						useTurn = true;
						autoReuse = true;
						createTile = 420;
						maxStack = 999;
						width = 12;
						height = 12;
						break;

					case 3465:
						name = "Focus Beam";
						width = 28;
						height = 30;
						useStyle = 5;
						useTurn = true;
						useAnimation = 27;
						useTime = 27;
						damage = 47;
						autoReuse = true;
						knockBack = 5;
						scale = 1;
						UseSound = SoundID.Item60;
						shoot = 558;
						toolTip = "Fires a wide-beam laser";
						rare = 3;
						shootSpeed = 15;
						crit = 1;
						mana = 18;
						noMelee = true;
						value = 388500;
						magic = true;
						break;

					case 3466:
						name = "Sonic Screwdriver Mk I";
						width = height = 30;
						value = Item.sellPrice(0, 1, 0, 0);
						useStyle = 3;
						rare = 3;
						useAnimation = useTime = 70;
						UseSound = SoundID.Item63;
						toolTip = "Reveals treasures, ores, and mobs";
						break;

					case 3467:
						name = "Sonic Screwdriver Mk II";
						width = height = 30;
						value = Item.sellPrice(0, 4, 0, 0);
						useStyle = 3;
						rare = 6;
						useAnimation = useTime = 70;
						UseSound = SoundID.Item63;
						toolTip = "Reveals treasures, ores, and mobs";
						toolTip2 = "Tells time and shows position";
						break;

					case 3468:
						name = "Sonic Screwdriver Mk III";
						width = height = 30;
						value = Item.sellPrice(0, 10, 0, 0);
						useStyle = 3;
						rare = 9;
						useAnimation = useTime = 70;
						UseSound = SoundID.Item63;
						toolTip = "Reveals treasures, ores, mobs, and dangers";
						toolTip2 = "Tells time, shows position, and can open all locks";
						break;

					case 3469:
						name = "Ferozium Brick Wall";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 7;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createWall = 193;
						width = 12;
						height = 12;
						break;

					case 3470:
						name = "Pyroscoric Brick Wall";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 7;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createWall = 194;
						width = 12;
						height = 12;
						break;

					case 3471:
						name = "Ring of Disgust";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 242;
						toolTip = "'B. Harold'";
						width = 30;
						height = 30;
						rare = 3;
						value = Item.sellPrice(0, 0, 10, 0);
						placeStyle = 36;
						break;

					case 3472:
						name = "Beetle Bar";
						width = 20;
						height = 20;
						value = Item.sellPrice(0, 1, 0, 0);
						rare = 8;
						maxStack = 999;
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						consumable = true;
						createTile = 239;
						placeStyle = 35;
						break;

					case 3473:
						name = "Duratanium Brick";
						useStyle = 1;
						useAnimation = 15;
						useTime = 10;
						consumable = true;
						useTurn = true;
						autoReuse = true;
						createTile = 421;
						maxStack = 999;
						width = 12;
						height = 12;
						break;

					case 3474:
						name = "Naquadah Brick";
						useStyle = 1;
						useAnimation = 15;
						useTime = 10;
						consumable = true;
						useTurn = true;
						autoReuse = true;
						createTile = 422;
						maxStack = 999;
						width = 12;
						height = 12;
						break;

					case 3475:
						name = "Troxinium Brick";
						useStyle = 1;
						useAnimation = 15;
						useTime = 10;
						consumable = true;
						useTurn = true;
						autoReuse = true;
						createTile = 423;
						maxStack = 999;
						width = 12;
						height = 12;
						break;

					case 3476:
						name = "Duratanium Brick Wall";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 7;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createWall = 195;
						width = 12;
						height = 12;
						break;

					case 3477:
						name = "Naquadah Brick Wall";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 7;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createWall = 196;
						width = 12;
						height = 12;
						break;

					case 3478:
						name = "Troxinium Brick Wall";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 7;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createWall = 197;
						width = 12;
						height = 12;
						break;

					case 3479:
						name = "Soul of Time";
						width = 22;
						height = 22;
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createTile = 424;
						noUseGraphic = true;
						value = 150000;
						rare = 7;
						toolTip = "'The essence of the ages'";
						break;

					case 3480:
						name = "Tome of Luck";
						width = 24;
						height = 28;
						accessory = true;
						toolTip = "Provides immunity to Pyroscoric and Tritanorium burns";
						toolTip2 = "7% increased critical strike chance";
						rare = 7;
						value = Item.sellPrice(0, 5, 0, 0);
						break;

					case 3481:
						name = "Timechanger Mk II";
						width = 24;
						height = 24;
						shoot = 559;
						useStyle = 1;
						useTime = 30;
						useAnimation = 15;
						UseSound = SoundID.Item1;
						value = Item.sellPrice(0, 3, 70, 0);
						rare = 6;
						break;

					case 3482:
						name = "Sapphire Wall";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 7;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createWall = 200;
						width = 12;
						height = 12;
						break;

					case 3483:
						name = "Ruby Wall";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 7;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createWall = 202;
						width = 12;
						height = 12;
						break;

					case 3484:
						name = "Emerald Wall";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 7;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createWall = 201;
						width = 12;
						height = 12;
						break;

					case 3485:
						name = "Topaz Wall";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 7;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createWall = 199;
						width = 12;
						height = 12;
						break;

					case 3486:
						name = "Amethyst Wall";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 7;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createWall = 198;
						width = 12;
						height = 12;
						break;

					case 3487:
						name = "Diamond Wall";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 7;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createWall = 203;
						width = 12;
						height = 12;
						break;

					case 3488:
						name = "Impervious Brick Wall";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 7;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createWall = 204;
						width = 12;
						height = 12;
						break;

					case 3489:
						name = "Gem Wand";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 15;
						autoReuse = true;
						gemWand = true;
						width = 28;
						height = 28;
						toolTip = "Places ore-form gems";
						break;

					case 3490:
						name = "Vertebrae Bookcase";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 101;
						placeStyle = 30;
						width = 20;
						height = 20;
						value = 300;
						break;

					case 3491:
						noWet = true;
						name = "Vertebrae Candle";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 33;
						placeStyle = 28;
						width = 8;
						height = 18;
						break;

					case 3492:
						name = "Vertebrae Chair";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 15;
						placeStyle = 35;
						width = 12;
						height = 30;
						break;

					case 3493:
						name = "Vertebrae Chest";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 21;
						placeStyle = 38;
						width = 26;
						height = 22;
						value = 500;
						break;

					case 3494:
						name = "Vertebrae Door";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						maxStack = 99;
						consumable = true;
						createTile = 10;
						placeStyle = 35;
						width = 14;
						height = 28;
						value = 200;
						break;

					case 3495:
						name = "Vertebrae Lantern";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createTile = 42;
						placeStyle = 34;
						width = 12;
						height = 28;
						break;

					case 3496:
						name = "Vertebrae Platform";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createTile = 19;
						placeStyle = 29;
						width = 8;
						height = 10;
						break;

					case 3497:
						name = "Vertebrae Work Bench";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 18;
						placeStyle = 30;
						width = 28;
						height = 14;
						value = 150;
						toolTip = "Used for basic crafting";
						break;

					case 3532:
						name = "Desert Beak Mask";
						width = 28;
						height = 20;
						headSlot = 202;
						rare = 1;
						vanity = true;
						value = Item.sellPrice(0, 2, 0, 0);
						break;

					case 3533:
						name = "Opal Gemspark Block";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createTile = 425;
						width = 12;
						height = 12;
						break;

					case 3534:
						name = "Sword Net";
						useTurn = true;
						melee = true;
						useStyle = 1;
						damage = 15;
						knockBack = 1.2f;
						useAnimation = 23;
						useTime = 23;
						width = 24;
						height = 28;
						UseSound = SoundID.Item1;
						value = Item.buyPrice(0, 1, 0, 0);
						autoReuse = true;
						break;

					case 3535:
						name = "Excalibur Net";
						useTurn = true;
						melee = true;
						useStyle = 1;
						damage = 43;
						knockBack = 4.2f;
						useAnimation = 23;
						rare = 4;
						useTime = 23;
						width = 60;
						height = 60;
						UseSound = SoundID.Item1;
						value = Item.buyPrice(0, 3, 0, 0);
						autoReuse = true;
						break;

					case 3536:
						name = "Oblivionet";
						useTurn = true;
						melee = true;
						useStyle = 1;
						damage = 70;
						knockBack = 6.2f;
						useAnimation = 21;
						rare = 8;
						useTime = 21;
						width = 54;
						height = 54;
						UseSound = SoundID.Item1;
						value = Item.buyPrice(0, 5, 0, 0);
						autoReuse = true;
						break;

					case 3537:
						name = "Terra Claws";
						width = 26;
						height = 30;
						accessory = true;
						value = Item.sellPrice(0, 15, 0, 0);
						rare = 12;
						toolTip = "Increases melee damage and speed by 10%";
						toolTip2 = "Melee attacks will burn, poison, envenom, frostburn, or ichor your enemies";
						break;

					case 3538:
						name = "Oblivion Trophy";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 240;
						width = 30;
						height = 30;
						value = Item.sellPrice(0, 1, 0, 0);
						placeStyle = 59;
						rare = 9;
						break;

					case 3539:
						name = "Armageddon Slime Mask";
						width = 28;
						height = 20;
						headSlot = 203;
						rare = 3;
						vanity = true;
						value = Item.sellPrice(0, 2, 0, 0);
						break;

					case 3540:
						name = "Bacterium Prime Mask";
						width = 28;
						height = 20;
						headSlot = 204;
						rare = 1;
						vanity = true;
						value = Item.sellPrice(0, 2, 0, 0);
						break;

					case 3541:
						name = "Hallow Statue";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 337;
						width = 20;
						height = 20;
						value = 300;
						placeStyle = 37;
						break;

					case 3542:
						name = "Tome Statue";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 337;
						width = 20;
						height = 20;
						value = 300;
						placeStyle = 36;
						break;

					case 3543:
						name = "Blue Lihzahrd Statue";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 337;
						width = 20;
						height = 20;
						value = 300;
						placeStyle = 38;
						break;

					case 3544:
						name = "Contagion Statue";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 337;
						width = 20;
						height = 20;
						value = 300;
						placeStyle = 39;
						break;

					case 3545:
						name = "Crimson Statue";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 337;
						width = 20;
						height = 20;
						value = 300;
						placeStyle = 40;
						break;

					case 3546:
						name = "Angel Sculpture";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 337;
						width = 20;
						height = 20;
						value = 300;
						placeStyle = 41;
						break;

					case 3547:
						name = "DNA Sculpture";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 337;
						width = 20;
						height = 20;
						value = 300;
						placeStyle = 42;
						break;

					case 3548:
						name = "Mint Chocolate Candy Cane Block";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createTile = 427;
						width = 12;
						height = 12;
						break;

					case 3549:
						name = "Red Velvet Candy Cane Block";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createTile = 428;
						width = 12;
						height = 12;
						break;

					case 3550:
						name = "Mint Chocolate Candy Cane Wall";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 7;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createWall = 206;
						width = 12;
						height = 12;
						break;

					case 3551:
						name = "Red Velvet Candy Cane Wall";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 7;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createWall = 205;
						width = 12;
						height = 12;
						break;

					case 3552:
						name = "Rainbow Candy Cane Block";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createTile = 429;
						width = 12;
						height = 12;
						break;

					case 3553:
						name = "Rainbow Candy Cane Wall";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 7;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createWall = 207;
						width = 12;
						height = 12;
						break;

					case 3554:
						name = "Nasty Spike";
						useStyle = 1;
						useAnimation = 15;
						useTime = 10;
						consumable = true;
						useTurn = true;
						autoReuse = true;
						createTile = 430;
						maxStack = 999;
						ammo = 147;
						width = 12;
						height = 12;
						value = Item.sellPrice(0, 0, 1, 0);
						rare = 4;
						break;

					case 3555:
						name = "Eyes' Pamphlet";
						useStyle = 4;
						useTime = 45;
						useAnimation = 45;
						value = 0;
						height = 18;
						width = 24;
						toolTip = "Summons three Eyes of Cthulhu";
						rare = 3;
						consumable = true;
						maxStack = 30;
						break;

					case 3556:
						mana = 25;
						damage = 90;
						useStyle = 1;
						name = "Aqua Impact";
						shootSpeed = 6f;
						shoot = 563;
						width = 26;
						height = 28;
						UseSound = SoundID.Item20;
						useAnimation = 20;
						useTime = 20;
						rare = 7;
						noMelee = true;
						knockBack = 6f;
						toolTip = "Casts a blast of water";
						value = 100000;
						magic = true;
						break;

					case 3557:
						name = "Missile Bolt";
						shootSpeed = -1f;
						shoot = 564;
						damage = 50;
						width = 10;
						height = 28;
						maxStack = 2000;
						consumable = true;
						ammo = 246;
						knockBack = 3f;
						value = 150;
						rare = 8;
						ranged = true;
						break;

					case 3558:
						autoReuse = true;
						useStyle = 1;
						name = "Phantom Knives";
						shootSpeed = 15f;
						shoot = 565;
						damage = 51;
						width = 18;
						height = 20;
						UseSound = SoundID.Item39;
						useAnimation = 16;
						useTime = 16;
						mana = 18;
						noUseGraphic = true;
						noMelee = true;
						value = Item.sellPrice(0, 30, 0, 0);
						knockBack = 3.75f;
						magic = true;
						rare = 9;
						toolTip = "Rapidly throws daggers that compound damage upon hitting a target";
						break;

					case 3559:
						name = "Ectoplasm Bathtub";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 90;
						placeStyle = 30;
						width = 20;
						height = 20;
						value = 300;
						break;

					case 3560:
						name = "Ectoplasm Bed";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						maxStack = 99;
						consumable = true;
						autoReuse = true;
						createTile = 79;
						placeStyle = 30;
						width = 28;
						height = 20;
						value = 2000;
						break;

					case 3561:
						name = "Ectoplasm Bookcase";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 101;
						placeStyle = 32;
						width = 20;
						height = 20;
						value = 300;
						break;

					case 3562:
						name = "Ectoplasm Candelabra";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 100;
						placeStyle = 30;
						width = 20;
						height = 20;
						value = 1500;
						break;

					case 3563:
						noWet = true;
						name = "Ectoplasm Candle";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 33;
						placeStyle = 30;
						width = 8;
						height = 18;
						break;

					case 3564:
						name = "Ectoplasm Chair";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 15;
						placeStyle = 37;
						width = 12;
						height = 30;
						break;

					case 3565:
						name = "Ectoplasm Chandelier";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 34;
						placeStyle = 36;
						width = 26;
						height = 26;
						value = 3000;
						break;

					case 3566:
						name = "Ectoplasm Clock";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 104;
						placeStyle = 26;
						width = 20;
						height = 20;
						value = 300;
						break;

					case 3567:
						name = "Ectoplasm Dresser";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 88;
						placeStyle = 27;
						width = 20;
						height = 20;
						value = 300;
						break;

					case 3568:
						name = "Ectoplasm Lamp";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 93;
						placeStyle = 30;
						width = 10;
						height = 24;
						value = 500;
						break;

					case 3569:
						name = "Ectoplasm Lantern";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createTile = 42;
						placeStyle = 36;
						width = 12;
						height = 28;
						break;

					case 3570:
						name = "Ectoplasm Piano";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 87;
						placeStyle = 29;
						width = 20;
						height = 20;
						value = 300;
						break;

					case 3571:
						name = "Ectoplasm Sofa";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 89;
						placeStyle = 32;
						width = 20;
						height = 20;
						value = 300;
						break;

					case 3572:
						name = "Ectoplasm Table";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 14;
						placeStyle = 35;
						width = 26;
						height = 20;
						value = 300;
						break;

					case 3573:
						name = "Ectoplasm Work Bench";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 99;
						consumable = true;
						createTile = 18;
						placeStyle = 32;
						width = 28;
						height = 14;
						value = 150;
						toolTip = "Used for basic crafting";
						break;

					case 3574:
						name = "Chaos Charm";
						width = 20;
						height = 24;
						value = 150000;
						toolTip = "Critical strike chance increases as your health drops";
						accessory = true;
						rare = 5;
						break;

					case 3575:
						name = "Chaos Eye";
						width = 20;
						height = 24;
						value = 3450000;
						toolTip = "Critical strike chance increases as your health drops";
						toolTip2 = "8% increased critical strike chance";
						accessory = true;
						rare = 9;
						break;

					case 3576:
						name = "Echoplasm";
						width = 18;
						height = 18;
						maxStack = 999;
						value = Item.sellPrice(0, 0, 5, 0);
						rare = 8;
						break;

					case 3577:
						name = "Heartstone Platform";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createTile = 19;
						placeStyle = 30;
						width = 8;
						height = 10;
						break;

					case 3578:
						name = "Ectoplasm Platform";
						useStyle = 1;
						useTurn = true;
						useAnimation = 15;
						useTime = 10;
						autoReuse = true;
						maxStack = 999;
						consumable = true;
						createTile = 19;
						placeStyle = 31;
						width = 8;
						height = 10;
						break;

					case 3579:
						name = "Trifectal";
						width = height = 30;
						scale = 1.5f;
						value = Item.sellPrice(0, 15, 70, 0);
						rare = crit = 8;
						toolTip = "Splits into three balls";
						useStyle = 5;
						useAnimation = useTime = 45;
						damage = 75;
						knockBack = 8f;
						UseSound = SoundID.Item1;
						melee = noUseGraphic = noMelee = channel = true;
						shoot = 566;
						shootSpeed = 15f;
						break;

					case 3580:
						name = "Energized Weapon Staff";
						useStyle = 1;
						shootSpeed = 14f;
						shoot = 568;
						damage = 62;
						width = 38;
						height = 36;
						UseSound = SoundID.Item44;
						buffType = 170;
						useAnimation = 30;
						useTime = 30;
						noMelee = true;
						value = Item.sellPrice(0, 30, 0, 0);
						knockBack = 2.5f;
						rare = 9;
						summon = true;
						mana = 30;
						break;
				}
			}

			if (offsetType == 3498) {
				name = "Bomb Skeleton Banner";
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				autoReuse = true;
				maxStack = 999;
				consumable = true;
				createTile = 91;
				placeStyle = 176;
				width = 10;
				height = 24;
				value = 1000;
				rare = 1;
			}

			if (offsetType >= 3499 && offsetType <= 3514) {
				name = "Ore Slime Banners";
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				autoReuse = true;
				maxStack = 999;
				consumable = true;
				createTile = 91;
				placeStyle = 177 + offsetType - 3499;
				width = 10;
				height = 24;
				value = 1500;
				rare = 1;
			}

			if (offsetType == 3515) {
				name = "Heartstone Bathtub";
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				autoReuse = true;
				maxStack = 99;
				consumable = true;
				createTile = 90;
				placeStyle = 29;
				width = 20;
				height = 20;
				value = 300;
			}

			if (offsetType == 3516) {
				name = "Heartstone Bed";
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				maxStack = 99;
				consumable = true;
				autoReuse = true;
				createTile = 79;
				placeStyle = 29;
				width = 28;
				height = 20;
				value = 2000;
			}

			if (offsetType == 3517) {
				name = "Heartstone Bookcase";
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				autoReuse = true;
				maxStack = 99;
				consumable = true;
				createTile = 101;
				placeStyle = 31;
				width = 20;
				height = 20;
				value = 300;
			}

			if (offsetType == 3518) {
				name = "Heartstone Candelabra";
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				autoReuse = true;
				maxStack = 99;
				consumable = true;
				createTile = 100;
				placeStyle = 29;
				width = 20;
				height = 20;
				value = 1500;
			}

			if (offsetType == 3519) {
				noWet = true;
				name = "Heartstone Candle";
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				autoReuse = true;
				maxStack = 99;
				consumable = true;
				createTile = 33;
				placeStyle = 29;
				width = 8;
				height = 18;
			}

			if (offsetType == 3520) {
				name = "Heartstone Chair";
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				autoReuse = true;
				maxStack = 99;
				consumable = true;
				createTile = 15;
				placeStyle = 36;
				width = 12;
				height = 30;
			}

			if (offsetType == 3521) {
				name = "Heartstone Chandelier";
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				autoReuse = true;
				maxStack = 99;
				consumable = true;
				createTile = 34;
				placeStyle = 35;
				width = 26;
				height = 26;
				value = 3000;
			}

			if (offsetType == 3522) {
				name = "Heartstone Chest";
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				autoReuse = true;
				maxStack = 99;
				consumable = true;
				createTile = 21;
				placeStyle = 40;
				width = 26;
				height = 22;
				value = 500;
			}

			if (offsetType == 3523) {
				name = "Heartstone Clock";
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				autoReuse = true;
				maxStack = 99;
				consumable = true;
				createTile = 104;
				placeStyle = 25;
				width = 20;
				height = 20;
				value = 300;
			}

			if (offsetType == 3524) {
				name = "Heartstone Door";
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				maxStack = 99;
				consumable = true;
				createTile = 10;
				placeStyle = 36;
				width = 14;
				height = 28;
				value = 200;
			}

			if (offsetType == 3525) {
				name = "Heartstone Dresser";
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				autoReuse = true;
				maxStack = 99;
				consumable = true;
				createTile = 88;
				placeStyle = 26;
				width = 20;
				height = 20;
				value = 300;
			}

			if (offsetType == 3526) {
				name = "Heartstone Lamp";
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				autoReuse = true;
				maxStack = 99;
				consumable = true;
				createTile = 93;
				placeStyle = 29;
				width = 10;
				height = 24;
				value = 500;
			}

			if (offsetType == 3527) {
				name = "Heartstone Lantern";
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				autoReuse = true;
				maxStack = 999;
				consumable = true;
				createTile = 42;
				placeStyle = 35;
				width = 12;
				height = 28;
			}

			if (offsetType == 3528) {
				name = "Heartstone Piano";
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				autoReuse = true;
				maxStack = 99;
				consumable = true;
				createTile = 87;
				placeStyle = 28;
				width = 20;
				height = 20;
				value = 300;
			}

			if (offsetType == 3529) {
				name = "Heartstone Sofa";
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				autoReuse = true;
				maxStack = 99;
				consumable = true;
				createTile = 89;
				placeStyle = 31;
				width = 20;
				height = 20;
				value = 300;
			}

			if (offsetType == 3530) {
				name = "Heartstone Table";
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				autoReuse = true;
				maxStack = 99;
				consumable = true;
				createTile = 14;
				placeStyle = 34;
				width = 26;
				height = 20;
				value = 300;
			}

			if (offsetType == 3531) {
				name = "Heartstone Work Bench";
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				autoReuse = true;
				maxStack = 99;
				consumable = true;
				createTile = 18;
				placeStyle = 31;
				width = 28;
				height = 14;
				value = 150;
				toolTip = "Used for basic crafting";
			}

			if (offsetType >= 3581 && offsetType <= 3587) {
				if (offsetType == 3586)
					toolTip2 = "Not the kind you think.";

				switch (offsetType) {
					case 3581:
						toolTip = "Converts tiles to the Purity in a large radius";
						break;

					case 3582:
						toolTip = "Converts tiles to the Corruption in a large radius";
						break;

					case 3583:
						toolTip = "Converts tiles to the Jungle in a large radius";
						break;

					case 3584:
						toolTip = "Converts tiles to the Crimson in a large radius";
						break;

					case 3585:
						toolTip = "Converts tiles to the Contagion in a large radius";
						break;

					case 3586:
						toolTip = "Converts tiles to Mushrooms in a large radius";
						break;

					case 3587:
						toolTip = "Converts tiles to the Hallow in a large radius";
						break;
				}

				createTile = 431;
				placeStyle = offsetType - 3581;
				useAnimation = useTime = 15;
				width = height = 40;
				mech = consumable = autoReuse = useTurn = true;
				rare = 4;
				useStyle = 1;
				maxStack = 999;
			}

			if (offsetType >= 3873 && offsetType <= 3925) {
				name = "Advanced Potion";
				UseSound = SoundID.Item3;
				useStyle = 2;
				useTurn = consumable = true;
				useAnimation = useTime = 17;
				maxStack = 100;
				width = 14;
				height = 24;
				value = 1000;
				rare = 7;
				buffType = offsetType - 3873 + 179;
				switch (offsetType) {
					case 3873:
						buffTime = 28800;
						toolTip = "Provides immunity to lava";
						break;

					case 3874:
						buffTime = 36000;
						toolTip = "Provides life regeneration";
						break;

					case 3875:
						buffTime = 28800;
						toolTip = "50% increased movement speed";
						break;

					case 3876:
						buffTime = 14400;
						toolTip = "Breathe water instead of air";
						break;

					case 3877:
						buffTime = 36000;
						toolTip = "Increase defense by 16";
						break;

					case 3878:
						buffTime = 14400;
						toolTip = "Increased mana regeneration";
						break;

					case 3879:
						buffTime = 36000;
						toolTip = "40% increased magic damage";
						break;

					case 3880:
						buffTime = 36000;
						toolTip = "Slows falling speed";
						break;

					case 3881:
						buffTime = 36000;
						toolTip = "Shows the location of treasure and ore";
						break;

					case 3882:
						buffTime = 14400;
						toolTip = "Grants invisibility";
						break;

					case 3883:
						buffTime = 36000;
						toolTip = "Emits an aura of light";
						break;

					case 3884:
						buffTime = 28800;
						toolTip = "Increases night vision";
						break;

					case 3885:
						buffTime = 50400;
						toolTip = "Increases enemy spawn rate";
						break;

					case 3886:
						buffTime = 21600;
						toolTip = "Attackers also take damage";
						break;

					case 3887:
						buffTime = 36000;
						toolTip = "Allows the ability to walk on liquids";
						break;

					case 3888:
						buffTime = 28800;
						toolTip = "40% increased arrow speed and damage";
						break;

					case 3889:
						buffTime = 36000;
						toolTip = "Shows the location of enemies";
						break;

					case 3890:
						buffTime = 3600 * 12;
						toolTip = "Allows the control of gravity";
						break;

					case 3891:
						buffTime = 36000;
						toolTip = "Increases mining speed";
						break;

					case 3892:
						buffTime = 28800 * 2;
						toolTip = "Increases pickup range for life hearts";
						break;

					case 3893:
						buffTime = 36000;
						toolTip = "Reduces enemy aggression and spawn rate";
						break;

					case 3894:
						buffTime = 108000;
						toolTip = "Increases placement speed and range";
						break;

					case 3895:
						buffTime = 28800;
						toolTip = "Increases knockback";
						break;

					case 3896:
						buffTime = 28800 * 2;
						toolTip = "Lets you to move swiftly in liquids";
						break;

					case 3897:
						buffTime = 43200;
						toolTip = "Increases your max number of minions";
						break;

					case 3898:
						buffTime = 72000;
						toolTip = "Allows you to see nearby traps";
						break;

					case 3899:
						buffTime = 50400;
						toolTip = "Gives 30% chance to not consume ammo";
						break;

					case 3900:
						buffTime = 36000;
						toolTip = "Increases max life by 40%";
						break;

					case 3901:
						buffTime = 28800;
						toolTip = "Reduces damage taken by 20%";
						break;

					case 3902:
						buffTime = 28800;
						toolTip = "Increases critical strike chance by 20%";
						break;

					case 3903:
						buffTime = 28800;
						toolTip = "Ignites nearby enemies";
						break;

					case 3904:
						buffTime = 28800;
						toolTip = "Increases damage by 20%";
						break;

					case 3905:
						buffTime = 28800 * 2;
						toolTip = "Increases fishing skill";
						break;

					case 3906:
						buffTime = 19600 * 2;
						toolTip = "Detects hooked fish";
						break;

					case 3907:
						buffTime = 28800 * 2;
						toolTip = "Increases chance to get a crate";
						break;

					case 3908:
						buffTime = 108000;
						toolTip = "Reduces damage from cold sources";
						break;

					case 3909:
						buffTime = 36000;
						toolTip = "Enemies within a ten tile radius take damage";
						break;

					case 3910:
						buffTime = 50400;
						toolTip = "Enemies take damage when you land";
						break;

					case 3911:
						buffTime = 216000;
						toolTip = "Doubles rare drop chance";
						break;

					case 3912:
						buffTime = 36000;
						toolTip = "Adds your max life to your max mana";
						break;

					case 3913:
						buffTime = 36000;
						toolTip = "Fallen Stars fall more frequently";
						break;

					case 3914:
						buffTime = 21600;
						toolTip = "Open caves light up";
						break;

					case 3915:
						buffTime = 3600 * 18;
						toolTip = "Increases all stats";
						break;

					case 3916:
						buffTime = 36000;
						toolTip = "GPS Effect";
						break;

					case 3917:
						buffTime = 32400 * 2;
						toolTip = "Slows time down";
						break;

					case 3918:
						buffTime = 3600 * 14;
						toolTip = "Enables teleportation to the cursor";
						break;

					case 3919:
						buffTime = 3600 * 9;
						toolTip = "-5% ranged damage, 30% chance to not consume ammo";
						break;

					case 3920:
						buffTime = 36000;
						toolTip = "-6 defense, +25% melee damage";
						break;

					case 3921:
						buffTime = 3600 * 8;
						toolTip = "-4% magic damage, +120 mana";
						break;

					case 3922:
						buffTime = 3600 * 8;
						toolTip = "-6% damage, +20 defense";
						break;

					case 3923:
						buffTime = 1200;
						toolTip = "Grants invincibility";
						break;

					case 3924:
						buffTime = 36000;
						toolTip = "Enables a projectile-reflecting force field";
						break;

					case 3925:
						buffTime = 3600 * 8;
						toolTip = "Increases item grab range";
						break;
				}
			}

			if (offsetType >= 3860 && offsetType <= 3871) {
				name = "Monster Banner 9";
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				autoReuse = true;
				maxStack = 999;
				consumable = true;
				createTile = 91;
				placeStyle = 200 + offsetType - 3860;
				width = 10;
				height = 24;
				value = 1000;
				rare = 1;
			}

			if (offsetType >= 3416 && offsetType <= 3422) {
				name = "Monster Banner 7";
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				autoReuse = true;
				maxStack = 999;
				consumable = true;
				createTile = 91;
				placeStyle = 169 + offsetType - 3416;
				width = 10;
				height = 24;
				value = 1000;
				rare = 1;
			}

			if (offsetType == 3748) // 1000th item
{
				rare = 8;
				UseSound = SoundID.Item1;
				name = "Berserker Blade";
				useStyle = 1;
				damage = 122;
				useTurn = true;
				useAnimation = 16;
				autoReuse = true;
				useTime = 16;
				width = 74;
				height = 74;
				scale = 1f;
				knockBack = 8f;
				toolTip = "'Go berserk!'";
				melee = true;
				value = Item.sellPrice(0, 12);
			}

			if (offsetType >= 3683 && offsetType <= 3687) {
				name = "Golden Tombstone";
				useTurn = true;
				useStyle = 1;
				useAnimation = 15;
				useTime = 10;
				maxStack = 99;
				consumable = true;
				createTile = 85;
				placeStyle = 6 + offsetType - 3683;
				width = 20;
				height = 20;
			}

			if (offsetType >= 3592 && offsetType <= 3603) {
				name = "Beams";
				useStyle = 1;
				useTurn = autoReuse = consumable = true;
				useAnimation = 15;
				useTime = 10;
				maxStack = 999;
				createTile = offsetType - 3160;
				width = height = 12;
			}

			if (offsetType >= 3416 && offsetType <= 3422) {
				name = "Monster Banner 7";
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				autoReuse = true;
				maxStack = 999;
				consumable = true;
				createTile = 91;
				placeStyle = 169 + offsetType - 3416;
				width = 10;
				height = 24;
				value = 1000;
				rare = 1;
			}

			if (offsetType >= 3675 && offsetType <= 3679) {
				name = "Gemspark Block 2";
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				autoReuse = true;
				maxStack = 999;
				consumable = true;
				createTile = 459 + offsetType - 3675;
				width = 12;
				height = 12;
			}

			if (offsetType >= 3618 && offsetType <= 3624) {
				name = "Monster Banner 8";
				useStyle = 1;
				useTurn = true;
				useAnimation = 15;
				useTime = 10;
				autoReuse = true;
				maxStack = 999;
				consumable = true;
				createTile = 91;
				placeStyle = 193 + offsetType - 3618;
				width = 10;
				height = 24;
				value = (offsetType == 3624 || offsetType == 3623) ? 100000 : 1500;
				rare = 1;
			}

			if (offsetType >= 3625 && offsetType <= 3628) {
				name = "Colored Flares";
				shootSpeed = 6f;
				shoot = offsetType - 3625 + 577;
				damage = 1;
				width = 12;
				height = 12;
				maxStack = 999;
				consumable = true;
				ammo = 931;
				knockBack = 1.5f;
				value = 7;
				ranged = true;
			}

			if (offsetType == 3194) {
				name = "Phantoplasm";
				useStyle = 1;
				useAnimation = 15;
				useTime = 10;
				consumable = true;
				useTurn = true;
				autoReuse = true;
				createTile = 387;
				maxStack = 999;
				width = 16;
				height = 14;
				value = Item.sellPrice(0, 1, 0, 0);
				rare = 10;
			}

			if (offsetType >= 3700 && offsetType <= 3709) {
				name = "Large Herbs";
				useTurn = true;
				useStyle = 1;
				useAnimation = 15;
				useTime = 15;
				maxStack = 999;
				consumable = true;
				createTile = 472;
				placeStyle = offsetType - 3700;
				width = 12;
				height = 20;
				value = 500;
			}

			if (offsetType >= 3710 && offsetType <= 3719) {
				name = "Large Herb Seeds";
				useTurn = true;
				useStyle = 1;
				useAnimation = 15;
				useTime = 15;
				maxStack = 999;
				consumable = true;
				createTile = 469;
				placeStyle = offsetType - 3710;
				width = 12;
				height = 20;
				value = 100;
			}
		}
	}
}
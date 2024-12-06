namespace Class15_ExampleCode.Models
{
    public class ItemManager
    {
        public List<Item> Items { get; set; } = new List<Item>();

        public ItemManager()
        {
            PopulateItems();
        }

        // method used for paging
        public List<Item> GetItems(int page, int pageSize)
        {
            return Items.Skip(pageSize*page).Take(pageSize).ToList();
        }

        // randomly populate items into the public Items List
        public void PopulateItems()
        {
            var random = new Random();
            var itemNames = new List<string>
            {
                "Mystic Sword", "Healing Potion", "Magic Wand", "Dragon Scale",
                "Iron Shield", "Phoenix Feather", "Elixir of Wisdom", "Golden Chalice",
                "Silver Dagger", "Ancient Scroll", "Enchanted Amulet", "Crystal Ball",
                "Ring of Power", "Cloak of Invisibility", "Gem of Truth", "Boots of Speed",
                "Staff of Fire", "Orb of Light", "Key of Destiny", "Helm of Valor",
                "Spellbook of Flames", "Runed Axe", "Scroll of Teleportation",
                "Ethereal Armor", "Chalice of Eternity", "Potion of Strength",
                "Thunder Hammer", "Divine Robe", "Mirror of Illusion", "Map of Secrets",
                "Cursed Coin", "Bag of Holding", "Lucky Charm", "Storm Ring",
                "Shadow Cloak", "Emerald Talisman", "Timepiece of Eternity", "Battle Horn",
                "Crystal Shard", "Sword of the Ancients", "Lunar Pendant",
                "Tome of Knowledge", "Pendant of Protection", "Crown of Kings",
                "Wand of Ice", "Ruby of Passion", "Chainmail of Frost",
                "Greaves of Thunder", "Earrings of Clarity", "Potion of Luck",
                "Elven Bow", "Scepter of Light", "Orb of Shadows", "Dragon Fang",
                "Golden Helm", "Abyssal Whip", "Staff of the Earth", "Flask of Mana",
                "Lantern of Guidance", "Arrow of Precision", "Shield of the Phoenix",
                "Sword of Light", "Boots of Levitation", "Cloak of Shadows",
                "Gauntlets of Power", "Horn of the Unicorn", "Ring of Eternity",
                "Scythe of Despair", "Lantern of the Abyss", "Scroll of Binding",
                "Vial of Dragon's Blood", "Pendant of Serenity", "Mantle of the Moon",
                "Cloak of Storms", "Helmet of Insight", "Amulet of Courage",
                "Scroll of the Void", "Talisman of Harmony", "Hammer of the Titan",
                "Crystal Staff", "Gem of the Void", "Tome of Eternal Flame",
                "Blade of Shadows", "Shield of the Guardian", "Mirror of Souls",
                "Staff of Eternity", "Orb of Night", "Ring of Shadows",
                "Pendant of the Sun", "Sapphire of the Skies", "Torch of the Ancients",
                "Boots of the Wind", "Orb of Infinity", "Helmet of Dawn",
                "Ring of the Storm", "Armor of the Eternal", "Locket of the Stars",
                "Pendant of the Cosmos"
            };

            for (int i = 1; i <= 100; i++)
            {
                var randomIndex = random.Next(itemNames.Count);
                Items.Add(new Item { Id = i, Name = itemNames[randomIndex] });
            }

        }
    }
}


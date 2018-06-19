using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCreator
{
   

    public class Character
    {
        public static List<string> skills = new List<string>();
        public static List<string> equipment = new List<string>();
        public static List<string> languages = new List<string>();
        public static List<string> proficiencies = new List<string>();
        public static List<string> traits = new List<string>();
        public static List<weapons> weapon = new List<weapons>();
        public static List<string> clickedWeapons = new List<string>();


        public string name, race, type, background;

        public int strength, dexterity, constitution, inteligence, wisdom, charisma;

        public  int armorClass, speed, hitPoints;

        public  int strMod, dexMod, constMod, intMod, wisMod, chaMod = 0;

        public  int strST, dexST, constST, intST, wisST, chaST;

        public  int proficiency = 2;

        public  string hitDie;

        public Character()
        { }

        public Character(string _name, string _race, string _type, string _background, int _strST, int _dexST, int _constST, int _intST, int _wisST, int _chaST,int _proficiency, int _strength, int _dexterity, int _constitution, int _inteligence, int _wisdom, int _charisma, int _armorClass, int _speed, int _hitPoints, string _hitDie, int _strMod, int _dexMod, int _constMod, int _intMod, int _wisMod, int _chaMod, List<string> _skills, List<string> _languages, List<string> _proficiencies, List<string> _equipment, List<string> _traits, List<weapons> _weapon)
        {
            name = _name;
            race = _race;
            type = _type;
            background = _background;
            strength = _strength;
            dexterity = _dexterity;
            constitution = _constitution;
            inteligence = _inteligence;
            wisdom = _wisdom;
            charisma = _charisma;
            armorClass = _armorClass;
            speed = _speed;
            hitPoints = _hitPoints;
            hitDie = _hitDie;
            skills = _skills;
            equipment = _equipment;
            languages = _languages;
            proficiencies = _proficiencies;
            traits = _traits;
            weapon = _weapon;
            strMod = _strMod;
            dexMod = _dexMod;
            constMod = _constMod;
            intMod = _intMod;
            wisMod = _wisMod;
            chaMod = _chaMod;
            proficiency = _proficiency;
            strST = _strST;
            dexST = _dexST;
            constST = _constST;
            intST = _intST;
            wisST = _wisST;
            chaST = _chaST;

            

            //RACES
            if (race == "Half-Elf")
            {
                charisma = charisma + 2;
                //TODO: add in the function of choosing 2 ability scores

                speed = 30;
                traits.Add("Darkvision");
                traits.Add("Fey Ancestry");
                proficiencies.Add("Skill Versatility");
                //TODO: add in the function of choosing 2 skills
                languages.Add("Common");
                languages.Add("Elvish");
                languages.Add("One Extra"); 

            }
            else if (race == "Half-Orc")
            {
                strength = strength + 2;
                constitution = constitution + 1;
                speed = 30;
                traits.Add("Darkvision");
                traits.Add("Menacing");
                traits.Add("Relentless Endurance");
                traits.Add("Savage Attacks");
                languages.Add("Common");
                languages.Add("Orc");
                skills.Add("Intimidation");

            }
            else if (race == "High Elf")
            {
                dexterity = dexterity + 2;
                inteligence = inteligence + 1;
                traits.Add("Elf Weapon Training");
                proficiencies.Add("Longsword");
                proficiencies.Add("Shortsword");
                proficiencies.Add("Shortbow");
                proficiencies.Add("Longbow");
                traits.Add("Extra Cantrip");
                speed = 30;
                traits.Add("Darkvision");
                traits.Add("Keen Senses");
                traits.Add("Fey Ancestry");
                traits.Add("Trance");
                languages.Add("Common");
                languages.Add("Elvish");
                languages.Add("One Extra");
                skills.Add("Perception");
            }
            else if (race == "Wood Elf")
            {
                dexterity = dexterity + 2;
                wisdom = wisdom + 1;
                proficiencies.Add("Elf Weapon Training");
                proficiencies.Add("Longsword");
                proficiencies.Add("Shortsword");
                proficiencies.Add("Shortbow");
                proficiencies.Add("Longbow");
                traits.Add("Fleet Footed");
                traits.Add("Mask of the Wild");
                speed = 35;
                traits.Add("Darkvision");
                traits.Add("Keen Senses");
                traits.Add("Fey Ancestry");
                traits.Add("Trance");
                languages.Add("Common");
                languages.Add("Elvish");
                skills.Add("Perception");
            }
            else if (race == "Dark Elf")
            {
                dexterity = dexterity + 2;
                charisma = charisma + 1;
                traits.Add("Drow Weapon Training");
                proficiencies.Add("Rapier");
                proficiencies.Add("Shortsword");
                proficiencies.Add("Hand Crossbow");
                traits.Add("Drow Magic");
                traits.Add("Sunlight Sensitivity");
                speed = 35;
                traits.Add("Superior Darkvision");
                traits.Add("Keen Senses");
                skills.Add("Perception");
                traits.Add("Fey Ancestry");
                traits.Add("Trance");
                languages.Add("Common");
                languages.Add("Elvish");
            }
            else if (race == "Hill Dwarf")
            {
                constitution = constitution + 2;
                wisdom = wisdom + 1;
                traits.Add("Dwarven Toughness");
                speed = 25;
                traits.Add("Darkvision");
                traits.Add("Dwarven Resilience");
                traits.Add("Dwarven Combat Training");
                proficiencies.Add("Battleaxe");
                proficiencies.Add("Handaxe");
                proficiencies.Add("Light Hammer");
                proficiencies.Add("Warhammer");
                traits.Add("Stonecutting");
                traits.Add("Artisan Tool Proficiency");
                languages.Add("Common");
                languages.Add("Dwarvish");
            }
            else if (race == "Mountain Dwarf")
            {
                constitution = constitution + 2;
                strength = strength + 2;
                traits.Add("Dwarven Armor Training");
                proficiencies.Add("Medium Armor");
                proficiencies.Add("Light Armor");
                speed = 25;
                traits.Add("Darkvision");
                traits.Add("Dwarven Resilience");
                traits.Add("Dwarven Combat Training");
                proficiencies.Add("Battleaxe");
                proficiencies.Add("Handaxe");
                proficiencies.Add("Light Hammer");
                proficiencies.Add("Warhammer");
                traits.Add("Stonecutting");
                traits.Add("Artisan Tool Proficiency");
                languages.Add("Common");
                languages.Add("Dwarvish");
            }
            else if (race == "Human")
            {
                strength = strength + 1;
                dexterity = dexterity + 1;
                constitution = constitution + 1;
                inteligence = inteligence + 1;
                wisdom = wisdom + 1;
                charisma = charisma + 1;
                speed = 30;
                languages.Add("Common");
                languages.Add("One Extra");
            }
            else if (race == "Tiefling")
            {
                inteligence = inteligence + 1;
                charisma = charisma + 2;
                speed = 30;
                traits.Add("Darkvision");
                traits.Add("Hellish Resistance");
                traits.Add("Infernal Legacy");
                languages.Add("Common");
                languages.Add("Infernal");
            }
            else if (race == "Lightfoot Halfling")
            {
                dexterity = dexterity + 2;
                charisma = charisma + 1;
                traits.Add("Naturally Stealthy");
                speed = 25;
                traits.Add("Lucky");
                traits.Add("Brave");
                traits.Add("Halfling Nimbleness");
                languages.Add("Common");
                languages.Add("Halfling");
            }
            else if (race == "Stout Halfling")
            {
                dexterity = dexterity + 2;
                constitution = constitution + 1;
                traits.Add("Stout Resilience");
                speed = 25;
                traits.Add("Lucky");
                traits.Add("Brave");
                traits.Add("Halfling Nimbleness");
                languages.Add("Common");
                languages.Add("Halfling");
            }
            else if (race == "Dragonborn")
            {
                strength = strength + 2;
                charisma = charisma + 1;
                speed = 30;
                traits.Add("Dragonic Ancestry");
                traits.Add("Breath Weapon");
                traits.Add("Damage Resistance");
                languages.Add("Common");
                languages.Add("Dragonic");
            }
            else if (race == "Forest Gnome")
            {
                inteligence = inteligence + 2;
                dexterity = dexterity + 1;
                traits.Add("Natural Illusionist");
                traits.Add("Speak with Small Beasts");
                speed = 25;
                traits.Add("Darkvision");
                traits.Add("Gnome Cunning");
                languages.Add("Common");
                languages.Add("Gnomish");
            }
            else if (race == "Rock Gnome")
            {
                inteligence = inteligence + 2;
                constitution = constitution + 1;
                traits.Add("Artificer's Lore");
                traits.Add("Tinker");
                speed = 25;
                traits.Add("Darkvision");
                traits.Add("Gnome Cunning");
                languages.Add("Common");
                languages.Add("Gnomish");
            }

            //CLASSES
            //TODO: Come back for skill choice
            if (type == "Cleric")
            {
                hitPoints = 8 + constMod;
                hitDie = "1d8";
                proficiencies.Add("Light Armor");
                proficiencies.Add("Medium Armor");
                proficiencies.Add("Sheilds");
                proficiencies.Add("Simple Weapons");
                strST = strMod;
                dexST = dexMod;
                constST = constMod;
                wisST = wisMod + proficiency;
                intST = intMod;
                chaST = chaMod + proficiency;
                equipment.Add("Shield");
                equipment.Add("Holy Symbol");
                traits.Add("Spellcasting");
                traits.Add("Devine Domain");
            }
            else if (type == "Druid")
            {
                hitPoints = 8 + constMod;
                hitDie = "1d8";
                proficiencies.Add("Light Armor");
                proficiencies.Add("Medium Armor");
                proficiencies.Add("Sheilds");
                proficiencies.Add("Clubs");
                proficiencies.Add("Daggers");
                proficiencies.Add("Darts");
                proficiencies.Add("Javelins");
                proficiencies.Add("Maces");
                proficiencies.Add("Quarterstaffs");
                proficiencies.Add("Scimitars");
                proficiencies.Add("Sickles");
                proficiencies.Add("Slings");
                proficiencies.Add("Spears");
                proficiencies.Add("Herbalism Kits");
                strST = strMod;
                dexST = dexMod;
                constST = constMod;
                wisST = wisMod + proficiency;
                intST = intMod + proficiency;
                chaST = chaMod;
                equipment.Add("Leather Armor");
                equipment.Add("Druidic Focus");
                equipment.Add("Explorer's Pack");
                traits.Add("Spellcasting");
                traits.Add("Druidic");
            }
            else if (type == "Barbarian")
            {
                hitPoints = 12 + constMod;
                hitDie = "1d12";
                proficiencies.Add("Light Armor");
                proficiencies.Add("Medium Armor");
                proficiencies.Add("Shields");
                proficiencies.Add("Simple Weapons");
                proficiencies.Add("Martial Weapons");
                strST = strMod + proficiency;
                dexST = dexMod;
                constST = constMod + proficiency;
                wisST = wisMod;
                intST = intMod;
                chaST = chaMod;
                equipment.Add("Explorer's Pack");
                weapons newweapon;
                newweapon = new weapons("Javelin X4", proficiency + strMod, "1d6 Piercing");
                weapon.Add(newweapon);
                //newweapon = new weapons("Battleaxe", proficiency + strMod, "1d8 Slashing");
                //weapon.Add(newweapon);
                traits.Add("Rage");
                traits.Add("Unarmored Defence");
            }
            else if (type == "Rogue")
            {
                hitPoints = 8 + constMod;
                hitDie = "1d8";
                proficiencies.Add("Light Armor");
                strST = strMod;
                dexST = dexMod + proficiency;
                constST = constMod;
                wisST = wisMod;
                intST = intMod + proficiency;
                chaST = chaMod;
                proficiencies.Add("Simple Weapons");
                proficiencies.Add("Hand Crossbow");
                proficiencies.Add("Longswords");
                proficiencies.Add("Rapiers");
                proficiencies.Add("Shortswords");
                proficiencies.Add("Thieves' Tools");
                traits.Add("Sneak Attack");
                traits.Add("Expertise");
                traits.Add("Thieves Cant");
                equipment.Add("Leather Armor");
                weapons newweapon;
                newweapon = new weapons("Dagger X2", proficiency + dexMod, "1d4 Piercing");
                weapon.Add(newweapon);

            }
            else if (type == "Paladin")
            {
                hitDie = "1d10";
                hitPoints = 10 + constMod;
                proficiencies.Add("All Armor");
                proficiencies.Add("Sheilds");
                proficiencies.Add("Simple Weapons");
                proficiencies.Add("Martial Weapons");
                strST = strMod;
                dexST = dexMod;
                constST = constMod;
                wisST = wisMod + proficiency;
                intST = intMod;
                chaST = chaMod + proficiency;
                equipment.Add("Chain Mail");
                equipment.Add("Holy Symbol");
                traits.Add("Lay on Hands");
                traits.Add("Divine Sense");
            }
            else if (type == "Monk")
            {
                hitPoints = 8 + constMod;
                hitDie = "1d8";
                proficiencies.Add("Simple Weapons");
                proficiencies.Add("Shortswords");
                proficiencies.Add("Artisan's Tools or Musical Instument");
                strST = strMod + proficiency;
                dexST = dexMod + proficiency;
                constST = constMod;
                wisST = wisMod;
                intST = intMod;
                chaST = chaMod;
                weapons newweapon;
                newweapon = new weapons("Dart X10", proficiency + dexMod, "1d4 Piercing");
                weapon.Add(newweapon);
                traits.Add("Unarmored Defence");
                traits.Add("Martial Arts");
            }
            else if (type == "Bard")
            {
                hitDie = "1d8";
                hitPoints = 8 + constMod;
                proficiencies.Add("Light Armor");
                proficiencies.Add("Simple Weapons");
                proficiencies.Add("Hand Crossbow");
                proficiencies.Add("Longswords");
                proficiencies.Add("Rapiers");
                proficiencies.Add("Shortswords");
                proficiencies.Add("Three Musical Instuments");
                strST = strMod;
                dexST = dexMod + proficiency;
                constST = constMod;
                wisST = wisMod;
                intST = intMod;
                chaST = chaMod + proficiency;
                equipment.Add("Leather Armor");
                weapons newweapon;
                newweapon = new weapons("Dagger", proficiency + strMod, "1d4 Piercing");
                weapon.Add(newweapon);
                traits.Add("Spellcasting");
                traits.Add("Bardic Inspiration");
                //choose 3 skills 
            }
            else if (type == "Wizard")
            {
                hitDie = "1d6";
                hitPoints = 6 + constMod;
                proficiencies.Add("Daggers");
                proficiencies.Add("Darts");
                proficiencies.Add("Slings");
                proficiencies.Add("Quarterstaffs");
                proficiencies.Add("Light Crossbows");
                strST = strMod;
                dexST = dexMod;
                constST = constMod;
                wisST = wisMod + proficiency;
                intST = intMod + proficiency;
                chaST = chaMod;
                equipment.Add("Spellbook");

            }
            else if (type == "Warlock")
            {
                hitDie = "1d8";
                hitPoints = 8 + constMod;
                proficiencies.Add("Light Armor");
                proficiencies.Add("Simple Weapons");
                strST = strMod;
                dexST = dexMod;
                constST = constMod;
                wisST = wisMod + proficiency;
                intST = intMod;
                chaST = chaMod + proficiency;
                equipment.Add("Leather Armor");
                weapons newweapon;
                newweapon = new weapons("Dagger X2", proficiency + strMod, "1d4 Piercing");
                weapon.Add(newweapon);
                traits.Add("Otherworldly Patron");
                traits.Add("Pact Magic");
            }
            else if (type == "Sorcerer")
            {
                hitDie = "1d6";
                hitPoints = 6 + constMod;
                proficiencies.Add("Daggers");
                proficiencies.Add("Darts");
                proficiencies.Add("Slings");
                proficiencies.Add("Quarterstaffs");
                proficiencies.Add("Light Crossbows");
                strST = strMod;
                dexST = dexMod;
                constST = constMod + proficiency;
                wisST = wisMod;
                intST = intMod;
                chaST = chaMod + proficiency;
                weapons newweapon;
                newweapon = new weapons("Dagger X2", proficiency + strMod, "1d4 Piercing");
                weapon.Add(newweapon);
                traits.Add("Spellcasting");
                traits.Add("Sorcerous Origin");


            }
            else if (type == "Fighter")
            {
                hitDie = "1d10";
                hitPoints = 10 + constMod;
                proficiencies.Add("All Armor");
                proficiencies.Add("Sheilds");
                proficiencies.Add("Simple Weapons");
                proficiencies.Add("Martial Weapons");
                strST = strMod + proficiency;
                dexST = dexMod;
                constST = constMod + proficiency;
                wisST = wisMod;
                intST = intMod;
                chaST = chaMod;
                traits.Add("Fighting Style");
                traits.Add("Second Wind");
            }
            else if (type == "Ranger")
            {
                hitDie = "1d10";
                hitPoints = 10 + constMod;
                proficiencies.Add("Light Armor");
                proficiencies.Add("Medium Armor");
                proficiencies.Add("Simple Weapons");
                proficiencies.Add("Martial Weapons");
                strST = strMod + proficiency;
                dexST = dexMod + proficiency;
                constST = constMod;
                wisST = wisMod;
                intST = intMod;
                chaST = chaMod;
                traits.Add("Favored Enemy");
                traits.Add("Natural Explorer");
                weapons newweapon;
                newweapon = new weapons("Longbow", proficiency + dexMod, "1d8 Piercing");
                weapon.Add(newweapon);
                equipment.Add("Arrows X20");
            }

            //BACKGROUND 

            if (background == "Acolyte")
            {
                skills.Add("Insight");
                skills.Add("Religion");
                languages.Add("Two Extra");
                equipment.Add("Holy Symbol");
                equipment.Add("Prayer book / Prayer Wheel");
                equipment.Add("5 sticks of incense");
                equipment.Add("Vestments");
                equipment.Add("Common Clothes");
                equipment.Add("15 Gold");

            }
            else if (background == "Charlatan")
            {
                skills.Add("Deception");
                skills.Add("Sleight of Hand");
                proficiencies.Add("Disguise Kit");
                proficiencies.Add("Forgery Kit");
                equipment.Add("Fine Clothes");
                equipment.Add("Disguise Kit");
                equipment.Add("Tools of the Con");
                equipment.Add("Weighted Die");
                equipment.Add("Marked Cards");
                equipment.Add("Signet Ring of a Fake Duke");
                equipment.Add("15 Gold");
            }
            else if (background == "Criminal")
            {
                skills.Add("Deception");
                skills.Add("Stealth");
                proficiencies.Add("One Gaming Set");
                proficiencies.Add("Thieves' Tools");
                equipment.Add("Crowbar");
                equipment.Add("Dark common Clothes with a Hood");
                equipment.Add("15 Gold");
            }
            else if (background == "Entertainer")
            {
                skills.Add("Acrobatics");
                skills.Add("Performance");
                proficiencies.Add("Disguise Kit");
                proficiencies.Add("One Musical Instrument");
                equipment.Add("One Musical Instrument");
                equipment.Add("The Favor of an Admirer");
                equipment.Add("A Costume");
                equipment.Add("15 Gold");
            }
            else if (background == "Folk Hero")
            {
                skills.Add("Animal Handling");
                skills.Add("Survival");
                proficiencies.Add("One Type of Artisan's Tools");
                proficiencies.Add("Land Vehicles");
                equipment.Add("One Type of Artisan's Tools");
                equipment.Add("A Shovel");
                equipment.Add("An Iron Pot");
                equipment.Add("Common Clothes");
                equipment.Add("10 Gold");
            }
            else if (background == "Guild Merchant")
            {
                skills.Add("Insight");
                skills.Add("Persuasion");
                proficiencies.Add("One Type of Artisan's Tools");
                languages.Add("One Extra");
                equipment.Add("One Type of Artisan's Tools");
                equipment.Add("A Letter of Introduction");
                equipment.Add("Traveler's Clothes");
                equipment.Add("15 Gold");
            }
            else if (background == "Hermit")
            {
                skills.Add("Medicine");
                skills.Add("Religion");
                proficiencies.Add("Herbalism Kit");
                languages.Add("One Extra");
                equipment.Add("A scroll case stuffed with notesfrom your studies or prayer");
                equipment.Add("A Winter Blanket");
                equipment.Add("Common Clothes");
                equipment.Add("Herbalism Kit");
                equipment.Add("5 Gold");
            }
            else if (background == "Noble ")
            {
                skills.Add("History");
                skills.Add("Persuasion");
                proficiencies.Add("One Type of Gaming Set");
                languages.Add("One Extra");
                equipment.Add("A Scroll of Pedigree");
                equipment.Add("Signet Ring");
                equipment.Add("Fine Clothes");
                equipment.Add("One Type of Gaming Set");
                equipment.Add("25 Gold");
            }
            else if (background == "Outlander")
            {
                skills.Add("Athletics");
                skills.Add("Survival");
                proficiencies.Add("One Musical Instrument");
                languages.Add("One Extra");
                equipment.Add("A Staff");
                equipment.Add("A Hunting Trap");
                equipment.Add("Hunting Trophy");
                equipment.Add("Traveler's Clothes");
                equipment.Add("10 Gold");
            }
            else if (background == "Sage")
            {
                skills.Add("Arcana");
                skills.Add("History");
                proficiencies.Add("One Musical Instrument");
                languages.Add("Two Extra");
                equipment.Add("A Bottle of Black ink");
                equipment.Add("A Quill");
                equipment.Add("A Smalll Knife");
                equipment.Add("A Letter From a Dead Friend Posing a Qustion You Have Not Yet Been Able to Answer");
                equipment.Add("Common Clothes");
                equipment.Add("10 Gold");
            }
            else if (background == "Sailor")
            {
                skills.Add("Athletics");
                skills.Add("Perception");
                proficiencies.Add("Navigator's Tools");
                proficiencies.Add("Water Vehicles");
                equipment.Add("A Belaying Pin");
                equipment.Add("50 Feet of Silk Rope");
                equipment.Add("A Lucky Charm");
                equipment.Add("Common Clothes");
                equipment.Add("10 Gold");
            }
            else if (background == "Soldier")
            {
                skills.Add("Athletics");
                skills.Add("Intimidation");
                proficiencies.Add("One Type of Gaming Set");
                proficiencies.Add("Land Vehicles");
                equipment.Add("Insigna of Rank");
                equipment.Add("A War Trophy");
                equipment.Add("Bone Die");
                equipment.Add("Common Clothes");
                equipment.Add("10 Gold");
            }
            else if (background == "Urchin")
            {
                skills.Add("Sleight of Hand");
                skills.Add("Stealth");
                proficiencies.Add("Disguise Kit");
                proficiencies.Add("Thieves' Tools");
                equipment.Add("Small Knife");
                equipment.Add("Home City Map");
                equipment.Add("A Pet Mouse");
                equipment.Add("Common Clothes");
                equipment.Add("A Token to Remember Your Parents By");
                equipment.Add("10 Gold");
            }
            // abiility modifiers 
            #region strMOD

            switch (strength)
            {
                case 4:
                    strMod = -3;
                    break;
                case 5:
                    strMod = -3;
                    break;
                case 6:
                    strMod = -2;
                    break;
                case 7:
                    strMod = -2;
                    break;
                case 8:
                    strMod = -1;
                    break;
                case 9:
                    strMod = -1;
                    break;
                case 10:
                    strMod = 0;
                    break;
                case 11:
                    strMod = 0;
                    break;
                case 12:
                    strMod = 1;
                    break;
                case 13:
                    strMod = 1;
                    break;
                case 14:
                    strMod = 2;
                    break;
                case 15:
                    strMod = 2;
                    break;
                case 16:
                    strMod = 3;
                    break;
                case 17:
                    strMod = 3;
                    break;
                case 18:
                    strMod = 4;
                    break;
                case 19:
                    strMod = 4;
                    break;
                case 20:
                    strMod = 5;
                    break;
                case 21:
                    strMod = 5;
                    break;
                case 22:
                    strMod = 6;
                    break;
                case 23:
                    strMod = 6;
                    break;
                case 24:
                    strMod = 7;
                    break;
            }
            #endregion

            #region dexMOD
            switch (dexterity)
            {
                case 4:
                    dexMod = -3;
                    break;
                case 5:
                    dexMod = -3;
                    break;
                case 6:
                    dexMod = -2;
                    break;
                case 7:
                    dexMod = -2;
                    break;
                case 8:
                    dexMod = -1;
                    break;
                case 9:
                    dexMod = -1;
                    break;
                case 10:
                    dexMod = 0;
                    break;
                case 11:
                    dexMod = 0;
                    break;
                case 12:
                    dexMod = 1;
                    break;
                case 13:
                    dexMod = 1;
                    break;
                case 14:
                    dexMod = 2;
                    break;
                case 15:
                    dexMod = 2;
                    break;
                case 16:
                    dexMod = 3;
                    break;
                case 17:
                    dexMod = 3;
                    break;
                case 18:
                    dexMod = 4;
                    break;
                case 19:
                    dexMod = 4;
                    break;
                case 20:
                    dexMod = 5;
                    break;
                case 21:
                    dexMod = 5;
                    break;
                case 22:
                    dexMod = 6;
                    break;
                case 23:
                    dexMod = 6;
                    break;
                case 24:
                    dexMod = 7;
                    break;
            }
            #endregion

            #region conMOD

            switch (constitution)
            {
                case 4:
                    constMod = -3;
                    break;
                case 5:
                    constMod = -3;
                    break;
                case 6:
                    constMod = -2;
                    break;
                case 7:
                    constMod = -2;
                    break;
                case 8:
                    constMod = -1;
                    break;
                case 9:
                    constMod = -1;
                    break;
                case 10:
                    constMod = 0;
                    break;
                case 11:
                    constMod = 0;
                    break;
                case 12:
                    constMod = 1;
                    break;
                case 13:
                    constMod = 1;
                    break;
                case 14:
                    constMod = 2;
                    break;
                case 15:
                    constMod = 2;
                    break;
                case 16:
                    constMod = 3;
                    break;
                case 17:
                    constMod = 3;
                    break;
                case 18:
                    constMod = 4;
                    break;
                case 19:
                    constMod = 4;
                    break;
                case 20:
                    constMod = 5;
                    break;
                case 21:
                    constMod = 5;
                    break;
                case 22:
                    constMod = 6;
                    break;
                case 23:
                    constMod = 6;
                    break;
                case 24:
                    constMod = 7;
                    break;
            }
            #endregion

            #region intMOD

            switch (inteligence)
            {
                case 4:
                    intMod = -3;
                    break;
                case 5:
                    intMod = -3;
                    break;
                case 6:
                    intMod = -2;
                    break;
                case 7:
                    intMod = -2;
                    break;
                case 8:
                    intMod = -1;
                    break;
                case 9:
                    intMod = -1;
                    break;
                case 10:
                    intMod = 0;
                    break;
                case 11:
                    intMod = 0;
                    break;
                case 12:
                    intMod = 1;
                    break;
                case 13:
                    intMod = 1;
                    break;
                case 14:
                    intMod = 2;
                    break;
                case 15:
                    intMod = 2;
                    break;
                case 16:
                    intMod = 3;
                    break;
                case 17:
                    intMod = 3;
                    break;
                case 18:
                    intMod = 4;
                    break;
                case 19:
                    intMod = 4;
                    break;
                case 20:
                    intMod = 5;
                    break;
                case 21:
                    intMod = 5;
                    break;
                case 22:
                    intMod = 6;
                    break;
                case 23:
                    intMod = 6;
                    break;
                case 24:
                    intMod = 7;
                    break;
            }
            #endregion

            #region wisMOD

            switch (wisdom)
            {
                case 4:
                    wisMod = -3;
                    break;
                case 5:
                    wisMod = -3;
                    break;
                case 6:
                    wisMod = -2;
                    break;
                case 7:
                    wisMod = -2;
                    break;
                case 8:
                    wisMod = -1;
                    break;
                case 9:
                    wisMod = -1;
                    break;
                case 10:
                    wisMod = 0;
                    break;
                case 11:
                    wisMod = 0;
                    break;
                case 12:
                    wisMod = 1;
                    break;
                case 13:
                    wisMod = 1;
                    break;
                case 14:
                    wisMod = 2;
                    break;
                case 15:
                    wisMod = 2;
                    break;
                case 16:
                    wisMod = 3;
                    break;
                case 17:
                    wisMod = 3;
                    break;
                case 18:
                    wisMod = 4;
                    break;
                case 19:
                    wisMod = 4;
                    break;
                case 20:
                    wisMod = 5;
                    break;
                case 21:
                    wisMod = 5;
                    break;
                case 22:
                    wisMod = 6;
                    break;
                case 23:
                    wisMod = 6;
                    break;
                case 24:
                    wisMod = 7;
                    break;
            }
            #endregion

            #region chaMOD

            switch (charisma)
            {
                case 4:
                    chaMod = -3;
                    break;
                case 5:
                    chaMod = -3;
                    break;
                case 6:
                    chaMod = -2;
                    break;
                case 7:
                    chaMod = -2;
                    break;
                case 8:
                    chaMod = -1;
                    break;
                case 9:
                    chaMod = -1;
                    break;
                case 10:
                    chaMod = 0;
                    break;
                case 11:
                    chaMod = 0;
                    break;
                case 12:
                    chaMod = 1;
                    break;
                case 13:
                    chaMod = 1;
                    break;
                case 14:
                    chaMod = 2;
                    break;
                case 15:
                    chaMod = 2;
                    break;
                case 16:
                    chaMod = 3;
                    break;
                case 17:
                    chaMod = 3;
                    break;
                case 18:
                    chaMod = 4;
                    break;
                case 19:
                    chaMod = 4;
                    break;
                case 20:
                    chaMod = 5;
                    break;
                case 21:
                    chaMod = 5;
                    break;
                case 22:
                    chaMod = 6;
                    break;
                case 23:
                    chaMod = 6;
                    break;
                case 24:
                    chaMod = 7;
                    break;
            }

            #endregion

            // Weapons 
            


        }



    }
}

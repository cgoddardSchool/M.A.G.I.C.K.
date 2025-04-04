using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.PeerToPeer;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Forms;
using iText.Forms.Fields;
using iText.Forms.Fields.Properties;
using System.IO;
using iText.Kernel.Utils;
using System.Windows.Forms;
using System.Web.UI;
using System.Data.SQLite.Linq;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.SQLite;
using static iText.Signatures.LtvVerification;

//THIS FILE HAS CONSOLE.WRITELINES THAT NEED TO BE REMOVED BEFORE HANDING IN


namespace M_A_G_I_C_K
{
    public class Character
    {
        //this will have all the info for the character
        //it will have a class, race, background, stats etc etc


        //stats, created via method
        protected int _STR, _DEX, _CON, _SMRT, _WIS, _CHA, _ProfisBonus;
        protected int[] _StatBonus = new int[6];
        //name and background, name gotten from pdf, background gotten from 
        private string _name, _background;
        //created via inherented class
        private DndClass _CharClass;
        private spellCaster _SpellCaster;
        protected Boolean _spellCaster;
        //created via inherented class
        private DndRace _CharRace;
        //equipment
        private string _armor, _weapon;
        private List<string> _Equipment = new List<string>();
        //feats
        private string[] _feats;
        private int _AC;
        private int ProfisBonus => _ProfisBonus;
        protected static string connectionString = @"Data Source=" + Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName) + @"\Databases\Primary Database.db";



        //constructors will one for full and one for completely empty
        //the one for all constructor will also have options to fill in blank ones, and if == null then blank

        public Character(int SelectedRace, int SelectedClass, string Name, int Level, int[] stats, string Background, List<string> inventory, string[] feats) 
        {
            
            /*RaceDropDown
             * Human
                Elf
                Dwarf
                Orc
                DragonBorn

                Class DropDown
                Fighter
                Cleric
                Wizard
                Rogue
                Bard
            */

            switch (SelectedRace)
            {
                case 1:
                    Console.WriteLine("Selected Human");

                    _CharRace = new Human();
 
                    break;
                case 2:
                    Console.WriteLine("Selected Elf");
                    _CharRace = new Elf();

                    break;
                case 3:
                    Console.WriteLine("Selected Dwarf");
                    _CharRace = new Dwarf();


                    break;
                case 4:
                    Console.WriteLine("Selected Orc");
                    _CharRace = new Orc();

                    break;
                case 5:
                    Console.WriteLine("Selected Dragonborn");
                    _CharRace = new Dragonborn();

                    break;

                default:
                    Console.WriteLine("Selected Nothing");
                    //begin randomly generated stuff



                    break;
            }

            switch (SelectedClass)
            {
                case 1:
                    Console.WriteLine("Selected Fighter");
                    _CharClass = new Fighter(Level);

                    break;
                case 4:
                    Console.WriteLine("Selected Rouge");
                    _CharClass = new Rouge(Level);

                    break;
                default:
                    Console.WriteLine("Selected Nothing");
                    //start random generation here


                    break;
            }

            //setting the spellcaster
            _spellCaster = false;

            //Both the Class and race has been selected this will then go into calculating the other shit

            //if the name is not just a space (if blank)
            if (Name != " ")
            {
                Console.WriteLine("Putting Name Info");

                _name = Name;
            }else
            {
                Console.WriteLine("Generating Name");
                //run the ran generator

                _name = "TestingPDF";
            }

            //adding all inventory stuff
            try
            {

                _weapon = inventory[0];
            }
            catch
            {
                Console.WriteLine("No weapon selected, travelling unarmed!");
            }
            try
            {

                _weapon = inventory[0];
            }
            catch
            {
                Console.WriteLine("No armor selected, travelling unarmored!");
            }

            foreach (string item in inventory)
            {
                _Equipment.Add(item);
            }

            //feats
            _feats = feats;


            /*
             * 
             * Stats[0] = STR;
                Stats[1] = DEX
                Stats[2] = SMRT
                Stats[3] = CON;
                Stats[4] = CHA;
                Stats[5] = WIS;
             * 
             */

            _STR = stats[0];
            _DEX = stats[1];
            _SMRT = stats[2];
            _CON = stats[3];
            _CHA = stats[4];
            _WIS = stats[5];

            _background = Background;

            //CALCULATING STATS GOES HERE
            calculatingStats();


            //testing lines
            Console.WriteLine("-----------------");
            Console.WriteLine("");
            Console.WriteLine("AC: " + _AC);
            Console.WriteLine("HP: " + _CharClass.Hitpoints);
            Console.WriteLine("CON " + _StatBonus[2]);
            Console.WriteLine("Dex " + _StatBonus[1]);
            if (_SpellCaster != null)
            {

                Console.WriteLine("Spellcasting Modifier (Save): " + _SpellCaster.spellSaveDC);
                Console.WriteLine("Spellcasting Modifier (Attack Bonus): " + _SpellCaster.SpellAtkBonus);
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------");



        }

        public Character(int SelectedRace, int SelectedClass, string Name, int Level, int[] stats, string Background, string[] Cantrips, string[] Spells, List<string> inventory, string[] feats)
        {

            /*RaceDropDown
             * Human
                Elf
                Dwarf
                Orc
                DragonBorn

                Class DropDown
                Fighter
                Cleric
                Wizard
                Rogue
                Bard
            */

            switch (SelectedRace)
            {
                case 1:
                    Console.WriteLine("Selected Human");

                    _CharRace = new Human();

                    break;
                case 2:
                    Console.WriteLine("Selected Elf");
                    _CharRace = new Elf();

                    break;
                case 3:
                    Console.WriteLine("Selected Dwarf");
                    _CharRace = new Dwarf();


                    break;
                case 4:
                    Console.WriteLine("Selected Orc");
                    _CharRace = new Orc();

                    break;
                case 5:
                    Console.WriteLine("Selected Dragonborn");
                    _CharRace = new Dragonborn();

                    break;

                default:
                    Console.WriteLine("Selected Nothing");
                    //begin randomly generated stuff



                    break;
            }

            switch (SelectedClass)
            {
                case 2:
                    Console.WriteLine("selected cleric");
                    _SpellCaster = new Cleric(Level, Cantrips, Spells);
                    _CharClass = new Cleric(Level, Cantrips, Spells);

                    break;
                case 3:
                    Console.WriteLine("Selected Wizard");
                    _SpellCaster = new Wizard(Level, Cantrips, Spells);
                    _CharClass = new Wizard(Level, Cantrips, Spells);

                    break;
                case 5:
                    Console.WriteLine("Selected Bard");
                    _SpellCaster = new Bard(Level, Cantrips, Spells);
                    _CharClass = new Bard(Level, Cantrips, Spells);

                    break;
                default:
                    Console.WriteLine("Selected Nothing");
                    //start random generation here
                    break;
            }

            //setting the spellcaster
            _spellCaster = true;

            //Both the Class and race has been selected this will then go into calculating the other shit

            //if the name is not just a space (if blank)
            if (Name != " ")
            {
                Console.WriteLine("Putting Name Info");

                _name = Name;
            }
            else
            {
                Console.WriteLine("Generating Name");
                //run the ran generator

                _name = "TestingPDF";
            }

            //adding all inventory stuff

            try
            {

                _weapon = inventory[0];
            }
            catch
            {
                Console.WriteLine("No weapon selected, travelling unarmed!");
            }
            try
            {

                _weapon = inventory[0];
            }
            catch
            {
                Console.WriteLine("No armor selected, travelling unarmored!");
            }

            foreach (string item in inventory)
            {
                _Equipment.Add(item);
            }

            //feats
            _feats = feats;

            /*
             * 
             * Stats[0] = STR;
                Stats[1] = DEX
                Stats[2] = SMRT
                Stats[3] = CON;
                Stats[4] = CHA;
                Stats[5] = WIS;
             * 
             */

            _STR = stats[0];
            _DEX = stats[1];
            _SMRT = stats[2];
            _CON = stats[3];
            _CHA = stats[4];
            _WIS = stats[5];

            _background = Background;

            //CALCULATING STATS GO HERE
            calculatingStats();
         }

        //get methods, we will need to add get methods to everything
        public DndClass CharClass
        {
            get { return _CharClass; }
        }

        //stat calculator
        public void calculatingStats()
        {
            //Stat bonuses
            _StatBonus[0] = (_STR- 10) / 2;
            _StatBonus[1] = (_DEX - 10) / 2;
            _StatBonus[2] = (_CON - 10) / 2;
            _StatBonus[3] = (_SMRT - 10) / 2;
            _StatBonus[4] = (_WIS - 10) / 2;
            _StatBonus[5] = (_CHA - 10) / 2;

            //ARMOR CLASS
            //---------------------------------------------------------------------
            //math.round didn't work, found an alternative
            //math.ceiling documention https://learn.microsoft.com/en-us/dotnet/api/system.math.ceiling?view=net-9.0
            // 
            //proficiency bonus  =  charlevel /4 rounded up +1

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = $"SELECT ArmorClass, ArmorType FROM Armors WHERE Name = '{_armor}'";

                using (SQLiteCommand command = new SQLiteCommand(query, conn))
                {

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            _AC = Convert.ToInt32(reader.GetString(reader.GetOrdinal("ArmorClass")));
                            string armorType = reader.GetString(reader.GetOrdinal("ArmorType"));

                            //check for if the armor is light or medium, if so add dex bonus
                            if (armorType == "Light" || armorType == "Medium")
                            {
                                _AC += _StatBonus[1];
                            } 
                        }
                        else
                        {
                            _AC = 10 + _StatBonus[1];
                        }    
                    }
                }
            }

            //HITPOINTS

            //get hitdie from class
            try
            {
                int hitdie = int.Parse(_CharClass.HitpointDice.Replace("D", ""));
                //use hitdie to calculate hp + con bonus * level
                _CharClass.Hitpoints = (hitdie + _StatBonus[2]) * _CharClass.Level;
            }
            catch
            {
                MessageBox.Show("Remember to select a class!");
            }

            if (_spellCaster == true)
            {
                switch (_SpellCaster.spellAbility.ToLower()){
                    case "wisdom":
                        _SpellCaster.calculateSpellStats(_StatBonus[4]);
                        break;
                    case "intelligence":
                        _SpellCaster.calculateSpellStats(_StatBonus[3]);
                        break;
                    case "charisma":
                        _SpellCaster.calculateSpellStats(_StatBonus[5]);
                        break;
                }
            }
            //Testing code to check the make sure values are updated properly.

            //Console.WriteLine("-----------------");
            //Console.WriteLine("");
            //Console.WriteLine("AC: " + _AC);
            //Console.WriteLine("HP: " + _CharClass.Hitpoints);
             
            //if (_SpellCaster != null)
            //{
            //    Console.WriteLine("Spellcasting Modifier (Save): " + _SpellCaster.spellSaveDC);
            //Console.WriteLine("Spellcasting Modifier (Attack Bonus): " + _SpellCaster.SpellAtkBonus);
            //}
            //Console.WriteLine("");
            //Console.WriteLine("-----------------");



        }
        public void creatingPdf()
        {
            Console.WriteLine("getting into pdf editing");


            /*flow of pdf creation
             * 
             * creates new pdf https://kb.itextpdf.com/itext/chapter-1-introducing-basic-building-blocks
             * copy the base pdf form to the new pdf, only first page if not spell caster (still need to figure out a bit but here https://kb.itextpdf.com/itext/chapter-6-/reusing-existing-pdf-documents-net)
             * start adding information to form (https://kb.itextpdf.com/itext/chapter-5-manipulating-an-existing-pdf-document-ne)
             * 
             * close form
             * 
             */

            //this if for finding the current path
            string pathToPDFFolder = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName) + @"\PDFS\";

            string CreationPath = pathToPDFFolder + _name + "CharacterSheet.pdf";

            string basePath = pathToPDFFolder + "DnD_BaseSheet.pdf";

            //sql
            string connectionString = @"Data Source=" + Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName) + @"\Databases\Primary Database.db";

            //creating a file at this location
            using (FileStream fs = File.Create(CreationPath));
            
            //setting up the pdf to merge to
            PdfDocument CharPdf = new PdfDocument(new PdfWriter(CreationPath));
            PdfMerger merger = new PdfMerger(CharPdf);

            //adding pages from the base document, first creating the pdf link then merging
            PdfDocument basePdf = new PdfDocument(new PdfReader(basePath));
            merger.Merge(basePdf, 1, basePdf.GetNumberOfPages());
            
            //closing the pdfs, will not be used anymore
            basePdf.Close();
            merger.Close();
            CharPdf.Close();

            //setting up for the documentation filling, will take the fields name from the base but then fill in the character pdf
            PdfDocument fillingPdf = new PdfDocument(new PdfReader(basePath), new PdfWriter(CreationPath));
            PdfAcroForm form = PdfFormCreator.GetAcroForm(fillingPdf, true);
            IDictionary<String, PdfFormField> fields = form.GetAllFormFields();

            if (_spellCaster == true)
            {
                //this will link to the fillingspells pdf
                _SpellCaster.fillingSpellsPdf(fields);

            }
            else
            {
                fillingPdf.RemovePage(2);

            }

            //all the fields to fill in are here
            //using this fields[""].SetValue("");
            //sections on the top
            fields["CharacterName"].SetValue(_name);
            fields["ClassLevel"].SetValue(_CharClass.CharClassName + " " + _CharClass.Level);
            fields["Race"].SetValue(_CharRace.CharRace);
            fields["Background"].SetValue(_background); //might need to change later depeneding on how we do that backgrounds

            //side table for values
            fields["STR"].SetValue(_STR.ToString());
            fields["DEX"].SetValue(_DEX.ToString());
            fields["CON"].SetValue(_CON.ToString());
            fields["INT"].SetValue(_SMRT.ToString());
            fields["WIS"].SetValue(_WIS.ToString());
            fields["CHA"].SetValue(_CHA.ToString());

            fields["STRmod"].SetValue(_StatBonus[0].ToString());
            fields["DEXmod"].SetValue(_StatBonus[1].ToString());
            fields["CONmod"].SetValue(_StatBonus[2].ToString());
            fields["INTmod"].SetValue(_StatBonus[3].ToString());
            fields["WISmod"].SetValue(_StatBonus[4].ToString());
            fields["CHAmod"].SetValue(_StatBonus[5].ToString());

            fields["Passive"].SetValue(_WIS.ToString());

            //center thingy
            fields["AC"].SetValue("");
            fields["Speed"].SetValue(_CharRace.Speed);
            fields["HPMax"].SetValue("");
            fields["Initiative"].SetValue(_StatBonus[1].ToString());
            fields["HDTotal"].SetValue("");
            fields["HD"].SetValue("");

            //might need to concat a bunch of shit before inputting it
            string allFeats = "";
            foreach(string thing in _feats)
            {
                allFeats += thing + ", ";
            }
            fields["Features and Traits"].SetValue(allFeats);
           
            string fullInventory = "";
            foreach (string item in _Equipment)
            {
                fullInventory += item + ", ";
            }
            fields["Equipment"].SetValue(fullInventory);
            fields["GP"].SetValue("150");


            //weapon, sql query for that
            string damage = null;
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                //finally a query
                string query = @"
                         SELECT Damage
                         FROM Weapons
                         Where Name = '" + _weapon + "'";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            damage = reader.GetString(reader.GetOrdinal("Damage"));
                        }
                    }
                }

                connection.Close();
            }

            fields["Wpn Name"].SetValue(_weapon);
            fields["Wpn1 AtkBonus"].SetValue("");
            fields["Wpn1 Damage"].SetValue(damage);


            fillingPdf.Close();

            //finally asking via pop up if you would like to move the file to your desktop
            //creating the message box
            string message = "Would you like to move the new pdf to your desktop?";
            string title = "Move Pdf?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            //managing results
            if (result == DialogResult.Yes)
            {

                string movementPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + _name + "CharacterSheet.pdf";

                //moving the stuff to desktop
                //File.Move(CreationPath, movementPath);
                MessageBox.Show("File Moved");
            }
            else 
            {
                MessageBox.Show("File kept in application Storage");
            }
        }
        
    }

    public abstract class DndClass
    {
        //this will be inhearented by all the classes
        protected int _Level, _hitpoints, _ProfisBonus;
        protected string _CharClassName, _hitpointDice;
        protected static string connectionString = @"Data Source=" + Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName) + @"\Databases\Primary Database.db";

        public string CharClassName
        {
            get { return _CharClassName; }
        }
        public int Level
        {
            get { return _Level; }
        }
        //in case you really really wanted _hitpoints to be protected...this way im not destroying your encapsulation
        //would make my life easier to have done so though lol
        public string HitpointDice => _hitpointDice;

        //constructor for hitpoints as I couldnt find one
        public int Hitpoints
        {
            get => _hitpoints;
            set => _hitpoints = value;
        }
        public static List<string> gettingWeapons(string WeaponType)
        {
            List<string> currentWeapon = new List<string>();
            string weaponQuery = "";

            using (var conn = new SQLiteConnection(connectionString))
            {
                if (WeaponType == "simple")
                {
                    weaponQuery = "SELECT Name FROM Weapons WHERE Type = 'Simple'";

                }
                else if(WeaponType == "martial")
                {
                    weaponQuery = "SELECT Name FROM Weapons WHERE Type = 'Simple' OR Type = 'Martial'";

                }

                conn.Open();
 
                using (SQLiteCommand command = new SQLiteCommand(weaponQuery, conn))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(reader.GetOrdinal("Name"));

                            currentWeapon.Add(name);
                        }
                    }
                }
                return currentWeapon;
            }
        }

        public static List<string> gettingFeats()
        {
            List<string> currentFeats = new List<string>();

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string featquery = "SELECT Name FROM GeneralFeats";

                using (SQLiteCommand command = new SQLiteCommand(featquery, conn))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(reader.GetOrdinal("Name"));

                            currentFeats.Add(name);
                        }
                    }
                }
                return currentFeats;
            }

        }

        public static List<string> gettingArmours(string ArmorType)
        {
            List<string> currentArmour = new List<string>();
            string armourQuery = "";


            using (var conn = new SQLiteConnection(connectionString))
            {
                if (ArmorType == "light")
                {
                    armourQuery = "SELECT Name FROM Armors WHERE ArmorType = 'Light' ";
                }
                else if (ArmorType == "medium")
                {
                    armourQuery = "SELECT Name FROM Armors WHERE ArmorType = 'Light' OR ArmorType = 'Medium' OR ArmorType= 'All'";
                }
                else if (ArmorType == "heavy")
                {
                    armourQuery = "SELECT Name FROM Armors WHERE ArmorType = 'Light' OR ArmorType = 'Medium' OR ArmorType= 'Heavy' OR ArmorType= 'All'";
                }
                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand(armourQuery, conn))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(reader.GetOrdinal("Name"));

                            currentArmour.Add(name);
                        }
                    }
                }
                return currentArmour;
            }
        }

        public static List<string> gettingEquipment()
        {
            List<string> currentEquipment = new List<string>();

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string featquery = "SELECT Name FROM GenEquipment";

                using (SQLiteCommand command = new SQLiteCommand(featquery, conn))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(reader.GetOrdinal("Name"));

                            currentEquipment.Add(name);
                        }
                    }
                }
                return currentEquipment;
            }
        }

    }
    public abstract class spellCaster : DndClass
    {
        protected string _spellAbility, _spellSaveDC, _spellAtkBonus;
        protected string[] _SelectedSpells, _SelectedCantrip;

        //this is the variable to be modified for the spells/cantrips
        public static int SpellAmountAllowed;

        public spellCaster() : base()
        {

        }

        public string spellAbility
        {
            get { return _spellAbility; }
        }

        public string spellSaveDC
        {
            get { return _spellSaveDC; }
        }

        public string SpellAtkBonus
        {
            get { return _spellAtkBonus; }
        }

        public void fillingSpellsPdf(IDictionary<String, PdfFormField> fields)
        {
            //setting these to defaults just to avoid errors from empty, will need to be updated later
            _spellSaveDC = "Null";
            _spellAtkBonus = "Null";

            //top section
            fields["Spellcasting Class 2"].SetValue(_CharClassName);
            fields["SpellcastingAbility 2"].SetValue(_spellAbility);
            fields["SpellSaveDC 2"].SetValue(_spellSaveDC);
            fields["SpellAtkBonus 2"].SetValue(_spellAtkBonus);


            //loop for cantrips
            int currentSpell = 1;
            foreach(string cantrip in _SelectedCantrip)
            {
                fields["C" + currentSpell].SetValue(cantrip);
                currentSpell++;
            }

            //nums to keep track of the spell level
            int numOfOne = 1;
            int numOfTwo = 1;
            int numOfThree = 1; 

            //loop for spells
            foreach (string spell in _SelectedSpells)
            {
                int level = 1;

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    //finally a query
                    string query = @"
                         SELECT Level
                         FROM " + _CharClassName + "SpellBook \n" +
                         "WHERE Name = '" + spell + "'";
                         

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                level = (int)reader.GetInt32(reader.GetOrdinal("Level"));
                            }
                        }
                    }
                    connection.Close();
                }

                switch (level)
                {
                    case 1:
                        fields["F" + numOfOne].SetValue(spell);
                        numOfOne++;
                        break;
                    case 2:
                        fields["S" + numOfThree].SetValue(spell);
                        numOfTwo++;
                        break;
                    case 3:
                        fields["T" + numOfThree].SetValue(spell);
                        numOfThree++;
                        break;
                }

            }

        }

        //this things are located within the spellcaster class, should be moved into there, and called in the constructor via _spellCaster.CalculatingSpellCastingStats
        public void calculateSpellStats(int casterStatMod)
        {
            _spellSaveDC = (8 + _ProfisBonus + casterStatMod).ToString() ;
            _spellAtkBonus = (_ProfisBonus + casterStatMod).ToString();

        }
    }

    class Fighter : DndClass
    {
        public Fighter(int Level) : base()
        { 
            _Level = Level;
            _CharClassName = "Fighter";
            _hitpointDice = "D10";
            _ProfisBonus = 2;
        }
    }

    class Cleric : spellCaster 
    {
        public Cleric(int Level, string[] Cantrips, string[] Spells) : base()
        {
            _Level = Level;
            _CharClassName = "Cleric";
            _hitpointDice = "D8";
            _SelectedCantrip = Cantrips;
            _SelectedSpells = Spells;
            _spellAbility = "Wisdom";
            _ProfisBonus = 2;
        }
        public static List<string> gettingSpells(int level)
        {
            List<string> currentSpells = new List<string>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                //finally a query
                string query = @"
                         SELECT Name
                         FROM ClericSpellbook
                         WHERE Level=" + level;

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(reader.GetOrdinal("Name"));

                            currentSpells.Add(name);
                        }
                    }
                }
                connection.Close();
            }

            return currentSpells;
        }

    }

    class Wizard : spellCaster 
    {

        public Wizard(int Level, string[] Cantrips, string[] Spells) : base()
        {
            _Level = Level;
            _CharClassName = "Wizard";
            _hitpointDice = "D6";
            _SelectedCantrip = Cantrips;
            _SelectedSpells = Spells;
            _spellAbility = "intelligence";
            _ProfisBonus = 2;
         

        }
        public static List<string> gettingSpells(int level)
        {
            List<string> currentSpells = new List<string>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                //finally a query
                string query = @"
                         SELECT Name
                         FROM WizardSpellbook
                        WHERE Level=" + level;

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(reader.GetOrdinal("Name"));

                            currentSpells.Add(name);
                        }
                    }
                }

                connection.Close();
            }

            return currentSpells;
        }
    }

    class Rouge : DndClass 
    {

        public Rouge(int Level) : base()
        {
            _Level = Level;
            _CharClassName = "Rouge";
            _hitpointDice = "D8";
            _ProfisBonus = 2;
        }
    }

    class Bard : spellCaster 
    {
        public Bard(int Level, string[] Cantrips, string[] Spells) : base()
        {
            _Level = Level;
            _CharClassName = "Bard";
            _hitpointDice = "D8";
            _SelectedCantrip = Cantrips;
            _SelectedSpells = Spells;
            _spellAbility = "Charisma";
            _ProfisBonus = 2;
        }

        public static List<string> gettingSpells(int level)
        {
            List<string> currentSpells = new List<string>();

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                //finally a query
                string query = @"
                         SELECT Name
                         FROM BardSpellbook
                         WHERE Level=" + level;

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader.GetString(reader.GetOrdinal("Name"));

                            currentSpells.Add(name);
                        }
                    }
                }

                connection.Close();
            }
            return currentSpells;
        }
    }

    //for races
    public abstract class DndRace
    {
        //this will be inherented by all the races
        protected int _speed;
        protected string _size, _CharRace;

        public DndRace()
        {
            _speed = 30;
            _size = "medium";
        }

        public string Speed
        {
            get
            {
                return _speed.ToString(); ;
            }

            set
            {
                //this will be edited to change spending on the armor/any other affects
            }
        }

        public string CharRace
        {
            get
            {
                return _CharRace.ToString(); 
            }
        }
        
    }

    class Human : DndRace
    {
        public Human(): base()
        {
            _CharRace = "Human";
        }
    }

    class Elf : DndRace
    {
        public Elf() : base()
        {
            _CharRace = "Elf";        
        }
    }

    class Dwarf : DndRace
    {


       public Dwarf(): base()
       {
            _speed = 25;
            _CharRace = "Dwarf";
       }
    }

    class Orc : DndRace
    {
        

        public Orc(): base()
        {
            _CharRace = "Orc";
        }

    }

    class Dragonborn : DndRace
    {


        public Dragonborn(): base()
        {
            _CharRace = "Dragonborn";

        }

    }


}

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
        //created via inherented class
        private DndRace _CharRace;
        
        //constructors will one for full and one for completely empty
        //the one for all constructor will also have options to fill in blank ones, and if == null then blank

        public Character(int SelectedRace, int SelectedClass, string Name, int Level, int[] stats, string Background) 
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
        }

        public Character(int SelectedRace, int SelectedClass, string Name, int Level, int[] stats, string Background, string[] Cantrips, string[] Spells)
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
                    _CharClass = new Cleric(Level, Cantrips, Spells);

                    break;
                case 3:
                    Console.WriteLine("Selected Wizard");
                    _CharClass = new Wizard(Level, Cantrips, Spells);

                    break;
                case 5:
                    Console.WriteLine("Selected Bard");
                    _CharClass = new Bard(Level, Cantrips, Spells);

                    break;
                default:
                    Console.WriteLine("Selected Nothing");
                    //start random generation here


                    break;
            }

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
        }

        //get methods, we will need to add get methods to everything
        public DndClass CharClass
        {
            get { return _CharClass; }
        }
        


        
        
        private void calculatingStats()
        {
            //ac, hitpoints, etc

            
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

            if (_CharClass.spellCaster == true)
            {
                //this will link to the fillingspells pdf
                fillingSpellsPdf(fields);
            }
            else
            {
                fillingPdf.RemovePage(1);
            }

            //all the fields to fill in are here
            //using this fields[""].SetValue("");
            //sections on the top
            fields["CharacterName"].SetValue(_name);
            fields["ClassLevel"].SetValue(_CharClass.CharClass + " " + _CharClass.Level);
            fields["Race"].SetValue(_CharRace.CharRace);
            fields["Background"].SetValue(_background); //might need to change later dpeneding on how we do that backgrounds

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

            fields["Passive"].SetValue("");

            //center thingy
            fields["AC"].SetValue("");
            fields["Speed"].SetValue(_CharRace.Speed);
            fields["HPMax"].SetValue("");
            fields["Initiative"].SetValue("");
            fields["HDTotal"].SetValue("");
            fields["HD"].SetValue("");

            //might need to concat a bunch of shit before inputting it
            fields["Features And Traits"].SetValue("");
            fields["Equipment"].SetValue("");
            fields["GD"].SetValue("");

            //weapons
            fields["Wpn Name"].SetValue("");
            fields["Wpn1 AtkBonus"].SetValue("");
            fields["Wpn1 Damage"].SetValue("");


            fillingPdf.Close();

            //finally asking via pop up if you would like to move the file to your desktop
            //creating the message box
            string message = "Would you like to move the new pdf to your desktop";
            string title = "Move Pdf?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            //managing results
            if (result == DialogResult.Yes)
            {
                //moving the stuff to desktop

            }
            else 
            { 

            }
        }

        private void fillingSpellsPdf(IDictionary<String, PdfFormField> fields)
        {
            //top section
            fields["Spellcasting Class 2"].SetValue(_CharClass.CharClass);
            fields["SpellcastingAbility 2"].SetValue("");
            fields["SpellSaveDC  2"].SetValue("");
            fields["SpellAtkBonus 2"].SetValue("");


            //loop for cantrips
        }
        
    }


    public abstract class DndClass
    {
        //this will be inhearented by all the classes
        protected int _Level, _hitpoints;
        protected string _CharClass, _hitpointDice;
        protected Boolean _spellCaster;
        protected static string connectionString = @"Data Source=" + Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName) + @"\Databases\Primary Database.db";

        public string CharClass
        {
            get { return _CharClass; }
        }

        public int Level
        {
            get { return _Level; }
        }

        public Boolean spellCaster 
        {
            get { return _spellCaster; }
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
            _spellCaster = true;
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

    }


    class Fighter : DndClass
    {
        public Fighter(int Level) : base()
        { 
            _Level = Level;
            _CharClass = "Fighter";
            _spellCaster = false;
            _hitpointDice = "D10";
        }
    }

    class Cleric : spellCaster 
    {
        public Cleric(int Level, string[] Cantrips, string[] Spells) : base()
        {
            _Level = Level;
            _CharClass = "Cleric";
            _hitpointDice = "D8";
            _SelectedCantrip = Cantrips;
            _SelectedSpells = Spells;

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
            _CharClass = "Wizard";
            _hitpointDice = "D6";
            _SelectedCantrip = Cantrips;
            _SelectedSpells = Spells;

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
            _CharClass = "Rouge";
            _spellCaster = false;
            _hitpointDice = "D8";

        }
    }

    class Bard : spellCaster 
    {
        public Bard(int Level, string[] Cantrips, string[] Spells) : base()
        {
            _Level = Level;
            _CharClass = "Bard";
            _hitpointDice = "D8";
            _SelectedCantrip = Cantrips;
            _SelectedSpells = Spells;
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
            _CharRace = "Elf";        }
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

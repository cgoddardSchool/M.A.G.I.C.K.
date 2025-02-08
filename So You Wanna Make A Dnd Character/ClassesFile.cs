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



//THIS FILE HAS CONSOLE.WRITELINES THAT NEED TO BE REMOVED BEFORE HANDING IN


namespace M_A_G_I_C_K
{
    class Character
    {
        //this will have all the info for the character
        //it will have a class, race, background, stats etc etc


        //stats, created via method
        protected int _STR, _DEX, _CON, _SMRT, _WIS, _CHA, _ProfisBonus;
        //name and background, name gotten from pdf, background gotten from 
        private string _name, _background;
        //created via inherented class
        private DndClass _CharClass;
        //created via inherented class
        private DndRace _CharRace;
        

        //constructors will one for full and one for completely empty
        //the one for all constructor will also have options to fill in blank ones, and if == null then blank

        public Character(int SelectedRace, int SelectedClass, string Name, int Level, int[] stats) 
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
                case 2:
                    Console.WriteLine("selected cleric");
                    _CharClass = new Cleric(Level);

                    break;
                case 3:
                    Console.WriteLine("Selected Wizard");
                    _CharClass = new Wizard(Level);

                    break;
                case 4:
                    Console.WriteLine("Selected Rouge");
                    _CharClass = new Rouge(Level);

                    break;
                case 5:
                    Console.WriteLine("Selected Bard");
                    _CharClass = new Bard(Level);

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
        }


        private void calculatingStats()
        {


            
        }

        //NEEDS TO FIX THE PATH TO WORK NO MATTER THE MACHINE IT IS ON
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

            //all the fields to fill in are here
            fields["CharacterName"].SetValue("This is a test please work");

            fillingPdf.Close();

            //finally asking via pop up if you would like to move the file to your desktop

        }

        
    }


    abstract class DndClass
    {
        //this will be inhearented by all the classes
        protected int _Level;
        protected string _CharClass;

        public string CharClass
        {
            get { return _CharClass; }
        }

        public int Level
        {
            get { return _Level; }
        }

    }

    class Fighter : DndClass
    {

        public Fighter(int Level) : base()
        { 
            _Level = Level;
            _CharClass = "Fighter";
        }
    }

    class Cleric : DndClass 
    {

        public Cleric(int Level) : base()
        {
            _Level = Level;
            _CharClass = "Cleric";
        }
    }

    class Wizard : DndClass 
    {

        public Wizard(int Level) : base()
        {
            _Level = Level;
            _CharClass = "Wizard";
        }
    }

    class Rouge : DndClass 
    {

        public Rouge(int Level) : base()
        {
            _Level = Level;
            _CharClass = "Rouge";
        }
    }

    class Bard : DndClass 
    {
        public Bard(int Level) : base()
        {
            _Level = Level;
            _CharClass = "Bard";
        }
    }



    abstract class DndRace
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

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

        public Character(int SelectedRace, int SelectedClass, string Name, int Level) 
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
            }

            

        }


        private void calculatingStats()
        {


            
        }
    }


    abstract class DndClass
    {
        //this will be inhearented by all the classes
        protected int _Level;

    }

    class Fighter : DndClass
    {

        public Fighter(int Level) : base()
        { 
            _Level = Level;
        }
    }

    class Cleric : DndClass 
    {

        public Cleric(int Level) : base()
        {
            _Level = Level;

        }
    }

    class Wizard : DndClass 
    {

        public Wizard(int Level) : base()
        {
            _Level = Level;

        }
    }

    class Rouge : DndClass 
    {

        public Rouge(int Level) : base()
        {
            _Level = Level;

        }
    }

    class Bard : DndClass 
    {
        public Bard(int Level) : base()
        {
            _Level = Level;

        }
    }



    abstract class DndRace
    {
        //this will be inherented by all the races
        protected int _speed;
        protected string _size;
        

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
        
    }

    class Human : DndRace
    {


        public Human(): base()
        {

        }
    }

    class Elf : DndRace
    {


        public Elf() : base()
        {

        }
    }

    class Dwarf : DndRace
    {


       public Dwarf(): base()
       {
            _speed = 25;
       }
    }

    class Orc : DndRace
    {
        

        public Orc(): base()
        {

        }

    }

    class Dragonborn : DndRace
    {


        public Dragonborn(): base()
        {


        }

    }


}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M_A_G_I_C_K
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //making the drop boxes default to the select please.. to allow for reselection of nothing after a selected option
            RaceDropBox.SelectedIndex = 0;
            ClassDropBox.SelectedIndex = 0;
        }

        //this will change the spells you can pick etc etc based on what you pick
        private void RaceDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*RaceDropDown
             * Human
                Elf
                Dwarf
                Orc
                DragonBorn
            */


            switch (RaceDropBox.SelectedIndex)
            {
                case 1:
                    //Human

                    break;
                case 2:
                    //elf

                    break;

                case 3:
                    //Dwarf

                    break;

                case 4:
                    //orc

                    break;

                case 5:
                    //DragonBorn

                    break;

                default:
                    //nothing change nothing

                    break;
            }
        }

        private void ClassDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EquipmentCheckBox.Items.Clear();
            FeatCheckBox.Items.Clear();
            SpellCheckBox.Items.Clear();

            /*Class DropDown
                Fighter
                Cleric
                Wizard
                Rogue
                Bard
            */

            //these will all be updates to a linq statments to filter by class then level, and then a loop to create all the items.add for each thing
            switch (ClassDropBox.SelectedIndex)
            {
                case 1:
                    //Fighter
                    EquipmentCheckBox.Items.Add("Items for fighter here!");
                    FeatCheckBox.Items.Add("fighter");
                    SpellCheckBox.Items.Add("Fighter");


                    break;
                case 2:
                    //Cleric
                    EquipmentCheckBox.Items.Add("Items for Cleric here!");
                    FeatCheckBox.Items.Add("Cleric");
                    SpellCheckBox.Items.Add("Cleric");

                    break;

                case 3:
                    //Wizard
                    EquipmentCheckBox.Items.Add("Items for Wizard here!");
                    FeatCheckBox.Items.Add("Wizard");
                    SpellCheckBox.Items.Add("Wizard");

                    break;

                case 4:
                    //Rouge
                    EquipmentCheckBox.Items.Add("Items for Rouge here!");
                    FeatCheckBox.Items.Add("Rouge");
                    SpellCheckBox.Items.Add("Rouge");

                    break;

                case 5:
                    //Bard
                    EquipmentCheckBox.Items.Add("Items for Barb here!");
                    FeatCheckBox.Items.Add("Bard");
                    SpellCheckBox.Items.Add("Bard");

                    break;

                default:
                    //nothing change nothing

                    break;
            }

        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            //collecting things to pass into the character builder

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

            //RaceDropBox.SelectedIndex selects the index of the dropdown that has been selected, and it functions like an array starting at 0
            int SelectedRace = RaceDropBox.SelectedIndex;
            int SelectedClass = ClassDropBox.SelectedIndex;

            string Name = FirstNameTxt.Text + " " + SecondNameTxt.Text;

            int Level = Convert.ToInt32(LevelPicker.Value);


            Character created = new Character(SelectedRace, SelectedClass, Name, Level);

            

            //Ends with opening another form with the information played out more cleanly

        }

        
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace So_You_Wanna_Make_A_Dnd_Character
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

        }

        private void ClassDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

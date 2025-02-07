using System;
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

    /*
     * things to add
     * 
     * 
     * 
     */

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
            STRCheck.Items.Clear();
            DEXCheck.Items.Clear();
            SMRTCheck.Items.Clear();
            CHACheck.Items.Clear();
            CONCheck.Items.Clear();
            WISCheck.Items.Clear();


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
                    STRCheck.Items.Add("+1 by Orc");
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
                    EquipmentCheckBox.Items.Add("Items for fighter");

                    //second switch statment for each level
                    switch (LevelPicker.Value)
                    {
                        case 1:
                            FeatCheckBox.Items.Add("Fighter");
                            SpellCheckBox.Items.Add("Fighter");
                            SpellCheckBox.Items.Add("ONE");

                            break;
                        case 2:
                            FeatCheckBox.Items.Add("Fighter");
                            SpellCheckBox.Items.Add("Fighter");
                            SpellCheckBox.Items.Add("TWO");

                            break;
                        case 3:
                            FeatCheckBox.Items.Add("Fighter");
                            SpellCheckBox.Items.Add("Fighter");
                            SpellCheckBox.Items.Add("THREE");

                            break;
                    }
                    break;
                case 2:
                    //Cleric
                    EquipmentCheckBox.Items.Add("Items for Cleric");

                    switch (LevelPicker.Value)
                    {
                        case 1:
                            FeatCheckBox.Items.Add("Cleric");
                            SpellCheckBox.Items.Add("Cleric");
                            SpellCheckBox.Items.Add("ONE");

                            break;
                        case 2:
                            FeatCheckBox.Items.Add("Cleric");
                            SpellCheckBox.Items.Add("Cleric");
                            SpellCheckBox.Items.Add("TWO");

                            break;
                        case 3:
                            FeatCheckBox.Items.Add("Cleric");
                            SpellCheckBox.Items.Add("Cleric");
                            SpellCheckBox.Items.Add("THREE");

                            break;
                    }

                    break;

                case 3:
                    //Wizard
                    EquipmentCheckBox.Items.Add("Items for Wizard");

                    switch (LevelPicker.Value)
                    {
                        case 1:
                            FeatCheckBox.Items.Add("Wizard");
                            SpellCheckBox.Items.Add("Wizard");
                            SpellCheckBox.Items.Add("ONE");

                            break;
                        case 2:
                            FeatCheckBox.Items.Add("Wizard");
                            SpellCheckBox.Items.Add("Wizard");
                            SpellCheckBox.Items.Add("TWO");

                            break;
                        case 3:
                            FeatCheckBox.Items.Add("Wizard");
                            SpellCheckBox.Items.Add("Wizard");
                            SpellCheckBox.Items.Add("THREE");

                            break;
                    }

                    break;

                case 4:
                    //Rouge
                    EquipmentCheckBox.Items.Add("Items for Rouge");

                    switch (LevelPicker.Value)
                    {
                        case 1:
                            FeatCheckBox.Items.Add("Rouge");
                            SpellCheckBox.Items.Add("Rouge");
                            SpellCheckBox.Items.Add("ONE");

                            break;
                        case 2:
                            FeatCheckBox.Items.Add("Rouge");
                            SpellCheckBox.Items.Add("Rouge");
                            SpellCheckBox.Items.Add("TWO");

                            break;
                        case 3:
                            FeatCheckBox.Items.Add("Rouge");
                            SpellCheckBox.Items.Add("Rouge");
                            SpellCheckBox.Items.Add("THREE");

                            break;
                    }

                    break;

                case 5:
                    //Bard
                    EquipmentCheckBox.Items.Add("Items for Bard");

                    switch (LevelPicker.Value)
                    {
                        case 1:
                            FeatCheckBox.Items.Add("Bard");
                            SpellCheckBox.Items.Add("Bard");
                            SpellCheckBox.Items.Add("ONE");

                            break;
                        case 2:
                            FeatCheckBox.Items.Add("Bard");
                            SpellCheckBox.Items.Add("Bard");
                            SpellCheckBox.Items.Add("TWO");

                            break;
                        case 3:
                            FeatCheckBox.Items.Add("Bard");
                            SpellCheckBox.Items.Add("Bard");
                            SpellCheckBox.Items.Add("THREE");

                            break;
                    }

                    break;

                default:
                    //nothing change nothing

                    break;
            }

        }

        private void LevelPicker_ValueChanged(object sender, EventArgs e)
        {
            //updating this will be more complicated
            FeatCheckBox.Items.Clear();
            SpellCheckBox.Items.Clear();

            /*Class DropDown
                Fighter
                Cleric
                Wizard
                Rogue
                Bard
            */

            //first switch statment for what the class is
            switch (ClassDropBox.SelectedIndex)
            {
                case 1:
                    //Fighter

                    //second switch statment for each level
                    switch (LevelPicker.Value)
                    {
                        case 1:
                            FeatCheckBox.Items.Add("Fighter");
                            SpellCheckBox.Items.Add("Fighter");
                            SpellCheckBox.Items.Add("ONE");

                            break;
                        case 2:
                            FeatCheckBox.Items.Add("Fighter");
                            SpellCheckBox.Items.Add("Fighter");
                            SpellCheckBox.Items.Add("TWO");

                            break;
                        case 3:
                            FeatCheckBox.Items.Add("Fighter");
                            SpellCheckBox.Items.Add("Fighter");
                            SpellCheckBox.Items.Add("THREE");

                            break;
                    }
                    break;
                case 2:
                    //Cleric
                    switch (LevelPicker.Value)
                    {
                        case 1:
                            FeatCheckBox.Items.Add("Cleric");
                            SpellCheckBox.Items.Add("Cleric");
                            SpellCheckBox.Items.Add("ONE");

                            break;
                        case 2:
                            FeatCheckBox.Items.Add("Cleric");
                            SpellCheckBox.Items.Add("Cleric");
                            SpellCheckBox.Items.Add("TWO");

                            break;
                        case 3:
                            FeatCheckBox.Items.Add("Cleric");
                            SpellCheckBox.Items.Add("Cleric");
                            SpellCheckBox.Items.Add("THREE");

                            break;
                    }

                    break;

                case 3:
                    //Wizard
                    switch (LevelPicker.Value)
                    {
                        case 1:
                            FeatCheckBox.Items.Add("Wizard");
                            SpellCheckBox.Items.Add("Wizard");
                            SpellCheckBox.Items.Add("ONE");

                            break;
                        case 2:
                            FeatCheckBox.Items.Add("Wizard");
                            SpellCheckBox.Items.Add("Wizard");
                            SpellCheckBox.Items.Add("TWO");

                            break;
                        case 3:
                            FeatCheckBox.Items.Add("Wizard");
                            SpellCheckBox.Items.Add("Wizard");
                            SpellCheckBox.Items.Add("THREE");

                            break;
                    }

                    break;

                case 4:
                    //Rouge
                    switch (LevelPicker.Value)
                    {
                        case 1:
                            FeatCheckBox.Items.Add("Rouge");
                            SpellCheckBox.Items.Add("Rouge");
                            SpellCheckBox.Items.Add("ONE");

                            break;
                        case 2:
                            FeatCheckBox.Items.Add("Rouge");
                            SpellCheckBox.Items.Add("Rouge");
                            SpellCheckBox.Items.Add("TWO");

                            break;
                        case 3:
                            FeatCheckBox.Items.Add("Rouge");
                            SpellCheckBox.Items.Add("Rouge");
                            SpellCheckBox.Items.Add("THREE");

                            break;
                    }

                    break;

                case 5:
                    //Bard
                    switch (LevelPicker.Value)
                    {
                        case 1:
                            FeatCheckBox.Items.Add("Bard");
                            SpellCheckBox.Items.Add("Bard");
                            SpellCheckBox.Items.Add("ONE");

                            break;
                        case 2:
                            FeatCheckBox.Items.Add("Bard");
                            SpellCheckBox.Items.Add("Bard");
                            SpellCheckBox.Items.Add("TWO");

                            break;
                        case 3:
                            FeatCheckBox.Items.Add("Bard");
                            SpellCheckBox.Items.Add("Bard");
                            SpellCheckBox.Items.Add("THREE");

                            break;
                    }

                    break;

                default:
                    //nothing change nothing

                    break;
            }
        }

        private void StatRoll_Click(object sender, EventArgs e)
        {
            //this will roll the stats or do standard array and will improve it based on the class
            //can 

            var ran = new Random();

            if (ClassDropBox.SelectedIndex == 0)
            {
                DEXStats.Value = ran.Next(6, 21);
                STRstats.Value = ran.Next(6, 21);
                SMRTStats.Value = ran.Next(6, 21);
                CHAStats.Value = ran.Next(6, 21);
                WISstats.Value = ran.Next(6, 21);
                CONStats.Value = ran.Next(6, 21);
            }
            else
            {
                //randomly generated stats rolled but with preference for the ones needed by the class
            }
        }


        //will add value changed for all the stat nums, to update the profis bounus thingy        
        private void STRstats_ValueChanged(object sender, EventArgs e)
        {
            if (STRstats.Value >= 6 && STRstats.Value < 8) STRbonusTxt.Text = "-2";
            else if (STRstats.Value >= 8 && STRstats.Value < 10) STRbonusTxt.Text = "-1";
            else if (STRstats.Value >= 10 && STRstats.Value < 12) STRbonusTxt.Text = "0";
            else if (STRstats.Value >= 12 && STRstats.Value < 14) STRbonusTxt.Text = "+1";
            else if (STRstats.Value >= 14) STRbonusTxt.Text = "+2";
  
        }

        private void DEXStats_ValueChanged(object sender, EventArgs e)
        {
            if (DEXStats.Value >= 6 && DEXStats.Value < 8) DEXbonusTxt.Text = "-2";
            else if (DEXStats.Value >= 8 && DEXStats.Value < 10) DEXbonusTxt.Text = "-1";
            else if (DEXStats.Value >= 10 && STRstats.Value < 12) DEXbonusTxt.Text = "0";
            else if (STRstats.Value >= 12 && DEXStats.Value < 14) DEXbonusTxt.Text = "+1";
            else if (DEXStats.Value >= 14) DEXbonusTxt.Text = "+2";
        }

        private void CONStats_ValueChanged(object sender, EventArgs e)
        {
            if (CONStats.Value >= 6 && CONStats.Value < 8) CONbonusTxt.Text = "-2";
            else if (CONStats.Value >= 8 && CONStats.Value < 10) CONbonusTxt.Text = "-1";
            else if (CONStats.Value >= 10 && CONStats.Value < 12) CONbonusTxt.Text = "0";
            else if (CONStats.Value >= 12 && CONStats.Value < 14) CONbonusTxt.Text = "+1";
            else if (CONStats.Value >= 14) CONbonusTxt.Text = "+2";
        }

        private void SMRTStats_ValueChanged(object sender, EventArgs e)
        {
            if (SMRTStats.Value >= 6 && SMRTStats.Value < 8) SMRTbonusTxt.Text = "-2";
            else if (SMRTStats.Value >= 8 && SMRTStats.Value < 10) SMRTbonusTxt.Text = "-1";
            else if (SMRTStats.Value >= 10 && SMRTStats.Value < 12) SMRTbonusTxt.Text = "0";
            else if (SMRTStats.Value >= 12 && SMRTStats.Value < 14) SMRTbonusTxt.Text = "+1";
            else if (SMRTStats.Value >= 14) SMRTbonusTxt.Text = "+2";
        }

        private void WISstats_ValueChanged(object sender, EventArgs e)
        {
            if (WISstats.Value >= 6 && WISstats.Value < 8) WISbonusTxt.Text = "-2";
            else if (WISstats.Value >= 8 && WISstats.Value < 10) WISbonusTxt.Text = "-1";
            else if (WISstats.Value >= 10 && WISstats.Value < 12) WISbonusTxt.Text = "0";
            else if (WISstats.Value >= 12 && WISstats.Value < 14) WISbonusTxt.Text = "+1";
            else if (WISstats.Value >= 14) WISbonusTxt.Text = "+2";
        }

        private void CHAStats_ValueChanged(object sender, EventArgs e)
        {
            if (CHAStats.Value >= 6 && CHAStats.Value < 8) CHAbonusTxt.Text = "-2";
            else if (CHAStats.Value >= 8 && CHAStats.Value < 10) CHAbonusTxt.Text = "-1";
            else if (CHAStats.Value >= 10 && CHAStats.Value < 12) CHAbonusTxt.Text = "0";
            else if (CHAStats.Value >= 12 && CHAStats.Value < 14) CHAbonusTxt.Text = "+1";
            else if (CHAStats.Value >= 14) CHAbonusTxt.Text = "+2";
        }

        //main button click
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

            //collecting all the stats
            int[] Stats = new int[6];

            Stats[0] = Convert.ToInt32(STRstats.Value);
            Stats[1] = Convert.ToInt32(DEXStats.Value);
            Stats[2] = Convert.ToInt32(SMRTStats.Value);
            Stats[3] = Convert.ToInt32(CONStats.Value);
            Stats[4] = Convert.ToInt32(CHAStats.Value);
            Stats[5] = Convert.ToInt32(WISstats.Value);
  
            Character created = new Character(SelectedRace, SelectedClass, Name, Level, Stats);

            created.creatingPdf();

            //Ends with opening another form with the information played out more cleanly

        }
    }
}

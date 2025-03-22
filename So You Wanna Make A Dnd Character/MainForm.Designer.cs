namespace M_A_G_I_C_K
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClassDropBox = new System.Windows.Forms.ComboBox();
            this.RaceDropBox = new System.Windows.Forms.ComboBox();
            this.RaceLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.FirstNameTxt = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EquipmentCheckBox = new System.Windows.Forms.CheckedListBox();
            this.SpellCheckBox = new System.Windows.Forms.CheckedListBox();
            this.FeatCheckBox = new System.Windows.Forms.CheckedListBox();
            this.runBtn = new System.Windows.Forms.Button();
            this.STRlabel = new System.Windows.Forms.Label();
            this.CHALabel = new System.Windows.Forms.Label();
            this.WISLabel = new System.Windows.Forms.Label();
            this.SMRTlabel = new System.Windows.Forms.Label();
            this.CONLabel = new System.Windows.Forms.Label();
            this.DEXlabel = new System.Windows.Forms.Label();
            this.NameSLabel = new System.Windows.Forms.Label();
            this.SecondNameTxt = new System.Windows.Forms.TextBox();
            this.LevelPicker = new System.Windows.Forms.NumericUpDown();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.STRCheck = new System.Windows.Forms.CheckedListBox();
            this.DEXCheck = new System.Windows.Forms.CheckedListBox();
            this.CONCheck = new System.Windows.Forms.CheckedListBox();
            this.SMRTCheck = new System.Windows.Forms.CheckedListBox();
            this.WISCheck = new System.Windows.Forms.CheckedListBox();
            this.CHACheck = new System.Windows.Forms.CheckedListBox();
            this.StatRoll = new System.Windows.Forms.Button();
            this.STRstats = new System.Windows.Forms.NumericUpDown();
            this.DEXStats = new System.Windows.Forms.NumericUpDown();
            this.CONStats = new System.Windows.Forms.NumericUpDown();
            this.SMRTStats = new System.Windows.Forms.NumericUpDown();
            this.WISstats = new System.Windows.Forms.NumericUpDown();
            this.CHAStats = new System.Windows.Forms.NumericUpDown();
            this.STRbonusTxt = new System.Windows.Forms.RichTextBox();
            this.DEXbonusTxt = new System.Windows.Forms.RichTextBox();
            this.CONbonusTxt = new System.Windows.Forms.RichTextBox();
            this.SMRTbonusTxt = new System.Windows.Forms.RichTextBox();
            this.WISbonusTxt = new System.Windows.Forms.RichTextBox();
            this.CHAbonusTxt = new System.Windows.Forms.RichTextBox();
            this.backgroundTb = new System.Windows.Forms.Label();
            this.backgroundTb1 = new System.Windows.Forms.TextBox();
            this.spellbookLbl = new System.Windows.Forms.Label();
            this.WeaponsLbl = new System.Windows.Forms.Label();
            this.classFeaturesLbl = new System.Windows.Forms.Label();
            this.statsLbl = new System.Windows.Forms.Label();
            this.playerIcon = new System.Windows.Forms.PictureBox();
            this.cantripLbl = new System.Windows.Forms.Label();
            this.Armours = new System.Windows.Forms.Label();
            this.ArmCheckbox = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InventoryCheckbox = new System.Windows.Forms.CheckedListBox();
            this.CantripList = new System.Windows.Forms.CheckedListBox();
            this.ProgressBarBtn = new System.Windows.Forms.Button();
            this.cantripsLbl = new System.Windows.Forms.Label();
            this.cantripLblCount = new System.Windows.Forms.Label();
            this.spellbookLblCount = new System.Windows.Forms.Label();
            this.RanNameBtn = new System.Windows.Forms.Button();
            this.randomNameLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LevelPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STRstats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEXStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMRTStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WISstats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHAStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassDropBox
            // 
            this.ClassDropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassDropBox.FormattingEnabled = true;
            this.ClassDropBox.Items.AddRange(new object[] {
            "Select Option",
            "Fighter",
            "Cleric",
            "Wizard",
            "Rogue",
            "Bard"});
            this.ClassDropBox.Location = new System.Drawing.Point(209, 69);
            this.ClassDropBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassDropBox.Name = "ClassDropBox";
            this.ClassDropBox.Size = new System.Drawing.Size(119, 24);
            this.ClassDropBox.TabIndex = 0;
            this.ClassDropBox.SelectedIndexChanged += new System.EventHandler(this.ClassDropBox_SelectedIndexChanged);
            // 
            // RaceDropBox
            // 
            this.RaceDropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RaceDropBox.FormattingEnabled = true;
            this.RaceDropBox.Items.AddRange(new object[] {
            "Select Option",
            "Human",
            "Elf",
            "Dwarf",
            "Orc",
            "Dragonborn"});
            this.RaceDropBox.Location = new System.Drawing.Point(337, 69);
            this.RaceDropBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RaceDropBox.Name = "RaceDropBox";
            this.RaceDropBox.Size = new System.Drawing.Size(117, 24);
            this.RaceDropBox.TabIndex = 0;
            this.RaceDropBox.SelectedIndexChanged += new System.EventHandler(this.RaceDropBox_SelectedIndexChanged);
            // 
            // RaceLabel
            // 
            this.RaceLabel.AutoSize = true;
            this.RaceLabel.Location = new System.Drawing.Point(334, 51);
            this.RaceLabel.Name = "RaceLabel";
            this.RaceLabel.Size = new System.Drawing.Size(40, 16);
            this.RaceLabel.TabIndex = 2;
            this.RaceLabel.Text = "Race";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(209, 51);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(41, 16);
            this.ClassLabel.TabIndex = 3;
            this.ClassLabel.Text = "Class";
            // 
            // FirstNameTxt
            // 
            this.FirstNameTxt.Location = new System.Drawing.Point(209, 25);
            this.FirstNameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FirstNameTxt.Name = "FirstNameTxt";
            this.FirstNameTxt.Size = new System.Drawing.Size(119, 22);
            this.FirstNameTxt.TabIndex = 4;
            this.FirstNameTxt.Text = "Unknown";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(209, 7);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(72, 16);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "First Name";
            // 
            // EquipmentCheckBox
            // 
            this.EquipmentCheckBox.FormattingEnabled = true;
            this.EquipmentCheckBox.Location = new System.Drawing.Point(163, 240);
            this.EquipmentCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EquipmentCheckBox.Name = "EquipmentCheckBox";
            this.EquipmentCheckBox.Size = new System.Drawing.Size(165, 191);
            this.EquipmentCheckBox.TabIndex = 6;
            // 
            // SpellCheckBox
            // 
            this.SpellCheckBox.FormattingEnabled = true;
            this.SpellCheckBox.Location = new System.Drawing.Point(11, 374);
            this.SpellCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpellCheckBox.Name = "SpellCheckBox";
            this.SpellCheckBox.Size = new System.Drawing.Size(140, 293);
            this.SpellCheckBox.TabIndex = 7;
            this.SpellCheckBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.SpellCheckBox_ItemCheck);
            // 
            // FeatCheckBox
            // 
            this.FeatCheckBox.FormattingEnabled = true;
            this.FeatCheckBox.Location = new System.Drawing.Point(348, 459);
            this.FeatCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FeatCheckBox.Name = "FeatCheckBox";
            this.FeatCheckBox.Size = new System.Drawing.Size(165, 208);
            this.FeatCheckBox.TabIndex = 8;
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(532, 630);
            this.runBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(281, 37);
            this.runBtn.TabIndex = 9;
            this.runBtn.Text = "Print Character";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // STRlabel
            // 
            this.STRlabel.AutoSize = true;
            this.STRlabel.Location = new System.Drawing.Point(527, 37);
            this.STRlabel.Name = "STRlabel";
            this.STRlabel.Size = new System.Drawing.Size(95, 16);
            this.STRlabel.TabIndex = 16;
            this.STRlabel.Text = "Strength (STR)";
            // 
            // CHALabel
            // 
            this.CHALabel.AutoSize = true;
            this.CHALabel.Location = new System.Drawing.Point(524, 338);
            this.CHALabel.Name = "CHALabel";
            this.CHALabel.Size = new System.Drawing.Size(103, 16);
            this.CHALabel.TabIndex = 17;
            this.CHALabel.Text = "Charisma (CHA)";
            // 
            // WISLabel
            // 
            this.WISLabel.AutoSize = true;
            this.WISLabel.Location = new System.Drawing.Point(527, 278);
            this.WISLabel.Name = "WISLabel";
            this.WISLabel.Size = new System.Drawing.Size(93, 16);
            this.WISLabel.TabIndex = 18;
            this.WISLabel.Text = "Wisdom (WIS)";
            // 
            // SMRTlabel
            // 
            this.SMRTlabel.AutoSize = true;
            this.SMRTlabel.Location = new System.Drawing.Point(524, 216);
            this.SMRTlabel.Name = "SMRTlabel";
            this.SMRTlabel.Size = new System.Drawing.Size(113, 16);
            this.SMRTlabel.TabIndex = 19;
            this.SMRTlabel.Text = "Intellegence (INT)";
            // 
            // CONLabel
            // 
            this.CONLabel.AutoSize = true;
            this.CONLabel.Location = new System.Drawing.Point(524, 156);
            this.CONLabel.Name = "CONLabel";
            this.CONLabel.Size = new System.Drawing.Size(115, 16);
            this.CONLabel.TabIndex = 20;
            this.CONLabel.Text = "Constitution (CON)";
            // 
            // DEXlabel
            // 
            this.DEXlabel.AutoSize = true;
            this.DEXlabel.Location = new System.Drawing.Point(527, 95);
            this.DEXlabel.Name = "DEXlabel";
            this.DEXlabel.Size = new System.Drawing.Size(97, 16);
            this.DEXlabel.TabIndex = 21;
            this.DEXlabel.Text = "Dexterity (DEX)";
            // 
            // NameSLabel
            // 
            this.NameSLabel.AutoSize = true;
            this.NameSLabel.Location = new System.Drawing.Point(334, 7);
            this.NameSLabel.Name = "NameSLabel";
            this.NameSLabel.Size = new System.Drawing.Size(72, 16);
            this.NameSLabel.TabIndex = 23;
            this.NameSLabel.Text = "Last Name";
            // 
            // SecondNameTxt
            // 
            this.SecondNameTxt.Location = new System.Drawing.Point(337, 25);
            this.SecondNameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SecondNameTxt.Name = "SecondNameTxt";
            this.SecondNameTxt.Size = new System.Drawing.Size(117, 22);
            this.SecondNameTxt.TabIndex = 22;
            this.SecondNameTxt.Text = "Adventurer";
            // 
            // LevelPicker
            // 
            this.LevelPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelPicker.Location = new System.Drawing.Point(462, 69);
            this.LevelPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LevelPicker.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.LevelPicker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LevelPicker.Name = "LevelPicker";
            this.LevelPicker.ReadOnly = true;
            this.LevelPicker.Size = new System.Drawing.Size(50, 45);
            this.LevelPicker.TabIndex = 24;
            this.LevelPicker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LevelPicker.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LevelPicker.ValueChanged += new System.EventHandler(this.LevelPicker_ValueChanged);
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Location = new System.Drawing.Point(460, 51);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(40, 16);
            this.LevelLabel.TabIndex = 25;
            this.LevelLabel.Text = "Level";
            // 
            // STRCheck
            // 
            this.STRCheck.FormattingEnabled = true;
            this.STRCheck.Location = new System.Drawing.Point(639, 56);
            this.STRCheck.Name = "STRCheck";
            this.STRCheck.Size = new System.Drawing.Size(174, 38);
            this.STRCheck.TabIndex = 26;
            // 
            // DEXCheck
            // 
            this.DEXCheck.FormattingEnabled = true;
            this.DEXCheck.Location = new System.Drawing.Point(639, 115);
            this.DEXCheck.Name = "DEXCheck";
            this.DEXCheck.Size = new System.Drawing.Size(174, 38);
            this.DEXCheck.TabIndex = 27;
            // 
            // CONCheck
            // 
            this.CONCheck.FormattingEnabled = true;
            this.CONCheck.Location = new System.Drawing.Point(639, 175);
            this.CONCheck.Name = "CONCheck";
            this.CONCheck.Size = new System.Drawing.Size(174, 38);
            this.CONCheck.TabIndex = 28;
            // 
            // SMRTCheck
            // 
            this.SMRTCheck.FormattingEnabled = true;
            this.SMRTCheck.Location = new System.Drawing.Point(639, 237);
            this.SMRTCheck.Name = "SMRTCheck";
            this.SMRTCheck.Size = new System.Drawing.Size(174, 38);
            this.SMRTCheck.TabIndex = 29;
            // 
            // WISCheck
            // 
            this.WISCheck.FormattingEnabled = true;
            this.WISCheck.Location = new System.Drawing.Point(639, 297);
            this.WISCheck.Name = "WISCheck";
            this.WISCheck.Size = new System.Drawing.Size(174, 38);
            this.WISCheck.TabIndex = 30;
            // 
            // CHACheck
            // 
            this.CHACheck.FormattingEnabled = true;
            this.CHACheck.Location = new System.Drawing.Point(639, 357);
            this.CHACheck.Name = "CHACheck";
            this.CHACheck.Size = new System.Drawing.Size(174, 38);
            this.CHACheck.TabIndex = 31;
            // 
            // StatRoll
            // 
            this.StatRoll.Location = new System.Drawing.Point(530, 406);
            this.StatRoll.Name = "StatRoll";
            this.StatRoll.Size = new System.Drawing.Size(283, 39);
            this.StatRoll.TabIndex = 32;
            this.StatRoll.Text = "Stat Randomizer";
            this.StatRoll.UseVisualStyleBackColor = true;
            this.StatRoll.Click += new System.EventHandler(this.StatRoll_Click);
            // 
            // STRstats
            // 
            this.STRstats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STRstats.Location = new System.Drawing.Point(527, 56);
            this.STRstats.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.STRstats.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.STRstats.Name = "STRstats";
            this.STRstats.ReadOnly = true;
            this.STRstats.Size = new System.Drawing.Size(62, 36);
            this.STRstats.TabIndex = 35;
            this.STRstats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.STRstats.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.STRstats.ValueChanged += new System.EventHandler(this.STRstats_ValueChanged);
            // 
            // DEXStats
            // 
            this.DEXStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEXStats.Location = new System.Drawing.Point(527, 117);
            this.DEXStats.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.DEXStats.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.DEXStats.Name = "DEXStats";
            this.DEXStats.ReadOnly = true;
            this.DEXStats.Size = new System.Drawing.Size(62, 36);
            this.DEXStats.TabIndex = 36;
            this.DEXStats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DEXStats.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.DEXStats.ValueChanged += new System.EventHandler(this.DEXStats_ValueChanged);
            // 
            // CONStats
            // 
            this.CONStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONStats.Location = new System.Drawing.Point(527, 175);
            this.CONStats.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.CONStats.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.CONStats.Name = "CONStats";
            this.CONStats.ReadOnly = true;
            this.CONStats.Size = new System.Drawing.Size(62, 36);
            this.CONStats.TabIndex = 37;
            this.CONStats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CONStats.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.CONStats.ValueChanged += new System.EventHandler(this.CONStats_ValueChanged);
            // 
            // SMRTStats
            // 
            this.SMRTStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMRTStats.Location = new System.Drawing.Point(527, 237);
            this.SMRTStats.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.SMRTStats.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.SMRTStats.Name = "SMRTStats";
            this.SMRTStats.ReadOnly = true;
            this.SMRTStats.Size = new System.Drawing.Size(62, 36);
            this.SMRTStats.TabIndex = 38;
            this.SMRTStats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SMRTStats.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.SMRTStats.ValueChanged += new System.EventHandler(this.SMRTStats_ValueChanged);
            // 
            // WISstats
            // 
            this.WISstats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WISstats.Location = new System.Drawing.Point(527, 297);
            this.WISstats.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.WISstats.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.WISstats.Name = "WISstats";
            this.WISstats.ReadOnly = true;
            this.WISstats.Size = new System.Drawing.Size(62, 36);
            this.WISstats.TabIndex = 39;
            this.WISstats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WISstats.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.WISstats.ValueChanged += new System.EventHandler(this.WISstats_ValueChanged);
            // 
            // CHAStats
            // 
            this.CHAStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHAStats.Location = new System.Drawing.Point(527, 357);
            this.CHAStats.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.CHAStats.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.CHAStats.Name = "CHAStats";
            this.CHAStats.ReadOnly = true;
            this.CHAStats.Size = new System.Drawing.Size(62, 36);
            this.CHAStats.TabIndex = 40;
            this.CHAStats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHAStats.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.CHAStats.ValueChanged += new System.EventHandler(this.CHAStats_ValueChanged);
            // 
            // STRbonusTxt
            // 
            this.STRbonusTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STRbonusTxt.Location = new System.Drawing.Point(595, 56);
            this.STRbonusTxt.Name = "STRbonusTxt";
            this.STRbonusTxt.ReadOnly = true;
            this.STRbonusTxt.Size = new System.Drawing.Size(38, 38);
            this.STRbonusTxt.TabIndex = 41;
            this.STRbonusTxt.Text = "-2";
            // 
            // DEXbonusTxt
            // 
            this.DEXbonusTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEXbonusTxt.Location = new System.Drawing.Point(595, 115);
            this.DEXbonusTxt.Name = "DEXbonusTxt";
            this.DEXbonusTxt.ReadOnly = true;
            this.DEXbonusTxt.Size = new System.Drawing.Size(38, 38);
            this.DEXbonusTxt.TabIndex = 42;
            this.DEXbonusTxt.Text = "-2";
            // 
            // CONbonusTxt
            // 
            this.CONbonusTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONbonusTxt.Location = new System.Drawing.Point(595, 175);
            this.CONbonusTxt.Name = "CONbonusTxt";
            this.CONbonusTxt.ReadOnly = true;
            this.CONbonusTxt.Size = new System.Drawing.Size(38, 38);
            this.CONbonusTxt.TabIndex = 43;
            this.CONbonusTxt.Text = "-2";
            // 
            // SMRTbonusTxt
            // 
            this.SMRTbonusTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMRTbonusTxt.Location = new System.Drawing.Point(595, 237);
            this.SMRTbonusTxt.Name = "SMRTbonusTxt";
            this.SMRTbonusTxt.ReadOnly = true;
            this.SMRTbonusTxt.Size = new System.Drawing.Size(38, 38);
            this.SMRTbonusTxt.TabIndex = 44;
            this.SMRTbonusTxt.Text = "-2";
            // 
            // WISbonusTxt
            // 
            this.WISbonusTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WISbonusTxt.Location = new System.Drawing.Point(595, 297);
            this.WISbonusTxt.Name = "WISbonusTxt";
            this.WISbonusTxt.ReadOnly = true;
            this.WISbonusTxt.Size = new System.Drawing.Size(38, 38);
            this.WISbonusTxt.TabIndex = 45;
            this.WISbonusTxt.Text = "-2";
            // 
            // CHAbonusTxt
            // 
            this.CHAbonusTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHAbonusTxt.Location = new System.Drawing.Point(595, 357);
            this.CHAbonusTxt.Name = "CHAbonusTxt";
            this.CHAbonusTxt.ReadOnly = true;
            this.CHAbonusTxt.Size = new System.Drawing.Size(38, 38);
            this.CHAbonusTxt.TabIndex = 46;
            this.CHAbonusTxt.Text = "-2";
            // 
            // backgroundTb
            // 
            this.backgroundTb.AutoSize = true;
            this.backgroundTb.Location = new System.Drawing.Point(209, 102);
            this.backgroundTb.Name = "backgroundTb";
            this.backgroundTb.Size = new System.Drawing.Size(80, 16);
            this.backgroundTb.TabIndex = 48;
            this.backgroundTb.Text = "Background";
            // 
            // backgroundTb1
            // 
            this.backgroundTb1.Location = new System.Drawing.Point(209, 119);
            this.backgroundTb1.Multiline = true;
            this.backgroundTb1.Name = "backgroundTb1";
            this.backgroundTb1.Size = new System.Drawing.Size(301, 94);
            this.backgroundTb1.TabIndex = 49;
            // 
            // spellbookLbl
            // 
            this.spellbookLbl.AutoSize = true;
            this.spellbookLbl.Location = new System.Drawing.Point(8, 353);
            this.spellbookLbl.Name = "spellbookLbl";
            this.spellbookLbl.Size = new System.Drawing.Size(69, 16);
            this.spellbookLbl.TabIndex = 50;
            this.spellbookLbl.Text = "Spellbook";
            // 
            // WeaponsLbl
            // 
            this.WeaponsLbl.AutoSize = true;
            this.WeaponsLbl.Location = new System.Drawing.Point(160, 220);
            this.WeaponsLbl.Name = "WeaponsLbl";
            this.WeaponsLbl.Size = new System.Drawing.Size(66, 16);
            this.WeaponsLbl.TabIndex = 51;
            this.WeaponsLbl.Text = "Weapons";
            // 
            // classFeaturesLbl
            // 
            this.classFeaturesLbl.AutoSize = true;
            this.classFeaturesLbl.Location = new System.Drawing.Point(342, 441);
            this.classFeaturesLbl.Name = "classFeaturesLbl";
            this.classFeaturesLbl.Size = new System.Drawing.Size(97, 16);
            this.classFeaturesLbl.TabIndex = 52;
            this.classFeaturesLbl.Text = "Class Features";
            // 
            // statsLbl
            // 
            this.statsLbl.AutoSize = true;
            this.statsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsLbl.Location = new System.Drawing.Point(538, 9);
            this.statsLbl.Name = "statsLbl";
            this.statsLbl.Size = new System.Drawing.Size(233, 29);
            this.statsLbl.TabIndex = 53;
            this.statsLbl.Text = "Character Statistics";
            // 
            // playerIcon
            // 
            this.playerIcon.Image = global::So_You_Wanna_Make_A_Dnd_Character.Properties.Resources.Default;
            this.playerIcon.Location = new System.Drawing.Point(11, 16);
            this.playerIcon.Name = "playerIcon";
            this.playerIcon.Size = new System.Drawing.Size(192, 192);
            this.playerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerIcon.TabIndex = 47;
            this.playerIcon.TabStop = false;
            // 
            // cantripLbl
            // 
            this.cantripLbl.AutoSize = true;
            this.cantripLbl.Location = new System.Drawing.Point(10, 296);
            this.cantripLbl.Name = "cantripLbl";
            this.cantripLbl.Size = new System.Drawing.Size(56, 16);
            this.cantripLbl.TabIndex = 67;
            this.cantripLbl.Text = "Cantrips";
            // 
            // Armours
            // 
            this.Armours.AutoSize = true;
            this.Armours.Location = new System.Drawing.Point(160, 441);
            this.Armours.Name = "Armours";
            this.Armours.Size = new System.Drawing.Size(50, 16);
            this.Armours.TabIndex = 69;
            this.Armours.Text = "Armour";
            // 
            // ArmCheckbox
            // 
            this.ArmCheckbox.FormattingEnabled = true;
            this.ArmCheckbox.Location = new System.Drawing.Point(163, 459);
            this.ArmCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ArmCheckbox.Name = "ArmCheckbox";
            this.ArmCheckbox.Size = new System.Drawing.Size(165, 208);
            this.ArmCheckbox.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 71;
            this.label2.Text = "Equipment";
            // 
            // InventoryCheckbox
            // 
            this.InventoryCheckbox.FormattingEnabled = true;
            this.InventoryCheckbox.Location = new System.Drawing.Point(345, 240);
            this.InventoryCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InventoryCheckbox.Name = "InventoryCheckbox";
            this.InventoryCheckbox.Size = new System.Drawing.Size(165, 191);
            this.InventoryCheckbox.TabIndex = 70;
            // 
            // CantripList
            // 
            this.CantripList.FormattingEnabled = true;
            this.CantripList.Location = new System.Drawing.Point(11, 240);
            this.CantripList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CantripList.Name = "CantripList";
            this.CantripList.Size = new System.Drawing.Size(140, 106);
            this.CantripList.TabIndex = 72;
            this.CantripList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CantripList_ItemCheck);
            // 
            // ProgressBarBtn
            // 
            this.ProgressBarBtn.Location = new System.Drawing.Point(532, 599);
            this.ProgressBarBtn.Name = "ProgressBarBtn";
            this.ProgressBarBtn.Size = new System.Drawing.Size(281, 26);
            this.ProgressBarBtn.TabIndex = 73;
            this.ProgressBarBtn.Text = "PROGRESS BAR SIZING";
            this.ProgressBarBtn.UseVisualStyleBackColor = true;
            // 
            // cantripsLbl
            // 
            this.cantripsLbl.AutoSize = true;
            this.cantripsLbl.Location = new System.Drawing.Point(8, 220);
            this.cantripsLbl.Name = "cantripsLbl";
            this.cantripsLbl.Size = new System.Drawing.Size(56, 16);
            this.cantripsLbl.TabIndex = 74;
            this.cantripsLbl.Text = "Cantrips";
            // 
            // cantripLblCount
            // 
            this.cantripLblCount.AutoSize = true;
            this.cantripLblCount.Location = new System.Drawing.Point(103, 220);
            this.cantripLblCount.Name = "cantripLblCount";
            this.cantripLblCount.Size = new System.Drawing.Size(48, 16);
            this.cantripLblCount.TabIndex = 75;
            this.cantripLblCount.Text = "( X / Y )";
            // 
            // spellbookLblCount
            // 
            this.spellbookLblCount.AutoSize = true;
            this.spellbookLblCount.Location = new System.Drawing.Point(103, 353);
            this.spellbookLblCount.Name = "spellbookLblCount";
            this.spellbookLblCount.Size = new System.Drawing.Size(48, 16);
            this.spellbookLblCount.TabIndex = 76;
            this.spellbookLblCount.Text = "( X / Y )";
            // 
            // RanNameBtn
            // 
            this.RanNameBtn.Location = new System.Drawing.Point(460, 25);
            this.RanNameBtn.Name = "RanNameBtn";
            this.RanNameBtn.Size = new System.Drawing.Size(61, 23);
            this.RanNameBtn.TabIndex = 77;
            this.RanNameBtn.Text = "RNG";
            this.RanNameBtn.UseVisualStyleBackColor = true;
            this.RanNameBtn.Click += new System.EventHandler(this.RanNameBtn_Click);
            // 
            // randomNameLbl
            // 
            this.randomNameLbl.AutoSize = true;
            this.randomNameLbl.Location = new System.Drawing.Point(422, 6);
            this.randomNameLbl.Name = "randomNameLbl";
            this.randomNameLbl.Size = new System.Drawing.Size(99, 16);
            this.randomNameLbl.TabIndex = 79;
            this.randomNameLbl.Text = "Random Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 684);
            this.Controls.Add(this.randomNameLbl);
            this.Controls.Add(this.RanNameBtn);
            this.Controls.Add(this.spellbookLblCount);
            this.Controls.Add(this.cantripLblCount);
            this.Controls.Add(this.cantripsLbl);
            this.Controls.Add(this.ProgressBarBtn);
            this.Controls.Add(this.CantripList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InventoryCheckbox);
            this.Controls.Add(this.Armours);
            this.Controls.Add(this.ArmCheckbox);
            this.Controls.Add(this.cantripLbl);
            this.Controls.Add(this.statsLbl);
            this.Controls.Add(this.classFeaturesLbl);
            this.Controls.Add(this.WeaponsLbl);
            this.Controls.Add(this.spellbookLbl);
            this.Controls.Add(this.backgroundTb1);
            this.Controls.Add(this.backgroundTb);
            this.Controls.Add(this.playerIcon);
            this.Controls.Add(this.CHAbonusTxt);
            this.Controls.Add(this.WISbonusTxt);
            this.Controls.Add(this.SMRTbonusTxt);
            this.Controls.Add(this.CONbonusTxt);
            this.Controls.Add(this.DEXbonusTxt);
            this.Controls.Add(this.STRbonusTxt);
            this.Controls.Add(this.CHAStats);
            this.Controls.Add(this.WISstats);
            this.Controls.Add(this.SMRTStats);
            this.Controls.Add(this.CONStats);
            this.Controls.Add(this.DEXStats);
            this.Controls.Add(this.STRstats);
            this.Controls.Add(this.StatRoll);
            this.Controls.Add(this.CHACheck);
            this.Controls.Add(this.WISCheck);
            this.Controls.Add(this.SMRTCheck);
            this.Controls.Add(this.CONCheck);
            this.Controls.Add(this.DEXCheck);
            this.Controls.Add(this.STRCheck);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.LevelPicker);
            this.Controls.Add(this.NameSLabel);
            this.Controls.Add(this.SecondNameTxt);
            this.Controls.Add(this.DEXlabel);
            this.Controls.Add(this.CONLabel);
            this.Controls.Add(this.SMRTlabel);
            this.Controls.Add(this.WISLabel);
            this.Controls.Add(this.CHALabel);
            this.Controls.Add(this.STRlabel);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.FeatCheckBox);
            this.Controls.Add(this.SpellCheckBox);
            this.Controls.Add(this.EquipmentCheckBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.FirstNameTxt);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.RaceLabel);
            this.Controls.Add(this.RaceDropBox);
            this.Controls.Add(this.ClassDropBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Multifaceted Assistant Generating Iconic Characters Kit";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LevelPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STRstats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEXStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMRTStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WISstats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHAStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ClassDropBox;
        private System.Windows.Forms.ComboBox RaceDropBox;
        private System.Windows.Forms.Label RaceLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.TextBox FirstNameTxt;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.CheckedListBox EquipmentCheckBox;
        private System.Windows.Forms.CheckedListBox SpellCheckBox;
        private System.Windows.Forms.CheckedListBox FeatCheckBox;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Label STRlabel;
        private System.Windows.Forms.Label CHALabel;
        private System.Windows.Forms.Label WISLabel;
        private System.Windows.Forms.Label SMRTlabel;
        private System.Windows.Forms.Label CONLabel;
        private System.Windows.Forms.Label DEXlabel;
        private System.Windows.Forms.Label NameSLabel;
        private System.Windows.Forms.TextBox SecondNameTxt;
        private System.Windows.Forms.NumericUpDown LevelPicker;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.CheckedListBox STRCheck;
        private System.Windows.Forms.CheckedListBox DEXCheck;
        private System.Windows.Forms.CheckedListBox CONCheck;
        private System.Windows.Forms.CheckedListBox SMRTCheck;
        private System.Windows.Forms.CheckedListBox WISCheck;
        private System.Windows.Forms.CheckedListBox CHACheck;
        private System.Windows.Forms.Button StatRoll;
        private System.Windows.Forms.NumericUpDown STRstats;
        private System.Windows.Forms.NumericUpDown DEXStats;
        private System.Windows.Forms.NumericUpDown CONStats;
        private System.Windows.Forms.NumericUpDown SMRTStats;
        private System.Windows.Forms.NumericUpDown WISstats;
        private System.Windows.Forms.NumericUpDown CHAStats;
        private System.Windows.Forms.RichTextBox STRbonusTxt;
        private System.Windows.Forms.RichTextBox DEXbonusTxt;
        private System.Windows.Forms.RichTextBox CONbonusTxt;
        private System.Windows.Forms.RichTextBox SMRTbonusTxt;
        private System.Windows.Forms.RichTextBox WISbonusTxt;
        private System.Windows.Forms.RichTextBox CHAbonusTxt;
        private System.Windows.Forms.PictureBox playerIcon;
        private System.Windows.Forms.Label backgroundTb;
        private System.Windows.Forms.TextBox backgroundTb1;
        private System.Windows.Forms.Label spellbookLbl;
        private System.Windows.Forms.Label WeaponsLbl;
        private System.Windows.Forms.Label classFeaturesLbl;
        private System.Windows.Forms.Label statsLbl;
        private System.Windows.Forms.Label cantripLbl;
        private System.Windows.Forms.Label Armours;
        private System.Windows.Forms.CheckedListBox ArmCheckbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox InventoryCheckbox;
        private System.Windows.Forms.CheckedListBox CantripList;
        private System.Windows.Forms.Button ProgressBarBtn;
        private System.Windows.Forms.Label cantripsLbl;
        private System.Windows.Forms.Label cantripLblCount;
        private System.Windows.Forms.Label spellbookLblCount;
        private System.Windows.Forms.Button RanNameBtn;
        private System.Windows.Forms.Label randomNameLbl;
    }
}


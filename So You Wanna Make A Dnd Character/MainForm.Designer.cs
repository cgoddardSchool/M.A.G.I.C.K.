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
            ((System.ComponentModel.ISupportInitialize)(this.LevelPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STRstats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEXStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CONStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SMRTStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WISstats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHAStats)).BeginInit();
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
            this.ClassDropBox.Location = new System.Drawing.Point(12, 167);
            this.ClassDropBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassDropBox.Name = "ClassDropBox";
            this.ClassDropBox.Size = new System.Drawing.Size(193, 24);
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
            this.RaceDropBox.Location = new System.Drawing.Point(12, 250);
            this.RaceDropBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RaceDropBox.Name = "RaceDropBox";
            this.RaceDropBox.Size = new System.Drawing.Size(193, 24);
            this.RaceDropBox.TabIndex = 0;
            this.RaceDropBox.SelectedIndexChanged += new System.EventHandler(this.RaceDropBox_SelectedIndexChanged);
            // 
            // RaceLabel
            // 
            this.RaceLabel.AutoSize = true;
            this.RaceLabel.Location = new System.Drawing.Point(12, 231);
            this.RaceLabel.Name = "RaceLabel";
            this.RaceLabel.Size = new System.Drawing.Size(40, 16);
            this.RaceLabel.TabIndex = 2;
            this.RaceLabel.Text = "Race";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(12, 149);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(41, 16);
            this.ClassLabel.TabIndex = 3;
            this.ClassLabel.Text = "Class";
            // 
            // FirstNameTxt
            // 
            this.FirstNameTxt.Location = new System.Drawing.Point(11, 34);
            this.FirstNameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FirstNameTxt.Name = "FirstNameTxt";
            this.FirstNameTxt.Size = new System.Drawing.Size(100, 22);
            this.FirstNameTxt.TabIndex = 4;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(11, 16);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(72, 16);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "First Name";
            // 
            // EquipmentCheckBox
            // 
            this.EquipmentCheckBox.FormattingEnabled = true;
            this.EquipmentCheckBox.Location = new System.Drawing.Point(15, 343);
            this.EquipmentCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EquipmentCheckBox.Name = "EquipmentCheckBox";
            this.EquipmentCheckBox.Size = new System.Drawing.Size(231, 276);
            this.EquipmentCheckBox.TabIndex = 6;
            // 
            // SpellCheckBox
            // 
            this.SpellCheckBox.FormattingEnabled = true;
            this.SpellCheckBox.Location = new System.Drawing.Point(277, 343);
            this.SpellCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SpellCheckBox.Name = "SpellCheckBox";
            this.SpellCheckBox.Size = new System.Drawing.Size(259, 276);
            this.SpellCheckBox.TabIndex = 7;
            // 
            // FeatCheckBox
            // 
            this.FeatCheckBox.FormattingEnabled = true;
            this.FeatCheckBox.Location = new System.Drawing.Point(277, 231);
            this.FeatCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FeatCheckBox.Name = "FeatCheckBox";
            this.FeatCheckBox.Size = new System.Drawing.Size(259, 72);
            this.FeatCheckBox.TabIndex = 8;
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(728, 613);
            this.runBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(161, 23);
            this.runBtn.TabIndex = 9;
            this.runBtn.Text = "Click Me when finished";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // STRlabel
            // 
            this.STRlabel.AutoSize = true;
            this.STRlabel.Location = new System.Drawing.Point(733, 29);
            this.STRlabel.Name = "STRlabel";
            this.STRlabel.Size = new System.Drawing.Size(35, 16);
            this.STRlabel.TabIndex = 16;
            this.STRlabel.Text = "STR";
            // 
            // CHALabel
            // 
            this.CHALabel.AutoSize = true;
            this.CHALabel.Location = new System.Drawing.Point(733, 462);
            this.CHALabel.Name = "CHALabel";
            this.CHALabel.Size = new System.Drawing.Size(35, 16);
            this.CHALabel.TabIndex = 17;
            this.CHALabel.Text = "CHA";
            // 
            // WISLabel
            // 
            this.WISLabel.AutoSize = true;
            this.WISLabel.Location = new System.Drawing.Point(733, 372);
            this.WISLabel.Name = "WISLabel";
            this.WISLabel.Size = new System.Drawing.Size(32, 16);
            this.WISLabel.TabIndex = 18;
            this.WISLabel.Text = "WIS";
            // 
            // SMRTlabel
            // 
            this.SMRTlabel.AutoSize = true;
            this.SMRTlabel.Location = new System.Drawing.Point(733, 283);
            this.SMRTlabel.Name = "SMRTlabel";
            this.SMRTlabel.Size = new System.Drawing.Size(29, 16);
            this.SMRTlabel.TabIndex = 19;
            this.SMRTlabel.Text = "INT";
            // 
            // CONLabel
            // 
            this.CONLabel.AutoSize = true;
            this.CONLabel.Location = new System.Drawing.Point(733, 201);
            this.CONLabel.Name = "CONLabel";
            this.CONLabel.Size = new System.Drawing.Size(36, 16);
            this.CONLabel.TabIndex = 20;
            this.CONLabel.Text = "CON";
            // 
            // DEXlabel
            // 
            this.DEXlabel.AutoSize = true;
            this.DEXlabel.Location = new System.Drawing.Point(733, 118);
            this.DEXlabel.Name = "DEXlabel";
            this.DEXlabel.Size = new System.Drawing.Size(34, 16);
            this.DEXlabel.TabIndex = 21;
            this.DEXlabel.Text = "DEX";
            // 
            // NameSLabel
            // 
            this.NameSLabel.AutoSize = true;
            this.NameSLabel.Location = new System.Drawing.Point(129, 16);
            this.NameSLabel.Name = "NameSLabel";
            this.NameSLabel.Size = new System.Drawing.Size(72, 16);
            this.NameSLabel.TabIndex = 23;
            this.NameSLabel.Text = "Last Name";
            // 
            // SecondNameTxt
            // 
            this.SecondNameTxt.Location = new System.Drawing.Point(129, 34);
            this.SecondNameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SecondNameTxt.Name = "SecondNameTxt";
            this.SecondNameTxt.Size = new System.Drawing.Size(131, 22);
            this.SecondNameTxt.TabIndex = 22;
            // 
            // LevelPicker
            // 
            this.LevelPicker.Location = new System.Drawing.Point(313, 62);
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
            this.LevelPicker.Size = new System.Drawing.Size(40, 22);
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
            this.LevelLabel.Location = new System.Drawing.Point(313, 39);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(40, 16);
            this.LevelLabel.TabIndex = 25;
            this.LevelLabel.Text = "Level";
            // 
            // STRCheck
            // 
            this.STRCheck.FormattingEnabled = true;
            this.STRCheck.Location = new System.Drawing.Point(858, 48);
            this.STRCheck.Name = "STRCheck";
            this.STRCheck.Size = new System.Drawing.Size(228, 55);
            this.STRCheck.TabIndex = 26;
            // 
            // DEXCheck
            // 
            this.DEXCheck.FormattingEnabled = true;
            this.DEXCheck.Location = new System.Drawing.Point(858, 134);
            this.DEXCheck.Name = "DEXCheck";
            this.DEXCheck.Size = new System.Drawing.Size(228, 55);
            this.DEXCheck.TabIndex = 27;
            // 
            // CONCheck
            // 
            this.CONCheck.FormattingEnabled = true;
            this.CONCheck.Location = new System.Drawing.Point(858, 216);
            this.CONCheck.Name = "CONCheck";
            this.CONCheck.Size = new System.Drawing.Size(228, 55);
            this.CONCheck.TabIndex = 28;
            // 
            // SMRTCheck
            // 
            this.SMRTCheck.FormattingEnabled = true;
            this.SMRTCheck.Location = new System.Drawing.Point(858, 302);
            this.SMRTCheck.Name = "SMRTCheck";
            this.SMRTCheck.Size = new System.Drawing.Size(228, 55);
            this.SMRTCheck.TabIndex = 29;
            // 
            // WISCheck
            // 
            this.WISCheck.FormattingEnabled = true;
            this.WISCheck.Location = new System.Drawing.Point(858, 392);
            this.WISCheck.Name = "WISCheck";
            this.WISCheck.Size = new System.Drawing.Size(228, 55);
            this.WISCheck.TabIndex = 30;
            // 
            // CHACheck
            // 
            this.CHACheck.FormattingEnabled = true;
            this.CHACheck.Location = new System.Drawing.Point(858, 483);
            this.CHACheck.Name = "CHACheck";
            this.CHACheck.Size = new System.Drawing.Size(228, 55);
            this.CHACheck.TabIndex = 31;
            // 
            // StatRoll
            // 
            this.StatRoll.Location = new System.Drawing.Point(446, 80);
            this.StatRoll.Name = "StatRoll";
            this.StatRoll.Size = new System.Drawing.Size(100, 23);
            this.StatRoll.TabIndex = 32;
            this.StatRoll.Text = "Roll Stats";
            this.StatRoll.UseVisualStyleBackColor = true;
            this.StatRoll.Click += new System.EventHandler(this.StatRoll_Click);
            // 
            // STRstats
            // 
            this.STRstats.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STRstats.Location = new System.Drawing.Point(718, 54);
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
            this.STRstats.Size = new System.Drawing.Size(62, 32);
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
            this.DEXStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEXStats.Location = new System.Drawing.Point(718, 149);
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
            this.DEXStats.Size = new System.Drawing.Size(62, 32);
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
            this.CONStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONStats.Location = new System.Drawing.Point(718, 239);
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
            this.CONStats.Size = new System.Drawing.Size(62, 32);
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
            this.SMRTStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMRTStats.Location = new System.Drawing.Point(718, 311);
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
            this.SMRTStats.Size = new System.Drawing.Size(62, 32);
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
            this.WISstats.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WISstats.Location = new System.Drawing.Point(718, 406);
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
            this.WISstats.Size = new System.Drawing.Size(62, 32);
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
            this.CHAStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHAStats.Location = new System.Drawing.Point(718, 495);
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
            this.CHAStats.Size = new System.Drawing.Size(62, 32);
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
            this.STRbonusTxt.Location = new System.Drawing.Point(803, 54);
            this.STRbonusTxt.Name = "STRbonusTxt";
            this.STRbonusTxt.ReadOnly = true;
            this.STRbonusTxt.Size = new System.Drawing.Size(49, 43);
            this.STRbonusTxt.TabIndex = 41;
            this.STRbonusTxt.Text = "-2";
            // 
            // DEXbonusTxt
            // 
            this.DEXbonusTxt.Location = new System.Drawing.Point(803, 146);
            this.DEXbonusTxt.Name = "DEXbonusTxt";
            this.DEXbonusTxt.ReadOnly = true;
            this.DEXbonusTxt.Size = new System.Drawing.Size(49, 43);
            this.DEXbonusTxt.TabIndex = 42;
            this.DEXbonusTxt.Text = "-2";
            // 
            // CONbonusTxt
            // 
            this.CONbonusTxt.Location = new System.Drawing.Point(803, 228);
            this.CONbonusTxt.Name = "CONbonusTxt";
            this.CONbonusTxt.ReadOnly = true;
            this.CONbonusTxt.Size = new System.Drawing.Size(49, 43);
            this.CONbonusTxt.TabIndex = 43;
            this.CONbonusTxt.Text = "-2";
            // 
            // SMRTbonusTxt
            // 
            this.SMRTbonusTxt.Location = new System.Drawing.Point(803, 311);
            this.SMRTbonusTxt.Name = "SMRTbonusTxt";
            this.SMRTbonusTxt.ReadOnly = true;
            this.SMRTbonusTxt.Size = new System.Drawing.Size(49, 43);
            this.SMRTbonusTxt.TabIndex = 44;
            this.SMRTbonusTxt.Text = "-2";
            // 
            // WISbonusTxt
            // 
            this.WISbonusTxt.Location = new System.Drawing.Point(803, 404);
            this.WISbonusTxt.Name = "WISbonusTxt";
            this.WISbonusTxt.ReadOnly = true;
            this.WISbonusTxt.Size = new System.Drawing.Size(49, 43);
            this.WISbonusTxt.TabIndex = 45;
            this.WISbonusTxt.Text = "-2";
            // 
            // CHAbonusTxt
            // 
            this.CHAbonusTxt.Location = new System.Drawing.Point(803, 495);
            this.CHAbonusTxt.Name = "CHAbonusTxt";
            this.CHAbonusTxt.ReadOnly = true;
            this.CHAbonusTxt.Size = new System.Drawing.Size(49, 43);
            this.CHAbonusTxt.TabIndex = 46;
            this.CHAbonusTxt.Text = "-2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 669);
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
    }
}


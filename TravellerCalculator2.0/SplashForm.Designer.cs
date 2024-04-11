namespace TravellerCalculator
{
    partial class SplashForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            namelabel = new Label();
            mainTabControl = new TabControl();
            welcome = new TabPage();
            entry = new TabPage();
            exitButton = new Button();
            clearButton = new Button();
            generateButton = new Button();
            destinationPlanetGroupBox = new GroupBox();
            destinationPopBox = new ComboBox();
            label2 = new Label();
            destinationRedCheck = new CheckBox();
            destinationAmberCheck = new CheckBox();
            destinationStarportBox = new ComboBox();
            destinationStarportLabel = new Label();
            destinationTechBox = new ComboBox();
            destinationTechLabel = new Label();
            characterGroupBox = new GroupBox();
            carouseBonus = new TextBox();
            carouseBonusLabel = new Label();
            carouseName = new TextBox();
            carouseLabel = new Label();
            streetwiseBonus = new TextBox();
            streetwiseBonusLabel = new Label();
            streetwiseName = new TextBox();
            streetwiseLabel = new Label();
            brokerBonus = new TextBox();
            brokerbonusLabel = new Label();
            brokerName = new TextBox();
            brokerLabel = new Label();
            sourcePlanetGroupBox = new GroupBox();
            sourcePopBox = new ComboBox();
            sourcePopLabel = new Label();
            parsecsBox = new TextBox();
            parsecsLabel = new Label();
            sourceRedCheck = new CheckBox();
            sourceAmberCheck = new CheckBox();
            sourceStarportBox = new ComboBox();
            sourceStarportLabel = new Label();
            sourceTechBox = new ComboBox();
            sourceTechLabel = new Label();
            results = new TabPage();
            mainTabControl.SuspendLayout();
            welcome.SuspendLayout();
            entry.SuspendLayout();
            destinationPlanetGroupBox.SuspendLayout();
            characterGroupBox.SuspendLayout();
            sourcePlanetGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Location = new Point(240, 86);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(113, 45);
            namelabel.TabIndex = 0;
            namelabel.Text = "By Johnny Rinaldo\r\n\r\nKo-fi.com/bizentine\r\n";
            // 
            // mainTabControl
            // 
            mainTabControl.Appearance = TabAppearance.Buttons;
            mainTabControl.Controls.Add(welcome);
            mainTabControl.Controls.Add(entry);
            mainTabControl.Controls.Add(results);
            mainTabControl.Location = new Point(12, 12);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(621, 257);
            mainTabControl.TabIndex = 2;
            // 
            // welcome
            // 
            welcome.Controls.Add(namelabel);
            welcome.Location = new Point(4, 27);
            welcome.Name = "welcome";
            welcome.Padding = new Padding(3);
            welcome.Size = new Size(613, 226);
            welcome.TabIndex = 0;
            welcome.Text = "Welcome!";
            welcome.UseVisualStyleBackColor = true;
            // 
            // entry
            // 
            entry.Controls.Add(exitButton);
            entry.Controls.Add(clearButton);
            entry.Controls.Add(generateButton);
            entry.Controls.Add(destinationPlanetGroupBox);
            entry.Controls.Add(characterGroupBox);
            entry.Controls.Add(sourcePlanetGroupBox);
            entry.Location = new Point(4, 27);
            entry.Name = "entry";
            entry.Padding = new Padding(3);
            entry.Size = new Size(613, 226);
            entry.TabIndex = 1;
            entry.Text = "Entry";
            entry.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(500, 196);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(108, 23);
            exitButton.TabIndex = 11;
            exitButton.Text = "&Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(388, 196);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(106, 23);
            clearButton.TabIndex = 10;
            clearButton.Text = "&Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(197, 163);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(185, 56);
            generateButton.TabIndex = 9;
            generateButton.Text = "&Generate!";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // destinationPlanetGroupBox
            // 
            destinationPlanetGroupBox.Controls.Add(destinationPopBox);
            destinationPlanetGroupBox.Controls.Add(label2);
            destinationPlanetGroupBox.Controls.Add(destinationRedCheck);
            destinationPlanetGroupBox.Controls.Add(destinationAmberCheck);
            destinationPlanetGroupBox.Controls.Add(destinationStarportBox);
            destinationPlanetGroupBox.Controls.Add(destinationStarportLabel);
            destinationPlanetGroupBox.Controls.Add(destinationTechBox);
            destinationPlanetGroupBox.Controls.Add(destinationTechLabel);
            destinationPlanetGroupBox.Location = new Point(197, 6);
            destinationPlanetGroupBox.Name = "destinationPlanetGroupBox";
            destinationPlanetGroupBox.Size = new Size(185, 151);
            destinationPlanetGroupBox.TabIndex = 8;
            destinationPlanetGroupBox.TabStop = false;
            destinationPlanetGroupBox.Text = "Planet (Destination)";
            // 
            // destinationPopBox
            // 
            destinationPopBox.FormattingEnabled = true;
            destinationPopBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C" });
            destinationPopBox.Location = new Point(73, 83);
            destinationPopBox.Name = "destinationPopBox";
            destinationPopBox.Size = new Size(94, 23);
            destinationPopBox.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 86);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 12;
            label2.Text = "Population:";
            // 
            // destinationRedCheck
            // 
            destinationRedCheck.AutoSize = true;
            destinationRedCheck.Location = new Point(73, 132);
            destinationRedCheck.Name = "destinationRedCheck";
            destinationRedCheck.Size = new Size(81, 19);
            destinationRedCheck.TabIndex = 7;
            destinationRedCheck.Text = "Red Zone?";
            destinationRedCheck.UseVisualStyleBackColor = true;
            // 
            // destinationAmberCheck
            // 
            destinationAmberCheck.AutoSize = true;
            destinationAmberCheck.Location = new Point(73, 112);
            destinationAmberCheck.Name = "destinationAmberCheck";
            destinationAmberCheck.Size = new Size(97, 19);
            destinationAmberCheck.TabIndex = 6;
            destinationAmberCheck.Text = "Amber Zone?";
            destinationAmberCheck.UseVisualStyleBackColor = true;
            // 
            // destinationStarportBox
            // 
            destinationStarportBox.FormattingEnabled = true;
            destinationStarportBox.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "X" });
            destinationStarportBox.Location = new Point(73, 54);
            destinationStarportBox.Name = "destinationStarportBox";
            destinationStarportBox.Size = new Size(94, 23);
            destinationStarportBox.TabIndex = 3;
            // 
            // destinationStarportLabel
            // 
            destinationStarportLabel.AutoSize = true;
            destinationStarportLabel.Location = new Point(18, 57);
            destinationStarportLabel.Name = "destinationStarportLabel";
            destinationStarportLabel.Size = new Size(52, 15);
            destinationStarportLabel.TabIndex = 2;
            destinationStarportLabel.Text = "Starport:";
            // 
            // destinationTechBox
            // 
            destinationTechBox.FormattingEnabled = true;
            destinationTechBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "X" });
            destinationTechBox.Location = new Point(73, 25);
            destinationTechBox.Name = "destinationTechBox";
            destinationTechBox.Size = new Size(94, 23);
            destinationTechBox.TabIndex = 1;
            // 
            // destinationTechLabel
            // 
            destinationTechLabel.AutoSize = true;
            destinationTechLabel.Location = new Point(6, 28);
            destinationTechLabel.Name = "destinationTechLabel";
            destinationTechLabel.Size = new Size(64, 15);
            destinationTechLabel.TabIndex = 0;
            destinationTechLabel.Text = "Tech Level:";
            // 
            // characterGroupBox
            // 
            characterGroupBox.Controls.Add(carouseBonus);
            characterGroupBox.Controls.Add(carouseBonusLabel);
            characterGroupBox.Controls.Add(carouseName);
            characterGroupBox.Controls.Add(carouseLabel);
            characterGroupBox.Controls.Add(streetwiseBonus);
            characterGroupBox.Controls.Add(streetwiseBonusLabel);
            characterGroupBox.Controls.Add(streetwiseName);
            characterGroupBox.Controls.Add(streetwiseLabel);
            characterGroupBox.Controls.Add(brokerBonus);
            characterGroupBox.Controls.Add(brokerbonusLabel);
            characterGroupBox.Controls.Add(brokerName);
            characterGroupBox.Controls.Add(brokerLabel);
            characterGroupBox.Location = new Point(388, 6);
            characterGroupBox.Name = "characterGroupBox";
            characterGroupBox.Size = new Size(220, 184);
            characterGroupBox.TabIndex = 7;
            characterGroupBox.TabStop = false;
            characterGroupBox.Text = "Characters";
            // 
            // carouseBonus
            // 
            carouseBonus.Location = new Point(161, 150);
            carouseBonus.Name = "carouseBonus";
            carouseBonus.Size = new Size(44, 23);
            carouseBonus.TabIndex = 11;
            // 
            // carouseBonusLabel
            // 
            carouseBonusLabel.AutoSize = true;
            carouseBonusLabel.Location = new Point(112, 153);
            carouseBonusLabel.Name = "carouseBonusLabel";
            carouseBonusLabel.Size = new Size(43, 15);
            carouseBonusLabel.TabIndex = 10;
            carouseBonusLabel.Text = "Bonus:";
            // 
            // carouseName
            // 
            carouseName.Location = new Point(6, 150);
            carouseName.Name = "carouseName";
            carouseName.Size = new Size(100, 23);
            carouseName.TabIndex = 9;
            carouseName.Text = "Name";
            // 
            // carouseLabel
            // 
            carouseLabel.AutoSize = true;
            carouseLabel.Location = new Point(6, 132);
            carouseLabel.Name = "carouseLabel";
            carouseLabel.Size = new Size(53, 15);
            carouseLabel.TabIndex = 8;
            carouseLabel.Text = "Carouse:";
            // 
            // streetwiseBonus
            // 
            streetwiseBonus.Location = new Point(161, 93);
            streetwiseBonus.Name = "streetwiseBonus";
            streetwiseBonus.Size = new Size(44, 23);
            streetwiseBonus.TabIndex = 7;
            // 
            // streetwiseBonusLabel
            // 
            streetwiseBonusLabel.AutoSize = true;
            streetwiseBonusLabel.Location = new Point(112, 96);
            streetwiseBonusLabel.Name = "streetwiseBonusLabel";
            streetwiseBonusLabel.Size = new Size(43, 15);
            streetwiseBonusLabel.TabIndex = 6;
            streetwiseBonusLabel.Text = "Bonus:";
            // 
            // streetwiseName
            // 
            streetwiseName.Location = new Point(6, 93);
            streetwiseName.Name = "streetwiseName";
            streetwiseName.Size = new Size(100, 23);
            streetwiseName.TabIndex = 5;
            streetwiseName.Text = "Name";
            // 
            // streetwiseLabel
            // 
            streetwiseLabel.AutoSize = true;
            streetwiseLabel.Location = new Point(6, 75);
            streetwiseLabel.Name = "streetwiseLabel";
            streetwiseLabel.Size = new Size(63, 15);
            streetwiseLabel.TabIndex = 4;
            streetwiseLabel.Text = "Streetwise:";
            // 
            // brokerBonus
            // 
            brokerBonus.Location = new Point(161, 37);
            brokerBonus.Name = "brokerBonus";
            brokerBonus.Size = new Size(44, 23);
            brokerBonus.TabIndex = 3;
            // 
            // brokerbonusLabel
            // 
            brokerbonusLabel.AutoSize = true;
            brokerbonusLabel.Location = new Point(112, 40);
            brokerbonusLabel.Name = "brokerbonusLabel";
            brokerbonusLabel.Size = new Size(43, 15);
            brokerbonusLabel.TabIndex = 2;
            brokerbonusLabel.Text = "Bonus:";
            // 
            // brokerName
            // 
            brokerName.Location = new Point(6, 37);
            brokerName.Name = "brokerName";
            brokerName.Size = new Size(100, 23);
            brokerName.TabIndex = 1;
            brokerName.Text = "Name";
            // 
            // brokerLabel
            // 
            brokerLabel.AutoSize = true;
            brokerLabel.Location = new Point(6, 19);
            brokerLabel.Name = "brokerLabel";
            brokerLabel.Size = new Size(44, 15);
            brokerLabel.TabIndex = 0;
            brokerLabel.Text = "Broker:";
            // 
            // sourcePlanetGroupBox
            // 
            sourcePlanetGroupBox.Controls.Add(sourcePopBox);
            sourcePlanetGroupBox.Controls.Add(sourcePopLabel);
            sourcePlanetGroupBox.Controls.Add(parsecsBox);
            sourcePlanetGroupBox.Controls.Add(parsecsLabel);
            sourcePlanetGroupBox.Controls.Add(sourceRedCheck);
            sourcePlanetGroupBox.Controls.Add(sourceAmberCheck);
            sourcePlanetGroupBox.Controls.Add(sourceStarportBox);
            sourcePlanetGroupBox.Controls.Add(sourceStarportLabel);
            sourcePlanetGroupBox.Controls.Add(sourceTechBox);
            sourcePlanetGroupBox.Controls.Add(sourceTechLabel);
            sourcePlanetGroupBox.Location = new Point(6, 6);
            sourcePlanetGroupBox.Name = "sourcePlanetGroupBox";
            sourcePlanetGroupBox.Size = new Size(185, 215);
            sourcePlanetGroupBox.TabIndex = 6;
            sourcePlanetGroupBox.TabStop = false;
            sourcePlanetGroupBox.Text = "Planet (Source)";
            // 
            // sourcePopBox
            // 
            sourcePopBox.FormattingEnabled = true;
            sourcePopBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C" });
            sourcePopBox.Location = new Point(73, 83);
            sourcePopBox.Name = "sourcePopBox";
            sourcePopBox.Size = new Size(94, 23);
            sourcePopBox.TabIndex = 11;
            // 
            // sourcePopLabel
            // 
            sourcePopLabel.AutoSize = true;
            sourcePopLabel.Location = new Point(2, 86);
            sourcePopLabel.Name = "sourcePopLabel";
            sourcePopLabel.Size = new Size(68, 15);
            sourcePopLabel.TabIndex = 10;
            sourcePopLabel.Text = "Population:";
            // 
            // parsecsBox
            // 
            parsecsBox.Location = new Point(77, 175);
            parsecsBox.Name = "parsecsBox";
            parsecsBox.Size = new Size(90, 23);
            parsecsBox.TabIndex = 9;
            // 
            // parsecsLabel
            // 
            parsecsLabel.AutoSize = true;
            parsecsLabel.Location = new Point(6, 154);
            parsecsLabel.Name = "parsecsLabel";
            parsecsLabel.Size = new Size(136, 30);
            parsecsLabel.TabIndex = 8;
            parsecsLabel.Text = "Distance to destination? \r\n(in parsecs)";
            // 
            // sourceRedCheck
            // 
            sourceRedCheck.AutoSize = true;
            sourceRedCheck.Location = new Point(73, 132);
            sourceRedCheck.Name = "sourceRedCheck";
            sourceRedCheck.Size = new Size(81, 19);
            sourceRedCheck.TabIndex = 7;
            sourceRedCheck.Text = "Red Zone?";
            sourceRedCheck.UseVisualStyleBackColor = true;
            // 
            // sourceAmberCheck
            // 
            sourceAmberCheck.AutoSize = true;
            sourceAmberCheck.Location = new Point(73, 112);
            sourceAmberCheck.Name = "sourceAmberCheck";
            sourceAmberCheck.Size = new Size(97, 19);
            sourceAmberCheck.TabIndex = 6;
            sourceAmberCheck.Text = "Amber Zone?";
            sourceAmberCheck.UseVisualStyleBackColor = true;
            // 
            // sourceStarportBox
            // 
            sourceStarportBox.FormattingEnabled = true;
            sourceStarportBox.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "X" });
            sourceStarportBox.Location = new Point(73, 54);
            sourceStarportBox.Name = "sourceStarportBox";
            sourceStarportBox.Size = new Size(94, 23);
            sourceStarportBox.TabIndex = 3;
            // 
            // sourceStarportLabel
            // 
            sourceStarportLabel.AutoSize = true;
            sourceStarportLabel.Location = new Point(18, 57);
            sourceStarportLabel.Name = "sourceStarportLabel";
            sourceStarportLabel.Size = new Size(52, 15);
            sourceStarportLabel.TabIndex = 2;
            sourceStarportLabel.Text = "Starport:";
            // 
            // sourceTechBox
            // 
            sourceTechBox.FormattingEnabled = true;
            sourceTechBox.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "X" });
            sourceTechBox.Location = new Point(73, 25);
            sourceTechBox.Name = "sourceTechBox";
            sourceTechBox.Size = new Size(94, 23);
            sourceTechBox.TabIndex = 1;
            // 
            // sourceTechLabel
            // 
            sourceTechLabel.AutoSize = true;
            sourceTechLabel.Location = new Point(6, 30);
            sourceTechLabel.Name = "sourceTechLabel";
            sourceTechLabel.Size = new Size(64, 15);
            sourceTechLabel.TabIndex = 0;
            sourceTechLabel.Text = "Tech Level:";
            // 
            // results
            // 
            results.Location = new Point(4, 27);
            results.Name = "results";
            results.Size = new Size(613, 226);
            results.TabIndex = 2;
            results.Text = "Results";
            results.UseVisualStyleBackColor = true;
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 274);
            Controls.Add(mainTabControl);
            Name = "SplashForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome!";
            mainTabControl.ResumeLayout(false);
            welcome.ResumeLayout(false);
            welcome.PerformLayout();
            entry.ResumeLayout(false);
            destinationPlanetGroupBox.ResumeLayout(false);
            destinationPlanetGroupBox.PerformLayout();
            characterGroupBox.ResumeLayout(false);
            characterGroupBox.PerformLayout();
            sourcePlanetGroupBox.ResumeLayout(false);
            sourcePlanetGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label namelabel;
        private TabControl mainTabControl;
        private TabPage welcome;
        private TabPage entry;
        private TabPage results;
        private Button exitButton;
        private Button clearButton;
        private Button generateButton;
        private GroupBox destinationPlanetGroupBox;
        private ComboBox destinationPopBox;
        private Label label2;
        private CheckBox destinationRedCheck;
        private CheckBox destinationAmberCheck;
        private ComboBox destinationStarportBox;
        private Label destinationStarportLabel;
        private ComboBox destinationTechBox;
        private Label destinationTechLabel;
        private GroupBox characterGroupBox;
        private TextBox carouseBonus;
        private Label carouseBonusLabel;
        private TextBox carouseName;
        private Label carouseLabel;
        private TextBox streetwiseBonus;
        private Label streetwiseBonusLabel;
        private TextBox streetwiseName;
        private Label streetwiseLabel;
        private TextBox brokerBonus;
        private Label brokerbonusLabel;
        private TextBox brokerName;
        private Label brokerLabel;
        private GroupBox sourcePlanetGroupBox;
        private ComboBox sourcePopBox;
        private Label sourcePopLabel;
        private TextBox parsecsBox;
        private Label parsecsLabel;
        private CheckBox sourceRedCheck;
        private CheckBox sourceAmberCheck;
        private ComboBox sourceStarportBox;
        private Label sourceStarportLabel;
        private ComboBox sourceTechBox;
        private Label sourceTechLabel;
    }
}

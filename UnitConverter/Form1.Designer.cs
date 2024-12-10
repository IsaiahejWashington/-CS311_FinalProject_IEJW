namespace UnitConverter
{
    partial class frmConversionTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConversionTable));
            txtBoxInput = new TextBox();
            grbConversions = new GroupBox();
            rdoOuncesToGrams = new RadioButton();
            rdoGramsToOunces = new RadioButton();
            rdoPoundsToKilograms = new RadioButton();
            rdoKilogramToPounds = new RadioButton();
            rdoFahrenehitToCelcius = new RadioButton();
            rdoCelciusToFahrenheit = new RadioButton();
            rdoMilesToKilometers = new RadioButton();
            rdoKilometersToMiles = new RadioButton();
            rdoFeetToMeters = new RadioButton();
            rdoMeterToFeet = new RadioButton();
            btnConvert = new Button();
            lblResults = new Label();
            richTextBox1 = new RichTextBox();
            grbConversions.SuspendLayout();
            SuspendLayout();
            // 
            // txtBoxInput
            // 
            txtBoxInput.Font = new Font("Bell MT", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBoxInput.Location = new Point(55, 46);
            txtBoxInput.Name = "txtBoxInput";
            txtBoxInput.Size = new Size(125, 24);
            txtBoxInput.TabIndex = 0;
            txtBoxInput.Text = "Input Value";
            // 
            // grbConversions
            // 
            grbConversions.Controls.Add(rdoOuncesToGrams);
            grbConversions.Controls.Add(rdoGramsToOunces);
            grbConversions.Controls.Add(rdoPoundsToKilograms);
            grbConversions.Controls.Add(rdoKilogramToPounds);
            grbConversions.Controls.Add(rdoFahrenehitToCelcius);
            grbConversions.Controls.Add(rdoCelciusToFahrenheit);
            grbConversions.Controls.Add(rdoMilesToKilometers);
            grbConversions.Controls.Add(rdoKilometersToMiles);
            grbConversions.Controls.Add(rdoFeetToMeters);
            grbConversions.Controls.Add(rdoMeterToFeet);
            grbConversions.Font = new Font("Bell MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbConversions.Location = new Point(55, 91);
            grbConversions.Name = "grbConversions";
            grbConversions.Size = new Size(282, 338);
            grbConversions.TabIndex = 1;
            grbConversions.TabStop = false;
            grbConversions.Text = "Conversion Options";
            // 
            // rdoOuncesToGrams
            // 
            rdoOuncesToGrams.AutoSize = true;
            rdoOuncesToGrams.Location = new Point(6, 293);
            rdoOuncesToGrams.Name = "rdoOuncesToGrams";
            rdoOuncesToGrams.Size = new Size(177, 28);
            rdoOuncesToGrams.TabIndex = 10;
            rdoOuncesToGrams.TabStop = true;
            rdoOuncesToGrams.Text = "Ounces to grams";
            rdoOuncesToGrams.UseVisualStyleBackColor = true;
            // 
            // rdoGramsToOunces
            // 
            rdoGramsToOunces.AutoSize = true;
            rdoGramsToOunces.Location = new Point(6, 263);
            rdoGramsToOunces.Name = "rdoGramsToOunces";
            rdoGramsToOunces.Size = new Size(178, 28);
            rdoGramsToOunces.TabIndex = 9;
            rdoGramsToOunces.TabStop = true;
            rdoGramsToOunces.Text = "Grams to ounces";
            rdoGramsToOunces.UseVisualStyleBackColor = true;
            // 
            // rdoPoundsToKilograms
            // 
            rdoPoundsToKilograms.AutoSize = true;
            rdoPoundsToKilograms.Location = new Point(6, 233);
            rdoPoundsToKilograms.Name = "rdoPoundsToKilograms";
            rdoPoundsToKilograms.Size = new Size(212, 28);
            rdoPoundsToKilograms.TabIndex = 8;
            rdoPoundsToKilograms.TabStop = true;
            rdoPoundsToKilograms.Text = "Pounds to kilograms";
            rdoPoundsToKilograms.UseVisualStyleBackColor = true;
            // 
            // rdoKilogramToPounds
            // 
            rdoKilogramToPounds.AutoSize = true;
            rdoKilogramToPounds.Location = new Point(6, 203);
            rdoKilogramToPounds.Name = "rdoKilogramToPounds";
            rdoKilogramToPounds.Size = new Size(205, 28);
            rdoKilogramToPounds.TabIndex = 7;
            rdoKilogramToPounds.TabStop = true;
            rdoKilogramToPounds.Text = "Kilograms to pound";
            rdoKilogramToPounds.UseVisualStyleBackColor = true;
            // 
            // rdoFahrenehitToCelcius
            // 
            rdoFahrenehitToCelcius.AutoSize = true;
            rdoFahrenehitToCelcius.Location = new Point(6, 173);
            rdoFahrenehitToCelcius.Name = "rdoFahrenehitToCelcius";
            rdoFahrenehitToCelcius.Size = new Size(215, 28);
            rdoFahrenehitToCelcius.TabIndex = 6;
            rdoFahrenehitToCelcius.TabStop = true;
            rdoFahrenehitToCelcius.Text = "Fahrenheit to celsius";
            rdoFahrenehitToCelcius.UseVisualStyleBackColor = true;
            // 
            // rdoCelciusToFahrenheit
            // 
            rdoCelciusToFahrenheit.AutoSize = true;
            rdoCelciusToFahrenheit.Location = new Point(6, 143);
            rdoCelciusToFahrenheit.Name = "rdoCelciusToFahrenheit";
            rdoCelciusToFahrenheit.Size = new Size(214, 28);
            rdoCelciusToFahrenheit.TabIndex = 4;
            rdoCelciusToFahrenheit.TabStop = true;
            rdoCelciusToFahrenheit.Text = "Celsius to fahrenheit";
            rdoCelciusToFahrenheit.UseVisualStyleBackColor = true;
            // 
            // rdoMilesToKilometers
            // 
            rdoMilesToKilometers.AutoSize = true;
            rdoMilesToKilometers.Location = new Point(6, 113);
            rdoMilesToKilometers.Name = "rdoMilesToKilometers";
            rdoMilesToKilometers.Size = new Size(203, 28);
            rdoMilesToKilometers.TabIndex = 3;
            rdoMilesToKilometers.TabStop = true;
            rdoMilesToKilometers.Text = "Miles to kilometers";
            rdoMilesToKilometers.UseVisualStyleBackColor = true;
            // 
            // rdoKilometersToMiles
            // 
            rdoKilometersToMiles.AutoSize = true;
            rdoKilometersToMiles.Location = new Point(6, 83);
            rdoKilometersToMiles.Name = "rdoKilometersToMiles";
            rdoKilometersToMiles.Size = new Size(203, 28);
            rdoKilometersToMiles.TabIndex = 2;
            rdoKilometersToMiles.TabStop = true;
            rdoKilometersToMiles.Text = "Kilometers to miles";
            rdoKilometersToMiles.UseVisualStyleBackColor = true;
            // 
            // rdoFeetToMeters
            // 
            rdoFeetToMeters.AutoSize = true;
            rdoFeetToMeters.Location = new Point(6, 53);
            rdoFeetToMeters.Name = "rdoFeetToMeters";
            rdoFeetToMeters.Size = new Size(160, 28);
            rdoFeetToMeters.TabIndex = 1;
            rdoFeetToMeters.TabStop = true;
            rdoFeetToMeters.Text = "Feet to meters";
            rdoFeetToMeters.UseVisualStyleBackColor = true;
            // 
            // rdoMeterToFeet
            // 
            rdoMeterToFeet.AutoSize = true;
            rdoMeterToFeet.Location = new Point(6, 23);
            rdoMeterToFeet.Name = "rdoMeterToFeet";
            rdoMeterToFeet.Size = new Size(158, 28);
            rdoMeterToFeet.TabIndex = 0;
            rdoMeterToFeet.TabStop = true;
            rdoMeterToFeet.Text = "Meters to feet";
            rdoMeterToFeet.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            btnConvert.BackColor = SystemColors.HighlightText;
            btnConvert.Font = new Font("Bell MT", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnConvert.Location = new Point(55, 485);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(211, 58);
            btnConvert.TabIndex = 2;
            btnConvert.Text = "Convert!";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Bell MT", 25.8000011F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblResults.Location = new Point(55, 613);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(176, 52);
            lblResults.TabIndex = 3;
            lblResults.Text = "Results ";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Bell MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(510, 46);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(392, 186);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // frmConversionTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1399, 752);
            Controls.Add(richTextBox1);
            Controls.Add(lblResults);
            Controls.Add(btnConvert);
            Controls.Add(grbConversions);
            Controls.Add(txtBoxInput);
            Name = "frmConversionTable";
            Text = "Conversion Table ";
            grbConversions.ResumeLayout(false);
            grbConversions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxInput;
        private GroupBox grbConversions;
        private RadioButton rdoOuncesToGrams;
        private RadioButton rdoGramsToOunces;
        private RadioButton rdoPoundsToKilograms;
        private RadioButton rdoKilogramToPounds;
        private RadioButton rdoFahrenehitToCelcius;
        private RadioButton rdoCelciusToFahrenheit;
        private RadioButton rdoMilesToKilometers;
        private RadioButton rdoKilometersToMiles;
        private RadioButton rdoFeetToMeters;
        private RadioButton rdoMeterToFeet;
        private Button btnConvert;
        private Label lblResults;
        private RichTextBox richTextBox1;
    }
}

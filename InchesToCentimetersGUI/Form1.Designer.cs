namespace InchesToCentimetersGUI
{
    partial class Form1
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
            Inches = new TextBox();
            Incheslbl = new Label();
            ConvertButton = new Button();
            Result = new Label();
            SuspendLayout();
            // 
            // Inches
            // 
            Inches.Location = new Point(116, 77);
            Inches.Name = "Inches";
            Inches.Size = new Size(100, 23);
            Inches.TabIndex = 0;
            // 
            // Incheslbl
            // 
            Incheslbl.AutoSize = true;
            Incheslbl.Location = new Point(116, 59);
            Incheslbl.Name = "Incheslbl";
            Incheslbl.Size = new Size(71, 15);
            Incheslbl.TabIndex = 1;
            Incheslbl.Text = "Enter Inches";
            // 
            // ConvertButton
            // 
            ConvertButton.Location = new Point(116, 113);
            ConvertButton.Name = "ConvertButton";
            ConvertButton.Size = new Size(150, 25);
            ConvertButton.TabIndex = 2;
            ConvertButton.Text = "Convert to Centimeters";
            ConvertButton.UseVisualStyleBackColor = true;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.ForeColor = Color.Blue;
            Result.Location = new Point(116, 151);
            Result.Name = "Result";
            Result.Size = new Size(0, 15);
            Result.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(Result);
            Controls.Add(ConvertButton);
            Controls.Add(Incheslbl);
            Controls.Add(Inches);
            Name = "Form1";
            Text = "Christine's Inches to Centimeters";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Inches;
        private Label Incheslbl;
        private Button ConvertButton;
        private Label Result;
    }
}

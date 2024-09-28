namespace InchesToCentimetersGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
         
            {
                int inches;
                double centimeters;

                inches = Convert.ToInt32(Inches.Text); 
                centimeters = inches * 2.54;
                Result.Text = inches + " inches is " + centimeters + " cm";
            }
        }

        private void Result_Click(object sender, EventArgs e)
        {

        }
    }
}

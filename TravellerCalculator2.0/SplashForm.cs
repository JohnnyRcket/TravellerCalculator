namespace TravellerCalculator
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            sourceTechBox.Text = null;
            sourceStarportBox.Text = null;
            sourcePopBox.Text = null;
            sourceAmberCheck.Checked = false;
            sourceRedCheck.Checked = false;
            destinationTechBox.Text = null;
            destinationStarportBox.Text = null;
            destinationPopBox.Text = null;
            destinationAmberCheck.Checked = false;
            destinationRedCheck.Checked = false;
            brokerName.Text = "Name";
            brokerBonus.Text = null;
            streetwiseName.Text = "Name";
            streetwiseBonus.Text = null;
            carouseName.Text = "Name";
            carouseBonus.Text = null;
            parsecsBox.Text = null;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {

        }
    }
}

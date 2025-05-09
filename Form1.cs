namespace MovieRecommendationUsingClips
{
    public partial class MovieRecommenderForm : Form
    {

        private CLIPSNET.Environment clipsEnv;

        public MovieRecommenderForm()
        {
            InitializeComponent();
            InitializeCLIPS();
        }

        private void InitializeCLIPS()
        {
            clipsEnv = new CLIPSNET.Environment();

            try
            {
                string clipsFilePath = "C:\\Users\\nour_\\source\\repos\\MovieRecommendationUsingClips\\movieRecommendation.CLP";

                if (System.IO.File.Exists(clipsFilePath))
                {
                    clipsEnv.Load(clipsFilePath);
                    Log("CLIPS rules loaded successfully from: " + clipsFilePath);
                }
                else
                {
                    MessageBox.Show("CLIPS rules file not found: " + clipsFilePath +
                                    "\n\nPlease make sure the file exists in the application directory.",
                                    "Error Loading Rules", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log("Error: CLIPS rules file not found: " + clipsFilePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading CLIPS rules: " + ex.Message,
                                "CLIPS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log("Error initializing CLIPS: " + ex.Message);
            }
        }

        private void GetRecommendation(string genre, string mood, string time)
        {
            try
            {
                clipsEnv.Reset();

                // Assert user preference fact
                string assertCmd = $"(assert (user-preference (genre \"{genre}\") (mood \"{mood}\") (time \"{time}\")))";
                clipsEnv.Eval(assertCmd);

                clipsEnv.Run();

                string recommendation = GetRecommendationFromFacts();

                if (string.IsNullOrEmpty(recommendation))
                {
                    recommendation = "No recommendation found for these preferences.";
                }

                resultTextBox.Text = recommendation;
            }
            catch (Exception ex)
            {
                Log("Error getting recommendation: " + ex.Message);
                MessageBox.Show("Error processing recommendation: " + ex.Message,
                               "CLIPS Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Log(string message)
        {
            // Simple logging function - you can extend this to write to a file if needed
            Console.WriteLine($"[{DateTime.Now}] {message}");
        }

        private void recommendButton_Click(object sender, EventArgs e)
        {
            GetRecommendation(
                genreComboBox.SelectedItem.ToString(),
                moodComboBox.SelectedItem.ToString(),
                timeComboBox.SelectedItem.ToString()
            );
        }
        private string GetRecommendationFromFacts()
        {
            var fact = clipsEnv.FindFact("recommendation");
            return fact?.GetSlotValue("text").ToString()
                   ?? "No recommendation found";
        }
    }
}
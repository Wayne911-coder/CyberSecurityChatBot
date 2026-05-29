namespace CyberSecurityBotGUI
{
    public partial class Form1 : Form
    {
        private ChatBot bot = new ChatBot();
        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTable_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string userInput = txtInput.Text;

            if (string.IsNullOrWhiteSpace(userInput))
            {
                lstChat.Items.Add("Bot: Please type a message before sending.");
                return;
            }

            lstChat.Items.Add("User: " + userInput);

            // 1. SENTIMENT (FIRST CHECK)
            string sentimentResponse = bot.HandleSentiment(userInput);
            if (sentimentResponse != null)
            {
                lstChat.Items.Add("Bot: " + sentimentResponse);

                // OPTIONAL: still give a tip after emotion
                string followUp = bot.GetKeywordResponse(userInput);
                if (followUp != null)
                {
                    lstChat.Items.Add("Bot: " + followUp);

                }

                txtInput.Clear();
                return;
            }

            // 2. NAME MEMORY
            string nameResponse = bot.HandleName(userInput);
            if (nameResponse != null)
            {
                lstChat.Items.Add("Bot: " + nameResponse);
                txtInput.Clear();
                return;
            }

            // 3. INTEREST MEMORY
            string interestResponse = bot.HandleInterest(userInput);
            if (interestResponse != null)
            {
                lstChat.Items.Add("Bot: " + interestResponse);
                txtInput.Clear();
                return;
            }

            // 4. FOLLOW-UP
            string followUpResponse = bot.DetectSentiment(userInput);
            if (followUpResponse != null)
            {
                lstChat.Items.Add("Bot: " + followUpResponse);
                txtInput.Clear();
                return;
            }

            // 5. KEYWORD RESPONSE
            string response = bot.GetKeywordResponse(userInput);

            if (response != null)
            {
                response = bot.Personalise(response);
                lstChat.Items.Add("Bot: " + response);
            }
            else
            {
                lstChat.Items.Add("Bot: I'm not sure I understand. Can you rephrase that?");
            }

            txtInput.Clear();
        }

    }
}

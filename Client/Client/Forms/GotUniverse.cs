using Client.Model;
using Client.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Client.Forms
{
    public partial class GotUniverse : Form
    {
        string searchKey;
        string searchValue;
        string message;
        List<TextBox> textBoxes;
        GameOfThronesCharacter gotCharacter;
        public GotUniverse()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            InitValidationComboBox();
            InitKeyComboBox();
            textBoxes = new List<TextBox>(){ tbFirstName, tbLastName, tbFullName,
                tbTitle, tbFamily, tbImage, tbImageUrl };
        }
        private void InitValidationComboBox()
        {
            cbValidation.Items.Add(Constants.XSD);
            cbValidation.Items.Add(Constants.RNG);
            cbValidation.SelectedIndex = 0;
        }
        private void InitKeyComboBox()
        {
            cbKey.Items.Add(Constants.firstName);
            cbKey.Items.Add(Constants.lastName);
            cbKey.Items.Add(Constants.fullName);
            cbKey.Items.Add(Constants.title);
            cbKey.Items.Add(Constants.family);
            cbKey.SelectedIndex = 0;
        }

        private async void btGetGotContinents_Click(object sender, EventArgs e)
        {
            try
            {
                var body = await ApiRequestUtils.SendGetRequest(Constants.gotContinentsUri);
                var continents = JsonConvert.DeserializeObject<List<GameOfThronesContinent>>(body);
                lbGotContinents.Items.Clear();
                foreach (var continent in continents)
                {
                    lbGotContinents.Items.Add(continent.ToString());

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private void btClearGotContinents_Click(object sender, EventArgs e) => lbGotContinents.Items.Clear();

        private async void btGetGotCharacters_Click(object sender, EventArgs e)
        {
            try
            {
                var body = await ApiRequestUtils.SendGetRequest(Constants.gotCharactersUri);
                var characters = JsonConvert.DeserializeObject<List<GameOfThronesCharacter>>(body);
                lbGotCharacters.Items.Clear();
                foreach (var character in characters)
                {
                    lbGotCharacters.Items.Add(character.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private void btClear_Click(object sender, EventArgs e) => lbGotCharacters.Items.Clear();

        private async void btSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(messageBox.Text))
            {
                message = messageBox.Text;
                chatBox.AppendText("Me: " + message + Environment.NewLine);
                messageBox.Clear();
                try
                {
                    var body = await ApiRequestUtils.SendPostRequest(Constants.gptUri, message);
                    var reply = JsonConvert.DeserializeObject<ChatGPTResponse>(body);
                    chatBox.AppendText("Chat GPT: " + reply.ToString() + Environment.NewLine);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }

        private async void btAddGotCharacter_Click(object sender, EventArgs e)
        {
            if (FormUtils.FormValid(textBoxes))
            {
                gotCharacter = CreateGameOfThronesCharacter();
                byte[] data = SerializationUtils.SerializeObjectToBytes(gotCharacter);
                string validationEndpoint = cbValidation.SelectedItem.ToString() == Constants.XSD
                    ? Constants.postXSDValidationEndpoint
                    : Constants.postRNGValidationEndpoint;

                string acceptHeaderValue = Constants.json;
                try
                {
                    var response = await ApiRequestUtils.SendValidationRequest(data, validationEndpoint, acceptHeaderValue);
                    lbFeedback.Text = ApiRequestUtils.GetValidationResultMessage(response);
                }
                catch (Exception)
                {
                    lbFeedback.Text = Constants.badRequest;
                }
            }
            else
            {
                lbFeedback.Text = Constants.allFieldsRequired;
            }
        }

        private GameOfThronesCharacter CreateGameOfThronesCharacter()
        {
            GameOfThronesCharacter gameOfThronesCharacter = new GameOfThronesCharacter(
                tbFirstName.Text.Trim(), tbLastName.Text.Trim(), tbFullName.Text.Trim(),
                tbTitle.Text.Trim(), tbFamily.Text.Trim(), tbImage.Text.Trim(), tbImageUrl.Text.Trim());
            return gameOfThronesCharacter;
        }

        private void btClearTextBoxes_Click(object sender, EventArgs e)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.Text = "";
            }
            lbFeedback.Text = "";
        }
        
        private void btSoapSearch_Click(object sender, EventArgs e)
        {
            lbCharacterSearch.Items.Clear();
            lbCharacterResult.Text = "";
            searchKey = cbKey.SelectedItem.ToString();
            searchValue = tbValue.Text.Trim();
            var client = new BrowseGot.CharacterSearchServiceSoapClient();
            var results = client.SearchCharacters(searchKey, searchValue);
            if (results.Length != 0)
            {
                foreach (var result in results)
                {
                    var gameOfThronesCharacter = new GameOfThronesCharacter(
                        result.Id, result.FirstName, result.LastName, result.FullName,
                        result.Title, result.Family, result.Image, result.ImageUrl);
                    lbCharacterSearch.Items.Add(gameOfThronesCharacter);
                }
            }
            else
            {
                lbCharacterResult.Text = Constants.noMatch;
            }
        }
        
        private void btSearchContinent_Click(object sender, EventArgs e)
        {
            lbContinentSearch.Items.Clear();
            lbContinentResult.Text = "";
            var value = tbContinent.Text.Trim();
            var client = new BrowseGot.CharacterSearchServiceSoapClient();
            var result = client.SearchContinent(value);
            if (result != null)
            {
                var gameOfThronesContinent = new GameOfThronesContinent(result.Id, result.Name);
                lbContinentSearch.Items.Add(gameOfThronesContinent);
            }
            else
            {
                lbContinentResult.Text = Constants.noMatch;
            }
        }

        private async void btValidate_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string solutionDirectoryPath = Directory.GetParent(path).Parent.Parent.Parent.FullName;
            string jarPath = Path.Combine(solutionDirectoryPath, "JaxbValidator.jar");
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "java";
            psi.Arguments = $"-jar \"{jarPath}\"";
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;
            psi.UseShellExecute = false;
            Process process = Process.Start(psi);
            string stdout = await process.StandardOutput.ReadToEndAsync();
            string stderr = await process.StandardError.ReadToEndAsync();
            process.WaitForExit();
            if (stderr == "")
            {
                lbValidation.Text = $"Output: {stdout}";
            }
            else
            {
                lbValidation.Text = $"Not valid";
            }
        }
    }
}

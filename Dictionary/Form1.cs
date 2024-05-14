using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }
        Thread threadWord;
        List<string> list = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("words.txt"))
            {
                string[] data = File.ReadAllLines("words.txt");
                list = data.ToList();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(threadWord != null)
            {
                threadWord.Abort();
                threadWord = null;
                
                threadWord = new Thread(checkingWordsAsync);
                threadWord.Start();
            }
            else
            {
                threadWord = new Thread(checkingWordsAsync);
                threadWord.Start();
            }
        }

        private async void checkingWordsAsync()
        {
            string newString = "";
            using (var client = new HttpClient())
            {
                try
                {
                    //setting the path of API --getting from the line 2 and line 8 of settings page which is saved in ./bin/config.bs

                    var endpoint = new Uri("https://api.dictionaryapi.dev/api/v2/entries/en/" + wordTextBox.Text);

                    //waiting for the API server to response if the server doesn't anwer the the code will 
                    HttpResponseMessage response = await client.GetAsync(endpoint);
                    if (!response.IsSuccessStatusCode)
                        return;
                    var result = client.GetAsync(endpoint).Result;
                    newString = result.Content.ReadAsStringAsync().Result;      //The ERROR is from here... 
                    //deserializing the JSON file into a list
                    List<JsonSTR> deserialized = JsonConvert.DeserializeObject<List<JsonSTR>>(newString);

                    //meaningBox.Text += deserialized.word;
                    //meaningBox.Text += deserialized.phonetic;
                    //meaningBox.Text += deserialized.origin;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (threadWord != null)
            {
                threadWord.Abort();
                threadWord = null;

                threadWord = new Thread(checkingWordsAsync);
                threadWord.Start();
            }
            else
            {
                threadWord = new Thread(checkingWordsAsync);
                threadWord.Start();
            }
        }
    }

}

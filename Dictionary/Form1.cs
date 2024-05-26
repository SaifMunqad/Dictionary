using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using NAudio.Wave;
using System.Net;

namespace Dictionary
{
    public partial class Dictionary : Form
    {
        string audioSoundAddress = null;
        public Dictionary()
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

        }

        private async void checkingWordsAsync()
        {
            string word = wordTextBox.Text;
            string newString = "";
            using (var client = new HttpClient())
            {
                
                //setting the path of API -- Writing 100 words with meaning was hard...

                var endpoint = new Uri("https://api.dictionaryapi.dev/api/v2/entries/en/" + wordTextBox.Text);

                try
                {
                    //waiting for the API server to response if the server doesn't anwer the the code will 
                    HttpResponseMessage response = await client.GetAsync(endpoint);


                }catch (Exception ex)
                {
                    FormChangesThread.NoConnection("NoConnection");
                    return;
                }
                if (word != wordTextBox.Text)
                    return;
                try
                {
                    var result = client.GetAsync(endpoint).Result;
                    newString = result.Content.ReadAsStringAsync().Result;      //The ERROR is from here... 
                                                                                //deserializing the JSON file into a list



                    List<JsonSTR> deserialized = JsonConvert.DeserializeObject<List<JsonSTR>>(newString);

                    string phValues = "";
                    string exampleValues = "";
                    string meaningValues = "";
                    string soAddress = "";
                    string woValues = "";
                    string orValues = "";
                    if(deserialized[0].Origin != null)
                    {
                        orValues = "Origin: " + deserialized[0].Origin;
                    }
                    else
                    {
                        orValues = null;
                    }
                    
                    foreach (PhoneticInfo phoneticInfo in deserialized[0].Phonetics)
                    {
                        string phData = "Phonetics: " + phoneticInfo.Text + "\n";
                        audioSoundAddress = phoneticInfo.Audio;
                        phValues = phData + "\n\r";
                    }
                    foreach (Meaning meaning in deserialized[0].Meanings)
                    {

                        string phData = "Part Of Speech: " + meaning.PartOfSpeech + "\n";
                        woValues = phData + "\n\r";
                    }


                    if (deserialized[0].Meanings != null && deserialized[0].Meanings.Count > 0)
                    {
                        Meaning firstMeaning = deserialized[0].Meanings[0];
                        if (firstMeaning.Definitions != null && firstMeaning.Definitions.Count > 0)
                        {
                            DefinitionInfo firstDefinitionInfo = firstMeaning.Definitions[0];

                            // Getting Data Form DefinitionInfo
                            string definition = firstDefinitionInfo.Definition;
                            string example = firstDefinitionInfo.Example;
                            List<string> synonyms = firstDefinitionInfo.Synonyms;
                            List<string> antonyms = firstDefinitionInfo.Antonyms;
                            meaningValues = "Definition: " + definition + "\n\r";
                            exampleValues = "Example: " + example;

                        }
                    }






                    FormChangesThread.changeText(phValues + "\n\r" + woValues + "\n\r" + orValues + "\n\r" + soAddress + "\n\r" + "\n\r" + meaningValues + "\n\r" + "\n\r" + exampleValues);
                }catch (Exception ex)
                {

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

        private void wordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (threadWord != null)
            {
                threadWord.Abort();
                threadWord = null;
                //Thread.Sleep(2);
                threadWord = new Thread(checkingWordsAsync);
                threadWord.Start();
            }
            else
            {
                threadWord = new Thread(checkingWordsAsync);
                threadWord.Start();
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            using (Stream ms = new MemoryStream())
            {
                if(audioSoundAddress != null)
                {
                    using (Stream stream = WebRequest.Create(audioSoundAddress).GetResponse().GetResponseStream())
                    {
                        byte[] buffer = new byte[32768];
                        int read;
                        while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            ms.Write(buffer, 0, read);
                        }
                    }
                }
                else
                {
                    return;
                }
                

                ms.Position = 0;
                using (WaveStream blockAlignedStream = new BlockAlignReductionStream(
                    WaveFormatConversionStream.CreatePcmStream(new Mp3FileReader(ms))))
                {
                    using (WaveOut waveOut = new WaveOut(WaveCallbackInfo.FunctionCallback()))
                    {
                        waveOut.Init(blockAlignedStream);
                        waveOut.Play();

                        while (waveOut.PlaybackState == PlaybackState.Playing)
                        {
                            System.Threading.Thread.Sleep(100);
                        }
                    }
                }
            }
        }
    }

}

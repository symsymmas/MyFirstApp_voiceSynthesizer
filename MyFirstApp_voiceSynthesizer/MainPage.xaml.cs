using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MyFirstApp_voiceSynthesizer.Resources;
using Windows.Phone.Speech.Recognition;   // For vocal recognition.
using Windows.Phone.Speech.Synthesis;   // For vocal synthesis.

namespace MyFirstApp_voiceSynthesizer
{
    public partial class MainPage : PhoneApplicationPage
    {
        private string toSay = null;

        SpeechRecognizerUI recoWithUI;
        // Constructeur
        public MainPage()
        {
            InitializeComponent();

            // Exemple de code pour la localisation d'ApplicationBar
            //BuildLocalizedApplicationBar();

            debugger.Text = toSay;
        }
        /*//*/
        /// <summary>
        /// When the user clicks on the button "let_sRead", the device reads the content of "text_read".
        /// </summary>
        /// <param name="sender">Don't know!</param>
        /// <param name="e">Don't know!</param>
        private async void let_sSpeak(/*object sender, RoutedEventArgs e*/) 
        {
            if (toSay != null || toSay != "")
            {
                SpeechSynthesizer synth = new SpeechSynthesizer();

                await synth.SpeakTextAsync(toSay);

            }

        }
        //*/
        /// <summary>
        /// When the user clicks on the button "let_sHear", the device hears its environment.
        /// </summary>
        /// <param name="sender">Don't know!</param>
        /// <param name="e">Don't know!</param>
        private async void let_sHear(/*object sender, RoutedEventArgs e*/)
        {
            SpeechRecognitionUIResult recoResult;

            this.recoWithUI = new SpeechRecognizerUI();   // Creates an instance of SpeechRecognizerUI.
            recoResult = await recoWithUI.RecognizeWithUIAsync();   // Starts recognition (loads the dictation grammar by default).

            if (recoResult.RecognitionResult.Text != null)
                toSay = recoResult.RecognitionResult.Text;

        }

        private void go_Click(object sender, RoutedEventArgs e)
        {
            let_sHear();
            //let_sSpeak();
        }

         //*/
    }

}
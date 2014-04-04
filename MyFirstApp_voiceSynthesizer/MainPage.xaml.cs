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
        SpeechRecognizerUI recoWithUI;
        // Constructeur
        public MainPage()
        {
            InitializeComponent();

            // Exemple de code pour la localisation d'ApplicationBar
            //BuildLocalizedApplicationBar();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void let_sRead_Click(object sender, RoutedEventArgs e) 
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();

            await synth.SpeakTextAsync(text_read.Text);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void let_sHear_Click(object sender, RoutedEventArgs e)
        {
            SpeechRecognitionUIResult recoResult;

            this.recoWithUI = new SpeechRecognizerUI();   // Creates an instance of SpeechRecognizerUI.
            recoResult = await recoWithUI.RecognizeWithUIAsync();   // Starts recognition (loads the dictation grammar by default).

            if (recoResult.RecognitionResult.Text != null)
                text_read.Text = recoResult.RecognitionResult.Text;

        }

    }

}
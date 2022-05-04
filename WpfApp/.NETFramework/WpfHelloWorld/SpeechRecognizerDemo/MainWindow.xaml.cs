using System;
using System.Windows;
using System.Speech.Recognition;

namespace SpeechRecognizerDemo {
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window {
        SpeechRecognizer recognizer = new SpeechRecognizer();

        public MainWindow() {
            InitializeComponent();

            GrammarBuilder grammar = new GrammarBuilder();
            grammar.Append(new Choices("red", "green", "blue", "black", "white"));
            grammar.Append(new Choices("on", "off"));
            recognizer.LoadGrammar(new Grammar(grammar));

            recognizer.SpeechDetected += Recognizer_SpeechDetected;
            recognizer.SpeechRecognized += Recognizer_SpeechRecognized;
            recognizer.SpeechRecognitionRejected += Recognizer_SpeechRecognitionRejected;
            recognizer.SpeechHypothesized += Recognizer_SpeechHypothesized;

        }

        private void Recognizer_SpeechDetected(object sender, SpeechDetectedEventArgs e) {
            this.label.Content = "Speech detected.";
        }

        private void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e) {
            this.label.Content = "Speech recognized. You said: " + e.Result.Text;
        }

        private void Recognizer_SpeechRecognitionRejected(object sender, SpeechRecognitionRejectedEventArgs e) {
            this.label.Content = "Speech rejected.";
        }

        private void Recognizer_SpeechHypothesized(object sender, SpeechHypothesizedEventArgs e) {
            this.label.Content = "Speech hypothesized.";
        }

        protected override void OnClosed(EventArgs e) {
            recognizer.Dispose();
        }
    }
}

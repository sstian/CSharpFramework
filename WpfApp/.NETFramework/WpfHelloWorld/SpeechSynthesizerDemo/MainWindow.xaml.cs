using System;
using System.Windows;
using System.Speech.Synthesis;

namespace SpeechSynthesizerDemo {
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void buttonSpeek_Click(object sender, RoutedEventArgs e) {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Speak(this.textWord.Text);
        }

        private void buttonPrompt_Click(object sender, RoutedEventArgs e) {
            PromptBuilder prompt = new PromptBuilder();

            prompt.AppendText("How are you");
            prompt.AppendBreak(TimeSpan.FromSeconds(1));

            prompt.AppendText("How", PromptEmphasis.Reduced);

            PromptStyle style = new PromptStyle();
            style.Rate = PromptRate.ExtraSlow;
            style.Emphasis = PromptEmphasis.Strong;
            prompt.StartStyle(style);
            prompt.AppendText("are");
            prompt.EndStyle();

            prompt.AppendText("you?");

            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Speak(prompt);
        }

        private void buttonPromptAppendText_Click(object sender, RoutedEventArgs e) {
            PromptBuilder prompt = new PromptBuilder();
            prompt.AppendText("The word laser is spelt by");
            prompt.AppendTextWithHint("laser", SayAs.SpellOut);

            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Speak(prompt);
        }
    }
}

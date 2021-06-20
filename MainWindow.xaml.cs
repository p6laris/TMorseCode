using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Media;


namespace TMorseCode
{
    public partial class MainWindow : Window
    {
        SolidColorBrush black = new SolidColorBrush(Color.FromRgb(0,0,0));
        SolidColorBrush white = new SolidColorBrush(Color.FromRgb(100, 100, 100));
        SoundPlayer dotPlayer = new SoundPlayer("dot.wav");
        SoundPlayer dashPlayer = new SoundPlayer("dash.wav");

        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void exitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void aboutClick(object sender, RoutedEventArgs e)
        {
            About p = new About();
            p.ShowDialog();
        }

        private void morseTxt_GotFocus(object sender, RoutedEventArgs e)
        {
            morseTxt.Clear();

        }

        private void convertBtn_Click(object sender, RoutedEventArgs e)
        {
            txtBlock.Text = "";
            List<char> newArray = new List<char>();
            
            if(string.IsNullOrEmpty(morseTxt.Text) || morseTxt.Text == "Type anything....")
            {
                MessageBox.Show("Please type something to convert.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                playBtn.IsEnabled = true;
                copyBtn.IsEnabled = true;
                char[][] morse = MorseConverter.MorseCode();
                for (int i = 0; i < morseTxt.Text.Length; i++)
                {
                    bool isLetterFound = false;
                    if(morseTxt.Text[i] == ' ')
                    {
                        ShowMorse(' ');
                    }
                    else
                    {
                        for (int j = 0; j < morse.Length && !isLetterFound; j++)
                        {
                            for (int k = 0; k < morse[j].Length; k++)
                            {
                                if(morseTxt.Text.ToUpper()[i] == morse[j][k])
                                {
                                    newArray = morse[j].ToList();
                                    newArray.Remove(morse[j][k]);
                                    ShowMorse(newArray.ToArray());
                                    isLetterFound = true;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
        private void ShowMorse(char[] morse)
        {
            string letter = null;
            for (int i = 0; i < morse.Length; i++)
            {
               if(morse[i] == '.')
                {
                    letter += ".";
                }
                else
                {
                    letter += "-";
                }
            }
            txtBlock.Text += letter;
            txtBlock.Text += " ";
        }
        private void ShowMorse(char a)
        {
            txtBlock.Text += " ";
            txtBlock.Text += "/";
            txtBlock.Text += " ";

        }

        private void playBtn_Click(object sender, RoutedEventArgs e)
        {
            rectColor.Background = black;
            
            for (int i = 0; i < txtBlock.Text.Length; i++)
            {

                if (txtBlock.Text[i] == ' ')
                    continue;

                else if (txtBlock.Text[i] == '.')
                {
                    dotPlayer.PlaySync();
                    rectColor.Background = white;
                }
                else
                {
                    dashPlayer.PlaySync();
                    rectColor.Background = white;
                    
                }
            }
        }


        private void txtBlock_Loaded(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBlock.Text))
            {
                playBtn.IsEnabled = false;
                copyBtn.IsEnabled = false;
            }
            else
            {
                playBtn.IsEnabled = true;
                copyBtn.IsEnabled = true;
            }
        }

        private void copyBtn_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(txtBlock.Text);
            MessageBox.Show("Morse code has been saved to clipboard!", "Saved successfully", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}

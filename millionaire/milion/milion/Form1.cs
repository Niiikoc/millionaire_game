using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Collections;
using System.Runtime.InteropServices;
using System.IO;

namespace millionaire
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer main = new SoundPlayer(millionaire.Properties.Resources.intro);
        System.Media.SoundPlayer time = new SoundPlayer(millionaire.Properties.Resources.end_candidate_leaves);
        System.Media.SoundPlayer penhnta = new SoundPlayer(millionaire.Properties.Resources.penhnta_penhnta);
        System.Media.SoundPlayer level_1 = new SoundPlayer(millionaire.Properties.Resources.level_1);
        System.Media.SoundPlayer answer_1 = new SoundPlayer(millionaire.Properties.Resources.correct_answer_1);
        System.Media.SoundPlayer answer_2 = new SoundPlayer(millionaire.Properties.Resources.correct_answer_2);
        System.Media.SoundPlayer answer_3 = new SoundPlayer(millionaire.Properties.Resources.correct_answer_3);
        System.Media.SoundPlayer answer_million = new SoundPlayer(millionaire.Properties.Resources.correct_answer_win1million);
        System.Media.SoundPlayer wrong = new SoundPlayer(millionaire.Properties.Resources.wrong_answer);
        System.Media.SoundPlayer wrong_2 = new SoundPlayer(millionaire.Properties.Resources.transition_after_lvl2);
        System.Media.SoundPlayer wrong_3 = new SoundPlayer(millionaire.Properties.Resources.transition_after_lvl3);
        System.Media.SoundPlayer wrong_4 = new SoundPlayer(millionaire.Properties.Resources.wrong_answer_after_endgame);
        System.Media.SoundPlayer level_2 = new SoundPlayer(millionaire.Properties.Resources.level_2);
        System.Media.SoundPlayer level_3 = new SoundPlayer(millionaire.Properties.Resources.level_3);
        System.Media.SoundPlayer scores_1 = new SoundPlayer(millionaire.Properties.Resources.scores1);
        System.Media.SoundPlayer scores_2 = new SoundPlayer(millionaire.Properties.Resources.scores2);
        System.Media.SoundPlayer scores_3 = new SoundPlayer(millionaire.Properties.Resources.scores3);
        System.Media.SoundPlayer scores_4 = new SoundPlayer(millionaire.Properties.Resources.scores4);
        private int score = 1;
        private int w, z, y, k, a, b, c, d;
        private int randomLineNumber;
        private string[] lines;
        private string first, second, third, fourth;
        private string CorrectAnswer;
        public Form1()
        {
            InitializeComponent();
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            //main.Play();
            //await Task.Delay(32000);
            //panel3.Visible = false;
            nextquestion();
        }
        private void nextquestion()
        {
            level_music();
            button1.Visible = true;
            button1.BackColor = Color.Transparent;
            button2.Visible = true;
            button2.BackColor = Color.Transparent;
            button3.Visible = true;
            button3.BackColor = Color.Transparent;
            button4.Visible = true;
            button4.BackColor = Color.Transparent;
            timer1.Start();
            if (score <= 5)
            {
                // ερωτησεις
                int temp = randomLineNumber;
                button1.Visible = true; button2.Visible = true; button3.Visible = true; button4.Visible = true;
                //lines = System.IO.File.ReadAllLines(@"C:\Users\nikos\Desktop\millionaire\milion\milion\bin\Debug\questions-level-first.txt");
                //lines = System.IO.File.ReadAllLines(Path.Combine(Application.StartupPath, @"\questions-level-first.txt"));
                string filepath = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
                filepath = Path.GetDirectoryName(filepath);
                filepath = filepath.Substring(6);
                lines = System.IO.File.ReadAllLines(filepath + @"\questions-level-first.txt");
                Random r = new Random();
                randomLineNumber = r.Next(0, lines.Length - 1);
                // απαντησεις
                var lines2 = System.IO.File.ReadLines(filepath + @"\answers-level-first.txt");
                if (temp != randomLineNumber)
                {
                    switch (randomLineNumber)
                    {
                        // ερωτησεις πρωτης κατηγοριας
                        case 0:
                            {
                                string a = lines2.Skip(randomLineNumber).First();
                                string b = lines2.Skip(randomLineNumber + 1).First();
                                string c = lines2.Skip(randomLineNumber + 2).First();
                                string d = lines2.Skip(randomLineNumber + 3).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Ελλάδα.";
                                break;
                            }
                        case 1:
                            {

                                string a = lines2.Skip(randomLineNumber + 4).First();
                                string b = lines2.Skip(randomLineNumber + 5).First();
                                string c = lines2.Skip(randomLineNumber + 6).First();
                                string d = lines2.Skip(randomLineNumber + 7).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Λευκάδα.";
                                break;
                            }
                        case 2:
                            {
                                string a = lines2.Skip(randomLineNumber + 8).First();
                                string b = lines2.Skip(randomLineNumber + 9).First();
                                string c = lines2.Skip(randomLineNumber + 10).First();
                                string d = lines2.Skip(randomLineNumber + 11).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Λιέγη.";
                                break;
                            }
                        case 3:
                            {
                                string a = lines2.Skip(randomLineNumber + 12).First();
                                string b = lines2.Skip(randomLineNumber + 13).First();
                                string c = lines2.Skip(randomLineNumber + 14).First();
                                string d = lines2.Skip(randomLineNumber + 15).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Σικελία.";
                                break;
                            }
                        case 4:
                            {
                                string a = lines2.Skip(randomLineNumber + 16).First();
                                string b = lines2.Skip(randomLineNumber + 17).First();
                                string c = lines2.Skip(randomLineNumber + 18).First();
                                string d = lines2.Skip(randomLineNumber + 19).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Ιστιοπλοΐα.";
                                break;
                            }
                        case 5:
                            {
                                string a = lines2.Skip(randomLineNumber + 20).First();
                                string b = lines2.Skip(randomLineNumber + 21).First();
                                string c = lines2.Skip(randomLineNumber + 22).First();
                                string d = lines2.Skip(randomLineNumber + 23).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Σφυριά.";
                                break;
                            }
                        case 6:
                            {
                                string a = lines2.Skip(randomLineNumber + 24).First();
                                string b = lines2.Skip(randomLineNumber + 25).First();
                                string c = lines2.Skip(randomLineNumber + 26).First();
                                string d = lines2.Skip(randomLineNumber + 27).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Ελύτης.";
                                break;
                            }
                        case 7:
                            {
                                string a = lines2.Skip(randomLineNumber + 28).First();
                                string b = lines2.Skip(randomLineNumber + 29).First();
                                string c = lines2.Skip(randomLineNumber + 30).First();
                                string d = lines2.Skip(randomLineNumber + 31).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Valentino Rossi.";
                                break;
                            }
                        case 8:
                            {
                                string a = lines2.Skip(randomLineNumber + 32).First();
                                string b = lines2.Skip(randomLineNumber + 33).First();
                                string c = lines2.Skip(randomLineNumber + 34).First();
                                string d = lines2.Skip(randomLineNumber + 35).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Samuel Morse.";
                                break;
                            }
                        case 9:
                            {
                                string a = lines2.Skip(randomLineNumber + 36).First();
                                string b = lines2.Skip(randomLineNumber + 37).First();
                                string c = lines2.Skip(randomLineNumber + 38).First();
                                string d = lines2.Skip(randomLineNumber + 39).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Αργεντινή.";
                                break;
                            }

                        case 10:
                            {
                                string a = lines2.Skip(randomLineNumber + 40).First();
                                string b = lines2.Skip(randomLineNumber + 41).First();
                                string c = lines2.Skip(randomLineNumber + 42).First();
                                string d = lines2.Skip(randomLineNumber + 43).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Ποσειδώνα.";
                                break;
                            }
                        case 11:
                            {

                                string a = lines2.Skip(randomLineNumber + 44).First();
                                string b = lines2.Skip(randomLineNumber + 45).First();
                                string c = lines2.Skip(randomLineNumber + 46).First();
                                string d = lines2.Skip(randomLineNumber + 47).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "1789.";
                                break;
                            }
                        case 12:
                            {
                                string a = lines2.Skip(randomLineNumber + 48).First();
                                string b = lines2.Skip(randomLineNumber + 49).First();
                                string c = lines2.Skip(randomLineNumber + 50).First();
                                string d = lines2.Skip(randomLineNumber + 51).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Πολεμικός στόλος.";
                                break;
                            }
                        case 13:
                            {
                                string a = lines2.Skip(randomLineNumber + 52).First();
                                string b = lines2.Skip(randomLineNumber + 53).First();
                                string c = lines2.Skip(randomLineNumber + 54).First();
                                string d = lines2.Skip(randomLineNumber + 55).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "1989.";
                                break;
                            }
                        case 14:
                            {
                                string a = lines2.Skip(randomLineNumber + 56).First();
                                string b = lines2.Skip(randomLineNumber + 57).First();
                                string c = lines2.Skip(randomLineNumber + 58).First();
                                string d = lines2.Skip(randomLineNumber + 59).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Με μήλα.";
                                break;
                            }
                        case 15:
                            {
                                string a = lines2.Skip(randomLineNumber + 60).First();
                                string b = lines2.Skip(randomLineNumber + 61).First();
                                string c = lines2.Skip(randomLineNumber + 62).First();
                                string d = lines2.Skip(randomLineNumber + 63).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "1594.";
                                break;
                            }
                        case 16:
                            {
                                string a = lines2.Skip(randomLineNumber + 64).First();
                                string b = lines2.Skip(randomLineNumber + 65).First();
                                string c = lines2.Skip(randomLineNumber + 66).First();
                                string d = lines2.Skip(randomLineNumber + 67).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Ρόδο.";
                                break;
                            }
                        case 17:
                            {
                                string a = lines2.Skip(randomLineNumber + 68).First();
                                string b = lines2.Skip(randomLineNumber + 69).First();
                                string c = lines2.Skip(randomLineNumber + 70).First();
                                string d = lines2.Skip(randomLineNumber + 71).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Βαλέττα.";
                                break;
                            }
                        case 18:
                            {
                                string a = lines2.Skip(randomLineNumber + 72).First();
                                string b = lines2.Skip(randomLineNumber + 73).First();
                                string c = lines2.Skip(randomLineNumber + 74).First();
                                string d = lines2.Skip(randomLineNumber + 75).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Διάχυση.";
                                break;
                            }
                        case 19:
                            {
                                string a = lines2.Skip(randomLineNumber + 76).First();
                                string b = lines2.Skip(randomLineNumber + 77).First();
                                string c = lines2.Skip(randomLineNumber + 78).First();
                                string d = lines2.Skip(randomLineNumber + 79).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Άπειρα κοινά σημεία.";
                                break;
                            }
                    }
                }
                else { nextquestion(); }
            }
            else if (score > 5 && score <= 10)
            {
                int temp = randomLineNumber;
                //lines = System.IO.File.ReadAllLines(@"C:\Users\nikos\Desktop\millionaire\milion\milion\bin\Debug\questions lvl2.txt");
                string filepath = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
                filepath = Path.GetDirectoryName(filepath);
                filepath = filepath.Substring(6);
                lines = System.IO.File.ReadAllLines(filepath + @"\questions lvl2.txt");
                Random r = new Random();
                randomLineNumber = r.Next(0, lines.Length - 1);
                var line = lines[randomLineNumber];
                var lines2 = System.IO.File.ReadLines(filepath + @"\answers lvl2.txt");
                if (temp != randomLineNumber)
                {
                    switch (randomLineNumber)
                    { //ερωτησεις δευτερης κατηγοριας
                        case 0:
                            {
                                string a = lines2.Skip(randomLineNumber).First();
                                string b = lines2.Skip(randomLineNumber + 1).First();
                                string c = lines2.Skip(randomLineNumber + 2).First();
                                string d = lines2.Skip(randomLineNumber + 3).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "1974.";
                                break;
                            }

                        case 1:
                            {
                                string a = lines2.Skip(randomLineNumber + 4).First();
                                string b = lines2.Skip(randomLineNumber + 5).First();
                                string c = lines2.Skip(randomLineNumber + 6).First();
                                string d = lines2.Skip(randomLineNumber + 7).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "7.";
                                break;
                            }
                        case 2:
                            {
                                string a = lines2.Skip(randomLineNumber + 8).First();
                                string b = lines2.Skip(randomLineNumber + 9).First();
                                string c = lines2.Skip(randomLineNumber + 10).First();
                                string d = lines2.Skip(randomLineNumber + 11).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Του Βουκουρεστίου.";
                                break;
                            }
                        case 3:
                            {
                                string a = lines2.Skip(randomLineNumber + 12).First();
                                string b = lines2.Skip(randomLineNumber + 13).First();
                                string c = lines2.Skip(randomLineNumber + 14).First();
                                string d = lines2.Skip(randomLineNumber + 15).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Άνωση.";
                                break;
                            }
                        case 4:
                            {
                                string a = lines2.Skip(randomLineNumber + 16).First();
                                string b = lines2.Skip(randomLineNumber + 17).First();
                                string c = lines2.Skip(randomLineNumber + 18).First();
                                string d = lines2.Skip(randomLineNumber + 19).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Ιωνικού και Δωρικού.";
                                break;
                            }
                        case 5:
                            {
                                string a = lines2.Skip(randomLineNumber + 20).First();
                                string b = lines2.Skip(randomLineNumber + 21).First();
                                string c = lines2.Skip(randomLineNumber + 22).First();
                                string d = lines2.Skip(randomLineNumber + 23).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Κινέζικα.";
                                break;
                            }
                        case 6:
                            {
                                string a = lines2.Skip(randomLineNumber + 24).First();
                                string b = lines2.Skip(randomLineNumber + 25).First();
                                string c = lines2.Skip(randomLineNumber + 26).First();
                                string d = lines2.Skip(randomLineNumber + 27).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Σκοποβολή.";
                                break;
                            }
                        case 7:
                            {
                                string a = lines2.Skip(randomLineNumber + 28).First();
                                string b = lines2.Skip(randomLineNumber + 29).First();
                                string c = lines2.Skip(randomLineNumber + 30).First();
                                string d = lines2.Skip(randomLineNumber + 31).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Ατσάλι.";
                                break;
                            }
                        case 8:
                            {
                                string a = lines2.Skip(randomLineNumber + 32).First();
                                string b = lines2.Skip(randomLineNumber + 33).First();
                                string c = lines2.Skip(randomLineNumber + 34).First();
                                string d = lines2.Skip(randomLineNumber + 35).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Ακουαφόρτε.";
                                break;
                            }
                        case 9:
                            {

                                string a = lines2.Skip(randomLineNumber + 36).First();
                                string b = lines2.Skip(randomLineNumber + 37).First();
                                string c = lines2.Skip(randomLineNumber + 38).First();
                                string d = lines2.Skip(randomLineNumber + 39).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Ήλιο.";
                                break;
                            }

                        case 10:
                            {
                                string a = lines2.Skip(randomLineNumber + 40).First();
                                string b = lines2.Skip(randomLineNumber + 41).First();
                                string c = lines2.Skip(randomLineNumber + 42).First();
                                string d = lines2.Skip(randomLineNumber + 43).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Παραλόγου.";
                                break;
                            }
                        case 11:
                            {
                                string a = lines2.Skip(randomLineNumber + 44).First();
                                string b = lines2.Skip(randomLineNumber + 45).First();
                                string c = lines2.Skip(randomLineNumber + 46).First();
                                string d = lines2.Skip(randomLineNumber + 47).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Λικέρ.";
                                break;
                            }
                        case 12:
                            {
                                string a = lines2.Skip(randomLineNumber + 48).First();
                                string b = lines2.Skip(randomLineNumber + 49).First();
                                string c = lines2.Skip(randomLineNumber + 50).First();
                                string d = lines2.Skip(randomLineNumber + 51).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "24 Μbps.";
                                break;
                            }
                        case 13:
                            {
                                string a = lines2.Skip(randomLineNumber + 52).First();
                                string b = lines2.Skip(randomLineNumber + 53).First();
                                string c = lines2.Skip(randomLineNumber + 54).First();
                                string d = lines2.Skip(randomLineNumber + 55).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Homegroups.";
                                break;
                            }
                        case 14:
                            {
                                string a = lines2.Skip(randomLineNumber + 56).First();
                                string b = lines2.Skip(randomLineNumber + 57).First();
                                string c = lines2.Skip(randomLineNumber + 58).First();
                                string d = lines2.Skip(randomLineNumber + 59).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "1.000.000 pixel.";
                                break;
                            }
                        case 15:
                            {
                                string a = lines2.Skip(randomLineNumber + 60).First();
                                string b = lines2.Skip(randomLineNumber + 61).First();
                                string c = lines2.Skip(randomLineNumber + 62).First();
                                string d = lines2.Skip(randomLineNumber + 63).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Η Λιβαδειά.";
                                break;
                            }
                        case 16:
                            {
                                string a = lines2.Skip(randomLineNumber + 64).First();
                                string b = lines2.Skip(randomLineNumber + 65).First();
                                string c = lines2.Skip(randomLineNumber + 66).First();
                                string d = lines2.Skip(randomLineNumber + 67).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Ηράκλειο Κρήτης.";
                                break;
                            }
                        case 17:
                            {
                                string a = lines2.Skip(randomLineNumber + 68).First();
                                string b = lines2.Skip(randomLineNumber + 69).First();
                                string c = lines2.Skip(randomLineNumber + 70).First();
                                string d = lines2.Skip(randomLineNumber + 71).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Save our souls.";
                                break;
                            }
                        case 18:
                            {
                                string a = lines2.Skip(randomLineNumber + 72).First();
                                string b = lines2.Skip(randomLineNumber + 73).First();
                                string c = lines2.Skip(randomLineNumber + 74).First();
                                string d = lines2.Skip(randomLineNumber + 75).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Άζωτο.";
                                break;
                            }
                        case 19:
                            {
                                string a = lines2.Skip(randomLineNumber + 76).First();
                                string b = lines2.Skip(randomLineNumber + 77).First();
                                string c = lines2.Skip(randomLineNumber + 78).First();
                                string d = lines2.Skip(randomLineNumber + 79).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Ερμής.";
                                break;
                            }

                    }
                }
                else { nextquestion();  }

            }
            else if (score > 10)
            {
                //lines = System.IO.File.ReadAllLines(@"C:\Users\nikos\Desktop\millionaire\milion\milion\bin\Debug\questions lvl3.txt");
                int temp = randomLineNumber;
                string filepath = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
                filepath = Path.GetDirectoryName(filepath);
                filepath = filepath.Substring(6);
                lines = System.IO.File.ReadAllLines(filepath + @"\questions lvl3.txt");
                Random r = new Random();
                randomLineNumber = r.Next(0, lines.Length - 1);
                var line = lines[randomLineNumber];
                line.Remove(randomLineNumber);
                var lines2 = System.IO.File.ReadLines(filepath + @"\answers lvl3.txt");
                if (temp != randomLineNumber)
                {
                    switch (randomLineNumber)
                    { // Ερωτησεις τελευταιας κατηγοριας
                        case 0:
                            {

                                string a = lines2.Skip(randomLineNumber).First();
                                string b = lines2.Skip(randomLineNumber + 1).First();
                                string c = lines2.Skip(randomLineNumber + 2).First();
                                string d = lines2.Skip(randomLineNumber + 3).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Ισλαμιστές.";
                                break;
                            }
                        case 1:
                            {
                                string a = lines2.Skip(randomLineNumber + 4).First();
                                string b = lines2.Skip(randomLineNumber + 5).First();
                                string c = lines2.Skip(randomLineNumber + 6).First();
                                string d = lines2.Skip(randomLineNumber + 7).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Δώσε μου κάπου να σταθώ και θα κινήσω τη Γη.";
                                break;
                            }
                        case 2:
                            {
                                string a = lines2.Skip(randomLineNumber + 8).First();
                                string b = lines2.Skip(randomLineNumber + 9).First();
                                string c = lines2.Skip(randomLineNumber + 10).First();
                                string d = lines2.Skip(randomLineNumber + 11).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Νικόλαος Μάντζαρος. ";
                                break;
                            }
                        case 3:
                            {
                                string a = lines2.Skip(randomLineNumber + 12).First();
                                string b = lines2.Skip(randomLineNumber + 13).First();
                                string c = lines2.Skip(randomLineNumber + 14).First();
                                string d = lines2.Skip(randomLineNumber + 15).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Ισπανός. ";
                                break;
                            }
                        case 4:
                            {
                                string a = lines2.Skip(randomLineNumber + 16).First();
                                string b = lines2.Skip(randomLineNumber + 17).First();
                                string c = lines2.Skip(randomLineNumber + 18).First();
                                string d = lines2.Skip(randomLineNumber + 19).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Εκκλησιαστικό δικαστήριο. ";
                                break;
                            }
                        case 5:
                            {
                                string a = lines2.Skip(randomLineNumber + 20).First();
                                string b = lines2.Skip(randomLineNumber + 21).First();
                                string c = lines2.Skip(randomLineNumber + 22).First();
                                string d = lines2.Skip(randomLineNumber + 23).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Αριστοτέλη.";
                                break;
                            }
                        case 6:
                            {
                                string a = lines2.Skip(randomLineNumber + 24).First();
                                string b = lines2.Skip(randomLineNumber + 25).First();
                                string c = lines2.Skip(randomLineNumber + 26).First();
                                string d = lines2.Skip(randomLineNumber + 27).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Γαλλία.";
                                break;
                            }
                        case 7:
                            {
                                string a = lines2.Skip(randomLineNumber + 28).First();
                                string b = lines2.Skip(randomLineNumber + 29).First();
                                string c = lines2.Skip(randomLineNumber + 30).First();
                                string d = lines2.Skip(randomLineNumber + 31).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Το πταίσμα.";
                                break;
                            }
                        case 8:
                            {
                                string a = lines2.Skip(randomLineNumber + 32).First();
                                string b = lines2.Skip(randomLineNumber + 33).First();
                                string c = lines2.Skip(randomLineNumber + 34).First();
                                string d = lines2.Skip(randomLineNumber + 35).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Χριστόφορος Μαγγελάνος.";
                                break;
                            }
                        case 9:
                            {
                                string a = lines2.Skip(randomLineNumber + 36).First();
                                string b = lines2.Skip(randomLineNumber + 37).First();
                                string c = lines2.Skip(randomLineNumber + 38).First();
                                string d = lines2.Skip(randomLineNumber + 39).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Ηρόδοτος.";

                                break;
                            }

                        case 10:
                            {
                                string a = lines2.Skip(randomLineNumber + 40).First();
                                string b = lines2.Skip(randomLineNumber + 41).First();
                                string c = lines2.Skip(randomLineNumber + 42).First();
                                string d = lines2.Skip(randomLineNumber + 43).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Ειδωλολάτρης.";
                                break;
                            }
                        case 11:
                            {
                                string a = lines2.Skip(randomLineNumber + 44).First();
                                string b = lines2.Skip(randomLineNumber + 45).First();
                                string c = lines2.Skip(randomLineNumber + 46).First();
                                string d = lines2.Skip(randomLineNumber + 47).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Η συνθήκη των παρισίων.";
                                break;
                            }
                        case 12:
                            {
                                string a = lines2.Skip(randomLineNumber + 48).First();
                                string b = lines2.Skip(randomLineNumber + 49).First();
                                string c = lines2.Skip(randomLineNumber + 50).First();
                                string d = lines2.Skip(randomLineNumber + 51).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "με τους κρατούμενους συνείδησης.";
                                break;
                            }
                        case 13:
                            {
                                string a = lines2.Skip(randomLineNumber + 52).First();
                                string b = lines2.Skip(randomLineNumber + 53).First();
                                string c = lines2.Skip(randomLineNumber + 54).First();
                                string d = lines2.Skip(randomLineNumber + 55).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Ρότερνταμ.";
                                break;
                            }
                        case 14:
                            {
                                string a = lines2.Skip(randomLineNumber + 56).First();
                                string b = lines2.Skip(randomLineNumber + 57).First();
                                string c = lines2.Skip(randomLineNumber + 58).First();
                                string d = lines2.Skip(randomLineNumber + 59).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Στην Κίνα.";
                                break;
                            }
                        case 15:
                            {
                                string a = lines2.Skip(randomLineNumber + 60).First();
                                string b = lines2.Skip(randomLineNumber + 61).First();
                                string c = lines2.Skip(randomLineNumber + 62).First();
                                string d = lines2.Skip(randomLineNumber + 63).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Φήμιος.";
                                break;
                            }
                        case 16:
                            {
                                string a = lines2.Skip(randomLineNumber + 64).First();
                                string b = lines2.Skip(randomLineNumber + 65).First();
                                string c = lines2.Skip(randomLineNumber + 66).First();
                                string d = lines2.Skip(randomLineNumber + 67).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Διώριγα του Σουέζ.";
                                break;
                            }
                        case 17:
                            {
                                string a = lines2.Skip(randomLineNumber + 68).First();
                                string b = lines2.Skip(randomLineNumber + 69).First();
                                string c = lines2.Skip(randomLineNumber + 70).First();
                                string d = lines2.Skip(randomLineNumber + 71).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Ιταλίας.";
                                break;
                            }
                        case 18:
                            {
                                string a = lines2.Skip(randomLineNumber + 72).First();
                                string b = lines2.Skip(randomLineNumber + 73).First();
                                string c = lines2.Skip(randomLineNumber + 74).First();
                                string d = lines2.Skip(randomLineNumber + 75).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Άζωτο.";
                                break;
                            }
                        case 19:
                            {
                                string a = lines2.Skip(randomLineNumber + 76).First();
                                string b = lines2.Skip(randomLineNumber + 77).First();
                                string c = lines2.Skip(randomLineNumber + 78).First();
                                string d = lines2.Skip(randomLineNumber + 79).First();
                                first = a; second = b; third = c; fourth = d;
                                tuxaia_seira();
                                CorrectAnswer = "Βαικάλη.";
                                break;
                            }
                    }
                }
                else { nextquestion(); }
            }
        }
        // ρολοι που χρησιμοποιειται για τον χρονο
        private void timer1_Tick(object sender, EventArgs e)
        {
            try {
                circularProgressBar1.Value -= 1;
                circularProgressBar1.Text = circularProgressBar1.Value.ToString();
                if (circularProgressBar1.Value == 0 || circularProgressBar1.Text == "0")
                {
                    time.Play();
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    label1.Visible = false;
                    panel5.Visible = true;
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        // το κουμπι Α
        private async void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == CorrectAnswer)
            { timer1.Stop();
                button1.BackColor = Color.DarkOrange;
                await Task.Delay(300);
                button1.BackColor = Color.Chartreuse;
                await Task.Delay(300);
                button1.BackColor = Color.DarkOrange;
                await Task.Delay(300);
                button1.BackColor = Color.Chartreuse;
                correct_answer();
                await Task.Delay(2400);
                if (score == 15) {
                    label1.Visible = false;
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                }
                score++;
                eikones();
                circularProgressBar1.Text = "30";
                circularProgressBar1.Value = 30;
                if (score <= 15) { nextquestion(); }
            }
            else
            {
                timer1.Stop();
                button1.BackColor = Color.DarkOrange;
                await Task.Delay(300);
                button1.BackColor = Color.Chartreuse;
                await Task.Delay(300);
                button1.BackColor = Color.DarkOrange;
                await Task.Delay(300);
                button1.BackColor = Color.OrangeRed;
                if (button2.Text == CorrectAnswer) { button2.BackColor = Color.Chartreuse; }
                else if (button3.Text == CorrectAnswer) { button3.BackColor = Color.Chartreuse; }
                else if (button4.Text == CorrectAnswer) { button4.BackColor = Color.Chartreuse; }
                wrong_answer();
                await Task.Delay(5000);
                scores();
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                label1.Visible = false;
                await Task.Delay(7000);
                panel5.Visible = true;
            }
        }
        //Το κουμπι Β
        private async void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == CorrectAnswer)
            { timer1.Stop();
                button2.BackColor = Color.DarkOrange;
                await Task.Delay(300);
                button2.BackColor = Color.Chartreuse;
                await Task.Delay(300);
                button2.BackColor = Color.DarkOrange;
                await Task.Delay(300);
                button2.BackColor = Color.Chartreuse;
                correct_answer();
                await Task.Delay(2400);
                if (score == 15)
                {
                    label1.Visible = false;
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                }
                score++;
                eikones();
                circularProgressBar1.Text = "30";
                circularProgressBar1.Value = 30;
                if (score <= 15) { nextquestion(); }

            }
            else
            {
                timer1.Stop();
                button2.BackColor = Color.DarkOrange;
                await Task.Delay(300);
                button2.BackColor = Color.Chartreuse;
                await Task.Delay(300);
                button2.BackColor = Color.DarkOrange;
                await Task.Delay(300);
                button2.BackColor = Color.OrangeRed;
                if (button1.Text == CorrectAnswer) { button1.BackColor = Color.Chartreuse; }
                else if (button3.Text == CorrectAnswer) { button3.BackColor = Color.Chartreuse; }
                else if (button4.Text == CorrectAnswer) { button4.BackColor = Color.Chartreuse; }
                wrong_answer();
                await Task.Delay(5000);
                scores();
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                label1.Visible = false;
                await Task.Delay(7000);
                panel5.Visible = true;
            }
        }
        //Το κουμπι Γ
        private async void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == CorrectAnswer)
            { timer1.Stop();
                button3.BackColor = Color.DarkOrange;
                await Task.Delay(300);
                button3.BackColor = Color.Chartreuse;
                await Task.Delay(300);
                button3.BackColor = Color.DarkOrange;
                await Task.Delay(300);
                button3.BackColor = Color.Chartreuse;
                correct_answer();
                await Task.Delay(2400);
                if (score == 15)
                {
                    label1.Visible = false;
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                }
                score++;
                eikones();
                circularProgressBar1.Text = "30";
                circularProgressBar1.Value = 30;
                if (score <= 15) { nextquestion(); }
            }
            else
            {
                timer1.Stop();
                button3.BackColor = Color.DarkOrange;
                await Task.Delay(300);
                button3.BackColor = Color.Chartreuse;
                await Task.Delay(300);
                button3.BackColor = Color.DarkOrange;
                await Task.Delay(300);
                button3.BackColor = Color.OrangeRed;
                if (button1.Text == CorrectAnswer) { button1.BackColor = Color.Chartreuse; }
                else if (button2.Text == CorrectAnswer) { button2.BackColor = Color.Chartreuse; }
                else if (button4.Text == CorrectAnswer) { button4.BackColor = Color.Chartreuse; }
                wrong_answer();
                await Task.Delay(5000);
                scores();
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                label1.Visible = false;
                await Task.Delay(7000);
                panel5.Visible = true;
            }
        }
        //Το κουμπι Δ
        private async void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == CorrectAnswer)
            { timer1.Stop();
                button4.BackColor = Color.DarkOrange;
                await Task.Delay(300);
                button4.BackColor = Color.Chartreuse;
                await Task.Delay(300);
                button4.BackColor = Color.DarkOrange;
                await Task.Delay(300);
                button4.BackColor = Color.Chartreuse;
                correct_answer();
                await Task.Delay(2400);
                if (score == 15)
                {
                    label1.Visible = false;
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                }
                score++;
                eikones();
                circularProgressBar1.Text = "30";
                circularProgressBar1.Value = 30;
                if (score <= 15) { nextquestion(); }
            }
            else
            {
                timer1.Stop();
                button4.BackColor = Color.DarkOrange;
                await Task.Delay(300);
                button4.BackColor = Color.Chartreuse;
                await Task.Delay(300);
                button4.BackColor = Color.DarkOrange;
                await Task.Delay(300);
                button4.BackColor = Color.OrangeRed;
                if (button1.Text == CorrectAnswer) { button1.BackColor = Color.Chartreuse; }
                else if (button2.Text == CorrectAnswer) { button2.BackColor = Color.Chartreuse; }
                else if (button3.Text == CorrectAnswer) { button3.BackColor = Color.Chartreuse; }
                wrong_answer();
                await Task.Delay(5000);
                scores();
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                label1.Visible = false;
                await Task.Delay(7000);
                panel5.Visible = true;
            }
        }
        // Η βοηθεια του κοινου
        private void button7_Click(object sender, EventArgs e)
        {
           timer1.Stop();
            if (score <= 6)
            {
                int sum = 100;
                Random r = new Random();
                a = r.Next(60, 85);
                sum -= a;
                b = r.Next(0, sum);
                sum -= b;
                c = r.Next(0, sum);
                sum -= c;
                d = sum;
                function_chart();
            }
            else if (score > 6 && score <= 11)
            {
                int sum = 100;
                Random r = new Random();
                a = r.Next(47, 76);
                sum -= a;
                b = r.Next(0, sum);
                sum -= b;
                c = r.Next(0, sum);
                sum -= c;
                d = sum;
                function_chart();
            }
            else if (score > 11 && score <= 14)
            {
                int sum = 100;
                Random r = new Random();
                a = r.Next(36, 63);
                sum -= a;
                b = r.Next(0, sum);
                sum -= b;
                c = r.Next(0, sum);
                sum -= c;
                d = sum;
                function_chart();
            }
            else if (score == 15)
            {
                int sum = 100;
                Random r = new Random();
                a = r.Next(30, 55);
                sum -= a;
                b = r.Next(0, sum);
                sum -= b;
                c = r.Next(0, sum);
                sum -= c;
                d = sum;
                function_chart();
            }
            button7.Enabled = false;
            button7.BackgroundImage = millionaire.Properties.Resources.x_audience;
        }
        // Η βοηθεια 50-50
        private void button6_Click(object sender, EventArgs e)
        {
            penhnta.Play();
            if (CorrectAnswer == button1.Text)
            {
                Random r = new Random();
                string[] epilogh = new string[3];
                string tuxaio;
                epilogh[0] = button2.Text;
                epilogh[1] = button3.Text;
                epilogh[2] = button4.Text;
                for (int y = 0; y < 3; ++y)
                {
                    while (true)
                    {
                        tuxaio = epilogh[r.Next(0, 2)].ToString();
                        for (int i = 0; i <= 2; ++i)
                        {
                            if (tuxaio == button2.Text)
                            { button2.Visible = false; }
                            else if (tuxaio == button3.Text)
                            { button3.Visible = false; }
                            else if (tuxaio == button4.Text)
                            { button4.Visible = false; }
                        }
                        if (button2.Text != button3.Text && button3.Text != button4.Text && button2.Text != button4.Text)
                        { break; }
                    }
                }
            }
            else if (CorrectAnswer == button2.Text)
            {
                Random r = new Random();
                string[] epilogh = new string[3];
                string tuxaio;
                epilogh[0] = button1.Text;
                epilogh[1] = button3.Text;
                epilogh[2] = button4.Text;
                for (int y = 0; y <3; ++y)
                {
                    while (true)
                    {
                        tuxaio = epilogh[r.Next(0, 2)].ToString();
                        for (int i = 0; i <= 2; ++i)
                        {
                            if (tuxaio == button1.Text)
                            { button1.Visible = false; }
                            else if (tuxaio == button3.Text)
                            { button3.Visible = false; }
                            else if (tuxaio == button4.Text)
                            { button4.Visible = false; }
                        }
                        if (button1.Text != button3.Text && button1.Text != button4.Text && button3.Text != button4.Text)
                        { break; }
                    }
                }
            }
            else if (CorrectAnswer == button3.Text)
            {
                Random r = new Random();
                string[] epilogh = new string[3];
                string tuxaio;
                epilogh[0] = button2.Text;
                epilogh[1] = button1.Text;
                epilogh[2] = button4.Text;
                for (int y = 0; y <3; ++y)
                {
                    while (true)
                    {
                        tuxaio = epilogh[r.Next(0, 2)].ToString();
                        for (int i = 0; i <= 2; ++i)
                        {
                            if (tuxaio == button2.Text)
                            { button2.Visible = false; }
                            else if (tuxaio == button1.Text)
                            { button1.Visible = false; }
                            else if (tuxaio == button4.Text)
                            { button4.Visible = false; }
                        }
                        if(button1.Text != button2.Text && button1.Text != button4.Text && button2.Text != button4.Text)
                        { break; }
                    }
                }
            }
            else if (CorrectAnswer == button4.Text)
            {
                Random r = new Random();
                string[] epilogh = new string[3];
                string tuxaio;
                epilogh[0] = button2.Text;
                epilogh[1] = button3.Text;
                epilogh[2] = button1.Text;
                for (int y = 0; y <3; ++y)
                {
                    while (true)
                    {
                        tuxaio = epilogh[r.Next(0, 2)].ToString();
                        for (int i = 0; i <= 2; ++i)
                        {
                            if (tuxaio == button2.Text)
                            { button2.Visible = false; }
                            else if (tuxaio == button3.Text)
                            { button3.Visible = false; }
                            else if (tuxaio == button1.Text)
                            { button1.Visible = false; }
                        }
                        if (button1.Text != button2.Text && button1.Text != button3.Text && button2.Text != button3.Text)
                        {break;}
                    }
                }
            }
            //button6.Enabled = false;
            button6.BackgroundImage = millionaire.Properties.Resources.x_50x50;
        }
        // Η τηλεφωνικη βοηθεια.
        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (score <= 6)
            {
                if (CorrectAnswer == button1.Text) { SoundPlayer phone1 = new SoundPlayer(millionaire.Properties.Resources.A1); phone1.Play(); }
                else if (CorrectAnswer == button2.Text) { SoundPlayer phone2 = new SoundPlayer(millionaire.Properties.Resources.Β1); phone2.Play(); }
                else if (CorrectAnswer == button3.Text) { SoundPlayer phone3 = new SoundPlayer(millionaire.Properties.Resources.Β2); phone3.Play(); }
                else if (CorrectAnswer == button4.Text) { SoundPlayer phone4 = new SoundPlayer(millionaire.Properties.Resources.Γ2); phone4.Play(); }
                timer1.Start();
            }
            else if(score > 6 && score <= 10)
            {
                if (CorrectAnswer == button1.Text) { SoundPlayer phone1 = new SoundPlayer(millionaire.Properties.Resources.Α2); phone1.Play(); }
                else if (CorrectAnswer == button2.Text) { SoundPlayer phone2 = new SoundPlayer(millionaire.Properties.Resources.Β2); phone2.Play(); }
                else if (CorrectAnswer == button3.Text) { SoundPlayer phone3 = new SoundPlayer(millionaire.Properties.Resources.Γ2); phone3.Play(); }
                else if (CorrectAnswer == button4.Text) { SoundPlayer phone4 = new SoundPlayer(millionaire.Properties.Resources.Δ2); phone4.Play(); }
                timer1.Start();
            }
            else if (score > 10)
            {
                if (CorrectAnswer == button3.Text) { SoundPlayer phone1 = new SoundPlayer(millionaire.Properties.Resources.Α3); phone1.Play(); }
                else if (CorrectAnswer == button4.Text) { SoundPlayer phone2 = new SoundPlayer(millionaire.Properties.Resources.Β3); phone2.Play(); }
                else if (CorrectAnswer == button1.Text) { SoundPlayer phone3 = new SoundPlayer(millionaire.Properties.Resources.Γ3); phone3.Play(); }
                else if (CorrectAnswer == button2.Text) { SoundPlayer phone4 = new SoundPlayer(millionaire.Properties.Resources.Δ3); phone4.Play(); }
                timer1.Start();
            }
            button5.Enabled = false;
            button5.BackgroundImage = millionaire.Properties.Resources.x_phone;
        }
        // Το κουμπι Συνέχεια.
        private void button9_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            label1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            timer1.Start();
        }
        // Το κουμπι Επανακκίνηση.
        private void button10_Click(object sender, EventArgs e)
        {
            score = 1;
            panel2.BackgroundImage = millionaire.Properties.Resources._100;
            circularProgressBar1.Text = "30";
            circularProgressBar1.Value = 30;
            nextquestion();
            panel4.Visible = false;
            label1.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button5.Enabled = true;
            button5.BackgroundImage = millionaire.Properties.Resources.phone;
            button6.Enabled = true;
            button6.BackgroundImage = millionaire.Properties.Resources._50x50;
            button7.Enabled = true;
            button7.BackgroundImage = millionaire.Properties.Resources.audience;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            label3.Text = "Γίνεται φόρτωση των ερωτοαπαντήσεων... παρακαλώ περιμένετε.";
            if (progressBar1.Value == 100)
            { timer2.Stop(); }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            score = 1;
            panel2.BackgroundImage = millionaire.Properties.Resources._100;
            circularProgressBar1.Text = "30";
            circularProgressBar1.Value = 30;
            nextquestion();
            panel5.Visible = false;
            label1.Visible = true;
            button5.Enabled = true;
            button5.BackgroundImage = millionaire.Properties.Resources.phone;
            button6.Enabled = true;
            button6.BackgroundImage = millionaire.Properties.Resources._50x50;
            button7.Enabled = true;
            button7.BackgroundImage = millionaire.Properties.Resources.audience;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    // Το κουμπι Έξοδος
    private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Το κουμπι ΜΕΝΟΥ.
        private void button8_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            panel4.Visible = true;
        }
        // Ηχοι για σωστή απαντηση
        public async void correct_answer()
        {
            if (score <= 5)
            {
                answer_1.Play();
            }
            else if (score > 5 && score <= 10)
            {
                answer_2.Play();
            }
            else if (score > 10 && score <= 14)
            {
                answer_3.Play();
            }
            else if (score == 15)
            {
                label4.Visible = true;
                pictureBox1.Visible = true;
                label4.BackColor = Color.White;
                await Task.Delay(300);
                label4.BackColor = Color.Gold;
                await Task.Delay(300);
                label4.BackColor = Color.White;
                await Task.Delay(300);
                label4.BackColor = Color.Gold;
                await Task.Delay(300);
                label4.BackColor = Color.White;
                await Task.Delay(300);
                label4.BackColor = Color.Gold;
                answer_million.Play();
                await  Task.Delay(23000);
                scores_4.Play();
                await Task.Delay(6000);
                Application.Exit();
            }
        }
        //Ηχοι για λαθος απαντηση.
        public void wrong_answer()
        {
            if (score <= 5)
            {
                wrong.Play();
            }
            else if (score > 5 && score <= 10)
            {
                wrong_2.Play();
            }
            else if (score > 10 && score <= 14)
            {
                wrong_3.Play();
            }
            else if (score == 15)
            {

                wrong_4.Play();
            }
        }
        // Ηχοι για το επιπεδο της δυσκολιας.
        public void level_music()
        {
            if (score <= 5)
            {
                level_1.PlayLooping();
            }
            else if (score > 5 && score <= 10)
            {
                level_2.PlayLooping();
            }
            else if (score > 10)
            {
                level_3.PlayLooping();
            }
        }
        // Μπερδευει τις σωστες απαντησεις με τα κουμπια!
        public void tuxaia_seira()
        {
            string[] nums = new string[4];
            nums[0] = first;
            nums[1] = second;
            nums[2] = third;
            nums[3] = fourth;
            Random rand = new Random();
            while (true)
            {
                w = rand.Next(0, 4);
                y = rand.Next(0, 4);
                z = rand.Next(0, 4);
                k = rand.Next(0, 4);
                if (w != y && w != z && w != k && y != z && y != k && k != z)
                { break; }
            }
            button1.Text = nums[w];
            this.label1.Text = lines[randomLineNumber];
            button2.Text = nums[y];
            this.label1.Text = lines[randomLineNumber];
            button3.Text = nums[z];
            this.label1.Text = lines[randomLineNumber];
            button4.Text = nums[k];
            this.label1.Text = lines[randomLineNumber];
        }
        // Ο κωδικας με τα ποσα που ανεβαινουν με τη σωστη απαντηση.
        public void eikones()
        {
            if (score == 2) { panel2.BackgroundImage = millionaire.Properties.Resources._200; }
            else if (score == 3) { panel2.BackgroundImage = millionaire.Properties.Resources._300; }
            else if (score == 4) { panel2.BackgroundImage = millionaire.Properties.Resources._500; }
            else if (score == 5) { panel2.BackgroundImage = millionaire.Properties.Resources._1000; }
            else if (score == 6) { panel2.BackgroundImage = millionaire.Properties.Resources._2000; }
            else if (score == 7) { panel2.BackgroundImage = millionaire.Properties.Resources._4000; }
            else if (score == 8) { panel2.BackgroundImage = millionaire.Properties.Resources._8000; }
            else if (score == 9) { panel2.BackgroundImage = millionaire.Properties.Resources._16000; }
            else if (score == 10) { panel2.BackgroundImage = millionaire.Properties.Resources._32000; }
            else if (score == 11) { panel2.BackgroundImage = millionaire.Properties.Resources._64000; }
            else if (score == 12) { panel2.BackgroundImage = millionaire.Properties.Resources._125000; }
            else if (score == 13) { panel2.BackgroundImage = millionaire.Properties.Resources._250000; }
            else if (score == 14) { panel2.BackgroundImage = millionaire.Properties.Resources._500000; }
            else if (score == 15) { panel2.BackgroundImage = millionaire.Properties.Resources.million; }
        }
        // Ήχος. μετα την λαθος απαντηση. ποσα κερδισε ο παιχτης.
        public void scores()
        {
            if(score < 5) {
                scores_1.Play();
            }
            else if(score >=5 && score <10)
            {
                scores_2.Play();
            }
            else if (score >=10 && score <=14)
            {
                scores_3.Play();
            }
        }
        public async void function_chart()
        {
            chart1.Visible = true;
            if (CorrectAnswer == button1.Text)
            {
                chart1.Series["Απαντησεις"].Points.AddXY("Το Αλφα", a);
                chart1.Series["Απαντησεις"].Points.AddXY("Το Βητα", b);
                chart1.Series["Απαντησεις"].Points.AddXY("Το Γαμα", c);
                chart1.Series["Απαντησεις"].Points.AddXY("Το Δελτα", d);
                SoundPlayer chart_a = new SoundPlayer(millionaire.Properties.Resources.chart_A);
                chart_a.Play();
                await Task.Delay(6000);
                chart1.Visible = false;
                timer1.Start();
            }
            if (CorrectAnswer == button2.Text)
            {
                chart1.Series["Απαντησεις"].Points.AddXY("Το Αλφα", b);
                chart1.Series["Απαντησεις"].Points.AddXY("Το Βητα", a);
                chart1.Series["Απαντησεις"].Points.AddXY("Το Γαμα", c);
                chart1.Series["Απαντησεις"].Points.AddXY("Το Δελτα", d);
                SoundPlayer chart_b = new SoundPlayer(millionaire.Properties.Resources.chart_B);
                chart_b.Play();
                await Task.Delay(6000);
                chart1.Visible = false;
                timer1.Start();
            }
            if (CorrectAnswer == button3.Text)
            {
                chart1.Series["Απαντησεις"].Points.AddXY("Το Αλφα", c);
                chart1.Series["Απαντησεις"].Points.AddXY("Το Βητα", b);
                chart1.Series["Απαντησεις"].Points.AddXY("Το Γαμα", a);
                chart1.Series["Απαντησεις"].Points.AddXY("Το Δελτα", d);
                SoundPlayer chart_c = new SoundPlayer(millionaire.Properties.Resources.chart_C);
                chart_c.Play();
                await Task.Delay(6000);
                chart1.Visible = false;
                timer1.Start();
            }
            if (CorrectAnswer == button4.Text)
            {
                chart1.Series["Απαντησεις"].Points.AddXY("Το Αλφα", d);
                chart1.Series["Απαντησεις"].Points.AddXY("Το Βητα", b);
                chart1.Series["Απαντησεις"].Points.AddXY("Το Γαμα", c);
                chart1.Series["Απαντησεις"].Points.AddXY("Το Δελτα", a);
                SoundPlayer chart_d = new SoundPlayer(millionaire.Properties.Resources.chart_D);
                chart_d.Play();
                await Task.Delay(6000);
                chart1.Visible = false;
                timer1.Start();
            }
        }
    }
}

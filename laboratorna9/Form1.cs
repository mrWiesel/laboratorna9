namespace laboratorna9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Îáğîáíèê çì³íè ñòàíó CheckBox: ïåğåìèêàº ââåäåííÿ ì³æ textBox òà âèáîğîì ôàéëó
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // ßêùî îáğàíî ç÷èòóâàííÿ ç ôàéëó, áëîêóºìî ğó÷íå ââåäåííÿ
                textBox1.Enabled = false;
                textBox1.Text = "Îö³íêè áóäóòü ç÷èòàí³ ç ôàéëó...";
                button1.Text = "Îá÷èñëèòè ç ôàéëó";
            }
            else
            {
                // ßêùî ôàéë íå îáğàíî, äîçâîëÿºìî ğó÷íå ââåäåííÿ
                textBox1.Enabled = true;
                textBox1.Text = "";
            }
        }

        // Îáğîáíèê íàòèñêàííÿ íà êíîïêó: âèêîíóº îñíîâíó ëîã³êó ïğîãğàìè
        private void button1_Click(object sender, EventArgs e)
        {
            string inputData = "";
            string selectedSubject = "";

            // Âèçíà÷àºìî îáğàíèé ïğåäìåò çà äîïîìîãîş if-else
            if (radioButton1.Checked) selectedSubject = "Ìàòåìàòèêà";
            else if (radioButton2.Checked) selectedSubject = "Ô³çèêà";
            else if (radioButton3.Checked) selectedSubject = "Ïğîãğàìóâàííÿ";
            else
            {
                MessageBox.Show("Áóäü ëàñêà, îáåğ³òü ïğåäìåò.", "Óâàãà");
                return;
            }

            // Ç÷èòóºìî äàí³ ç ôàéëó àáî ç TextBox
            if (checkBox1.Checked)
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    openFileDialog.Title = "Îáåğ³òü ôàéë ç îö³íêàìè";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        inputData = File.ReadAllText(openFileDialog.FileName);
                    }
                    else
                    {
                        return; // Çóïèíÿºìî âèêîíàííÿ, ÿêùî êîğèñòóâà÷ çàêğèâ â³êíî âèáîğó ôàéëó
                    }
                }
            }
            else
            {
                inputData = textBox1.Text;
            }

            // Îáğîáêà îö³íîê òà âèâåäåííÿ ğåçóëüòàòó
            try
            {
                // Ğîçáèâàºìî ââåäåíèé ğÿäîê íà ÷èñëà (ğîçä³ëşâà÷³: ïğîá³ë àáî êîìà)
                var grades = inputData.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                      .Select(double.Parse)
                                      .ToList();

                if (grades.Count == 0)
                {
                    MessageBox.Show("Íå çíàéäåíî îö³íîê. Ââåä³òü äàí³ àáî ïåğåâ³ğòå ôàéë.", "Ïîìèëêà");
                    return;
                }

                // Çíàõîäèìî ñåğåäí³é áàë
                double average = grades.Average();
                string conclusion = "";

                // Âèçíà÷àºìî âèñíîâîê çà äîïîìîãîş if/else if çã³äíî ç óìîâàìè
                if (average >= 90 && average <= 100)
                {
                    conclusion = "Â³äì³ííî";
                }
                else if (average >= 75 && average < 90)
                {
                    conclusion = "Äîáğå";
                }
                else if (average >= 60 && average < 75)
                {
                    conclusion = "Çàäîâ³ëüíî";
                }
                else if (average >= 0 && average < 60)
                {
                    conclusion = "Íåçàäîâ³ëüíî";
                }
                else
                {
                    MessageBox.Show("Ïîìèëêà: ñåğåäí³é áàë âèõîäèòü çà ìåæ³ 0-100.", "Ïîìèëêà");
                    return;
                }

                // Âèâîäèìî ô³íàëüíèé ğåçóëüòàò ó Label
                label1.Text = $"Ïğåäìåò: {selectedSubject}\n" +
                              $"Ñåğåäí³é áàë: {Math.Round(average, 2)}\n" +
                              $"Âèñíîâîê: {conclusion}";
            }
            catch (FormatException)
            {
                // Â³äëîâëşºìî ïîìèëêó, ÿêùî ââåäåíî òåêñò çàì³ñòü ÷èñåë
                MessageBox.Show("Íåêîğåêòíèé ôîğìàò äàíèõ. Âèêîğèñòîâóéòå ëèøå ÷èñëà, ğîçä³ëåí³ ïğîá³ëîì àáî êîìîş.", "Ïîìèëêà ôîğìàòó");
            }
            catch (Exception ex)
            {
                // Â³äëîâëşºìî áóäü-ÿê³ ³íø³ íåïåğåäáà÷óâàí³ ïîìèëêè
                MessageBox.Show($"Ñòàëàñÿ ïîìèëêà: {ex.Message}", "Ïîìèëêà");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

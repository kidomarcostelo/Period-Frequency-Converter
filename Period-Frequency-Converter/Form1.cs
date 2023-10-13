namespace Period_Frequency_Converter
{
    public partial class Form1 : Form
    {
        bool switchDeterminer = false;

        List<string> fItems = new List<string>
            {
                "Hz",
                "KHz",
                "MHz",
                "GHz",
                "THz"
            };
        List<string> tItems = new List<string>
            {
                "s",
                "ms",
                "µs",
                "ns",
                "ps"
            };

        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.AddRange(fItems.ToArray());
            comboBox2.Items.AddRange(tItems.ToArray());
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            textBox2.ReadOnly = true;

            FirstLabel.Text = "Frequency";
            SecondLabel.Text = "Seconds";
        }

        private void Switch()
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            comboBox1.Items.Clear();
            comboBox2.Items.Clear();

            // false kay default
            if (!switchDeterminer)
            {
                FirstLabel.Text = "Frequency";
                SecondLabel.Text = "Seconds";
                comboBox1.Items.AddRange(fItems.ToArray());
                comboBox2.Items.AddRange(tItems.ToArray());

                switchDeterminer = true;

            }
            else
            {
                FirstLabel.Text = "Seconds";
                SecondLabel.Text = "Frequency";
                comboBox1.Items.AddRange(tItems.ToArray());
                comboBox2.Items.AddRange(fItems.ToArray());

                switchDeterminer = false;
            }

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Switch();
        }

        private void Convert()
        {
            try
            {
                double number = double.Parse(textBox1.Text);

                // convert  Period to Frequency
                if (FirstLabel.Text == "Seconds")
                {
                    double periodsInSeconds = GetPeriodInSeconds(number, comboBox1.SelectedItem.ToString()!);
                    double frequency = 1.0 / periodsInSeconds;

                    double answer = ConvertToOutputUnit(frequency, "Hz", comboBox2.SelectedItem.ToString()!);
                    textBox2.Text = answer.ToString();
                }
                // convert frequency to period
                else
                {
                    double frequencyInHertz = GetFrequencyInHertz(number, comboBox1.SelectedItem.ToString()!);

                    double periods = 1.0 / frequencyInHertz;

                    double answer = ConvertToOutputUnit(periods, "s", comboBox2.SelectedItem.ToString()!);
                    textBox2.Text = answer.ToString();
                }
            }
            catch
            {
                label1.Text = "Invalid Input";
                return;
            }

        }

        //Convert period to seconds 
        private double GetPeriodInSeconds(double periods, string selectedUnit)
        {
            switch (selectedUnit)
            {
                case "s":
                    return periods;
                case "ms":
                    return periods * 1e-3;
                case "µs":
                    return periods * 1e-6;
                case "ns":
                    return periods * 1e-9;
                case "ps":
                    return periods * 1e-12;
                default:
                    return periods;
            }
        }

        //Convert Frequency to Hz
        private double GetFrequencyInHertz(double frequency, string selectedUnit)
        {

            switch (selectedUnit)
            {
                case "Hz":
                    return frequency;
                case "KHz":
                    return frequency * 1e3;
                case "MHz":
                    return frequency * 1e6;
                case "GHz":
                    return frequency * 1e9;
                case "THz":
                    return frequency * 1e12;
                default:
                    return frequency;
            }
        }

        private double ConvertToOutputUnit(double value, string inputUnit, string outputUnit)
        {
            switch (inputUnit)
            {
                case "s":
                    switch (outputUnit)
                    {
                        case "s":
                            return value;
                        case "ms":
                            return value * 1e3;
                        case "µs":
                            return value * 1e6;
                        case "ns":
                            return value * 1e9;
                        case "ps":
                            return value * 1e12;
                    }
                    break;
                case "Hz":
                    switch (outputUnit)
                    {
                        case "Hz":
                            return value;
                        case "KHz":
                            return value * 1e-3;
                        case "MHz":
                            return value * 1e-6;
                        case "GHz":
                            return value * 1e-9;
                        case "THz":
                            return value * 1e-12;
                    }
                    break;
                    // Handle other input units and their conversions to output units here
            }

            // Default: return the input value if units do not match
            return value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Convert();
        }
    }
}
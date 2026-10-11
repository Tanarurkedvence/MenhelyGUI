using MenhelyCLI;

namespace MenhelyGUI
{
    public partial class Form1 : Form
    {
        List<Kutya> kutyas = new List<Kutya>();
        static int index = 0;
        static int index1 = 0;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            comboBox1.TextChanged += ComboBox1_TextChanged;
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show(
                 text: $"Biztosan örökbe fogadja {nev.Text} nevű kutyát?",
                 caption: "Örökbefogadás",
                 icon: MessageBoxIcon.Question,
                 buttons: MessageBoxButtons.YesNo
                 );

            if (response == DialogResult.Yes)
            {
                if (kutyas[index1].Orokbefogadva == true)
                {
                    MessageBox.Show(
                     text: $"Ez a kutya már gazdára talált!",
                     caption: "Örökbefogadás",
                     icon: MessageBoxIcon.Question,
                     buttons: MessageBoxButtons.OKCancel
                 );
                }
                else { 
                using (StreamWriter iro = new StreamWriter("../../../forras/orokbefogadasok.txt"))
                {
                    iro.WriteLine($"{DateTime.Now};{nev.Text}");
                }
                Application.Exit();
                }
            }
        }

        private void ListBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            index1 = listBox1.SelectedIndex;
            nev.Text = $"{kutyas[index1].Nev}";
            fajta.Text = $"{kutyas[index1].Fajta}";
            kor.Text = $"{kutyas[index1].Kor} év";
            suly.Text = $"{kutyas[index1].Suly} kg";
            nem.Text = $"{kutyas[index1].Nem}";
            allapot.Text = kutyas[index1].Orokbefogadva ? "Gazdáratalált" : "Örökbefogadható";

        }

        private void ComboBox1_TextChanged(object? sender, EventArgs e)
        {
              index = comboBox1.SelectedIndex;
              listBox1.Items.Clear();
              var f8 = kutyas.Where(x => x.Fajta == kutyas[index].Fajta).ToList();

            foreach (var kutya in f8)
            {
                listBox1.Items.Add(kutya.ToString());
            }

        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            Read();
            Write();
            var kutyak = kutyas.Select(x => x.Fajta).Distinct().ToList();
            foreach (var kutya in kutyak)
            {
                comboBox1.Items.Add(kutya.ToString());
             }
        }

        private void Write()
        {
            foreach(var kutya in kutyas)
            {
                listBox1.Items.Add(kutya.ToString());
            }
             
        }

        private void Read()
        {
            using (StreamReader o = new StreamReader("../../../forras/kutyak.txt"))
            {
                o.ReadLine();
                while (!o.EndOfStream)
                {
                    string line = o.ReadLine();
                    kutyas.Add(new Kutya(line));
                }

            }
        }
    }
}

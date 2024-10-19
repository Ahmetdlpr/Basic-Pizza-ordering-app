namespace Pizza_ordering_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sosis_CheckedChanged(object sender, EventArgs e)
        {
            label11.Text = Sosis.Text;
        }

        private void Siparisitamamlabtn_Click(object sender, EventArgs e)
        {
            Ýsimsoyisimlistbox.Items.Add(Adisoyaditextbox.Text);
            Telefonlistbox.Items.Add(Telefonnotextbox.Text);
            AdresListBox.Items.Add(Adrestextbox.Text);
            PizzaBoylistbox.Items.Add(Pizzaboyutucombobox.Text);
            Iceceklerlistbox.Items.Add(Iceceklercombobox.Text);
            Cesitlerlistbox.Items.Add(label1.Text + "," + label14.Text + "," + label15.Text + "," + label16.Text + "," + label17.Text + "," + label23.Text + "," + label22.Text + "," + label21.Text + "," + label20.Text + "," + label19.Text + "," + label18.Text);
        }

        private void Sucuk_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = Sucuk.Text;
        }

        private void Pastýrma_CheckedChanged(object sender, EventArgs e)
        {
            label14.Text = Pastýrma.Text;
        }

        private void Cheddar_CheckedChanged(object sender, EventArgs e)
        {
            label15.Text = Cheddar.Text;
        }

        private void Ezine_CheckedChanged(object sender, EventArgs e)
        {
            label16.Text = Ezine.Text;
        }

        private void Tulum_CheckedChanged(object sender, EventArgs e)
        {
            label17.Text = Tulum.Text;
        }

        private void Kornisonbiber_CheckedChanged(object sender, EventArgs e)
        {
            label23.Text = Kornisonbiber.Text;
        }

        private void Yesilbiber_CheckedChanged(object sender, EventArgs e)
        {
            label22.Text = Yesilbiber.Text;
        }

        private void Kýrmýzýbiber_CheckedChanged(object sender, EventArgs e)
        {
            label21.Text = Kýrmýzýbiber.Text;
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void incehamur_CheckedChanged(object sender, EventArgs e)
        {
            label20.Text = incehamur.Text;
        }

        private void Ortahamur_CheckedChanged(object sender, EventArgs e)
        {
            label19.Text = Ortahamur.Text;
        }

        private void Kalýnhamur_CheckedChanged(object sender, EventArgs e)
        {
            label18.Text = Kalýnhamur.Text;
        }

        private void Temizlebtn_Click(object sender, EventArgs e)
        {
            Pizzaboyutucombobox.Text = "";
            Iceceklercombobox.Text = "";
            Adisoyaditextbox.Text = "";
            Telefonnotextbox.Text = "";
            Adrestextbox.Text = "";
            label1.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label23.Text = "";
            label22.Text = "";
            label21.Text = "";
            label20.Text = "";
            label19.Text = "";
            label18.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pizzaboyutucombobox.Text = "";
            Iceceklercombobox.Text = "";
            Adisoyaditextbox.Text = "";
            Telefonnotextbox.Text = "";
            Adrestextbox.Text = "";
            label1.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label23.Text = "";
            label22.Text = "";
            label21.Text = "";
            label20.Text = "";
            label19.Text = "";
            label18.Text = "";
            Telefonlistbox.Items.Clear();
            Ýsimsoyisimlistbox.Items.Clear();
            Iceceklerlistbox.Items.Clear();
            PizzaBoylistbox.Items.Clear();
            AdresListBox.Items.Clear();
            Cesitlerlistbox.Items.Clear();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

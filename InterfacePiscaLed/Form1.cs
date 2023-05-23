using InterfacePiscaLed.classes;
namespace InterfacePiscaLed {

    public partial class Form1 : Form {
        private Led Led;
        public Form1() {
            InitializeComponent();
            this.Led = new Led();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            if (Led.IsLedOn() == true) {
                Led.TurnOff();
                energy.Image = Properties.Resources.energy_off;
                MessageBox.Show("O Led foi desligado", "Desligado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Led.IsLedOn() == false) {
                Led.TurnOn();
                energy.Image= Properties.Resources.energy_on;
                MessageBox.Show("O Led foi ligado", "Ligado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Ocorreu Algum erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
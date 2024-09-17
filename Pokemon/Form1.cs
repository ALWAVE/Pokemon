using Pokemon.Characters;

namespace Pokemon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DisplayPokemonInfo();
        }


        private void DisplayPokemonInfo()
        {
           


            // Создаем экземпляр Ullumise
            Ullumise illumise = new Ullumise();

            // Присваиваем значения элементам управления
            label1.Text = illumise.Name;
            label2.Text = $"HP: {illumise.Hp}";
            label3.Text = $"Attack: {illumise.Attack}";
            label4.Text = $"Defense: {illumise.Deffense}";
            label5.Text = $"Speed: {illumise.Speed}";
            label6.Text = $"Special Attack: {illumise.SpecialAttack?.Name} (Power: {illumise.SpecialAttack?.Power})";
            label7.Text = $"Special Protection: {illumise.SpecialProtection?.Name} (Protection: {illumise.SpecialProtection?.Protection})";

            Sawsbuck sawsbuck = new Sawsbuck();

            label14.Text = sawsbuck.Name;
            label13.Text = $"HP: {sawsbuck.Hp}";
            label12.Text = $"Attack: {sawsbuck.Attack}";
            label11.Text = $"Defense: {sawsbuck.Deffense}";
            label9.Text = $"Speed: {sawsbuck.Speed}";
            label8.Text = $"Special Attack: {sawsbuck.SpecialAttack?.Name} (Power: {sawsbuck.SpecialAttack?.Power})";
            label10.Text = $"Special Protection: {sawsbuck.SpecialProtection?.Name} (Protection: {sawsbuck.SpecialProtection?.Protection})";

            Deerling deerling = new Deerling();

            label21.Text = deerling.Name;
            label20.Text = $"HP: {deerling.Hp}";
            label19.Text = $"Attack: {deerling.Attack}";
            label18.Text = $"Defense: {deerling.Deffense}";
            label16.Text = $"Speed: {deerling.Speed}";
            label17.Text = $"Special Attack: {deerling.SpecialAttack?.Name} (Power: {deerling.SpecialAttack?.Power})";
            label15.Text = $"Special Protection: {deerling.SpecialProtection?.Name} (Protection: {deerling.SpecialProtection?.Protection})";

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

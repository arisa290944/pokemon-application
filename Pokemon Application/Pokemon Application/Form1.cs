using Pokemon_Application.Properties;

namespace Pokemon_Application
{
    public partial class Form1 : Form
    {
        Pokemon[] pokemonPosition = new Pokemon[6];
        Charmander charmander;
        Sandshrew sandshrew;
        Jigglypuff jigglypuff;
        Paras paras;
        Clefairy clefairy;
        Mankey mankey;
        public Form1()
        {
            InitializeComponent();
            charmander = new Charmander();
            sandshrew = new Sandshrew();
            jigglypuff = new Jigglypuff();
            paras = new Paras();
            clefairy = new Clefairy();
            mankey = new Mankey();
        }
        void setPokemonImage()
        {
            this.labelPokemonName.Text = pokemonPosition[0].getName();
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;

            this.pictureBox1.Image = pokemonPosition[0].getImage();
            this.pictureBox2.Image = pokemonPosition[1].getImage();
            this.pictureBox3.Image = pokemonPosition[2].getImage();
            this.pictureBox4.Image = pokemonPosition[3].getImage();
            this.pictureBox5.Image = pokemonPosition[4].getImage();
            this.pictureBox6.Image = pokemonPosition[5].getImage();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pokemonPosition[0] = charmander;
            pokemonPosition[1] = sandshrew;
            pokemonPosition[2] = jigglypuff;
            pokemonPosition[3] = paras;
            pokemonPosition[4] = clefairy;
            pokemonPosition[5] = mankey;

            setPokemonImage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pokemon temp = pokemonPosition[0];
            pokemonPosition[0] = pokemonPosition[1];
            pokemonPosition[1] = temp;

            setPokemonImage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pokemon temp = pokemonPosition[0];
            pokemonPosition[0] = pokemonPosition[2];
            pokemonPosition[2] = temp;

            setPokemonImage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pokemon temp = pokemonPosition[0];
            pokemonPosition[0] = pokemonPosition[3];
            pokemonPosition[3] = temp;

            setPokemonImage();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pokemon temp = pokemonPosition[0];
            pokemonPosition[0] = pokemonPosition[4];
            pokemonPosition[4] = temp;

            setPokemonImage();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pokemon temp = pokemonPosition[0];
            pokemonPosition[0] = pokemonPosition[5];
            pokemonPosition[5] = temp;

            setPokemonImage();
        }
    }
}
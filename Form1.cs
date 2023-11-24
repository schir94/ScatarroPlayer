using System.Media;

namespace ScatarroPlayer
{
	public partial class ScatarroPlayer : Form
	{
		public ScatarroPlayer()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var audio = Properties.Resources.scatarro;

			using SoundPlayer soundPlayer = new SoundPlayer(audio);
			soundPlayer.Play();

		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace TrabajoPracticoPrimerParcial
{
    public static class Sounds
    {

        public static void PlayClickSound()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:\\Users\\vilan\\OneDrive\\Escritorio\\TrabajoPracticoPrimerParcialProgLab2\\CarniceriaApp\\TrabajoPracticoPrimerParcial\\Resources\\click.wav";
            player.Play();
        }
        public static void PlayClickSound2()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:\\Users\\vilan\\OneDrive\\Escritorio\\TrabajoPracticoPrimerParcialProgLab2\\CarniceriaApp\\TrabajoPracticoPrimerParcial\\Resources\\click2.wav";
            player.Play();
        }
        public static void PlayClickSound3()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:\\Users\\vilan\\OneDrive\\Escritorio\\TrabajoPracticoPrimerParcialProgLab2\\CarniceriaApp\\TrabajoPracticoPrimerParcial\\Resources/click3.wav";
            player.Play();
        }
    }
}


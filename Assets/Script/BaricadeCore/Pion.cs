namespace BaricadeCore
{
    public class Pion : Bille
    {
        Couleur couleur;

        public Pion(Couleur couleur) : base(){
            this.couleur = couleur;
        }
    }

    public enum Couleur {
        Rouge,
        Jaune,
        Bleu,
        Vert
    }
}
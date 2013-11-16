using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace projet_bdsp
{
    public class Plate
    {
        public byte[,] Cells { get; set; }

        public void Draw(SpriteBatch spriteBatch)
        {
            // On boucle sur chaque case
            // Si la case est un bloc on affiche sa texture (bloc bloqué ou en mouvement)
            // Sinon on fait rien
        }

        public bool IsLineFull(int y)
        {
            // Renvoie vrai si la ligne numéro y est pleine (byte 1 ou 2)
            return true;
        }

        public void EmptyLine(int y)
        {
            // Vide la ligne y et fait tomber tous les blocs
            // au dessus de cette ligne d'une case

        }


       
    }
}

using MetroFramework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLand.Domain.Interface
{
    public class Colors
    {
        public Color GetColor(MetroColorStyle style)
        {
            Color retorno = new Color();
            switch (style)
            {
                case MetroColorStyle.Orange:
                    retorno = Color.DarkOrange;
                    break;
                case MetroColorStyle.Green:
                    retorno = Color.Green;
                    break;
                case MetroColorStyle.Pink:
                    retorno = Color.Pink;
                    break;
                case MetroColorStyle.Purple:
                    retorno = Color.Purple;
                    break;
                case MetroColorStyle.Red:
                    retorno = Color.Red;
                    break;
                case MetroColorStyle.Silver:
                    retorno = Color.Silver;
                    break;
                case MetroColorStyle.Yellow:
                    retorno = Color.Yellow;
                    break;
                case MetroColorStyle.Brown:
                    retorno = Color.SaddleBrown;
                    break;
                case MetroColorStyle.Magenta:
                    retorno = Color.Magenta;
                    break;
                case MetroColorStyle.Blue:
                    retorno = Color.DeepSkyBlue;
                    break;
                case MetroColorStyle.Lime:
                    retorno = Color.Lime;
                    break;
                case MetroColorStyle.Teal:
                    retorno = Color.Teal;
                    break;
            }
            return retorno;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using VietNamWar.Global;
namespace VietNamWar.DTO
{
    class CinfoEagle
    {
        private string symbol;

        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }
        //trạng thái
        STATUS status;
        //img soure
        private static Dictionary<Texture2D, Vector2> midPos;
        private Texture2D posImg;
        private Point midImg;

        public CinfoEagle() { }

        public CinfoEagle(string symbol, STATUS status, Texture2D posImg, Point midImg) 
        {
            this.symbol = symbol;
            this.status = status;
            this.posImg = posImg;
            this.midImg = midImg;
        }
    }
}

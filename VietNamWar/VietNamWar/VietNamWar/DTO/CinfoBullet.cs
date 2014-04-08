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
    class CinfoBullet
    {
        //kí hiệu
        private string symbol;

        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }
        //source img
        private static Dictionary<Texture2D, Vector2> midPos;
        private Texture2D posImg;
        private Point midImg;
        //trang thai
        STATUS status;

        // tốc độ bay
        private int speed;

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        // đạn địch or đạn ta
        GUIDE guide;
        public CinfoBullet() { }

        public CinfoBullet(string symbol, STATUS status, int speed, GUIDE guide,
            Dictionary<Texture2D, Vector2> midPos, Texture2D posImg, Point midImg)
        {
            this.symbol = symbol;
            this.status = status;

            this.speed = speed;
            this.guide = guide;
            this.posImg = posImg;
            this.midImg = midImg;
        }
    }
}

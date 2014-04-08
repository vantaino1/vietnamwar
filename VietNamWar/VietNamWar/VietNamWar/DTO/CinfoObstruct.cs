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
    public class CinfoObstruct
    {
        protected ContentManager _content;
        protected GameTime _gametime;
        protected SpriteBatch _spritebatch;

        protected OBSTRUCTIONS symbol;              // Ký hiệu           
        protected Rectangle _wall;                  // Hình ảnh vật cản
        protected Vector2 _posWall;                 // Vị trí ảnh

        #region Constructor

        public CinfoObstruct() { }

        public CinfoObstruct(OBSTRUCTIONS symbol, Rectangle _wall, Vector2 _posWall)
        {
            this.symbol = symbol;
            this._wall = _wall;
            this._posWall = _posWall;
            
        }
        
        #endregion

        #region Proterties\

        public Rectangle Wall
        {
            get { return _wall; }
            set { _wall = value; }
        }

        public OBSTRUCTIONS Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        public Vector2 PosWall
        {
            get { return _posWall; }
            set { _posWall = value; }
        }

        #endregion
    }
}

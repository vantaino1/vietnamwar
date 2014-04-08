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
    class CinfoTanks
    {
        #region Variable

        protected DIRECTION direction;                      // Hướng
        protected STATUS status;                            // Trạng thái

        protected CGlobalVariable _amor;                    // Áo Giáp
        protected CGlobalVariable _life_player;             // Số mạng
        protected CGlobalVariable _ms_player;               // Tốc độ
        protected CGlobalVariable _dame;                    // Sức công phá
        protected CGlobalVariable _hp_player;               // Máu

        protected Vector2 current;                          // vị trí hiện tại
        protected Vector2 destination;                      // VT Đích đến

        protected Texture2D _imgTanks;                      // Hình ảnh
        
        #endregion

        #region Properties

        public Texture2D ImgTanks
        {
          get { return _imgTanks; }
          set { _imgTanks = value; }
        }

        public Vector2 Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public Vector2 Current
        {
            get { return current; }
            set { current = value; }
        }

        public CGlobalVariable Dame
        {
            get { return _dame; }
            set { _dame = value; }
        }
        public CGlobalVariable Hp_player
        {
            get { return _hp_player; }
            set { _hp_player = value; }
        }

        public CGlobalVariable Ms_player
        {
            get { return _ms_player; }
            set { _ms_player = value; }
        }
        public CGlobalVariable Life_player
        {
            get { return _life_player; }
            set { _life_player = value; }
        }
        public DIRECTION Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        public STATUS Status
        {
            get { return status; }
            set { status = value; }
        }

        public CGlobalVariable Amor
        {
            get { return _amor; }
            set { _amor = value; }
        }
        #endregion

        #region Constructors
        public CinfoTanks(){}
        #endregion


    }
}

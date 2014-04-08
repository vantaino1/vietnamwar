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
    class CInfoPlayerTank:CinfoTanks
    {
        protected PLAYER _player;                                // Người chơi 1 hoặc người chơi 2
        protected PLAYERGUIDE _guide;                            // Cấp độ tank người chơi
        protected Vector2 _posStart = new Vector2(330, 780);     // Vị trí xe tank xuất hiện khi bắt đầu

        public Dictionary<string, Rectangle> _tankRules;         //Thông tin file xml hình ảnh
        
        #region Constructor
        public CInfoPlayerTank()
            : base() { }
        public CInfoPlayerTank(PLAYER _player, PLAYERGUIDE _guide, Vector2 _posStart)
            :base()
        {
            this._player = _player;
            this._guide = _guide;
            this._posStart = _posStart;
        }
        #endregion
        #region Properties
        protected PLAYER Player
        {
            get { return _player; }
            set { _player = value; }
        }
        public PLAYERGUIDE Guide
        {
            get { return _guide; }
            set { _guide = value; }
        }

        public Vector2 PosStart
        {
            get { return _posStart; }
            set { _posStart = value; }
        }
        #endregion
    }
}

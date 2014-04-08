using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
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
    class CInfoLevel
    {

        protected List<CinfoTanks> _enemyTanks;             // Số lượng xe tank địch
        protected List<CinfoItems> _items;                  // Số lượng vật phẩm ngẫu nhiên
        protected List<CinfoObstruct> _obs;                 //Thông tin vật cản
        protected Point _eaglepos;                          // Vị trí eagle
        public Dictionary<string, string> _mapRules;        // Thông tin xây dựng map
        public Dictionary<string, Rectangle> _wallRules;    // Thông tin tọa độ hình ảnh vật cản
         
        protected ContentManager _content;
        protected GameTime _gametime;
        protected SpriteBatch _spritebatch;

        #region Constructor
        public CInfoLevel() 
        {
            _enemyTanks = new List<CinfoTanks>();
            _items = new List<CinfoItems>();
            _obs = new List<CinfoObstruct>();
            _eaglepos = new Point(13, 25);
        }
        #endregion

        #region Properties

        public List<CinfoItems> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public List<CinfoTanks> EnemyTanks
        {
            get { return _enemyTanks; }
            set { _enemyTanks = value; }
        }
        public List<CinfoObstruct> Obs
        {
            get { return _obs; }
            set { _obs = value; }
        }

        public Point Eaglepos
        {
            get { return _eaglepos; }
            set { _eaglepos = value; }
        }
        #endregion
    }
}

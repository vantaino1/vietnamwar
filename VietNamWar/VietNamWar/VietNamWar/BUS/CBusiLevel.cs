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

namespace VietNamWar.BUS
{
    class CBusiLevel
    {
        DTO.CInfoLevel Level = new DTO.CInfoLevel();
        DTO.CinfoObstruct Obs;
        protected char[] _mapRules;
        protected Texture2D _wall;

        public ContentManager _content;
        public GameTime _gameTime;
        public SpriteBatch _spritebatch;

        #region Process methods
        public CBusiLevel(ContentManager _content, GameTime _gameTime, SpriteBatch _spritebatch)
        {
            this._content = _content;
            this._gameTime = _gameTime;
            this._spritebatch = _spritebatch;

            if (_content != null)
            {
                Level._mapRules = _content.Load<Dictionary<string, string>>("Map/1");
                Level._wallRules = _content.Load<Dictionary<string, Rectangle>>("XML/wallmini");
                _wall = _content.Load<Texture2D>("Images/wallmini");               
            }
            for (int i = 1; i <= 26; i++)
            {
                _mapRules = Level._mapRules["Line" + i].ToCharArray();
                for (int j = 0; j < 26; j++)
                {
                    switch (_mapRules[j])
                    {
                        case '#':
                            Obs = new DTO.CinfoObstruct();
                            Obs.Symbol = OBSTRUCTIONS.brick;
                            Obs.Wall = Level._wallRules["#"];
                            Obs.PosWall = new Vector2(i*30,(j+1)*30);
                            Level.Obs.Add(Obs);
                            break;
                        case '@':
                            Obs = new DTO.CinfoObstruct();
                            Obs.Symbol = OBSTRUCTIONS.steel;
                            Obs.Wall = Level._wallRules["@"];
                            Obs.PosWall = new Vector2(i*30,(j+1)*30);
                            Level.Obs.Add(Obs);
                            break;
                        case '~':
                            Obs = new DTO.CinfoObstruct();
                            Obs.Symbol = OBSTRUCTIONS.river;
                            Obs.Wall = Level._wallRules["~"];
                            Obs.PosWall = new Vector2(i*30,(j+1)*30);
                            Level.Obs.Add(Obs);
                            break;
                        case '%':
                            Obs = new DTO.CinfoObstruct();
                            Obs.Symbol = OBSTRUCTIONS.tree;
                            Obs.Wall = Level._wallRules["%"];
                            Obs.PosWall = new Vector2(i*30,(j+1)*30);
                            Level.Obs.Add(Obs);
                            break;
                    }
                }
            }
            
        }
        #endregion

        #region BUS methods
        public void Update()
        {
        }
        public void Draw()
        {
            _spritebatch.Begin();
            foreach (DTO.CinfoObstruct _obstruct in Level.Obs)
            {
                switch (_obstruct.Symbol)
                {
                    case OBSTRUCTIONS.brick:
                        _spritebatch.Draw(_wall, Obs.PosWall, Obs.Wall, Color.White, 0, Vector2.Zero, 1f, SpriteEffects.None, 0);
                        break;
                    case OBSTRUCTIONS.river:
                        _spritebatch.Draw(_wall, Obs.PosWall, Obs.Wall, Color.White, 0, Vector2.Zero,1f, SpriteEffects.None, 0);
                        break;
                    case OBSTRUCTIONS.steel:
                        _spritebatch.Draw(_wall, Obs.PosWall, Obs.Wall, Color.White, 0, Vector2.Zero, 1f, SpriteEffects.None, 0);
                        break;
                    case OBSTRUCTIONS.tree:
                        _spritebatch.Draw(_wall, Obs.PosWall, Obs.Wall, Color.White, 0, Vector2.Zero, 1f, SpriteEffects.None, 0);
                        break;
                }
            }
            _spritebatch.End();
           
        }
        #endregion
    }
}

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

namespace VietNamWar.BUS
{
    class CBusiPlayerTank
    {
        DTO.CInfoPlayerTank _ptank = new DTO.CInfoPlayerTank();
        int num = 1;

        ContentManager _content;
        SpriteBatch _spritebatch;
        GameTime _gametime;

        public CBusiPlayerTank(ContentManager _content, GameTime _gametime, SpriteBatch _spritebatch)
        {
            this._content = _content;
            this._gametime = _gametime;
            this._spritebatch = _spritebatch;
            if(_content!=null)
            {
                _ptank._tankRules = _content.Load<Dictionary<string,Rectangle>>("XML/lefttank");
                _ptank.ImgTanks = _content.Load<Texture2D>("Images/lefttank");
            }
        }
        public void Draw()
        {
            _spritebatch.Begin();
            _spritebatch.Draw(_ptank.ImgTanks, _ptank.PosStart, _ptank._tankRules["tank"+num], Color.White, 0, Vector2.Zero,1f, SpriteEffects.None, 0);
            _spritebatch.End();
        }
        public void Update()
        {
            KeyboardState keyboartState = Keyboard.GetState();
            if (keyboartState.IsKeyDown(Keys.A))
                _ptank.Status = STATUS.action;
                if (num < 6)
                    num++;
                else
                    num = 1;
                _ptank.Status = STATUS.stand;
        }
    }
}

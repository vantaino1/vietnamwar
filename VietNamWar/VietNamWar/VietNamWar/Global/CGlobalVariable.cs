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

namespace VietNamWar.Global
{
    public class CGlobalVariable
    {
        private static int _level = 1;                                        //Cấp độ màn chơi       
        private static int _score = 0;                                        //Điểm tổng kết        
        private static int _bonus = 50;                                       //Điểm cộng khi hoàn thành màn chơi

        private static int _hp_player = 100;                                  //Máu của xe tank player
        private static int _hp_enemy = 100;                                   //Máu của xe tank địch bình thường
        private static int _hp_enemy_heavy = 400;                             //Máu của xe tank địch dạng heavy

        private static int _ms_player;                                        //Tốc độ di chuyển của tank người chơi
        private static int _ms_enemy_heavey;                                  //Tốc độ di chuyển của tank heavy
        private static int _ms_enemy_strike;                                  //Tốc độ di chuyển của tank strike

        private static int _life_player_1 = 3;                                //Số lượng mạng người chơi 1
        private static int _life_player_2 = 3;                                //Số lượng mạng người chơi 2

        private static int _dame = 100;                                       //Lực công kích của đạn
        private static bool amor = true;                                      //Lớp bảo vệ khi hồi sinh hoặc ăn item amor
                                               
        public static Vector2 curPos;                                   //Vị trí hiện tại của người chơi
        public static Vector2 endPos;                                   //Vị trí kết thúc của người chơi 
        public static Dictionary<Texture2D, Vector2> midPos;            //Tâm ảnh

        #region Properties
        public static int Level
        {
            get { return CGlobalVariable._level; }
            set { CGlobalVariable._level = value; }
        }

        public static int Score
        {
            get { return CGlobalVariable._score; }
            set { CGlobalVariable._score = value; }
        }

        public static int Bonus
        {
            get { return CGlobalVariable._bonus; }
            set { CGlobalVariable._bonus = value; }
        }

        public static int Hp_player
        {
            get { return CGlobalVariable._hp_player; }
            set { CGlobalVariable._hp_player = value; }
        }

        public static int Hp_enemy
        {
            get { return CGlobalVariable._hp_enemy; }
            set { CGlobalVariable._hp_enemy = value; }
        }

        public static int Hp_enemy_heavy
        {
            get { return CGlobalVariable._hp_enemy_heavy; }
            set { CGlobalVariable._hp_enemy_heavy = value; }
        }

        public static int Ms_player
        {
            get { return CGlobalVariable._ms_player; }
            set { CGlobalVariable._ms_player = value; }
        }

        public static int Ms_enemy_heavey
        {
            get { return CGlobalVariable._ms_enemy_heavey; }
            set { CGlobalVariable._ms_enemy_heavey = value; }
        }

        public static int Ms_enemy_strike
        {
            get { return CGlobalVariable._ms_enemy_strike; }
            set { CGlobalVariable._ms_enemy_strike = value; }
        }

        public static int Life_player_1
        {
            get { return CGlobalVariable._life_player_1; }
            set { CGlobalVariable._life_player_1 = value; }
        }

        public static int Life_player_2
        {
            get { return CGlobalVariable._life_player_2; }
            set { CGlobalVariable._life_player_2 = value; }
        }

        public static int Dame
        {
            get { return CGlobalVariable._dame; }
            set { CGlobalVariable._dame = value; }
        }

        public static bool Amor
        {
            get { return CGlobalVariable.amor; }
            set { CGlobalVariable.amor = value; }
        }
        #endregion
    }
}

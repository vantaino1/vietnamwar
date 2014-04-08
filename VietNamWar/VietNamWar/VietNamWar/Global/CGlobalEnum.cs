using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VietNamWar.Global
{
    /// <summary>
    /// Trạng thái của xe tank
    /// </summary>
    public enum STATUS
    {
        dead = 0,
        alive = 1,
        stand = 2,
        action = 3,
        pause = 4,
    }

    /// <summary>
    /// Player 1 hoặc Player 2
    /// </summary>
    public enum PLAYER
    {
        player1 = 0,
        player2 = 1,
    }

    /// <summary>
    /// 4 cấp độ xe tank địch
    /// </summary>
    public enum ENEMYGUIDE
    {
        basic = 0,
        strike = 1,
        medium = 2,
        heavy = 3,
    }

    /// <summary>
    /// 4 cấp độ xe tank người chơi
    /// </summary>
    public enum PLAYERGUIDE
    {
        lv0 = 0,
        lv1 = 1,
        lv2 = 2,
        lv3 = 3,
    }

    /// <summary>
    /// Các dạng vật cản
    /// </summary>
    public enum OBSTRUCTIONS
    {
        brick = 0,
        steel = 1,
        river = 2,
        tree = 3,
    }

    /// <summary>
    /// Hướng di chuyển của xe tank và đạn
    /// </summary>
    public enum DIRECTION
    {
        left = 0,
        right = 1,
        up = 2,
        down = 3,
    }

    /// <summary>
    /// Các vật phẩm rơi ngẫu nhiên trong game
    /// </summary>
    public enum ITEMS
    {
        grenade = 0,
        clock = 1,
        shovel = 2,
        start = 3,
        tank = 4,
        helmet = 5,
    }

    /// <summary>
    /// Người chơi hoặc máy
    /// </summary>
    public enum GUIDE
    {
        player = 0,
        enmey = 1,
    }


}

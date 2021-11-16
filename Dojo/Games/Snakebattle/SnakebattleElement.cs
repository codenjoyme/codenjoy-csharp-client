/*-
 * #%L
 * Codenjoy - it's a dojo-like platform from developers to developers.
 * %%
 * Copyright (C) 2021 Codenjoy
 * %%
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as
 * published by the Free Software Foundation, either version 3 of the
 * License, or (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public
 * License along with this program.  If not, see
 * <http://www.gnu.org/licenses/gpl-3.0.html>.
 * #L%
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo.Games.Snakebattle
{
    public enum SnakebattleElement : short
    {

            // Empty space - space where the snake can move.

        NONE = (short)' ',

            // Impenetrable wall.

        WALL = (short)'☼',

            // Respawn point from which the snake starts its movement.

        START_FLOOR = (short)'#',

            // .

        OTHER = (short)'?',

            // Apple.

        APPLE = (short)'○',

            // Stone.

        STONE = (short)'●',

            // Flying pill/Angel's wings.

        FLYING_PILL = (short)'©',

            // Fury pill/Devil's mask.

        FURY_PILL = (short)'®',

            // Gold.

        GOLD = (short)'$',

            // Your snake head pointing down.

        HEAD_DOWN = (short)'▼',

            // Your snake head pointing left.

        HEAD_LEFT = (short)'◄',

            // Your snake head pointing right.

        HEAD_RIGHT = (short)'►',

            // Your snake head pointing up.

        HEAD_UP = (short)'▲',

            // Your snake is dead.

        HEAD_DEAD = (short)'☻',

            // Your snake head under influence Fury pill/Devils mask.

        HEAD_EVIL = (short)'♥',

            // Your snake head under influence Flying pill/Angels wings.

        HEAD_FLY = (short)'♠',

            // Your snake head when snake is inactive.

        HEAD_SLEEP = (short)'&',

            // Body of your snake is directed horizontally.

        BODY_HORIZONTAL = (short)'═',

            // Body of your snake is directed vertically.

        BODY_VERTICAL = (short)'║',

            // Turning your snake body from left to down.

        BODY_LEFT_DOWN = (short)'╗',

            // Turning your snake body from left to up.

        BODY_LEFT_UP = (short)'╝',

            // Turning your snake body from right to down.

        BODY_RIGHT_DOWN = (short)'╔',

            // Turning your snake body from left to up.

        BODY_RIGHT_UP = (short)'╚',

            // Your snake tail (end) pointing down.

        TAIL_END_DOWN = (short)'╙',

            // Your snake tail (end) pointing left.

        TAIL_END_LEFT = (short)'╘',

            // Your snake tail (end) pointing up.

        TAIL_END_UP = (short)'╓',

            // Your snake tail (end) pointing right.

        TAIL_END_RIGHT = (short)'╕',

            // Your snake tail (end) when snake is inactive.

        TAIL_INACTIVE = (short)'~',

            // Enemy snake head pointing down.

        ENEMY_HEAD_DOWN = (short)'˅',

            // Enemy snake head pointing left.

        ENEMY_HEAD_LEFT = (short)'<',

            // Enemy snake head pointing right.

        ENEMY_HEAD_RIGHT = (short)'>',

            // Enemy snake head pointing up.

        ENEMY_HEAD_UP = (short)'˄',

            // Enemy snake is dead.

        ENEMY_HEAD_DEAD = (short)'☺',

            // Enemy snake head under influence Fury pill/Devils mask.

        ENEMY_HEAD_EVIL = (short)'♣',

            // Enemy snake head under influence Flying pill/Angels wings.

        ENEMY_HEAD_FLY = (short)'♦',

            // Enemy snake head when snake is inactive.

        ENEMY_HEAD_SLEEP = (short)'ø',

            // Body of enemy snake is directed horizontally.

        ENEMY_BODY_HORIZONTAL = (short)'─',

            // Body of enemy snake is directed vertically.

        ENEMY_BODY_VERTICAL = (short)'│',

            // Turning enemy snake body from left to down.

        ENEMY_BODY_LEFT_DOWN = (short)'┐',

            // Turning enemy snake body from left to up.

        ENEMY_BODY_LEFT_UP = (short)'┘',

            // Turning enemy snake body from right to down.

        ENEMY_BODY_RIGHT_DOWN = (short)'┌',

            // Turning enemy snake body from left to up.

        ENEMY_BODY_RIGHT_UP = (short)'└',

            // Enemy snake tail (end) pointing down.

        ENEMY_TAIL_END_DOWN = (short)'¤',

            // Enemy snake tail (end) pointing left.

        ENEMY_TAIL_END_LEFT = (short)'×',

            // Enemy snake tail (end) pointing up.

        ENEMY_TAIL_END_UP = (short)'æ',

            // Enemy snake tail (end) pointing right.

        ENEMY_TAIL_END_RIGHT = (short)'ö',

            // Enemy snake tail (end) when snake is inactive.

        ENEMY_TAIL_INACTIVE = (short)'*'
    }
}


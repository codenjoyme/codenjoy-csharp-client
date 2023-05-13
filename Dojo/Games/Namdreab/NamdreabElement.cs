/*-
 * #%L
 * Codenjoy - it's a dojo-like platform from developers to developers.
 * %%
 * Copyright (C) 2012 - 2022 Codenjoy
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

namespace Dojo.Games.Namdreab
{
    public enum NamdreabElement : short
    {

            // Empty space - space where the hero can move.

        NONE = (short)' ',

            // Impenetrable rock.

        ROCK = (short)'☼',

            // Respawn point from which the hero starts its movement.

        START_SPOT = (short)'#',

            // Blueberry.

        BLUEBERRY = (short)'○',

            // Acorn.

        ACORN = (short)'●',

            // Death cap. Brings the player into flight mode, which gives
            // him the ability to avoid obstacles.

        DEATH_CAP = (short)'©',

            // Fly agaric. Brings the player into a fury, which gives him
            // an advantage when clashing.

        FLY_AGARIC = (short)'®',

            // Strawberry.

        STRAWBERRY = (short)'$',

            // Your hero head pointing down.

        HEAD_DOWN = (short)'▼',

            // Your hero head pointing left.

        HEAD_LEFT = (short)'◄',

            // Your hero head pointing right.

        HEAD_RIGHT = (short)'►',

            // Your hero head pointing up.

        HEAD_UP = (short)'▲',

            // Your hero is dead.

        HEAD_DEAD = (short)'☻',

            // Your hero head under influence fly agaric.

        HEAD_EVIL = (short)'♥',

            // Your hero head under influence death cap.

        HEAD_FLY = (short)'♠',

            // Your hero head when hero is inactive.

        HEAD_SLEEP = (short)'&',

            // Body of your hero is directed horizontally.

        BODY_HORIZONTAL = (short)'═',

            // Body of your hero is directed vertically.

        BODY_VERTICAL = (short)'║',

            // Turning your hero body from left to down.

        BODY_LEFT_DOWN = (short)'╗',

            // Turning your hero body from left to up.

        BODY_LEFT_UP = (short)'╝',

            // Turning your hero body from right to down.

        BODY_RIGHT_DOWN = (short)'╔',

            // Turning your hero body from left to up.

        BODY_RIGHT_UP = (short)'╚',

            // Your hero tail (end) pointing down.

        TAIL_END_DOWN = (short)'╙',

            // Your hero tail (end) pointing left.

        TAIL_END_LEFT = (short)'╘',

            // Your hero tail (end) pointing up.

        TAIL_END_UP = (short)'╓',

            // Your hero tail (end) pointing right.

        TAIL_END_RIGHT = (short)'╕',

            // Your hero tail (end) when hero is inactive.

        TAIL_INACTIVE = (short)'~',

            // Enemy hero head pointing down.

        ENEMY_HEAD_DOWN = (short)'˅',

            // Enemy hero head pointing left.

        ENEMY_HEAD_LEFT = (short)'<',

            // Enemy hero head pointing right.

        ENEMY_HEAD_RIGHT = (short)'>',

            // Enemy hero head pointing up.

        ENEMY_HEAD_UP = (short)'˄',

            // Enemy hero is dead.

        ENEMY_HEAD_DEAD = (short)'☺',

            // Enemy hero head under influence fly agaric.

        ENEMY_HEAD_EVIL = (short)'♣',

            // Enemy hero head under influence death cap.

        ENEMY_HEAD_FLY = (short)'♦',

            // Enemy hero head when hero is inactive.

        ENEMY_HEAD_SLEEP = (short)'ø',

            // Body of enemy hero is directed horizontally.

        ENEMY_BODY_HORIZONTAL = (short)'─',

            // Body of enemy hero is directed vertically.

        ENEMY_BODY_VERTICAL = (short)'│',

            // Turning enemy hero body from left to down.

        ENEMY_BODY_LEFT_DOWN = (short)'┐',

            // Turning enemy hero body from left to up.

        ENEMY_BODY_LEFT_UP = (short)'┘',

            // Turning enemy hero body from right to down.

        ENEMY_BODY_RIGHT_DOWN = (short)'┌',

            // Turning enemy hero body from left to up.

        ENEMY_BODY_RIGHT_UP = (short)'└',

            // Enemy hero tail (end) pointing down.

        ENEMY_TAIL_END_DOWN = (short)'¤',

            // Enemy hero tail (end) pointing left.

        ENEMY_TAIL_END_LEFT = (short)'×',

            // Enemy hero tail (end) pointing up.

        ENEMY_TAIL_END_UP = (short)'æ',

            // Enemy hero tail (end) pointing right.

        ENEMY_TAIL_END_RIGHT = (short)'ö',

            // Enemy hero tail (end) when hero is inactive.

        ENEMY_TAIL_INACTIVE = (short)'*'
    }
}


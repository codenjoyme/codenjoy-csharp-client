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

            // Impassable obstacle.

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

            // Your hero is pointing down.

        HERO_DOWN = (short)'▼',

            // Your hero is pointing left.

        HERO_LEFT = (short)'◄',

            // Your hero is pointing right.

        HERO_RIGHT = (short)'►',

            // Your hero is pointing up.

        HERO_UP = (short)'▲',

            // Your hero is dead.

        HERO_DEAD = (short)'☻',

            // Your hero is influenced by Fly agaric.

        HERO_EVIL = (short)'♥',

            // Your hero is influenced by Death cap.

        HERO_FLY = (short)'♠',

            // Your hero when inactive.

        HERO_SLEEP = (short)'&',

            // Your hero's beard is directed horizontally.

        HERO_BEARD_HORIZONTAL = (short)'═',

            // Your hero's beard is directed vertically.

        HERO_BEARD_VERTICAL = (short)'║',

            // Turning your hero's beard from left to down.

        HERO_BEARD_LEFT_DOWN = (short)'╗',

            // Turning your hero's beard from left to up.

        HERO_BEARD_LEFT_UP = (short)'╝',

            // Turning your hero's beard from right to down.

        HERO_BEARD_RIGHT_DOWN = (short)'╔',

            // Turning your hero's beard from left to up.

        HERO_BEARD_RIGHT_UP = (short)'╚',

            // Tail of your hero's beard that points to the down.

        HERO_TAIL_DOWN = (short)'╙',

            // Tail of your hero's beard that points to the left.

        HERO_TAIL_LEFT = (short)'╘',

            // Tail of your hero's beard that points to the up.

        HERO_TAIL_UP = (short)'╓',

            // Tail of your hero's beard that points to the right.

        HERO_TAIL_RIGHT = (short)'╕',

            // Tail of your hero's beard when inactive.

        HERO_TAIL_INACTIVE = (short)'~',

            // Enemy hero is pointing down.

        ENEMY_HERO_DOWN = (short)'˅',

            // Enemy hero is pointing left.

        ENEMY_HERO_LEFT = (short)'<',

            // Enemy hero is pointing right.

        ENEMY_HERO_RIGHT = (short)'>',

            // Enemy hero is pointing up.

        ENEMY_HERO_UP = (short)'˄',

            // Enemy hero is dead.

        ENEMY_HERO_DEAD = (short)'☺',

            // Enemy hero is influenced by Fly agaric.

        ENEMY_HERO_EVIL = (short)'♣',

            // Enemy hero is influenced by Death cap.

        ENEMY_HERO_FLY = (short)'♦',

            // Enemy hero when inactive.

        ENEMY_HERO_SLEEP = (short)'ø',

            // Enemy hero's beard is directed horizontally.

        ENEMY_HERO_BEARD_HORIZONTAL = (short)'─',

            // Enemy hero's beard is directed vertically.

        ENEMY_HERO_BEARD_VERTICAL = (short)'│',

            // Turning enemy hero's beard from left to down.

        ENEMY_HERO_BEARD_LEFT_DOWN = (short)'┐',

            // Turning enemy hero's beard from left to up.

        ENEMY_HERO_BEARD_LEFT_UP = (short)'┘',

            // Turning enemy hero's beard from right to down.

        ENEMY_HERO_BEARD_RIGHT_DOWN = (short)'┌',

            // Turning enemy hero's beard from left to up.

        ENEMY_HERO_BEARD_RIGHT_UP = (short)'└',

            // Tail of enemy hero's beard that points to the down.

        ENEMY_HERO_TAIL_DOWN = (short)'¤',

            // Tail of enemy hero's beard that points to the left.

        ENEMY_HERO_TAIL_LEFT = (short)'×',

            // Tail of enemy hero's beard that points to the up.

        ENEMY_HERO_TAIL_UP = (short)'æ',

            // Tail of enemy hero's beard that points to the right.

        ENEMY_HERO_TAIL_RIGHT = (short)'ö',

            // Tail of enemy hero's beard when inactive.

        ENEMY_HERO_TAIL_INACTIVE = (short)'*'
    }
}


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

namespace Dojo.Games.Expansion
{
    public enum ExpansionElement : short
    {

            // Empty space (at layer 2) where player can go.

        EMPTY = (short)'-',

            // Empty space (at layer 1) where player can go.

        FLOOR = (short)'.',

            // Wall.

        ANGLE_IN_LEFT = (short)'╔',

            // Wall.

        WALL_FRONT = (short)'═',

            // Wall.

        ANGLE_IN_RIGHT = (short)'┐',

            // Wall.

        WALL_RIGHT = (short)'│',

            // Wall.

        ANGLE_BACK_RIGHT = (short)'┘',

            // Wall.

        WALL_BACK = (short)'─',

            // Wall.

        ANGLE_BACK_LEFT = (short)'└',

            // Wall.

        WALL_LEFT = (short)'║',

            // Wall.

        WALL_BACK_ANGLE_LEFT = (short)'┌',

            // Wall.

        WALL_BACK_ANGLE_RIGHT = (short)'╗',

            // Wall.

        ANGLE_OUT_RIGHT = (short)'╝',

            // Wall.

        ANGLE_OUT_LEFT = (short)'╚',

            // Wall.

        SPACE = (short)' ',

            // Forces of player 1.

        FORCE1 = (short)'♥',

            // Forces of player 2.

        FORCE2 = (short)'♦',

            // Forces of player 3.

        FORCE3 = (short)'♣',

            // Forces of player 4.

        FORCE4 = (short)'♠',

            // Exit.

        EXIT = (short)'E',

            // Hole.

        HOLE = (short)'O',

            // Unpassable break.

        BREAK = (short)'B',

            // Gold.

        GOLD = (short)'$',

            // Base of player 1.

        BASE1 = (short)'1',

            // Base of player 2.

        BASE2 = (short)'2',

            // Base of player 3.

        BASE3 = (short)'3',

            // Base of player 4.

        BASE4 = (short)'4',

            // Fog of war system layer.

        FOG = (short)'F',

            // Background system layer.

        BACKGROUND = (short)'G'
    }
}


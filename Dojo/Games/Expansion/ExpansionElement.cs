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

namespace Dojo.Games.Expansion
{
    public enum ExpansionElement : short
    {

        EMPTY = (short)'-',

        FLOOR = (short)'.',

        ANGLE_IN_LEFT = (short)'╔',

        WALL_FRONT = (short)'═',

        ANGLE_IN_RIGHT = (short)'┐',

        WALL_RIGHT = (short)'│',

        ANGLE_BACK_RIGHT = (short)'┘',

        WALL_BACK = (short)'─',

        ANGLE_BACK_LEFT = (short)'└',

        WALL_LEFT = (short)'║',

        WALL_BACK_ANGLE_LEFT = (short)'┌',

        WALL_BACK_ANGLE_RIGHT = (short)'╗',

        ANGLE_OUT_RIGHT = (short)'╝',

        ANGLE_OUT_LEFT = (short)'╚',

        SPACE = (short)' ',

        FORCE1 = (short)'♥',

        FORCE2 = (short)'♦',

        FORCE3 = (short)'♣',

        FORCE4 = (short)'♠',

        EXIT = (short)'E',

        HOLE = (short)'O',

        BREAK = (short)'B',

        GOLD = (short)'$',

        BASE1 = (short)'1',

        BASE2 = (short)'2',

        BASE3 = (short)'3',

        BASE4 = (short)'4',

        FOG = (short)'F',

        BACKGROUND = (short)'G'
    }
}


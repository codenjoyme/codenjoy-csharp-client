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

namespace Dojo.Games.Excitebike
{
    public enum ExcitebikeElement : short
    {

        NONE = (short)' ',

        FENCE = (short)'■',

        ACCELERATOR = (short)'>',

        INHIBITOR = (short)'<',

        OBSTACLE = (short)'|',

        LINE_CHANGER_UP = (short)'▲',

        LINE_CHANGER_DOWN = (short)'▼',

        SPRINGBOARD_LEFT_UP = (short)'╔',

        SPRINGBOARD_LEFT = (short)'ˊ',

        SPRINGBOARD_LEFT_DOWN = (short)'╚',

        SPRINGBOARD_TOP = (short)'═',

        SPRINGBOARD_RIGHT_UP = (short)'╗',

        SPRINGBOARD_RIGHT = (short)'ˋ',

        SPRINGBOARD_RIGHT_DOWN = (short)'╝',

        BIKE = (short)'B',

        BIKE_AT_ACCELERATOR = (short)'A',

        BIKE_AT_INHIBITOR = (short)'I',

        BIKE_AT_LINE_CHANGER_UP = (short)'U',

        BIKE_AT_LINE_CHANGER_DOWN = (short)'D',

        BIKE_AT_KILLED_BIKE = (short)'K',

        BIKE_AT_SPRINGBOARD_LEFT = (short)'L',

        BIKE_AT_SPRINGBOARD_LEFT_DOWN = (short)'M',

        BIKE_AT_SPRINGBOARD_RIGHT = (short)'R',

        BIKE_AT_SPRINGBOARD_RIGHT_DOWN = (short)'S',

        BIKE_IN_FLIGHT_FROM_SPRINGBOARD = (short)'F',

        BIKE_FALLEN = (short)'b',

        BIKE_FALLEN_AT_ACCELERATOR = (short)'a',

        BIKE_FALLEN_AT_INHIBITOR = (short)'i',

        BIKE_FALLEN_AT_LINE_CHANGER_UP = (short)'u',

        BIKE_FALLEN_AT_LINE_CHANGER_DOWN = (short)'d',

        BIKE_FALLEN_AT_FENCE = (short)'f',

        BIKE_FALLEN_AT_OBSTACLE = (short)'o',

        OTHER_BIKE = (short)'Ḃ',

        OTHER_BIKE_AT_ACCELERATOR = (short)'Ā',

        OTHER_BIKE_AT_INHIBITOR = (short)'Ī',

        OTHER_BIKE_AT_LINE_CHANGER_UP = (short)'Ū',

        OTHER_BIKE_AT_LINE_CHANGER_DOWN = (short)'Ď',

        OTHER_BIKE_AT_KILLED_BIKE = (short)'Ḱ',

        OTHER_BIKE_AT_SPRINGBOARD_LEFT = (short)'Ĺ',

        OTHER_BIKE_AT_SPRINGBOARD_LEFT_DOWN = (short)'Ṁ',

        OTHER_BIKE_AT_SPRINGBOARD_RIGHT = (short)'Ř',

        OTHER_BIKE_AT_SPRINGBOARD_RIGHT_DOWN = (short)'Ŝ',

        OTHER_BIKE_IN_FLIGHT_FROM_SPRINGBOARD = (short)'Ḟ',

        OTHER_BIKE_FALLEN = (short)'ḃ',

        OTHER_BIKE_FALLEN_AT_ACCELERATOR = (short)'ā',

        OTHER_BIKE_FALLEN_AT_INHIBITOR = (short)'ī',

        OTHER_BIKE_FALLEN_AT_LINE_CHANGER_UP = (short)'ū',

        OTHER_BIKE_FALLEN_AT_LINE_CHANGER_DOWN = (short)'ď',

        OTHER_BIKE_FALLEN_AT_FENCE = (short)'ḟ',

        OTHER_BIKE_FALLEN_AT_OBSTACLE = (short)'ō'
    }
}


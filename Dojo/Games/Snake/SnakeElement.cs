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

namespace Dojo.Games.Snake
{
    public enum SnakeElement : short
    {

            // Stone.

        BAD_APPLE = (short)'☻',

            // Having eaten it, you shorten it in length. If it is not long
            // enough, you die.

        GOOD_APPLE = (short)'☺',

            // An obstacle that cannot be passed. It is also the border of
            // the field.

        BREAK = (short)'☼',

            // An empty place in the field where the snake can go.

        NONE = (short)' ',

            // Snake head is pointing down.

        HEAD_DOWN = (short)'▼',

            // Snake head is pointing left.

        HEAD_LEFT = (short)'◄',

            // Snake head is pointing right.

        HEAD_RIGHT = (short)'►',

            // Snake head is pointing up.

        HEAD_UP = (short)'▲',

            // Horizontal part of the body.

        TAIL_HORIZONTAL = (short)'═',

            // Vertical part of the body.

        TAIL_VERTICAL = (short)'║',

            // Turning the snake body from left to down.

        TAIL_LEFT_DOWN = (short)'╗',

            // Turning the snake body from left to up.

        TAIL_LEFT_UP = (short)'╝',

            // Turning the snake body from right to down.

        TAIL_RIGHT_DOWN = (short)'╔',

            // Turning the snake body from right to up.

        TAIL_RIGHT_UP = (short)'╚',

            // Down tail.

        TAIL_END_DOWN = (short)'╙',

            // Left tail.

        TAIL_END_LEFT = (short)'╘',

            // Up tail.

        TAIL_END_UP = (short)'╓',

            // Right tail.

        TAIL_END_RIGHT = (short)'╕'
    }
}


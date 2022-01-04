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

namespace Dojo.Games.Moebius
{
    public enum MoebiusElement : short
    {

            // Труба повернута слева вверх.

        LEFT_UP = (short)'╝',

            // Труба повернута сверху направо.

        UP_RIGHT = (short)'╚',

            // Труба повернута справа вниз.

        RIGHT_DOWN = (short)'╔',

            // Труба повернута снизу влево.

        DOWN_LEFT = (short)'╗',

            // Прямая труба слева направо.

        LEFT_RIGHT = (short)'═',

            // Прямая труба сверху вниз.

        UP_DOWN = (short)'║',

            // Две пересеченные прямые трубы, одна сверху вниз, другая
            // слева направо.

        CROSS = (short)'╬',

            // Пустое место на поле.

        EMPTY = (short)' '
    }
}


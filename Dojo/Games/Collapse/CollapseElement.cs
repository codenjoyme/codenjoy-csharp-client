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

namespace Dojo.Games.Collapse
{
    public enum CollapseElement : short
    {

            // Пустое место – место которое заполнится фишкой в следующий
            // тик.

        NONE = (short)' ',

            // Граница поля, в игре не участвует (не перемещается).

        BORDER = (short)'☼',

            // Перемещаемая фишка 1.

        ONE = (short)'1',

            // Перемещаемая фишка 2.

        TWO = (short)'2',

            // Перемещаемая фишка 3.

        THREE = (short)'3',

            // Перемещаемая фишка 4.

        FOUR = (short)'4',

            // Перемещаемая фишка 5.

        FIVE = (short)'5',

            // Перемещаемая фишка 6.

        SIX = (short)'6',

            // Перемещаемая фишка 7.

        SEVEN = (short)'7',

            // Перемещаемая фишка 8.

        EIGHT = (short)'8',

            // Перемещаемая фишка 9.

        NINE = (short)'9'
    }
}


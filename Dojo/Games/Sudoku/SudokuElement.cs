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

namespace Dojo.Games.Sudoku
{
    public enum SudokuElement : short
    {

            // Пустое место – циферку в котором предстоит отгадать.

        NONE = (short)' ',

            // Граница, проигнорируй ее - она не учитывается в координатах.

        BORDER = (short)'☼',

            // Если число не отображается на поле.

        HIDDEN = (short)'*',

            // Цифра 1.

        ONE = (short)'1',

            // Цифра 2.

        TWO = (short)'2',

            // Цифра 3.

        THREE = (short)'3',

            // Цифра 4.

        FOUR = (short)'4',

            // Цифра 5.

        FIVE = (short)'5',

            // Цифра 6.

        SIX = (short)'6',

            // Цифра 7.

        SEVEN = (short)'7',

            // Цифра 8.

        EIGHT = (short)'8',

            // Цифра 9.

        NINE = (short)'9'
    }
}


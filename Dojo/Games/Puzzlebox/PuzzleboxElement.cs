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

namespace Dojo.Games.Puzzlebox
{
    public enum PuzzleboxElement : short
    {

            // Пустое место – по которому может двигаться герой.

        NONE = (short)' ',

            // Стена через которую герою пройти нельзя.

        WALL = (short)'☼',

            // Твой герой.

        HERO = (short)'☺',

            // Коробка, которую можно передвинуть.

        BOX = (short)'#',

            // Коробка, которую ты передвигаешь в данный момент.

        CURBOX = (short)'1',

            // Место куда нужно доставить коробку.

        FILEDBOX = (short)'@',

            // Место для коробки в котором уже находится оная.

        TARGET = (short)'0'
    }
}


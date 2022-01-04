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

namespace Dojo.Games.Hex
{
    public enum HexElement : short
    {

            // Пустое поле на карте. Сюда можно перемещать свои войска.

        NONE = (short)' ',

            // Непроходимое препятствие. Обычно граница поля, но может
            // появиться в месте, куда два героя одновременно отправят вои
            // войска.

        WALL = (short)'☼',

            // Твои войска.

        MY_HERO = (short)'☺',

            // Войска противника 1.

        HERO1 = (short)'☻',

            // Войска противника 2.

        HERO2 = (short)'♥',

            // Войска противника 3.

        HERO3 = (short)'♦',

            // Войска противника 4.

        HERO4 = (short)'♣',

            // Войска противника 5.

        HERO5 = (short)'♠',

            // Войска противника 6.

        HERO6 = (short)'•',

            // Войска противника 7.

        HERO7 = (short)'◘',

            // Войска противника 8.

        HERO8 = (short)'○',

            // Войска противника 9.

        HERO9 = (short)'◙',

            // Войска противника 10.

        HERO10 = (short)'♂',

            // Войска противника 11.

        HERO11 = (short)'♀'
    }
}


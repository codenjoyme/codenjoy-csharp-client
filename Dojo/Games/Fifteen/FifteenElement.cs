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

namespace Dojo.Games.Fifteen
{
    public enum FifteenElement : short
    {

            // Фишка 1. Герой ее может переместить на свое место.

        A = (short)'a',

            // Фишка 2.

        B = (short)'b',

            // Фишка 3.

        C = (short)'c',

            // Фишка 4.

        D = (short)'d',

            // Фишка 5.

        E = (short)'e',

            // Фишка 6.

        F = (short)'f',

            // Фишка 7.

        G = (short)'g',

            // Фишка 8.

        H = (short)'h',

            // Фишка 9.

        I = (short)'i',

            // Фишка 10.

        J = (short)'j',

            // Фишка 11.

        K = (short)'k',

            // Фишка 12.

        L = (short)'l',

            // Фишка 13.

        M = (short)'m',

            // Фишка 14.

        N = (short)'n',

            // Фишка 15.

        O = (short)'o',

            // Твой герой. Герой перемещает фишки меняясь с ними местами.

        HERO = (short)'+',

            // Стена. Препятствие для перемещения фишек.

        WALL = (short)'*'
    }
}


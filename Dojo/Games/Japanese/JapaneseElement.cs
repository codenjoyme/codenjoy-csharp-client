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

namespace Dojo.Games.Japanese
{
    public enum JapaneseElement : short
    {

            // Игрок утверждает, что пиксель белый.

        WHITE = (short)'-',

            // Игрок утверждает, что пиксель черный.

        BLACK = (short)'*',

            // Игрок пока не определился, какого цвета этот пиксель.

        UNSET = (short)' ',

            // Пустое место в полое для цифр.

        NAN = (short)'.',

            // Блок отсутствует.

        _0 = (short)'0',

            // Блок длинной в 1 пиксель.

        _1 = (short)'1',

            // Блок длинной в 2 пикселя.

        _2 = (short)'2',

            // Блок длинной в 3 пикселя.

        _3 = (short)'3',

            // Блок длинной в 4 пикселя.

        _4 = (short)'4',

            // Блок длинной в 5 пикселей.

        _5 = (short)'5',

            // Блок длинной в 6 пикселей.

        _6 = (short)'6',

            // Блок длинной в 7 пикселей.

        _7 = (short)'7',

            // Блок длинной в 8 пикселей.

        _8 = (short)'8',

            // Блок длинной в 9 пикселей.

        _9 = (short)'9',

            // Блок длинной в 10 пикселей.

        _10 = (short)'a',

            // Блок длинной в 11 пикселей.

        _11 = (short)'b',

            // Блок длинной в 12 пикселей.

        _12 = (short)'c',

            // Блок длинной в 13 пикселей.

        _13 = (short)'d',

            // Блок длинной в 14 пикселей.

        _14 = (short)'e',

            // Блок длинной в 15 пикселей.

        _15 = (short)'f',

            // Блок длинной в 16 пикселей.

        _16 = (short)'g',

            // Блок длинной в 17 пикселей.

        _17 = (short)'h',

            // Блок длинной в 18 пикселей.

        _18 = (short)'i',

            // Блок длинной в 19 пикселей.

        _19 = (short)'j',

            // Блок длинной в 20 пикселей.

        _20 = (short)'k',

            // Блок длинной в 21 пиксель.

        _21 = (short)'l',

            // Блок длинной в 22 пикселя.

        _22 = (short)'m',

            // Блок длинной в 23 пикселя.

        _23 = (short)'n',

            // Блок длинной в 24 пикселя.

        _24 = (short)'o',

            // Блок длинной в 25 пикселей.

        _25 = (short)'p',

            // Блок длинной в 26 пикселей.

        _26 = (short)'q',

            // Блок длинной в 27 пикселей.

        _27 = (short)'r',

            // Блок длинной в 28 пикселей.

        _28 = (short)'s',

            // Блок длинной в 29 пикселей.

        _29 = (short)'t',

            // Блок длинной в 30 пикселей.

        _30 = (short)'u',

            // Блок длинной в 31 пиксель.

        _31 = (short)'v',

            // Блок длинной в 32 пикселя.

        _32 = (short)'w',

            // Блок длинной в 33 пикселя.

        _33 = (short)'x',

            // Блок длинной в 34 пикселя.

        _34 = (short)'y',

            // Блок длинной в 35 пикселей.

        _35 = (short)'z',

            // Блок длинной в 36 пикселей.

        _36 = (short)'A',

            // Блок длинной в 37 пикселей.

        _37 = (short)'B',

            // Блок длинной в 38 пикселей.

        _38 = (short)'C',

            // Блок длинной в 39 пикселей.

        _39 = (short)'D',

            // Блок длинной в 40 пикселей.

        _40 = (short)'E',

            // Блок длинной в 41 пиксель.

        _41 = (short)'F',

            // Блок длинной в 42 пикселя.

        _42 = (short)'G',

            // Блок длинной в 43 пикселя.

        _43 = (short)'H',

            // Блок длинной в 44 пикселя.

        _44 = (short)'I',

            // Блок длинной в 45 пикселей.

        _45 = (short)'J',

            // Блок длинной в 46 пикселей.

        _46 = (short)'K',

            // Блок длинной в 47 пикселей.

        _47 = (short)'L',

            // Блок длинной в 48 пикселей.

        _48 = (short)'M',

            // Блок длинной в 49 пикселей.

        _49 = (short)'N',

            // Блок длинной в 50 пикселей.

        _50 = (short)'O',

            // Блок длинной в 51 пиксель.

        _51 = (short)'P',

            // Блок длинной в 52 пикселя.

        _52 = (short)'Q',

            // Блок длинной в 53 пикселя.

        _53 = (short)'R',

            // Блок длинной в 54 пикселя.

        _54 = (short)'S',

            // Блок длинной в 55 пикселей.

        _55 = (short)'T',

            // Блок длинной в 56 пикселей.

        _56 = (short)'U',

            // Блок длинной в 57 пикселей.

        _57 = (short)'V',

            // Блок длинной в 58 пикселей.

        _58 = (short)'W',

            // Блок длинной в 59 пикселей.

        _59 = (short)'X',

            // Блок длинной в 60 пикселей.

        _60 = (short)'Y',

            // Блок длинной в 61 пиксель.

        _61 = (short)'Z'
    }
}


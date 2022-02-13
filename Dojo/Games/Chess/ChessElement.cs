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

namespace Dojo.Games.Chess
{
    public enum ChessElement : short
    {

            // Поле.

        SQUARE = (short)'.',

            // Препятствие для фигур.

        BARRIER = (short)' ',

            // Король белых.

        WHITE_KING = (short)'W',

            // Ферзь белых.

        WHITE_QUEEN = (short)'Q',

            // Ладья белых.

        WHITE_ROOK = (short)'R',

            // Слон белых.

        WHITE_BISHOP = (short)'B',

            // Конь белых.

        WHITE_KNIGHT = (short)'K',

            // Пешка белых.

        WHITE_PAWN = (short)'P',

            // Король черных.

        BLACK_KING = (short)'w',

            // Ферзь черных.

        BLACK_QUEEN = (short)'q',

            // Ладья черных.

        BLACK_ROOK = (short)'r',

            // Слон черных.

        BLACK_BISHOP = (short)'b',

            // Конь черных.

        BLACK_KNIGHT = (short)'k',

            // Пешка черных.

        BLACK_PAWN = (short)'p',

            // Король красных.

        RED_KING = (short)'Y',

            // Ферзь красных.

        RED_QUEEN = (short)'X',

            // Ладья красных.

        RED_ROOK = (short)'I',

            // Слон красных.

        RED_BISHOP = (short)'G',

            // Конь красных.

        RED_KNIGHT = (short)'L',

            // Пешка красных.

        RED_PAWN = (short)'Z',

            // Король синих.

        BLUE_KING = (short)'y',

            // Ферзь синих.

        BLUE_QUEEN = (short)'x',

            // Ладья синих.

        BLUE_ROOK = (short)'i',

            // Слон синих.

        BLUE_BISHOP = (short)'g',

            // Конь синих.

        BLUE_KNIGHT = (short)'l',

            // Пешка синих.

        BLUE_PAWN = (short)'z',

            // Изображение шахматной доски (фон).

        BACKGROUND = (short)'-'
    }
}


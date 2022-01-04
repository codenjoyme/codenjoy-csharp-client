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

namespace Dojo.Games.Rubicscube
{
    public enum RubicscubeElement : short
    {

            // Пустое место на поле, не обращай на него внимания.

        NONE = (short)' ',

            // Красная грань.

        RED = (short)'R',

            // Зеленая грань.

        GREEN = (short)'G',

            // Синяя грань.

        BLUE = (short)'B',

            // Белая грань.

        WHITE = (short)'W',

            // Желтая грань.

        YELLOW = (short)'Y',

            // Оранжевая грань.

        ORANGE = (short)'O'
    }
}


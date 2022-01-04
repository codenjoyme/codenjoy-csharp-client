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

namespace Dojo.Games.Xonix
{
    public enum XonixElement : short
    {

            // Море, где живут морские враги. Море нужно делать сушей.

        SEA = (short)'.',

            // Ничейная суша, по которой можно передвигаться героям и
            // наземным врагам.

        LAND = (short)'X',

            // Твой герой.

        HERO = (short)'O',

            // Захваченная тобой суша.

        HERO_LAND = (short)'#',

            // След, который оставляет герой двигаясь по морю или по сушам
            // противника. Уязвим для морских врагов. После выхода героя на
            // сушу, море (и/или суша другого противника), очерченное
            // следом, превращается в сушу.

        HERO_TRACE = (short)'o',

            // Герой противника.

        HOSTILE = (short)'A',

            // Захваченные противниками суша.

        HOSTILE_LAND = (short)'@',

            // След, оставляемые противником во время захвата суши.

        HOSTILE_TRACE = (short)'a',

            // Морской враг.

        MARINE_ENEMY = (short)'M',

            // Сухопутный враг.

        LAND_ENEMY = (short)'L'
    }
}


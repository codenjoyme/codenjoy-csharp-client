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

namespace Dojo.Games.Selfdefense
{
    public enum SelfdefenseElement : short
    {

            // Пустое место в космосе. Сюда может переместиться корабль.

        NONE = (short)' ',

            // Инопланетянин. Атакует всех.

        ENEMY = (short)'X',

            // Твоя база. Ее нужно защищать.

        BASE = (short)'☺',

            // Твой корабль.

        SPACESHIP = (short)'.',

            // Твоя платформа.

        PLATFORM = (short)'=',

            // Защитники твоей базы. Выносят вначале их, потом саму базу.

        GUARD = (short)'+',

            // Базы твоих противников.

        OTHER_BASE = (short)'☻',

            // Корабли противников.

        OTHER_SPACESHIP = (short)',',

            // Платформы противников.

        OTHER_PLATFORM = (short)'-',

            // Защитники баз противников.

        OTHER_GUARD = (short)'*',

            // Туман войны.

        FOG = (short)'F',

            // Космос.

        BACKGROUND = (short)'G'
    }
}


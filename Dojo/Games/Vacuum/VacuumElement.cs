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

namespace Dojo.Games.Vacuum
{
    public enum VacuumElement : short
    {

            // Чистая клетка локации. Проезд облагается штрафом.
            // Эффективный пылесос должен меньше гулять по чистым местам и
            // больше убираться.

        NONE = (short)' ',

            // Сам робот-пылесос.

        VACUUM = (short)'O',

            // Стартовая точка робота-пылесоса на уровне.

        START = (short)'S',

            // Барьер, через который нельзя проехать.

        BARRIER = (short)'#',

            // Грязь/пыль, которую нужно очистить для того, чтобы пройти
            // уровень.

        DUST = (short)'*',

            // Переключатель движения влево. Заехать можно с любой стороны.
            // Автоматически поворачивает робота в сторону, в которую
            // указывает.

        SWITCH_LEFT = (short)'←',

            // Переключатель движения вправо. Заехать можно с любой
            // стороны. Автоматически поворачивает робота в сторону, в
            // которую указывает.

        SWITCH_RIGHT = (short)'→',

            // Переключатель движения вверх. Заехать можно с любой стороны.
            // Автоматически поворачивает робота в сторону, в которую
            // указывает.

        SWITCH_UP = (short)'↑',

            // Переключатель движения вниз. Заехать можно с любой стороны.
            // Автоматически поворачивает робота в сторону, в которую
            // указывает.

        SWITCH_DOWN = (short)'↓',

            // Ограничитель въезда. Заехать можно только слева. Выезжать с
            // ограничителя можно в любом направлении.

        LIMITER_LEFT = (short)'╡',

            // Ограничитель въезда. Заехать можно только справа. Выезжать с
            // ограничителя можно в любом направлении.

        LIMITER_RIGHT = (short)'╞',

            // Ограничитель въезда. Заехать можно только сверху. Выезжать с
            // ограничителя можно в любом направлении.

        LIMITER_UP = (short)'╨',

            // Ограничитель въезда. Заехать можно только снизу. Выезжать с
            // ограничителя можно в любом направлении.

        LIMITER_DOWN = (short)'╥',

            // Ограничитель въезда. Заехать можно как сверху, так и снизу.
            // Выезжать с ограничителя можно в любом направлении.

        LIMITER_VERTICAL = (short)'║',

            // Ограничитель въезда. Заехать можно как слева, так и справа.
            // Выезжать с ограничителя можно в любом направлении.

        LIMITER_HORIZONTAL = (short)'═',

            // Карусель. Работает одновременно и как переключатель движения
            // и как ограничитель въезда. Заехать можно слева или сверху,
            // повернет робота наверх или налево соответственно. После
            // проезда карусель поворачиваются по часовой стрелке.

        ROUNDABOUT_LEFT_UP = (short)'┘',

            // Карусель. Работает одновременно и как переключатель движения
            // и как ограничитель въезда. Заехать можно сверху или справа,
            // повернет робота направо или наверх соответственно. После
            // проезда карусель поворачиваются по часовой стрелке.

        ROUNDABOUT_UP_RIGHT = (short)'└',

            // Карусель. Работает одновременно и как переключатель движения
            // и как ограничитель въезда. Заехать можно справа или снизу,
            // повернет робота вниз или направо соответственно. После
            // проезда карусель поворачиваются по часовой стрелке.

        ROUNDABOUT_RIGHT_DOWN = (short)'┌',

            // Карусель. Работает одновременно и как переключатель движения
            // и как ограничитель въезда. Заехать можно снизу или слева,
            // повернет робота налево или вниз соответственно. После
            // проезда карусель поворачиваются по часовой стрелке.

        ROUNDABOUT_DOWN_LEFT = (short)'┐'
    }
}


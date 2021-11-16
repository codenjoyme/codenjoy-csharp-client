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

namespace Dojo.Games.Football
{
    public enum FootballElement : short
    {

            // Пустое место, куда можно перейти игроку.

        NONE = (short)' ',

            // Внешняя разметка поля, через которую нельзя пройти.

        WALL = (short)'☼',

            // Твой игроку.

        HERO = (short)'☺',

            // Игрок с мячом.

        HERO_W_BALL = (short)'☻',

            // Мяч в движении.

        BALL = (short)'*',

            // Мяч остановился.

        STOPPED_BALL = (short)'∙',

            // Верхние ворота.

        TOP_GOAL = (short)'┴',

            // Нижние ворота.

        BOTTOM_GOAL = (short)'┬',

            // Твои ворота.

        MY_GOAL = (short)'=',

            // Чужие ворота.

        ENEMY_GOAL = (short)'⌂',

            // Гол в ворота.

        HITED_GOAL = (short)'x',

            // Гол в твои ворота.

        HITED_MY_GOAL = (short)'#',

            // Игрок твоей команды.

        TEAM_MEMBER = (short)'♦',

            // Игрок твоей команды с мячем.

        TEAM_MEMBER_W_BALL = (short)'♥',

            // Игрок команды противников.

        ENEMY = (short)'♣',

            // Игрок команды противников с мячем.

        ENEMY_W_BALL = (short)'♠'
    }
}


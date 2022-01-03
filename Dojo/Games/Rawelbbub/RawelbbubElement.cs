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

namespace Dojo.Games.Rawelbbub
{
    public enum RawelbbubElement : short
    {

            // An empty space where hero can move.

        WATER = (short)' ',

            // Underwater reefs. They cannot be destroyed without prize
            // PRIZE_BREAKING_BAD.

        REEFS = (short)'☼',

            // Explosion site. It disappears in a second.

        EXPLOSION = (short)'Ѡ',

            // Oil leak, hitting which the hero partially loses control.
            // During the passage, the field of view is limited and the
            // hero will repeat the old commands for several ticks in a
            // row, ignoring the current commands.

        OIL = (short)'#',

            // Seaweed hide heroes which can continue to shoot at the same
            // time. The fired shells are also not visible under the weed.
            // Only prizes can be seen from behind seaweed.

        SEAWEED = (short)'%',

            // Fishnet does not allow to pass through itself without the
            // PRIZE_WALKING_ON_FISHNET prize, but the shells fly freely
            // through the water. Hero stuck in the middle of the fishnet,
            // after canceling the PRIZE_WALKING_ON_FISHNET prize, can move
            // 1 cell in the fishnet only every N ticks.

        FISHNET = (short)'~',

            // An iceberg that hasn't been shot yet. It takes 3 shots to
            // completely destroy.

        ICEBERG_HUGE = (short)'╬',

            // Partially destroyed iceberg. For complete destruction, 2
            // shot is required.

        ICEBERG_MEDIUM_DOWN = (short)'╩',

            // Partially destroyed iceberg. For complete destruction, 2
            // shot is required.

        ICEBERG_MEDIUM_UP = (short)'╦',

            // Partially destroyed iceberg. For complete destruction, 2
            // shot is required.

        ICEBERG_MEDIUM_LEFT = (short)'╠',

            // Partially destroyed iceberg. For complete destruction, 2
            // shot is required.

        ICEBERG_MEDIUM_RIGHT = (short)'╣',

            // Almost destroyed iceberg. For complete destruction, 1 shot
            // is required.

        ICEBERG_SMALL_DOWN_DOWN = (short)'╨',

            // Almost destroyed iceberg. For complete destruction, 1 shot
            // is required.

        ICEBERG_SMALL_UP_UP = (short)'╥',

            // Almost destroyed iceberg. For complete destruction, 1 shot
            // is required.

        ICEBERG_SMALL_LEFT_LEFT = (short)'╞',

            // Almost destroyed iceberg. For complete destruction, 1 shot
            // is required.

        ICEBERG_SMALL_RIGHT_RIGHT = (short)'╡',

            // Almost destroyed iceberg. For complete destruction, 1 shot
            // is required.

        ICEBERG_SMALL_LEFT_RIGHT = (short)'│',

            // Almost destroyed iceberg. For complete destruction, 1 shot
            // is required.

        ICEBERG_SMALL_UP_DOWN = (short)'─',

            // Almost destroyed iceberg. For complete destruction, 1 shot
            // is required.

        ICEBERG_SMALL_UP_LEFT = (short)'┌',

            // Almost destroyed iceberg. For complete destruction, 1 shot
            // is required.

        ICEBERG_SMALL_UP_RIGHT = (short)'┐',

            // Almost destroyed iceberg. For complete destruction, 1 shot
            // is required.

        ICEBERG_SMALL_DOWN_LEFT = (short)'└',

            // Almost destroyed iceberg. For complete destruction, 1 shot
            // is required.

        ICEBERG_SMALL_DOWN_RIGHT = (short)'┘',

            // Completely destroyed iceberg. No different from WATER. A new
            // one will appear at this place soon.

        ICEBERG_DESTROYED = (short)' ',

            // Torpedo - is a self-propelled underwater missile designed to
            // be fired from a submarine and to explode on reaching a
            // target. The target can be an iceberg, another submarine and
            // other elements under water.

        TORPEDO = (short)'•',

            // Your hero is pointing up.

        HERO_UP = (short)'▲',

            // Your hero is pointing right.

        HERO_RIGHT = (short)'►',

            // Your hero is pointing down.

        HERO_DOWN = (short)'▼',

            // Your hero is pointing left.

        HERO_LEFT = (short)'◄',

            // Enemy hero is pointing up.

        OTHER_HERO_UP = (short)'˄',

            // Enemy hero is pointing right.

        OTHER_HERO_RIGHT = (short)'˃',

            // Enemy hero is pointing down.

        OTHER_HERO_DOWN = (short)'˅',

            // Enemy hero is pointing left.

        OTHER_HERO_LEFT = (short)'˂',

            // AI is pointing up.

        AI_UP = (short)'?',

            // AI is pointing right.

        AI_RIGHT = (short)'»',

            // AI is pointing down.

        AI_DOWN = (short)'¿',

            // AI is pointing left.

        AI_LEFT = (short)'«',

            // AI can also be a prize, then it is highlighted by this
            // sprite every few ticks.

        AI_PRIZE = (short)'◘',

            // The dropped prize after the destruction of the prize AI
            // flickers on the field every even tick of the game with this
            // sprite.

        PRIZE = (short)'!',

            // A prize that gives the hero temporary invulnerability.

        PRIZE_IMMORTALITY = (short)'1',

            // A prize that allows you to temporarily destroy any icebergs
            // and underwater reefs (but not the border of the field) with
            // 1 shot.

        PRIZE_BREAKING_BAD = (short)'2',

            // A prize that allows the hero to temporarily walk on fishnet.

        PRIZE_WALKING_ON_FISHNET = (short)'3',

            // A prize that allows the hero to temporarily see all enemies
            // and their bullets under the seaweed.

        PRIZE_VISIBILITY = (short)'4',

            // A prize that allows the hero to temporarily not slide on the
            // ice.

        PRIZE_NO_SLIDING = (short)'5'
    }
}


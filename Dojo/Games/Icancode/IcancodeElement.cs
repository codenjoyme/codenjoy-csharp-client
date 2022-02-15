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

namespace Dojo.Games.Icancode
{
    public enum IcancodeElement : short
    {

            // Empty space (on layer 2) where player can go.

        EMPTY = (short)'-',

            // Empty space (on layer 1) where player can go.

        FLOOR = (short)'.',

            // Wall (on layer 1).

        ANGLE_IN_LEFT = (short)'╔',

            // Wall (on layer 1).

        WALL_FRONT = (short)'═',

            // Wall (on layer 1).

        ANGLE_IN_RIGHT = (short)'┐',

            // Wall (on layer 1).

        WALL_RIGHT = (short)'│',

            // Wall (on layer 1).

        ANGLE_BACK_RIGHT = (short)'┘',

            // Wall (on layer 1).

        WALL_BACK = (short)'─',

            // Wall (on layer 1).

        ANGLE_BACK_LEFT = (short)'└',

            // Wall (on layer 1).

        WALL_LEFT = (short)'║',

            // Wall (on layer 1).

        WALL_BACK_ANGLE_LEFT = (short)'┌',

            // Wall (on layer 1).

        WALL_BACK_ANGLE_RIGHT = (short)'╗',

            // Wall (on layer 1).

        ANGLE_OUT_RIGHT = (short)'╝',

            // Wall (on layer 1).

        ANGLE_OUT_LEFT = (short)'╚',

            // Wall (on layer 1).

        SPACE = (short)' ',

            // Charging laser machine (on layer 1) pointing left.

        LASER_MACHINE_CHARGING_LEFT = (short)'˂',

            // Charging laser machine (on layer 1) pointing right.

        LASER_MACHINE_CHARGING_RIGHT = (short)'˃',

            // Charging laser machine (on layer 1) pointing up.

        LASER_MACHINE_CHARGING_UP = (short)'˄',

            // Charging laser machine (on layer 1) pointing down.

        LASER_MACHINE_CHARGING_DOWN = (short)'˅',

            // Charged laser machine (on layer 1) pointing left.

        LASER_MACHINE_READY_LEFT = (short)'◄',

            // Charged laser machine (on layer 1) pointing right.

        LASER_MACHINE_READY_RIGHT = (short)'►',

            // Charged laser machine (on layer 1) pointing up.

        LASER_MACHINE_READY_UP = (short)'▲',

            // Charged laser machine (on layer 1) pointing down.

        LASER_MACHINE_READY_DOWN = (short)'▼',

            // Level start spot (on layer 1).

        START = (short)'S',

            // Level exit spot (on layer 1).

        EXIT = (short)'E',

            // Hole (on layer 1).

        HOLE = (short)'O',

            // Box (on layer 2) that can be moved and jumped over.

        BOX = (short)'B',

            // Zombie start spot (on layer 1).

        ZOMBIE_START = (short)'Z',

            // Gold (on layer 1).

        GOLD = (short)'$',

            // Unstoppable laser perk (on layer 1).

        UNSTOPPABLE_LASER_PERK = (short)'l',

            // Death ray perk (on layer 1).

        DEATH_RAY_PERK = (short)'r',

            // Unlimited fire perk (on layer 1).

        UNLIMITED_FIRE_PERK = (short)'f',

            // Fire perk (on layer 1).

        FIRE_PERK = (short)'a',

            // Jump perk (on layer 1).

        JUMP_PERK = (short)'j',

            // Move boxes perk (on layer 1).

        MOVE_BOXES_PERK = (short)'m',

            // Your hero (on layer 2).

        ROBO = (short)'☺',

            // Your hero (on layer 2) falls into a hole.

        ROBO_FALLING = (short)'o',

            // Your hero (on layer 3) falling.

        ROBO_FLYING = (short)'*',

            // Your hero (on layer 2) died from a laser.

        ROBO_LASER = (short)'☻',

            // Other hero (on layer 2).

        ROBO_OTHER = (short)'X',

            // Other hero (on layer 2) falls into a hole.

        ROBO_OTHER_FALLING = (short)'x',

            // Other hero (on layer 3) falling.

        ROBO_OTHER_FLYING = (short)'^',

            // Other hero (on layer 2) died from a laser.

        ROBO_OTHER_LASER = (short)'&',

            // Laser (on layer 2) flies to the left.

        LASER_LEFT = (short)'←',

            // Laser (on layer 2) flies to the right.

        LASER_RIGHT = (short)'→',

            // Laser (on layer 2) flies to the up.

        LASER_UP = (short)'↑',

            // Laser (on layer 2) flies to the down.

        LASER_DOWN = (short)'↓',

            // Female zombie (on layer 2).

        FEMALE_ZOMBIE = (short)'♀',

            // Male zombie (on layer 2).

        MALE_ZOMBIE = (short)'♂',

            // Zombie dies (on layer 2).

        ZOMBIE_DIE = (short)'✝',

            // Fog of war system layer (on layer 1).

        FOG = (short)'F',

            // Background system layer (on layer 2).

        BACKGROUND = (short)'G'
    }
}


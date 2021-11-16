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

namespace Dojo.Games.Clifford
{
    public enum CliffordElement : short
    {

            // Empty space - where the hero can move.

        NONE = (short)' ',

            // A wall where you can shoot a hole.

        BRICK = (short)'#',

            // The wall is restored over time. When the process begins, we
            // see a timer.

        PIT_FILL_1 = (short)'1',

            // The wall is restored over time. When the process begins, we
            // see a timer.

        PIT_FILL_2 = (short)'2',

            // The wall is restored over time. When the process begins, we
            // see a timer.

        PIT_FILL_3 = (short)'3',

            // The wall is restored over time. When the process begins, we
            // see a timer.

        PIT_FILL_4 = (short)'4',

            // Indestructible wall - It cannot be destroyed with a shot.

        STONE = (short)'☼',

            // At the moment of the shot, we see the wall like this.

        CRACK_PIT = (short)'*',

            // Clue knife. Collect a series of clues to get the maximum
            // points.

        CLUE_KNIFE = (short)'$',

            // Clue glove. Collect a series of clues to get the maximum
            // points.

        CLUE_GLOVE = (short)'&',

            // Clue ring. Collect a series of clues to get the maximum
            // points.

        CLUE_RING = (short)'@',

            // Your hero is dead. In the next tick, it will disappear and
            // appear in a new location.

        HERO_DIE = (short)'Ѡ',

            // Your hero is climbing the ladder.

        HERO_LADDER = (short)'Y',

            // Your hero runs to the left.

        HERO_LEFT = (short)'◄',

            // Your hero runs to the right.

        HERO_RIGHT = (short)'►',

            // Your hero is falling.

        HERO_FALL = (short)']',

            // Your hero is crawling along the pipe.

        HERO_PIPE = (short)'{',

            // Your hero in the pit.

        HERO_PIT = (short)'⍃',

            // Your shadow-hero is dead. In the next tick, it will
            // disappear and appear in a new location.

        HERO_MASK_DIE = (short)'x',

            // Your shadow-hero is climbing the ladder.

        HERO_MASK_LADDER = (short)'⍬',

            // Your shadow-hero runs to the left.

        HERO_MASK_LEFT = (short)'⊲',

            // Your shadow-hero runs to the right.

        HERO_MASK_RIGHT = (short)'⊳',

            // Your shadow-hero is falling.

        HERO_MASK_FALL = (short)'⊅',

            // Your shadow-hero is crawling along the pipe.

        HERO_MASK_PIPE = (short)'⋜',

            // Your shadow-hero in the pit.

        HERO_MASK_PIT = (short)'ᐊ',

            // Other hero is dead. In the next tick, it will disappear and
            // appear in a new location.

        OTHER_HERO_DIE = (short)'Z',

            // Other hero is climbing the ladder.

        OTHER_HERO_LADDER = (short)'U',

            // Other hero runs to the left.

        OTHER_HERO_LEFT = (short)')',

            // Other hero runs to the right.

        OTHER_HERO_RIGHT = (short)'(',

            // Other hero is falling.

        OTHER_HERO_FALL = (short)'⊐',

            // Other hero is crawling along the pipe.

        OTHER_HERO_PIPE = (short)'Э',

            // Other hero in the pit.

        OTHER_HERO_PIT = (short)'ᗉ',

            // Other shadow-hero is dead. In the next tick, it will
            // disappear and appear in a new location.

        OTHER_HERO_MASK_DIE = (short)'⋈',

            // Other shadow-hero is climbing the ladder.

        OTHER_HERO_MASK_LADDER = (short)'⋕',

            // Other shadow-hero runs to the left.

        OTHER_HERO_MASK_LEFT = (short)'⋊',

            // Other shadow-hero runs to the right.

        OTHER_HERO_MASK_RIGHT = (short)'⋉',

            // Other shadow-hero is falling.

        OTHER_HERO_MASK_FALL = (short)'⋣',

            // Other shadow-hero is crawling along the pipe.

        OTHER_HERO_MASK_PIPE = (short)'⊣',

            // Other shadow-hero in the pit.

        OTHER_HERO_MASK_PIT = (short)'ᗏ',

            // Enemy hero is dead. In the next tick, it will disappear and
            // appear in a new location.

        ENEMY_HERO_DIE = (short)'Ž',

            // Enemy hero is climbing the ladder.

        ENEMY_HERO_LADDER = (short)'Ǔ',

            // Enemy hero runs to the left.

        ENEMY_HERO_LEFT = (short)'❫',

            // Enemy hero runs to the right.

        ENEMY_HERO_RIGHT = (short)'❪',

            // Enemy hero is falling.

        ENEMY_HERO_FALL = (short)'⋥',

            // Enemy hero is crawling along the pipe.

        ENEMY_HERO_PIPE = (short)'Ǯ',

            // Enemy hero in the pit.

        ENEMY_HERO_PIT = (short)'⇇',

            // Enemy shadow-hero is dead. In the next tick, it will
            // disappear and appear in a new location.

        ENEMY_HERO_MASK_DIE = (short)'⧓',

            // Enemy shadow-hero is climbing the ladder.

        ENEMY_HERO_MASK_LADDER = (short)'≠',

            // Enemy shadow-hero runs to the left.

        ENEMY_HERO_MASK_LEFT = (short)'⧒',

            // Enemy shadow-hero runs to the right.

        ENEMY_HERO_MASK_RIGHT = (short)'⧑',

            // Enemy shadow-hero is falling.

        ENEMY_HERO_MASK_FALL = (short)'⌫',

            // Enemy shadow-hero is crawling along the pipe.

        ENEMY_HERO_MASK_PIPE = (short)'❵',

            // Enemy shadow-hero in the pit.

        ENEMY_HERO_MASK_PIT = (short)'⬱',

            // Robber is climbing the ladder.

        ROBBER_LADDER = (short)'Q',

            // Robber runs to the left. Robber picks up the nearest prey
            // and hunts for it until it overtakes it.

        ROBBER_LEFT = (short)'«',

            // Robber runs to the right. Robber picks up the nearest prey
            // and hunts for it until it overtakes it.

        ROBBER_RIGHT = (short)'»',

            // Robber is falling.

        ROBBER_FALL = (short)'‹',

            // Robber is crawling along the pipe.

        ROBBER_PIPE = (short)'<',

            // Robber in the pit.

        ROBBER_PIT = (short)'⍇',

            // Opened golden gates. Can only be locked with a golden key.

        OPENED_DOOR_GOLD = (short)'⍙',

            // Opened silver gates. Can only be locked with a silver key.

        OPENED_DOOR_SILVER = (short)'⍚',

            // Opened bronze gates. Can only be locked with a bronze key.

        OPENED_DOOR_BRONZE = (short)'⍜',

            // Closed golden gates. Can only be opened with a golden key.

        CLOSED_DOOR_GOLD = (short)'⍍',

            // Closed silver gates. Can only be opened with a silver key.

        CLOSED_DOOR_SILVER = (short)'⌺',

            // Closed bronze gates. Can only be opened with a bronze key.

        CLOSED_DOOR_BRONZE = (short)'⌼',

            // Bronze key. Helps open/close golden gates. The key can only
            // be used once.

        KEY_GOLD = (short)'✦',

            // Silver key. Helps open/close silver gates. The key can only
            // be used once.

        KEY_SILVER = (short)'✼',

            // Bronze key. Helps open/close bronze gates. The key can only
            // be used once.

        KEY_BRONZE = (short)'⍟',

            // Bullet. After the shot by the hero, the bullet flies until
            // it meets an obstacle. The bullet kills the hero. It
            // ricochets from the indestructible wall (no more than 1
            // time). The bullet destroys the destructible wall.

        BULLET = (short)'•',

            // Ladder - the hero can move along the level along it.

        LADDER = (short)'H',

            // Pipe - the hero can also move along the level along it, but
            // only horizontally.

        PIPE = (short)'~',

            // Back door - allows the hero to secretly move to another
            // random place on the map.

        BACKWAY = (short)'⊛',

            // Disguise potion - endow the hero with additional abilities.
            // The hero goes into shadow mode.

        MASK_POTION = (short)'S'
    }
}


/*-
 * #%L
 * Codenjoy - it's a dojo-like platform from developers to developers.
 * %%
 * Copyright (C) 2018 Codenjoy
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

namespace Dojo.Games.Mollymage
{
    public enum Element : short
    {
        /// your Molly

        // This is what she usually looks like.
        HERO = (short)'☺',

        // This is if she is sitting on own potion.
        POTION_HERO = (short)'☻',

        // Oops, your Molly is dead (don't worry,
        // she will appear somewhere in next move).
        // You're getting penalty points for each death.
        DEAD_HERO = (short)'Ѡ',

        /// other players heroes

        // This is what other heroes looks like.
        OTHER_HERO = (short)'♥',

        // This is if player is sitting on own potion.
        OTHER_POTION_HERO = (short)'♠',

        // Enemy corpse (it will disappear shortly,
        // right on the next move).
        // If you've done it you'll get score points.
        OTHER_DEAD_HERO = (short)'♣',

        /// the potions
        // After Molly set the potion, the timer starts (5 ticks).
        POTION_TIMER_5 = (short)'5',

        // This will blow up after 4 ticks.
        POTION_TIMER_4 = (short)'4',

        // This after 3...
        POTION_TIMER_3 = (short)'3',

        // Two..
        POTION_TIMER_2 = (short)'2',

        // One.
        POTION_TIMER_1 = (short)'1',

        // Boom! this is what is potion does,
        // everything that is destroyable got destroyed.
        BOOM = (short)'҉',

        /// walls

        // Indestructible wall - it will not fall from potion.
        WALL = (short)'☼',

        // this is a treasure box, it opens with an explosion.
        TREASURE_BOX = (short)'#',

        // this is like a treasure box opens looks
        // like, it will disappear on next move.
        // if it's you did it - you'll get score
        // points. Perhaps a prize will appear.
        OPENING_TREASURE_BOX = (short)'H',

        /// soulless creatures

        // This guys runs over the board randomly
        // and gets in the way all the time.
        // If it will touch Molly - she will die.
        // You'd better kill this piece of ... soul,
        // you'll get score points for it.
        GHOST = (short)'&',

        // This is ghost corpse.
        DEAD_GHOST = (short)'x',

        /// perks

        // Potion blast radius increase.
        // Applicable only to new potions.
        // The perk is temporary.
        POTION_BLAST_RADIUS_INCREASE = (short)'+',

        // Increase available potions count.
        // Number of extra potions can be set
        // in settings. Temporary.
        POTION_COUNT_INCREASE = (short)'c',

        // Potion blast not by timer but by second act.
        // Number of RC triggers is limited and c
        // an be set in settings.
        POTION_REMOTE_CONTROL = (short)'r',

        // Do not die after potion blast
        // (own potion and others as well). Temporary.
        POTION_IMMUNE = (short)'i',

        // Hero can shoot by poison cloud
        // Temporary.
        POISON_THROWER = (short)'T',

        /// a void
        // This is the only place where you can move your Molly.
        NONE = (short)' '
    }
}

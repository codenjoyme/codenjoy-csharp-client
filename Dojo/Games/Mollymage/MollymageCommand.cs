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

namespace Dojo.Games.Mollymage
{
    public class MollymageCommand
    {
        public static string LEFT = "LEFT";
        public static string RIGHT = "RIGHT";
        public static string UP = "UP";
        public static string DOWN = "DOWN";

        public static string DROP_POTION = "ACT";

        public static string DROP_POTION_THEN_MOVE_LEFT = "ACT,LEFT";
        public static string DROP_POTION_THEN_MOVE_RIGHT = "ACT,RIGHT";
        public static string DROP_POTION_THEN_MOVE_UP = "ACT,UP";
        public static string DROP_POTION_THEN_MOVE_DOWN = "ACT,DOWN";

        public static string MOVE_LEFT_THEN_DROP_POTION = "LEFT,ACT";
        public static string MOVE_RIGHT_THEN_DROP_POTION = "RIGHT,ACT";
        public static string MOVE_UP_THEN_DROP_POTION = "UP,ACT";
        public static string MOVE_DOWN_THEN_DROP_POTION = "DOWN,ACT";

        public static string THROW_POTION_THEN_MOVE_LEFT = "LEFT,ACT(1)";
        public static string THROW_POTION_THEN_MOVE_RIGHT = "RIGHT,ACT(1)";
        public static string THROW_POTION_THEN_MOVE_UP = "UP,ACT(1)";
        public static string THROW_POTION_THEN_MOVE_DOWN = "DOWN,ACT(1)";

        public static string EXPLODE_POTIONS_THEN_MOVE_LEFT = "ACT(2),LEFT";
        public static string EXPLODE_POTIONS_THEN_MOVE_RIGHT = "ACT(2),RIGHT";
        public static string EXPLODE_POTIONS_THEN_MOVE_UP = "ACT(2),UP";
        public static string EXPLODE_POTIONS_THEN_MOVE_DOWN = "ACT(2),DOWN";

        public static string MOVE_LEFT_THEN_EXPLODE_POTIONS = "LEFT,ACT(2)";
        public static string MOVE_RIGHT_THEN_EXPLODE_POTIONS = "RIGHT,ACT(2)";
        public static string MOVE_UP_THEN_EXPLODE_POTIONS = "UP,ACT(2)";
        public static string MOVE_DOWN_THEN_EXPLODE_POTIONS = "DOWN,ACT(2)";
    }
}
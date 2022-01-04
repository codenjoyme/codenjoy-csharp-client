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

namespace Dojo.Games.Clifford
{
    public class CliffordCommand
    {
        public static string MOVE_LEFT = "LEFT";
        public static string MOVE_RIGHT = "RIGHT";
        public static string MOVE_UP = "UP";
        public static string MOVE_DOWN = "DOWN";

        public static string CRACK_LEFT = "ACT,LEFT";
        public static string CRACK_RIGHT = "ACT,RIGHT";

        public static string DIE = "ACT(0)";

        public static string SHOOT_LEFT = "ACT(1),LEFT";
        public static string SHOOT_RIGHT = "ACT(1),RIGHT";

        public static string OPEN_DOOR_LEFT = "ACT(2),LEFT";
        public static string OPEN_DOOR_RIGHT = "ACT(2),RIGHT";

        public static string CLOSE_DOOR_LEFT = "ACT(3),LEFT";
        public static string CLOSE_DOOR_RIGHT = "ACT(3),RIGHT";
    }
}
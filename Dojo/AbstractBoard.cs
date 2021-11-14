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

namespace Dojo
{
    public abstract class AbstractBoard<T> : AbstractLayeredBoard<T>
        where T : Enum
    {
        protected string BoardString { get; }

        protected readonly LengthToXY LengthXY;

        public AbstractBoard(string boardString)
        {
            BoardString = boardString.Replace("\n", "");
            LengthXY = new LengthToXY(Size);
        }

        /// <summary>
        /// GameBoard size (actual board size is Size x Size cells)
        /// </summary>
        public int Size
        {
            get
            {
                return (int)Math.Sqrt(BoardString.Length);
            }
        }

        public T GetAt(Point point, T defaultValue = default)
        {
            if (point.IsOutOf(Size))
            {
                return defaultValue;
            }

            var value = BoardString[LengthXY.GetLength(point.X, point.Y)];

            return (T)Enum.ToObject(typeof(T), value);
        }

        public bool IsAt(Point point, T element)
        {
            if (point.IsOutOf(Size))
            {
                return false;
            }

            return EqualityComparer<T>.Default.Equals(GetAt(point), element);
        }

        public string BoardAsString()
        {
            var result = string.Empty;

            for (int i = 0; i < Size; i++)
            {
                result += BoardString.Substring(i * Size, Size);
                result += "\n";
            }
            return result;
        }

        public List<Point> Get(T element)
        {
            var result = new List<Point>();

            for (int i = 0; i < Size * Size; i++)
            {
                var pt = LengthXY.GetXY(i);

                if (IsAt(pt, element))
                {
                    result.Add(pt);
                }
            }

            return result;
        }

        public bool IsAnyOfAt(Point point, params T[] elements)
        {
            return elements.Any(elem => IsAt(point, elem));
        }

        public bool IsNear(Point point, T element)
        {
            if (point.IsOutOf(Size))
                return false;

            return IsAt(point.ShiftLeft(), element) ||
                   IsAt(point.ShiftRight(), element) ||
                   IsAt(point.ShiftTop(), element) ||
                   IsAt(point.ShiftBottom(), element);
        }

        public int CountNear(Point point, T element)
        {
            if (point.IsOutOf(Size))
                return 0;

            int count = 0;
            if (IsAt(point.ShiftLeft(), element))
            {
                count++;
            }

            if (IsAt(point.ShiftRight(), element))
            {
                count++;
            }

            if (IsAt(point.ShiftTop(), element))
            {
                count++;
            }

            if (IsAt(point.ShiftBottom(), element))
            {
                count++;
            }

            return count;
        }
    }
}

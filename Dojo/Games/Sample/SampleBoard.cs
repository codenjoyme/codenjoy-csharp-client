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

using Dojo.Infrastructure;
using static Dojo.Games.Sample.SampleElement;

namespace Dojo.Games.Sample
{
    public class SampleBoard : AbstractBoard<SampleElement>
    {
        public SampleBoard(string boardString)
            : base(boardString)
        {
        }

        public bool IsGameOver
        {
            get
            {
                return BoardString.Contains((char)SampleElement.HERO_DEAD);
            }
        }
        
        public Point GetHero()
        {
            var result = GetRelativeElements(GetHeroElements());

            if (result.Count == 0)
            {
                throw new NullReferenceException("Hero element has not been found.");
            }

            return result[0];
        }

        public List<Point> GetOtherHeroes()
        {
            var result = GetRelativeElements(GetOtherHeroElements());
            return result;
        }
        
        public List<Point> GetWalls()
        {
            var result = GetRelativeElements(GetWallElements());
            return result;
        }

        public List<Point> GetBombs()
        {
            var result = GetRelativeElements(GetBombElements());
            return result;
        }

        public List<Point> GetGold()
        {
            var result = GetRelativeElements(GetGoldElements());
            return result;
        }

        public List<Point> GetBarriers()
        {
            var result = GetRelativeElements(GetBarrierElements());
            return result;
        }
        
        internal bool IsHeroAt(Point point)
        {
            return IsAnyOfAt(point, GetHeroElements().ToArray());
        }

        internal bool IsOtherHeroAt(Point point)
        {
            return IsAnyOfAt(point, GetOtherHeroElements().ToArray());
        }

        internal bool IsWallAt(Point point)
        {
            return IsAnyOfAt(point, GetWallElements().ToArray());
        }

        internal bool IsBombAt(Point point)
        {
            return IsAnyOfAt(point, GetBombElements().ToArray());
        }

        internal bool IsGoldAt(Point point)
        {
            return IsAnyOfAt(point, GetGoldElements().ToArray());
        }

        internal bool IsBarrierAt(Point point)
        {
            return IsAnyOfAt(point, GetBarrierElements().ToArray());
        }

        internal static List<SampleElement> GetHeroElements()
        {
            return new List<SampleElement>
            {
                SampleElement.HERO_DEAD,
                SampleElement.HERO
            };
        }

        internal static List<SampleElement> GetOtherHeroElements()
        {
            return new List<SampleElement>
            {
                SampleElement.OTHER_HERO,
                SampleElement.OTHER_HERO_DEAD
            };
        }

        internal static List<SampleElement> GetWallElements()
        {
            return new List<SampleElement>
            {
                SampleElement.WALL
            };
        }

        internal static List<SampleElement> GetGoldElements()
        {
            return new List<SampleElement>
            {
                SampleElement.GOLD
            };
        }

        internal static List<SampleElement> GetBombElements()
        {
            return new List<SampleElement>
            {
                SampleElement.BOMB
            };
        }

        internal static List<SampleElement> GetBarrierElements()
        {
            return new List<SampleElement>
            {
                SampleElement.WALL,
                SampleElement.BOMB,
                SampleElement.OTHER_HERO,
                SampleElement.OTHER_HERO_DEAD
            };
        }
        
        public override string ToString()
        {
            return string.Format("{0}\n" +
                     "Hero at: {1}\n" +
                     "Other heroes at: {2}\n" +
                     "Bombs at: {3}\n" +
                     "Gold at: {4}\n",
                     BoardAsString(),
                     GetHero(),
                     GetOtherHeroes().ListAsString(),
                     GetBombs().ListAsString(),
                     GetGold().ListAsString()
            );
        }
    }
}

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

using Dojo.Infrastructure;
using static Dojo.Games.Verland.VerlandElement;

namespace Dojo.Games.Verland
{
    public class VerlandBoard : AbstractBoard<VerlandElement>
    {
        public VerlandBoard(string boardString)
            : base(boardString)
        {
        }
        
        public Point GetHero()
        {
            var result = GetRelativeElements(GetHeroesElements());

            if (result.Count == 0)
            {
                throw new NullReferenceException("Hero element has not been found.");
            }

            return result[0];
        }

        public List<Point> GetOtherHeroes()
        {
            var result = GetRelativeElements(GetOtherHeroesElements());
            return result;
        }
        
        public List<Point> GetEnemyHeroes()
        {
            var result = GetRelativeElements(GetEnemyHeroElements());
            return result;
        }
        
        public List<Point> GetWalls()
        {
            var result = GetRelativeElements(GetWallsElements());
            return result;
        }
        
        public List<Point> GetOtherStuff()
        {
            var result = GetRelativeElements(GetOtherStuffElements());
            return result;
        }
        
        public int CountContagions(Point point)
        {

            return IsAnyOfAt(point, GetInfectionMarkers().ToArray()) ? (char) GetAt(point) - '0' : 0; 
        }

        
        public bool IsGameOver
        {
            get
            {
                return BoardString.Contains((char)HERO_DEAD);
            }
        }
        
        internal bool IsHeroAt(Point point)
        {
            return IsAnyOfAt(point, GetHeroesElements().ToArray());
        }
        
        internal bool IsEnemyAt(Point point)
        {
            return IsAnyOfAt(point, GetEnemyHeroesElements().ToArray());
        }

        internal bool IsOtherHeroAt(Point point)
        {
            return IsAnyOfAt(point, GetOtherHeroesElements().ToArray());
        }
        
        internal static List<VerlandElement> GetEnemyHeroElements()
        {
            return new List<VerlandElement>
            {
                ENEMY_HERO_DEAD,
                ENEMY_HERO
            };
        }

        internal static List<VerlandElement> GetWallsElements()
        {
            return new List<VerlandElement>
            {
                PATHLESS
            };
        }
        
        internal static List<VerlandElement> GetOtherStuffElements()
        {
            return new List<VerlandElement>
            {
                INFECTION,
                HIDDEN,
                PATHLESS
            };
        }

        internal static List<VerlandElement> GetHeroesElements()
        {
            return new List<VerlandElement>
            {
                HERO_DEAD,
                HERO
            };
        }

        internal static List<VerlandElement> GetEnemyHeroesElements()
        {
            return new List<VerlandElement>
            {
                ENEMY_HERO_DEAD,
                ENEMY_HERO
            };
        }

        internal static List<VerlandElement> GetOtherHeroesElements()
        {
            return new List<VerlandElement>
            {
                OTHER_HERO_DEAD,
                OTHER_HERO
            };
        }
        
        internal static List<VerlandElement> GetInfectionMarkers()
        {
            return new List<VerlandElement>
            {
                CLEAR,
                CONTAGION_ONE,
                CONTAGION_TWO,
                CONTAGION_THREE,
                CONTAGION_FOUR,
                CONTAGION_FIVE,
                CONTAGION_SIX,
                CONTAGION_SEVEN,
                CONTAGION_EIGHT
            };
        }
        
        public override string ToString()
        {
            return string.Format("{0}\n" +
                     "Hero at: {1}\n" +
                     "Other heroes at: {2}\n" +
                     "Enemy heroes at: {3}\n" +
                     "Other stuff at: {4}\n",
                     BoardAsString(),
                     GetHero(),
                     GetOtherHeroes().ListAsString(),
                     GetEnemyHeroes().ListAsString(),
                     GetOtherStuff().ListAsString()
            );
        }
    }
}

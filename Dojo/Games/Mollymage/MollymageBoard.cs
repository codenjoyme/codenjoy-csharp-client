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

using Dojo.Infrastructure;

namespace Dojo.Games.Mollymage
{
    public class MollymageBoard : AbstractBoard<Element>
    {
        public MollymageBoard(string boardString)
            : base(boardString)
        {
        }

        public Point GetHero()
        {
            var points = Get(Element.HERO, Element.POTION_HERO, Element.DEAD_HERO);

            if (!points.Any())
            {
                throw new NullReferenceException("Hero element has not been found.");
            }

            return points.FirstOrDefault();
        }

        public List<Point> GetOtherHeroes()
        {
            return Get(Element.OTHER_HERO, Element.OTHER_POTION_HERO, Element.OTHER_DEAD_HERO).ToList();
        }

        public List<Point> GetEnemyHeroes()
        {
            return Get(Element.ENEMY_HERO, Element.ENEMY_POTION_HERO, Element.ENEMY_DEAD_HERO).ToList();
        }

        public bool IsGameOver
        {
            get
            {
                return BoardString.Contains((char)Element.DEAD_HERO);
            }
        }

        public Element GetAt(Point point)
        {
            return GetAt(point, Element.WALL);
        }

        /// <summary>
        /// gets board view as string
        /// </summary>
        public override string ToString()
        {
            return string.Format("{0}\n" +
                     "Hero at: {1}\n" +
                     "Other heroes at: {2}\n" +
                     "Enemy heroes at: {3}\n" +
                     "Ghosts at: {4}\n" +
                     "Treasure Boxes at: {5}\n" +
                     "Potions at: {6}\n" +
                     "Blasts at: {7}\n" +
                     "Expected blasts at: {8}",
                     BoardAsString(),
                     GetHero(),
                     GetOtherHeroes().ListAsString(),
                     GetEnemyHeroes().ListAsString(),
                     GetGhosts().ListAsString(),
                     GetTreasureBoxes().ListAsString(),
                     GetPotions().ListAsString(),
                     GetBlasts().ListAsString(),
                     GetFutureBlasts().ListAsString());
        }

        public List<Point> GetBarrier()
        {
            return GetGhosts()
                .Concat(GetWalls())
                .Concat(GetPotions())
                .Concat(GetTreasureBoxes())
                .Concat(GetOtherHeroes())
                .Distinct()
                .OrderBy(pt => pt.X).ThenBy(pt => pt.Y)
                .ToList();
        }

        public List<Point> GetGhosts()
        {
            return Get(Element.GHOST);
        }


        public List<Point> GetWalls()
        {
            return Get(Element.WALL);
        }

        public List<Point> GetTreasureBoxes()
        {
            return Get(Element.TREASURE_BOX);
        }

        public List<Point> GetPotions()
        {
            return Get(Element.POTION_TIMER_1)
                .Concat(Get(Element.POTION_TIMER_2))
                .Concat(Get(Element.POTION_TIMER_3))
                .Concat(Get(Element.POTION_TIMER_4))
                .Concat(Get(Element.POTION_TIMER_5))
                .Concat(Get(Element.POTION_HERO))
                .Concat(Get(Element.OTHER_POTION_HERO))
                .OrderBy(pt => pt.X).ThenBy(pt => pt.Y)
                .ToList();
        }

        public List<Point> GetPerks()
        {
            return Get(Element.POTION_BLAST_RADIUS_INCREASE)
                .Concat(Get(Element.POTION_COUNT_INCREASE))
                .Concat(Get(Element.POTION_IMMUNE))
                .Concat(Get(Element.POTION_REMOTE_CONTROL))
                .Concat(Get(Element.POISON_THROWER))
                .Concat(Get(Element.POTION_EXPLODER))
                .OrderBy(pt => pt.X).ThenBy(pt => pt.Y)
                .ToList();
        }

        public List<Point> GetBlasts()
        {
            return Get(Element.BOOM);
        }

        public List<Point> GetFutureBlasts()
        {
            var potions = Get(Element.POTION_TIMER_1);
            var result = new List<Point>();
            foreach (var potion in potions)
            {
                result.Add(potion);
                result.Add(potion.ShiftLeft());
                result.Add(potion.ShiftRight());
                result.Add(potion.ShiftTop());
                result.Add(potion.ShiftBottom());
            }

            return result.Where(blast => !blast.IsOutOf(Size) && !GetBarrier().Contains(blast)).Distinct().ToList();
        }

        public bool IsBarrierAt(Point point)
        {
            return GetBarrier().Contains(point);
        }
    }
}

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

using Dojo;
using Dojo.Infrastructure;

namespace Dojo.Games.Mollymage
{
    public class Board : AbstractBoard<Element>
    {
        public Board(string boardString)
            : base(boardString)
        {
        }

        public Point GetHero()
        {
            return Get(Element.HERO)
                    .Concat(Get(Element.POTION_HERO))
                    .Concat(Get(Element.DEAD_HERO))
                    .Last();
        }

        public List<Point> GetOtherHeroes()
        {
            return Get(Element.OTHER_HERO)
                .Concat(Get(Element.OTHER_POTION_HERO))
                .Concat(Get(Element.OTHER_DEAD_HERO))
                .ToList();
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
                     "Ghosts at: {3}\n" +
                     "Treasure Boxes at: {4}\n" +
                     "Potions as: {5}\n" +
                     "Blasts: {6}\n" +
                     "Expected blasts at: {7}\n" +
                     "Perks at: {8}",
                     BoardAsString(),
                     GetHero(),
                     GetOtherHeroes().ListAsString(),
                     GetGhosts().ListAsString(),
                     GetTreasureBoxes().ListAsString(),
                     GetPotions().ListAsString(),
                     GetBlasts().ListAsString(),
                     GetFutureBlasts().ListAsString(),
                     GetPerks().ListAsString());
        }

        public List<Point> GetBarrier()
        {
            return GetGhosts()
                .Concat(GetWalls())
                .Concat(GetPotions())
                .Concat(GetTreasureBoxes())
                .Concat(GetOtherHeroes())
                .Distinct()
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
                .ToList();
        }

        public List<Point> GetPerks()
        {
            return Get(Element.POTION_BLAST_RADIUS_INCREASE)
                .Concat(Get(Element.POTION_COUNT_INCREASE))
                .Concat(Get(Element.POTION_IMMUNE))
                .Concat(Get(Element.POTION_REMOTE_CONTROL))
                .Concat(Get(Element.POISON_THROWER))
                .ToList();
        }

        public List<Point> GetBlasts()
        {
            return Get(Element.BOOM);
        }

        public List<Point> GetFutureBlasts()
        {
            var potions = GetPotions();
            var result = new List<Point>();
            foreach (var potion in potions)
            {
                result.Add(potion);
                result.Add(potion.ShiftLeft());
                result.Add(potion.ShiftRight());
                result.Add(potion.ShiftTop());
                result.Add(potion.ShiftBottom());
            }

            return result.Where(blast => !blast.IsOutOf(Size) && !GetWalls().Contains(blast)).Distinct().ToList();
        }

        public bool IsBarrierAt(Point point)
        {
            return GetBarrier().Contains(point);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo.Games.Clifford
{
    public enum CliffordElement : short
    {
        /// void

        NONE = (short)' ',                  // Empty space - where the hero can move.
                                            
        /// bricks                          
                                            
        BRICK = (short)'#',                 // A wall where you can shoot a hole.
        PIT_FILL_1 = (short)'1',            // The wall is restored over time. When the process begins, we see a timer.
        PIT_FILL_2 = (short)'2',            
        PIT_FILL_3 = (short)'3',            
        PIT_FILL_4 = (short)'4',            
                                            
        STONE = (short)'☼',                 // Indestructible wall - It cannot be destroyed with a shot.
                                            
        CRACK_PIT = (short)'*',             // At the moment of the shot, we see the wall like this.
                                            
        /// clues                           
                                            
        CLUE_KNIFE = (short)'$',            // Clue knife. Collect a series of clues to get the maximum points.
        CLUE_GLOVE = (short)'&',            // Clue glove. Collect a series of clues to get the maximum points.
        CLUE_RING = (short)'@',             // Clue ring. Collect a series of clues to get the maximum points.
                                            
        /// your hero                       
                                            
        HERO_DIE = (short)'Ѡ',              // Your hero is dead. In the next tick, it will disappear and appear in a new location.
        HERO_LADDER = (short)'Y',           // Your hero is climbing the ladder.
        HERO_LEFT = (short)'◄',             // Your hero runs to the left.
        HERO_RIGHT = (short)'►',            // Your hero runs to the right.
        HERO_FALL = (short)']',             // Your hero is falling.
        HERO_PIPE = (short)'{',             // Your hero is crawling along the pipe.
                                            
        HERO_PIT = (short)'⍃',              // Your hero in the pit.
                                            
        /// your hero in shadow mode        
                                            
        HERO_MASK_DIE = (short)'x',         // Your shadow-hero is dead. In the next tick, it will disappear and appear in a new location.
        HERO_MASK_LADDER = (short)'⍬',      // Your shadow-hero is climbing the ladder.
        HERO_MASK_LEFT = (short)'⊲',        // Your shadow-hero runs to the left.
        HERO_MASK_RIGHT = (short)'⊳',       // Your shadow-hero runs to the right.
        HERO_MASK_FALL = (short)'⊅',        // Your shadow-hero is falling.
        HERO_MASK_PIPE = (short)'⋜',        // Your shadow-hero is crawling along the pipe.
        HERO_MASK_PIT = (short)'ᐊ',         // Your shadow-hero in the pit.
                                            
        /// other heroes                    
                                            
        OTHER_HERO_DIE = (short)'Z',        // Other hero is dead. In the next tick, it will disappear and appear in a new location.
        OTHER_HERO_LADDER = (short)'U',     // Other hero is climbing the ladder.
        OTHER_HERO_LEFT = (short)')',       // Other hero runs to the left.
        OTHER_HERO_RIGHT = (short)'(',      // Other hero runs to the right.
        OTHER_HERO_FALL = (short)'⊐',       // Other hero is falling.
        OTHER_HERO_PIPE = (short)'Э',       // Other hero is crawling along the pipe.
        OTHER_HERO_PIT = (short)'ᗉ',        // Other hero in the pit.

    /// other heroes in shadow mode

        OTHER_HERO_MASK_DIE = (short)'⋈',    // Other shadow-hero is dead. In the next tick, it will disappear and appear in a new location.
        OTHER_HERO_MASK_LADDER = (short)'⋕', // Other shadow-hero is climbing the ladder.
        OTHER_HERO_MASK_LEFT = (short)'⋊',   // Other shadow-hero runs to the left.
        OTHER_HERO_MASK_RIGHT = (short)'⋉',  // Other shadow-hero runs to the right.
        OTHER_HERO_MASK_FALL = (short)'⋣',   // Other shadow-hero is falling.
        OTHER_HERO_MASK_PIPE = (short)'⊣',   // Other shadow-hero is crawling along the pipe.
        OTHER_HERO_MASK_PIT = (short)'ᗏ',    // Other shadow-hero in the pit.

    /// enemy heroes

        ENEMY_HERO_DIE = (short)'Ž',         // Enemy hero is dead. In the next tick, it will disappear and appear in a new location.
        ENEMY_HERO_LADDER = (short)'Ǔ',      // Enemy hero is climbing the ladder.
        ENEMY_HERO_LEFT = (short)'❫',        // Enemy hero runs to the left.
        ENEMY_HERO_RIGHT = (short)'❪',       // Enemy hero runs to the right.
        ENEMY_HERO_FALL = (short)'⋥',        // Enemy hero is falling.
        ENEMY_HERO_PIPE = (short)'Ǯ',        // Enemy hero is crawling along the pipe.
        ENEMY_HERO_PIT = (short)'⇇',         // Enemy hero in the pit.

    /// enemy heroes in shadow mode

        ENEMY_HERO_MASK_DIE = (short)'⧓',    // Enemy shadow-hero is dead. In the next tick, it will disappear and appear in a new location.
        ENEMY_HERO_MASK_LADDER = (short)'≠', // Enemy shadow-hero is climbing the ladder.
        ENEMY_HERO_MASK_LEFT = (short)'⧒',   // Enemy shadow-hero runs to the left.
        ENEMY_HERO_MASK_RIGHT = (short)'⧑',  // Enemy shadow-hero runs to the right.
        ENEMY_HERO_MASK_FALL = (short)'⌫',  // Enemy shadow-hero is falling.
        ENEMY_HERO_MASK_PIPE = (short)'❵',    // Enemy shadow-hero is crawling along the pipe.
        ENEMY_HERO_MASK_PIT = (short)'⬱',    // Enemy shadow-hero in the pit.

    // robbers (dummy AI-bots)

        ROBBER_LADDER = (short)'Q',          // Robber is climbing the ladder.
        ROBBER_LEFT = (short)'«',            // Robber runs to the left. Robber picks up the nearest prey and hunts for it until it overtakes it.
        ROBBER_RIGHT = (short)'»',          // Robber runs to the right. Robber picks up the nearest prey and hunts for it until it overtakes it.
        ROBBER_FALL = (short)'‹',           // Robber is falling.
        ROBBER_PIPE = (short)'<',           // Robber is crawling along the pipe.
        ROBBER_PIT = (short)'⍇',            // Robber in the pit.

    /// doors and keys

        OPENED_DOOR_GOLD = (short)'⍙',       // Opened golden gates. Can only be locked with a golden key.
        OPENED_DOOR_SILVER = (short)'⍚',     // Opened silver gates. Can only be locked with a silver key.
        OPENED_DOOR_BRONZE = (short)'⍜',     // Opened bronze gates. Can only be locked with a bronze key.
        CLOSED_DOOR_GOLD = (short)'⍍',       // Closed golden gates. Can only be opened with a golden key.
        CLOSED_DOOR_SILVER = (short)'⌺',     // Closed silver gates. Can only be opened with a silver key.
        CLOSED_DOOR_BRONZE = (short)'⌼',     // Closed bronze gates. Can only be opened with a bronze key.
        KEY_GOLD = (short)'✦',               // Golden key. Helps open/close golden gates. The key can only be used once.
        KEY_SILVER = (short)'✼',            // Silver key. Helps open/close silver gates. The key can only be used once.
        KEY_BRONZE = (short)'⍟',            // Bronze key. Helps open/close bronze gates. The key can only be used once.

    /// other stuff

        BULLET = (short)'•',        // Bullet. After the shot by the hero, the bullet
                                    // flies until it meets an obstacle. The bullet
                                    // kills the hero. It ricochets from the indestructible
                                    // wall (no more than 1 time). The bullet destroys
                                    // the destructible wall.

        LADDER = (short)'H',        // Ladder - the hero can move along the level along it.
        PIPE = (short)'~',          // Pipe - the hero can also move along the level along it, but only horizontally.
        BACKWAY = (short)'⊛',       // Back door - allows the hero to secretly move to another random place on the map.
        MASK_POTION = (short)'S',   // Disguise potion - endow the hero with " +
                                    // additional abilities. The hero goes into " +
                                    // shadow mode.");
    }
}

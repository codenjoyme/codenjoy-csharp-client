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

namespace Dojo.Games.A2048
{
    public enum A2048Element : short
    {

            // An obstacle through which the chips do not pass.

        _x = (short)'x',

            // Number 2. Will unite on the field only with the same chips,
            // the result will be a chip with number 4, so 2+2=4.

        _2 = (short)'2',

            // Number 4. 4+4=8.

        _4 = (short)'4',

            // Number 8. 8+8=16.

        _8 = (short)'8',

            // Number 16. 16+16=32.

        _16 = (short)'A',

            // Number 32. 32+36=64.

        _32 = (short)'B',

            // Number 64. 64+64=128.

        _64 = (short)'C',

            // Number 128. 128+128=256.

        _128 = (short)'D',

            // Number 256. 256+256=512.

        _256 = (short)'E',

            // Number 512. 512+512=1,024.

        _512 = (short)'F',

            // Number 1,024. 1k+1k=2k.

        _1024 = (short)'G',

            // Number 2,048. 2k+2k=4k.

        _2048 = (short)'H',

            // Number 4,096. 4k+4k=8k.

        _4096 = (short)'I',

            // Number 8,192. 8k+8k=16k.

        _8192 = (short)'J',

            // Number 16,384. 16k+16k=32k.

        _16384 = (short)'K',

            // Number 32,768. 32k+32k=64k.

        _32768 = (short)'L',

            // Number 65,536. 64k+64k=128k.

        _65536 = (short)'M',

            // Number 131,072. 128k+128k=256k.

        _131072 = (short)'N',

            // Number 262,144. 256k+256k=512k.

        _262144 = (short)'O',

            // Number 524,288. 512k+512k=1M.

        _524288 = (short)'P',

            // Number 1,048,576. 1M+1M=2M.

        _1048576 = (short)'Q',

            // Number 2,097,152. 2M+2M=4M.

        _2097152 = (short)'R',

            // Number 4,194,304. 4M+4M=8M.

        _4194304 = (short)'S',

            // Empty space.

        NONE = (short)' '
    }
}


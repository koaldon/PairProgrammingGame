using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame
{
   public static class AsciiDrawings
    {
        public static StringBuilder BulbasaurDrawing(StringBuilder AsciiArt)
        {
            AsciiArt.AppendLine(@"             `;,;.;,;.;.'");
            AsciiArt.AppendLine(@"              ..:;:;::;: ");
            AsciiArt.AppendLine(@"        ..--''' '' ' ' '''--.  ");
            AsciiArt.AppendLine(@"      /' .   .'        '.   .`\");
            AsciiArt.AppendLine(@"     | /    /            \   '.|");
            AsciiArt.AppendLine(@"     | |   :             :    :|");
            AsciiArt.AppendLine(@"   .'| |   :             :    :|");
            AsciiArt.AppendLine(@" ,: /\ \.._\ __..===..__/_../ /`.");
            AsciiArt.AppendLine(@"|'' |  :.|  `'          `'  |.'  ::.");
            AsciiArt.AppendLine(@"|   |  ''|    :'';          | ,  `''\");
            AsciiArt.AppendLine(@"|.:  \/  | /'-.`'   ':'.-'\ |  \,   |");
            AsciiArt.AppendLine(@"| '  /  /  | / |...   | \ |  |  |';'|");
            AsciiArt.AppendLine(@" \ _ |:.|  |_\_|`.'   |_/_|  |.:| _ |");
            AsciiArt.AppendLine(@"/,.,.|' \__       . .      __/ '|.,.,\");
            AsciiArt.AppendLine(@"     | ':`.`----._____.---'.'   |");
            AsciiArt.AppendLine("      \\   `:\"\"\"------ - '\"\"' |   | ");
            AsciiArt.AppendLine(@"       ',-,-',             .'-=,=,");
            return AsciiArt;
        }
    }
}

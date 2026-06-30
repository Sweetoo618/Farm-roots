using System.Collections.Generic;

namespace Rules.LevelRules
{
    public class LevelConfig
    {
        public static readonly Dictionary<string, int> LevelUpExpConfig = new Dictionary<string, int>
        {
            {"Level1ToLevel2", 30},
            {"Level2ToLevel3", 70},
            {"Level3ToLevel4", 100},
            {"Level4ToLevel5", 130},
            {"Level5ToLevel6", 180},
            {"Level6ToLevel7", 200},
            {"Level7ToLevel8", 240},
            {"Level8ToLevel9", 260},
            {"Level9ToLevel10", 300}
        };
    }
}

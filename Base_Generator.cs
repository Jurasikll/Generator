using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    class Base_Generator
    {
        private UInt32 width;
        private UInt32 height;
        private UInt32 levelsCount;
        List<byte> levelsFillRatio;

        public Boolean set_map_params(UInt32 width, UInt32 height, UInt32 levelsCount, List<byte> levelsFillRatio)
        {
            Int32 countLevelsFillRatio = levelsFillRatio.Count;
            Boolean res = false;
            const string ERROR_MSG_UNCORECT_LEVELS_COUNT = "Неверное колличество уровней карты (levelsCount и levelsFillRatio.count должны быть равны)";

            if (levelsCount == countLevelsFillRatio)
            {
                this.width = width;
                this.height = height;
                this.levelsCount = levelsCount;
                this.levelsFillRatio = new List<byte>(countLevelsFillRatio);
                for (int i = 0; i < levelsCount; i++)
                {
                    this.levelsFillRatio.Add(levelsFillRatio[i]);
                }
                res = true;

            } else
            {
                throw new Exception(ERROR_MSG_UNCORECT_LEVELS_COUNT);
            }
            return res;
        }
        public UInt32 Width 
        {
            get { return this.width; }
        }
        public UInt32 Height
        {
            get { return this.height; }
        }
        public UInt32 LevelsCount
        {
            get { return this.levelsCount; }
        }
        public List<byte> LevelsFillRatio
        {
            get { return this.levelsFillRatio; }
        }
    }
}

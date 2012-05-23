﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    public interface ISet
    {
        void SetMaxLevel(int level);

        int GetMaxLevel();

        void SetCurrentLevel(int level);

        int GetCurrentLevel();

        void SetCurrentLevel(int level, ref List<int[]> alteredlist);
    }
}
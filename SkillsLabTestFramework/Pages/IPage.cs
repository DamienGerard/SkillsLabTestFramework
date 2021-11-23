using System;
using System.Collections.Generic;
using System.Text;

namespace SkillsLabTestFramework
{
    interface IPage
    {
        string Url { get; }

        void Goto();

        bool IsAt();
    }
}

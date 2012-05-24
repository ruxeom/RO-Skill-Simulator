using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    interface AbstractFactory
    {
        IDataManager CreateDataSource();
        IDataManager CreateSaveDataDestination();
        IDataManager CreateLoadDataSource();
        IGraphManager CreateGraphManager();
        ITreeBuilder CreateTreeBuilder();
    }
}

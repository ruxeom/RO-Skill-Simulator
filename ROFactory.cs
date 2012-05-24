using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    public class ROFactory:AbstractFactory
    {
        public IDataManager CreateDataSource()
        {
            return ROSQLExpressConnectionManager.Instance;
        }

        public IDataManager CreateSaveDataDestination()
        {
            return null;
        }

        public IDataManager CreateLoadDataSource()
        {
            return null;
        }

        public IGraphManager CreateGraphManager()
        {
            return new ROGraphManager();
        }

        public ITreeBuilder CreateTreeBuilder()
        {
            return new ROTreeBuilder();
        }
    }
}

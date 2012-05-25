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
            return new ROFileCommunicationManager();
        }

        public IDataManager CreateLoadDataSource()
        {
            return new ROFileCommunicationManager();
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

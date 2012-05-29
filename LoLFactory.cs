using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillSimulator
{
    public class LoLFactory :AbstractFactory
    {
        public IDataManager CreateDataSource()
        {
            return LoLSQLExpressConnectionManager2.Instance;
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
            return new LoLGraphManager();
        }

        public ITreeBuilder CreateTreeBuilder()
        {
            return new LoLTreeBuilder();
        }
    }
}

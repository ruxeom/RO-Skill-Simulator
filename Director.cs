using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace SkillSimulator
{
    public class Director: IObserver
    {
        private SkillSimulatorMainGUI GUIManager;
        private IDataManager DataSourceManager;
        private IDataManager SaveDataDestinationManager;
        private IDataManager LoadDataSourceManager;
        private ITreeBuilder TreeBuilder;
        private IGraphManager GraphManager;

        public Director()
        {
            GUIManager = new SkillSimulatorMainGUI();
            GraphManager = new ROGraphManager();
            TreeBuilder = new ROTreeBuilder();
            GUIManager.Subscribe(this);
            DataSourceManager = ROSQLExpressConnectionManager.Instance;
            Application.Run(GUIManager);
        }

        public void NotifyNew(int simtype) 
        {
            //Here we will change the factory to provide our director with the 
            //right IDataManagers and Builders
            if (simtype == Constants.LoLSimulator)
            {
                GUIManager.HideROSpecifics();
            }
            else if (simtype == Constants.ROSimulator)
            {
                GUIManager.ShowROSpecifics();
            }
        }
        public void NotifySelection(string name)
        {
            GraphManager = new ROGraphManager(); //use the factory to reload our graph manager (restart it)

            ArrayList nodes = DataSourceManager.GetNodes(name);
            List<ITree> trees = TreeBuilder.BuildTreesFromData(nodes);
            ArrayList edgedata = DataSourceManager.GetEdges(name);
            TreeBuilder.AddEdgesToTrees(trees, edgedata);
            GraphManager.AddTrees(trees);
            GUIManager.AddVisualNodes(GraphManager.GetAllNodes());
        }

        public void NotifyModification(int id, int lvl) { }
        public void NotifySave() { }
        public void NotifyLoad() { }
        public void NotifyClose() { }

        
    }
}

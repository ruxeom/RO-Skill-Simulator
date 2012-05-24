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
        private AbstractFactory Factory;

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
                //Factory = new LoLFactory();
            }
            else if (simtype == Constants.ROSimulator)
            {
                GUIManager.ShowROSpecifics();
                Factory = new ROFactory();
            }

            DataSourceManager = Factory.CreateDataSource();
            SaveDataDestinationManager = Factory.CreateSaveDataDestination();
            LoadDataSourceManager = Factory.CreateLoadDataSource();
            GraphManager = Factory.CreateGraphManager();
            TreeBuilder = Factory.CreateTreeBuilder();

            //A LoL simulator doesn't need further specification, so we can create it now,
            //but it has to be done AFTER the Factory was created.
            if (simtype == Constants.LoLSimulator)
                NotifySelection("");

        }
        public void NotifySelection(string name)
        {
            //use the factory to reload our graph manager (restart it)
            ArrayList nodes = DataSourceManager.GetNodes(name);
            List<ITree> trees = TreeBuilder.BuildTreesFromData(nodes);
            ArrayList edgedata = DataSourceManager.GetEdges(name);
            TreeBuilder.AddEdgesToTrees(trees, edgedata);
            GraphManager.AddTrees(trees);   //this method replaces the previous trees
            int usablepoints = DataSourceManager.GetTotalUsablePoints(name);
            GraphManager.AddGlobalUsablePoints(usablepoints);
            GUIManager.AddVisualNodes(GraphManager.GetAllNodes());
            GUIManager.SetStatus(GraphManager.GetStatus());
        }

        public void NotifyModification(int id, int lvl) 
        {
            List<int[]> alterednodes = GraphManager.ModifyNodeLevel(id, lvl);
            GUIManager.UpdateVisualNodes(alterednodes);
            GUIManager.SetStatus(GraphManager.GetStatus());
        }
        public void NotifySave() { }
        public void NotifyLoad() { }
        public void NotifyClose() { }
        
    }
}

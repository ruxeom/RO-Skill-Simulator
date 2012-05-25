using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.IO;

namespace SkillSimulator
{
    public class ROFileCommunicationManager: IDataManager
    {
        public ArrayList GetNodes(string treename)
        {
            return null;
        }

        public ArrayList GetEdges(string treename)
        {
            return null;
        }

        public ArrayList GetUsablePoints(string name)
        {
            return null;
        }

        public int GetTotalUsablePoints(string name)
        {
            return 0;
        }

        public ArrayList GetBuildNames()
        {
            return null;
        }

        public ArrayList GetBuild(string name)
        {
            return null;
        }

        public void SaveBuild(string game, string type, List<INode> nodes)
        {
            //It can happen that they try to save before creating a tree, in which case
            //it would be a pointless save.
            if (type != null)
            {
                SaveFileDialog d = new SaveFileDialog();
                d.Filter = "Sim files (*.sim)|*.sim";
                d.FilterIndex = 2;
                if (d.ShowDialog() == DialogResult.OK)
                {
                    TextWriter writer;
                    Stream stream;
                    if ((stream = d.OpenFile()) != null)
                    {
                        writer = new StreamWriter(stream);
                        writer.WriteLine("Type:");
                        writer.WriteLine(game + "-" + type);
                        writer.WriteLine("Build:");
                        foreach (INode node in nodes)
                            writer.WriteLine(node.ID + "-" + node.Currentlvl);
                        writer.Close();
                    }
                }
            }
            
        }
    }
}

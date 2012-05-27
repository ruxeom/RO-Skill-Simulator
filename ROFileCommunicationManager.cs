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

        public ArrayList GetBuild()
        {
            ArrayList data = null;
            //We check here the integrity of the "type" of simulator while checking the file
            //and show a notification in case it doesn't match the file.
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "SIM files (*.sim)|*.sim";
            d.FilterIndex = 2;
            if (d.ShowDialog() == DialogResult.OK)
            {
                TextReader reader;
                Stream stream;
                if ((stream = d.OpenFile()) != null)
                {
                    char[] split = {'-'};
                    reader = new StreamReader(stream);
                    data = new ArrayList();
                    string line;
                    string [] splitline;
                    object[] rawdata;
                    line = reader.ReadLine();

                    rawdata = new object[2];
                    splitline = line.Split(split);
                    rawdata[0] = splitline[0];
                    rawdata[1] = splitline[1];
                    data.Add(rawdata);
                    
                    while ((line = reader.ReadLine()) != null)
                    {
                        rawdata = new object[2];
                        splitline = line.Split(split);
                        rawdata[0] = Convert.ToInt32(splitline[0]);
                        rawdata[1] = Convert.ToInt32(splitline[1]);
                        data.Add(rawdata);
                    }
                    reader.Close();
                }
            }
            return data;
        }

        public void SaveBuild(string game, string type, List<INode> nodes)
        {
            //It can happen that they try to save before creating a tree, in which case
            //it would be a pointless save.
            if (type != null)
            {
                SaveFileDialog d = new SaveFileDialog();
                d.Filter = "SIM files (*.sim)|*.sim";
                d.FilterIndex = 2;
                if (d.ShowDialog() == DialogResult.OK)
                {
                    TextWriter writer;
                    Stream stream;
                    if ((stream = d.OpenFile()) != null)
                    {
                        writer = new StreamWriter(stream);
                        writer.WriteLine(game + "-" + type);
                        foreach (INode node in nodes)
                            writer.WriteLine(node.GetID() + "-" + node.Currentlvl);
                        writer.Close();
                    }
                }
            }
            
        }
    }
}

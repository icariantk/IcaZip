using System.Text;

namespace IcaZip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void makeFirstMove_Click(object sender, EventArgs e)
        {
            CountChars();
        }
        Dictionary<char, int> originalCount;
        private void CountChars()
        {
            char[] origText = original.Text.ToCharArray();
            originalCount = new Dictionary<char, int>();
            for (int c = 0; c != origText.Length; c++)
            {
                if (!originalCount.ContainsKey(origText[c]))
                {
                    originalCount.Add(origText[c], 1);
                }
                else
                {
                    originalCount[origText[c]]++;
                }
            }
            var sortedDict = from entry in originalCount orderby entry.Value ascending select entry;
            foreach (KeyValuePair<char, int> kvp in sortedDict)
            {
                charList.Items.Add(kvp.Key);
                countList.Items.Add(kvp.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CountChars();
            while (charList.Items.Count > 1)
            {
                GroupByLowest();
            }
            recurseTree();
            compressOriginalText();
        }

        private void compressOriginalText()
        {
            char[] origText = original.Text.ToCharArray();
            StringBuilder sb = new StringBuilder();
            for (int c = 0; c != origText.Length; c++)
            {
                sb.Append(compTree[origText[c]]);
            }
            
            while (sb.Length% 8 != 0)
            {
                sb.Append('0');
            }
            string input = sb.ToString();
            int numOfBytes = input.Length / 8;
            byte[] bytes = new byte[numOfBytes];
            for (int i = 0; i < numOfBytes; ++i)
            {
                bytes[i] = Convert.ToByte(input.Substring(8 * i, 8), 2);
            }
            List<byte> file = new List<byte>();
            //Add the number of chars counted
            file.AddRange(BitConverter.GetBytes(originalCount.Count));
            //add the char then the count
            foreach (KeyValuePair<char,int> kvp in originalCount){
                file.Add((byte)kvp.Key);
                file.AddRange(BitConverter.GetBytes(kvp.Value));
            }
            //add the original text size
            int size = origText.Length;
            file.AddRange(BitConverter.GetBytes(size));
            //add the compressed data
            file.AddRange(bytes);
            compress.Text = Convert.ToBase64String(bytes);
            tempBinary.Text=sb.ToString();
        }

        int newNodesCount;
        private void GroupLowest_Click(object sender, EventArgs e)
        {
            GroupByLowest();
        }

        private void GroupByLowest()
        {
            if (countList.Items.Count > 1)
            {
                newNodesCount++;
                string newName = "L" + newNodesCount;
                int newCount = (int)countList.Items[0] + (int)countList.Items[1];
                tv.Nodes.Add(newName);
                int lastnode = tv.Nodes.Count - 1;
                if (charList.Items[0].ToString().Length > 1)
                {
                    int index = -1;
                    for (int c = 0; c != tv.Nodes.Count; c++)
                    {
                        Console.WriteLine("Available NOdes:" + tv.Nodes[c]);
                        if (tv.Nodes[c].Text == charList.Items[0].ToString())
                        {
                            index = c;
                        }
                    }
                    tv.Nodes[lastnode].Nodes.Insert(0, (TreeNode)tv.Nodes[index].Clone());
                    tv.Nodes.RemoveAt(index);
                    lastnode--;
                }
                else
                {
                    tv.Nodes[lastnode].Nodes.Add(charList.Items[0].ToString());
                }
                if (charList.Items[1].ToString().Length > 1)
                {
                    int index = -1;
                    for (int c = 0; c != tv.Nodes.Count; c++)
                    {
                        Console.WriteLine("Available NOdes:" + tv.Nodes[c]);
                        if (tv.Nodes[c].Text == charList.Items[1].ToString())
                        {
                            index = c;
                        }
                    }
                    tv.Nodes[lastnode].Nodes.Insert(1, (TreeNode)tv.Nodes[index].Clone());
                    tv.Nodes.RemoveAt(index);
                    lastnode--;
                }
                else
                {
                    tv.Nodes[lastnode].Nodes.Add(charList.Items[1].ToString());
                }
                charList.Items.RemoveAt(0);
                charList.Items.RemoveAt(0);
                countList.Items.RemoveAt(0);
                countList.Items.RemoveAt(0);
                int indexToInsert = countList.Items.Count;
                for (int c = 0; c != countList.Items.Count; c++)
                {
                    if (newCount > (int)countList.Items[c])
                    {
                        indexToInsert = c + 1;
                    }
                }
                countList.Items.Insert(indexToInsert, newCount);
                charList.Items.Insert(indexToInsert, newName);
            }
        }

        private void transverseTree_Click(object sender, EventArgs e)
        {
            recurseTree();
        }
        Dictionary<char, string> compTree;
        private void recurseTree()
        {
            string vals = getValuesOfTree(tv.Nodes[0]);
            string[] valsReal = vals.Split('|');
            compTree = new Dictionary<char, string>();
            for (int c = 0; c != valsReal.Length; c++)
            {
                if (valsReal[c].Length > 0)
                {
                    if (c % 2 == 0)
                    {
                        dictValue.Items.Add(valsReal[c]);
                    }
                    else
                    {
                        dict.Items.Add(valsReal[c]);
                        compTree.Add(valsReal[c].ToCharArray()[0], valsReal[c-1]);

                    }
                }
            }
        }

        private string getValuesOfTree(TreeNode currentNode, string currentPath="")
        {
            if(currentNode.Nodes.Count> 0)
            {
                    return getValuesOfTree(currentNode.Nodes[0], currentPath+"0") + getValuesOfTree(currentNode.Nodes[1], currentPath+"1");
            }
            else
            {
                return currentPath+"|" +currentNode.Text+"|";
            }
        }

        private void CharCounter_Tick(object sender, EventArgs e)
        {
            label1.Text = "Original (" + (original.Text.Length)+" bytes)";
            if (compress.Text.Length > 0)
            {
                try
                {
                    label2.Text = "Compressed (" + Convert.FromBase64String(compress.Text).Length + " bytes)";
                }catch(Exception E)
                {
                    label2.Text = "Compressed";
                }
            }
            else
            {
                label2.Text = "Compressed";
            }
        }

        private void dict_SelectedIndexChanged(object sender, EventArgs e)
        {
            dictValue.SelectedIndex = dict.SelectedIndex;
        }
    }
}
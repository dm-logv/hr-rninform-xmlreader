using System;
using System.Collections.Generic;
using System.Windows.Forms;
using rn.rn_inform.test.Storage;


namespace rn.rn_inform.test
{
    class Tree
    {
        public static TreeNode PopulateTreeRoot(RNUObj RNUObj)
        {
            var TreeNode = new TreeNode();

            foreach (var Obj in getRNUObjStorage(RNUObj.Instance().InnerStorage))
            {
                String CurrentKey = Obj.Key;
                List<IContainer> CurrentValue = Obj.Value;
                TreeNode CurrentNode = TreeNode.Nodes.Add(CurrentKey);
                CurrentNode.Tag = CurrentValue;
                CurrentNode.Nodes.AddRange(PopulateTreeNodes(CurrentValue).ToArray());
            }

            return TreeNode;
        }

        public static List<TreeNode> PopulateTreeNodes(List<IContainer> ObjectList)
        {
            var TreeNodes = new List<TreeNode>();

            foreach (var CurrentObject in ObjectList)
            {
                var CurrentNode = new TreeNode(CurrentObject.Name);
                CurrentNode.Tag = CurrentObject;
                if (CurrentObject.GetType().GetProperty("InnerStorage") != null)
                {
                    CurrentNode.Nodes.AddRange(
                        PopulateTreeNodes(CurrentObject.InnerStorage).ToArray()
                        );
                }
                TreeNodes.Add(CurrentNode);
            }

            return TreeNodes;
        }

        public static SortedDictionary<String, List<IContainer>>
            getRNUObjStorage(List<ProjDocBinderRevision> InnerStorage)
        {
            var Dictionary = new SortedDictionary<String, List<IContainer>>();
            foreach (var CurrentObject in InnerStorage)
            {
                String key = CurrentObject.RNUObj;
                Dictionary[key].Add(CurrentObject);
            }

            return Dictionary;
        }
    }
}

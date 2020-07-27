using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEditor;
using UnityEngine;
namespace MiniGameSDK
{
    public class ISAdmobSetter : IBuildValueSetter
    {
        public void SetData(Dictionary<string, string> data)
        {
            string id = data["Admob Appid"];
            AdmboIdAsset.Inst.id = id;
            foreach (var item in AssetDatabase.FindAssets("AndroidManifest"))
            {
                string xmlPath = AssetDatabase.GUIDToAssetPath(item);
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlPath);
                PlayerPrefs.SetString(Application.identifier + "player_admob_id", id);
                var node = FindNode(xmlDoc, "/manifest/application/meta-data", "android:name", "com.google.android.gms.ads.APPLICATION_ID");
                if (node != null)
                {
                    node.Attributes["android:value"].Value = id;
                    xmlDoc.Save(xmlPath);
                    break;
                }
            }
        }
        static XmlNode FindNode(XmlDocument xmlDoc, string xpath, string attributeName, string attributeValue)
        {
            XmlNodeList nodes = xmlDoc.SelectNodes(xpath);
            //Debug.Log(nodes.Count);
            for (int i = 0; i < nodes.Count; i++)
            {
                XmlNode node = nodes.Item(i);
                string _attributeValue = node.Attributes[attributeName].Value;
                if (_attributeValue == attributeValue)
                {
                    return node;
                }
            }
            return null;
        }
    }

}

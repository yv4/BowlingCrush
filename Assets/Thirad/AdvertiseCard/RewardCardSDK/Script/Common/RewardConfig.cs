using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = ("Tools/RewardConfig"))]
public class RewardConfig : ScriptableObject
{   
	[SerializeField]
    [Header("True 会打印日志")]
    public bool DebugMode = true;


	[SerializeField]
	[Header ("同时下载数量")]
	[Range (3, 20)]
	public int maxDownloads = 3;
}

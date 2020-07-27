using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class RankingListData
{
    public int code;
    public RankingListItemData[] winning;
}

[System.Serializable]
public class RankingListItemData
{
    public int id;
    public string name;
    public int month;
    public int day;
    public string hour;
    public string sun_money;
    public string withdraw_sun_money;
}

public class RankingListItem : MonoBehaviour
{
    public Text ranking, name, date, time, price;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Init(RankingListItemData data)
    {
        ranking.text = data.id.ToString();
        name.text = data.name.Length > 11 ? data.name.Substring(0, 10) + "..." : data.name;
        date.text = data.day + "/" + data.month;
        time.text = data.hour;
        price.text = data.withdraw_sun_money;
    }
}

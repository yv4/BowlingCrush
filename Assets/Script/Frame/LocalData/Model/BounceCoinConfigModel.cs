using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCoinConfigModel : AbstractModel<BounceCoinConfigModel, BounceCoinConfigEntity>
{
    protected override string FileName
    {
        get
        {
            return "BounceCoinConfig.data";
        }
    }

    protected override BounceCoinConfigEntity MakeEntity(GameDataTableParser parse)
    {

        BounceCoinConfigEntity entity = new BounceCoinConfigEntity();

        entity.Id = int.Parse(parse.GetFieldValue("Id").ToString());
        entity.Border = parse.GetFieldValue("Border").ToString();
        entity.TwoPercent = float.Parse(parse.GetFieldValue("TwoPercent"));
        entity.FourPercent = float.Parse(parse.GetFieldValue("FourPercent"));
        entity.SixPercent = float.Parse(parse.GetFieldValue("SixPercent"));
        entity.EightPercent = float.Parse(parse.GetFieldValue("EightPercent"));
        entity.WinFail = int.Parse(parse.GetFieldValue("WinFail"));

        return entity;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollorMissionModel : AbstractModel<DollorMissionModel, DollorMissionEntity>
{
    protected override string FileName
    {
        get
        {
            return "DollorMission.data";
        }
    }

    protected override DollorMissionEntity MakeEntity(GameDataTableParser parse)
    {

        DollorMissionEntity entity = new DollorMissionEntity();

        entity.Id = int.Parse(parse.GetFieldValue("Id").ToString());
        entity.Mission = parse.GetFieldValue("Mission").ToString();
        entity.SuccessCount = int.Parse(parse.GetFieldValue("HardCount").ToString());

        return entity;
    }
}

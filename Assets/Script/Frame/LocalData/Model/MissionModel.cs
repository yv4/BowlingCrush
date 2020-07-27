using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionModel : AbstractModel<MissionModel, MissionEntity>
{
    protected override string FileName
    {
        get
        {
            return "Mission.data";
        }
    }

    protected override MissionEntity MakeEntity(GameDataTableParser parse)
    {

        MissionEntity entity = new MissionEntity();

        entity.Id = int.Parse(parse.GetFieldValue("Id").ToString());
        entity.MeshName = parse.GetFieldValue("MeshName").ToString();
        entity.Speed = float.Parse(parse.GetFieldValue("Speed").ToString());

        return entity;
    }
}

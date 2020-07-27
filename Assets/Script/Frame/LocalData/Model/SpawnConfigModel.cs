using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnConfigModel : AbstractModel<SpawnConfigModel, SpawnConfigEntity>
{
    protected override string FileName
    {
        get
        {
            return "SpawnConfig.data";
        }
    }

    protected override SpawnConfigEntity MakeEntity(GameDataTableParser parse)
    {

        SpawnConfigEntity entity = new SpawnConfigEntity();

        entity.Id = int.Parse(parse.GetFieldValue("Id").ToString());
        entity.Border = parse.GetFieldValue("Border").ToString();
        entity.EasyCount = int.Parse(parse.GetFieldValue("EasyCount").ToString());
        entity.NormalCount = int.Parse(parse.GetFieldValue("NormalCount").ToString());
        entity.HardCount = int.Parse(parse.GetFieldValue("HardCount").ToLower());

        return entity;
    }
}

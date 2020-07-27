using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItemModel : AbstractModel<ShopItemModel, ShopItemEntity>
{
    protected override string FileName
    {
        get
        {
            return "ShopItems.data";
        }
    }

    protected override ShopItemEntity MakeEntity(GameDataTableParser parse)
    {

        ShopItemEntity entity = new ShopItemEntity();

        entity.Id = int.Parse(parse.GetFieldValue("Id").ToString());
        entity.MeshName = parse.GetFieldValue("MeshName").ToString();
        entity.ShowSprite = parse.GetFieldValue("ShowSprite").ToString();
        entity.BuyCoin = int.Parse(parse.GetFieldValue("BuyCoin").ToString());

        return entity;
    }
}

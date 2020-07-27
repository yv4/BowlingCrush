﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractModel<T,P>
where T:class,new()
where P:AbstractEntity
{

    protected List<P> m_List;
    protected Dictionary<int, P> m_Dic;


    private string m_DataPath = "file://"+Application.streamingAssetsPath + "/";


    public AbstractModel()
    {
        m_List = new List<P>();
        m_Dic = new Dictionary<int, P>();
        LoadData();
    }

    #region 需要子类实现的属性或方法
    /// <summary>
    /// 数据文件名称
    /// </summary>
    protected abstract string FileName { get; }

    /// <summary>
    /// 创建实体
    /// </summary>
    /// <param name="parse"></param>
    /// <returns></returns>
    protected abstract P MakeEntity(GameDataTableParser parse);
    #endregion

    #region 加载数据 LoadData
    /// <summary>
    /// 加载数据
    /// </summary>
    private void LoadData()
    {

        using (GameDataTableParser parse = new GameDataTableParser(string.Format(m_DataPath+@"{0}", FileName)))
        {
            while (!parse.Eof)
            {
                //创建实体
                P p = MakeEntity(parse);
                m_List.Add(p);
                m_Dic[p.Id] = p;
                parse.Next();
            }
        }
    }
    #endregion

    #region GetList 获取集合

    /// <summary>
    /// 获取集合
    /// </summary>
    /// <returns></returns>
    public List<P> GetList()
    {
        return m_List;
    }


    #endregion

    #region Get 根据编号获取实体
    /// <summary>
    /// 根据编号获取实体
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public P Get(int id)
    {
        if (m_List!=null)
        {
            return m_List.Find(s => { return s.Id == id; });
        }

        return null;
    }
    #endregion
}

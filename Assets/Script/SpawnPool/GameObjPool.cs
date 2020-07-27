using PathologicalGames;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PoolName
{
    Bottle
}

public class GameObjPool : Singleton<GameObjPool> {

    //对象池键值表
    private Dictionary<PoolName, SpawnPool> m_SpawnPools=new Dictionary<PoolName, SpawnPool>();


    public override void Dispose()
    {
        base.Dispose();

        this.m_SpawnPools.Clear();
        //this.m_SpawnPools = null;
    }

    #region 创建池相关方法

    private void CreatePool(GameObject prefab,PoolName poolName,Transform parent=null)
    {
        SpawnPool pool = PoolManager.Pools.Create(poolName.ToString());

        //设置池的父物体
        pool.group.parent = parent;

        //池位置
        pool.group.localPosition = Vector3.zero;

        m_SpawnPools[poolName] = pool;

        //添加预设池
        CreatePrefabPool(prefab,poolName);
    }

    private void CreatePrefabPool(GameObject prefab,PoolName poolName)
    {
        //根据物体的种类创建多个子池 PrefabPool为预设池 有多少预设就创建多少预设池
        PrefabPool prefabPool = new PrefabPool(prefab.transform);

        //设置预设池的预加载数量
        prefabPool.preloadAmount = 5;

        //是否开启缓存池自动清理模式 
        //自动清理是指 比如刷10个怪 但是只出现了15个 多余的怪自动清理
        prefabPool.cullDespawned = true;

        //缓存池设为自动清理后 始终保持的物体数量 到此数量后不再清理
        prefabPool.cullAbove = 5;

        //设置多长时间进行一次清理 单位是秒
        prefabPool.cullDelay = 2;

        //每次清理的数量
        prefabPool.cullMaxPerPass = 2;

        //给池添加预设池
        m_SpawnPools[poolName].CreatePrefabPool(prefabPool);
    }

    /// <summary>
    /// 清除池中敌人
    /// </summary>
    public void ClearPool()
    {
        m_SpawnPools.Clear();
    }

    public GameObject CreateObj(GameObject prefab,PoolName poolName,Transform parent=null)
    {
        if (m_SpawnPools==null||!m_SpawnPools.ContainsKey(poolName))
        {
            CreatePool(prefab, poolName, parent);
        }


        //从池中取出需要的实例
        Transform tran = m_SpawnPools[poolName].Spawn(prefab);
        if (tran == null)
        {
            CreatePrefabPool(prefab,poolName);
            tran = m_SpawnPools[poolName].Spawn(prefab);
        }
        return tran.gameObject;
    }

    public void DestroyObj(GameObject enemyPrefab,PoolName poolName)
    {
        if (enemyPrefab)
        {
            m_SpawnPools[poolName].Despawn(enemyPrefab.transform);
        }
        //else
        //{
        //    Debug.Log("要回收的对象为Null");
        //}

        
    }

    #endregion

}

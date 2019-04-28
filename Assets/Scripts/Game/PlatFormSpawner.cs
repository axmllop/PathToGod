using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatFormSpawner : MonoBehaviour {


    public Vector3 startSpawnPos;
    private Vector3 platFormSpawnPostion;
    private int spawnPlatFormCount = 5;
    
    bool isLeftSpawn;
    ManagerVars vars;
       
    private void Start()
    {
        platFormSpawnPostion = startSpawnPos;
        vars = ManagerVars.GetManagerVars();
        for (int i = 0; i < 5; i++)
        {
            spawnPlatFormCount = 5;
            DecidePath();
        }
       GameObject go = Instantiate(vars.characterPre);
        go.transform.position = new Vector3(0, -35f, 0);
    }
    /// <summary>
    /// 确定路径
    /// </summary>
    private void DecidePath()
    {
        if (spawnPlatFormCount > 0)
        {
            spawnPlatFormCount--;
            SpawnPlatForm();
        }
        else
        {
            isLeftSpawn = !isLeftSpawn;
            spawnPlatFormCount = Random.Range(1, 4);
            SpawnPlatForm();
        }
    }
    /// <summary>
    /// 生成平台
    /// </summary>
    private void SpawnPlatForm()
    {
        SpawnNormalPlatForm();
        if (isLeftSpawn)
        {
            platFormSpawnPostion = new Vector3(platFormSpawnPostion.x - vars.nextXPos, platFormSpawnPostion.y + vars.nextYPos, 0);

        }
        else
        {
            platFormSpawnPostion = new Vector3(platFormSpawnPostion.x + vars.nextXPos, platFormSpawnPostion.y + vars.nextYPos, 0);
        }
    }
    /// <summary>
    /// 生成单个平台
    /// </summary>
    private void SpawnNormalPlatForm()
    {
        GameObject go = Instantiate(vars.NormalPlatFormPre, transform);
        go.transform.position = platFormSpawnPostion;
    }


}

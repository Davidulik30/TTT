using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void StartSpawn()
    {
        GameObject[] spawnpoints;
        GameObject[] plates;
        plates = GameObject.FindGameObjectsWithTag("plate");
        spawnpoints = GameObject.FindGameObjectsWithTag("Spawner");
        
        int i=1;
        int startSign=Random.Range(1, 3);
        

        for (int j = 0; j < 50; j++)
        {
            int start = Random.Range(0, 9);

            if (plates[start].GetComponent<Calculating>().sign == "none")
            {
                plates[start].GetComponent<Calculating>().fillingnumber = i;
                plates[start].GetComponent<Calculating>().sign = "occupied";
                spawnpoints[start].GetComponent<SpawnSigns>().SpawnSign(startSign + i);
                i++;
                
            }
        }
        


        /* foreach (var sample in spawnpoints)
         {
             sample.GetComponent<SpawnSigns>().SpawnSign();
         }*/
    }
}

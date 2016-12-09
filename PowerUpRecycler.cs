using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PowerUpRecycler : MonoBehaviour {

	public List<PowerUp> PowerUpList;
    public List<PowerUpSpawn> SpawnList;

    public bool CanSpawn = true;
    private int listIndex = 0;

	void Start()
	{
		
		PowerUpList = new List<PowerUp> ();
        SpawnList = new List<PowerUpSpawn>();
		//subscribes to the action
		PowerUp.PowerAction += PowerUpActionHandler;
        PowerUpSpawn.PowerSpawnAction += SpawnPointHandler;

        StartCoroutine(SpawnAtPoints()); 

	}
	//how the function handles the power up action
	void PowerUpActionHandler(PowerUp _p)
	{
		//adding to list
		PowerUpList.Add(_p);

	}

    //how the function handles the power up action
    void SpawnPointHandler(PowerUpSpawn _p)
    {
        //adding to list
        SpawnList.Add(_p);

    }

    void DeactivatePowerUps()

    {
        foreach (PowerUp item in PowerUpList)

        {
            item.gameObject.SetActive(false);
        }
    }

    public IEnumerator SpawnAtPoints()
    {
        yield return new WaitForSeconds(0.1f);
        DeactivatePowerUps();

        while (CanSpawn)
        {
            foreach (PowerUpSpawn point in SpawnList)

            {
                PowerUpList[listIndex].transform.position = point.transform.position;
                PowerUpList[listIndex].gameObject.SetActive(true);
                listIndex++;
                if (listIndex > PowerUpList.Count - 1)
                {
                    listIndex = 0;
                }
            }
            yield return new WaitForSeconds(3);
            DeactivatePowerUps();
        }
    }

}

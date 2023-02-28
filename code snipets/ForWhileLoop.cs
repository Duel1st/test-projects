using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForWhileLoop : MonoBehaviour
{
    public GameObject cube;
    private bool isTrue = true;
    public Vector3 spawnValue;
    public int value;
    
    void Start()
    {
        cube = Resources.Load<GameObject>("Cube");

        ForEachOfThese();

        //StartCoroutine(ForEachOfTheseTimer());
    }

    private void ForEachOfThese()
    {
        for(int i = 0; i < value; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValue.x, spawnValue.x), Random.Range(-spawnValue.y, spawnValue.y), spawnValue.z);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(cube, spawnPosition, spawnRotation);
        }
    }

    private IEnumerator ForEachOfTheseTimer()
    {
        while (isTrue)
        {
            for (int i = 0; i < value; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValue.x, spawnValue.x), Random.Range(-spawnValue.y, spawnValue.y), spawnValue.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(cube, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(3);
            }
            yield return new WaitForSeconds(3);
            if (!isTrue)
            {
                break;
            }
        }
    }
}

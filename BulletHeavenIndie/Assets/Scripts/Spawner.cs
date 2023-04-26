using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject basicEnemy;

    [SerializeField]
    private GameObject secondEnemy;

    [SerializeField]
    private float basicspawnInterval = 3.0f;

    [SerializeField]
    private float secondspawnInterval = 7.0f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy(basicspawnInterval, basicEnemy));
        StartCoroutine(SpawnEnemy(secondspawnInterval, secondEnemy));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnEnemy(float interval, GameObject enemy){

        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-10f, 10f), Random.Range(-15f, 15f), 0 ), Quaternion.identity);

        StartCoroutine(SpawnEnemy(interval, enemy));

    }
}

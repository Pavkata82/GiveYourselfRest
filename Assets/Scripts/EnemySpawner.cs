using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] monsterReference;

    private GameObject spawnedMonster;

    [SerializeField]
    private Transform leftPos, rightPos;

    private int randomSide;
    private int randomIndex;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMonsters());
    }

    IEnumerator SpawnMonsters()
    {
        while (true)
        {      
            yield return new WaitForSeconds(Random.Range(1, 5));

            randomIndex = Random.Range(0, monsterReference.Length);
            randomSide = Random.Range(0, 2);

            spawnedMonster = Instantiate(monsterReference[randomIndex]);

            if (randomSide == 0)
            {
                spawnedMonster.transform.position = leftPos.position;
                spawnedMonster.GetComponent<Enemy>().speed = Random.Range(4, 10);
                spawnedMonster.transform.localScale = new Vector3(-1.5f, 1.5f, 1.5f);
            }
            else
            {
                spawnedMonster.transform.position = rightPos.position;
                spawnedMonster.GetComponent<Enemy>().speed = -Random.Range(4, 10);
            }
        }
    }
}

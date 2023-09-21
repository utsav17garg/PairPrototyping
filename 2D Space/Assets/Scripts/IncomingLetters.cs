using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncomingLetters : MonoBehaviour
{
    public GameObject[] letters;
    public float SpawnTime = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());

    }

    // Update is called once per frame
    IEnumerator Spawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(SpawnTime);
            Spawn();
        }
    }

    void Spawn()
    {
        int randomValue = Random.Range(0, letters.Length);
        int randomY = Random.Range(-6, 6);
        Instantiate(letters[randomValue], new Vector2(transform.position.x, randomY), Quaternion.identity);
    }
}


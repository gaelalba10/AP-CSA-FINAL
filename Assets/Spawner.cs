using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{


        public GameObject enemeyPre; 
        public Sprite[] enemySprites;

        public int enemiesToSpawn = 10;

        private List<GameObject> activeEnemies = new List<GameObject>();

        public Vector2 randomPosition;



        void SpawnEnemies()
        {
           // GameObject newEnemy = Instantiate(enemeyPre, randomPosition, Quaternion.identity);

            for(int i =0; i < enemiesToSpawn; i++)
            {

            float randomX = Random.Range(-8f, 8f);
            float randomY = Random.Range(-4f, 4f);

            randomPosition = new Vector2(randomX, randomY);
            GameObject newEnemy = Instantiate(enemeyPre, randomPosition, Quaternion.identity);



                SpriteRenderer sr = newEnemy.GetComponent<SpriteRenderer>();
                if (sr != null && enemySprites.Length > 0)
                {
                    sr.sprite = enemySprites[Random.Range(0, enemySprites.Length)];
                }

                activeEnemies.Add(newEnemy);
            }

        }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnEnemies();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

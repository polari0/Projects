using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class SpawnObjects : MonoBehaviour
    {
        public int numberToSpawn;
        public List<GameObject> spawnpool;
        public GameObject quad;
        void Start()
        {
            spanwObjects();
        }
        public void spanwObjects()
        {
            int randomItem = 0;
            GameObject toSpawn;
            MeshCollider c = quad.GetComponent<MeshCollider>();

            float screenX, screenY;
            Vector2 pos;


            for (int i = 0; i < numberToSpawn; i++)
            {
                randomItem = Random.Range(0, spawnpool.Count);
                toSpawn = spawnpool[randomItem];

                screenX = Random.Range(c.bounds.min.x, c.bounds.min.x);
                screenY = Random.Range(c.bounds.min.y, c.bounds.min.y);
                pos = new Vector2(screenX, screenY);

                Instantiate(toSpawn, pos, toSpawn.transform.rotation);
            WaitScript.wait();
            }
        }
        private void destroyObject()
        {
            foreach (GameObject o in GameObject.FindGameObjectsWithTag("Spawnable"))
            {
                Destroy(o);
            }
        }
    }

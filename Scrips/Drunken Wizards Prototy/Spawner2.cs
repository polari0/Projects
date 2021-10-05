using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    public GameObject Tear;
    public float respawnTim = 1.0f;
    public GameObject quad;
    public Vector2 spawnArea;

    private void Start()
    {

    }

    private void spawnTear()
    {
        GameObject a = Instantiate(Tear) as GameObject;
    }
}

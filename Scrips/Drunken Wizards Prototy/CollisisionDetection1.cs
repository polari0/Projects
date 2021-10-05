using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisisionDetection1 : MonoBehaviour
{
    private int timesChecked = 0;
    //Adding variables

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Demons.PitchFork();
            WaitScript.Wait1();
        }
    }
}

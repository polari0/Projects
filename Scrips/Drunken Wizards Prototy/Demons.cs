using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demons : MonoBehaviour
{
    public int timesChecked = 0;

    public void PitchFork()
    {
        if (timesChecked < 2)
        {
            timesChecked = +1;
            if (timesChecked == 1)
            {
                Debug.Log("timesChecked = 1");
            }
            if (timesChecked == 2)
            {
                Debug.Log("timesChecked = 2");
                timesChecked = 0;
            }
        }
    }
}

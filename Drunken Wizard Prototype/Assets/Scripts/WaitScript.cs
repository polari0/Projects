using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitScript : MonoBehaviour
{
    public static bool lockBool = false;

    public static IEnumerator Wait1(float howLongToWait)
    {


        lockBool = !lockBool;
        yield return new WaitForSeconds(howLongToWait);
        lockBool = !lockBool;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitScript : MonoBehaviour
{
    public static IEnumerator Wait1()
    {
        yield return new WaitForSeconds(1);
    }
    public IEnumerator Wait2()
    {
        yield return new WaitForSeconds(2);
    }
    public IEnumerator Wait3()
    {
        yield return new WaitForSeconds(3);
    }
    public IEnumerator Wait4()
    {
        yield return new WaitForSeconds(4);
    }
    public IEnumerator Wait5()
    {
        yield return new WaitForSeconds(5);
    }
}

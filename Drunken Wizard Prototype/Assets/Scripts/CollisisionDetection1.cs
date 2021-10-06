using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisisionDetection1 : MonoBehaviour
{
    //private int timesChecked = 0;

    //[SerializeField]
    //private Demons demonsInstance;
    ////Adding variables

    //private void Start()
    //{
    //    demonsInstance = GetComponent<Demons>();
    //}
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.name == "Player")
    //    {
    //        print("We are here");
    //        demonsInstance.PitchFork();
    //        //WaitScript.Wait1(1f);
    //    }
    //}

    //private void OnTriggerStay(Collider other)
    //{
    //    if (other.gameObject.name == "Player")
    //    {
    //        print("We are here 2");
    //        demonsInstance.PitchFork();
    //        //WaitScript.Wait1(1f);
    //    }
    //}
    public GameObject tear;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Spawnable")
        {
            Destroy(collision.gameObject);
        }
    }
}


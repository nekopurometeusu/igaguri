using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollisionTarget : MonoBehaviour
{
    public int point = 10;
    private int count = 0;
    private void OnCollisionEnter(Collision collision)
    {
        count++;
        if (count == 100)
        {
            point *= 3;
            count = 0;
        }
        Score_Script.instance.ScoreManager(point);
        if(count % 10 == 0)
        {
            DestroyObject(collision.gameObject);
        }
    }
}

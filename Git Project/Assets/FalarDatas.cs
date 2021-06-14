using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalarDatas : MonoBehaviour
{
    public Transform[] g;
    void Start()
    {
        foreach(Transform t in g)
        {
            Debug.Log( t.position );
        }
    }

}

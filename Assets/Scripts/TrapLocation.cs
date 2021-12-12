using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapLocation : MonoBehaviour
{
    char nowIndex;
    private void Start()
    {
        nowIndex = transform.name[4];
    }
    char getNowIndex()
    {
        return nowIndex;
    }
    private void OnTriggerEnter(Collider other)
    {
        getNowIndex();
    }
}

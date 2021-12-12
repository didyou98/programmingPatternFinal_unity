using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlTraps : MonoBehaviour
{
    public GameObject player;
    public GameObject preview;
    int[] results = new int[10];
    int index = 0;
    int idx;
    // Start is called before the first frame update;
    void Start()
    {
        
        for(int i = 0; i < transform.childCount; i++)
        {
           results[index] = Random.Range(0, transform.GetChild(i).childCount);
           transform.GetChild(i).GetChild(Random.Range(0, results[i])).GetComponent<BoxCollider>().isTrigger = true;
            index++;
        }
        // preview.transform.GetChild(0).GetComponentInChildren<Image>().color = Color.red;
    }

    public int getHint()
    {
        return idx + 1;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject traps;
    Vector3 startPoint;
    bool bChange;
    public int nowIndex;
    CommandKey btnA, btnB;
    private void Start()
    {
        startPoint = transform.position;
        bChange = false;
        OnClickedChangePos();
    }

    public void OnClickedChangePos()
    {
        if(!bChange)
        {
            bChange = true;
            btnA = new CommandLeftRight(this.gameObject);
            btnB = new CommandUpDown(this.gameObject);
        }
        else
        {
            bChange = false;
            btnA = new CommandUpDown(this.gameObject);
            btnB = new CommandLeftRight(this.gameObject);
        }
    }
    void Update()
    {
        if(transform.position.y <= -2.0f)
        {
            transform.position = startPoint;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            btnA.Excute(-1.5f);
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            btnA.Excute(1.5f);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            btnB.Excute(1.5f);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            btnB.Excute(-1.5f);
        }
    }
}

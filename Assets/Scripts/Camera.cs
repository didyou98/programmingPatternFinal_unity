using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject preview;
    public GameObject player;
    CommandKey command;
    bool flag;
    void Start()
    {
        flag = true;
    }
    public void OnClickedChangeRotation()
    {

        if(flag)
        {
            command = new CommandSide(this.gameObject, player, preview);
            command.Excute(true);
            flag = false;
        }
        else
        {
            command = new CommandSide(this.gameObject, player, preview);
            command.Excute(false);
            flag = true;
        }
        
    }
}

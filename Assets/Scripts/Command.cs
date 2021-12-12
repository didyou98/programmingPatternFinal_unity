using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CommandKey
{
    public GameObject preview;
    public GameObject camera;
    public GameObject player;


    public virtual void Excute(bool flag) { }
    public virtual void Excute(float pos) { }

    public virtual void Undo() { }
}

public class CommandSide : CommandKey
{

    public CommandSide(GameObject camera, GameObject player, GameObject preview)
    {
        this.camera = camera;
        this.player = player;
        this.preview = preview;
    }

    public override void Excute(bool flag)
    {
        ChangeLoc(flag);
    }

    void ChangeLoc(bool flag)
    {
        float playerPosX = player.transform.position.x;
        float playerPosY = player.transform.position.y;
        float playerPosZ = player.transform.position.z;
        if (flag)
        {
            Debug.Log("시점 1");
            preview.transform.rotation = Quaternion.Euler(-180, 0, 90);
            camera.transform.rotation = Quaternion.Euler(90, 0, 90);
            camera.transform.position = new Vector3(0, 25, 0);
        }
        else
        {
            Debug.Log("시점 0");
            preview.transform.rotation = Quaternion.Euler(0, -180, 180);
            camera.transform.rotation = Quaternion.Euler(10f, 0, 0);
            camera.transform.position = new Vector3(playerPosX, playerPosY + 2f, playerPosY - 5f);
        }
    }
}


public class CommandUpDown : CommandKey
{
    public CommandUpDown(GameObject obj)
    {
        this.player = obj;
    }
    public override void Excute(float pos)
    {
        UpDown(pos);
    }

    void UpDown(float pos)
    {
        player.transform.Translate(new Vector3(0, 0, pos));
    }

}

public class CommandLeftRight : CommandKey
{
    public CommandLeftRight(GameObject obj)
    {
        this.player = obj;
    }
    public override void Excute(float pos)
    {
        LeftRight(pos);
    }

    void LeftRight(float pos)
    {
        player.transform.Translate(new Vector3(pos, 0, 0));
    }

}
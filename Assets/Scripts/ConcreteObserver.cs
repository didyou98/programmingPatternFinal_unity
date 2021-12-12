using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteObserver :  Observer
{
    GameObject obj;
    public ConcreteObserver(GameObject obj)
    {
        this.obj = obj;
    }
    public override void OnNotify()
    {
        int next = this.obj.GetComponent<ConcreteSubject>().nextResult();
        Debug.Log("이벤트 Called");
        Debug.Log("다음 칸은 " + next + "을 조심하세요");
    }
}

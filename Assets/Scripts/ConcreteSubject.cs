using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteSubject : MonoBehaviour, Subject
{
    public GameObject answer;
    List<Observer> observers = new List<Observer>();
    int result;
    public void AddObserver(Observer o)
    {
        observers.Add(o);
    }

    public void Notifiy()
    {
        foreach (Observer o in observers)
        {
            o.OnNotify();
        }
    }

    public void RemoveObserver(Observer o)
    {
        if (observers.IndexOf(o) > 0) observers.Remove(o);
    }

    void Start()
    {
        Observer obj = new ConcreteObserver(this.gameObject);
        AddObserver(obj);
    }

    public int nextResult()
    {
        result = answer.GetComponent<ControlTraps>().getHint();
        return result;
    }
}

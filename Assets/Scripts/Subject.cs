using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Subject
{
    void AddObserver(Observer o);
    void RemoveObserver(Observer o);
    void Notifiy();
}

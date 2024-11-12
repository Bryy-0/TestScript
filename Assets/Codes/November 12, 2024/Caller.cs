using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caller : MonoBehaviour
{
    [SerializeField] Chest chest;
    [SerializeField] Switch newSwitch;

    void Start()
    {
        chest.Interacted();
        newSwitch.Interacted();
    }
}

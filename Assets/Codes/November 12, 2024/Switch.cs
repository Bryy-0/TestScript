using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : Interaction
{

    public void Interacted()
    {
        if (isInteracted)
        {
            isInteracted = false;
        }
        else
        {
            isInteracted = true;
        }
    }

    private void DropLoot()
    {
        DisplayToolTips();
    }
}

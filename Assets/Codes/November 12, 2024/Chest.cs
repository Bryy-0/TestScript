using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Interaction
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
            DropLoot();
        }

    }

   /* private void DropLoot()
    {
        Debug.Log("Drop loots");
    }*/

    private void DropLoot()
    {
        DisplayToolTips();
    }
}

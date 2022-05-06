using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public bool selected = false;

    private void OnMouseDown()
    {
        if (selected)
        {
            selected = false;
        }
        else
        {
            selected = true;
        }
    }

}

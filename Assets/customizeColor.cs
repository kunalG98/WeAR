using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class customizeColor : MonoBehaviour
{

    public Material color;

    public Color one;
    public Color two;
    public Color three;
    public Color four;

    public void changeColor(int choice)
    {
        if (choice == 1)
            color.color = one;
        else if (choice == 2)
            color.color = two;
        else if (choice == 3)
            color.color = three;
        else if (choice == 4)
            color.color = four;
    }

}

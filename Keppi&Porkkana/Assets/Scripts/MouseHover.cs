using System.Collections;
using UnityEngine;

public class MouseHover : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        renderer.material.color = Color.black;
    }

    void OnMouseEnter()
    {
        renderer.material.color = Color.red;
    }

    void OnMouseExit()
    {
        renderer.material.color = Color.black;
    }
}
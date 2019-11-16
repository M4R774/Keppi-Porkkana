using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCarrot : MonoBehaviour
{

    public float distanceY = -75f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.y = distanceY;
        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
    }
}

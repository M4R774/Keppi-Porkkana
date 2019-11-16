using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCarrot : MonoBehaviour
{

    public float distanceY = 0;
    public float distanceZ = 40;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.y += distanceY;
        mousePosition.z += distanceZ;
        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
    }
}

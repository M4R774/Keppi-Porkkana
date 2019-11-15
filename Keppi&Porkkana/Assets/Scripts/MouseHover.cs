using System.Collections;
using UnityEngine;

public class MouseHover : MonoBehaviour {

    // Start is called before the first frame update
void Start() => renderer.material.color = Color.white;

void OnMouseEnter() => Renderer.material.color = Color.yellow;

void OnMouseExit() => Renderer.material.color = Color.white;

}

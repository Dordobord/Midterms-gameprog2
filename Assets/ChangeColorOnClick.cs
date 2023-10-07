using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnClick : MonoBehaviour
{
    public Material[] colorMaterials; // Assign the color materials in the Inspector

    private Renderer playerRenderer;

    private void Start()
    {
        playerRenderer = GetComponent<Renderer>();
    }

    private void OnMouseDown()
    {
        // Check if there are materials in the array
        if (colorMaterials.Length > 0)
        {
            // Choose a random index from the array
            int randomIndex = Random.Range(0, colorMaterials.Length);

            // Change the player's material to the randomly selected material
            playerRenderer.material = colorMaterials[randomIndex];
        }
    }
}

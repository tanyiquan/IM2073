using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSystem : MonoBehaviour
{// A slot to drag your Text object into
    public GameObject interactText;
    bool player_detection = false;
    void Start()
    {
        // Safety: Make sure text is OFF when game starts
        if (interactText != null)
            interactText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // 1. Check if the F key works AT ALL
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("F key was pressed! Current Detection Status: " + player_detection);
        }

        if (player_detection && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Dialogue Started!");
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "PlayerCapsule")
        {
            player_detection = true;
            // Turn Text ON
            if (interactText != null)
                interactText.SetActive(true);
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.name == "PlayerCapsule")
        {
            player_detection = false;

            // Turn Text OFF
            if (interactText != null)
                interactText.SetActive(false);
        }
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGateController : MonoBehaviour
{
    [SerializeField] private Animator myGate_L = null;
    [SerializeField] private Animator myGate_R = null;
    [SerializeField] private bool GateTrigger = false;
    private bool isOpen = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isOpen) //comparing the Tag for Player, and checking that animation hasn't been played yet
        {
            OpenGates();
        }
    }

    
    private void OpenGates() //function for playing animation
    {
        if (GateTrigger)
        {
            myGate_L.Play("GateDoorOpen_L", 0, 0.0f);
            myGate_R.Play("GateDoorOpen_R", 0, 0.0f);
            isOpen = true;
        }
    }

}

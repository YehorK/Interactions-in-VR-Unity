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
        if (other.CompareTag("Player") && !isOpen)
        {
            OpenGates();
        }
    }

    private void OpenGates()
    {
        if (GateTrigger)
        {
            myGate_L.Play("GateDoorOpen_L", 0, 0.0f);
            myGate_R.Play("GateDoorOpen_R", 0, 0.0f);
            isOpen = true;
        }
    }

}

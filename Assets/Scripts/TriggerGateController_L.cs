using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGateController_L : MonoBehaviour
{
    [SerializeField] private Animator myGate = null;

    [SerializeField] private bool GateTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (GateTrigger)
            {
                myGate.Play("GateDoorOpen_L", 0, 0.0f);
            }
            else { 
                return;
            }
            //else if (!GateTrigger)
            //{
            //    myGate.Play("GateDoorClose_L", 0, 0.0f);
            //}
        }
    }
}

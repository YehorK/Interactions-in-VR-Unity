using UnityEngine;

public class PumpkinToThrow : MonoBehaviour
{
    private PumpkinManager pumpkinManager;

    private void Start()
    {
        pumpkinManager = FindObjectOfType<PumpkinManager>();  // Get the reference to the PumpkinManager
    }

    private void OnTriggerEnter(Collider other) // Detecting collision
    {
        if (other.CompareTag("Cauldron"))  // The cauldron must have the "Cauldron" tag
        {
            pumpkinManager.OnPumpkinHitCauldron();  // Notify the manager when a pumpkin hits the cauldron
        }
    }
}

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
        Debug.Log("OnTrigger Enter is working");
        if (other.CompareTag("Cauldron"))  // Ensure that the cauldron has the "Cauldron" tag
        {
            pumpkinManager.OnPumpkinHitCauldron();  // Notify the manager when a pumpkin hits the cauldron
        }
    }
}

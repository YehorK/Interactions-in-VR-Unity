using UnityEngine;

public class PumpkinManager : MonoBehaviour
{
    [SerializeField] private GameObject pumpkinPrefab;  // The pumpkin prefab to spawn
    [SerializeField] private Transform spawnLocation;   // The location where the pumpkin spawns
    [SerializeField] private GameObject newObject;      // The object that becomes active after 3 hits - in our case the lit cauldron
    private GameObject currentPumpkin;  // Reference to the current pumpkin
    private Vector3 lastPosition;  // Last known position of the pumpkin
    private float stillTimer = 0f;  // Timer for how long the pumpkin has been still
    private bool hasMoved = false;  // Flag to check if the pumpkin has been moved from its spawn position
    private int pumpkinHitCount = 0;  // Counter for how many times pumpkins have hit the cauldron

    private void Start()
    {
        SpawnPumpkin();  // Spawn the first pumpkin at the start
    }

    private void Update()
    {
        if (currentPumpkin != null)
        {
            Vector3 currentPosition = currentPumpkin.transform.position;

            // Check if the pumpkin has been moved from the spawn position
            if (!hasMoved && currentPosition != spawnLocation.position)
            {
                hasMoved = true;  // Mark that the pumpkin has been moved
            }

            // If the pumpkin has been moved, check if it stays still
            if (hasMoved)
            {
                if (currentPosition == lastPosition)
                {
                    stillTimer += Time.deltaTime;  // Increase timer if pumpkin is still
                }
                else
                {
                    stillTimer = 0f;  // Reset the timer if the pumpkin moves
                }

                // If the pumpkin hasn't moved for 5 seconds, destroy and spawn a new one
                if (stillTimer >= 5f)
                {
                    DestroyPumpkin();
                    SpawnPumpkin();
                }
            }

            lastPosition = currentPosition;  // Update the last known position
            if (lastPosition.y < -1)
            {
                DestroyPumpkin();
                SpawnPumpkin();
            }
        }
    }

    // Method to spawn a new pumpkin at the specified location
    private void SpawnPumpkin()
    {
        currentPumpkin = Instantiate(pumpkinPrefab, spawnLocation.position, spawnLocation.rotation);
        lastPosition = currentPumpkin.transform.position;  // Initialize last position
        stillTimer = 0f;  // Reset the still timer
        hasMoved = false;  // Reset the moved flag
    }

    // Destroy the current pumpkin
    private void DestroyPumpkin()
    {
        if (currentPumpkin != null)
        {
            Destroy(currentPumpkin);  // Destroy the pumpkin
        }
    }

    // Increment the hit count when a pumpkin hits the cauldron
    public void OnPumpkinHitCauldron()
    {
        pumpkinHitCount++;  // Increment the hit count

        if (pumpkinHitCount == 5) // == instead of >= so that the toggle function is used only once
        {
            ToggleNewObject();  // Activate or toggle the new object after 3 hits
        }
    }

    // Method to toggle the active status of the new object
    private void ToggleNewObject()
    {
        newObject.SetActive(!newObject.activeSelf);  // Toggle active status of the new object (the lit cauldron)
    }
}

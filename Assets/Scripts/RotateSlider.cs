using UnityEngine;
using UnityEngine.UI;  // Include this for UI elements

public class RotateSlider : MonoBehaviour
{
    public float rotationSpeed = 50f; // Speed of rotation
    public Slider rotationSlider; // Reference to the slider

    private void Start()
    {
        // Initialize the slider value to the current Y rotation of the scarecrow
        rotationSlider.value = transform.eulerAngles.y;
        // Add listener for when the slider value changes
        rotationSlider.onValueChanged.AddListener(SetRotation);
    }

    // Method to rotate the scarecrow based on slider value
    public void SetRotation(float value)
    {
        // Set the scarecrow's rotation based on the slider's value
        transform.rotation = Quaternion.Euler(0, value, 0); // Rotate around the Y-axis
    }

    private void OnDestroy()
    {
        // Clean up the listener when the object is destroyed
        rotationSlider.onValueChanged.RemoveListener(SetRotation);
    }
}

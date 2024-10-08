using UnityEngine;
using UnityEngine.UI; 

public class RotateSlider : MonoBehaviour
{
    public float rotationSpeed = 30f; // Speed of rotation
    public Slider rotationSlider; // Reference to the slider

    private void Start()
    {
        // Initialize the slider value to the current Y rotation of the scarecrow
        rotationSlider.value = transform.eulerAngles.y;
        // Add listener for when the slider value changes
        rotationSlider.onValueChanged.AddListener(SetRotation);
    }

    // Method to rotate the scarecrow based on slider input
    public void SetRotation(float value)
    {
        // Set the object's rotation based on the slider's value
        transform.rotation = Quaternion.Euler(0, value, 0); // Rotation around the Y-axis
    }


    // Good practice to have the OnDestroy() to clean up the listener, however, it's not needed for our setup
    //private void OnDestroy()
    //{
    //    // Clean up the listener when the object is destroyed
    //    rotationSlider.onValueChanged.RemoveListener(SetRotation);
    //}
}

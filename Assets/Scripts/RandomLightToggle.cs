using UnityEngine;
using System.Collections;

public class RandomLightToggle : MonoBehaviour
{
    // Array to store references to the lights
    public Light[] lights;

    // Minimum and maximum interval for toggling lights (in seconds)
    public float minToggleInterval = 1f;
    public float maxToggleInterval = 5f;

    void Start()
    {
        if (lights.Length == 0)
        {
            Debug.LogError("No lights assigned to the RandomLightToggle script.");
            return;
        }

        // Start the coroutine for each light
        foreach (Light light in lights)
        {
            StartCoroutine(ToggleLightRoutine(light));
        }
    }

    private IEnumerator ToggleLightRoutine(Light light)
    {
        while (true)
        {
            // Wait for a random amount of time
            float waitTime = Random.Range(minToggleInterval, maxToggleInterval);
            yield return new WaitForSeconds(waitTime);

            // Toggle the light's active state
            light.enabled = !light.enabled;
        }
    }
}

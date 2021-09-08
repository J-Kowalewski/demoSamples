using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class SaturationTest : MonoBehaviour
{
    private PostProcessVolume volume;
    private ColorGrading colorGrading;

    // Start is called before the first frame update
    void Start()
    {
        volume = GetComponent<PostProcessVolume>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("t"))
        {
            ChangeSaturationIntensity(-10);
        }
        if (Input.GetKeyDown("y"))
        {
            ChangeSaturationIntensity(10);
        }
    }

    void ChangeSaturationIntensity(int value)
    {
        volume.profile.TryGetSettings(out colorGrading);
        int currentValue = (int) colorGrading.saturation.value;
      
        colorGrading.saturation.value = Mathf.Clamp(currentValue + value, -80, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public GameObject cubeSoundPrefab;
    public GameObject cylinderSoundPrefab;
    public GameObject capsuleSoundPrefab;

    public GameObject soundParent;
    public GameObject cubeSoundObj;
    public GameObject cylinderSoundObj;
    public GameObject capsuleSoundObj;

    public GameObject modulePrefab;
    public GameObject moduleParent;
    public GameObject ui;

    readonly Color FILTER_MODULE_COLOR = Color.red;
    readonly Color VOLUMN_UP_MODULE_COLOR = Color.black;
    readonly Color VOLUMN_DOWN_MODULE_COLOR = Color.white;
    readonly Color PITCH_UP_MODULE_COLOR = Color.blue;
    readonly Color PITCH_DOWN_MODULE_COLOR = Color.green;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void resetCubeSound()
    {
        // destroy old sound;
        Destroy(cubeSoundObj);

        // instantiate new cube sound
        cubeSoundObj = Instantiate(cubeSoundPrefab, soundParent.transform);
        cubeSoundObj.name = "CubeSound";
    }

    public void resetCylinderSound()
    {
        // destroy old sound;
        Destroy(cylinderSoundObj);

        // instantiate new cylinder sound
        cylinderSoundObj = Instantiate(cylinderSoundPrefab, soundParent.transform);
        cubeSoundObj.name = "CylinderSound";
    }

    public void resetCapsuleSound()
    {
        // destroy old sound;
        Destroy(capsuleSoundObj);

        // instantiate new capsule sound
        capsuleSoundObj = Instantiate(capsuleSoundPrefab, soundParent.transform);
        cubeSoundObj.name = "CapsuleSound";
    }

    #region Module Instantiate
    public void InstantiateFilterModule()
    {
        // Instantiate the module
        GameObject newModule = Instantiate(modulePrefab, moduleParent.transform.position, moduleParent.transform.rotation, moduleParent.transform);
        // Change Color
        newModule.GetComponent<Renderer>().material.color = FILTER_MODULE_COLOR;
        newModule.name = "FilterModule";
    }

    public void InstantiateVolumeUpModule()
    {
        // Instantiate the module
        GameObject newModule = Instantiate(modulePrefab, moduleParent.transform.position, moduleParent.transform.rotation, moduleParent.transform);
        // Change Color
        newModule.GetComponent<Renderer>().material.color = VOLUMN_UP_MODULE_COLOR;
        newModule.name = "VolumeUpModule";
    }

    public void InstantiateVolumeDownModule()
    {
        // Instantiate the module
        GameObject newModule = Instantiate(modulePrefab, moduleParent.transform.position, moduleParent.transform.rotation, moduleParent.transform);
        // Change Color
        newModule.GetComponent<Renderer>().material.color = VOLUMN_DOWN_MODULE_COLOR;
        newModule.name = "VolumeDownModule";
    }

    public void InstantiatePitchUpModule()
    {
        // Instantiate the module
        GameObject newModule = Instantiate(modulePrefab, moduleParent.transform.position, moduleParent.transform.rotation, moduleParent.transform);
        // Change Color
        newModule.GetComponent<Renderer>().material.color = PITCH_UP_MODULE_COLOR;
        newModule.name = "PitchUpModule";
    }

    public void InstantiatePitchDownModule()
    {
        // Instantiate the module
        GameObject newModule = Instantiate(modulePrefab, moduleParent.transform.position, moduleParent.transform.rotation, moduleParent.transform);
        // Change Color
        newModule.GetComponent<Renderer>().material.color = PITCH_DOWN_MODULE_COLOR;
        newModule.name = "PitchDownModule";
    }
    #endregion


    #region Helper Functions
    /// <summary>
    /// return the average val of two colors
    /// </summary>
    /// <param name="moduleColor"></param>
    /// <param name="soundColor"></param>
    /// <returns></returns>
    static public Color GetMergedColor(Color soundColor, Color moduleColor)
    {
        return new Color((moduleColor.r + soundColor.r)/2, (moduleColor.g + soundColor.g)/2, (moduleColor.b + soundColor.b)/2);
    }

    #endregion
}

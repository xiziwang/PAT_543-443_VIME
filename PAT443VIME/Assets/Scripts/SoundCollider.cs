using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCollider : MonoBehaviour
{
    public float SIZE_INCREMENT_X = 0.1f;
    public float SIZE_INCREMENT_Y = 0.1f;
    public float SIZE_INCREMENT_Z = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.name)
        {
            case "FilterModule":
                // change the color and the size
                GetComponent<Renderer>().material.color = InteractionManager.GetMergedColor(GetComponent<Renderer>().material.color, other.gameObject.GetComponent<Renderer>().material.color);
                transform.parent.localScale += new Vector3(SIZE_INCREMENT_X, SIZE_INCREMENT_Y, SIZE_INCREMENT_Z);
                transform.localScale += new Vector3(SIZE_INCREMENT_X, SIZE_INCREMENT_Y, SIZE_INCREMENT_Z);

                // TODO: edit audio

                // destroy the module
                Destroy(other.gameObject);
                break;
            case "VolumeUpModule":
                // change the color and the size
                GetComponent<Renderer>().material.color = InteractionManager.GetMergedColor(GetComponent<Renderer>().material.color, other.gameObject.GetComponent<Renderer>().material.color);
                transform.parent.localScale += new Vector3(SIZE_INCREMENT_X, SIZE_INCREMENT_Y, SIZE_INCREMENT_Z);
                transform.localScale += new Vector3(SIZE_INCREMENT_X, SIZE_INCREMENT_Y, SIZE_INCREMENT_Z);

                // TODO: edit audio

                // destroy the module
                Destroy(other.gameObject);
                break;
            case "VolumeDownModule":
                // change the color and the size
                GetComponent<Renderer>().material.color = InteractionManager.GetMergedColor(GetComponent<Renderer>().material.color, other.gameObject.GetComponent<Renderer>().material.color);
                transform.parent.localScale += new Vector3(SIZE_INCREMENT_X, SIZE_INCREMENT_Y, SIZE_INCREMENT_Z);
                transform.localScale += new Vector3(SIZE_INCREMENT_X, SIZE_INCREMENT_Y, SIZE_INCREMENT_Z);

                // TODO: edit audio

                // destroy the module
                Destroy(other.gameObject);
                break;
            case "PitchUpModule":
                // change the color and the size
                GetComponent<Renderer>().material.color = InteractionManager.GetMergedColor(GetComponent<Renderer>().material.color, other.gameObject.GetComponent<Renderer>().material.color);
                transform.parent.localScale += new Vector3(SIZE_INCREMENT_X, SIZE_INCREMENT_Y, SIZE_INCREMENT_Z);
                transform.localScale += new Vector3(SIZE_INCREMENT_X, SIZE_INCREMENT_Y, SIZE_INCREMENT_Z);

                // TODO: edit audio

                // destroy the module
                Destroy(other.gameObject);
                break;
            case "PitchDownModule":
                // change the color and the size
                GetComponent<Renderer>().material.color = InteractionManager.GetMergedColor(GetComponent<Renderer>().material.color, other.gameObject.GetComponent<Renderer>().material.color);
                transform.parent.localScale += new Vector3(SIZE_INCREMENT_X, SIZE_INCREMENT_Y, SIZE_INCREMENT_Z);
                transform.localScale += new Vector3(SIZE_INCREMENT_X, SIZE_INCREMENT_Y, SIZE_INCREMENT_Z);

                // TODO: edit audio

                // destroy the module
                Destroy(other.gameObject);
                break;
            default:
                break;
        }

    }
}

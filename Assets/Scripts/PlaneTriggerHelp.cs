using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneTriggerHelp : MonoBehaviour
{
    public AudioSource targetAudioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (targetAudioSource != null && !targetAudioSource.enabled)
            {
                targetAudioSource.enabled = true;
                targetAudioSource.Play();
            }
        }
    }
}

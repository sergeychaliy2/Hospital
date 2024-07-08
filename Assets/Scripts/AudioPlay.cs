using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    public AudioSource audios;
    public void PlayAudios()
    {
        if (audios != null && !audios.enabled)
        {
            audios.enabled = true;
            audios.Play();
        }
    }
}

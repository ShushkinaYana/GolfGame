using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class AudioManager : MonoBehaviour
    {
        public void PlayAudio(AudioClip clip )
        {
            GetComponent<AudioSource>().PlayOneShot(clip);
        }
    }
}

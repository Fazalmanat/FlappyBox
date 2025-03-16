using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiooo : MonoBehaviour
{
    [SerializeField] AudioSource musicsnd;
    [SerializeField] AudioSource sfxsound;

    public AudioClip background;
    public AudioClip jump;
    public AudioClip score;
    public AudioClip death;

    private void Start()
    {
            musicsnd.clip = background;
            musicsnd.Play();
    }
    public void playsfx(AudioClip clip)
    {
        sfxsound.PlayOneShot(clip);
    }


}

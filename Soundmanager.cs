using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundmanager : MonoBehaviour
{
    public AudioClip specialSound;
    public AudioClip dismissalSound;
    public AudioClip dicerollSound;
    public AudioClip winSound;
    public AudioClip safeHouseSound;
    public AudioClip playermoveSound;

    public static AudioSource playermoveSoundSource;
    public static AudioSource safeHouseSoundSource;
    public static AudioSource winSoundSource;
    public static AudioSource specialSoundSource;
    public static AudioSource dicerollSoundSource;
    public static AudioSource dismissalSoundSource;

    AudioSource AddAudio(AudioClip clip,bool playonawake,bool loop,float volume)
    {
        AudioSource audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = clip;
        audioSource.playOnAwake = playonawake;
        audioSource.loop = loop;
        audioSource.volume = volume;
        return audioSource;
     }

    // Start is called before the first frame update
    void Start()
    {
        specialSoundSource = AddAudio(specialSound, false, false, 1.0f);
        dismissalSoundSource = AddAudio(dismissalSound, false, false, 1.0f);
        playermoveSoundSource = AddAudio(playermoveSound, false, false, 1.0f);
        dicerollSoundSource = AddAudio(dicerollSound, false, false, 1.0f);
        winSoundSource=AddAudio(winSound,false,false, 1.0f);
        safeHouseSoundSource=AddAudio(safeHouseSound,false,false, 1.0f);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

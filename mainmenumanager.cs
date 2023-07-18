using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
public class mainmenumanager : MonoBehaviour
{
    public static int  number_players=3;

    public void two_players()
    {
        Soundmanager.specialSoundSource.Play();
        number_players = 2;
        SceneManager.LoadScene("ludo");
    }
    public void three_players()
    {
        Soundmanager.specialSoundSource.Play();
        number_players = 3;
        SceneManager.LoadScene("ludo");
    }
    public void four_players()
    {
        Soundmanager.specialSoundSource.Play();
        number_players = 4;
        SceneManager.LoadScene("ludo");
    }
    public void quit()
    {
        Soundmanager.specialSoundSource.Play();
        if(EditorApplication.isPlaying)
        {
            EditorApplication.isPlaying = false;
        }
    }
    
    // Start is called before the first frame update
    
}

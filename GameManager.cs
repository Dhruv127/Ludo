using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.Netcode;
using TMPro;

public class GameManager : NetworkBehaviour

{
    public TMP_Text first_position;
    public TMP_Text second_position;
    public TMP_Text third_position;
    public TMP_Text fourth_position;
     
    public int toatalredhiuse, totalyellowhouse, totalgreenhouse, totalbluehouse;

    public GameObject redFrame, yellowFrame, blueFrame, greenFrame;

    public GameObject redplayer1Caze, redplayer2Caze, redplayer3Caze, redplayer4Caze;
    public GameObject yellowplayer1Caze, yellowplayer2Caze, yellowplayer3Caze, yellowplayer4Caze;
    public GameObject blueplayer1Caze, blueplayer2Caze, blueplayer3Caze, blueplayer4Caze;
    public GameObject greenplayer1Caze, greenplayer2Caze, greenplayer3Caze, greenplayer4Caze;

    public Vector3 redplayer1pos, redplayer2pos, redplayer3pos, redplayer4pos;
    public Vector3 yellowplayer1pos, yellowplayer2pos, yellowplayer3pos, yellowplayer4pos;
    public Vector3 blueplayer1pos, blueplayer2pos, blueplayer3pos, blueplayer4pos;
    public Vector3 greenplayer1pos, greenplayer2pos, greenplayer3pos, greenplayer4pos;

    public Transform diceRoll;
    public Transform redDiceRoll, greenDiceRoll, blueDiceRoll, yellowDiceRoll;

    public Button diceRollButton;

    public Button redplayer1Button, redplayer2Button, redplayer3Button, redplayer4Button;
    public Button yellowplayer1Button, yellowplayer2Button, yellowplayer3Button, yellowplayer4Button;
    public Button blueplayer1Button, blueplayer2Button, blueplayer3Button, blueplayer4Button;
    public Button greenplayer1Button, greenplayer2Button, greenplayer3Button, greenplayer4Button;

    public GameObject redplayer1, redplayer2, redplayer3, redplayer4;
    public GameObject yellowplayer1, yellowplayer2, yellowplayer3, yellowplayer4;
    public GameObject blueplayer1, blueplayer2, blueplayer3, blueplayer4;
    public GameObject greenplayer1, greenplayer2, greenplayer3, greenplayer4;

    public GameObject redScreen, blueScreen, yellowScreen, greenScreen;

    public int redplayer1Steps, redplayer2Steps, redplayer3Steps, redplayer4Steps;
    public int yellowplayer1Steps, yellowplayer2Steps, yellowplayer3Steps, yellowplayer4Steps;
    public int blueplayer1Steps, blueplayer2Steps, blueplayer3Steps, blueplayer4Steps;
    public int greenplayer1Steps, greenplayer2Steps, greenplayer3Steps, greenplayer4Steps;

    private int selectDiceNumAnimation;

    public GameObject dice1RollAnimation, dice2RollAnimation, dice3RollAnimation,
        dice4RollAnimation, dice5RollAnimation, dice6RollAnimation;

    public List<GameObject> redMovementBlock = new List<GameObject>();
    public List<GameObject> yellowMovementBlock = new List<GameObject>();
    public List<GameObject> greenMovementBlock = new List<GameObject>();
    public List<GameObject> blueMovementBlock = new List<GameObject>();

    public string playerTurn = "RED";

    public GameObject exitScreen;
    public GameObject GameCompleteScreen;
    public GameObject red;
    public GameObject green;
    public Vector3 redPlayer1path;
    public Vector3 greenPlayer1path;
    public Vector3 red1, green1;
    public bool Safe;
    public bool redplayer1sizeReduced = false;
    public bool redplayer2sizeReduced = false;
    public bool redplayer3sizeReduced = false;
    public bool redplayer4sizeReduced = false;

    public bool greenplayer1sizeReduced = false;
    public bool greenplayer2sizeReduced = false;
    public bool greenplayer3sizeReduced = false;
    public bool greenplayer4sizeReduced = false;

    public bool blueplayer1sizeReduced = false;
    public bool blueplayer2sizeReduced = false;
    public bool blueplayer3sizeReduced = false;
    public bool blueplayer4sizeReduced = false;

    public bool yellowplayer1sizeReduced = false;
    public bool yellowplayer2sizeReduced = false;
    public bool yellowplayer3sizeReduced = false;
    public bool yellowplayer4sizeReduced = false;

    public bool redplayer1safeWin = false;
    public bool redplayer2safeWin = false;
    public bool redplayer3safeWin = false;
    public bool redplayer4safeWin = false;

    public bool greenplayer1safeWin = false;
    public bool greenplayer2safeWin = false;
    public bool greenplayer3safeWin = false;
    public bool greenplayer4safeWin = false;

    public bool blueplayer1safeWin = false;
    public bool blueplayer2safeWin = false;
    public bool blueplayer3safeWin = false;
    public bool blueplayer4safeWin = false;

    public bool yellowplayer1safeWin = false;
    public bool yellowplayer2safeWin = false;
    public bool yellowplayer3safeWin = false;
    public bool yellowplayer4safeWin = false;

    public void Exit()
    {
        Soundmanager.specialSoundSource.Play();
        exitScreen.SetActive(true);
    }
    public void No()
    {
        Soundmanager.specialSoundSource.Play();
        exitScreen.SetActive(false);
    }
    public void Yes()
    {
        Soundmanager.specialSoundSource.Play();
        SceneManager.LoadScene("mainMenuScene");
    }
    public void GameCompeleted()
    {
        Soundmanager.specialSoundSource.Play();
        GameCompleteScreen.SetActive(true);
    }
    public void yesCompleted()
    {
        Soundmanager.specialSoundSource.Play();
        SceneManager.LoadScene("mainMenuScene");
    }
    public void noCompleted()
    {
        Soundmanager.specialSoundSource.Play();
        SceneManager.LoadScene("ludo");
    }
    public void DiceRoll()
    {
        
        Soundmanager.dicerollSoundSource.Play();
        diceRollButton.interactable = false;
        redplayer1Button.enabled = true; redplayer2Button.enabled = true; redplayer3Button.enabled = true; redplayer4Button.enabled = true;
        yellowplayer1Button.enabled =true; yellowplayer2Button.enabled = true; yellowplayer3Button.enabled = true; yellowplayer4Button.enabled = true;
        blueplayer1Button.enabled = true; blueplayer2Button.enabled = true; blueplayer3Button.enabled = true; blueplayer4Button.enabled = true;
        greenplayer1Button.enabled = true; greenplayer2Button.enabled = true; greenplayer3Button.enabled = true; greenplayer4Button.enabled = true;

        redplayer1Button.interactable = true; redplayer2Button.interactable = true; redplayer3Button.interactable = true; redplayer4Button.interactable = true;
        yellowplayer1Button.interactable = true; yellowplayer2Button.interactable = true; yellowplayer3Button.interactable = true; yellowplayer4Button.interactable = true;
        blueplayer1Button.interactable = true; blueplayer2Button.interactable = true; blueplayer3Button.interactable = true; blueplayer4Button.interactable = true;
        greenplayer1Button.interactable = true; greenplayer2Button.interactable = true; greenplayer3Button.interactable = true; greenplayer4Button.interactable = true;
        
        if (playerTurn == "BLUE")
        {
            
        
        

            greenplayer1Button.enabled = false;
            greenplayer2Button.enabled = false;
            greenplayer3Button.enabled = false;
            greenplayer4Button.enabled = false;


            redplayer1Button.enabled = false;
            redplayer2Button.enabled = false;
            redplayer3Button.enabled = false;
            redplayer4Button.enabled = false;

            yellowplayer1Button.enabled = false;
            yellowplayer2Button.enabled = false;
            yellowplayer3Button.enabled = false;
            yellowplayer4Button.enabled = false;
        }
        if (playerTurn == "GREEN")
        {

            blueplayer1Button.enabled = false;
            blueplayer2Button.enabled = false;
            blueplayer3Button.enabled = false;
            blueplayer4Button.enabled = false;


            redplayer1Button.enabled = false;
            redplayer2Button.enabled = false;
            redplayer3Button.enabled = false;
            redplayer4Button.enabled = false;

            yellowplayer1Button.enabled = false;
            yellowplayer2Button.enabled = false;
            yellowplayer3Button.enabled = false;
            yellowplayer4Button.enabled = false;
        }
        if (playerTurn == "RED")
        {

            greenplayer1Button.enabled = false;
            greenplayer2Button.enabled = false;
            greenplayer3Button.enabled = false;
            greenplayer4Button.enabled = false;



            blueplayer1Button.enabled = false;
            blueplayer2Button.enabled = false;
            blueplayer3Button.enabled = false;
            blueplayer4Button.enabled = false;

            yellowplayer1Button.enabled = false;
            yellowplayer2Button.enabled = false;
            yellowplayer3Button.enabled = false;
            yellowplayer4Button.enabled = false;
        }
        if (playerTurn == "YELLOW")
        {

            greenplayer1Button.enabled = false;
            greenplayer2Button.enabled = false;
            greenplayer3Button.enabled = false;
            greenplayer4Button.enabled = false;


            blueplayer1Button.enabled = false;
            blueplayer2Button.enabled = false;
            blueplayer3Button.enabled = false;
            blueplayer4Button.enabled = false;

            redplayer1Button.enabled = false;
            redplayer2Button.enabled = false;
            redplayer3Button.enabled = false;
            redplayer4Button.enabled = false;
        }
        selectDiceNumAnimation = Random.Range(1, 7);

        switch (selectDiceNumAnimation)
        {
            case 1:
                dice1RollAnimation.SetActive(true);
                dice2RollAnimation.SetActive(false);
                dice3RollAnimation.SetActive(false);
                dice4RollAnimation.SetActive(false);
                dice5RollAnimation.SetActive(false);
                dice6RollAnimation.SetActive(false);
                break;
            case 2:
                dice1RollAnimation.SetActive(false);
                dice2RollAnimation.SetActive(true);
                dice3RollAnimation.SetActive(false);
                dice4RollAnimation.SetActive(false);
                dice5RollAnimation.SetActive(false);
                dice6RollAnimation.SetActive(false);
                break;
            case 3:
                dice1RollAnimation.SetActive(false);
                dice2RollAnimation.SetActive(false);
                dice3RollAnimation.SetActive(true);
                dice4RollAnimation.SetActive(false);
                dice5RollAnimation.SetActive(false);
                dice6RollAnimation.SetActive(false);
                break;
            case 4:
                dice1RollAnimation.SetActive(false);
                dice2RollAnimation.SetActive(false);
                dice3RollAnimation.SetActive(false);
                dice4RollAnimation.SetActive(true);
                dice5RollAnimation.SetActive(false);
                dice6RollAnimation.SetActive(false);
                break;
            case 5:
                dice1RollAnimation.SetActive(false);
                dice2RollAnimation.SetActive(false);
                dice3RollAnimation.SetActive(false);
                dice4RollAnimation.SetActive(false);
                dice5RollAnimation.SetActive(true);
                dice6RollAnimation.SetActive(false);
                break;
            case 6:
                dice1RollAnimation.SetActive(false);
                dice2RollAnimation.SetActive(false);
                dice3RollAnimation.SetActive(false);
                dice4RollAnimation.SetActive(false);
                dice5RollAnimation.SetActive(false);
                dice6RollAnimation.SetActive(true);
                break;

        }
        if((57-redplayer1Steps)<selectDiceNumAnimation)
        {
            redplayer1Button.interactable = false;
        }
        if ((57 - redplayer2Steps) < selectDiceNumAnimation)
        {
            redplayer2Button.interactable = false;
        }
        if ((57 - redplayer3Steps) < selectDiceNumAnimation)
        {
            redplayer3Button.interactable = false;
        }
        if ((57 - redplayer4Steps) < selectDiceNumAnimation)
        {
            redplayer4Button.interactable = false;
        }

        if ((57 - greenplayer1Steps) < selectDiceNumAnimation)
        {
            greenplayer1Button.interactable = false;
        }
        if ((57 - greenplayer2Steps) < selectDiceNumAnimation)
        {
            greenplayer2Button.interactable = false;
        }
        if ((57 - greenplayer3Steps) < selectDiceNumAnimation)
        {
            greenplayer3Button.interactable = false;
        }
        if ((57 - greenplayer4Steps) < selectDiceNumAnimation)
        {
            greenplayer4Button.interactable = false;
        }

        if ((57 - yellowplayer1Steps) < selectDiceNumAnimation)
        {
            yellowplayer1Button.interactable = false;
        }
        if ((57 - yellowplayer2Steps) < selectDiceNumAnimation)
        {
            yellowplayer2Button.interactable = false;
        }
        if ((57 - yellowplayer3Steps) < selectDiceNumAnimation)
        {
            yellowplayer3Button.interactable = false;
        }
        if ((57 - yellowplayer4Steps) < selectDiceNumAnimation)
        {
            yellowplayer4Button.interactable = false;
        }

        if ((57 - blueplayer1Steps) < selectDiceNumAnimation)
        {
            blueplayer1Button.interactable = false;
        }
        if ((57 - blueplayer2Steps) < selectDiceNumAnimation)
        {
            blueplayer2Button.interactable = false;
        }
        if ((57 - blueplayer3Steps) < selectDiceNumAnimation)
        {
            blueplayer3Button.interactable = false;
        }
        if ((57 - blueplayer4Steps) < selectDiceNumAnimation)
        {
            blueplayer4Button.interactable = false;
        }
        StartCoroutine("Intialize");
    }
    public void IntializePlayerTurn()
    {

        diceRollButton.interactable = true;

        dice1RollAnimation.SetActive(false);
        dice2RollAnimation.SetActive(false);
        dice3RollAnimation.SetActive(false);
        dice4RollAnimation.SetActive(false);
        dice5RollAnimation.SetActive(false);
        dice6RollAnimation.SetActive(false);

        switch (mainmenumanager.number_players)
        {
            case 2:
                if (playerTurn == "RED")
                {
                    redFrame.SetActive(true);
                    greenFrame.SetActive(false);


                    if (greenplayer1Steps == 0)
                    {
                        greenplayer1Caze.SetActive(true);
                        greenplayer1Button.interactable = false;
                    }
                    if (greenplayer2Steps == 0)
                    {
                        greenplayer2Caze.SetActive(true);
                        greenplayer2Button.interactable = false;
                    }
                    if (greenplayer3Steps == 0)
                    {
                        greenplayer3Caze.SetActive(true);
                        greenplayer3Button.interactable = false;
                    }
                    if (greenplayer4Steps == 0)
                    {
                        greenplayer4Caze.SetActive(true);
                        greenplayer4Button.interactable = false;
                    }
                }
                if (playerTurn == "GREEN")
                {
                    redFrame.SetActive(false);
                    greenFrame.SetActive(true);

                    if (redplayer1Steps == 0)
                    {
                        redplayer1Caze.SetActive(true);
                        redplayer1Button.interactable = false;
                    }
                    if (redplayer2Steps == 0)
                    {
                        redplayer2Caze.SetActive(true);
                        redplayer2Button.interactable = false;
                    }
                    if (redplayer3Steps == 0)
                    {
                        redplayer3Caze.SetActive(true);
                        redplayer3Button.interactable = false;
                    }
                    if (redplayer4Steps == 0)
                    {
                        redplayer4Caze.SetActive(true);
                        redplayer4Button.interactable = false;
                    }

                }
                break;
            case 3:
                if (playerTurn == "BLUE")
                {
                    redFrame.SetActive(false);
                    yellowFrame.SetActive(false);
                    blueFrame.SetActive(true);

                    

                    if (redplayer1Steps == 0)
                    {
                        redplayer1Caze.SetActive(true);
                        redplayer1Button.interactable = false;
                    }
                    if (redplayer2Steps == 0)
                    {
                        redplayer2Caze.SetActive(true);
                        redplayer2Button.interactable = false;
                    }
                    if (redplayer3Steps == 0)
                    {
                        redplayer3Caze.SetActive(true);
                        redplayer3Button.interactable = false;
                    }
                    if (redplayer4Steps == 0)
                    {
                        redplayer4Caze.SetActive(true);
                        redplayer4Button.interactable = false;
                    }

                    if (yellowplayer1Steps == 0)
                    {
                        yellowplayer1Caze.SetActive(true);
                        yellowplayer1Button.interactable = false;
                    }
                    if (yellowplayer2Steps == 0)
                    {
                        yellowplayer2Caze.SetActive(true);
                        yellowplayer2Button.interactable = false;
                    }
                    if (yellowplayer3Steps == 0)
                    {
                        yellowplayer3Caze.SetActive(true);
                        yellowplayer3Button.interactable = false;
                    }
                    if (yellowplayer4Steps == 0)
                    {
                        yellowplayer4Caze.SetActive(true);
                        yellowplayer4Button.interactable = false;
                    }
                }
                if (playerTurn == "RED")
                {
                    redFrame.SetActive(true);
                    yellowFrame.SetActive(false);
                    blueFrame.SetActive(false);


                   

                    if (yellowplayer1Steps == 0)
                    {
                        yellowplayer1Caze.SetActive(true);
                        yellowplayer1Button.interactable = false;
                    }
                    if (yellowplayer2Steps == 0)
                    {
                        yellowplayer2Caze.SetActive(true);
                        yellowplayer2Button.interactable = false;
                    }
                    if (yellowplayer3Steps == 0)
                    {
                        yellowplayer3Caze.SetActive(true);
                        yellowplayer3Button.interactable = false;
                    }
                    if (yellowplayer4Steps == 0)
                    {
                        yellowplayer4Caze.SetActive(true);
                        yellowplayer4Button.interactable = false;
                    }

                    if (blueplayer1Steps == 0)
                    {
                        blueplayer1Caze.SetActive(true);
                        blueplayer1Button.interactable = false;
                    }
                    if (blueplayer2Steps == 0)
                    {
                        blueplayer2Caze.SetActive(true);
                        blueplayer2Button.interactable = false;
                    }
                    if (blueplayer3Steps == 0)
                    {
                        blueplayer3Caze.SetActive(true);
                        blueplayer3Button.interactable = false;
                    }
                    if (blueplayer4Steps == 0)
                    {
                        blueplayer4Caze.SetActive(true);
                        blueplayer4Button.interactable = false;
                    }
                }
                if (playerTurn == "YELLOW")
                {
                   
                        redFrame.SetActive(false);
                        yellowFrame.SetActive(true);
                        blueFrame.SetActive(false);
                    redplayer1Button.enabled = false;
                    redplayer2Button.enabled = false;
                    redplayer3Button.enabled = false;
                    redplayer4Button.enabled = false;

                    blueplayer1Button.enabled = false;
                    blueplayer2Button.enabled = false;
                    blueplayer3Button.enabled = false;
                    blueplayer4Button.enabled = false;

                    if (blueplayer1Steps == 0)
                    {
                        blueplayer1Caze.SetActive(true);
                        blueplayer1Button.interactable = false;
                    }
                    if (blueplayer2Steps == 0)
                    {
                        blueplayer2Caze.SetActive(true);
                        blueplayer2Button.interactable = false;
                    }
                    if (blueplayer3Steps == 0)
                    {
                        blueplayer3Caze.SetActive(true);
                        blueplayer3Button.interactable = false;
                    }
                    if (blueplayer4Steps == 0)
                    {
                        blueplayer4Caze.SetActive(true);
                        blueplayer4Button.interactable = false;
                    }
                    if (redplayer1Steps == 0)
                    {
                        redplayer1Caze.SetActive(true);
                        redplayer1Button.interactable = false;
                    }
                    if (redplayer2Steps == 0)
                    {
                        redplayer2Caze.SetActive(true);
                        redplayer2Button.interactable = false;
                    }
                    if (redplayer3Steps == 0)
                    {
                        redplayer3Caze.SetActive(true);
                        redplayer3Button.interactable = false;
                    }
                    if (redplayer4Steps == 0)
                    {
                        redplayer4Caze.SetActive(true);
                        redplayer4Button.interactable = false;
                    }
                }

                break;
            case 4:

                if (playerTurn == "BLUE")
                {
                    redFrame.SetActive(false);
                    yellowFrame.SetActive(false);
                    blueFrame.SetActive(true);
                    greenFrame.SetActive(false);

                    

                    if (redplayer1Steps == 0)
                    {
                        redplayer1Caze.SetActive(true);
                        redplayer1Button.interactable = false;
                    }
                    if (redplayer2Steps == 0)
                    {
                        redplayer2Caze.SetActive(true);
                        redplayer2Button.interactable = false;
                    }
                    if (redplayer3Steps == 0)
                    {
                        redplayer3Caze.SetActive(true);
                        redplayer3Button.interactable = false;
                    }
                    if (redplayer4Steps == 0)
                    {
                        redplayer4Caze.SetActive(true);
                        redplayer4Button.interactable = false;
                    }

                    if (yellowplayer1Steps == 0)
                    {
                        yellowplayer1Caze.SetActive(true);
                        yellowplayer1Button.interactable = false;
                    }
                    if (yellowplayer2Steps == 0)
                    {
                        yellowplayer2Caze.SetActive(true);
                        yellowplayer2Button.interactable = false;
                    }
                    if (yellowplayer3Steps == 0)
                    {
                        yellowplayer3Caze.SetActive(true);
                        yellowplayer3Button.interactable = false;
                    }
                    if (yellowplayer4Steps == 0)
                    {
                        yellowplayer4Caze.SetActive(true);
                        yellowplayer4Button.interactable = false;
                    }
                    if (greenplayer1Steps == 0)
                    {
                        greenplayer1Caze.SetActive(true);
                        greenplayer1Button.interactable = false;
                    }
                    if (greenplayer2Steps == 0)
                    {
                        greenplayer2Caze.SetActive(true);
                        greenplayer2Button.interactable = false;
                    }
                    if (greenplayer3Steps == 0)
                    {
                        greenplayer3Caze.SetActive(true);
                        greenplayer3Button.interactable = false;
                    }
                    if (greenplayer4Steps == 0)
                    {
                        greenplayer4Caze.SetActive(true);
                        greenplayer4Button.interactable = false;
                    }
                }

                    if (playerTurn == "RED")
                {
                    redFrame.SetActive(true);
                    yellowFrame.SetActive(false);
                    blueFrame.SetActive(false);
                    greenFrame.SetActive(false);

                        redplayer1Button.enabled = true;
                        redplayer2Button.enabled = true;
                        redplayer3Button.enabled = true;
                        redplayer4Button.enabled = true;

                        blueplayer1Button.enabled = false;
                        blueplayer2Button.enabled = false;
                        blueplayer3Button.enabled = false;
                        blueplayer4Button.enabled = false;


                        greenplayer1Button.enabled = false;
                        greenplayer2Button.enabled = false;
                        greenplayer3Button.enabled = false;
                        greenplayer4Button.enabled = false;


                        yellowplayer1Button.enabled = false;
                        yellowplayer2Button.enabled = false;
                        yellowplayer3Button.enabled = false;
                        yellowplayer4Button.enabled = false;

                    if (yellowplayer1Steps == 0)
                    {
                        yellowplayer1Caze.SetActive(true);
                        yellowplayer1Button.interactable = false;
                    }
                    if (yellowplayer2Steps == 0)
                    {
                        yellowplayer2Caze.SetActive(true);
                        yellowplayer2Button.interactable = false;
                    }
                    if (yellowplayer3Steps == 0)
                    {
                        yellowplayer3Caze.SetActive(true);
                        yellowplayer3Button.interactable = false;
                    }
                    if (yellowplayer4Steps == 0)
                    {
                        yellowplayer4Caze.SetActive(true);
                        yellowplayer4Button.interactable = false;
                    }

                    if (blueplayer1Steps == 0)
                    {
                        blueplayer1Caze.SetActive(true);
                        blueplayer1Button.interactable = false;
                    }
                    if (blueplayer2Steps == 0)
                    {
                        blueplayer2Caze.SetActive(true);
                        blueplayer2Button.interactable = false;
                    }
                    if (blueplayer3Steps == 0)
                    {
                        blueplayer3Caze.SetActive(true);
                        blueplayer3Button.interactable = false;
                    }
                    if (blueplayer4Steps == 0)
                    {
                        blueplayer4Caze.SetActive(true);
                        blueplayer4Button.interactable = false;
                    }
                    if (greenplayer1Steps == 0)
                    {
                        greenplayer1Caze.SetActive(true);
                        greenplayer1Button.interactable = false;
                    }
                    if (greenplayer2Steps == 0)
                    {
                        greenplayer2Caze.SetActive(true);
                        greenplayer2Button.interactable = false;
                    }
                    if (greenplayer3Steps == 0)
                    {
                        greenplayer3Caze.SetActive(true);
                        greenplayer3Button.interactable = false;
                    }
                    if (greenplayer4Steps == 0)
                    {
                        greenplayer4Caze.SetActive(true);
                        greenplayer4Button.interactable = false;
                    }

                }


                    if (playerTurn == "YELLOW")
                {
                    redFrame.SetActive(false);
                    yellowFrame.SetActive(true);
                    blueFrame.SetActive(false);
                    greenFrame.SetActive(false);

                       

                    if (blueplayer1Steps == 0)
                    {
                        blueplayer1Caze.SetActive(true);
                        blueplayer1Button.interactable = false;
                    }
                    if (blueplayer2Steps == 0)
                    {
                        blueplayer2Caze.SetActive(true);
                        blueplayer2Button.interactable = false;
                    }
                    if (blueplayer3Steps == 0)
                    {
                        blueplayer3Caze.SetActive(true);
                        blueplayer3Button.interactable = false;
                    }
                    if (blueplayer4Steps == 0)
                    {
                        blueplayer4Caze.SetActive(true);
                        blueplayer4Button.interactable = false;
                    }
                    if (redplayer1Steps == 0)
                    {
                        redplayer1Caze.SetActive(true);
                        redplayer1Button.interactable = false;
                    }
                    if (redplayer2Steps == 0)
                    {
                        redplayer2Caze.SetActive(true);
                        redplayer2Button.interactable = false;
                    }
                    if (redplayer3Steps == 0)
                    {
                        redplayer3Caze.SetActive(true);
                        redplayer3Button.interactable = false;
                    }
                    if (redplayer4Steps == 0)
                    {
                        redplayer4Caze.SetActive(true);
                        redplayer4Button.interactable = false;
                    }
                    if (greenplayer1Steps == 0)
                    {
                        greenplayer1Caze.SetActive(true);
                        greenplayer1Button.interactable = false;
                    }
                    if (greenplayer2Steps == 0)
                    {
                        greenplayer2Caze.SetActive(true);
                        greenplayer2Button.interactable = false;
                    }
                    if (greenplayer3Steps == 0)
                    {
                        greenplayer3Caze.SetActive(true);
                        greenplayer3Button.interactable = false;
                    }
                    if (greenplayer4Steps == 0)
                    {
                        greenplayer4Caze.SetActive(true);
                        greenplayer4Button.interactable = false;
                    }

                }
                if (playerTurn == "GREEN")
                {
                    redFrame.SetActive(false);
                    yellowFrame.SetActive(false);
                    blueFrame.SetActive(false);
                    greenFrame.SetActive(true);

                       
                    if (redplayer1Steps == 0)
                    {
                        redplayer1Caze.SetActive(true);
                        redplayer1Button.interactable = false;
                    }
                    if (redplayer2Steps == 0)
                    {
                        redplayer2Caze.SetActive(true);
                        redplayer2Button.interactable = false;
                    }
                    if (redplayer3Steps == 0)
                    {
                        redplayer3Caze.SetActive(true);
                        redplayer3Button.interactable = false;
                    }
                    if (redplayer4Steps == 0)
                    {
                        redplayer4Caze.SetActive(true);
                        redplayer4Button.interactable = false;
                    }

                    if (yellowplayer1Steps == 0)
                    {
                        yellowplayer1Caze.SetActive(true);
                        yellowplayer1Button.interactable = false;
                    }
                    if (yellowplayer2Steps == 0)
                    {
                        yellowplayer2Caze.SetActive(true);
                        yellowplayer2Button.interactable = false;
                    }
                    if (yellowplayer3Steps == 0)
                    {
                        yellowplayer3Caze.SetActive(true);
                        yellowplayer3Button.interactable = false;
                    }
                    if (yellowplayer4Steps == 0)
                    {
                        yellowplayer4Caze.SetActive(true);
                        yellowplayer4Button.interactable = false;
                    }
                    if (blueplayer1Steps == 0)
                    {
                        blueplayer1Caze.SetActive(true);
                        blueplayer1Button.interactable = false;
                    }
                    if (blueplayer2Steps == 0)
                    {
                        blueplayer2Caze.SetActive(true);
                        blueplayer2Button.interactable = false;
                    }
                    if (blueplayer3Steps == 0)
                    {
                        blueplayer3Caze.SetActive(true);
                        blueplayer3Button.interactable = false;
                    }
                    if (blueplayer4Steps == 0)
                    {
                        blueplayer4Caze.SetActive(true);
                        blueplayer4Button.interactable = false;
                    }

                }
                    break;




    }


    }
    IEnumerator Intialize()
    {
        yield return new WaitForSeconds(1f);
        switch (playerTurn)
        {
            case "RED":

                if (selectDiceNumAnimation == 6 && redplayer1Steps == 0)
                {
                    //blink(redplayer1, 0.1f, 1f);
                    redplayer1Caze.SetActive(false);
                    redplayer1Button.interactable = true;
                }
                if (selectDiceNumAnimation == 6 && redplayer2Steps == 0)
                {
                    redplayer2Caze.SetActive(false);
                    redplayer2Button.interactable = true;
                }
                if (selectDiceNumAnimation == 6 && redplayer3Steps == 0)
                {
                    redplayer3Caze.SetActive(false);
                    redplayer3Button.interactable = true;
                }
                if (selectDiceNumAnimation == 6 && redplayer4Steps == 0)
                {
                    redplayer4Caze.SetActive(false);
                    redplayer4Button.interactable = true;
                }
                if(redplayer1Caze.activeInHierarchy)
                {
                    redplayer1Button.interactable = false;
                }
                if (redplayer2Caze.activeInHierarchy)
                {
                    redplayer2Button.interactable = false;
                }
                if (redplayer3Caze.activeInHierarchy)
                {
                    redplayer3Button.interactable = false;
                }
                if (redplayer4Caze.activeInHierarchy)
                {
                    redplayer4Button.interactable = false;
                }
                if (!redplayer1Button.interactable&&!redplayer2Button.interactable
                      &&! redplayer3Button.interactable && !redplayer4Button.interactable
                      )
                { 
                    redplayer1Button.interactable = false;
                     redplayer2Button.interactable = false;
                    redplayer3Button.interactable = false;
                    redplayer4Button.interactable = false;

                    switch (mainmenumanager.number_players)
                    {
                        case 2:
                            playerTurn = "GREEN";
                            IntializePlayerTurn();
                            break;
                        case 3:
                            playerTurn = "BLUE";
                            IntializePlayerTurn();
                            break;
                        case 4:
                            playerTurn = "BLUE";
                            IntializePlayerTurn();
                            break;
                    }

                }

                break;
            case "GREEN":
                if (selectDiceNumAnimation == 6 && greenplayer1Steps == 0)
                {
                    greenplayer1Button.interactable = true;
                    greenplayer1Caze.SetActive(false);
                }
                if (selectDiceNumAnimation == 6 && greenplayer2Steps == 0)
                {
                    greenplayer2Button.interactable = true;
                    greenplayer2Caze.SetActive(false);
                }
                if (selectDiceNumAnimation == 6 && greenplayer3Steps == 0)
                {
                    greenplayer3Button.interactable = true;
                    greenplayer3Caze.SetActive(false);
                }
                if (selectDiceNumAnimation == 6 && greenplayer4Steps == 0)
                {
                    greenplayer4Button.interactable = true;
                    greenplayer4Caze.SetActive(false);
                }
                if (greenplayer1Caze.activeInHierarchy)
                {
                    greenplayer1Button.interactable = false;
                }
                if (greenplayer2Caze.activeInHierarchy)
                {
                    greenplayer2Button.interactable = false;
                }
                if (greenplayer2Caze.activeInHierarchy)
                {
                    greenplayer3Button.interactable = false;
                }
                if (greenplayer4Caze.activeInHierarchy)
                {
                    greenplayer4Button.interactable = false;
                }

                if (!greenplayer1Button.interactable && !greenplayer2Button.interactable
                      && !greenplayer3Button.interactable && !greenplayer4Button.interactable
                      )
                {
                    greenplayer1Button.interactable = false;
                    greenplayer2Button.interactable = false;
                    greenplayer3Button.interactable = false;
                    greenplayer4Button.interactable = false;
                    switch (mainmenumanager.number_players)
                    {
                        case 2:
                            playerTurn = "RED";
                            IntializePlayerTurn();
                            break;
                        case 4:
                            playerTurn = "YELLOW";
                            IntializePlayerTurn();
                            break;

                    }

                }
                break;
            case "BLUE":

                if (selectDiceNumAnimation == 6 && blueplayer1Steps == 0)
                {
                    //blink(blueplayer1, 0.1f, 1f);
                    blueplayer1Caze.SetActive(false);
                    blueplayer1Button.interactable = true;
                }
                if (selectDiceNumAnimation == 6 && blueplayer2Steps == 0)
                {
                    blueplayer2Caze.SetActive(false);
                    blueplayer2Button.interactable = true;
                }
                if (selectDiceNumAnimation == 6 && blueplayer3Steps == 0)
                {
                    blueplayer3Caze.SetActive(false);
                    blueplayer3Button.interactable = true;
                }
                if (selectDiceNumAnimation == 6 && blueplayer4Steps == 0)
                {
                    blueplayer4Caze.SetActive(false);
                    blueplayer4Button.interactable = true;
                }
                if (blueplayer1Caze.activeInHierarchy)
                {
                    blueplayer1Button.interactable = false;
                }
                if (blueplayer2Caze.activeInHierarchy)
                {
                    blueplayer2Button.interactable = false;
                }
                if (blueplayer3Caze.activeInHierarchy)
                {
                    blueplayer3Button.interactable = false;
                }
                if (blueplayer4Caze.activeInHierarchy)
                {
                    blueplayer4Button.interactable = false;
                }
                if (!blueplayer1Button.interactable && !blueplayer2Button.interactable
                      && !blueplayer3Button.interactable &&! blueplayer4Button.interactable
                      )
                {
                    blueplayer1Button.interactable = false;
                    blueplayer2Button.interactable = false;
                    blueplayer3Button.interactable = false;
                    blueplayer4Button.interactable = false;

                    switch (mainmenumanager.number_players)
                    {
                        case 3:
                            playerTurn = "YELLOW";
                            IntializePlayerTurn();
                            break;
                        case 4:
                            playerTurn = "GREEN";
                            IntializePlayerTurn();
                            break;
                    }
                }
                break;
            case "YELLOW":
                if (selectDiceNumAnimation == 6 && yellowplayer1Steps == 0)
                {
                    //blink(yellowplayer1, 0.1f, 1f);
                    yellowplayer1Caze.SetActive(false);
                    yellowplayer1Button.interactable = true;
                }
                if (selectDiceNumAnimation == 6 && yellowplayer2Steps == 0)
                {
                    yellowplayer2Caze.SetActive(false);
                    yellowplayer2Button.interactable = true;
                }
                if (selectDiceNumAnimation == 6 && yellowplayer3Steps == 0)
                {
                    yellowplayer3Caze.SetActive(false);
                    yellowplayer3Button.interactable = true;
                }
                if (selectDiceNumAnimation == 6 && yellowplayer4Steps == 0)
                {
                    yellowplayer4Caze.SetActive(false);
                    yellowplayer4Button.interactable = true;
                }
                if (yellowplayer1Caze.activeInHierarchy)
                {
                    yellowplayer1Button.interactable = false;
                }
                if (yellowplayer2Caze.activeInHierarchy)
                {
                    yellowplayer2Button.interactable = false;
                }
                if (yellowplayer3Caze.activeInHierarchy)
                {
                    yellowplayer3Button.interactable = false;
                }
                if (yellowplayer4Caze.activeInHierarchy)
                {
                    yellowplayer4Button.interactable = false;
                }

                if (!yellowplayer1Button.interactable && !yellowplayer2Button.interactable
                      && !yellowplayer3Button.interactable && !yellowplayer4Button.interactable
                      )
                {
                    yellowplayer1Button.interactable = false;
                    yellowplayer2Button.interactable = false;
                    yellowplayer3Button.interactable = false;
                    yellowplayer4Button.interactable = false;

                    switch (mainmenumanager.number_players)
                    {
                        case 3:
                            playerTurn = "RED";
                            IntializePlayerTurn();
                            break;
                        case 4:
                            playerTurn = "RED";
                            IntializePlayerTurn();
                            break;
                    }
                }
                break;

        }
    }
    public void Delay(float time)
    {
        StartCoroutine(DelayAction(time));
    }
    IEnumerator DelayAction(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
    }

    public int redPlayermovement(string tag, int Steps, GameObject playerCaze, Button playerButton)
    {
        
        Soundmanager.playermoveSoundSource.Play();
        redplayer1Button.enabled = false; redplayer2Button.enabled = false; redplayer3Button.enabled = false; redplayer4Button.enabled=false;
        yellowplayer1Button.enabled = false; yellowplayer2Button.enabled = false; yellowplayer3Button.enabled = false; yellowplayer4Button.enabled=false;
        blueplayer1Button.enabled = false; blueplayer2Button.enabled = false; blueplayer3Button.enabled = false; blueplayer4Button.enabled=false;
        greenplayer1Button.enabled = false; greenplayer2Button.enabled = false; greenplayer3Button.enabled = false; greenplayer4Button.enabled = false;
        
            if (playerTurn == "RED")
            {

                if (selectDiceNumAnimation == 6)
                {
                    if (Steps == 0)
                    {
                        // playerCaze.SetActive(true);

                        //playerButton.interactable = false;

                        GameObject.FindGameObjectWithTag(tag).transform.position = redMovementBlock[Steps].transform.position;
                        Steps += 1;
                        playerTurn = "RED";

                    }
                    else
                    {
                        for (int i = Steps; i < Steps + 6; i++)
                        {
                            GameObject.FindGameObjectWithTag(tag).transform.position = redMovementBlock[i].transform.position;
                            Delay(0.25f);
                            // Invoke("Delay(steps)", 1f);
                        }
                        Steps += 6;
                        playerTurn = "RED";

                    }
                }
                if (selectDiceNumAnimation == 1 && Steps != 0)
                {

                    GameObject.FindGameObjectWithTag(tag).transform.position = redMovementBlock[Steps].transform.position;
                    Steps += 1;

                    switch (mainmenumanager.number_players)
                    {
                        case 2:
                            playerTurn = "GREEN";
                            break;
                        case 3:
                            playerTurn = "BLUE";
                            break;
                        case 4:
                            playerTurn = "BLUE";
                            break;
                    }

                }
                if (selectDiceNumAnimation == 2 && Steps != 0)
                {
                    for (int i = Steps; i < Steps + 2; i++)
                    {
                        GameObject.FindGameObjectWithTag(tag).transform.position = redMovementBlock[i].transform.position;
                        //StartCoroutine("Delay");
                        // Delay(0.25f);
                    }
                    Steps += 2;

                    switch (mainmenumanager.number_players)
                    {
                        case 2:
                            playerTurn = "GREEN";
                            break;
                        case 3:
                            playerTurn = "BLUE";
                            break;
                        case 4:
                            playerTurn = "BLUE";
                            break;
                    }

                }
                if (selectDiceNumAnimation == 3 && Steps != 0)
                {
                    for (int i = Steps; i < Steps + 3; i++)
                    {
                        GameObject.FindGameObjectWithTag(tag).transform.position = redMovementBlock[i].transform.position;
                        //StartCoroutine("Delay");
                        //Delay(0.25f);
                    }
                    Steps += 3;
                    switch (mainmenumanager.number_players)
                    {
                        case 2:
                            playerTurn = "GREEN";
                            break;
                        case 3:
                            playerTurn = "BLUE";
                            break;
                        case 4:
                            playerTurn = "BLUE";
                            break;
                    }

                }
                if (selectDiceNumAnimation == 4 && Steps != 0)
                {
                    for (int i = Steps; i < Steps + 4; i++)
                    {
                        GameObject.FindGameObjectWithTag(tag).transform.position = redMovementBlock[i].transform.position;
                        //StartCoroutine("Delay"); 
                        //Delay(0.25f);
                    }

                    Steps += 4;

                    switch (mainmenumanager.number_players)
                    {
                        case 2:
                            playerTurn = "GREEN";
                            break;
                        case 3:
                            playerTurn = "BLUE";
                            break;
                        case 4:
                            playerTurn = "BLUE";
                            break;
                    }

                }
                if (selectDiceNumAnimation == 5 && Steps != 0)
                {
                    for (int i = Steps; i < Steps + 5; i++)
                    {
                        GameObject.FindGameObjectWithTag(tag).transform.position = redMovementBlock[i].transform.position;
                        // yield return new WaitForSeconds(0.25f);
                        // Delay(0.25f);
                    }
                    Steps += 5;

                    switch (mainmenumanager.number_players)
                    {
                        case 2:
                            playerTurn = "GREEN";
                            break;
                        case 3:
                            playerTurn = "BLUE";
                            break;
                        case 4:
                            playerTurn = "BLUE";
                            break;
                    }

                }
            }


            if (Steps == 57)
            {
            Soundmanager.safeHouseSoundSource.Play();
            GameObject.FindGameObjectWithTag(tag).GetComponent<Button>().interactable = false;
                toatalredhiuse += 1;
            playerTurn = "RED";
           
            }
            if (toatalredhiuse == 4)
            {
                Debug.Log("RedWin");
                if (!first_position.enabled)
                {
                    first_position.enabled = true;
                    first_position.text = "1)Red Player";
                }
               else if (!second_position.enabled)
                {
                    second_position.enabled = true;
                    second_position.text = "2)Red Player";
                }
                else if (!third_position.enabled)
                {
                    third_position.enabled = true;
                    third_position.text = "3)Red Player";
                }
                else if (!fourth_position.enabled)
                {
                    fourth_position.enabled = true;
                    fourth_position.text = "4)Red Player";
                }
                switch (mainmenumanager.number_players)
                {
                    case 2:
                        if (first_position.enabled)
                        {
                        second_position.text="2)Green Player";
                        GameCompeleted();
                        }
                        break;
                    case 3:
                        if (first_position.enabled && second_position.enabled)
                        {
                        GameCompeleted();
                        GameCompeleted();
                    }
                        break;
                    case 4:
                        if (first_position.enabled && second_position.enabled && third_position.enabled)
                        {
                        GameCompeleted();
                    }
                        break;
                }
            }

        
        return Steps;
    }

    public int bluePlayermovement(string tag, int Steps)
    {
        Soundmanager.playermoveSoundSource.Play();
        redplayer1Button.enabled = false; redplayer2Button.enabled = false; redplayer3Button.enabled = false; redplayer4Button.enabled = false;
        yellowplayer1Button.enabled = false; yellowplayer2Button.enabled = false; yellowplayer3Button.enabled = false; yellowplayer4Button.enabled = false;
        blueplayer1Button.enabled = false; blueplayer2Button.enabled = false; blueplayer3Button.enabled = false; blueplayer4Button.enabled = false;
        greenplayer1Button.enabled = false; greenplayer2Button.enabled = false; greenplayer3Button.enabled = false; greenplayer4Button.enabled = false;
       
            if (playerTurn == "BLUE")
            {
               
                    if (selectDiceNumAnimation == 6)
                    {
                        if (Steps == 0)
                        {

                            //green1 = Vector3.Lerp(tran(sform.position, greenMovementBlock[greenplayer1Steps].transform.position, 1f * Time.deltaTime);

                            GameObject.FindGameObjectWithTag(tag).transform.position = blueMovementBlock[Steps].transform.position;
                            Steps += 1;
                            playerTurn = "BLUE";

                        }
                        else
                        {
                            GameObject.FindGameObjectWithTag(tag).transform.position = blueMovementBlock[Steps + 5].transform.position;
                            Steps += 6;
                            playerTurn = "BLUE";
                        }
                    }
                    if (selectDiceNumAnimation == 1 && Steps != 0)
                    {
                        // green1= Vector3.Lerp(transform.position, greenMovementBlock[greenplayer1Steps].transform.position, 1f * Time.deltaTime);
                        GameObject.FindGameObjectWithTag(tag).transform.position = blueMovementBlock[Steps].transform.position;
                        Steps += 1;
                        switch (mainmenumanager.number_players)
                        {
                            case 3:
                                playerTurn = "YELLOW";
                                break;
                            case 4:
                                playerTurn = "GREEN";
                                break;
                        }
                    }
                    if (selectDiceNumAnimation == 2 && Steps != 0)
                    {
                        //green1 = Vector3.Lerp(transform.position, greenMovementBlock[greenplayer1Steps].transform.position, 1f * Time.deltaTime);
                        GameObject.FindGameObjectWithTag(tag).transform.position = blueMovementBlock[Steps + 1].transform.position;
                        Steps += 2;
                        switch (mainmenumanager.number_players)
                        {
                            case 3:
                                playerTurn = "YELLOW";
                                break;
                            case 4:
                                playerTurn = "GREEN";
                                break;
                        }
                    }
                    if (selectDiceNumAnimation == 3 && Steps != 0)
                    {
                        GameObject.FindGameObjectWithTag(tag).transform.position = blueMovementBlock[Steps + 2].transform.position;
                        Steps += 3;
                        switch (mainmenumanager.number_players)
                        {
                            case 3:
                                playerTurn = "YELLOW";
                                break;
                            case 4:
                                playerTurn = "GREEN";
                                break;
                        }
                    }
                    if (selectDiceNumAnimation == 4 && Steps != 0)
                    {
                        GameObject.FindGameObjectWithTag(tag).transform.position = blueMovementBlock[Steps + 3].transform.position;
                        Steps += 4;
                        switch (mainmenumanager.number_players)
                        {
                            case 3:
                                playerTurn = "YELLOW";
                                break;
                            case 4:
                                playerTurn = "GREEN";
                                break;
                        }
                    }
                    if (selectDiceNumAnimation == 5 && Steps != 0)
                    {
                        GameObject.FindGameObjectWithTag(tag).transform.position = blueMovementBlock[Steps + 4].transform.position;
                        Steps += 5;
                        switch (mainmenumanager.number_players)
                        {
                            case 3:
                                playerTurn = "YELLOW";
                                break;
                            case 4:
                                playerTurn = "GREEN";
                                break;
                        }
                    }
                }
                if (Steps == 57)
                {
            Soundmanager.safeHouseSoundSource.Play();
                    GameObject.FindGameObjectWithTag(tag).GetComponent<Button>().interactable = false;
                    totalbluehouse += 1;
            playerTurn = "BLUE";
                }
                if (totalbluehouse == 4)
                {
                    Debug.Log("blue win");
                    if (!first_position.enabled)
                    {
                        first_position.enabled = true;
                        first_position.text = "1)Blue Player";
                    }
                   else  if (!second_position.enabled)
                    {
                        second_position.enabled = true;
                        second_position.text = "2)Blue Player";
                    }
                    else if (!third_position.enabled)
                    {
                        third_position.enabled = true;
                        third_position.text = "3)Blue Player";
                    }
                   else if (!fourth_position.enabled)
                    {
                        fourth_position.enabled = true;
                        fourth_position.text = "4)Blue Player";
                    }
                    switch(mainmenumanager.number_players)
                    {
                        case 2:
                            if (first_position.enabled)
                            {
                        second_position.text = "RED";
                        GameCompeleted();
                    }
                            break;
                        case 3:
                            if (first_position.enabled && second_position.enabled)
                            {
                        if(first_position.text=="1)Red Player")
                        {
                            third_position.text = "3)Yellow Player";
                        }
                        if (first_position.text == "1)Yellow Player")
                        {
                            third_position.text = "3)Red Player";
                        }
                        GameCompeleted();
                    }
                            break;
                        case 4:
                            if (first_position.enabled && second_position.enabled && third_position.enabled)
                            {
                        GameCompeleted();
                    }
                            break;
                    }
                    
                }




            

          
        
        
        return Steps;

    }
    public int greenPlayermovement(string tag,int Steps)
    {
        Soundmanager.playermoveSoundSource.Play();
        redplayer1Button.enabled = false; redplayer2Button.enabled = false; redplayer3Button.enabled = false; redplayer4Button.enabled = false;
        yellowplayer1Button.enabled = false; yellowplayer2Button.enabled = false; yellowplayer3Button.enabled = false; yellowplayer4Button.enabled = false;
        blueplayer1Button.enabled = false; blueplayer2Button.enabled = false; blueplayer3Button.enabled = false; blueplayer4Button.enabled = false;
        greenplayer1Button.enabled = false; greenplayer2Button.enabled = false; greenplayer3Button.enabled = false; greenplayer4Button.enabled = false;
       
            if (playerTurn == "GREEN")
            {

                if (selectDiceNumAnimation == 6)
                {
                    if (Steps == 0)
                    {

                        //green1 = Vector3.Lerp(transform.position, greenMovementBlock[greenplayer1Steps].transform.position, 1f * Time.deltaTime);

                        GameObject.FindGameObjectWithTag(tag).transform.position = greenMovementBlock[Steps].transform.position;
                        Steps += 1;
                        playerTurn = "GREEN";

                    }
                    else
                    {
                        GameObject.FindGameObjectWithTag(tag).transform.position = greenMovementBlock[Steps + 5].transform.position;
                        Steps += 6;
                        playerTurn = "GREEN";
                    }
                }
                if (selectDiceNumAnimation == 1 && Steps != 0)
                {
                    // green1= Vector3.Lerp(transform.position, greenMovementBlock[greenplayer1Steps].transform.position, 1f * Time.deltaTime);
                    GameObject.FindGameObjectWithTag(tag).transform.position = greenMovementBlock[Steps].transform.position;
                    Steps += 1;
                    switch (mainmenumanager.number_players)
                    {
                        case 2:
                            playerTurn = "RED";
                            break;
                        case 4:
                            playerTurn = "YELLOW";
                            break;
                    }
                }
                if (selectDiceNumAnimation == 2 && Steps != 0)
                {
                    //green1 = Vector3.Lerp(transform.position, greenMovementBlock[greenplayer1Steps].transform.position, 1f * Time.deltaTime);
                    GameObject.FindGameObjectWithTag(tag).transform.position = greenMovementBlock[Steps + 1].transform.position;
                    Steps += 2;
                    switch (mainmenumanager.number_players)
                    {
                        case 2:
                            playerTurn = "RED";
                            break;
                        case 4:
                            playerTurn = "YELLOW";
                            break;
                    }
                }
                if (selectDiceNumAnimation == 3 && Steps != 0)
                {
                    GameObject.FindGameObjectWithTag(tag).transform.position = greenMovementBlock[Steps + 2].transform.position;
                    Steps += 3;
                    switch (mainmenumanager.number_players)
                    {
                        case 2:
                            playerTurn = "RED";
                            break;
                        case 4:
                            playerTurn = "YELLOW";
                            break;
                    }
                }
                if (selectDiceNumAnimation == 4 && Steps != 0)
                {
                    GameObject.FindGameObjectWithTag(tag).transform.position = greenMovementBlock[Steps + 3].transform.position;
                    Steps += 4;
                    switch (mainmenumanager.number_players)
                    {
                        case 2:
                            playerTurn = "RED";
                            break;
                        case 4:
                            playerTurn = "YELLOW";
                            break;
                    }
                }
                if (selectDiceNumAnimation == 5 && Steps != 0)
                {
                    GameObject.FindGameObjectWithTag(tag).transform.position = greenMovementBlock[Steps + 4].transform.position;
                    Steps += 5;
                    switch (mainmenumanager.number_players)
                    {
                        case 2:
                            playerTurn = "RED";
                            break;
                        case 4:
                            playerTurn = "YELLOW";
                            break;
                    }
                }
            }
            if (Steps == 57)
            {
            Soundmanager.safeHouseSoundSource.Play();
                GameObject.FindGameObjectWithTag(tag).GetComponent<Button>().interactable = false;
                totalgreenhouse += 1;
            playerTurn = "GREEN";
            }
            if (totalgreenhouse == 4)
            {
                Debug.Log("green win");
                if(!first_position.enabled)
                {
                    first_position.enabled = true;
                    first_position.text = "1)Green Player";
                }
               else if(!second_position.enabled)
                {
                    second_position.enabled = true;
                    second_position.text = "2)Green Player";
                }
               else if (!third_position.enabled)
                {
                    third_position.enabled = true;
                    third_position.text = "3)Green Player";
                }
               else if (!fourth_position.enabled)
                {
                    fourth_position.enabled = true;
                    fourth_position.text = "4)Green Player";
                }
                switch (mainmenumanager.number_players)
                {
                    case 2:
                        if (first_position.enabled)
                        {
                        GameCompeleted();
                    }
                        break;
                    case 3:
                        if (first_position.enabled && second_position.enabled)
                        {
                        GameCompeleted();
                    }
                        break;
                    case 4:
                        if (first_position.enabled && second_position.enabled && third_position.enabled)
                        {
                        GameCompeleted();
                    }
                        break;
                }
            }



        
      
            
        
        return Steps ;

    }
    public int yellowPlayermovement(string tag, int Steps)
    {
        Soundmanager.playermoveSoundSource.Play();
        redplayer1Button.enabled = false; redplayer2Button.enabled = false; redplayer3Button.enabled = false; redplayer4Button.enabled = false;
        yellowplayer1Button.enabled = false; yellowplayer2Button.enabled = false; yellowplayer3Button.enabled = false; yellowplayer4Button.enabled = false;
        blueplayer1Button.enabled = false; blueplayer2Button.enabled = false; blueplayer3Button.enabled = false; blueplayer4Button.enabled = false;
        greenplayer1Button.enabled = false; greenplayer2Button.enabled = false; greenplayer3Button.enabled = false; greenplayer4Button.enabled = false;
       
            if (playerTurn == "YELLOW")
            {
               
                    if (selectDiceNumAnimation == 6)
                    {
                        if (Steps == 0)
                        {

                            //green1 = Vector3.Lerp(transform.position, greenMovementBlock[greenplayer1Steps].transform.position, 1f * Time.deltaTime);

                            GameObject.FindGameObjectWithTag(tag).transform.position = yellowMovementBlock[Steps].transform.position;
                            Steps += 1;
                            playerTurn = "YELLOW";

                        }
                        else
                        {
                            GameObject.FindGameObjectWithTag(tag).transform.position = yellowMovementBlock[Steps + 5].transform.position;
                            Steps += 6;
                            playerTurn = "YELLOW";
                        }
                    }
                    if (selectDiceNumAnimation == 1 && Steps != 0)
                    {

                        GameObject.FindGameObjectWithTag(tag).transform.position = yellowMovementBlock[Steps].transform.position;
                        Steps += 1;
                        switch (mainmenumanager.number_players)
                        {
                            case 3:
                                playerTurn = "RED";
                                break;
                            case 4:
                                playerTurn = "RED";
                                break;
                        }
                    }
                    if (selectDiceNumAnimation == 2 && Steps != 0)
                    {
                        //green1 = Vector3.Lerp(transform.position, greenMovementBlock[greenplayer1Steps].transform.position, 1f * Time.deltaTime);
                        GameObject.FindGameObjectWithTag(tag).transform.position = yellowMovementBlock[Steps + 1].transform.position;
                        Steps += 2;
                        switch (mainmenumanager.number_players)
                        {
                            case 3:
                                playerTurn = "RED";
                                break;
                            case 4:
                                playerTurn = "RED";
                                break;
                        }
                    }
                    if (selectDiceNumAnimation == 3 && Steps != 0)
                    {
                        GameObject.FindGameObjectWithTag(tag).transform.position = yellowMovementBlock[Steps + 2].transform.position;
                        Steps += 3;
                        switch (mainmenumanager.number_players)
                        {
                            case 3:
                                playerTurn = "RED";
                                break;
                            case 4:
                                playerTurn = "RED";
                                break;
                        }
                    }
                    if (selectDiceNumAnimation == 4 && Steps != 0)
                    {
                        GameObject.FindGameObjectWithTag(tag).transform.position = yellowMovementBlock[Steps + 3].transform.position;
                        Steps += 4;
                        switch (mainmenumanager.number_players)
                        {
                            case 3:
                                playerTurn = "RED";
                                break;
                            case 4:
                                playerTurn = "RED";
                                break;
                        }
                    }
                    if (selectDiceNumAnimation == 5 && Steps != 0)
                    {
                        GameObject.FindGameObjectWithTag(tag).transform.position = yellowMovementBlock[Steps + 4].transform.position;
                        Steps += 5;
                        switch (mainmenumanager.number_players)
                        {
                            case 3:
                                playerTurn = "RED";
                                break;
                            case 4:
                                playerTurn = "RED";
                                break;
                        }
                    }
                }
                
                if(Steps==57)
                {
            Soundmanager.safeHouseSoundSource.Play();
            GameObject.FindGameObjectWithTag(tag).GetComponent<Button>().interactable = false;
                    totalyellowhouse += 1;
            playerTurn = "YELLOW";
           
                }
                if(totalyellowhouse==4)
                {
                    Debug.Log("yellow win");
                if (!first_position.enabled)
                {
                    first_position.enabled = true;
                    first_position.text = "1)Yellow Player";
                }
                else if (!second_position.enabled)
                {
                    second_position.enabled = true;
                    second_position.text = "2)Yellow Player";
                }
               else if (!third_position.enabled)
                {
                    third_position.enabled = true;
                    third_position.text = "3)Yellow Player";
                }
                else if (!fourth_position.enabled)
                {
                    fourth_position.enabled = true;
                    fourth_position.text = "4)Yellow Player";
                }
                switch (mainmenumanager.number_players)
                {
                    case 2:
                        if (first_position.enabled)
                        {
                        GameCompeleted();
                    }
                        break;
                    case 3:
                        if (first_position.enabled && second_position.enabled)
                        {
                        if (first_position.text == "1)Red Player")
                        {
                            third_position.text = "3)Blue Player";
                        }
                        if (first_position.text == "1)Blue Player")
                        {
                            third_position.text = "3)Red Player";
                        }
                        GameCompeleted();
                    }
                        break;
                    case 4:
                        if (first_position.enabled && second_position.enabled && third_position.enabled)
                        {
                        GameCompeleted();
                    }
                        break;
                }
            }


            

            
        
       
        return Steps;

    }
    public void redPlayer1movement()
    {
        Soundmanager.playermoveSoundSource.Play();
        Safe = false;
        if (redplayer1sizeReduced)
        {
            redplayer1.transform.localScale = new Vector3(1, 1, 1);
            redplayer1.transform.position -= new Vector3(0, 5, 0);
            redplayer1sizeReduced = false;

        }
        redplayer1Steps = redPlayermovement("Playerred1", redplayer1Steps, redplayer1Caze, redplayer1Button);
        if (redplayer1Steps > 51)
        {
            redplayer1safeWin = true;
        }
        if (redplayer1Steps == 1 || redplayer1Steps == 9 || redplayer1Steps == 14 || redplayer1Steps == 22 || redplayer1Steps == 27 || redplayer1Steps == 35 || redplayer1Steps == 40 || redplayer1Steps == 48)
        {
            Safe = true;
        }
        int Steps = redplayer1Steps;
        if ((Steps == (greenplayer1Steps + 26) || Steps == (greenplayer1Steps - 26)) &&!greenplayer1safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "RED";
                greenplayer1Steps = 0;
                GameObject.FindGameObjectWithTag("Playergreen1").transform.position = greenMovementBlock[57].transform.position;
                greenplayer1Caze.SetActive(true);
            }
            if(Safe)
            {
                greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer1sizeReduced = true;
                redplayer1.transform.localScale = new Vector3(0.5f, 0.5f,1);
                redplayer1.transform.position += new Vector3(0, 5, 0);
                redplayer1sizeReduced = true;
            }

        }
        if ((Steps == (greenplayer2Steps + 26) || Steps == (greenplayer2Steps - 26))&& !greenplayer2safeWin )
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "RED";
                greenplayer2Steps = 0;
                GameObject.FindGameObjectWithTag("Playergreen2").transform.position = greenMovementBlock[58].transform.position;
                greenplayer2Caze.SetActive(true);
            }
            if (Safe)
            {

                greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer2sizeReduced = true;
                redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer1.transform.position += new Vector3(0, 5, 0);
                redplayer1sizeReduced = true;

            }
        }
        if ((Steps == (greenplayer3Steps + 26) || Steps == (greenplayer3Steps - 26))&& !greenplayer3safeWin )
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "RED";
                greenplayer3Steps = 0;
                GameObject.FindGameObjectWithTag("Playergreen3").transform.position = greenMovementBlock[59].transform.position;
                greenplayer3Caze.SetActive(true);
            }
            if (Safe)
            {
                greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer3sizeReduced = true;
                redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer1.transform.position += new Vector3(0, 5, 0);
                redplayer1sizeReduced = true;

            }
        }
        if( (Steps == (greenplayer4Steps + 26) || Steps == (greenplayer4Steps - 26))&& !greenplayer4safeWin )
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "RED";
                greenplayer4Steps = 0;
                GameObject.FindGameObjectWithTag("Playergreen4").transform.position = greenMovementBlock[60].transform.position;
                greenplayer4Caze.SetActive(true);
            }
            if (Safe)
            {
                greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer4sizeReduced = true;
                redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer1.transform.position += new Vector3(0, 5, 0);
                redplayer1sizeReduced = true;

            }

        }
        if (Steps < 40)
        {
            if (Steps == (yellowplayer1Steps - 13) && !yellowplayer1safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow1").transform.position = yellowMovementBlock[57].transform.position;
                    yellowplayer1Caze.SetActive(true);
                }
                if (Safe)
                {
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1sizeReduced = true;
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1.transform.position += new Vector3(0, 5, 0);
                    redplayer1sizeReduced = true;
                }

            }
            if (Steps == (yellowplayer2Steps - 13) && !yellowplayer2safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow2").transform.position = yellowMovementBlock[58].transform.position;
                    yellowplayer2Caze.SetActive(true);
                }
                if (Safe)
                {
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2sizeReduced = true;
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1.transform.position += new Vector3(0, 5, 0);
                    redplayer1sizeReduced = true;
                }

            }
            if (Steps == (yellowplayer3Steps - 13) && !yellowplayer3safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow3").transform.position = yellowMovementBlock[59].transform.position;
                    yellowplayer3Caze.SetActive(true);
                }
                if (Safe)
                {
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3sizeReduced = true;
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1.transform.position += new Vector3(0, 5, 0);
                    redplayer1sizeReduced = true;
                }
            }
            if (Steps == (yellowplayer4Steps - 13) && !yellowplayer4safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow4").transform.position = yellowMovementBlock[60].transform.position;
                    yellowplayer4Caze.SetActive(true);
                }
                if (Safe)
                {
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4sizeReduced = true;
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1.transform.position += new Vector3(0, 5, 0);
                    redplayer1sizeReduced = true;
                }
            }
        }
        if (Steps >= 40)
        {
            if (Steps == (yellowplayer1Steps +39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow1").transform.position = yellowMovementBlock[57].transform.position;
                    yellowplayer1Caze.SetActive(true);
                }
                if (Safe)
                {
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1sizeReduced = true;
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1.transform.position += new Vector3(0, 5, 0);
                    redplayer1sizeReduced = true;
                }

            }
            if (Steps == (yellowplayer2Steps +39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow2").transform.position = yellowMovementBlock[58].transform.position;
                    yellowplayer2Caze.SetActive(true);
                }
                if (Safe)
                {
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2sizeReduced = true;
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1.transform.position += new Vector3(0, 5, 0);
                    redplayer1sizeReduced = true;
                }

            }
            if (Steps == (yellowplayer3Steps +39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow3").transform.position = yellowMovementBlock[59].transform.position;
                    yellowplayer3Caze.SetActive(true);
                }
                if (Safe)
                {
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3sizeReduced = true;
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1.transform.position += new Vector3(0, 5, 0);
                    redplayer1sizeReduced = true;
                }
            }
            if (Steps == (yellowplayer4Steps +39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow4").transform.position = yellowMovementBlock[60].transform.position;
                    yellowplayer4Caze.SetActive(true);
                }
                if (Safe)
                {
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4sizeReduced = true;
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1.transform.position += new Vector3(0, 5, 0);
                    redplayer1sizeReduced = true;
                }
            }
        }
        if (blueplayer1Steps < 40)
        {
            if (Steps == (blueplayer1Steps +13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue1").transform.position = blueMovementBlock[57].transform.position;
                    blueplayer1Caze.SetActive(true);
                }
                if (Safe)
                {
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1sizeReduced = true;
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1.transform.position += new Vector3(0, 5, 0);
                    redplayer1sizeReduced = true;
                }
            }
        }
        if (blueplayer1Steps >= 40)
        {
            if (Steps == (blueplayer1Steps - 39) && !blueplayer1safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue1").transform.position = blueMovementBlock[57].transform.position;
                    blueplayer1Caze.SetActive(true);
                }
                if (Safe)
                {
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1sizeReduced = true;
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1.transform.position += new Vector3(0, 5, 0);
                    redplayer1sizeReduced = true;
                }
            }
        }
        if (blueplayer2Steps < 40)
        {
            if (Steps == (blueplayer2Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue2").transform.position = blueMovementBlock[58].transform.position;
                    blueplayer2Caze.SetActive(true);
                }
                if (Safe)
                {
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2sizeReduced = true;
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1.transform.position += new Vector3(0, 5, 0);
                    redplayer1sizeReduced = true;
                }
            }
        }
        if (blueplayer2Steps >= 40)
        {
            if (Steps == (blueplayer2Steps -39) && !blueplayer2safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue2").transform.position = blueMovementBlock[58].transform.position;
                    blueplayer2Caze.SetActive(true);

                }
                if (Safe)
                {
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2sizeReduced = true;
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1.transform.position += new Vector3(0, 5, 0);
                    redplayer1sizeReduced = true;
                }
            }
        }
        if (blueplayer3Steps < 40)
        {
            if (Steps == (blueplayer3Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue3").transform.position = blueMovementBlock[59].transform.position;
                    blueplayer3Caze.SetActive(true);
                }
                if (Safe)
                {
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3sizeReduced = true;
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1.transform.position += new Vector3(0, 5, 0);
                    redplayer1sizeReduced = true;
                }
            }
        }
        if (blueplayer3Steps >= 40)
        {
            if (Steps == (blueplayer3Steps -39) && !blueplayer3safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue3").transform.position = blueMovementBlock[59].transform.position;
                    blueplayer3Caze.SetActive(true);
                }
                if (Safe)
                {
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3sizeReduced = true;
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1.transform.position += new Vector3(0, 5, 0);
                    redplayer1sizeReduced = true;
                }
            }
        }
        if (blueplayer4Steps < 40)
        {
            if (Steps == (blueplayer4Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue4").transform.position = blueMovementBlock[60].transform.position;
                    blueplayer4Caze.SetActive(true);
                }
                if (Safe)
                {
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4sizeReduced = true;
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1.transform.position += new Vector3(0, 5, 0);
                    redplayer1sizeReduced = true;

                }
            }
        }
        if (blueplayer4Steps >= 40)
        {
            if (Steps == (blueplayer4Steps -39) && !blueplayer4safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue4").transform.position = blueMovementBlock[60].transform.position;
                    blueplayer4Caze.SetActive(true);
                }
                if (Safe)
                {
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4sizeReduced = true;
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1.transform.position += new Vector3(0, 5, 0);
                    redplayer1sizeReduced = true;

                }
            }
        }

       

        if (redplayer1Steps == 0)
        {
            redplayer1Caze.SetActive(true);
            redplayer1Button.interactable = false;
        }
        if (redplayer2Steps == 0)
        {
            redplayer2Caze.SetActive(true);
            redplayer2Button.interactable = false;
        }
        if (redplayer3Steps == 0)
        {
            redplayer3Caze.SetActive(true);
            redplayer3Button.interactable = false;
        }
        if (redplayer4Steps == 0)
        {
            redplayer4Caze.SetActive(true);
            redplayer4Button.interactable = false;
        }


        IntializePlayerTurn();
    }
    public void redPlayer2movement()
    {
        Soundmanager.playermoveSoundSource.Play();
        Safe = false;
        if (redplayer2sizeReduced)
        {
            redplayer2.transform.localScale = new Vector3(1, 1, 1);
            redplayer2.transform.position -= new Vector3(0, 5, 0);
            redplayer2sizeReduced = false;

        }
        redplayer2Steps = redPlayermovement("Playerred2", redplayer2Steps, redplayer2Caze, redplayer2Button);
        if (redplayer2Steps > 51)
        {
            redplayer2safeWin = true;
        }
        if (redplayer2Steps == 1 || redplayer2Steps == 9 || redplayer2Steps == 14 || redplayer2Steps == 22 || redplayer2Steps == 27 || redplayer2Steps == 35 || redplayer2Steps == 40 || redplayer2Steps == 48)
        {
            Safe = true;
        }
        int Steps = redplayer2Steps;
        if( (Steps == (greenplayer1Steps + 26) || Steps == (greenplayer1Steps - 26))  && !greenplayer1safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "RED";
                greenplayer1Steps = 0;
                GameObject.FindGameObjectWithTag("Playergreen1").transform.position = greenMovementBlock[57].transform.position;
                greenplayer1Caze.SetActive(true);
            }
            if (Safe)
            {
                greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer1sizeReduced = true;
                redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer2.transform.position += new Vector3(0, 5, 0);
                redplayer2sizeReduced = true;
            }
        }
        if ((Steps == (greenplayer2Steps + 26)||Steps==(greenplayer2Steps-26)) && !greenplayer2safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "RED";
                greenplayer2Steps = 0;
                GameObject.FindGameObjectWithTag("Playergreen2").transform.position = greenMovementBlock[58].transform.position;
                greenplayer1Caze.SetActive(true);
            }
            if (Safe)
            {
                greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer2sizeReduced = true;
                redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer2.transform.position += new Vector3(0, 5, 0);
                redplayer2sizeReduced = true;
            }
        }
        if ((Steps == (greenplayer3Steps + 26) || Steps == (greenplayer3Steps - 26)) && !greenplayer3safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "RED";
                greenplayer3Steps = 0;
                GameObject.FindGameObjectWithTag("Playergreen3").transform.position = greenMovementBlock[59].transform.position;
            }
            if (Safe)
            {
                greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer3sizeReduced = true;
                redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer2.transform.position += new Vector3(0, 5, 0);
                redplayer2sizeReduced = true;
            }

        }
        if( (Steps == (greenplayer4Steps + 26) || Steps == (greenplayer4Steps - 26)) && !greenplayer4safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "RED";
                greenplayer4Steps = 0;
                GameObject.FindGameObjectWithTag("Playergreen4").transform.position = greenMovementBlock[60].transform.position;
            }
            if (Safe)
            {
                greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer4sizeReduced = true;
                redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer2.transform.position += new Vector3(0, 5, 0);
                redplayer2sizeReduced = true;
            }
        }
        if (Steps < 40)
        {
            if (Steps == (yellowplayer1Steps - 13) && !yellowplayer1safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow1").transform.position = yellowMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1sizeReduced = true;
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2.transform.position += new Vector3(0, 5, 0);
                    redplayer2sizeReduced = true;
                }

            }
            if (Steps == (yellowplayer2Steps - 13) && !yellowplayer2safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow2").transform.position = yellowMovementBlock[58].transform.position;
                }
                if (Safe)
                {
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2sizeReduced = true;
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2.transform.position += new Vector3(0, 5, 0);
                    redplayer2sizeReduced = true;
                }

            }
            if (Steps == (yellowplayer3Steps -13) && !yellowplayer3safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow3").transform.position = yellowMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3sizeReduced = true;
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2.transform.position += new Vector3(0, 5, 0);
                    redplayer2sizeReduced = true;
                }
            }
            if (Steps == (yellowplayer4Steps -13) && !yellowplayer4safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow4").transform.position = yellowMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4sizeReduced = true;
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2.transform.position += new Vector3(0, 5, 0);
                    redplayer2sizeReduced = true;
                }
            }
        }
        if (Steps >= 40)
        {
            if (Steps == (yellowplayer1Steps +39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow1").transform.position = yellowMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1sizeReduced = true;
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2.transform.position += new Vector3(0, 5, 0);
                    redplayer2sizeReduced = true;
                }

            }
            if (Steps == (yellowplayer2Steps +39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow2").transform.position = yellowMovementBlock[58].transform.position;
                }
                if (Safe)
                {
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2sizeReduced = true;
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2.transform.position += new Vector3(0, 5, 0);
                    redplayer2sizeReduced = true;
                }

            }
            if (Steps == (yellowplayer3Steps+39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow3").transform.position = yellowMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3sizeReduced = true;
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2.transform.position += new Vector3(0, 5, 0);
                    redplayer2sizeReduced = true;
                }
            }
            if (Steps == (yellowplayer4Steps +39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow4").transform.position = yellowMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4sizeReduced = true;
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2.transform.position += new Vector3(0, 5, 0);
                    redplayer2sizeReduced = true;
                }
            }
        }
        if (blueplayer1Steps < 40)
        {

            if (Steps == (blueplayer1Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue1").transform.position = blueMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1sizeReduced = true;
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2.transform.position += new Vector3(0, 5, 0);
                    redplayer2sizeReduced = true;
                }
            }
        }
        if (blueplayer1Steps >= 40)
        {

            if (Steps == (blueplayer1Steps -39) && !blueplayer1safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue1").transform.position = blueMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1sizeReduced = true;
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2.transform.position += new Vector3(0, 5, 0);
                    redplayer2sizeReduced = true;
                }
            }
        }
        if (blueplayer2Steps < 40)
        {
            if (Steps == (blueplayer2Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue2").transform.position = blueMovementBlock[58].transform.position;
                }
                if (Safe)
                {
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2sizeReduced = true;
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2.transform.position += new Vector3(0, 5, 0);
                    redplayer2sizeReduced = true;
                }
            }
        }

        if (blueplayer2Steps >=40)
        {
            if (Steps == (blueplayer2Steps -39) && !blueplayer2safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue2").transform.position = blueMovementBlock[58].transform.position;
                }
                if (Safe)
                {
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2sizeReduced = true;
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2.transform.position += new Vector3(0, 5, 0);
                    redplayer2sizeReduced = true;
                }
            }
        }
        if (blueplayer3Steps < 40)
        {
            if (Steps == (blueplayer3Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue3").transform.position = blueMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3sizeReduced = true;
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2.transform.position += new Vector3(0, 5, 0);
                    redplayer2sizeReduced = true;
                }
            }
        }
        if (blueplayer3Steps >= 40)
        {
            if (Steps == (blueplayer3Steps -39) && !blueplayer3safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue3").transform.position = blueMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3sizeReduced = true;
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2.transform.position += new Vector3(0, 5, 0);
                    redplayer2sizeReduced = true;
                }
            }
        }
        if (blueplayer4Steps < 40)
        {
            if (Steps == (blueplayer4Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue4").transform.position = blueMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4sizeReduced = true;
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2.transform.position += new Vector3(0, 5, 0);
                    redplayer2sizeReduced = true;
                }
            }
        }
        if (blueplayer4Steps >= 40)
        {
            if (Steps == (blueplayer4Steps -39) && !blueplayer4safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue4").transform.position = blueMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4sizeReduced = true;
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2.transform.position += new Vector3(0, 5, 0);
                    redplayer2sizeReduced = true;
                }
            }
        }
        if ((58 - redplayer1Steps) < selectDiceNumAnimation)
        {
            redplayer1Button.interactable = false;
        }
        if ((58 - redplayer1Steps) >= selectDiceNumAnimation && redplayer1Steps != 0)
        {
            redplayer1Button.interactable = true;
        }

        if (redplayer1Steps == 0)
        {
            redplayer1Caze.SetActive(true);
            redplayer1Button.interactable = false;
        }
        if (redplayer2Steps == 0)
        {
            redplayer2Caze.SetActive(true);
            redplayer2Button.interactable = false;
        }
        if (redplayer3Steps == 0)
        {
            redplayer3Caze.SetActive(true);
            redplayer3Button.interactable = false;
        }
        if (redplayer4Steps == 0)
        {
            redplayer4Caze.SetActive(true);
            redplayer4Button.interactable = false;
        }
        if ((redMovementBlock.Count - redplayer2Steps) < selectDiceNumAnimation)
        {
            redplayer2Button.interactable = false;
        }
        if ((redMovementBlock.Count - redplayer2Steps) >= selectDiceNumAnimation && redplayer2Steps != 0)
        {
            redplayer2Button.interactable = true;
        }
        if (redplayer1Steps == 0)
        {
            redplayer1Caze.SetActive(true);
            redplayer1Button.interactable = false;
        }
        if (redplayer2Steps == 0)
        {
            redplayer2Caze.SetActive(true);
            redplayer2Button.interactable = false;
        }
        if (redplayer3Steps == 0)
        {
            redplayer3Caze.SetActive(true);
            redplayer3Button.interactable = false;
        }
        if (redplayer4Steps == 0)
        {
            redplayer4Caze.SetActive(true);
            redplayer4Button.interactable = false;
        }

        IntializePlayerTurn();
    }
    public void redPlayer3movement()
    {
        Soundmanager.playermoveSoundSource.Play();
        Safe = false;
        if (redplayer3sizeReduced)
        {
            redplayer3.transform.localScale = new Vector3(1, 1, 1);
            redplayer3.transform.position -= new Vector3(0, 5, 0);
            redplayer3sizeReduced = false;

        }
        redplayer3Steps = redPlayermovement("Playerred3", redplayer3Steps, redplayer3Caze, redplayer3Button);
        if (redplayer3Steps > 51)
        {
            redplayer3safeWin = true;
        }
        if (redplayer3Steps == 1 || redplayer3Steps == 9 || redplayer3Steps == 14 || redplayer3Steps == 22 || redplayer3Steps == 27 || redplayer3Steps == 35 || redplayer3Steps == 40 || redplayer3Steps == 48)
        {
            Safe = true;
        }
        int Steps = redplayer3Steps;
        
        if ((Steps == (greenplayer1Steps + 26) || Steps == (greenplayer1Steps - 26))&&!greenplayer1safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "RED";
                greenplayer1Steps = 0;
                GameObject.FindGameObjectWithTag("Playergreen1").transform.position = greenMovementBlock[57].transform.position;
                greenplayer1Caze.SetActive(true);
            }
            if (Safe)
            {
                greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer1sizeReduced = true;
                redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer3.transform.position += new Vector3(0, 5, 0);
                redplayer3sizeReduced = true;
            }

        }
        if( (Steps == (greenplayer2Steps + 26) || Steps == (greenplayer2Steps - 26))&& !greenplayer2safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "RED";
                greenplayer2Steps = 0;
                GameObject.FindGameObjectWithTag("Playergreen2").transform.position = greenMovementBlock[58].transform.position;
                greenplayer2Caze.SetActive(true);
            }
            if (Safe)
            {
                greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer2sizeReduced = true;
                redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer3.transform.position += new Vector3(0, 5, 0);
                redplayer3sizeReduced = true;
            }
        }
        if ((Steps == (greenplayer3Steps + 26) || Steps == (greenplayer3Steps - 26))&& !greenplayer3safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "RED";
                greenplayer3Steps = 0;
                GameObject.FindGameObjectWithTag("Playergreen3").transform.position = greenMovementBlock[59].transform.position;
            }
            if (Safe)
            {
                greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer3sizeReduced = true;
                redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer3.transform.position += new Vector3(0, 5, 0);
                redplayer3sizeReduced = true;
            }

        }
        if ((Steps == (greenplayer4Steps + 26) || Steps == (greenplayer4Steps - 26))&& !greenplayer4safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "RED";
                greenplayer4Steps = 0;
                GameObject.FindGameObjectWithTag("Playergreen4").transform.position = greenMovementBlock[60].transform.position;
            }
            if (Safe)
            {
                greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer4sizeReduced = true;
                redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer3.transform.position += new Vector3(0, 5, 0);
                redplayer3sizeReduced = true;
            }

        }
        if (Steps < 40)
        {
            if (Steps == (yellowplayer1Steps - 13) && !yellowplayer1safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow1").transform.position = yellowMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1sizeReduced = true;
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3.transform.position += new Vector3(0, 5, 0);
                    redplayer3sizeReduced = true;
                }
            }
            if (Steps == (yellowplayer2Steps - 13) && !yellowplayer2safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow2").transform.position = yellowMovementBlock[58].transform.position;
                }
                if (Safe)
                {
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2sizeReduced = true;
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3.transform.position += new Vector3(0, 5, 0);
                    redplayer3sizeReduced = true;
                }

            }
            if (Steps == (yellowplayer3Steps - 13) && !yellowplayer3safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow3").transform.position = yellowMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3sizeReduced = true;
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3.transform.position += new Vector3(0, 5, 0);
                    redplayer3sizeReduced = true;
                }
            }
            if (Steps == (yellowplayer4Steps - 13) && !yellowplayer4safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow4").transform.position = yellowMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4sizeReduced = true;
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3.transform.position += new Vector3(0, 5, 0);
                    redplayer3sizeReduced = true;
                }
            }
        }
        if (Steps >= 40)
        {
            if (Steps == (yellowplayer1Steps +39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow1").transform.position = yellowMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1sizeReduced = true;
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3.transform.position += new Vector3(0, 5, 0);
                    redplayer3sizeReduced = true;
                }
            }
            if (Steps == (yellowplayer2Steps +39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow2").transform.position = yellowMovementBlock[58].transform.position;
                }
                if (Safe)
                {
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2sizeReduced = true;
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3.transform.position += new Vector3(0, 5, 0);
                    redplayer3sizeReduced = true;
                }

            }
            if (Steps == (yellowplayer3Steps +39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow3").transform.position = yellowMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3sizeReduced = true;
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3.transform.position += new Vector3(0, 5, 0);
                    redplayer3sizeReduced = true;
                }
            }
            if (Steps == (yellowplayer4Steps +39))
            {
                if (!Safe)
                {
                    playerTurn = "RED";
                    yellowplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow4").transform.position = yellowMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4sizeReduced = true;
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3.transform.position += new Vector3(0, 5, 0);
                    redplayer3sizeReduced = true;
                }
            }
        }
        if (blueplayer1Steps < 40)
        {
            if (Steps == (blueplayer1Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue1").transform.position = blueMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1sizeReduced = true;
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3.transform.position += new Vector3(0, 5, 0);
                    redplayer3sizeReduced = true;
                }
            }
        }
        if (blueplayer1Steps >= 40)
        {
            if (Steps == (blueplayer1Steps -39) && !blueplayer1safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue1").transform.position = blueMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1sizeReduced = true;
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3.transform.position += new Vector3(0, 5, 0);
                    redplayer3sizeReduced = true;
                }
            }
        }
        if (blueplayer2Steps < 40)
        {

            if (Steps == (blueplayer2Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue2").transform.position = blueMovementBlock[58].transform.position;
                }
                if (Safe)
                {
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2sizeReduced = true;
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3.transform.position += new Vector3(0, 5, 0);
                    redplayer3sizeReduced = true;
                }
            }
        }
        if (blueplayer2Steps >= 40)
        {

            if (Steps == (blueplayer2Steps -39) && !blueplayer2safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue2").transform.position = blueMovementBlock[58].transform.position;
                }
                if (Safe)
                {
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2sizeReduced = true;
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3.transform.position += new Vector3(0, 5, 0);
                    redplayer3sizeReduced = true;
                }
            }
        }
        if (blueplayer3Steps < 40)
        {

            if (Steps == (blueplayer3Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue3").transform.position = blueMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3sizeReduced = true;
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3.transform.position += new Vector3(0, 5, 0);
                    redplayer3sizeReduced = true;
                }
            }
        }
        if (blueplayer3Steps >= 40)
        {

            if (Steps == (blueplayer3Steps -39) && !blueplayer3safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue3").transform.position = blueMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3sizeReduced = true;
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3.transform.position += new Vector3(0, 5, 0);
                    redplayer3sizeReduced = true;
                }
            }
        }
        if (blueplayer4Steps < 40)
        {
            if (Steps == (blueplayer4Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue4").transform.position = blueMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4sizeReduced = true;
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3.transform.position += new Vector3(0, 5, 0);
                    redplayer3sizeReduced = true;
                }
            }
        }
        if (blueplayer4Steps >= 40)
        {
            if (Steps == (blueplayer4Steps -39) && !blueplayer4safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue4").transform.position = blueMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4sizeReduced = true;
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3.transform.position += new Vector3(0, 5, 0);
                    redplayer3sizeReduced = true;
                }
            }
        }
        if ((57 - redplayer1Steps) < selectDiceNumAnimation)
        {
            redplayer1Button.interactable = false;
        }
        if ((57 - redplayer1Steps) >= selectDiceNumAnimation && redplayer1Steps != 0)
        {
            redplayer1Button.interactable = true;
        }

        if (redplayer1Steps == 0)
        {
            redplayer1Caze.SetActive(true);
            redplayer1Button.interactable = false;
        }
        if (redplayer2Steps == 0)
        {
            redplayer2Caze.SetActive(true);
            redplayer2Button.interactable = false;
        }
        if (redplayer3Steps == 0)
        {
            redplayer3Caze.SetActive(true);
            redplayer3Button.interactable = false;
        }
        if (redplayer4Steps == 0)
        {
            redplayer4Caze.SetActive(true);
            redplayer4Button.interactable = false;
        }
        if ((redMovementBlock.Count - redplayer3Steps) < selectDiceNumAnimation)
        {
            redplayer3Button.interactable = false;
        }
        if ((redMovementBlock.Count - redplayer3Steps) >= selectDiceNumAnimation && redplayer3Steps != 0)
        {
            redplayer3Button.interactable = true;
        }
        if (redplayer1Steps == 0)
        {
            redplayer1Caze.SetActive(true);
            redplayer1Button.interactable = false;
        }
        if (redplayer2Steps == 0)
        {
            redplayer2Caze.SetActive(true);
            redplayer2Button.interactable = false;
        }
        if (redplayer3Steps == 0)
        {
            redplayer3Caze.SetActive(true);
            redplayer3Button.interactable = false;
        }
        if (redplayer4Steps == 0)
        {
            redplayer4Caze.SetActive(true);
            redplayer4Button.interactable = false;
        }
        IntializePlayerTurn();
    }
    public void redPlayer4movement()
    {
        Soundmanager.playermoveSoundSource.Play();
        Safe = false;
        if (redplayer4sizeReduced)
        {
            redplayer4.transform.localScale = new Vector3(1, 1, 1);
            redplayer4.transform.position -= new Vector3(0, 5, 0);
            redplayer4sizeReduced = false;

        }
        redplayer4Steps = redPlayermovement("Playerred4", redplayer4Steps, redplayer4Caze, redplayer4Button);
        if (redplayer4Steps > 51)
        {
            redplayer4safeWin = true;
        }
        if (redplayer4Steps == 1 || redplayer4Steps == 9 || redplayer4Steps == 14 || redplayer4Steps == 22 || redplayer4Steps == 27 || redplayer4Steps == 35 || redplayer4Steps == 40 || redplayer4Steps == 48)
        {
            Safe = true;
        }
        int Steps = redplayer4Steps;
        if ((Steps == (greenplayer1Steps + 26) || Steps == (greenplayer1Steps - 26)) && !greenplayer1safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "RED";
                greenplayer1Steps = 0;
                GameObject.FindGameObjectWithTag("Playergreen1").transform.position = greenMovementBlock[57].transform.position;
                greenplayer1Caze.SetActive(true);
            }
            if (Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer1sizeReduced = true;
                redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer4.transform.position += new Vector3(0, 5, 0);
                redplayer4sizeReduced = true;
            }

        }
        if ((Steps == (greenplayer2Steps + 26) || Steps == (greenplayer2Steps - 26)) && !greenplayer2safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "RED";
                greenplayer2Steps = 0;
                GameObject.FindGameObjectWithTag("Playergreen2").transform.position = greenMovementBlock[58].transform.position;
                greenplayer1Caze.SetActive(true);
            }
            if (Safe)
            {
                greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer2sizeReduced = true;
                redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer4.transform.position += new Vector3(0, 5, 0);
                redplayer4sizeReduced = true;
            }
        }
        if ((Steps == (greenplayer3Steps + 26) || Steps == (greenplayer3Steps - 26)) && !greenplayer3safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "RED";
                greenplayer3Steps = 0;
                GameObject.FindGameObjectWithTag("Playergreen3").transform.position = greenMovementBlock[59].transform.position;
            }
            if (Safe)
            {
                greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer3sizeReduced = true;
                redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer4.transform.position += new Vector3(0, 5, 0);
                redplayer4sizeReduced = true;
            }

        }
        if ((Steps == (greenplayer4Steps + 26) || Steps == (greenplayer4Steps - 26)) && !greenplayer4safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "RED";
                greenplayer4Steps = 0;
                GameObject.FindGameObjectWithTag("Playergreen4").transform.position = greenMovementBlock[60].transform.position;
            }
            if (Safe)
            {
                greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer4sizeReduced = true;
                redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer4.transform.position += new Vector3(0, 5, 0);
                redplayer4sizeReduced = true;
            }
        }
        if (Steps < 40)
        {
            if (Steps == (yellowplayer1Steps - 13) && !yellowplayer1safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow1").transform.position = yellowMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1sizeReduced = true;
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4.transform.position += new Vector3(0, 5, 0);
                    redplayer4sizeReduced = true;
                }

            }
            if (Steps == (yellowplayer2Steps - 13) && !yellowplayer2safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow2").transform.position = yellowMovementBlock[58].transform.position;
                }
                if (Safe)
                {
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2sizeReduced = true;
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4.transform.position += new Vector3(0, 5, 0);
                    redplayer4sizeReduced = true;
                }

            }
            if (Steps == (yellowplayer3Steps -13) && !yellowplayer3safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow3").transform.position = yellowMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3sizeReduced = true;
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4.transform.position += new Vector3(0, 5, 0);
                    redplayer4sizeReduced = true;
                }
            }
            if (Steps == (yellowplayer4Steps -13) && !yellowplayer4safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow4").transform.position = yellowMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4sizeReduced = true;
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4.transform.position += new Vector3(0, 5, 0);
                    redplayer4sizeReduced = true;
                }
            }
        }
        if (Steps >= 40)
        {
            if (Steps == (yellowplayer1Steps + 39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow1").transform.position = yellowMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1sizeReduced = true;
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4.transform.position += new Vector3(0, 5, 0);
                    redplayer4sizeReduced = true;
                }

            }
            if (Steps == (yellowplayer2Steps + 39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow2").transform.position = yellowMovementBlock[58].transform.position;
                }
                if (Safe)
                {
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2sizeReduced = true;
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4.transform.position += new Vector3(0, 5, 0);
                    redplayer4sizeReduced = true;
                }

            }

            if (Steps == (yellowplayer3Steps + 39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow3").transform.position = yellowMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3sizeReduced = true;
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4.transform.position += new Vector3(0, 5, 0);
                    redplayer4sizeReduced = true;
                }
            }
            if (Steps == (yellowplayer4Steps + 39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    yellowplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow4").transform.position = yellowMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4sizeReduced = true;
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4.transform.position += new Vector3(0, 5, 0);
                    redplayer4sizeReduced = true;
                }
            }
        }
        if (blueplayer1Steps < 40)
        {
            if (Steps == (blueplayer1Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue1").transform.position = blueMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1sizeReduced = true;
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4.transform.position += new Vector3(0, 5, 0);
                    redplayer4sizeReduced = true;
                }
            }
        }
        if (blueplayer1Steps >=40)
        {
            if (Steps == (blueplayer1Steps -39) && !blueplayer1safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue1").transform.position = blueMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1sizeReduced = true;
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4.transform.position += new Vector3(0, 5, 0);
                    redplayer4sizeReduced = true;
                }
            }
        }
        if (blueplayer2Steps < 40)
        {
            if (Steps == (blueplayer2Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue2").transform.position = blueMovementBlock[58].transform.position;
                }
                if (Safe)
                {
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2sizeReduced = true;
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4.transform.position += new Vector3(0, 5, 0);
                    redplayer4sizeReduced = true;
                }
            }
        }
        if (blueplayer2Steps < 40)
        {
            if (Steps == (blueplayer2Steps -39) && !blueplayer2safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue2").transform.position = blueMovementBlock[58].transform.position;
                }
                if (Safe)
                {
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2sizeReduced = true;
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4.transform.position += new Vector3(0, 5, 0);
                    redplayer4sizeReduced = true;
                }
            }
        }
        if (blueplayer3Steps < 40)
        {
            if (Steps == (blueplayer3Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue3").transform.position = blueMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3sizeReduced = true;
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4.transform.position += new Vector3(0, 5, 0);
                    redplayer4sizeReduced = true;
                }
            }
        }
        if (blueplayer3Steps >= 40)
        {
            if (Steps == (blueplayer3Steps -39) && !blueplayer3safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue3").transform.position = blueMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3sizeReduced = true;
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4.transform.position += new Vector3(0, 5, 0);
                    redplayer4sizeReduced = true;
                }
            }
        }
        if (blueplayer4Steps < 40)
        {
            if (Steps == (blueplayer4Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue4").transform.position = blueMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4sizeReduced = true;
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4.transform.position += new Vector3(0, 5, 0);
                    redplayer4sizeReduced = true;
                }
            }
        }
        if (blueplayer4Steps >=40)
        {
            if (Steps == (blueplayer4Steps -39) && !blueplayer4safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "RED";
                    blueplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue4").transform.position = blueMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4sizeReduced = true;
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4.transform.position += new Vector3(0, 5, 0);
                    redplayer4sizeReduced = true;
                }
            }
        }
        if ((58 - redplayer4Steps) < selectDiceNumAnimation)
        {
            redplayer1Button.interactable = false;
        }
        if ((58 - redplayer4Steps) >= selectDiceNumAnimation && redplayer1Steps != 0)
        {
            redplayer1Button.interactable = true;
        }

        if (redplayer1Steps == 0)
        {
            redplayer1Caze.SetActive(true);
            redplayer1Button.interactable = false;
        }
        if (redplayer2Steps == 0)
        {
            redplayer2Caze.SetActive(true);
            redplayer2Button.interactable = false;
        }
        if (redplayer3Steps == 0)
        {
            redplayer3Caze.SetActive(true);
            redplayer3Button.interactable = false;
        }
        if (redplayer4Steps == 0)
        {
            redplayer4Caze.SetActive(true);
            redplayer4Button.interactable = false;
        }
        if ((redMovementBlock.Count - redplayer4Steps) < selectDiceNumAnimation)
        {
            redplayer4Button.interactable = false;
        }
        if ((redMovementBlock.Count - redplayer4Steps) >= selectDiceNumAnimation && redplayer4Steps != 0)
        {
            redplayer4Button.interactable = true;
        }
        if (redplayer1Steps == 0)
        {
            redplayer1Caze.SetActive(true);
            redplayer1Button.interactable = false;
        }
        if (redplayer2Steps == 0)
        {
            redplayer2Caze.SetActive(true);
            redplayer2Button.interactable = false;
        }
        if (redplayer3Steps == 0)
        {
            redplayer3Caze.SetActive(true);
            redplayer3Button.interactable = false;
        }
        if (redplayer4Steps == 0)
        {
            redplayer4Caze.SetActive(true);
            redplayer4Button.interactable = false;
        }

        IntializePlayerTurn();
    }
    public void greenPlayer1movement()
    {
        Soundmanager.playermoveSoundSource.Play();
        Safe = false;
        if (greenplayer1sizeReduced)
        {
            Soundmanager.dismissalSoundSource.Play();
            greenplayer1.transform.localScale = new Vector3(1, 1, 1);
            greenplayer1.transform.position -= new Vector3(0, 5, 0);
            greenplayer1sizeReduced = false;

        }
        greenplayer1Steps = greenPlayermovement("Playergreen1", greenplayer1Steps);
        if (greenplayer1Steps > 51)
        {
            greenplayer2safeWin = true;
        }
        if (greenplayer1Steps == 1 || greenplayer1Steps == 9 || greenplayer1Steps == 14 || greenplayer1Steps == 22 || greenplayer1Steps == 27 || greenplayer1Steps == 35 || greenplayer1Steps == 40 || greenplayer1Steps == 48)
        {
            Safe = true;
        }
        int Steps = greenplayer1Steps;
        if ((Steps == (redplayer1Steps + 26) || Steps == (redplayer1Steps - 26)) && !greenplayer1safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "GREEN";
                redplayer1Steps = 0;
                GameObject.FindGameObjectWithTag("Playerred1").transform.position = redMovementBlock[57].transform.position;
            }
            if (Safe)
            {
                redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer1sizeReduced = true;
                greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer1.transform.position += new Vector3(0, 5, 0);
                greenplayer1sizeReduced = true;
            }
        }
        if ((Steps == (redplayer2Steps + 26) || Steps == (redplayer2Steps - 26)) && !greenplayer2safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "GREEN";
                redplayer2Steps = 0;
                GameObject.FindGameObjectWithTag("Playerred2").transform.position = redMovementBlock[58].transform.position;
            }
            if (Safe)
            {
                redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer2sizeReduced = true;
                greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer1.transform.position += new Vector3(0, 5, 0);
                greenplayer1sizeReduced = true;
            }
        }
        if ((Steps == (redplayer3Steps + 26) || Steps == (redplayer3Steps - 26))&& !greenplayer3safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "GREEN";
                redplayer3Steps = 0;
                GameObject.FindGameObjectWithTag("Playerred3").transform.position = redMovementBlock[59].transform.position;
            }
            if (Safe)
            {
                redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer3sizeReduced = true;
                greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer1.transform.position += new Vector3(0, 5, 0);
                greenplayer1sizeReduced = true;
            }
        }
        if ((Steps == (redplayer4Steps + 26) || Steps == (redplayer4Steps - 26)) && !greenplayer4safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "GREEN";
                redplayer4Steps = 0;
                GameObject.FindGameObjectWithTag("Playerred4").transform.position = redMovementBlock[60].transform.position;
            }
            if (Safe)
            {
                redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer4sizeReduced = true;
                greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer1.transform.position += new Vector3(0, 5, 0);
                greenplayer1sizeReduced = true;
            }
        }
        if (yellowplayer1Steps < 40)
        {

            if (Steps == (yellowplayer1Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    yellowplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow1").transform.position = yellowMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1sizeReduced = true;
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1.transform.position += new Vector3(0, 5, 0);
                    greenplayer1sizeReduced = true;
                }
            }
        }
        if (yellowplayer1Steps >= 40)
        {

            if (Steps == (yellowplayer1Steps -39) && !yellowplayer1safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    yellowplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow1").transform.position = yellowMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1sizeReduced = true;
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1.transform.position += new Vector3(0, 5, 0);
                    greenplayer1sizeReduced = true;
                }
            }
        }
        if (yellowplayer2Steps < 40)
        {

            if (Steps == (yellowplayer2Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    yellowplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow2").transform.position = yellowMovementBlock[58].transform.position;
                    playerTurn = "GREEN";
                }
                if (Safe)
                {
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2sizeReduced = true;
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1.transform.position += new Vector3(0, 5, 0);
                    greenplayer1sizeReduced = true;
                }
            }
        }
        if (yellowplayer2Steps >=40)
        {

            if (Steps == (yellowplayer2Steps -39) && !yellowplayer2safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    yellowplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow2").transform.position = yellowMovementBlock[58].transform.position;
                    playerTurn = "GREEN";
                }
                if (Safe)
                {
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2sizeReduced = true;
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1.transform.position += new Vector3(0, 5, 0);
                    greenplayer1sizeReduced = true;
                }
            }
        }
        if (yellowplayer3Steps < 40)
        {
            if (Steps == (yellowplayer3Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    yellowplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow3").transform.position = yellowMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3sizeReduced = true;
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1.transform.position += new Vector3(0, 5, 0);
                    greenplayer1sizeReduced = true;
                }
            }
        }
        if (yellowplayer3Steps >= 40)
        {
            if (Steps == (yellowplayer3Steps -39) && !yellowplayer3safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    yellowplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow3").transform.position = yellowMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3sizeReduced = true;
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1.transform.position += new Vector3(0, 5, 0);
                    greenplayer1sizeReduced = true;
                }
            }
        }
        if (yellowplayer4Steps < 40)
        {
            if (Steps == (yellowplayer4Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    yellowplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow4").transform.position = yellowMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4sizeReduced = true;
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1.transform.position += new Vector3(0, 5, 0);
                    greenplayer1sizeReduced = true;
                }
            }
        }
        if (yellowplayer4Steps >= 40)
        {
            if (Steps == (yellowplayer4Steps - 39) && !yellowplayer4safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    yellowplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow4").transform.position = yellowMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4sizeReduced = true;
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1.transform.position += new Vector3(0, 5, 0);
                    greenplayer1sizeReduced = true;
                }
            }
        }
        if (Steps < 40)
        {
            if (Steps == (blueplayer1Steps - 13) && !blueplayer1safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue1").transform.position = blueMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1sizeReduced = true;
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1.transform.position += new Vector3(0, 5, 0);
                    greenplayer1sizeReduced = true;
                }
            }
            if (Steps == (blueplayer2Steps - 13) && !blueplayer2safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue2").transform.position = blueMovementBlock[58].transform.position;
                }
                if (Safe)
                {
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2sizeReduced = true;
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1.transform.position += new Vector3(0, 5, 0);
                    greenplayer1sizeReduced = true;
                }
            }
            if (Steps == (blueplayer3Steps - 13) && !blueplayer3safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue3").transform.position = blueMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3sizeReduced = true;
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1.transform.position += new Vector3(0, 5, 0);
                    greenplayer1sizeReduced = true;
                }
            }
            if (Steps == (blueplayer4Steps - 13) && !blueplayer4safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue4").transform.position = blueMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4sizeReduced = true;
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1.transform.position += new Vector3(0, 5, 0);
                    greenplayer1sizeReduced = true;
                }
            }
        }
        if (Steps >=40)
        {
            if (Steps == (blueplayer1Steps +39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue1").transform.position = blueMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1sizeReduced = true;
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1.transform.position += new Vector3(0, 5, 0);
                    greenplayer1sizeReduced = true;
                }
            }
            if (Steps == (blueplayer2Steps +39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue2").transform.position = blueMovementBlock[58].transform.position;
                }
                if (Safe)
                {
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2sizeReduced = true;
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1.transform.position += new Vector3(0, 5, 0);
                    greenplayer1sizeReduced = true;
                }
            }
            if (Steps == (blueplayer3Steps +39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue3").transform.position = blueMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3sizeReduced = true;
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1.transform.position += new Vector3(0, 5, 0);
                    greenplayer1sizeReduced = true;
                }
            }
            if (Steps == (blueplayer4Steps +39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue4").transform.position = blueMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4sizeReduced = true;
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1.transform.position += new Vector3(0, 5, 0);
                    greenplayer1sizeReduced = true;
                }
            }
        }
        if ((58 - greenplayer1Steps) < selectDiceNumAnimation)
        {
            greenplayer1Button.interactable = false;
        }
        if ((58 - greenplayer1Steps) >= selectDiceNumAnimation&&greenplayer1Steps!=0)
        {
            greenplayer1Button.interactable = true;
        }
        if (greenplayer1Steps == 0)
        {
            greenplayer1Caze.SetActive(true);
            greenplayer1Button.interactable = false;
        }
        if (greenplayer2Steps == 0)
        {
            greenplayer2Caze.SetActive(true);
            greenplayer2Button.interactable = false;
        }
        if (greenplayer3Steps == 0)
        {
            greenplayer3Caze.SetActive(true);
            greenplayer3Button.interactable = false;
        }
        if (greenplayer4Steps == 0)
        {
            greenplayer4Caze.SetActive(true);
            greenplayer4Button.interactable = false;
        }
        IntializePlayerTurn();
    }
    public void greenPlayer2movement()
    {
        Soundmanager.playermoveSoundSource.Play();
        Safe = false;
        if (greenplayer2sizeReduced)
        {
            greenplayer2.transform.localScale = new Vector3(1, 1, 1);
            greenplayer2.transform.position -= new Vector3(0, 5, 0);
            greenplayer2sizeReduced = false;

        }
        greenplayer2Steps = greenPlayermovement("Playergreen2", greenplayer2Steps);
        if (greenplayer2Steps > 51)
        {
            greenplayer2safeWin = true;
        }
        if (greenplayer2Steps == 1 || greenplayer2Steps == 9 || greenplayer2Steps == 14 || greenplayer2Steps == 22 || greenplayer2Steps == 27 || greenplayer2Steps == 35 || greenplayer2Steps == 40 || greenplayer2Steps == 48)
        {
            Safe = true;
        }
        int Steps = greenplayer2Steps;
        if ((Steps == (redplayer1Steps + 26) || Steps == (redplayer1Steps - 26)) && !redplayer1safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "GREEN";
                redplayer1Steps = 0;
                GameObject.FindGameObjectWithTag("Playerred1").transform.position = redMovementBlock[57].transform.position;
            }
            if (Safe)
            {
                redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer1sizeReduced = true;
                greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer2.transform.position += new Vector3(0, 5, 0);
                greenplayer2sizeReduced = true;
            }
        }
        if( (Steps == (redplayer2Steps + 26) || Steps == (redplayer2Steps - 26)) && !redplayer2safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "GREEN";
                redplayer2Steps = 0;
                GameObject.FindGameObjectWithTag("Playerred2").transform.position = redMovementBlock[58].transform.position;
            }
            if (Safe)
            {
                redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer2sizeReduced = true;
                greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer2.transform.position += new Vector3(0, 5, 0);
                greenplayer2sizeReduced = true;
            }
        }
        if ((Steps == (redplayer3Steps + 26) || Steps == (redplayer3Steps - 26))&& !redplayer3safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "GREEN";
                redplayer3Steps = 0;
                GameObject.FindGameObjectWithTag("Playerred3").transform.position = redMovementBlock[59].transform.position;
            }
            if (Safe)
            {
                redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer3sizeReduced = true;
                greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer2.transform.position += new Vector3(0, 5, 0);
                greenplayer2sizeReduced = true;
            }
        }
        if ((Steps == (redplayer4Steps + 26) || Steps == (redplayer4Steps - 26)) && !redplayer4safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "GREEN";
                redplayer4Steps = 0;
                GameObject.FindGameObjectWithTag("Playerred4").transform.position = redMovementBlock[60].transform.position;
            }
            if (Safe)
            {
                redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer4sizeReduced = true;
                greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer2.transform.position += new Vector3(0, 5, 0);
                greenplayer2sizeReduced = true;
            }
        }
        if (yellowplayer1Steps < 40)
        {
            if (Steps == (yellowplayer1Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    yellowplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow1").transform.position = yellowMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1sizeReduced = true;
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2.transform.position += new Vector3(0, 5, 0);
                    greenplayer2sizeReduced = true;
                }
            }
        }
        if (yellowplayer1Steps >= 40)
        {
            if (Steps == (yellowplayer1Steps -39) && !yellowplayer1safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    yellowplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow1").transform.position = yellowMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1sizeReduced = true;
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2.transform.position += new Vector3(0, 5, 0);
                    greenplayer2sizeReduced = true;
                }
            }
        }
        if (yellowplayer2Steps < 40)
        {

            if (Steps == (yellowplayer2Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    yellowplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow2").transform.position = yellowMovementBlock[58].transform.position;
                    playerTurn = "GREEN";
                }
                if (Safe)
                {
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1sizeReduced = true;
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2.transform.position += new Vector3(0, 5, 0);
                    greenplayer2sizeReduced = true;
                }
            }
        }
        if (yellowplayer2Steps >= 40)
        {

            if (Steps == (yellowplayer2Steps -39) && !yellowplayer2safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    yellowplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow2").transform.position = yellowMovementBlock[58].transform.position;
                    playerTurn = "GREEN";
                }
                if (Safe)
                {
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1sizeReduced = true;
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2.transform.position += new Vector3(0, 5, 0);
                    greenplayer2sizeReduced = true;
                }
            }
        }
        if (yellowplayer3Steps < 40)
        {
            if (Steps == (yellowplayer3Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    yellowplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow3").transform.position = yellowMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1sizeReduced = true;
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2.transform.position += new Vector3(0, 5, 0);
                    greenplayer2sizeReduced = true;
                }
            }
        }
        if (yellowplayer3Steps >= 40)
        {
            if (Steps == (yellowplayer3Steps -39) && !yellowplayer3safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    yellowplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow3").transform.position = yellowMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1sizeReduced = true;
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2.transform.position += new Vector3(0, 5, 0);
                    greenplayer2sizeReduced = true;
                }
            }
        }
        if (yellowplayer4Steps < 40)
        {
            if (Steps == (yellowplayer4Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    yellowplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow4").transform.position = yellowMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1sizeReduced = true;
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2.transform.position += new Vector3(0, 5, 0);
                    greenplayer2sizeReduced = true;
                }
            }
        }
        if (yellowplayer4Steps >= 40)
        {
            if (Steps == (yellowplayer4Steps -39) && !yellowplayer4safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    yellowplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow4").transform.position = yellowMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1sizeReduced = true;
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2.transform.position += new Vector3(0, 5, 0);
                    greenplayer2sizeReduced = true;
                }
            }
        }
        if (Steps < 40)
        {
            if (Steps == (blueplayer1Steps - 13) && !blueplayer1safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue1").transform.position = blueMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1sizeReduced = true;
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2.transform.position += new Vector3(0, 5, 0);
                    greenplayer2sizeReduced = true;
                }
            }
            if (Steps == (blueplayer2Steps - 13) && !blueplayer2safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue2").transform.position = blueMovementBlock[58].transform.position;
                }
                if (Safe)
                {
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2sizeReduced = true;
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2.transform.position += new Vector3(0, 5, 0);
                    greenplayer2sizeReduced = true;
                }
            }
            if (Steps == (blueplayer3Steps - 13) && !blueplayer3safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue3").transform.position = blueMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3sizeReduced = true;
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2.transform.position += new Vector3(0, 5, 0);
                    greenplayer2sizeReduced = true;
                }
            }
            if (Steps == (blueplayer4Steps - 13) && !blueplayer4safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue4").transform.position = blueMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4sizeReduced = true;
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2.transform.position += new Vector3(0, 5, 0);
                    greenplayer2sizeReduced = true;
                }
            }
        }
        if (Steps >= 40)
        {
            if (Steps == (blueplayer1Steps +39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue1").transform.position = blueMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1sizeReduced = true;
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2.transform.position += new Vector3(0, 5, 0);
                    greenplayer2sizeReduced = true;
                }
            }
            if (Steps == (blueplayer2Steps +39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue2").transform.position = blueMovementBlock[58].transform.position;
                }
                if (Safe)
                {
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2sizeReduced = true;
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2.transform.position += new Vector3(0, 5, 0);
                    greenplayer2sizeReduced = true;
                }
            }
            if (Steps == (blueplayer3Steps +39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue3").transform.position = blueMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3sizeReduced = true;
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2.transform.position += new Vector3(0, 5, 0);
                    greenplayer2sizeReduced = true;
                }
            }
            if (Steps == (blueplayer4Steps +39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue4").transform.position = blueMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4sizeReduced = true;
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2.transform.position += new Vector3(0, 5, 0);
                    greenplayer2sizeReduced = true;
                }
            }
        }
        if ((58 - greenplayer1Steps) < selectDiceNumAnimation)
        {
            greenplayer1Button.interactable = false;
        }
        if ((58 - greenplayer1Steps) >= selectDiceNumAnimation && greenplayer1Steps != 0)
        {
            greenplayer1Button.interactable = true;
        }
        if (greenplayer1Steps == 0)
        {
            greenplayer1Caze.SetActive(true);
            greenplayer1Button.interactable = false;
        }
        if (greenplayer2Steps == 0)
        {
            greenplayer2Caze.SetActive(true);
            greenplayer2Button.interactable = false;
        }
        if (greenplayer3Steps == 0)
        {
            greenplayer3Caze.SetActive(true);
            greenplayer3Button.interactable = false;
        }
        if (greenplayer4Steps == 0)
        {
            greenplayer4Caze.SetActive(true);
            greenplayer4Button.interactable = false;
        }
        if ((greenMovementBlock.Count - greenplayer2Steps) < selectDiceNumAnimation)
        {
            greenplayer2Button.interactable = false;
        }
        if ((greenMovementBlock.Count - greenplayer2Steps) >= selectDiceNumAnimation && greenplayer2Steps != 0)
        {
            greenplayer2Button.interactable = true;
        }
        if (greenplayer1Steps == 0)
        {
            greenplayer1Caze.SetActive(true);
            greenplayer1Button.interactable = false;
        }
        if (greenplayer2Steps == 0)
        {
            greenplayer2Caze.SetActive(true);
            greenplayer2Button.interactable = false;
        }
        if (greenplayer3Steps == 0)
        {
            greenplayer3Caze.SetActive(true);
            greenplayer3Button.interactable = false;
        }
        if (greenplayer4Steps == 0)
        {
            greenplayer4Caze.SetActive(true);
            greenplayer4Button.interactable = false;
        }
        IntializePlayerTurn();

    }
    public void greenPlayer3movement()
    {
        Soundmanager.playermoveSoundSource.Play();
        Safe = false;
        if (greenplayer3sizeReduced)
        {
            greenplayer3.transform.localScale = new Vector3(1, 1, 1);
            greenplayer3.transform.position -= new Vector3(0, 5, 0);
            greenplayer3sizeReduced = false;

        }
        greenplayer3Steps = greenPlayermovement("Playergreen3", greenplayer3Steps);
        if (greenplayer3Steps > 51)
        {
            greenplayer3safeWin = true;
        }
        if (greenplayer3Steps == 1 || greenplayer3Steps == 9 || greenplayer3Steps == 14 || greenplayer3Steps == 22 || greenplayer3Steps == 27 || greenplayer3Steps == 35 || greenplayer3Steps == 40 || greenplayer3Steps == 48)
        {
            Safe = true;
        }
        int Steps = greenplayer3Steps;
        if ((Steps == (redplayer1Steps + 26) || Steps == (redplayer1Steps - 26)) && !redplayer1safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "GREEN";
                redplayer1Steps = 0;
                GameObject.FindGameObjectWithTag("Playerred1").transform.position = redMovementBlock[57].transform.position;
            }
            if (Safe)
            {
                redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer1sizeReduced = true;
                greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer3.transform.position += new Vector3(0, 5, 0);
                greenplayer3sizeReduced = true;
            }
        }
        if ((Steps == (redplayer2Steps + 26) || Steps == (redplayer2Steps - 26)) && !redplayer2safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "GREEN";
                redplayer2Steps = 0;
                GameObject.FindGameObjectWithTag("Playerred2").transform.position = redMovementBlock[58].transform.position;
            }
            if (Safe)
            {
                redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer2sizeReduced = true;
                greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer3.transform.position += new Vector3(0, 5, 0);
                greenplayer3sizeReduced = true;
            }
        }
        if ((Steps == (redplayer3Steps + 26) || Steps == (redplayer3Steps - 26))&& !redplayer3safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "GREEN";
                redplayer3Steps = 0;
                GameObject.FindGameObjectWithTag("Playerred3").transform.position = redMovementBlock[59].transform.position;
            }
            if (Safe)
            {
                redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer3sizeReduced = true;
                greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer3.transform.position += new Vector3(0, 5, 0);
                greenplayer3sizeReduced = true;
            }

        }
        if ((Steps == (redplayer4Steps + 26) || Steps == (redplayer4Steps - 26)) && !redplayer4safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "GREEN";
                redplayer4Steps = 0;
                GameObject.FindGameObjectWithTag("Playerred4").transform.position = redMovementBlock[60].transform.position;
            }
            if (Safe)
            {
                redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer4sizeReduced = true;
                greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer3.transform.position += new Vector3(0, 5, 0);
                greenplayer3sizeReduced = true;
            }
        }
        if (yellowplayer1Steps < 40)
        {
            if (Steps == (yellowplayer1Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    yellowplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow1").transform.position = yellowMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1sizeReduced = true;
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3.transform.position += new Vector3(0, 5, 0);
                    greenplayer3sizeReduced = true;
                }
            }
        }
        if (yellowplayer1Steps >= 40)
        {
            if (Steps == (yellowplayer1Steps -39)&&!yellowplayer1safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    yellowplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow1").transform.position = yellowMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1sizeReduced = true;
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3.transform.position += new Vector3(0, 5, 0);
                    greenplayer3sizeReduced = true;
                }
            }
        }
        if (yellowplayer2Steps < 40)
        {
            if (Steps == (yellowplayer2Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    yellowplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow2").transform.position = yellowMovementBlock[58].transform.position;
                    playerTurn = "GREEN";
                }
                if (Safe)
                {
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2sizeReduced = true;
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3.transform.position += new Vector3(0, 5, 0);
                    greenplayer3sizeReduced = true;
                }
            }
        }
        if (yellowplayer2Steps >= 40)
        {
            if (Steps == (yellowplayer2Steps -39)&&!yellowplayer2safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    yellowplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow2").transform.position = yellowMovementBlock[58].transform.position;
                    playerTurn = "GREEN";
                }
                if (Safe)
                {
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2sizeReduced = true;
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3.transform.position += new Vector3(0, 5, 0);
                    greenplayer3sizeReduced = true;
                }
            }
        }
        if (yellowplayer3Steps < 40)
        {
            if (Steps == (yellowplayer3Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    yellowplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow3").transform.position = yellowMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3sizeReduced = true;
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3.transform.position += new Vector3(0, 5, 0);
                    greenplayer3sizeReduced = true;
                }
            }
        }
        if (yellowplayer3Steps >= 40)
        {
            if (Steps == (yellowplayer3Steps -39) && !yellowplayer3safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    yellowplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow3").transform.position = yellowMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3sizeReduced = true;
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3.transform.position += new Vector3(0, 5, 0);
                    greenplayer3sizeReduced = true;
                }
            }
        }
        if (yellowplayer4Steps < 40)
        {
            if (Steps == (yellowplayer4Steps + 13) )
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    yellowplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow4").transform.position = yellowMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4sizeReduced = true;
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3.transform.position += new Vector3(0, 5, 0);
                    greenplayer3sizeReduced = true;
                }
            }
        }
        if (yellowplayer4Steps >= 40)
        {
            if (Steps == (yellowplayer4Steps -39) && !yellowplayer4safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    yellowplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow4").transform.position = yellowMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4sizeReduced = true;
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3.transform.position += new Vector3(0, 5, 0);
                    greenplayer3sizeReduced = true;
                }
            }
        }
        if (Steps < 40)
        {
            if (Steps == (blueplayer1Steps - 13) && !blueplayer1safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue1").transform.position = blueMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1sizeReduced = true;
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3.transform.position += new Vector3(0, 5, 0);
                    greenplayer3sizeReduced = true;
                }
            }
            if (Steps == (blueplayer2Steps - 13) && !blueplayer2safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue2").transform.position = blueMovementBlock[58].transform.position;
                }
                if (Safe)
                {
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2sizeReduced = true;
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3.transform.position += new Vector3(0, 5, 0);
                    greenplayer3sizeReduced = true;
                }

            }
            if (Steps == (blueplayer3Steps - 13) && !blueplayer3safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue3").transform.position = blueMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3sizeReduced = true;
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3.transform.position += new Vector3(0, 5, 0);
                    greenplayer3sizeReduced = true;
                }
            }
            if (Steps == (blueplayer4Steps - 13) && !blueplayer4safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue4").transform.position = blueMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4sizeReduced = true;
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3.transform.position += new Vector3(0, 5, 0);
                    greenplayer3sizeReduced = true;
                }
            }
        }
        if (Steps >= 40)
        {
            if (Steps == (blueplayer1Steps +39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue1").transform.position = blueMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1sizeReduced = true;
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3.transform.position += new Vector3(0, 5, 0);
                    greenplayer3sizeReduced = true;
                }
            }
            if (Steps == (blueplayer2Steps +39) )
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue2").transform.position = blueMovementBlock[58].transform.position;
                }
                if (Safe)
                {
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2sizeReduced = true;
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3.transform.position += new Vector3(0, 5, 0);
                    greenplayer3sizeReduced = true;
                }

            }
            if (Steps == (blueplayer3Steps +39) )
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue3").transform.position = blueMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3sizeReduced = true;
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3.transform.position += new Vector3(0, 5, 0);
                    greenplayer3sizeReduced = true;
                }
            }
            if (Steps == (blueplayer4Steps +39) )
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue4").transform.position = blueMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4sizeReduced = true;
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3.transform.position += new Vector3(0, 5, 0);
                    greenplayer3sizeReduced = true;
                }
            }
        }
        if ((58 - greenplayer3Steps) < selectDiceNumAnimation)
        {
            greenplayer3Button.interactable = false;
        }
        if ((58- greenplayer3Steps) >= selectDiceNumAnimation && greenplayer3Steps != 0)
        {
            greenplayer3Button.interactable = true;
        }
        if (greenplayer1Steps == 0)
        {
            greenplayer1Caze.SetActive(true);
            greenplayer1Button.interactable = false;
        }
        if (greenplayer2Steps == 0)
        {
            greenplayer2Caze.SetActive(true);
            greenplayer2Button.interactable = false;
        }
        if (greenplayer3Steps == 0)
        {
            greenplayer3Caze.SetActive(true);
            greenplayer3Button.interactable = false;
        }
        if (greenplayer4Steps == 0)
        {
            greenplayer4Caze.SetActive(true);
            greenplayer4Button.interactable = false;
        }
        IntializePlayerTurn();
    }
    public void greenPlayer4movement()
    {
        Soundmanager.playermoveSoundSource.Play();
        Safe = false;
        if (greenplayer4sizeReduced)
        {
            greenplayer4.transform.localScale = new Vector3(1, 1, 1);
            greenplayer4.transform.position -= new Vector3(0, 5, 0);
            greenplayer4sizeReduced = false;

        }
        greenplayer4Steps = greenPlayermovement("Playergreen4", greenplayer4Steps);
        if (greenplayer4Steps > 51)
        {
            greenplayer4safeWin = true;
        }
        if (greenplayer4Steps == 1 || greenplayer4Steps == 9 || greenplayer4Steps == 14 || greenplayer4Steps == 22 ||greenplayer4Steps == 27 || greenplayer4Steps == 35 || greenplayer4Steps == 40 || greenplayer4Steps == 48)
        {
            Safe = true;
        }
        int Steps = greenplayer4Steps;
        if ((Steps == (redplayer1Steps + 26) || Steps == (redplayer1Steps - 26))&& !redplayer1safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "GREEN";
                redplayer1Steps = 0;
                GameObject.FindGameObjectWithTag("Playerred1").transform.position = redMovementBlock[57].transform.position;
            }
            if (Safe)
            {
                redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer1sizeReduced = true;
                greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer4.transform.position += new Vector3(0, 5, 0);
                greenplayer4sizeReduced = true;
            }
        }
        if ((Steps == (redplayer2Steps + 26) || Steps == (redplayer2Steps - 26)) && !redplayer2safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "GREEN";
                redplayer2Steps = 0;
                GameObject.FindGameObjectWithTag("Playerred2").transform.position = redMovementBlock[58].transform.position;
            }
            if (Safe)
            {
                redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer2sizeReduced = true;
                greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer4.transform.position += new Vector3(0, 5, 0);
                greenplayer4sizeReduced = true;
            }
        }
        if ((Steps == (redplayer3Steps + 26) || Steps == (redplayer3Steps - 26)) && !redplayer3safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "GREEN";
                redplayer3Steps = 0;
                GameObject.FindGameObjectWithTag("Playerred3").transform.position = redMovementBlock[59].transform.position;
            }
            if (Safe)
            {
                redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer3sizeReduced = true;
                greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer4.transform.position += new Vector3(0, 5, 0);
                greenplayer4sizeReduced = true;
            }
        }
        if ((Steps == (redplayer4Steps + 26) || Steps == (redplayer4Steps - 26)) && !redplayer4safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "GREEN";
                redplayer4Steps = 0;
                GameObject.FindGameObjectWithTag("Playerred4").transform.position = redMovementBlock[60].transform.position;
            }
            if (Safe)
            {
                redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                redplayer4sizeReduced = true;
                greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                greenplayer4.transform.position += new Vector3(0, 5, 0);
                greenplayer4sizeReduced = true;
            }
        }
        if (yellowplayer1Steps < 40)
        {
            if (Steps == (yellowplayer1Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    yellowplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow1").transform.position = yellowMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1sizeReduced = true;
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4.transform.position += new Vector3(0, 5, 0);
                    greenplayer4sizeReduced = true;
                }
            }
        }
        if (yellowplayer1Steps >= 40)
        {
            if (Steps == (yellowplayer1Steps -39) && !yellowplayer1safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    yellowplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow1").transform.position = yellowMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1sizeReduced = true;
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4.transform.position += new Vector3(0, 5, 0);
                    greenplayer4sizeReduced = true;
                }
            }
        }
        if (yellowplayer2Steps < 40)
        {

            if (Steps == (yellowplayer2Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    yellowplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow2").transform.position = yellowMovementBlock[58].transform.position;
                    playerTurn = "GREEN";
                }
                if (Safe)
                {
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2sizeReduced = true;
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4.transform.position += new Vector3(0, 5, 0);
                    greenplayer4sizeReduced = true;
                }

            }
        }
        if (yellowplayer2Steps >= 40)
        {

            if (Steps == (yellowplayer2Steps -39) && !yellowplayer2safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    yellowplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow2").transform.position = yellowMovementBlock[58].transform.position;
                    playerTurn = "GREEN";
                }
                if (Safe)
                {
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2sizeReduced = true;
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4.transform.position += new Vector3(0, 5, 0);
                    greenplayer4sizeReduced = true;
                }

            }
        }
        if (yellowplayer3Steps < 40)
        {
            if (Steps == (yellowplayer3Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    yellowplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow3").transform.position = yellowMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3sizeReduced = true;
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4.transform.position += new Vector3(0, 5, 0);
                    greenplayer4sizeReduced = true;
                }
            }
        }
        if (yellowplayer3Steps >= 40)
        {
            if (Steps == (yellowplayer3Steps -39) && !yellowplayer3safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    yellowplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow3").transform.position = yellowMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3sizeReduced = true;
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4.transform.position += new Vector3(0, 5, 0);
                    greenplayer4sizeReduced = true;
                }
            }
        }
        if (yellowplayer4Steps < 40)
        {
            if (Steps == (yellowplayer4Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    yellowplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow4").transform.position = yellowMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4sizeReduced = true;
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4.transform.position += new Vector3(0, 5, 0);
                    greenplayer4sizeReduced = true;
                }
            }
        }
        if (yellowplayer4Steps >= 40)
        {
            if (Steps == (yellowplayer4Steps -39) && !yellowplayer4safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    yellowplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playeryellow4").transform.position = yellowMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4sizeReduced = true;
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4.transform.position += new Vector3(0, 5, 0);
                    greenplayer4sizeReduced = true;
                }
            }
        }
        if (Steps < 40)
        {
            if (Steps == (blueplayer1Steps - 13) && !blueplayer1safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue1").transform.position = blueMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1sizeReduced = true;
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4.transform.position += new Vector3(0, 5, 0);
                    greenplayer4sizeReduced = true;
                }
            }
            if (Steps == (blueplayer2Steps - 13) && !blueplayer2safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue2").transform.position = blueMovementBlock[58].transform.position;
                }
                if (Safe)
                {
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2sizeReduced = true;
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4.transform.position += new Vector3(0, 5, 0);
                    greenplayer4sizeReduced = true;
                }
            }
            if (Steps == (blueplayer3Steps - 13) && !blueplayer3safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue3").transform.position = blueMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3sizeReduced = true;
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4.transform.position += new Vector3(0, 5, 0);
                    greenplayer4sizeReduced = true;
                }
            }
            if (Steps == (blueplayer4Steps - 13) && !blueplayer4safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue4").transform.position = blueMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4sizeReduced = true;
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4.transform.position += new Vector3(0, 5, 0);
                    greenplayer4sizeReduced = true;
                }
            }
        }
        if (Steps >= 40)
        {
            if (Steps == (blueplayer1Steps +39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue1").transform.position = blueMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1sizeReduced = true;
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4.transform.position += new Vector3(0, 5, 0);
                    greenplayer4sizeReduced = true;
                }
            }
            if (Steps == (blueplayer2Steps +39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue2").transform.position = blueMovementBlock[58].transform.position;
                }
                if (Safe)
                {
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2sizeReduced = true;
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4.transform.position += new Vector3(0, 5, 0);
                    greenplayer4sizeReduced = true;
                }
            }
            if (Steps == (blueplayer3Steps +39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue3").transform.position = blueMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3sizeReduced = true;
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4.transform.position += new Vector3(0, 5, 0);
                    greenplayer4sizeReduced = true;
                }
            }
            if (Steps == (blueplayer4Steps +39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "GREEN";
                    blueplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerblue4").transform.position = blueMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4sizeReduced = true;
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4.transform.position += new Vector3(0, 5, 0);
                    greenplayer4sizeReduced = true;
                }
            }
        }
        if ((58 - greenplayer4Steps) < selectDiceNumAnimation)
        {
            greenplayer4Button.interactable = false;
        }
        if ((58 - greenplayer4Steps) >= selectDiceNumAnimation && greenplayer4Steps != 0)
        {
            greenplayer4Button.interactable = true;
        }
        if (greenplayer1Steps == 0)
        {
            greenplayer1Caze.SetActive(true);
            greenplayer1Button.interactable = false;
        }
        if (greenplayer2Steps == 0)
        {
            greenplayer2Caze.SetActive(true);
            greenplayer2Button.interactable = false;
        }
        if (greenplayer3Steps == 0)
        {
            greenplayer3Caze.SetActive(true);
            greenplayer3Button.interactable = false;
        }
        if (greenplayer4Steps == 0)
        {
            greenplayer4Caze.SetActive(true);
            greenplayer4Button.interactable = false;
        }

        IntializePlayerTurn();
    }
    public void yellowPlayer1movement()
    {
        Soundmanager.playermoveSoundSource.Play();
        Safe = false;
        if (yellowplayer1sizeReduced)
        {
            yellowplayer1.transform.localScale = new Vector3(1, 1, 1);
            yellowplayer1.transform.position -= new Vector3(0, 5, 0);
            yellowplayer1sizeReduced = false;

        }
        yellowplayer1Steps = yellowPlayermovement("Playeryellow1", yellowplayer1Steps);
        if (yellowplayer1Steps > 51)
        {
            yellowplayer1safeWin = true;
        }
        if (yellowplayer1Steps == 1 || yellowplayer1Steps == 9 || yellowplayer1Steps == 14 || yellowplayer1Steps == 22 || yellowplayer1Steps == 27 || yellowplayer1Steps == 35 || yellowplayer1Steps == 40 || yellowplayer1Steps == 48)
        {
            Safe = true;
        }
        int Steps = yellowplayer1Steps;
        if (redplayer1Steps < 40)
        {
            if (Steps == (redplayer1Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "YELLOW";
                    redplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred1").transform.position = redMovementBlock[57].transform.position;

                }
                if (Safe)
                {
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1sizeReduced = true;
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1.transform.position += new Vector3(0, 5, 0);
                    yellowplayer1sizeReduced = true;
                }
            }
        }
        if (redplayer1Steps >= 40)
        {
            if (Steps == (redplayer1Steps -39) && !redplayer1safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "YELLOW";
                    redplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred1").transform.position = redMovementBlock[57].transform.position;

                }
                if (Safe)
                {
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1sizeReduced = true;
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1.transform.position += new Vector3(0, 5, 0);
                    yellowplayer1sizeReduced = true;
                }
            }
        }
        if (redplayer2Steps < 40)
        {
            if (Steps == (redplayer2Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "YELLOW";
                    redplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred2").transform.position = redMovementBlock[58].transform.position;
                }
                if (Safe)
                {
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2sizeReduced = true;
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1.transform.position += new Vector3(0, 5, 0);
                    yellowplayer1sizeReduced = true;
                }
            }
        }
        if (redplayer2Steps > 40)
        {
            if (Steps == (redplayer2Steps - 39) && !redplayer2safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "YELLOW";
                    redplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred2").transform.position = redMovementBlock[58].transform.position;
                }
                if (Safe)
                {
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2sizeReduced = true;
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1.transform.position += new Vector3(0, 5, 0);
                    yellowplayer1sizeReduced = true;
                }
            }
        }
        if (redplayer3Steps < 40)
        {
            if (Steps == (redplayer3Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "YELLOW";
                    redplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred3").transform.position = redMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3sizeReduced = true;
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1.transform.position += new Vector3(0, 5, 0);
                    yellowplayer1sizeReduced = true;
                }
            }
        }
        if (redplayer3Steps >= 40)
        {
            if (Steps == (redplayer3Steps -39) && !redplayer3safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "YELLOW";
                    redplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred3").transform.position = redMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3sizeReduced = true;
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1.transform.position += new Vector3(0, 5, 0);
                    yellowplayer1sizeReduced = true;
                }
            }
        }
        if (redplayer4Steps < 40)
        {
            if (Steps == (redplayer4Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "YELLOW";
                    redplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred4").transform.position = redMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4sizeReduced = true;
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1.transform.position += new Vector3(0, 5, 0);
                    yellowplayer1sizeReduced = true;
                }
            }
        }
        if (redplayer4Steps >= 40)
        {
            if (Steps == (redplayer4Steps -39) && !redplayer4safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "YELLOW";
                    redplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred4").transform.position = redMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4sizeReduced = true;
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1.transform.position += new Vector3(0, 5, 0);
                    yellowplayer1sizeReduced = true;
                }
            }
        }
        if (Steps < 40)
        {
            if (Steps == (greenplayer1Steps - 13) && !blueplayer1safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "YELLOW";
                    greenplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen1").transform.position = greenMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1sizeReduced = true;
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1.transform.position += new Vector3(0, 5, 0);
                    yellowplayer1sizeReduced = true;
                }
            }
            if (Steps == (greenplayer2Steps - 13) && !blueplayer2safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "YELLOW";
                    greenplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen2").transform.position = greenMovementBlock[58].transform.position;
                }
                if (Safe)
                {
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2sizeReduced = true;
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1.transform.position += new Vector3(0, 5, 0);
                    yellowplayer1sizeReduced = true;
                }
            }
            if (Steps == (greenplayer3Steps - 13) && !blueplayer3safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "YELLOW";
                    greenplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen3").transform.position = greenMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3sizeReduced = true;
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1.transform.position += new Vector3(0, 5, 0);
                    yellowplayer1sizeReduced = true;
                }

            }
            if (Steps == (greenplayer4Steps - 13) && !greenplayer4safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "YELLOW";
                    greenplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen4").transform.position = greenMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4sizeReduced = true;
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1.transform.position += new Vector3(0, 5, 0);
                    yellowplayer1sizeReduced = true;
                }
            }
        }
        if (Steps >=40)
        {
            if (Steps == (greenplayer1Steps +39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "YELLOW";
                    greenplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen1").transform.position = greenMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1sizeReduced = true;
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1.transform.position += new Vector3(0, 5, 0);
                    yellowplayer1sizeReduced = true;
                }
            }
            if (Steps == (greenplayer2Steps +39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "YELLOW";
                    greenplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen2").transform.position = greenMovementBlock[58].transform.position;
                }
                if (Safe)
                {
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2sizeReduced = true;
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1.transform.position += new Vector3(0, 5, 0);
                    yellowplayer1sizeReduced = true;
                }
            }
            if (Steps == (greenplayer3Steps +39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "YELLOW";
                    greenplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen3").transform.position = greenMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3sizeReduced = true;
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1.transform.position += new Vector3(0, 5, 0);
                    yellowplayer1sizeReduced = true;
                }

            }
            if (Steps == (greenplayer4Steps +39))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "YELLOW";
                    greenplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen4").transform.position = greenMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4sizeReduced = true;
                    yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer1.transform.position += new Vector3(0, 5, 0);
                    yellowplayer1sizeReduced = true;
                }
            }
        }
        if ((Steps == (blueplayer1Steps - 26) || Steps == (blueplayer1Steps + 26)) && !blueplayer1safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "YELLOW";
                blueplayer1Steps = 0;
                GameObject.FindGameObjectWithTag("Playerblue1").transform.position = blueMovementBlock[57].transform.position;
            }
            if (Safe)
            {
                blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                blueplayer1sizeReduced = true;
                yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer1.transform.position += new Vector3(0, 5, 0);
                yellowplayer1sizeReduced = true;
            }
        }
        if ((Steps == (blueplayer2Steps - 26) || Steps == (blueplayer2Steps + 26)) && !blueplayer2safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "YELLOW";
                blueplayer2Steps = 0;
                GameObject.FindGameObjectWithTag("Playerblue2").transform.position = blueMovementBlock[58].transform.position;
            }
            if (Safe)
            {
                blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                blueplayer2sizeReduced = true;
                yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer1.transform.position += new Vector3(0, 5, 0);
                yellowplayer1sizeReduced = true;
            }

        }
        if ((Steps == (blueplayer3Steps - 26) || Steps == (blueplayer3Steps + 26))&& !blueplayer3safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "YELLOW";
                blueplayer3Steps = 0;
                GameObject.FindGameObjectWithTag("Playerblue3").transform.position = blueMovementBlock[59].transform.position;
            }
            if (Safe)
            {
                blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                blueplayer3sizeReduced = true;
                yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer1.transform.position += new Vector3(0, 5, 0);
                yellowplayer1sizeReduced = true;
            }
        }
        if ((Steps == (blueplayer4Steps - 26) || Steps == (blueplayer4Steps + 26)) && !blueplayer4safeWin)
        {
            if (!Safe)
            {
                Soundmanager.dismissalSoundSource.Play();
                playerTurn = "YELLOW";
                blueplayer4Steps = 0;
                GameObject.FindGameObjectWithTag("Playerblue4").transform.position = blueMovementBlock[60].transform.position;
            }
            if (Safe)
            {
                blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                blueplayer4sizeReduced = true;
                yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer1.transform.position += new Vector3(0, 5, 0);
                yellowplayer1sizeReduced = true;
            }
        }
        if ((58 - yellowplayer1Steps) < selectDiceNumAnimation)
        {
            yellowplayer1Button.interactable = false;
        }
        if ((58 - yellowplayer1Steps) >= selectDiceNumAnimation && yellowplayer1Steps != 0)
        {
            yellowplayer1Button.interactable = true;
        }

        if (yellowplayer1Steps == 0)
        {
            yellowplayer1Caze.SetActive(true);
            yellowplayer1Button.interactable = false;
        }
        if (yellowplayer2Steps == 0)
        {
            yellowplayer2Caze.SetActive(true);
            yellowplayer2Button.interactable = false;
        }
        if (yellowplayer3Steps == 0)
        {
            yellowplayer3Caze.SetActive(true);
            yellowplayer3Button.interactable = false;
        }
        if (yellowplayer4Steps == 0)
        {
            yellowplayer4Caze.SetActive(true);
            yellowplayer4Button.interactable = false;
        }

        IntializePlayerTurn();

    }
    public void yellowPlayer2movement()
    {
        Soundmanager.playermoveSoundSource.Play();
        Safe = false;
        if (yellowplayer2sizeReduced)
        {
            yellowplayer2.transform.localScale = new Vector3(1, 1, 1);
            yellowplayer2.transform.position -= new Vector3(0, 5, 0);
            yellowplayer2sizeReduced = false;

        }
        yellowplayer2Steps = yellowPlayermovement("Playeryellow2", yellowplayer2Steps);
        if (yellowplayer2Steps > 51)
        {
            yellowplayer2safeWin = true;
        }
        if (yellowplayer2Steps == 1 || yellowplayer2Steps == 9 || yellowplayer2Steps == 14 || yellowplayer2Steps == 22 || yellowplayer2Steps == 27 || yellowplayer2Steps == 35 || yellowplayer2Steps == 40 || yellowplayer2Steps == 48)
        {
            Safe = true;
        }
        int Steps = yellowplayer2Steps;
        if (redplayer1Steps < 40)
        {
            if (Steps == (redplayer1Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "YELLOW";
                    redplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred1").transform.position = redMovementBlock[57].transform.position;

                }
                if (Safe)
                {
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1sizeReduced = true;
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2.transform.position += new Vector3(0, 5, 0);
                    yellowplayer2sizeReduced = true;
                }
            }
        }
        if (redplayer1Steps >= 40)
        {
            if (Steps == (redplayer1Steps -39) && !redplayer1safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "YELLOW";
                    redplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred1").transform.position = redMovementBlock[57].transform.position;

                }
                if (Safe)
                {
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1sizeReduced = true;
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2.transform.position += new Vector3(0, 5, 0);
                    yellowplayer2sizeReduced = true;
                }
            }
        }
        if (redplayer2Steps < 40)
        {
            if (Steps == (redplayer2Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "YELLOW";
                    redplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred2").transform.position = redMovementBlock[58].transform.position;
                }
                if (Safe)
                {
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2sizeReduced = true;
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2.transform.position += new Vector3(0, 5, 0);
                    yellowplayer2sizeReduced = true;
                }
            }
        }
        if (redplayer2Steps >= 40)
        {
            if (Steps == (redplayer2Steps -39) && !redplayer2safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "YELLOW";
                    redplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred2").transform.position = redMovementBlock[58].transform.position;
                }
                if (Safe)
                {
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2sizeReduced = true;
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2.transform.position += new Vector3(0, 5, 0);
                    yellowplayer2sizeReduced = true;
                }
            }
        }

        if (redplayer3Steps < 40)
        {
            if (Steps == (redplayer3Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "YELLOW";
                    redplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred3").transform.position = redMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3sizeReduced = true;
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2.transform.position += new Vector3(0, 5, 0);
                    yellowplayer2sizeReduced = true;
                }
            }
        }
        if (redplayer3Steps >= 40)
        {
            if (Steps == (redplayer3Steps -39) && !redplayer3safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "YELLOW";
                    redplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred3").transform.position = redMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3sizeReduced = true;
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2.transform.position += new Vector3(0, 5, 0);
                    yellowplayer2sizeReduced = true;
                }
            }
        }
        if (redplayer4Steps < 40)
        {
            if (Steps == (redplayer4Steps + 13))
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "YELLOW";
                    redplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred4").transform.position = redMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4sizeReduced = true;
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2.transform.position += new Vector3(0, 5, 0);
                    yellowplayer2sizeReduced = true;
                }
            }
        }
        if (redplayer4Steps >= 40)
        {
            if (Steps == (redplayer4Steps -39) && !redplayer4safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "YELLOW";
                    redplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred4").transform.position = redMovementBlock[60].transform.position;
                }
                if (Safe)
                {
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4sizeReduced = true;
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2.transform.position += new Vector3(0, 5, 0);
                    yellowplayer2sizeReduced = true;
                }
            }
        }
        if (Steps < 40)
        {
            if (Steps == (greenplayer1Steps - 13) && !greenplayer1safeWin)
            {
                if (!Safe)
                {
                    Soundmanager.dismissalSoundSource.Play();
                    playerTurn = "YELLOW";
                    greenplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen1").transform.position = greenMovementBlock[57].transform.position;
                }
                if (Safe)
                {
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1sizeReduced = true;
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2.transform.position += new Vector3(0, 5, 0);
                    yellowplayer2sizeReduced = true;
                }
            }
            if (Steps == (greenplayer2Steps - 13) && !greenplayer2safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    greenplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen2").transform.position = greenMovementBlock[58].transform.position;
                }
                if (Safe)
                {
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2sizeReduced = true;
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2.transform.position += new Vector3(0, 5, 0);
                    yellowplayer2sizeReduced = true;
                }
            }
            if (Steps == (greenplayer3Steps - 13) && !greenplayer3safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    greenplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen3").transform.position = greenMovementBlock[59].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3sizeReduced = true;
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2.transform.position += new Vector3(0, 5, 0);
                    yellowplayer2sizeReduced = true;
                }
            }
            if (Steps == (greenplayer4Steps - 13) && !greenplayer4safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    greenplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen4").transform.position = greenMovementBlock[60].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4sizeReduced = true;
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2.transform.position += new Vector3(0, 5, 0);
                    yellowplayer2sizeReduced = true;
                }
            }
        }
        if (Steps >= 40)
        {
            if (Steps == (greenplayer1Steps +39))
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    greenplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen1").transform.position = greenMovementBlock[57].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1sizeReduced = true;
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2.transform.position += new Vector3(0, 5, 0);
                    yellowplayer2sizeReduced = true;
                }
            }
            if (Steps == (greenplayer2Steps +39))
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    greenplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen2").transform.position = greenMovementBlock[58].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2sizeReduced = true;
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2.transform.position += new Vector3(0, 5, 0);
                    yellowplayer2sizeReduced = true;
                }
            }
            if (Steps == (greenplayer3Steps +39))
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    greenplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen3").transform.position = greenMovementBlock[59].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3sizeReduced = true;
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2.transform.position += new Vector3(0, 5, 0);
                    yellowplayer2sizeReduced = true;
                }
            }
            if (Steps == (greenplayer4Steps +39))
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    greenplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen4").transform.position = greenMovementBlock[60].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4sizeReduced = true;
                    yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer2.transform.position += new Vector3(0, 5, 0);
                    yellowplayer2sizeReduced = true;
                }
            }
        }

        if ((Steps == (blueplayer1Steps - 26) || Steps == (blueplayer1Steps + 26))&& !blueplayer1safeWin)
        {
            if (!Safe)
            {
                playerTurn = "YELLOW";
                blueplayer1Steps = 0;
                GameObject.FindGameObjectWithTag("Playerblue1").transform.position = blueMovementBlock[57].transform.position;
                Soundmanager.dismissalSoundSource.Play();
            }
            if (Safe)
            {
                blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                blueplayer1sizeReduced = true;
                yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer2.transform.position += new Vector3(0, 5, 0);
                yellowplayer2sizeReduced = true;
            }
        }
        if ((Steps == (blueplayer2Steps - 26) || Steps == (blueplayer2Steps + 26)) && !blueplayer2safeWin)
        {
            if (!Safe)
            {
                playerTurn = "YELLOW";
                blueplayer2Steps = 0;
                GameObject.FindGameObjectWithTag("Playerblue2").transform.position = blueMovementBlock[58].transform.position;
                Soundmanager.dismissalSoundSource.Play();
            }
            if (Safe)
            {
                blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                blueplayer2sizeReduced = true;
                yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer2.transform.position += new Vector3(0, 5, 0);
                yellowplayer2sizeReduced = true;
            }

        }
        if ((Steps == (blueplayer3Steps - 26) || Steps == (blueplayer3Steps + 26)) && !blueplayer3safeWin)
        {
            if (!Safe)
            {
                playerTurn = "YELLOW";
                blueplayer3Steps = 0;
                GameObject.FindGameObjectWithTag("Playerblue3").transform.position = blueMovementBlock[59].transform.position;
                Soundmanager.dismissalSoundSource.Play();
            }
            if (Safe)
            {
                blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                blueplayer3sizeReduced = true;
                yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer2.transform.position += new Vector3(0, 5, 0);
                yellowplayer2sizeReduced = true;
            }
        }
        if ((Steps == (blueplayer4Steps - 26) || Steps == (blueplayer4Steps + 26)) && !blueplayer4safeWin)
        {
            if (!Safe)
            {
                playerTurn = "YELLOW";
                blueplayer4Steps = 0;
                GameObject.FindGameObjectWithTag("Playerblue4").transform.position = blueMovementBlock[60].transform.position;
                Soundmanager.dismissalSoundSource.Play();
            }
            if (Safe)
            {
                blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                blueplayer4sizeReduced = true;
                yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer2.transform.position += new Vector3(0, 5, 0);
                yellowplayer2sizeReduced = true;
            }
        }
       
        if ((58 - yellowplayer2Steps) < selectDiceNumAnimation)
        {
            yellowplayer2Button.interactable = false;
        }
        if ((58 - yellowplayer2Steps) >= selectDiceNumAnimation && yellowplayer2Steps != 0)
        {
            yellowplayer2Button.interactable = true;
        }

        if (yellowplayer1Steps == 0)
        {
            yellowplayer1Caze.SetActive(true);
            yellowplayer1Button.interactable = false;
        }
        if (yellowplayer2Steps == 0)
        {
            yellowplayer2Caze.SetActive(true);
            yellowplayer2Button.interactable = false;
        }
        if (yellowplayer3Steps == 0)
        {
            yellowplayer3Caze.SetActive(true);
            yellowplayer3Button.interactable = false;
        }
        if (yellowplayer4Steps == 0)
        {
            yellowplayer4Caze.SetActive(true);
            yellowplayer4Button.interactable = false;
        }
        IntializePlayerTurn();
    }
    public void yellowPlayer3movement()
    {
        Soundmanager.playermoveSoundSource.Play();
        Safe = false;
        if (yellowplayer3sizeReduced)
        {
            yellowplayer3.transform.localScale = new Vector3(1, 1, 1);
            yellowplayer3.transform.position -= new Vector3(0, 5, 0);
            yellowplayer3sizeReduced = false;

        }
        yellowplayer3Steps = yellowPlayermovement("Playeryellow3", yellowplayer3Steps);
        if (yellowplayer3Steps > 51)
        {
            yellowplayer3safeWin = true;
        }
        if (yellowplayer3Steps == 1 || yellowplayer3Steps == 9 || yellowplayer3Steps == 14 || yellowplayer3Steps == 22 || yellowplayer3Steps == 27 || yellowplayer3Steps == 35 || yellowplayer3Steps == 40 || yellowplayer3Steps == 48)
        {
            Safe = true;
        }
        int Steps = yellowplayer3Steps;
        if (redplayer1Steps < 40)
        {
            if (Steps == (redplayer1Steps + 13))
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    redplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred1").transform.position = redMovementBlock[57].transform.position;
                    Soundmanager.dismissalSoundSource.Play();

                }
                if (Safe)
                {
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1sizeReduced = true;
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3.transform.position += new Vector3(0, 5, 0);
                    yellowplayer3sizeReduced = true;
                }
            }
        }
        if (redplayer1Steps >= 40)
        {
            if (Steps == (redplayer1Steps -39) && !redplayer1safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    redplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred1").transform.position = redMovementBlock[57].transform.position;
                    Soundmanager.dismissalSoundSource.Play();

                }
                if (Safe)
                {
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1sizeReduced = true;
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3.transform.position += new Vector3(0, 5, 0);
                    yellowplayer3sizeReduced = true;
                }
            }
        }
        if (redplayer2Steps < 40)
        {
            if (Steps == (redplayer2Steps + 13))
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    redplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred2").transform.position = redMovementBlock[58].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2sizeReduced = true;
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3.transform.position += new Vector3(0, 5, 0);
                    yellowplayer3sizeReduced = true;
                }
            }
        }
        if (redplayer2Steps >= 40)
        {
            if (Steps == (redplayer2Steps -39) && !redplayer2safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    redplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred2").transform.position = redMovementBlock[58].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2sizeReduced = true;
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3.transform.position += new Vector3(0, 5, 0);
                    yellowplayer3sizeReduced = true;
                }
            }
        }
        if (redplayer3Steps < 40)
        {
            if (Steps == (redplayer3Steps + 13))
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    redplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred3").transform.position = redMovementBlock[59].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3sizeReduced = true;
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3.transform.position += new Vector3(0, 5, 0);
                    yellowplayer3sizeReduced = true;
                }
            }
        }
        if (redplayer3Steps >= 40)
        {
            if (Steps == (redplayer3Steps -39) && !redplayer3safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    redplayer3Steps = 0;
                    Soundmanager.dismissalSoundSource.Play();
                    GameObject.FindGameObjectWithTag("Playerred3").transform.position = redMovementBlock[59].transform.position;
                }
                if (Safe)
                {
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3sizeReduced = true;
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3.transform.position += new Vector3(0, 5, 0);
                    yellowplayer3sizeReduced = true;
                }
            }
        }
        if (redplayer4Steps < 40)
        {
            if (Steps == (redplayer4Steps + 13))
            {

                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    redplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred4").transform.position = redMovementBlock[60].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4sizeReduced = true;
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3.transform.position += new Vector3(0, 5, 0);
                    yellowplayer3sizeReduced = true;
                }
            }
        }
        if (redplayer4Steps >= 40)
        {
            if (Steps == (redplayer4Steps -39) && !redplayer4safeWin)
            {

                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    redplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred4").transform.position = redMovementBlock[60].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4sizeReduced = true;
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3.transform.position += new Vector3(0, 5, 0);
                    yellowplayer3sizeReduced = true;
                }
            }
        }

         if (redplayer1Steps >= 40)
        {
            if (Steps == (redplayer4Steps + 13))
            {

                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    redplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred4").transform.position = redMovementBlock[60].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4sizeReduced = true;
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3.transform.position += new Vector3(0, 5, 0);
                    yellowplayer3sizeReduced = true;
                }
            }
        }
        if(Steps < 40)
        {
            if (Steps == (greenplayer1Steps - 13) && !greenplayer1safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    greenplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen1").transform.position = greenMovementBlock[57].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1sizeReduced = true;
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3.transform.position += new Vector3(0, 5, 0);
                    yellowplayer3sizeReduced = true;
                }
            }



            if (Steps == (greenplayer2Steps - 13) && !greenplayer2safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    greenplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen2").transform.position = greenMovementBlock[58].transform.position;
                }
                if (Safe)
                {
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2sizeReduced = true;
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3.transform.position += new Vector3(0, 5, 0);
                    yellowplayer3sizeReduced = true;
                }
            }
            if (Steps == (greenplayer3Steps - 13) && !greenplayer3safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    greenplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen3").transform.position = greenMovementBlock[59].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3sizeReduced = true;
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3.transform.position += new Vector3(0, 5, 0);
                    yellowplayer3sizeReduced = true;
                }
            }
            if (Steps == (greenplayer4Steps - 13) && !greenplayer4safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    greenplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen4").transform.position = greenMovementBlock[60].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4sizeReduced = true;
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3.transform.position += new Vector3(0, 5, 0);
                    yellowplayer3sizeReduced = true;
                }
            }
        }
        if (Steps >= 40)
        {
            if (Steps == (greenplayer1Steps +39))
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    greenplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen1").transform.position = greenMovementBlock[57].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1sizeReduced = true;
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3.transform.position += new Vector3(0, 5, 0);
                    yellowplayer3sizeReduced = true;
                }
            }



            if (Steps == (greenplayer2Steps +39))
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    greenplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen2").transform.position = greenMovementBlock[58].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2sizeReduced = true;
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3.transform.position += new Vector3(0, 5, 0);
                    yellowplayer3sizeReduced = true;
                }
            }
            if (Steps == (greenplayer3Steps +39))
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    greenplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen3").transform.position = greenMovementBlock[59].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3sizeReduced = true;
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3.transform.position += new Vector3(0, 5, 0);
                    yellowplayer3sizeReduced = true;
                }
            }
            if (Steps == (greenplayer4Steps +39))
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    greenplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen4").transform.position = greenMovementBlock[60].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4sizeReduced = true;
                    yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer3.transform.position += new Vector3(0, 5, 0);
                    yellowplayer3sizeReduced = true;
                }
            }
        }


        if ((Steps == (blueplayer1Steps -26) || Steps == (blueplayer1Steps + 26))&& !blueplayer1safeWin)
        {
            if (!Safe)
            {
                playerTurn = "YELLOW";
                blueplayer1Steps = 0;
                GameObject.FindGameObjectWithTag("Playerblue1").transform.position = blueMovementBlock[57].transform.position;
                Soundmanager.dismissalSoundSource.Play();
            }
            if (Safe)
            {
                blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                blueplayer1sizeReduced = true;
                yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer3.transform.position += new Vector3(0, 5, 0);
                yellowplayer3sizeReduced = true;
            }
        }
        if ((Steps == (blueplayer2Steps - 26) || Steps == (blueplayer2Steps + 26))&& !blueplayer2safeWin)
        {
            if (!Safe)
            {
                playerTurn = "YELLOW";
                blueplayer2Steps = 0;
                GameObject.FindGameObjectWithTag("Playerblue2").transform.position = blueMovementBlock[58].transform.position;
                Soundmanager.dismissalSoundSource.Play();
            }
            if (Safe)
            {
                blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                blueplayer2sizeReduced = true;
                yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer3.transform.position += new Vector3(0, 5, 0);
                yellowplayer3sizeReduced = true;
            }
        }
        if ((Steps == (blueplayer3Steps - 26) || Steps == (blueplayer3Steps + 26)) && !blueplayer3safeWin)
        {
            if (!Safe)
            {
                playerTurn = "YELLOW";
                blueplayer3Steps = 0;
                GameObject.FindGameObjectWithTag("Playerblue3").transform.position = blueMovementBlock[59].transform.position;
                Soundmanager.dismissalSoundSource.Play();
            }
            if (Safe)
            {
                blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                blueplayer3sizeReduced = true;
                yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer3.transform.position += new Vector3(0, 5, 0);
                yellowplayer3sizeReduced = true;
            }
        }
        if((Steps == (blueplayer4Steps - 26) || Steps == (blueplayer4Steps + 26)) && !blueplayer4safeWin)
        {
            if (!Safe)
            {
                playerTurn = "YELLOW";
                blueplayer4Steps = 0;
                GameObject.FindGameObjectWithTag("Playerblue4").transform.position = blueMovementBlock[60].transform.position;
                Soundmanager.dismissalSoundSource.Play();
            }
            if (Safe)
            {
                blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                blueplayer4sizeReduced = true;
                yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer3.transform.position += new Vector3(0, 5, 0);
                yellowplayer3sizeReduced = true;
            }
        }
       
        if ((58- yellowplayer3Steps) < selectDiceNumAnimation)
        {
            yellowplayer3Button.interactable = false;
        }
        if ((58 - yellowplayer3Steps) >= selectDiceNumAnimation && yellowplayer3Steps != 0)
        {
            yellowplayer3Button.interactable = true;
        }

        if (yellowplayer1Steps == 0)
        {
            yellowplayer1Caze.SetActive(true);
            yellowplayer1Button.interactable = false;
        }
        if (yellowplayer2Steps == 0)
        {
            yellowplayer2Caze.SetActive(true);
            yellowplayer2Button.interactable = false; 
        }
        if (yellowplayer3Steps == 0)
        {
            yellowplayer3Caze.SetActive(true);
            yellowplayer3Button.interactable = false;
        }
        if (yellowplayer4Steps == 0)
        {
            yellowplayer4Caze.SetActive(true);
            yellowplayer4Button.interactable = false;
        }
        IntializePlayerTurn();
    }
    public void yellowPlayer4movement()
    {
        Soundmanager.playermoveSoundSource.Play();
        Safe = false;
        if (yellowplayer4sizeReduced)
        {
            yellowplayer4.transform.localScale = new Vector3(1, 1, 1);
            yellowplayer4.transform.position -= new Vector3(0, 5, 0);
            yellowplayer4sizeReduced = false;

        }
        yellowplayer4Steps = yellowPlayermovement("Playeryellow4", yellowplayer4Steps);
        if (yellowplayer4Steps > 51)
        {
            yellowplayer4safeWin = true;
        }
        if (yellowplayer4Steps == 1 || yellowplayer4Steps == 9 || yellowplayer4Steps == 14 || yellowplayer4Steps == 22 || yellowplayer4Steps == 27 || yellowplayer4Steps == 35 || yellowplayer4Steps == 40 || yellowplayer4Steps == 48)
        {
            Safe = true;
        }
        int Steps = yellowplayer4Steps;
        if (redplayer1Steps < 40)
        {
            if (Steps == (redplayer1Steps + 13))
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    redplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred1").transform.position = redMovementBlock[57].transform.position;
                    Soundmanager.dismissalSoundSource.Play();

                }
                if (Safe)
                {
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1sizeReduced = true;
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4.transform.position += new Vector3(0, 5, 0);
                    yellowplayer4sizeReduced = true;
                }
            }
        }
        if (redplayer1Steps >= 40)
        {
            if (Steps == (redplayer1Steps -39) && !redplayer1safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    redplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred1").transform.position = redMovementBlock[57].transform.position;
                    Soundmanager.dismissalSoundSource.Play();

                }
                if (Safe)
                {
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1sizeReduced = true;
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4.transform.position += new Vector3(0, 5, 0);
                    yellowplayer4sizeReduced = true;
                }
            }
        }
        if (redplayer2Steps < 40)
        {
            if (Steps == (redplayer2Steps + 13))
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    redplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred2").transform.position = redMovementBlock[58].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2sizeReduced = true;
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4.transform.position += new Vector3(0, 5, 0);
                    yellowplayer4sizeReduced = true;
                }
            }
        }
        if (redplayer2Steps >= 40)
        {
            if (Steps == (redplayer2Steps -39) && !redplayer2safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    redplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred2").transform.position = redMovementBlock[58].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2sizeReduced = true;
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4.transform.position += new Vector3(0, 5, 0);
                    yellowplayer4sizeReduced = true;
                }
            }
        }
        if (redplayer3Steps < 40)
        {
            if (Steps == (redplayer3Steps + 13))
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    redplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred3").transform.position = redMovementBlock[59].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3sizeReduced = true;
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4.transform.position += new Vector3(0, 5, 0);
                    yellowplayer4sizeReduced = true;
                }
            }
        }
        if (redplayer3Steps >= 40)
        {
            if (Steps == (redplayer3Steps -39) && !redplayer3safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    redplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred3").transform.position = redMovementBlock[59].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3sizeReduced = true;
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4.transform.position += new Vector3(0, 5, 0);
                    yellowplayer4sizeReduced = true;
                }
            }
        }
        if (redplayer4Steps < 40)
        {
            if (Steps == (redplayer4Steps + 13))
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    redplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred4").transform.position = redMovementBlock[60].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4sizeReduced = true;
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4.transform.position += new Vector3(0, 5, 0);
                    yellowplayer4sizeReduced = true;
                }
            }

        }

        if (redplayer4Steps >= 40)
        {
            if (Steps == (redplayer4Steps -39) && !redplayer4safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    redplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred4").transform.position = redMovementBlock[60].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4sizeReduced = true;
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4.transform.position += new Vector3(0, 5, 0);
                    yellowplayer4sizeReduced = true;
                }
            }

        }
        if (Steps < 40)
        {
            if (Steps == (greenplayer1Steps - 13) && !greenplayer1safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    greenplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen1").transform.position = greenMovementBlock[57].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1sizeReduced = true;
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4.transform.position += new Vector3(0, 5, 0);
                    yellowplayer4sizeReduced = true;
                }
            }
            if (Steps == (greenplayer2Steps - 13) && !greenplayer2safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    greenplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen2").transform.position = greenMovementBlock[58].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2sizeReduced = true;
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4.transform.position += new Vector3(0, 5, 0);
                    yellowplayer4sizeReduced = true;
                }
            }
            if (Steps == (greenplayer3Steps - 13) && !greenplayer3safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    greenplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen3").transform.position = greenMovementBlock[59].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3sizeReduced = true;
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4.transform.position += new Vector3(0, 5, 0);
                    yellowplayer4sizeReduced = true;
                }
            }
            if (Steps == (greenplayer4Steps - 13)&&!greenplayer4safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    greenplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen4").transform.position = greenMovementBlock[60].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4sizeReduced = true;
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4.transform.position += new Vector3(0, 5, 0);
                    yellowplayer4sizeReduced = true;
                }
            }
        }
        if (Steps >= 40)
        {
            if (Steps == (greenplayer1Steps +39))
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    greenplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen1").transform.position = greenMovementBlock[57].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1sizeReduced = true;
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4.transform.position += new Vector3(0, 5, 0);
                    yellowplayer4sizeReduced = true;
                }
            }
            if (Steps == (greenplayer2Steps +39))
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    greenplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen2").transform.position = greenMovementBlock[58].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2sizeReduced = true;
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4.transform.position += new Vector3(0, 5, 0);
                    yellowplayer4sizeReduced = true;
                }
            }
            if (Steps == (greenplayer3Steps +39))
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    greenplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen3").transform.position = greenMovementBlock[59].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3sizeReduced = true;
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4.transform.position += new Vector3(0, 5, 0);
                    yellowplayer4sizeReduced = true;
                }
            }
            if (Steps == (greenplayer4Steps +39))
            {
                if (!Safe)
                {
                    playerTurn = "YELLOW";
                    greenplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen4").transform.position = greenMovementBlock[60].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4sizeReduced = true;
                    yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    yellowplayer4.transform.position += new Vector3(0, 5, 0);
                    yellowplayer4sizeReduced = true;
                }
            }
        }
        if ((Steps == (blueplayer1Steps - 26) || Steps == (blueplayer1Steps + 26))&& !blueplayer1safeWin)
        {
            if (!Safe)
            {
                playerTurn = "YELLOW";
                blueplayer1Steps = 0;
                GameObject.FindGameObjectWithTag("Playerblue1").transform.position = blueMovementBlock[57].transform.position;
                Soundmanager.dismissalSoundSource.Play();
            }
            if (Safe)
            {
                yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer1sizeReduced = true;
                yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer4.transform.position += new Vector3(0, 5, 0);
                yellowplayer4sizeReduced = true;
            }
        }
        if ((Steps == (blueplayer2Steps - 26) || Steps == (blueplayer2Steps + 26))&& !blueplayer2safeWin)
        {
            if (!Safe)
            {
                playerTurn = "YELLOW";
                blueplayer2Steps = 0;
                GameObject.FindGameObjectWithTag("Playerblue2").transform.position = blueMovementBlock[58].transform.position;
                Soundmanager.dismissalSoundSource.Play();
            }
            if (Safe)
            {
                yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer2sizeReduced = true;
                yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer4.transform.position += new Vector3(0, 5, 0);
                yellowplayer4sizeReduced = true;
            }
        }
        if ((Steps == (blueplayer3Steps - 26) || Steps == (blueplayer3Steps + 26))&& !blueplayer3safeWin)
        {
            if (!Safe)
            {
                playerTurn = "YELLOW";
                blueplayer3Steps = 0;
                GameObject.FindGameObjectWithTag("Playerblue3").transform.position = blueMovementBlock[59].transform.position;
                Soundmanager.dismissalSoundSource.Play();
            }
            if (Safe)
            {
                yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer3sizeReduced = true;
                yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer4.transform.position += new Vector3(0, 5, 0);
                yellowplayer4sizeReduced = true;
            }
        }
        if ((Steps == (blueplayer4Steps - 26) || Steps == (blueplayer4Steps +26)) && !blueplayer4safeWin)
        {
            if (!Safe)
            {
                playerTurn = "YELLOW";
                blueplayer4Steps = 0;
                GameObject.FindGameObjectWithTag("Playerblue4").transform.position = blueMovementBlock[60].transform.position;
                Soundmanager.dismissalSoundSource.Play();
            }
            if (Safe)
            {
                yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer4sizeReduced = true;
                yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer4.transform.position += new Vector3(0, 5, 0);
                yellowplayer4sizeReduced = true;
            }
        }
       
        if ((58- yellowplayer4Steps) < selectDiceNumAnimation)
        {
            yellowplayer4Button.interactable = false;
        }
        if ((58 - yellowplayer4Steps) >= selectDiceNumAnimation && yellowplayer4Steps != 0)
        {
            yellowplayer4Button.interactable = true;
        }

        if (yellowplayer1Steps == 0)
        {
            yellowplayer1Caze.SetActive(true);
            yellowplayer1Button.interactable = false;
        }
        if (yellowplayer2Steps == 0)
        {
            yellowplayer2Caze.SetActive(true);
            yellowplayer2Button.interactable = false;
        }
        if (yellowplayer3Steps == 0)
        {
            yellowplayer3Caze.SetActive(true);
            yellowplayer3Button.interactable = false;
        }
        if (yellowplayer4Steps == 0)
        {
            yellowplayer4Caze.SetActive(true);
            yellowplayer4Button.interactable = false;
        }

        IntializePlayerTurn();

    }
    public void bluePlayer1movement()
    {
        Soundmanager.playermoveSoundSource.Play();
        Safe = false;
        if (blueplayer1sizeReduced)
        {
            blueplayer1.transform.localScale = new Vector3(1, 1, 1);
            blueplayer1.transform.position -= new Vector3(0, 5, 0);
            blueplayer1sizeReduced = false;

        }
        blueplayer1Steps = bluePlayermovement("Playerblue1", blueplayer1Steps);
        if (blueplayer1Steps > 51)
        {
            blueplayer1safeWin = true;
        }
        if (blueplayer1Steps == 1 || blueplayer1Steps == 9 || blueplayer1Steps == 14 || blueplayer1Steps == 22 || blueplayer1Steps == 27 || blueplayer1Steps == 35 || blueplayer1Steps == 40 || blueplayer1Steps == 48)
        {
            Safe = true;
        }
        int Steps = blueplayer1Steps;
        if (Steps < 40)
        {
            if (Steps == (redplayer1Steps - 13) && !redplayer1safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred1").transform.position = redMovementBlock[57].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1sizeReduced = true;
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1.transform.position += new Vector3(0, 5, 0);
                    blueplayer1sizeReduced = true;
                }
            }
            if (Steps == (redplayer2Steps - 13) && !redplayer2safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred2").transform.position = redMovementBlock[58].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2sizeReduced = true;
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1.transform.position += new Vector3(0, 5, 0);
                    blueplayer1sizeReduced = true;
                }
            }
            if (Steps == (redplayer3Steps - 13) && !redplayer3safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred3").transform.position = redMovementBlock[59].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3sizeReduced = true;
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1.transform.position += new Vector3(0, 5, 0);
                    blueplayer1sizeReduced = true;
                }
            }
            if (Steps == (redplayer4Steps - 13) && !redplayer4safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred4").transform.position = redMovementBlock[60].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4sizeReduced = true;
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1.transform.position += new Vector3(0, 5, 0);
                    blueplayer1sizeReduced = true;
                }
            }
        }
        if (Steps >= 40)
        {
            if (Steps == (redplayer1Steps +39))
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred1").transform.position = redMovementBlock[57].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1sizeReduced = true;
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1.transform.position += new Vector3(0, 5, 0);
                    blueplayer1sizeReduced = true;
                }
            }
            if (Steps == (redplayer2Steps +39))
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred2").transform.position = redMovementBlock[58].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2sizeReduced = true;
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1.transform.position += new Vector3(0, 5, 0);
                    blueplayer1sizeReduced = true;
                }
            }
            if (Steps == (redplayer3Steps +39))
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred3").transform.position = redMovementBlock[59].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3sizeReduced = true;
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1.transform.position += new Vector3(0, 5, 0);
                    blueplayer1sizeReduced = true;
                }
            }
            if (Steps == (redplayer4Steps +39))
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred4").transform.position = redMovementBlock[60].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4sizeReduced = true;
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1.transform.position += new Vector3(0, 5, 0);
                    blueplayer1sizeReduced = true;
                }
            }
        }
        
        if ((Steps == (yellowplayer1Steps + 26) || Steps == (yellowplayer1Steps - 26)) && !yellowplayer1safeWin)
        {
            if (!Safe)
            {
                playerTurn = "BLUE";
                yellowplayer1Steps = 0;
                GameObject.FindGameObjectWithTag("Playeryellow1").transform.position = yellowMovementBlock[57].transform.position;
                Soundmanager.dismissalSoundSource.Play();
            }
            if (Safe)
            {
                yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer1sizeReduced = true;
                blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                blueplayer1.transform.position += new Vector3(0, 5, 0);
                blueplayer1sizeReduced = true;
            }
        }
        if ((Steps == (yellowplayer2Steps + 26) || Steps == (yellowplayer2Steps - 26)) && !yellowplayer2safeWin)
        {
            if (!Safe)
            {
                playerTurn = "BLUE";
                yellowplayer2Steps = 0;
                GameObject.FindGameObjectWithTag("Playeryellow2").transform.position = yellowMovementBlock[58].transform.position;
                Soundmanager.dismissalSoundSource.Play();
            }
            if (Safe)
            {
                yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer2sizeReduced = true;
                blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                blueplayer1.transform.position += new Vector3(0, 5, 0);
                blueplayer1sizeReduced = true;
            }
        }
        if ((Steps == (yellowplayer3Steps + 26) || Steps == (yellowplayer3Steps - 26)) && !yellowplayer3safeWin)
        {
            if (!Safe)
            {
                playerTurn = "BLUE";
                yellowplayer3Steps = 0;
                GameObject.FindGameObjectWithTag("Playeryellow3").transform.position = yellowMovementBlock[59].transform.position;
                Soundmanager.dismissalSoundSource.Play();
            }
            if (Safe)
            {
                yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer3sizeReduced = true;
                blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                blueplayer1.transform.position += new Vector3(0, 5, 0);
                blueplayer1sizeReduced = true;
            }
        }
        if ((Steps == (yellowplayer4Steps + 26) || Steps == (yellowplayer4Steps - 26)) && !yellowplayer4safeWin)
        {
            if (!Safe)
            {
                playerTurn = "BLUE";
                yellowplayer4Steps = 0;
                GameObject.FindGameObjectWithTag("playeryellow4").transform.position = yellowMovementBlock[60].transform.position;
                Soundmanager.dismissalSoundSource.Play();
            }
            if (Safe)
            {
                yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer4sizeReduced = true;
                blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                blueplayer1.transform.position += new Vector3(0, 5, 0);
                blueplayer1sizeReduced = true;
            }
        }
        if (greenplayer1Steps < 40)
        {
            if (Steps == (greenplayer1Steps + 13))
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen1").transform.position = greenMovementBlock[57].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1sizeReduced = true;
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1.transform.position += new Vector3(0, 5, 0);
                    blueplayer1sizeReduced = true;
                }
            }
        }
        if (greenplayer1Steps >= 40)
        {
            if (Steps == (greenplayer1Steps -39) && !greenplayer1safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen1").transform.position = greenMovementBlock[57].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1sizeReduced = true;
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1.transform.position += new Vector3(0, 5, 0);
                    blueplayer1sizeReduced = true;
                }
            }
        }
        if (greenplayer2Steps < 40)
        {
            if (Steps == (greenplayer2Steps + 13))
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen2").transform.position = greenMovementBlock[58].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2sizeReduced = true;
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1.transform.position += new Vector3(0, 5, 0);
                    blueplayer1sizeReduced = true;
                }
            }
        }
        if (greenplayer2Steps >= 40)
        {
            if (Steps == (greenplayer2Steps -39) && !greenplayer2safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen2").transform.position = greenMovementBlock[58].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2sizeReduced = true;
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1.transform.position += new Vector3(0, 5, 0);
                    blueplayer1sizeReduced = true;
                }
            }
        }
        if (greenplayer3Steps < 40)
        {
            if (Steps == (greenplayer3Steps + 13))
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen3").transform.position = greenMovementBlock[59].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3sizeReduced = true;
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1.transform.position += new Vector3(0, 5, 0);
                    blueplayer1sizeReduced = true;
                }
            }
        }
        if (greenplayer3Steps >= 40)
        {
            if (Steps == (greenplayer3Steps -39) && !greenplayer3safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen3").transform.position = greenMovementBlock[59].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3sizeReduced = true;
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1.transform.position += new Vector3(0, 5, 0);
                    blueplayer1sizeReduced = true;
                }
            }
        }
        if (greenplayer4Steps < 40)
        {
            if (Steps == (greenplayer4Steps + 13))
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen4").transform.position = greenMovementBlock[60].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4sizeReduced = true;
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1.transform.position += new Vector3(0, 5, 0);
                    blueplayer1sizeReduced = true;
                }
            }
        }
        if (greenplayer4Steps >= 40)
        {
            if (Steps == (greenplayer4Steps -39) && !greenplayer4safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen4").transform.position = greenMovementBlock[60].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4sizeReduced = true;
                    blueplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer1.transform.position += new Vector3(0, 5, 0);
                    blueplayer1sizeReduced = true;
                }
            }
        }
        if ((58 - blueplayer1Steps) < selectDiceNumAnimation)
        {
            blueplayer1Button.interactable = false;
        }
        if ((58 - blueplayer1Steps) >= selectDiceNumAnimation && blueplayer1Steps != 0)
        {
            blueplayer1Button.interactable = true;
        }

        if (blueplayer1Steps == 0)
        {
            blueplayer1Caze.SetActive(true);
            blueplayer1Button.interactable = false;
        }
        if (blueplayer2Steps == 0)
        {
            blueplayer2Caze.SetActive(true);
            blueplayer2Button.interactable = false;
        }
        if (blueplayer3Steps == 0)
        {
            blueplayer3Caze.SetActive(true);
            blueplayer3Button.interactable = false;
        }
        if (blueplayer4Steps == 0)
        {
            blueplayer4Caze.SetActive(true);
            blueplayer4Button.interactable = false;
        }


        IntializePlayerTurn();
    }
    public void bluePlayer2movement()
    {
        Soundmanager.playermoveSoundSource.Play();
        Safe = false;
        if (blueplayer2sizeReduced)
        {
            blueplayer2.transform.localScale = new Vector3(1, 1, 1);
            blueplayer2.transform.position -= new Vector3(0, 5, 0);
            blueplayer2sizeReduced = false;

        }
        blueplayer2Steps = bluePlayermovement("Playerblue2", blueplayer2Steps);
        if (blueplayer2Steps > 51)
        {
            blueplayer2safeWin = true;
        }
        if (blueplayer2Steps == 1 || blueplayer2Steps == 9 || blueplayer2Steps == 14 || blueplayer2Steps == 22 || blueplayer2Steps == 27 || blueplayer2Steps == 35 || blueplayer2Steps == 40 || blueplayer2Steps == 48)
        {
            Safe = true;
        }
        int Steps = blueplayer2Steps;
        if (Steps < 40)
        {
            if (Steps == (redplayer1Steps - 13) && !redplayer1safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred1").transform.position = redMovementBlock[57].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1sizeReduced = true;
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2.transform.position += new Vector3(0, 5, 0);
                    blueplayer2sizeReduced = true;
                }
            }
            if (Steps == (redplayer2Steps - 13) && !redplayer2safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred2").transform.position = redMovementBlock[58].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2sizeReduced = true;
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2.transform.position += new Vector3(0, 5, 0);
                    blueplayer2sizeReduced = true;
                }
            }
            if (Steps == (redplayer3Steps - 13) && !redplayer3safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred3").transform.position = redMovementBlock[59].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3sizeReduced = true;
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2.transform.position += new Vector3(0, 5, 0);
                    blueplayer2sizeReduced = true;
                }
            }
            if (Steps == (redplayer4Steps - 13) && !redplayer4safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred4").transform.position = redMovementBlock[60].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4sizeReduced = true;
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2.transform.position += new Vector3(0, 5, 0);
                    blueplayer2sizeReduced = true;
                }
            }
        }
        if (Steps >=40)
        {
            if (Steps == (redplayer1Steps +39))
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred1").transform.position = redMovementBlock[57].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1sizeReduced = true;
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2.transform.position += new Vector3(0, 5, 0);
                    blueplayer2sizeReduced = true;
                }
            }
            if (Steps == (redplayer2Steps +39))
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred2").transform.position = redMovementBlock[58].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2sizeReduced = true;
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2.transform.position += new Vector3(0, 5, 0);
                    blueplayer2sizeReduced = true;
                }
            }
            if (Steps == (redplayer3Steps +39))
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred3").transform.position = redMovementBlock[59].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3sizeReduced = true;
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2.transform.position += new Vector3(0, 5, 0);
                    blueplayer2sizeReduced = true;
                }
            }
            if (Steps == (redplayer4Steps +39))
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred4").transform.position = redMovementBlock[60].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4sizeReduced = true;
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2.transform.position += new Vector3(0, 5, 0);
                    blueplayer2sizeReduced = true;
                }
            }
        }

        if ((Steps == (yellowplayer1Steps + 26) || Steps == (yellowplayer1Steps - 26)) && !yellowplayer1safeWin)
        {
            if (!Safe)
            {
                playerTurn = "BLUE";
                yellowplayer1Steps = 0;
                GameObject.FindGameObjectWithTag("Playeryellow1").transform.position = yellowMovementBlock[57].transform.position;
                Soundmanager.dismissalSoundSource.Play();
            }
            if (Safe)
            {
                yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer1sizeReduced = true;
                blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                blueplayer2.transform.position += new Vector3(0, 5, 0);
                blueplayer2sizeReduced = true;
            }
        }
        if ((Steps == (yellowplayer2Steps + 26) || Steps == (yellowplayer2Steps - 26)) && !yellowplayer2safeWin)
        {
            if (!Safe)
            {
                playerTurn = "BLUE";
                yellowplayer2Steps = 0;
                GameObject.FindGameObjectWithTag("Playeryellow2").transform.position = yellowMovementBlock[58].transform.position;
                Soundmanager.dismissalSoundSource.Play();
            }
            if (Safe)
            {
                yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer2sizeReduced = true;
                blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                blueplayer2.transform.position += new Vector3(0, 5, 0);
                blueplayer2sizeReduced = true;
            }
        }
        if( (Steps == (yellowplayer3Steps + 26) || Steps == (yellowplayer3Steps - 26)) && !yellowplayer3safeWin)
        {
            if (!Safe)
            {
                playerTurn = "BLUE";
                yellowplayer3Steps = 0;
                GameObject.FindGameObjectWithTag("Playeryellow3").transform.position = yellowMovementBlock[59].transform.position;
                Soundmanager.dismissalSoundSource.Play();
            }
            if (Safe)
            {
                yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer3sizeReduced = true;
                blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                blueplayer2.transform.position += new Vector3(0, 5, 0);
                blueplayer2sizeReduced = true;
            }
        }
        if( (Steps == (yellowplayer4Steps + 26) || Steps == (yellowplayer4Steps - 26)) && !yellowplayer4safeWin)
        {
            if (!Safe)
            {
                playerTurn = "BLUE";
                yellowplayer4Steps = 0;
                GameObject.FindGameObjectWithTag("playeryellow4").transform.position = yellowMovementBlock[60].transform.position;
                Soundmanager.dismissalSoundSource.Play();
            }
            if (Safe)
            {
                yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer4sizeReduced = true;
                blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                blueplayer2.transform.position += new Vector3(0, 5, 0);
                blueplayer2sizeReduced = true;
            }
        }
        if (greenplayer1Steps < 40)
        {
            if (Steps == (greenplayer1Steps + 13))
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen1").transform.position = greenMovementBlock[57].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1sizeReduced = true;
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2.transform.position += new Vector3(0, 5, 0);
                    blueplayer2sizeReduced = true;
                }
            }
        }
        if (greenplayer1Steps >= 40)
        {
            if (Steps == (greenplayer1Steps -39) && !greenplayer1safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen1").transform.position = greenMovementBlock[57].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1sizeReduced = true;
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2.transform.position += new Vector3(0, 5, 0);
                    blueplayer2sizeReduced = true;
                }
            }
        }
        if (greenplayer2Steps <40)
        {
            if (Steps == (greenplayer2Steps +13))
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen2").transform.position = greenMovementBlock[58].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2sizeReduced = true;
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2.transform.position += new Vector3(0, 5, 0);
                    blueplayer2sizeReduced = true;
                }
            }
        }
        if (greenplayer2Steps >= 40)
        {
            if (Steps == (greenplayer2Steps -39) && !greenplayer2safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen2").transform.position = greenMovementBlock[58].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2sizeReduced = true;
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2.transform.position += new Vector3(0, 5, 0);
                    blueplayer2sizeReduced = true;
                }
            }
        }
        if (greenplayer3Steps < 40)
        {
            if (Steps == (greenplayer3Steps + 13))
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen3").transform.position = greenMovementBlock[59].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3sizeReduced = true;
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2.transform.position += new Vector3(0, 5, 0);
                    blueplayer2sizeReduced = true;
                }
            }
        }
        if (greenplayer3Steps >= 40)
        {
            if (Steps == (greenplayer3Steps -39) && !greenplayer3safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen3").transform.position = greenMovementBlock[59].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3sizeReduced = true;
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2.transform.position += new Vector3(0, 5, 0);
                    blueplayer2sizeReduced = true;
                }
            }
        }
        if (greenplayer4Steps < 40)
        {
            if (Steps == (greenplayer4Steps + 13))
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen4").transform.position = greenMovementBlock[60].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4sizeReduced = true;
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2.transform.position += new Vector3(0, 5, 0);
                    blueplayer2sizeReduced = true;
                }
            }
        }
        if (greenplayer4Steps >= 40)
        {
            if (Steps == (greenplayer4Steps -39) && !greenplayer4safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen4").transform.position = greenMovementBlock[60].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4sizeReduced = true;
                    blueplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer2.transform.position += new Vector3(0, 5, 0);
                    blueplayer2sizeReduced = true;
                }
            }
        }
        if ((58 - blueplayer2Steps) < selectDiceNumAnimation)
        {
            blueplayer2Button.interactable = false;
        }
        if ((58 - blueplayer2Steps) >= selectDiceNumAnimation && blueplayer2Steps != 0)
        {
            blueplayer2Button.interactable = true;
        }

        if (blueplayer1Steps == 0)
        {
            blueplayer1Caze.SetActive(true);
            blueplayer1Button.interactable = false;
        }
        if (blueplayer2Steps == 0)
        {
            blueplayer2Caze.SetActive(true);
            blueplayer2Button.interactable = false;
        }
        if (blueplayer3Steps == 0)
        {
            blueplayer3Caze.SetActive(true);
            blueplayer3Button.interactable = false;
        }
        if (blueplayer4Steps == 0)
        {
            blueplayer4Caze.SetActive(true);
            blueplayer4Button.interactable = false;
        }


        IntializePlayerTurn();
    }
    public void bluePlayer3movement()
    {
        Soundmanager.playermoveSoundSource.Play();
        Soundmanager.playermoveSoundSource.Play();
    
        Safe = false;
        if (blueplayer3sizeReduced)
        {
            blueplayer3.transform.localScale = new Vector3(1, 1, 1);
            blueplayer3.transform.position -= new Vector3(0, 5, 0);
            blueplayer3sizeReduced = false;

        }
        blueplayer3Steps = bluePlayermovement("Playerblue3", blueplayer3Steps);
        if (blueplayer3Steps > 51)
        {
            blueplayer3safeWin = true;
        }
        if (blueplayer3Steps == 1 || blueplayer3Steps == 9 || blueplayer3Steps == 14 || blueplayer3Steps == 22 || blueplayer3Steps == 27 || blueplayer3Steps == 35 || blueplayer3Steps == 40 || blueplayer3Steps == 48)
        {
            Safe = true;
        }
        int Steps = blueplayer3Steps;
        if (Steps < 40)
        {
            if (Steps == (redplayer1Steps - 13) && !redplayer1safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred1").transform.position = redMovementBlock[57].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1sizeReduced = true;
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3.transform.position += new Vector3(0, 5, 0);
                    blueplayer3sizeReduced = true;
                }
            }
            if (Steps == (redplayer2Steps - 13) && !redplayer2safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred2").transform.position = redMovementBlock[58].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2sizeReduced = true;
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3.transform.position += new Vector3(0, 5, 0);
                    blueplayer3sizeReduced = true;
                }
            }
            if (Steps == (redplayer3Steps - 13) && !redplayer3safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred3").transform.position = redMovementBlock[59].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3sizeReduced = true;
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3.transform.position += new Vector3(0, 5, 0);
                    blueplayer3sizeReduced = true;
                }
            }
            if (Steps == (redplayer4Steps - 13) && !redplayer4safeWin)
            {
                if (!Safe)
                {

                    playerTurn = "BLUE";
                    redplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred4").transform.position = redMovementBlock[60].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4sizeReduced = true;
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3.transform.position += new Vector3(0, 5, 0);
                    blueplayer3sizeReduced = true;
                }
            }
        }
        if (Steps >= 40)
        {
            if (Steps == (redplayer1Steps +39))
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred1").transform.position = redMovementBlock[57].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1sizeReduced = true;
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3.transform.position += new Vector3(0, 5, 0);
                    blueplayer3sizeReduced = true;
                }
            }
            if (Steps == (redplayer2Steps +39))
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred2").transform.position = redMovementBlock[58].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2sizeReduced = true;
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3.transform.position += new Vector3(0, 5, 0);
                    blueplayer3sizeReduced = true;
                }
            }
            if (Steps == (redplayer3Steps +39))
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred3").transform.position = redMovementBlock[59].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3sizeReduced = true;
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3.transform.position += new Vector3(0, 5, 0);
                    blueplayer3sizeReduced = true;
                }
            }
            if (Steps == (redplayer4Steps+39))
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred4").transform.position = redMovementBlock[60].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4sizeReduced = true;
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3.transform.position += new Vector3(0, 5, 0);
                    blueplayer3sizeReduced = true;
                }
            }
        }
        if( (Steps == (yellowplayer1Steps + 26) || Steps == (yellowplayer1Steps - 26)) && !yellowplayer1safeWin)
        {
            if (!Safe)
            {
                playerTurn = "BLUE";
                yellowplayer1Steps = 0;
                GameObject.FindGameObjectWithTag("Playeryellow1").transform.position = yellowMovementBlock[57].transform.position;
                Soundmanager.dismissalSoundSource.Play();
            }
            if (Safe)
            {
                yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer1sizeReduced = true;
                blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                blueplayer3.transform.position += new Vector3(0, 5, 0);
                blueplayer3sizeReduced = true;
            }
        }
        if ((Steps == (yellowplayer2Steps + 26) || Steps == (yellowplayer2Steps - 26)) && !yellowplayer2safeWin)
        {
            if (!Safe)
            {
                playerTurn = "BLUE";
                yellowplayer2Steps = 0;
                GameObject.FindGameObjectWithTag("Playeryellow2").transform.position = yellowMovementBlock[58].transform.position;
                Soundmanager.dismissalSoundSource.Play();
            }
            if (Safe)
            {
                yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer2sizeReduced = true;
                blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                blueplayer3.transform.position += new Vector3(0, 5, 0);
                blueplayer3sizeReduced = true;
            }
        }
        if ((Steps == (yellowplayer3Steps + 26) || Steps == (yellowplayer3Steps - 26)) && !yellowplayer3safeWin)
        {
            if (!Safe)
            {
                playerTurn = "BLUE";
                yellowplayer3Steps = 0;
                GameObject.FindGameObjectWithTag("Playeryellow3").transform.position = yellowMovementBlock[59].transform.position;
                Soundmanager.dismissalSoundSource.Play();
            }
            if (Safe)
            {
                yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer3sizeReduced = true;
                blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                blueplayer3.transform.position += new Vector3(0, 5, 0);
                blueplayer3sizeReduced = true;
            }
        }
        if ((Steps == (yellowplayer4Steps + 26) || Steps == (yellowplayer4Steps - 26)) && !yellowplayer4safeWin)
        {
            if (!Safe)
            {
                playerTurn = "BLUE";
                yellowplayer4Steps = 0;
                GameObject.FindGameObjectWithTag("playeryellow4").transform.position = yellowMovementBlock[60].transform.position;
                Soundmanager.dismissalSoundSource.Play();
            }
            if (Safe)
            {
                yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer4sizeReduced = true;
                blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                blueplayer3.transform.position += new Vector3(0, 5, 0);
                blueplayer3sizeReduced = true;
            }
        }
        if (greenplayer1Steps < 40)
        {
            if (Steps == (greenplayer1Steps + 13))
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen1").transform.position = greenMovementBlock[57].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1sizeReduced = true;
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3.transform.position += new Vector3(0, 5, 0);
                    blueplayer3sizeReduced = true;
                }
            }
        }
        if (greenplayer1Steps >= 40)
        {
            if (Steps == (greenplayer1Steps -39) && !greenplayer1safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen1").transform.position = greenMovementBlock[57].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1sizeReduced = true;
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3.transform.position += new Vector3(0, 5, 0);
                    blueplayer3sizeReduced = true;
                }
            }
        }
        if (greenplayer2Steps < 40)
        {
            if (Steps == (greenplayer2Steps + 13))
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen2").transform.position = greenMovementBlock[58].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2sizeReduced = true;
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3.transform.position += new Vector3(0, 5, 0);
                    blueplayer3sizeReduced = true;
                }
            }
        }
        if (greenplayer2Steps  >=40)
        {
            if (Steps == (greenplayer2Steps -39) && !greenplayer2safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen2").transform.position = greenMovementBlock[58].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2sizeReduced = true;
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3.transform.position += new Vector3(0, 5, 0);
                    blueplayer3sizeReduced = true;
                }
            }
        }
        if (greenplayer3Steps < 40)
        {
            if (Steps == (greenplayer3Steps + 13))
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen3").transform.position = greenMovementBlock[59].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3sizeReduced = true;
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3.transform.position += new Vector3(0, 5, 0);
                    blueplayer3sizeReduced = true;
                }
            }
        }
        if (greenplayer3Steps >= 40)
        {
            if (Steps == (greenplayer3Steps -39) && !greenplayer3safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen3").transform.position = greenMovementBlock[59].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3sizeReduced = true;
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3.transform.position += new Vector3(0, 5, 0);
                    blueplayer3sizeReduced = true;
                }
            }
        }
        if (greenplayer4Steps < 40)
        {
            if (Steps == (greenplayer3Steps +13))
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen3").transform.position = greenMovementBlock[59].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3sizeReduced = true;
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3.transform.position += new Vector3(0, 5, 0);
                    blueplayer3sizeReduced = true;
                }
            }
        }
        if (greenplayer4Steps >= 40)
        {
            if (Steps == (greenplayer4Steps - 39) && !greenplayer4safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen4").transform.position = greenMovementBlock[60].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4sizeReduced = true;
                    blueplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer3.transform.position += new Vector3(0, 5, 0);
                    blueplayer3sizeReduced = true;
                }
            }
        }
        if ((58 - blueplayer3Steps) < selectDiceNumAnimation)
        {
            blueplayer3Button.interactable = false;
        }
        if ((58 - blueplayer3Steps) >= selectDiceNumAnimation && blueplayer3Steps != 0)
        {
            blueplayer3Button.interactable = true;
        }

        if (blueplayer1Steps == 0)
        {
            blueplayer1Caze.SetActive(true);
            blueplayer1Button.interactable = false;
        }
        if (blueplayer2Steps == 0)
        {
            blueplayer2Caze.SetActive(true);
            blueplayer2Button.interactable = false;
        }
        if (blueplayer3Steps == 0)
        {
            blueplayer3Caze.SetActive(true);
            blueplayer3Button.interactable = false;
        }
        if (blueplayer4Steps == 0)
        {
            blueplayer4Caze.SetActive(true);
            blueplayer4Button.interactable = false;
        }

        IntializePlayerTurn();

    }
    public void bluePlayer4movement()
    {
        Soundmanager.playermoveSoundSource.Play();
        Safe = false;
        if (blueplayer4sizeReduced)
        {
            blueplayer4.transform.localScale = new Vector3(1, 1, 1);
            blueplayer4.transform.position -= new Vector3(0, 5, 0);
            blueplayer4sizeReduced = false;

        }
        blueplayer4Steps = bluePlayermovement("Playerblue4", blueplayer4Steps);
        if(blueplayer4Steps>51)
        {
            blueplayer4safeWin = true;
        }
        if (blueplayer4Steps == 1 || blueplayer4Steps == 9 || blueplayer4Steps == 14 || blueplayer4Steps == 22 || blueplayer4Steps == 27 || blueplayer4Steps == 35 || blueplayer4Steps == 40 || blueplayer4Steps == 48)
        {
            Safe = true;
        }
        int Steps = blueplayer4Steps;
        
        if (Steps < 40)
        {
            if (Steps == (redplayer1Steps - 13)&&!redplayer1safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred1").transform.position = redMovementBlock[57].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1sizeReduced = true;
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4.transform.position += new Vector3(0, 5, 0);
                    blueplayer4sizeReduced = true;
                }
            }
            if (Steps == (redplayer2Steps - 13)&&!redplayer2safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred2").transform.position = redMovementBlock[58].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2sizeReduced = true;
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4.transform.position += new Vector3(0, 5, 0);
                    blueplayer4sizeReduced = true;
                }
            }
            if (Steps == (redplayer3Steps - 13) && !redplayer3safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred3").transform.position = redMovementBlock[59].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3sizeReduced = true;
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4.transform.position += new Vector3(0, 5, 0);
                    blueplayer4sizeReduced = true;
                }
            }
            if (Steps == (redplayer4Steps - 13)&&!redplayer4safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred4").transform.position = redMovementBlock[60].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4sizeReduced = true;
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4.transform.position += new Vector3(0, 5, 0);
                    blueplayer4sizeReduced = true;
                }
            }
        }
        if (Steps >= 40)
        {
            if (Steps == (redplayer1Steps +39) && !redplayer1safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred1").transform.position = redMovementBlock[57].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer1sizeReduced = true;
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4.transform.position += new Vector3(0, 5, 0);
                    blueplayer4sizeReduced = true;
                }
            }
            if (Steps == (redplayer2Steps +39) && !redplayer2safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred2").transform.position = redMovementBlock[58].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer2sizeReduced = true;
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4.transform.position += new Vector3(0, 5, 0);
                    blueplayer4sizeReduced = true;
                }
            }
            if (Steps == (redplayer3Steps +39) && !redplayer3safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred3").transform.position = redMovementBlock[59].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer3sizeReduced = true;
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4.transform.position += new Vector3(0, 5, 0);
                    blueplayer4sizeReduced = true;
                }
            }
            if (Steps == (redplayer4Steps +39) && !redplayer4safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    redplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playerred4").transform.position = redMovementBlock[60].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    redplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    redplayer4sizeReduced = true;
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4.transform.position += new Vector3(0, 5, 0);
                    blueplayer4sizeReduced = true;
                }
            }
        }
        if ((Steps == (yellowplayer1Steps + 26) || Steps == (yellowplayer1Steps - 26)) && !yellowplayer1safeWin)
        {
            if (!Safe)
            {
                playerTurn = "BLUE";
                yellowplayer1Steps = 0;
                GameObject.FindGameObjectWithTag("Playeryellow1").transform.position = yellowMovementBlock[57].transform.position;
                Soundmanager.dismissalSoundSource.Play();
            }
            if (Safe)
            {
                yellowplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer1sizeReduced = true;
                blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                blueplayer4.transform.position += new Vector3(0, 5, 0);
                blueplayer4sizeReduced = true;
            }
        }
        if ((Steps == (yellowplayer2Steps + 26) || Steps == (yellowplayer2Steps - 26))&& !yellowplayer2safeWin)
        {
            if (!Safe)
            {
                playerTurn = "BLUE";
                yellowplayer2Steps = 0;
                GameObject.FindGameObjectWithTag("Playeryellow2").transform.position = yellowMovementBlock[58].transform.position;
                Soundmanager.dismissalSoundSource.Play();
            }
            if (Safe)
            {
                yellowplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer2sizeReduced = true;
                blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                blueplayer4.transform.position += new Vector3(0, 5, 0);
                blueplayer4sizeReduced = true;
            }
        }
        if ((Steps == (yellowplayer3Steps + 26) || Steps == (yellowplayer3Steps - 26)) && !yellowplayer3safeWin)
        {
            if (!Safe)
            {
                playerTurn = "BLUE";
                yellowplayer3Steps = 0;
                GameObject.FindGameObjectWithTag("Playeryellow3").transform.position = yellowMovementBlock[59].transform.position;
                Soundmanager.dismissalSoundSource.Play();
            }
            if (Safe)
            {
                yellowplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer3sizeReduced = true;
                blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                blueplayer4.transform.position += new Vector3(0, 5, 0);
                blueplayer4sizeReduced = true;
            }
        }
        if ((Steps == (yellowplayer4Steps + 26)||Steps==(yellowplayer4Steps-26)) && !yellowplayer4safeWin)
        {
            if (!Safe)
            {
                playerTurn = "BLUE";
                yellowplayer4Steps = 0;
                GameObject.FindGameObjectWithTag("playeryellow4").transform.position = yellowMovementBlock[60].transform.position;
                Soundmanager.dismissalSoundSource.Play();
            }
            if (Safe)
            {
                yellowplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                yellowplayer4sizeReduced = true;
                blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                blueplayer4.transform.position += new Vector3(0, 5, 0);
                blueplayer4sizeReduced = true;
            }
        }
        if (greenplayer1Steps < 40)
        {

            if (Steps == (greenplayer1Steps + 13) && !greenplayer1safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen1").transform.position = greenMovementBlock[57].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1sizeReduced = true;
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4.transform.position += new Vector3(0, 5, 0);
                    blueplayer4sizeReduced = true;
                }
            }
        }
        if (greenplayer1Steps >= 40)
        {

            if (Steps == (greenplayer1Steps -39) && !greenplayer1safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer1Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen1").transform.position = greenMovementBlock[57].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer1.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer1sizeReduced = true;
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4.transform.position += new Vector3(0, 5, 0);
                    blueplayer4sizeReduced = true;
                }
            }
        }
        if (greenplayer2Steps < 40)
        {
            if (Steps == (greenplayer2Steps + 13) && !greenplayer2safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen2").transform.position = greenMovementBlock[58].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2sizeReduced = true;
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4.transform.position += new Vector3(0, 5, 0);
                    blueplayer4sizeReduced = true;
                }
            }
        }
       
        if (greenplayer2Steps >= 40)
        {
            if (Steps == (greenplayer2Steps -39) && !greenplayer2safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer2Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen2").transform.position = greenMovementBlock[58].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer2.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer2sizeReduced = true;
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4.transform.position += new Vector3(0, 5, 0);
                    blueplayer4sizeReduced = true;
                }
            }
        }
        if (greenplayer3Steps < 40)
        {
            if (Steps == (greenplayer3Steps + 13) && !greenplayer3safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen3").transform.position = greenMovementBlock[59].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3sizeReduced = true;
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4.transform.position += new Vector3(0, 5, 0);
                    blueplayer4sizeReduced = true;
                }
            }
        }
        if (greenplayer3Steps >= 40)
        {
            if (Steps == (greenplayer3Steps -39) && !greenplayer3safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer3Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen3").transform.position = greenMovementBlock[59].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer3.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer3sizeReduced = true;
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4.transform.position += new Vector3(0, 5, 0);
                    blueplayer4sizeReduced = true;
                }
            }
        }
        if (greenplayer4Steps < 40)
        {
            if (Steps == (greenplayer4Steps + 13) && !greenplayer4safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen4").transform.position = greenMovementBlock[60].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4sizeReduced = true;
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4.transform.position += new Vector3(0, 5, 0);
                    blueplayer4sizeReduced = true;
                }
            }
        }
        if (greenplayer4Steps >= 40)
        {
            if (Steps == (greenplayer4Steps -39) && !greenplayer4safeWin)
            {
                if (!Safe)
                {
                    playerTurn = "BLUE";
                    greenplayer4Steps = 0;
                    GameObject.FindGameObjectWithTag("Playergreen4").transform.position = greenMovementBlock[60].transform.position;
                    Soundmanager.dismissalSoundSource.Play();
                }
                if (Safe)
                {
                    greenplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    greenplayer4sizeReduced = true;
                    blueplayer4.transform.localScale = new Vector3(0.5f, 0.5f, 1);
                    blueplayer4.transform.position += new Vector3(0, 5, 0);
                    blueplayer4sizeReduced = true;
                }
            }
        }
        if ((58 - blueplayer4Steps) < selectDiceNumAnimation)
        {
            blueplayer4Button.interactable = false;
        }
        if ((58 - blueplayer4Steps) >= selectDiceNumAnimation && blueplayer4Steps != 0)
        {
            blueplayer4Button.interactable = true;
        }

        if (blueplayer1Steps == 0)
        {
            blueplayer1Caze.SetActive(true);
            blueplayer1Button.interactable = false;
        }
        if (blueplayer2Steps == 0)
        {
            blueplayer2Caze.SetActive(true);
            blueplayer2Button.interactable = false;
        }
        if (blueplayer3Steps == 0)
        {
            blueplayer3Caze.SetActive(true);
            blueplayer3Button.interactable = false;
        }
        if (blueplayer4Steps == 0)
        {
            blueplayer4Caze.SetActive(true);
            blueplayer4Button.interactable = false;
        }

        IntializePlayerTurn();

    }
    void blink(GameObject obj, float blinkSpeed, float duration)
        {
            StartCoroutine(_blinkCOR(obj, blinkSpeed, duration));
        }
        IEnumerator _blinkCOR(GameObject obj, float blinkSpeed, float duration)
        {
            obj.SetActive(true);
            Color defualtColor = obj.GetComponent<MeshRenderer>().material.color;

            float counter = 0;
            float innerCounter = 0;

            bool visible = false;

            while (counter < duration)
            {
                counter += Time.deltaTime;
                innerCounter += Time.deltaTime;

                //Toggle and reset if innerCounter > blinkSpeed
                if (innerCounter > blinkSpeed)
                {
                    visible = !visible;
                    innerCounter = 0f;
                }

                if (visible)
                {
                    //Show
                    show(obj);
                }
                else
                {
                    //Hide
                    hide(obj);
                }

                //Wait for a frame
                yield return null;
            }

            //Done Blinking, Restore default color then Disable the GameObject
            obj.GetComponent<MeshRenderer>().material.color = defualtColor;
            obj.SetActive(false);
        }
        void show(GameObject obj)
        {
            Color currentColor = obj.GetComponent<MeshRenderer>().material.color;
            currentColor.a = 1;
            obj.GetComponent<MeshRenderer>().material.color = currentColor;
        }

        void hide(GameObject obj)
        {
            Color currentColor = obj.GetComponent<MeshRenderer>().material.color;
            currentColor.a = 0;
            obj.GetComponent<MeshRenderer>().material.color = currentColor;
        }
        // Start is called before the first frame update
        void Start ()
        {
            QualitySettings.vSyncCount = 1;
            Application.targetFrameRate = 30;
            switch (mainmenumanager.number_players)
            {
                case 2:

                    playerTurn = "RED";

                    redFrame.SetActive(true);
                    yellowFrame.SetActive(false);
                    greenFrame.SetActive(false);
                    blueFrame.SetActive(false);

                    blueplayer1.SetActive(false);
                    blueplayer2.SetActive(false);
                    blueplayer3.SetActive(false);
                    blueplayer4.SetActive(false);

                    yellowplayer1.SetActive(false);
                    yellowplayer2.SetActive(false);
                    yellowplayer3.SetActive(false);
                    yellowplayer4.SetActive(false);
                    break;
                case 3:
                    playerTurn = "YELLOW";

                    yellowFrame.SetActive(true);
                    redFrame.SetActive(false);
                    greenFrame.SetActive(false);
                    blueFrame.SetActive(false);

                    greenplayer1.SetActive(false);
                    greenplayer2.SetActive(false);
                    greenplayer3.SetActive(false);
                    greenplayer4.SetActive(false);

                    break;
                case 4:
                    playerTurn = "RED";

                    blueFrame.SetActive(false);
                    redFrame.SetActive(true);
                    greenFrame.SetActive(false);
                    yellowFrame.SetActive(false);
                    break;
            }
            redplayer1pos = redplayer1.transform.position;
            redplayer2pos = redplayer2.transform.position;
            redplayer3pos = redplayer3.transform.position;
            redplayer4pos = redplayer4.transform.position;

            greenplayer1pos = greenplayer1.transform.position;
            greenplayer2pos = greenplayer2.transform.position;
            greenplayer3pos = greenplayer3.transform.position;
            greenplayer4pos = greenplayer4.transform.position;

            blueplayer1pos = blueplayer1.transform.position;
            blueplayer2pos = blueplayer2.transform.position;
            blueplayer3pos = blueplayer3.transform.position;
            blueplayer4pos = blueplayer4.transform.position;

            yellowplayer1pos = yellowplayer1.transform.position;
            yellowplayer2pos = yellowplayer2.transform.position;
            yellowplayer3pos = yellowplayer3.transform.position;
            yellowplayer4pos = yellowplayer4.transform.position;
        }

        // Update is called once per frame
        void Update()
        {

        }

    }


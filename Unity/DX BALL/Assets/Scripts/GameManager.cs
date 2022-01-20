using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject ballPrefab;
    public GameObject playerPrefab;
    public Text scoreText;
    public Text ballsText;
    public Text levelText;

    public GameObject panelMenu;
    public GameObject panelPlay;
    public GameObject panelLevelCompleted;
    public GameObject panelGameOver;

    public enum State {MENU,INIT,PLAY,LEVELCOMPLETED,LOADLEVEL,GAMEOVER}
    State _state; 

    public void PlayClicked(){
        SwitchState(State.INIT);
    }

    void Start()
    {
        SwitchState(State.MENU);
    }

    
   

    public void SwitchState(State newState){
        EndState();
        BeginState(newState);
    }

    void BeginState(State newState){
        switch (newState){
            case State.MENU:
            panelMenu.SetActive(true);
            break;
            case State.INIT:
            panelPlay.SetActive(true);
            break;
            case State.PLAY:
            break;
            case State.LEVELCOMPLETED:
            panelLevelCompleted.SetActive(true);
            break;
            case State.LOADLEVEL:
            break;
            case State.GAMEOVER:
            panelGameOver.SetActive(true);
            break;
            }
    }

    void Update()
    {
         switch (_state){
            case State.MENU:
            break;
            case State.INIT:
            break;
            case State.PLAY:
            break;
            case State.LEVELCOMPLETED:
            break;
            case State.LOADLEVEL:
            break;
            case State.GAMEOVER:
            break;
            }
    }

    void EndState(){
         switch (_state){
            case State.MENU:
            panelMenu.SetActive(false);
            break;
            case State.INIT:
            break;
            case State.PLAY:
            break;
            case State.LEVELCOMPLETED:
            panelLevelCompleted.SetActive(false);
            break;
            case State.LOADLEVEL:
            break;
            case State.GAMEOVER:
            panelPlay.SetActive(false);
            panelGameOver.SetActive(false);
            break;
            }
    }
}

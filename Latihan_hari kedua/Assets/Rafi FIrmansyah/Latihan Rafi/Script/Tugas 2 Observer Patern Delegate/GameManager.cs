using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GmMngrRafi
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager _instance;

        private bool gameOver = false;
        private bool win = false;
        private bool pause = false;

        public GameObject panelGameOver;
        public GameObject panelWin;
        public GameObject panelPaused;


        public bool IsGameOver => gameOver;
        public bool IsWin => win;
        public bool IsPaused => pause;

        public static GameManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = FindObjectOfType<GameManager>();

                    if (_instance == null)
                    {
                        GameObject singleton = new GameObject(typeof(GameManager).Name);
                        _instance = singleton.AddComponent<GameManager>();
                    }
                }
                return _instance;
            }
        }

        public void SetGameOver(bool value)
        {
            gameOver = value;
            if (gameOver)
            {
                panelGameOver.SetActive(true);
            }

            else
            {
                panelGameOver.SetActive(false);

            }
        }

        public void SetWin(bool value)
        {
            win = value;
            if (win)
            {
                panelWin.SetActive(true);
            }

            else
            {
                panelWin.SetActive(false);

            }
        }

        public void SetPause(bool value)
        {
            pause = value;
            if (pause)
            {
                panelPaused.SetActive(true);
            }

            else
            {
                panelPaused.SetActive(false);

            }
        }
    }
}

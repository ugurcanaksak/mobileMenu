using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{


        public void play()
        {            
            Debug.Log($"Play Clicked");
        }

        public void Exit()
        {
            Debug.Log("Exit Clicked");
        }

        public void Options()
        {
            Debug.Log("Options Clicked");
        }
        public void HighScore()
        {
            Debug.Log("High Score Clicked");
        }
}

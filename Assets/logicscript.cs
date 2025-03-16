using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicscript : MonoBehaviour
{
    public int score;
    public Text scoretext;
    public bool flag = true;
    public GameObject gameoverscreeen;
    public audiooo audiop;

    private void Start()
    {
        audiop = GameObject.FindGameObjectWithTag("audio").GetComponent<audiooo>();
    }


    [ContextMenu("increase score")]
    public void addscore(int scoretoadd)
    {
        if (flag == true)
        {
            score = score + scoretoadd;
            scoretext.text = score.ToString();
            audiop.playsfx(audiop.score);

        }

    }
    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Game0ver()
    {   
        gameoverscreeen.SetActive(true);
        audiop.playsfx(audiop.death);
        flag = false;

    }
}

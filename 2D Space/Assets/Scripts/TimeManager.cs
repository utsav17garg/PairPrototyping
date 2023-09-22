using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using TMPro;
using UnityEngine.UI;
public class TimeManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI theText;
    public float startingTime;
    private GameConroller gameOverPanel;
    private void Start()
    {

        gameOverPanel = GameObject.Find("GameController").GetComponent<GameConroller>();
    }

    // Update is called once per frame
    void Update()
    {
        startingTime -= Time.deltaTime;
        if(startingTime < 0)
        {
            theText.text = "" + 0;
            Debug.Log("Game Over");
            GameObject spaceShip = GameObject.FindGameObjectsWithTag("Player")[0];
            Destroy(spaceShip);
            Debug.Log("Destroyed");
            Time.timeScale = 0;
            gameOverPanel.show();
        }
        theText.text = "" + Mathf.Round(startingTime);
    }

    public void addTime()
    {
        Debug.Log("Adding Time");
        float asd = float.Parse(theText.text,
      System.Globalization.CultureInfo.InvariantCulture) + 10;
        startingTime = asd;
    }

    public void penaltyTime()
    {
        float penalty = float.Parse(theText.text,
      System.Globalization.CultureInfo.InvariantCulture) - 20;
        startingTime = penalty;
    }
}

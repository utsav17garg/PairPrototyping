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
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        startingTime -= Time.deltaTime;
        theText.text = "" + Mathf.Round(startingTime);
    }

    public void addTime()
    {
        Debug.Log("hello");
        float asd = float.Parse(theText.text,
      System.Globalization.CultureInfo.InvariantCulture) + 5;
        startingTime = asd;
    }
}

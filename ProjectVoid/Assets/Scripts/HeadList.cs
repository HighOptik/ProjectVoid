using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadList : MonoBehaviour
{
    public List<GameObject> AllSprites;
    public int currentlyDisplayed;
    // Use this for initialization
    void Start()
    {
        foreach (Transform child in transform)
        {
            AllSprites.Add(child.gameObject);

        }
        currentlyDisplayed = Random.Range(0, AllSprites.Count);
        DisplayCurrent();
    }

    // Update is called once per frame
    public void DisplayCurrent()
    {
        foreach (GameObject go in AllSprites)
        {
            go.SetActive(false);
        }
        AllSprites[currentlyDisplayed].SetActive(true);
    }
    public void Next()
    {
        int prevNumb = currentlyDisplayed;
        currentlyDisplayed = Random.Range(0, AllSprites.Count);
        if (prevNumb == currentlyDisplayed)
        {
            currentlyDisplayed = Random.Range(0, AllSprites.Count);
        }
        DisplayCurrent();

    }
}

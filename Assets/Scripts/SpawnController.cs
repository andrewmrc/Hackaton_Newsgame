using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SpawnController : MonoBehaviour
{
    private Archive archive;
    //private Calculator refCalculator;

    public Button[] buttons;

    private void Awake()
    {
        archive = FindObjectOfType<Archive>();
        //refCalculator = FindObjectOfType<Calculator>();
	}

    private void Start()
    {
        StartCoroutine(Spawn(5));
    }

    private IEnumerator Spawn(float _seconds)
    {
        while (true)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].GetComponent<News>().isTrue = archive.listNews[i].isTrue;
                buttons[i].GetComponent<News>().isInteresting = archive.listNews[i].isInteresting;
                buttons[i].GetComponent<News>().titleNews = archive.listNews[i].titleNews;
                buttons[i].GetComponentInChildren<Text>().text = buttons[i].GetComponent<News>().titleNews;

                Debug.Log("Refresh");
                //refCalculator.CalcNewsValue(buttons[i]);
            }

            yield return new WaitForSeconds(_seconds);
            yield return null;
        }
    }

    private void RefreshText(string _titleNews)
    {

    }
}
using UnityEngine;

[System.Serializable]
public class News : MonoBehaviour
{
    public bool isTrue, isInteresting;
    public string titleNews;
    public int weight;
    
    public News(bool _isTrue, bool _isInteresting, string _titleNews)
    {
        isTrue = _isTrue;
        isInteresting = _isInteresting;
        titleNews = _titleNews;
    }
}
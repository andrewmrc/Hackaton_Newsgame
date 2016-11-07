using UnityEngine;
using System.Collections.Generic;

public class Archive : MonoBehaviour
{
    public List<News> listNews;
    
    private void Awake()
    {
        listNews = new List<News>();
        News news_1 = new News(true, true, "Clinton vince su Trump");
        News news_2= new News(true, false, "Zio Peppe è morto");
        News news_3 = new News(false, false, "Primo uomo sbarcato sul Sole");

        listNews.Add(news_1);
        listNews.Add(news_2);
        listNews.Add(news_3);
    }
}
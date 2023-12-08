using System;

class Program
{
    
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video youtubeJavaScript = new Video("The Modern JavaScript Tutorial", "E.tv", 2500);
        Video youtubeDogs = new Video("Funny Dogs compilation", "ACBC Media", 5000);
        Video youtubeprogram = new Video("C# programming basics", "BYU", 6050);

        _videos.Add(youtubeJavaScript);
        _videos.Add(youtubeDogs);
        _videos.Add(youtubeprogram);       

        youtubeJavaScript.SetComment("Alice", "this is an outstanding book on JS. Extremely well organized, thorough, yet simple. The author(s) have nailed it!");
        youtubeJavaScript.SetComment("Bob", "Yes it is one of the best!!");
        youtubeJavaScript.SetComment("Charlie", "I wished I had  watched this video sooner!.");

        youtubeDogs.SetComment("ben", "This is so funny, I can't stop laughing!");
        youtubeDogs.SetComment("David", "The Dod at 3:15 is my favorite!");
        youtubeDogs.SetComment("Top2", "My dog does that all the time!");

        youtubeprogram.SetComment("Eve","This is very helpful, thank you!");
        youtubeprogram.SetComment("Sinny","I learned a lot from this video!");
        youtubeprogram.SetComment("Gagy","I love it");
        
        foreach (Video video in _videos)
        {
            video.DisplayVideoInfo();
        }
        
        
    }
}


























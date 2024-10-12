using System;

class Program
{
    static void Main(string[] args)
    {
        //Clear console and set output settings
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;

        //Open an empty list of vieos
        List<Video> allVids = new List<Video>();

        //Create a few videos
        Video vid1 = new Video("MrBeast","Counting to 1 googleplex","4:38:23");
        vid1.AddComment("Ben P.","Great video man!");
        vid1.AddComment("Steven H.","I think you skipped 894...");
        vid1.AddComment("Sarah M.","More videos with Carl pls!");
        allVids.Add(vid1);

        Video vid2 = new Video("Corg&Co","Learning Klingon W/LMadge!","23:54");
        vid2.AddComment("Willem D.","Interesting stuff here.");
        vid2.AddComment("Marty O.","Love your content");
        vid2.AddComment("Rosie O.","You two are so cute!");
        allVids.Add(vid2);

        Video vid3 = new Video("GameTheorists","Is PacMan a Secret Government Spy?","1:02:03");
        vid3.AddComment("Dwayne J.","More likely Mrs. PacMan");
        vid3.AddComment("Aqua F.","OMG I LOVE OLD MARIO GAMES!!!");
        vid3.AddComment("Matt P.","@Aqua_F. Mario literally isn't in this game...");
        allVids.Add(vid3);

        Video vid4 = new Video("HiddenXperia","5 Halo Games Announced in 24 Hours!","42:15");
        vid4.AddComment("Bill M.","They all look trash tho");
        vid4.AddComment("Whoopie G.","It's the green guy from Fortnite!");
        vid4.AddComment("Brenden H.","AI and microtransactions... yipee");
        allVids.Add(vid4);

        foreach(Video singleVid in allVids)
        {
            singleVid.ShowVideoDetails();
            singleVid.ShowComments();
        }
    }
}
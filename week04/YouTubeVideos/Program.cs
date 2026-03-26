using System;
using System.Diagnostics;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _HimTube = new List<Video>(); 
        Video one = new Video();
        one.SetVideo("Reviewing on how to not use a graphics card", "Nvidia", 5070);
        one.SetComment("techBuddy", "Loved the video, deserves a sequel about RAM next!");
        one.SetComment("ITGuy", "I been doing this wrong my whole life! thanks!");
        one.SetComment("GroupNerd", "Erm, ackshually, twisting the cable like you did will decrease performance by 0.000001 seconds, wich is unnaceptable");
        _HimTube.Add(one);
        Video two = new Video();
        two.SetVideo("Video on a resolution so high you can smell nature", "HDNature", 2160);
        two.SetComment("Hobot","bro that was unecessairy, juz go out side");
        two.SetComment("MaddamOlinda","Thank you so much, now i can finally smell the nice fragrances of nature while doing chores");
        two.SetComment("WorkplaceHazard","First time seeing nature, been born on a big city and there's none of that left here");
        _HimTube.Add(two);
        Video tree = new Video();
        tree.SetVideo("squirrels, where to find them and how to get them to bury seeds", "Sapling", 360);
        tree.SetComment("SquirrelsSA","We do not like your video, we feel exploited and will file complaints to your lawyer!");
        tree.SetComment("BigOak","I'm proud of you! I never quite understood the process but now i feel much well informed!");
        tree.SetComment("GrapesIsFresh","Yall having to do all this to your seeds??");
        tree.SetComment("SplitScreech","Great video, will never use that information ever.");
        _HimTube.Add(tree);

        foreach (Video video in _HimTube)
        {
            int ammount = video.ReturnCommentAmmount();
            video.DisplayVideoThings(ammount);
        }
    }
}
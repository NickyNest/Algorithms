Console.WriteLine("Hash tables");

var voted = new Dictionary<string, bool>();
CheckVote("mike");
CheckVote("tom");
CheckVote("mike");


void CheckVote(string name)
{
    if (voted.ContainsKey(name))
    {
        Console.WriteLine("kick them out!");
    }
    else
    {
        voted[name] = true;
        Console.WriteLine("let them vote {0}", name);
    }
}
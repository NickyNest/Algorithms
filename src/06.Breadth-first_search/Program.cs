Console.WriteLine("Breadth-first_search");

var graph = new Dictionary<string, List<string>>
{
    ["you"] = ["alice", "bob", "claire"],
    ["bob"] = ["anuj", "peggy"],
    ["alice"] = ["peggy"],
    ["claire"] = ["thom", "jonny"],
    ["anuj"] = [],
    ["peggy"] = [],
    ["thom"] = [],
    ["jonny"] = []
};

var found = Search("you");
Console.WriteLine(string.IsNullOrEmpty(found) ? "not found" : found);

string Search(string name)
{
    var searchQueue = new Queue<string>(graph[name]);
    var searched = new List<string>();

    while(searchQueue.TryDequeue(out var person))
    {
        if(searched.Contains(person))
        {
            continue;
        }

        if (IsSeller(person))
        {
            return person;
        }
        else
        {
            searchQueue = new Queue<string>(searchQueue.Concat(graph[person]));
            searched.Add(person);
        }
    }

    return string.Empty;
}

bool IsSeller(string name) => name[^1] == 'm';
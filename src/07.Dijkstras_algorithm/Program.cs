Console.WriteLine("Dijkstras algorithm");

var graph = new Dictionary<string, Dictionary<string, int>>()
{
    ["start"] = new Dictionary<string, int>()
    {
        ["a"] = 6,
        ["b"] = 2
    },
    ["a"] = new Dictionary<string, int>()
    {
        ["fin"] = 1
    },
    ["b"] = new Dictionary<string, int>()
    {
        ["a"] = 3,
        ["fin"] = 5
    },
    ["fin"] = new Dictionary<string, int>()
};
var infinity = int.MaxValue;
var costs = new Dictionary<string, int>
{
    ["a"] = 6,
    ["b"] = 2,
    ["fin"] = infinity
};
var parents = new Dictionary<string, string>
{
    ["a"] = "start",
    ["b"] = "start",
    ["fin"] = string.Empty
};
var processed = new List<string>();

var node = FindLowestCostNode(costs);
while (node != string.Empty)
{
    var cost = costs[node];
    var neighbors = graph[node];
    foreach (var neighbor in neighbors)
    {
        var newCost = cost + neighbor.Value;
        if (newCost < costs[neighbor.Key])
        {
            costs[neighbor.Key] = newCost;
            parents[neighbor.Key] = node;
        }
    }

    processed.Add(node);
    node = FindLowestCostNode(costs);
}

Console.WriteLine(string.Join(", ", costs));
Console.WriteLine(string.Join(", ", parents));
var current = "fin";
var path = new List<string> { current };
while (current != "start")
{
    current = parents[current];
    path.Add(current);
}
path.Reverse();
Console.WriteLine(string.Join(" --> ", path));

string FindLowestCostNode(Dictionary<string, int> costs)
{
    var unprocessed = costs.Where(kvp => !processed.Contains(kvp.Key)).ToList();

    if (unprocessed.Count == 0)
    {
        return string.Empty;
    }
    
    return unprocessed.MinBy(kvp => kvp.Value).Key;
}

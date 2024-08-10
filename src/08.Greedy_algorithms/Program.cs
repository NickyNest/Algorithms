Console.WriteLine("Greedy algorithms");

var statesNeeded = new HashSet<string> {"mt", "wa", "or", "id", "nv", "ut", "ca", "az"};
var stations = new Dictionary<string, HashSet<string>>
{
    ["k1"] = new HashSet<string> {"id", "nv", "ut"},
    ["k2"] = new HashSet<string> {"wa", "id", "mt"},
    ["k3"] = new HashSet<string> {"or", "nv", "ca"},
    ["k4"] = new HashSet<string> {"nv", "ut"},
    ["k5"] = new HashSet<string> {"ca", "az"},
};
var finalStations = new HashSet<string> {};

while (statesNeeded.Any())
{
    var bestStation = string.Empty;
    var statesCovered = new HashSet<string>();

    foreach (var station in stations)
    {
        var covered = new HashSet<string>(statesNeeded.Intersect(station.Value));
        if (covered.Count() > statesCovered.Count)
        {
            bestStation = station.Key;
            statesCovered = covered;
        }
    }

    statesNeeded.RemoveWhere(s => statesCovered.Contains(s));
    stations.Remove(bestStation);
    finalStations.Add(bestStation);
}

Console.WriteLine(string.Join(", ", finalStations));

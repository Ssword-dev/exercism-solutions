public static class Dominoes
{
    public static bool CanChain(IEnumerable<(int, int)> dominoes)
    {
        var enumerator = dominoes.GetEnumerator();

        // no items.
        if (!enumerator.MoveNext()) {
            return true;
        }

        // A map of nodes and its neighbors, for traversing and
        // degree evaluation.
        var map = new Dictionary<int, List<int>>();

        // The set of nodes not visited, so that we can check if
        // we already visited a node.
        // the reason why this is not a 'visited' node set because
        // we need to know if there are any disconnected nodes, if there are,
        // then it is not going to be visited.
        var notYetVisited = new HashSet<int>();

        // The reason why the first domino is special is
        // because we picked the first node in the first domino in advance
        // to test for accessibility.
        var firstDomino = enumerator.Current;
        RegisterDomino(firstDomino);

        while (enumerator.MoveNext()) {
            RegisterDomino(enumerator.Current);
        }

        // Registers the dominoes, makes them workable.
        void RegisterDomino((int a, int b) domino)
        {
            var (a, b) = domino;

            map.TryAdd(a, []);
            map.TryAdd(b, []);

            map[a].Add(b);
            map[b].Add(a);
            notYetVisited.Add(a);
            notYetVisited.Add(b);
        }

        bool AllNodesAreAccessibleFromTheFirstNode() {
            var queue = new Queue<int>();

            queue.Enqueue(firstDomino.Item1);

            while (queue.TryDequeue(out var node)) {
                if (!notYetVisited.Contains(node)) continue;

                notYetVisited.Remove(node);

                foreach (var neighbor in map[node]) {
                    queue.Enqueue(neighbor);
                }
            }

            return notYetVisited.Count == 0;
        }

        bool AllNodesHaveAnEvenDegree() {
            return map.All(kv => kv.Value.Count % 2 == 0);
        }

        return AllNodesHaveAnEvenDegree() && AllNodesAreAccessibleFromTheFirstNode();
    }
}
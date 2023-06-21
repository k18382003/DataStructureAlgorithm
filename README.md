# Learning and explaining Algorithms and Data Structure by C#

## BigO

- It’s a language we use for talking about how long an algorithm takes to run.
- Big O doesn’t measure things in seconds, it’s focusing on how quickly our runtime grows.
- We can measure the code scalability by using the input size and comparing it to the operations that increase.

### Four rules of BigO

- Rule 1: Worst case - We should always think the worst senarios.
- Rule 2: Remove Constants - The constant won't affect the runtime too much, we only care about how the runtime growth will shows on the graph(linear or curve). When it is `O(2n + 1000000)`, we will consider it is `O(n)`.
- Rule 3: Different terms of inputs - The example below, we need to consider all the input may have significant impact to our runtime. So, the BigO will be `O(a + b)` instead of `O(n)`.

```cs
    public void printBoxlabel(List<string> Boxes1, List<string> Boxes2)
    {
        foreach(var label in Boxes1)
            Console.WriteLine(label);
        foreach(var label in Boxes2)
            Console.WriteLine(label);
    }
```

- Rule 4: Drop Non Dominants - The example below, the BigO would be `O(n + n^2)`, but we will always drop non dominants, so the BigO in this case is `O(n^2)`.

```cs
    public void printBoxlabelandLablePair(List<string> Boxes1)
    {
        foreach(var label in Boxes1)
            Console.WriteLine(label);
        foreach(var label in Boxes1)
        {
            foreach(var labe2 in Boxes1)
                Console.WriteLine(label + " " + label2);
        }
    }
```

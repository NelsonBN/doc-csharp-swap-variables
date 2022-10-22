BenchmarkRunner.Run<SwapPrimitivesBenchmarks>();
BenchmarkRunner.Run<SwapClassesBenchmarks>();

[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class SwapPrimitivesBenchmarks
{
    public int A = 20;
    public int B = 30;

    [Benchmark(Baseline = true)]
    public void ClassicMethod()
    {

        var aux = A;
        A = B;
        B = aux;
    }

    [Benchmark]
    public void TupleMethod()
    {
        (A, B) = (B, A);
    }
}




[MemoryDiagnoser]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[RankColumn]
public class SwapClassesBenchmarks
{
    public DemoPerson A = new DemoPerson { Name = "Chris", Age = 35 };
    public DemoPerson B = new DemoPerson { Name = "Jane", Age = 40 };

    [Benchmark(Baseline = true)]
    public void ClassicMethod()
    {

        var aux = A;
        A = B;
        B = aux;
    }

    [Benchmark]
    public void TupleMethod()
    {
        (A, B) = (B, A);
    }

    public class DemoPerson
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString() => $"Name = {Name}, Age = {Age}";
}
}

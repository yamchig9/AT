int M = 1;
int N = 10;

PrintNumbersBetween(M, N);

void PrintNumbersBetween(int m, int n)
{
    if (m <= n)
    {
        Console.Write(m + " ");
        PrintNumbersBetween(m + 1, n);
    }
}
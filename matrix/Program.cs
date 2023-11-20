using System.Drawing;

bool sym = true;
int n = Convert.ToInt32(Console.ReadLine());
int[,] nums = new int[n, n];
int[,] trans = new int[n, n];
if (n <= 100)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            nums[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (nums[i, j] != nums[j, i])
            {
                sym = false;
                break;
            }
        }
    }

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            trans[i, j] = nums[j, i];
            Console.Write(trans[i, j]);

            if (j == n - 1)
                Console.WriteLine();
        }
    }
}
else
{
    Console.WriteLine("Число не соответствует условию");
}

Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(nums[i, j]);
    }
    Console.WriteLine();

}

if (equalCheck())
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}

Console.ReadLine();
bool equalCheck()
{
    bool trigger = true;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (!(nums[i, j] == trans[i, j])) trigger = false;
        }
    }
    return trigger;
}
int TT(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array = { 1, 56, 3, 57, 89, 6, 12, 8, 987654321 };
array[0] = 12;

//int max1 = TT (a1, b1, c1);
//int max2 = TT (a2, b2, c2);
//int max3 = TT (a3, b3, c3);

int result = TT(TT(array[0], array[1], array[2]), TT(array[3], array[4], array[5]), TT(array[6], array[7], array[8]));

Console.WriteLine(result);
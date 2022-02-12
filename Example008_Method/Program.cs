int TT(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 23;
int b1 = 99;
int c1 = 23;
int a2 = 54;
int b2 = 23;
int c2 = 2;
int a3 = 54;
int b3 = 89;
int c3 = 987;


//int max1 = TT (a1, b1, c1);
//int max2 = TT (a2, b2, c2);
//int max3 = TT (a3, b3, c3);

int maxM = TT(TT(a1, b1, c1), TT(a2, b2, c2), TT(a3, b3, c3));

Console.WriteLine(maxM);

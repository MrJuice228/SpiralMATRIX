/*
int counter=0;
bool[]a=new bool[150000];
for(int  i = 0; i < 2000000;i++)
{
    a[i]=true;
}
a[0]=false;
a[1]=false;
for(int i = 2;i<2000000;i++)
{
    for(int j = i + i;j<2000000;j+=i)
    {
        a[j]=false;
    }
}
for(int i = 0;i<2000000;i++)
{

}

long ans=1;
long maxn=0;
string n = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
for(int i = 0; i<n.Length-12;i++)
{
    ans = 1;
    for(int k =i;k<i+13;k++)
    {
    ans = ans * Convert.ToInt32(Convert.ToString(n[k]));
    }
    if(ans>maxn)
    {
        maxn=ans;
    }
}
Console.WriteLine(maxn);

int c=0;
for(int i = 100;i<700;i++)
{
    for(int j = 200;j<500;j++)
    {
        c= i*i+j*j;
        if(i+j+Math.Sqrt(c)==1000)
        {
            Console.WriteLine($"{i} {j} {Math.Sqrt(c)}");
            Console.WriteLine(i*j*Math.Sqrt(c));
        }
    }
}

int counter=0;
long ans=0;
bool[]a=new bool[2000000];
for(int  i = 0; i < 2000000;i++)
{
    a[i]=true;
}
a[0]=false;
a[1]=false;
for(int i = 2;i<2000000;i++)
{
    for(int j = i + i;j<2000000;j+=i)
    {
        a[j]=false;
    }
}
for(int i = 0;i<2000000;i++)
{
if (a[i]==true)
{
    ans+=i;
}
}
Console.WriteLine(ans);

void GenArr(int [,]a,int a ,int b)
{
}
*/
void PrintArray(int k, int l, int [,]a)
{
for(int i = 0; i < k;i++)
    {
        for(int j = 0;j<l;j++)
        {
            Console.Write($"{a[i,j]}\t");
        }
        Console.WriteLine("\n");
    }
    Console.WriteLine("\n");
}
void GenArr(int k, int l, int [,]a)
{
    for(int i = 0;i<k;i++)
    {
        for(int j = 0; j <l;j++)
        {
            a[i,j]=0;
        }
    }
}
void OrganizeArray(int k, int l, int [,]a)
{
    int GlobalCounter = k*l;
    int i1 = 0;
    int j1=0;
    int counter = 1;
    while(true)
{
        if(GlobalCounter<counter)
        {
            break;
        }
    for(int j = j1;j<l;j++) //right
    {
         if(j==l-1 || a[i1,j]!=0)
        {
            break;
        }
        a[i1,j]=counter;
        counter++;
        PrintArray(k,l,a);
       
    }
    for(int i = i1; i<k; i++) // down
    {
        if(i==k-1 || a[l-1,i]!=0)
        {
            break;
        }
        a[i, l-1]=counter;
        counter++;
        PrintArray(k,l,a);
        
    }
    for(int j = l-1;j>0;j--) // left
    {
        if(j==0 || a[k-1,j-1]!=0)
        {
            break;
        }
        a[k-1,j]=counter;
        counter++;
        PrintArray(k,l,a);
    }
    for(int i = k; i>0;i--) // up
    {
        if(i==0 || a[i-1,j1]!=0)
        {
            break;
        }
        a[i-1,j1]=counter;
        counter++;
        PrintArray(k,l,a);
    }
    i1++;
    j1++;
    k--;
    l--;

}
}
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
int [,]a= new int[n1,n2];
GenArr(n1,n2,a);
OrganizeArray(n1,n2,a);
PrintArray(n1,n2,a);

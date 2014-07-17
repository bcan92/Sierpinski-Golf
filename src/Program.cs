namespace System.Linq{using _=String;class P{static void Main(_[]a){
int v=1<<int.Parse(a[0]),u=++v;var b=new bool[u];b[0]=1>0;
for(;v-->1;){_ s=new _(' ',v);Console.WriteLine(s+_.Concat(b.Select(
n=>n?@"/\":"  ")));b=b.Select((n,k)=>k<=u-v&k>0?n^b[k-1]:n).ToArray();}}}}